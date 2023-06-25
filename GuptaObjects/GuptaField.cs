using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaField : GuptaObject
 {

  internal GuptaObject parent;
  internal List<string> props;

  internal GuptaField(GuptaObject parent_, string line, List<string> block)
  {
   parent = parent_;
   props = block;
   name = AptUtils.ResolveValue(block[block.IndexOf(line)]);
  }
 }
}
