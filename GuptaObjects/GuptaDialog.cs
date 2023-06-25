using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaDialog
 {
  internal string name;
  internal List<GuptaField> fields;
  internal GuptaDialog(List<string> block)
  {
   fields = new List<GuptaField>();
   name = AptUtils.ResolveValue(block[0]);
  }

 }
}
