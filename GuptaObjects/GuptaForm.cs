using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaForm
 {
  internal string name;
  internal List<GuptaField> fields;
  internal GuptaForm(List<string> block)
  {
   fields = new List<GuptaField>();
   name = AptUtils.ResolveValue(block[0]);
  }
 }
}
