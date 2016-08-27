using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using FileExplorerApp.Entities;

namespace FileExplorerApp.Repository
{
    public interface IFileSystem
    {
        //List<User> GetUsers(int userIdToExclude);
        //bool UserExists(string userName);
        //void CreateUser(User user);
        int instanceIdx
        { get; }

        List<FileDir> GetDirectoryFiles(string dirPath);

        List<FileDir> GetDirectorySubDirs(string dirPath);

        bool PathExists(string dirPath);

        string GetParentDirectory(string dirPath);

    }
}
