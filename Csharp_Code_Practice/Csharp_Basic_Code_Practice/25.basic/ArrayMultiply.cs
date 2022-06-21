namespace basic
{
    public class ArrayMultiply
    {
        public void ArrayMulti(int[] array1, int[] array2)
        {
            for(int i = 0 ; i < array1.Length; i++)
            {
                System.Console.Write(array1[i] * array2[i] + " ");
            }
            System.Console.WriteLine("\n");
        } 
    }
}
