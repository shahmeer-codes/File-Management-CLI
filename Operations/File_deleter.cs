using System;
using System.IO;

class File_deleter
{
    public void Delete(string current_file_path)
    {
        File_selector fs = new File_selector();
        string selected_file_for_delete_path = fs.file_select();

        if (string.IsNullOrEmpty(selected_file_for_delete_path))
        {
            Console.WriteLine("No working file selected.");
            return;
        }
        if (Path.GetFullPath(selected_file_for_delete_path)
    .Equals(Path.GetFullPath(current_file_path), StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("This file is in use you cannot delete this file!");
            return;
        }

        string fileName = Path.GetFileName(selected_file_for_delete_path);

        if (fileName.Equals("data", StringComparison.OrdinalIgnoreCase))
        {
            Console.WriteLine("data.txt is a permanent file and cannot be deleted.");
            return;
        }
        
        if (!File.Exists(selected_file_for_delete_path))
        {
            Console.WriteLine("File does not exist.");
            return;
        }

        File.Delete(selected_file_for_delete_path);

        Console.WriteLine("File deleted successfully!");
    }
}