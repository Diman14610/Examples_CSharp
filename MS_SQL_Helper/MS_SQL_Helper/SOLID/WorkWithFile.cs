using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;

namespace MS_SQL_Helper.SOLID
{
    class WorkWithFile
    {
        private string Path { get; set; }
        private string Content { get; set; }

        public WorkWithFile(string path, string content)
        {
            Path = path;
            Content = content;
        }

        public virtual bool WriteAllInFile()
        {
            using (StreamWriter sw = new StreamWriter(Path, true))
            {
                sw.WriteLine(Content);
            }
            return true;
        }
    }

     class WorkWithExcel : WorkWithFile
    {
        private string Path { get; set; }
        private string Content { get; set; }

        public WorkWithExcel(string path, string content) : base(path, content)
        {
            Path = path;
            Content = content;
        }

        public override bool WriteAllInFile()
        {
            return base.WriteAllInFile();
        }
    }
}
