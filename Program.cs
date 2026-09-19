using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        Console.WriteLine("Welcome to the File Manager!");
        File_selector fs = new File_selector();
        string file_name=fs.Select();
        while(repeat)
        {
        Console.WriteLine("<--- File Manager --->");
            Console.WriteLine("1. Create a file");
            Console.WriteLine("2. Read a file");
            Console.WriteLine("3. Overwrite file (It may delete the existing data)");
            Console.WriteLine("4. Append data to file (Add new data atbthe edn without deleting the existing data)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            if (!int.TryParse(Console.ReadLine(), out int choice))
            {
                Console.WriteLine("Invalid input.");
                continue;
            }

        switch (choice)
        {
            case 1:
                File_creator f = new File_creator();
                f.Create();
                break;
            case 2:
                Reader r =new Reader();
                r.Read();
                break;
            case 3:
                Overwriter o = new Overwriter();
                o.Overwrite();
                break;
            case 4:
                Appender a = new Appender();
                a.Append();
                break;
            case 5:
                repeat= false;
                break;
            default:
                    Console.WriteLine("Invalid choice.Try again!");
                    break;
        }
        
    }
}
}