using System;
using System.IO;
/// <summary>
/// 学习文件流使用的Demo
/// </summary>
namespace S_FileStream
{
    class Program
    {
        public static FileInfo file;
        public string filePath;

        public FileInfo CreateFile(string path)
        {
            return new FileInfo(path);
        }

        static void Main(string[] args)
        {
            string file = Environment.CurrentDirectory;
            Console.WriteLine("HelloWord!" + file);
            foreach (var str in args)
                Console.Write(str);
            Console.ReadKey();
        }
    }
}

