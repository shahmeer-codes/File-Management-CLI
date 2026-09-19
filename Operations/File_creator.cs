using System;
class File_creator{
        public void Create(){
            Console.Write("Enter the file name: ");
            string? name = Console.ReadLine();
            // string dataFolder = Path.Combine(Directory.GetCurrentDirectory(), "Files");

            // if (!Directory.Exists(dataFolder))
            //     {
            //         Directory.CreateDirectory(dataFolder);
            //     }

            // string filePath = Path.Combine(dataFolder, name!);
            // Console.WriteLine(filePath);
            File.Create($@"C:\Users\Shahmeer\Desktop\FileSystem in C#\Files\{name}").Close();
            Console.WriteLine("File created successfully!");
    }
}
