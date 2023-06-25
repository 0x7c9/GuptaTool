using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaDialog : GuptaObject
 {
  internal List<GuptaField> fields;
  internal GuptaDialog(List<string> block)
  {
   fields = new List<GuptaField>();
   name = AptUtils.ResolveValue(block[0]);
   ResolveFields(block);
  }


  private void ResolveFields(List<string> block)
  {

   List<int> indexes = new List<int>();

   for (int i = 0; i < block.Count; i++)
   {
    if (AptUtils.IsDataFieldMarker(block[i]))
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
    fields.Add(new GuptaField(this, block[indexes[j]], buffer));
   }

  }


 }
}
