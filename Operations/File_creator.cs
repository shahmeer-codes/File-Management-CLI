using System;
class File_creator{
        public void Create(){
            Console.Write("Enter the file name: ");
            string? name = Console.ReadLine();
            string current_path=Directory.GetCurrentDirectory();
            File.Create($@"{current_path}\Files\{name}").Close();
            Console.WriteLine("File created successfully!");
    }
}
