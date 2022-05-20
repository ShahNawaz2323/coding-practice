namespace InheritancePrac
{
    public class PresentationObject
    {

    public int width {get; set;}
    public int heigh {get; set;}

    public void Copy()
    {
        System.Console.WriteLine("Object Copied to clipboard.");
    }

    public void Duplicate()
    {
        System.Console.WriteLine("Object was duplicated.");
    }

    
    }
}
