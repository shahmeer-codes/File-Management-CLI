using System;
class Overwriter{
    public void Overwrite(){
        StreamWriter writer = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt",false);
        Console.WriteLine("Enter the text to write to the file:");
        string text = Console.ReadLine();
        writer.WriteLine(text);
        writer.Close();
    }
}