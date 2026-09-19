using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        while(repeat)
        {
        Console.WriteLine("\t<---File manager--->");
        Console.WriteLine("\t1. Create a file\n\t2. Read a file\n\t3. Apend the previous text in a file\n\t4. Add data in a file with previous data\n\t5. Exit");
        int choice = Convert.ToInt32(Console.ReadLine());
        switch (choice)
        {
            case 1:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt").Close();
                Console.WriteLine("File created successfully!");
                break;
            case 2:
                StreamReader r = new StreamReader(@"C:\Users\Shahmeer\Desktop\data.txt");
                string line = r.ReadToEnd();
                while ((line = r.ReadLine()) != null)
                {
                    Console.WriteLine(line);
                }
                r.Close();
                break;
            case 3:
                StreamWriter writer = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt");
                Console.WriteLine("Enter the text to write to the file:");
                string text = Console.ReadLine();
                writer.WriteLine(text);
                writer.Close();
                break;
            case 4:
                StreamWriter writer1 = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt",true);
                Console.WriteLine("Enter the text to write to the file:");
                string text1 = Console.ReadLine();
                writer1.WriteLine(text1);
                writer1.Close();
                break;
            case 5:
                repeat= false;
                break;
        }
        
    }
}
}