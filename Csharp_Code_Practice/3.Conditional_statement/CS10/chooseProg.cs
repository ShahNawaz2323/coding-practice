using System;


namespace CS10
{
    public class chooseProg
    {
        public void select()
        {
            do
            {
                
            
            System.Console.WriteLine("*****If you want to check days in months press \"1\" ");
            System.Console.WriteLine("*****If you want to Compute the Area press \"2\" ");
            System.Console.WriteLine("*****If you want to do Arthmatic (+-*/), press \"3\" \n");
            System.Console.Write("Input 1 , 2 or 3 to start that program: ");
            int choose = Convert.ToInt32(Console.ReadLine());

            switch (choose)
            {
                case 1:
                    {
                        Console.WriteLine("********Determine How many days in the Given Month********");
                        MonthsDay monthObj = new MonthsDay();
                        monthObj.Months();
                        break;
                    }
                case 2:
                    {
                        ComputeTheArea area = new ComputeTheArea();
                        area.AreaCal();
                        break;
                    }
                case 3:
                    {
                        Arthmatic arthObj = new Arthmatic();
                        arthObj.ArtCal();
                        break;

                    }
                default:
                    {
                        System.Console.WriteLine("Invalid Option Selection.... ");
                        break;
                    }
            }
       
            System.Console.Write("\n*****If want to run program again press Y or any other word if you want to exit:  ");
            string c = Console.ReadLine();
            c.ToUpper();

            if(c == "Y")
            {
                continue;
            }
            else{
                break;
            }
            } while (true);
        }
    }
}
