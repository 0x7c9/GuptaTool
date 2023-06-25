using GuptaTool.GuptaObjects;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.LinkLabel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuptaTool
{
 internal class GuptaParserExt
 {


  internal List<GuptaTable> tables;
  internal List<GuptaForm> forms;
  internal List<GuptaDialog> dialogs;
  internal List<GuptaBlock> basicBlocks;

  internal GuptaParserExt()
  {
   basicBlocks = new List<GuptaBlock>();
   tables = new List<GuptaTable>();
   forms = new List<GuptaForm>();
   dialogs = new List<GuptaDialog>();
  }

  internal void ParseFile(string[] lines)
  {
   basicBlocks = ParseBasicBlocks(lines);
   basicBlocks.AddRange(ParseChildTables(lines));
   ProcessBlocks(basicBlocks);
  }

  private void ProcessBlocks(List<GuptaBlock> blocks)
  {

   foreach (var block in blocks)
   {
    switch (block.blockType)
    {
     case BlockType.TableWindow:
      tables.Add(new GuptaTable(block.contents));
      break;
     case BlockType.FormWindow:
      forms.Add(new GuptaForm(block.contents));
      break;
     case BlockType.DialogBox:
      dialogs.Add(new GuptaDialog(block.contents));
      break;
     case BlockType.ChildTable:
      tables.Add(new GuptaTable(block.contents));
      break;
    }
   }

  }

  internal List<GuptaTable> GetTablesWhereColumnUsed(string columnName)
  {
   List<GuptaTable> result = new List<GuptaTable>();
   foreach (var window in tables)
   {
    foreach (var column in window.columns)
    {
     if (column.name == columnName)
      result.Add(window);
    }
   }
   if (result.Count > 0)
   {
    return result;
   }
   return null;
  }

  internal List<GuptaObject> GetFormsWhereFieldUsed(string columnName)
  {
   List<GuptaObject> result = new List<GuptaObject>();
   foreach (var window in forms)
   {
    foreach (var column in window.fields)
    {
     if (column.name == columnName)
      result.Add(window);
    }
   }
   foreach (var window in dialogs)
   {
    foreach (var column in window.fields)
    {
     if (column.name == columnName)
      result.Add(window);
    }
   }
   if (result.Count > 0)
   {
    return result;
   }
   return null;
  }


  internal List<GuptaColumn> GetColumnsFromName(string columnName)
  {
   List<GuptaColumn> columns = new List<GuptaColumn>();

   foreach (var window in tables)
   {
    foreach (var column in window.columns)
    {
     if (columnName == column.name)
      columns.Add(column);
    }
   }
   return columns;
  }

  internal List<GuptaBlock> ParseBasicBlocks(string[] lines)
  {
   List<GuptaBlock> blocks = new List<GuptaBlock>();
   List<int> indexes = new List<int>();
   for (int i = 0; i < lines.Length; i++)
   {
    if (lines[i].Contains(".head 1 +"))
    {
     indexes.Add(i);
    }
   }
   for (int j = 0; j < indexes.Count; j++)
   {
    int lenght = -1;

    if (j == indexes.Count - 1)
     lenght = indexes[j] - indexes[j - 1];
    else
     lenght = indexes[j + 1] - indexes[j];

    List<string> block = lines.ToList().Skip(indexes[j]).Take(lenght).ToList();

    GuptaBlock guptaBlock = new GuptaBlock(block);

    switch (j)
    {
     case 0:
      guptaBlock.blockType = BlockType.DesingTimeSettings;
      break;
     case 1:
      guptaBlock.blockType = BlockType.Libraries;
      break;
     case 2:
      guptaBlock.blockType = BlockType.GlobalDeclarations;
      break;
     case 3:
      guptaBlock.blockType = BlockType.DesignHistory;
      break;
     default:
      guptaBlock.blockType = ResolveBlock(guptaBlock.contents[0]);
      break;
    }
    blocks.Add(guptaBlock);
   }
   return blocks;
  }

  private List<GuptaBlock> ParseChildTables(string[] lines)
  {
   List<GuptaBlock> blocks = new List<GuptaBlock>();
   List<int> indexes = new List<int>();
   for (int i = 0; i < lines.Length; i++)
   {
    if (lines[i].Contains(".head 3 +  Child Table:"))
    {
     indexes.Add(i);
    }
   }


   for (int j = 0; j < indexes.Count; j++)
   {
    int lenght = -1;

    if (indexes.Count == 1)
     lenght = lines.Length - indexes[j];
    else if (j == indexes.Count - 1)
     lenght = indexes[j] - indexes[j - 1];
    else
     lenght = indexes[j + 1] - indexes[j];

    List<string> block = lines.ToList().Skip(indexes[j]).Take(lenght).ToList();

    GuptaBlock guptaBlock = new GuptaBlock(block);

    guptaBlock.blockType = ResolveBlock(guptaBlock.contents[0]);
    blocks.Add(guptaBlock);
   }

   return blocks;
  }



  private BlockType ResolveBlock(string line)
  {
   if (line.Contains("Form Window"))
    return BlockType.FormWindow;
   if (line.Contains("Table Window"))
    return BlockType.TableWindow;
   if (line.Contains("Dialog Box"))
    return BlockType.DialogBox;
   if (line.Contains("Child Table"))
    return BlockType.ChildTable;
   throw new NotImplementedException();
  }


 }
}
