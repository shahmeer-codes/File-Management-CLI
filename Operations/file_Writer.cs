using System;
class file_writer{
    public void write(string name,bool append){
        StreamWriter writer = new StreamWriter($@"{name}",append);
        Console.WriteLine("Enter the text to write to the file:");
        string text = Console.ReadLine();
        writer.WriteLine(text);
        writer.Close();
    }
}