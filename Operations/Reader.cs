using System;
class Reader{
    public void Read(){
        StreamReader r = new StreamReader(@"C:\Users\Shahmeer\Desktop\data.txt");
                string line = r.ReadToEnd();
                Console.WriteLine(line);
                r.Close();
    }
}