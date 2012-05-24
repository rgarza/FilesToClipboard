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
                StringCollection paths = new StringCollection();
                foreach (var file in args)
                {
                    if (File.Exists(file) || Directory.Exists(file))
                    {                       
                        paths.Add(file);                       
                    }
                }
                Clipboard.SetFileDropList(paths);
            }
        }
    }
}
