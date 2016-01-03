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
        public string Extension = "";
        public long size = 0;
        FileInfo oFileInfo = null;
        public void initFilesInfo()
        {
            if (!string.IsNullOrEmpty(fullPath))
            {
                oFileInfo = new FileInfo(fullPath);
                FileName = oFileInfo.Name;
                size = oFileInfo.Length;
                if (oFileInfo.Extension.Length > 1)
                {
                    Extension = oFileInfo.Extension.Substring(1).ToUpper();
                   
                }

            }
        }
        public string toString()
        {
            string delim = FilesStore.CSVDelimenator;
            return fullPath.RemoveCSVDeliminator() + delim + FileName.RemoveCSVDeliminator() + delim + Extension.RemoveCSVDeliminator() + delim + size + delim + oFileInfo.CreationTime.ToString().RemoveCSVDeliminator();
        }
        public string toStringHeader()
        {
            string delim = FilesStore.CSVDelimenator;
            return "fullPath" + delim + "FileName" + delim + "Extension" + delim + "size" + delim + "CreationTime";
        }
    }
}
