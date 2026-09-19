using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        while(repeat)
        {
        Console.WriteLine("<--- File Manager --->");
            Console.WriteLine("1. Create a file");
            Console.WriteLine("2. Read a file");
            Console.WriteLine("3. Overwrite file (It may delete the existing data)");
            Console.WriteLine("4. Append data to file (Add new data atbthe edn without deleting the existing data)");
            Console.WriteLine("5. Exit");
            Console.Write("Enter your choice: ");

            int choice = Convert.ToInt32(Console.ReadLine());

        switch (choice)
        {
            case 1:
                File.Create(@"C:\Users\Shahmeer\Desktop\data.txt").Close();
                Console.WriteLine("File created successfully!");
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
        }
        
    }
}
}