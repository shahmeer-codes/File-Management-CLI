using System;
using System.IO;
class Program
{
    public static void Main(string[] args)
    {
        bool repeat= true;
        Console.WriteLine("Welcome to the File Manager!");
        File_selector fs = new File_selector();
        string current_file_path = fs.Select();

        while(repeat)
        {
        Console.WriteLine("<--- File Manager --->");
            Console.WriteLine("1. Create another file");
            Console.WriteLine("2. Read a file");
            Console.WriteLine("3. Overwrite file (It may delete the existing data)");
            Console.WriteLine("4. Append data to file (Add new data at the edn without deleting the existing data)");
            Console.WriteLine("5. Change the Working File");
            Console.WriteLine("6. Delete a File");
            Console.WriteLine("7. Exit");

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
                if(f.Create() =="")
                {
                    Console.WriteLine("File creation failed.");
                    repeat = false;
                }
                break;
            case 2:
                Reader r =new Reader();
                r.Read(current_file_path);
                break;
            case 3:
                file_writer fow = new file_writer();
                fow.write(current_file_path,false);
                break;
            case 4:
                file_writer faw = new file_writer();
                faw.write(current_file_path,true);
                break;
            case 5:
                current_file_path = fs.Select();
                break;
            case 6:
                File_deleter deleter = new File_deleter();
                deleter.Delete(current_file_path);
                break;
            case 7:
                repeat= false;
                break;
            default:
                    Console.WriteLine("Invalid choice.Try again!");
                    break;
        }
        
    }
}
}