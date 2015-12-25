using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDoubleChecker.Domain
{
    class FolderObj
    {
        public string path = "";
        List<FolderObj> Folders = new List<FolderObj>();
        List<FileObj> Files = new List<FileObj>();

        public bool scanFolders(string _path = null)
        {
            if (!string.IsNullOrEmpty(_path))
            {
                path = _path;
            }
            if (!string.IsNullOrEmpty(path))
            {
                var files = Directory.GetFiles(path);
                Files = files.Select(x => new FileObj() { fullPath = x }).ToList();
                foreach (var item in Files)
                {
                    item.initFilesInfo();
                }
                FilesStore.ListOfFiles.AddRange(Files.Where(x => FilesStore.videoExtentionList.Contains(x.Extention)));

                var Dirs = Directory.GetDirectories(path);
                Folders = Dirs.Select(x => new FolderObj() { path = x }).ToList();
                foreach (var item in Folders)
                {
                    item.scanFolders();
                }

            }
            else
            {
                return false;
            }
            return true;
        }
    }
}
