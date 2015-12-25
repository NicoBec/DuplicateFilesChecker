using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDoubleChecker.Domain
{
    class FolderFilesChecker
    {
        public void scanFolder(string Path)
        {
            FolderObj Fold = new FolderObj();
            Fold.scanFolders(Path);

            var t = FilesStore.ListOfFiles;
            var ext = (FilesStore.ListOfFiles.Select(x => x.Extention).ToList()).Distinct();
        }
    }
}
