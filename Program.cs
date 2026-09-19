using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        Console.WriteLine("\t<---File manager--->");
        Console.WriteLine("\t1. Create a file\n\t2. Read a file\n\t3. Write to a file\n\t4. Delete a file\n\t5. Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 2:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 3:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 4:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 5:
                repeat= false;
                break;
            default:
        }
        StreamWriter w = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt");
        w.Write("Hello World");
        w.Close();
    }
}