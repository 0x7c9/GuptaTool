using GuptaTool.Forms;
using GuptaTool.GuptaObjects;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GuptaTool
{
 internal class Program
 {
  [STAThread]
  static void Main(string[] args)
  {

   Application.EnableVisualStyles();
   Application.Run(new MainForm());

   //string[] lines = File.ReadAllLines("RoutTemplate.apt");
   //GuptaParser parser = new GuptaParser();
   //parser.FindWindows(lines);
   //GuptaWindow window = parser.GetWindowFromComlumn("colActiveOperation");

   //string form = parser.FindFormFromColumnName("colActiveOperation", lines);
   //parser.ParseWindow(form,lines);

  }


  

 }
}
