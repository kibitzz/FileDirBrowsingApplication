using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorerApp.Entities;
using System.IO;

namespace FileExplorerApp.Repository
{

    /*  Принцип інве́рсії зале́жностей(англ.Dependency Inversion Principle, DIP) —
     *   один з п'яти SOLID-принципів об'єктно-орієнтованого проектування програм, 
     *   суть якого полягає у розриві зв'язності між програмними модулями вищого 
     *   та нижчого рівнів за допомогою спільних абстракцій.

  Принцип формулюється наступним чином:

  Модулі вищого рівня не повинні залежати від модулів нижчого рівня.
  Всі вони повинні залежати від абстракцій.

  Абстракції не повинні залежати від деталей реалізації.
  Деталі реалізації повинні залежати від абстракцій.

  */
    //A repository is an object that encapsulates the data layer, 
    //and contains logic for retrieving data and mapping it to an entity model. 
    public class FileSystemBrowser : IFileSystem
    {
        public static string systemRootAlias = "root";
        public static int instancesCounter;
        public int _instanceIdx;
        public int instanceIdx
        {
            get { return _instanceIdx; }
        }

        public FileSystemBrowser()
        {
            _instanceIdx = instancesCounter;
            instancesCounter++;
        }
        

        public List<FileDir> GetDirectoryFiles(string dirPath)
        {           
            DirectoryInfo d = new DirectoryInfo(dirPath);
            if (d.Exists)
            {               
                FileInfo[] fInf = d.GetFiles();
                List<FileDir> rez = new List<FileDir>( fInf.Length);
              
                foreach (FileInfo f in fInf)
                {
                    FileDir fd = new FileDir();
                    fd.Name = f.Name;
                    fd.Length = f.Length;
                    rez.Add(fd);
                }

                return rez;
            }

            return new List<FileDir>(); ;
        }

        public List<FileDir> GetDirectorySubDirs(string dirPath)
        {           
            DirectoryInfo d = new DirectoryInfo(dirPath);
            if (d.Exists)
            {

                DirectoryInfo[] dirInf = d.GetDirectories();              
                List<FileDir> rez = new List<FileDir>(dirInf.Length );

                foreach (DirectoryInfo di in dirInf)
                {
                    FileDir fd = new FileDir();
                    fd.Name = di.Name;
                    fd.isDir = true;
                    rez.Add(fd);
                }
              
                return rez;
            }

            if (dirPath == systemRootAlias)
            {
                String[] drives = Environment.GetLogicalDrives();
                List<FileDir> rez = new List<FileDir>(drives.Length);
                foreach (string di in drives)
                {
                    FileDir fd = new FileDir();
                    fd.Name = di;
                    fd.isDir = true;
                    rez.Add(fd);
                }
                return rez;
            }

            return new List<FileDir>();

        }

        public string GetParentDirectory(string dirPath)
        {
            DirectoryInfo d = new DirectoryInfo(dirPath);
            if (d.Exists && d.Parent != null)
            {
                return d.Parent.Exists ? d.Parent.FullName : systemRootAlias;
            }
            return "";
        }

        public bool PathExists(string dirPath)
        {
            DirectoryInfo d = new DirectoryInfo(dirPath);           
            if (d.Exists || dirPath == systemRootAlias)
            {
                return true;
            }

            return false;           
        }
    }
}
