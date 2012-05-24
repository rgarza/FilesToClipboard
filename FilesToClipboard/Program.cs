using System;
using System.Collections.Generic;
using System.Text;
using System.IO;
using System.Windows.Forms;
using System.Collections.Specialized;

namespace FilesToClipboard
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main(String [] args)
        {
            if (args.Length > 0)
            {
                String file = args[0];
                if (File.Exists(file) || Directory.Exists(file))
                {
                    StringCollection paths = new StringCollection();
                    paths.Add(file);
                    Clipboard.SetFileDropList(paths);
                }
            }
        }
    }
}
