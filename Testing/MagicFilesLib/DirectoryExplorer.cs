using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MagicFilesLib
{
    public class DirectoryExplorer : IDirectoryExplorer
    {
        public ICollection<string> GetFiles(string path)
        {

            string[] files = Directory.GetFiles(path);

            return files;

        }
    }

}
