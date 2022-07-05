using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace CS8
{
    class Program
    {
        static void Main(string[] args)
        {
            System.Console.WriteLine("Write a program in C# Sharp to accept a grade and declare the equivalent description : ");
            var grade = new GradeFinder();
            grade.Grade();
            // int custid, conu;
            // double chg, surchg = 0, gramt, netamt;
            // string connm;

            // Console.Write("\n\n");
            // Console.Write("Calculate Electricity Bill:\n");
            // Console.Write("----------------------------");
            // Console.Write("\n\n");

            // Console.Write("Input Customer ID :");
            // custid = Convert.ToInt32(Console.ReadLine());
            // Console.Write("Input the name of the customer :");
            // connm = Console.ReadLine();
            // Console.Write("Input the unit consumed by the customer : ");
            // conu = Convert.ToInt32(Console.ReadLine());
            // if (conu < 200)
            //     chg = 1.20;
            // else if (conu >= 200 && conu < 400)
            //     chg = 1.50;
            // else if (conu >= 400 && conu < 600)
            //     chg = 1.80;
            // else
            //     chg = 2.00;
            // gramt = conu * chg;
            // if (gramt > 300)
            //     surchg = gramt * 15 / 100.0;
            // netamt = gramt + surchg;
            // if (netamt < 100)
            //     netamt = 100;
            // Console.Write("\nElectricity Bill\n");
            // Console.Write("Customer IDNO                       :{0}\n", custid);
            // Console.Write("Customer Name                       :{0}\n", connm);
            // Console.Write("unit Consumed                       :{0}\n", conu);
            // Console.Write("Amount Charges @Rs. {0}  per unit :{1}\n", chg, gramt);
            // Console.Write("Surchage Amount                     :{0}\n", surchg);
            // Console.Write("Net Amount Paid By the Customer     :{0}\n", netamt);

            // Console.WriteLine("***Write a program in C# Sharp to calculate and print the Electricity bill of a given customer.****");

            // double id, unitPrice ;
            // string name; 
            // double UnitConsumed, TotalCost;

            // System.Console.Write("Please Input ID of Bill: ");
            // id = Convert.ToInt32(Console.ReadLine());
            // System.Console.Write("Please Input Your Name: ");
            // name = Console.ReadLine();
            // System.Console.Write("Please Input Consumed Electricity Units: ");
            // UnitConsumed = Convert.ToInt32(Console.ReadLine());

            // // System.Console.WriteLine($"{id} , {name} , {UnitConsumed}");
            // if (UnitConsumed <= 199)
            // {
            //     unitPrice = 1.20;
            //     System.Console.WriteLine("This Month your bill is: {0}",UnitConsumed * unitPrice );
            // }
            // else if (UnitConsumed >= 200 && UnitConsumed < 400)
            // {
            //     unitPrice = 1.50;
            //     System.Console.WriteLine("This Month your bill is: {0}",UnitConsumed * unitPrice );
            // }
            // else if (UnitConsumed >= 400 && UnitConsumed < 600)
            // {
            //     unitPrice = 1.80;
            //     TotalCost = (UnitConsumed * unitPrice) * 0.15;
            //     double GrandTotal = (UnitConsumed * unitPrice) + TotalCost;
            //     System.Console.WriteLine("This Month your bill is: {0}", GrandTotal );
            // }
            // else if (UnitConsumed >= 600)
            // {
            //     unitPrice = 2.00f;
            //     TotalCost = (UnitConsumed * unitPrice) * 0.15;
            //     double GrandTotal = (UnitConsumed * unitPrice) + TotalCost;
            //     System.Console.WriteLine("This Month your bill is: {0}",GrandTotal );
            // }


        }
    }
}
