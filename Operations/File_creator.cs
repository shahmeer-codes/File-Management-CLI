using System;
class File_creator{
        public string Create(){
            Console.Write("Enter the file name: ");
            string? name = Console.ReadLine();
            string current_path=Directory.GetCurrentDirectory();
            string file_path = $@"{current_path}\Files\{name}";
            File.Create($@"{file_path}").Close();
            Console.WriteLine("File created successfully!");
            return file_path;
    }
}
