using System;
class Appender{
    public void Append(){
        StreamWriter writer1 = new StreamWriter(@"C:\Users\Shahmeer\Desktop\data.txt",true);
                Console.WriteLine("Enter the text to write to the file:");
                string text1 = Console.ReadLine();
                writer1.WriteLine(text1);
                writer1.Close();
    }
}