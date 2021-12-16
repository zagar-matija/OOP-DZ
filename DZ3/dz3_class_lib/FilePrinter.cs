using System;
using System.Collections.Generic;
using System.Text;
using System.IO;

namespace dz3_class_lib
{
    public class FilePrinter : IPrinter
    {
        private string fileName;

        public FilePrinter(string fileName)
        {
            this.fileName = fileName;
        }
        public void Log(string message)
        {
            using (StreamWriter sw = File.AppendText(fileName))
            {
                    sw.WriteLine(message);
            }
        }
        public void SetFileName(string fileName)
        {
            this.fileName = fileName;
        }
    }
}
