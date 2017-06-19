using System;
using System.Collections.Generic;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace GTR2LauncherExe {
    class Program {
        static void Main(string[] args) {
            ProcessStartInfo psi = new ProcessStartInfo("GTR2.exe") {

            };
            Process p = Process.Start(psi);
            p.WaitForExit();
        }
    }
}
