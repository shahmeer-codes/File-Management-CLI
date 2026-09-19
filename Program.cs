using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        Console.WriteLine("\t<---File manager--->");
        Console.WriteLine("\t1. Create a file\n\t2. Read a file\n\t3. Write or apend to a file\n\t4. Delete a file\n\t5. Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 2:
                StreamReader r = new StreamReader(@"C:\Users\Shahmeer\Desktop\data.txt");
                string line = r.ReadToEnd();
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                break;
            case 3:
                StreamWriter writer = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt");
                Console.WriteLine("Enter the text to write to the file:");
                string text = Console.ReadLine();
                writer.WriteLine(text);
                break;
            case 4:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt");
                break;
            case 5:
                repeat= false;
                break;
        }
        StreamWriter w = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt");
        w.Write("Hello World");
        w.Close();
    }
}