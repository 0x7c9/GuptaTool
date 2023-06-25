using GuptaTool.GuptaObjects;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.TextBox;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GuptaTool.Forms
{
 public partial class MainForm : Form
 {
  GuptaParserExt guptaParser;
  public MainForm()
  {
   InitializeComponent();
   this.Load += MainForm_Load;
  }

  private void MainForm_Load(object sender, EventArgs e)
  {
   guptaParser = new GuptaParserExt();
  }

  private void openToolStripMenuItem_Click(object sender, EventArgs e)
  {
   OpenFileDialog fileDialog = new OpenFileDialog();
   fileDialog.Multiselect = true;
   switch(fileDialog.ShowDialog())
   {
    case DialogResult.OK:
     if(fileDialog.FileNames.Length > 0)
     {
      ProcessFiles(fileDialog.FileNames);
     }  
     break;
   }
  }

  private void ProcessFiles(string[] fileNames)
  {
   foreach (var file in fileNames)
   {
    if (Path.GetExtension(file) == ".apt")
    {
     string[] files = File.ReadAllLines(file);
     guptaParser = new GuptaParserExt();
     guptaParser.ParseFile(files);
     PrintWindows();
     
    }
    else
    {
     Error($"Invalid file: {file}");
    }
   }
   ShowStructure();
  }

  private void Error(string content)
  {
   txtResult.Text += content+ "\r\n";
  }

  private void PrintWindows()
  {
   txtResult.ForeColor = Color.Green;
   foreach (var window in guptaParser.tables)
   {
    txtResult.Text += $"Found Table: {window.windowName} , columns: {window.columns.Count}\r\n";
   }
   foreach (var window in guptaParser.forms)
   {
    txtResult.Text += $"Found Form: {window.name} , fields: {window.fields.Count}\r\n";
   }

   foreach (var window in guptaParser.dialogs)
   {
    txtResult.Text += $"Found Dialog: {window.name} , fields: {window.fields.Count}\r\n";
   }
  }

  private void ShowStructure()
  {
   foreach(var table in guptaParser.tables)
   {
    TreeNode parent = new TreeNode(table.windowName);
    var TreeNodesList = new List<TreeNode>();
    foreach (var col in table.columns)
    {
     TreeNodesList.Add(new TreeNode(col.name));
    }
    foreach(var entry in TreeNodesList)
    {
     parent.Nodes.Add(entry);
    }
    treeStructure.Nodes.Add(parent);
   }
  }

  private void txtColumnQuery_TextChanged(object sender, EventArgs e)
  {
   txtResult.Text = String.Empty;
   if (guptaParser.tables == null)
    return;
   if(guptaParser.tables.Count > 0)
   {
    if (txtColumnQuery.Text.Length > 0)
    {
     List<GuptaTable> windows = guptaParser.GetTablesWhereColumnUsed(txtColumnQuery.Text);
     if (windows != null)
     {
      foreach(var window in windows)
      {
       txtResult.ForeColor = Color.Orange;
       txtResult.Text = $"{txtColumnQuery.Text} is located at: {window.windowName}\r\n";
      }
     }
     else
     {
      txtResult.Text = "Nothing found!";
     }
    }
   }

  }



  private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
  {
   MessageBox.Show("Codded by 0x7c9 2023","About..",MessageBoxButtons.OK, MessageBoxIcon.Information);
  }

  private void txtQueryCollumnDetail_TextChanged(object sender, EventArgs e)
  {
   txtResult.Text = String.Empty;
   if (guptaParser.tables == null)
    return;
   if (guptaParser.tables.Count > 0)
   {
    if (txtQueryCollumnDetail.Text.Length > 0)
    {
     List<GuptaColumn> columns = guptaParser.GetColumnsFromName(txtQueryCollumnDetail.Text);
     if (columns != null)
     {
      foreach (var col in columns)
      {
       PrintColumnInfo(col);
       txtResult.Text += "\r\n";
      }
     }
     else
     {
      txtResult.Text = "Nothing found!";
     }
    }
   }
  }

  private void PrintColumnInfo(GuptaColumn column)
  {
   txtResult.ForeColor = Color.Orange;
   txtResult.Text = $"{column.name} is located at: {column.parent.windowName}\r\n";
   foreach (var prop in column.props)
   {
    txtResult.Text += prop + "\r\n";
   }
  }

  private void treeStructure_NodeMouseDoubleClick(object sender, TreeNodeMouseClickEventArgs e)
  {
   string name = treeStructure.SelectedNode.Text;
   if(name.Contains("col"))
   {
    GuptaColumn col = null;

    foreach(var table in guptaParser.tables)
    {
     foreach(var column in table.columns)
     {
      col = column;
      break;
     }
    }

    if(col != null)
    {
     PrintColumnInfo(col);
    }
    
   }



  }
 }
}
