using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        StreamWriter w = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt");
        w.Write("Hello World");
        w.Close();
    }
}