using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;
using System.IO;

namespace batlaunch
{
  class Program
  {
    static void Main(string[] args) {
			Console.Title = "BatLaunch";
			
			// retval only includes a bkslash if in drive's root
			string dir = Environment.CurrentDirectory;
			char c = dir[dir.Length - 1];
			string filename;
			if(c.Equals(@"\")) { 
				filename = dir + @".bat\batlaunch.bat";
			} else {
				filename = dir + @"\.bat\batlaunch.bat";
			}

			ProcessStartInfo startInfo = new ProcessStartInfo(filename);
			startInfo.WindowStyle = ProcessWindowStyle.Minimized;

			try {
				Process.Start(startInfo);
			} catch(Exception) {
				Console.WriteLine("Could not find file batlaunch.bat in subfolder \\.bat\n");
				Console.WriteLine("Expected:\n");
				Console.WriteLine(" any-folder");
				Console.WriteLine(" ├─batlaunch.exe");
				Console.WriteLine(" └─.bat");
				Console.WriteLine("    └─ batlaunch.bat\n");
				Console.WriteLine(">>> Press any key to terminate console. <<<");
				Console.ReadKey();
			}

    }
  }
}
