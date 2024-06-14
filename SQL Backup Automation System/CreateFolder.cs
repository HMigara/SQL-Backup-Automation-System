using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SQL_Backup_Automation_System
{
    public class CreateFolder
    {
        public void CreateFolderAndFile(string folderPath, string fileName, string content)
        {
            // Combine the folder path and file name to get the full file path
            string filePath = Path.Combine(folderPath, fileName);

            // Check if the directory exists, if not, create it
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                File.WriteAllText(filePath, content);
            }

            
            string Txtdata = File.ReadAllText(filePath);


            if (string.IsNullOrEmpty(Txtdata))
            {
                File.WriteAllText(filePath, content);
            }

            if (Txtdata != content)
            {
                File.WriteAllText(filePath, content);
            }
            
            
        }
    }
}
