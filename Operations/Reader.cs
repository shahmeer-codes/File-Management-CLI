using System;
class Reader{
    public void Read(string name){
        StreamReader r = new StreamReader($@"{name}");
                string line = r.ReadToEnd();
                
                Console.WriteLine(line);
                r.Close();
    }
}