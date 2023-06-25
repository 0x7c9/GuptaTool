using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GuptaTool.GuptaObjects
{
 internal class GuptaBlock
 {
  internal List<string> contents;
  internal BlockType blockType;

  internal GuptaBlock(List<string> contents_)
  {
   contents = contents_;
  }

 }
}
