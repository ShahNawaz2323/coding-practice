namespace MethodOverridePrac
{
    public class Circle : Shape
    {
        public override void Draw()
        {
           //Any code specific to  to class circle itself 
            System.Console.WriteLine("Draw a Circle");
        }
    }

    public class Rectangle: Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Rectangle");
        }
    }
    public class Triangle : Shape
    {
        public override void Draw()
        {
            System.Console.WriteLine("Draw a Triangle");
        }
    }
    public class Shape
    {
        public int Width { get; set; }
        public int Height { get; set; }
        public Position Position { get; set; }

        public virtual void Draw()
        {

        }
    
    }
}
