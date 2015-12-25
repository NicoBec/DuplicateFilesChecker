using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FilesDoubleChecker.Domain
{
    public class FileObj
    {
        public string fullPath = "";
        public string FileName = "";
        public string Extention = "";
        public int size = 0;
        FileInfo oFileInfo = null;
        public void initFilesInfo()
        {
            if (!string.IsNullOrEmpty(fullPath))
            {
                oFileInfo = new FileInfo(fullPath);
                FileName = oFileInfo.Name;
                if (oFileInfo.Extension.Length > 1)
                {
                    Extention = oFileInfo.Extension.Substring(1).ToUpper();
                }

            }
        }

    }
}
