using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDoubleChecker.Domain
{
    class FolderObj
    {
        List<FolderObj> Folders = new List<FolderObj>();
        List<FileObj> Files = new List<FileObj>();
    }
}
