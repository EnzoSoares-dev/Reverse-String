using System;
namespace Question_5{

    public class Program{
        static void Main(){
            string? text;     
            System.Console.WriteLine("What do you want to invert?");
            text = Console.ReadLine();     
            while(text == " "){
                System.Console.WriteLine("What do you want to invert?");
            text = Console.ReadLine();
            }
            int size = text.Length; 
            List<char> outText = new List<char>(); 
            foreach(char chars in text){                
                outText.Insert(0,chars);
            }
            text = new String(outText.ToArray());
            System.Console.WriteLine(text);

        }
    }
}
