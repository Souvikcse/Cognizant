using System.Collections.Generic;

namespace MagicFilesLib
{
    public interface IDirectoryExplorer
    {
        ICollection<string> GetFiles(string path);

    }
}
