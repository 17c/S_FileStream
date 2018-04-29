using System;
using System.IO;
/// <summary>
/// 学习文件流使用的Demo
/// </summary>
namespace S_FileStream
{   /// <summary>
/// 总结
/// Path可以获取文件的路径，是相当好用的一个类。
/// File类 用于创建 删除 判定是否存在 等 
/// Directory类 类似于File类
/// FileInfo 改变文件的读写方式等，并不常用
/// SreamWriter 控制文件读写
/// 参考文献
/// https://www.cnblogs.com/hellowzl/p/6797556.html
/// </summary>
    class Program
    {
        public static StreamWriter writer;
        public static string filePath;


        static void Main(string[] args)
        {
            string file = Environment.CurrentDirectory;
            Console.WriteLine("exe currentDirectory:" + file);
            Console.WriteLine("root currentDirectory:" + Path.GetPathRoot(file));
            //存储文件的地址
            string tempFile=  Path.GetDirectoryName(Path.GetDirectoryName(file));
            string DirPath = tempFile + "\\LuaFile";
            Console.WriteLine("DirPath:" + DirPath);

            //创建一个文件夹
            if (!Directory.Exists(DirPath)){
                Directory.CreateDirectory(DirPath);
            }
            //创建一个lua文件
            filePath = DirPath + "\\input.lua";
            if (!File.Exists(filePath))
            {
              File.Create(filePath);
            }
            //输入一句话
            writer = new StreamWriter(filePath,true);
            writer.WriteLine("print(\"hello,world\")");
            writer.Flush();
           
        }
    }
}

