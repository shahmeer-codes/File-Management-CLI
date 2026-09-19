using System;
class File_selector{
    public string Select(){
        string[] s=Directory.GetFiles(@"C:\Users\Shahmeer\Desktop\FileSystem in C#\Files");
        Console.WriteLine("These are the files in the working directory:");
            for(int i=0; i<s.Length; i++)
            {
                Console.WriteLine($"{i+1}. "+Path.GetFileName(s[i]));
            }
        Console.Write("Select a working directory file from the list below : ");
        int c= Convert.ToInt32(Console.ReadLine());
        return s[c];
    }
}