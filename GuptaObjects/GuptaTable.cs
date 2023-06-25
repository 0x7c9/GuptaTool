using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaTable
 {


  internal string windowName;
  internal List<GuptaColumn> columns;

  internal GuptaTable(List<string> block)
  {
   columns = new List<GuptaColumn>();
   windowName = AptUtils.ResolveValue(block[0]);
   ResolveColums(block);
  }

  private void ResolveColums(List<string> block)
  {

   List<int> indexes = new List<int>();

   for(int i = 0; i < block.Count; i++)
   {
    if (AptUtils.IsColumnMarker(block[i]))
    {
     indexes.Add(i);
    }
   }

   for (int j = 0; j < indexes.Count; j++)
   {
    int index = indexes[j];
    List<string> buffer = new List<string>();
    while (block[index] != ".enddata")
    {
     buffer.Add(block[index]);
     index--;
    }
    buffer.Reverse();
    columns.Add(new GuptaColumn(this, block[indexes[j]], buffer));
   }

  }


 }
}
