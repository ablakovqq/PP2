using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
namespace Task3
{
    class Program
    {
        static void rec(DirectoryInfo dir, string level)
        {
            Console.WriteLine(level + dir.Name);
            level += "    ";
            FileSystemInfo[] fs = dir.GetFileSystemInfos();
            for (int i = 0; i < fs.Length; ++i)
            {
                if (fs[i] is FileInfo) 
                {
                    Console.WriteLine(level + fs[i].Name);
                }
                else
                {
                    rec(fs[i] as DirectoryInfo, level);
                }
            }
        }
        static void Main(string[] args)
        {
            DirectoryInfo dir = new DirectoryInfo(@"/Users/Gappar/Desktop/Lab2/Task3/Problems");
            rec(dir, "");
        }
    }
}