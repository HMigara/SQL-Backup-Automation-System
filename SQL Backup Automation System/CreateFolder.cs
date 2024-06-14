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
        public void CreateFolderAndFile(string folderPath, string fileName, string Pathcontent, string TimefileName, string Timecontent)
        {
            // Combine the folder path and file name to get the full file path
            string FilePath = Path.Combine(folderPath, fileName);
            String TimePath = Path.Combine(folderPath,TimefileName);

            // Check if the directory exists, if not, create it
            if (!Directory.Exists(folderPath))
            {
                Directory.CreateDirectory(folderPath);
                File.WriteAllText(FilePath, Pathcontent);
                File.WriteAllText(TimePath, Timecontent);
            }

            
            string TxtPathdata = File.ReadAllText(FilePath);
            string TxtTimedata = File.ReadAllText(TimePath);


            if (string.IsNullOrEmpty(TxtPathdata))
            {
                File.WriteAllText(FilePath, Pathcontent);
                File.WriteAllText(TimePath, Timecontent);
            }

            if (TxtPathdata != Pathcontent)
            {
                File.WriteAllText(FilePath, Pathcontent);      
            }

            if(TxtTimedata != Timecontent)
            {
                File.WriteAllText(TimePath, Timecontent);
            }
            
            
        }
    }
}
