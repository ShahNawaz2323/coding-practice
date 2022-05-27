using System;
using System.IO;
using System.Collections;

namespace UpDownCast
{

    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Text();  //Down casting in next line , shape type object , become text type at compiling time.
            Text text = (Text) shape; //object of shape class but have behaior of text class object. Down Casting.
            

            // var list = new ArrayList();
            // list.Add(1);
            // list.Add("Shah");
            // list.Add(new Text()); //apply or supply text type object.

            // var anotherList = new List<int>();

            // var anotherList = new List<shape>();

            
            
            // StreamReader reader = new StreamReader(new MemoryStream());
            
            
            // Text text = new Text();
            // //implicity conversion | No Conversion Require.
            // Shape shape = text;
            

            // text.Width = 200;
            // shape.Width = 100;

            // System.Console.WriteLine(text.Width);
        }
    }
}
