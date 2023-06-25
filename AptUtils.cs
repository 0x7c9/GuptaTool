using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using static System.Windows.Forms.LinkLabel;

namespace GuptaTool
{
 internal class AptUtils
 {


  internal static bool IsColumnMarker(string line)
  {
   if (line.Contains(".head 3 +  Column:"))
    return true;
   return false;
  }

  internal static bool IsDataFieldMarker(string line)
  {
   if (line.Contains(".head 3 +  Data Field:"))
    return true;
   return false;
  }


  internal static string ResolveValue(string line)
  {
   return line.Split(':').ToArray()[1].Replace(" ","");
  }

 }
}
