using System;
class File_selector{
    public string file_select(){
        Console.WriteLine("You can select a file from the existing files in the working directory.");
        string current_path=Directory.GetCurrentDirectory();
        string[] files =Directory.GetFiles($@"{current_path}\Files");

        Console.WriteLine("These are the files in the working directory:");
            for(int i=0; i<files.Length; i++)
            {
                Console.WriteLine($"{i+1}. "+ Path.GetFileName(files[i]));
            }
        Console.Write("Select a working directory file from the list below : ");
        int file_number= Convert.ToInt32(Console.ReadLine());
        return files[file_number-1];

    }
    public string Select(){
        Console.WriteLine("You wanted to create a new file or woking (y/n): ");
        char choice= Convert.ToChar(Console.ReadLine());
        if(choice=='y' || choice=='Y'){
            File_creator f = new File_creator();
            string path= f.Create();
            return path;

        }else if(choice=='n' || choice=='N'){

            string return_file_name= file_select();
            return return_file_name;

        }

        Console.WriteLine("Invalid choice. program is ending.");
        return "";
    }
}