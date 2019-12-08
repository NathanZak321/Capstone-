using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Table
{
    //----------------------------------------------
    // Title: Cost of Flooring
    // Application Type: Console
    // Description: Calculate the cost for flooring
    // Author: Nathan Zak
    // Date Created: 12/2/2019
    //----------------------------------------------
    class Program
    {
        static void Main(string[] args)
        {
            #region "Variables & Opening"

            string widthString;
            string lengthString;
            string costFoot;
            string room1Name = "Living Room";
            double room1Length, room1Width;
            double room1CostSqFoot;
            double room1Area;
            double room1Cost;

            string width2String;
            string length2String;
            string cost2Foot;
            string room2Name = "Kitchen";
            double room2Length, room2Width;
            double room2CostSqFoot;
            double room2Area;
            double room2Cost;

            string width3String;
            string length3String;
            string cost3Foot;
            string room3Name = "Bedroom 1";
            double room3Length, room3Width;
            double room3CostSqFoot;
            double room3Area;
            double room3Cost;

            string width4String;
            string length4String;
            string cost4Foot;
            string room4Name = "Bedroom 2";
            double room4Length, room4Width;
            double room4CostSqFoot;
            double room4Area;
            double room4Cost;

            string width5String;
            string length5String;
            string cost5Foot;
            string room5Name = "Master";
            double room5Length, room5Width;
            double room5CostSqFoot;
            double room5Area;
            double room5Cost;


            string width6String;
            string length6String;
            string cost6Foot;
            string room6Name = "Bathroom";
            double room6Length, room6Width;
            double room6CostSqFoot;
            double room6Area;
            double room6Cost;
            double totalArea;
            double totalCost;


            //------------------------
            // - Greeting -
            //------------------------
            Console.BackgroundColor = ConsoleColor.DarkBlue;
            Console.Clear();
            Console.WriteLine();
            Console.Write("Hello User");
            Console.WriteLine();

            //----------------------------
            // - Description -
            //----------------------------
            Console.WriteLine();
            Console.Write("I'm here to help you calculate the cost of flooring for your house.");
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Press any key to continue.");
            Console.ReadKey();
            Console.Clear();
            #endregion

            #region "Room Measurements"
            //-------------------------------
            // - Ask for Measurements - (First Room)
            //-------------------------------
            Console.BackgroundColor = ConsoleColor.Yellow;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();

            Console.WriteLine("Please tell me the length of your living room.");
            lengthString = Console.ReadLine();
            while (!double.TryParse(lengthString, out room1Length))
            {
                Console.WriteLine("This is not a number!");
                lengthString = Console.ReadLine();
            }
            Console.Write("\tThe length is " + room1Length + " feet.");
            room1Length = double.Parse(lengthString);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("And what is the width of your living room?");
            widthString = Console.ReadLine();
            while (!double.TryParse(widthString, out room1Width))
            {
                Console.WriteLine("This is not a number!");
                widthString = Console.ReadLine();
            }
            Console.Write("\tThe width is " + room1Width + " feet.");
            room1Width = double.Parse(widthString);

            Console.WriteLine();
            Console.WriteLine();

            Console.WriteLine("Please enter the cost per sq foot.");
            costFoot = Console.ReadLine();
            while (!double.TryParse(costFoot, out room1CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                costFoot = Console.ReadLine();
            }
            room1CostSqFoot = double.Parse(costFoot);
            Console.Write("\tThe cost per square foot is " + room1CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Second Room"
            //------------------------------------
            // - Second Room -
            //------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your kitchen.");
            length2String = Console.ReadLine();
            while (!double.TryParse(length2String, out room2Length))
            {
                Console.WriteLine("This is not a number!");
                length2String = Console.ReadLine();
            }
            room2Length = double.Parse(length2String);
            Console.Write("\tThe length is " + room2Length + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And what is the width of your kitchen?");
            width2String = Console.ReadLine();
            while (!double.TryParse(width2String, out room2Width))
            {
                Console.WriteLine("This is not a number!");
                width2String = Console.ReadLine();
            }
            room2Width = double.Parse(width2String);
            Console.Write("\tThe width is " + room2Width + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost2Foot = Console.ReadLine();
            while (!double.TryParse(cost2Foot, out room2CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                cost2Foot = Console.ReadLine();
            }
            room2CostSqFoot = double.Parse(cost2Foot);
            Console.Write("\tThe cost per square foot is " + room2CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Third Room"
            //------------------------------------
            // - Third Room -
            //------------------------------------
            Console.BackgroundColor = ConsoleColor.Cyan;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your first bedroom.");
            length3String = Console.ReadLine();
            while (!double.TryParse(length3String, out room3Length))
            {
                Console.WriteLine("This is not a number!");
                length3String = Console.ReadLine();
            }
            room3Length = double.Parse(length3String);
            Console.Write("\tThe length is " + room3Length + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And what is the width of your first bedroom?");
            width3String = Console.ReadLine();
            while (!double.TryParse(width3String, out room3Width))
            {
                Console.WriteLine("This is not a number!");
                width3String = Console.ReadLine();
            }
            room3Width = double.Parse(width3String);
            Console.Write("\tThe width is " + room3Width + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost3Foot = Console.ReadLine();

            while (!double.TryParse(cost3Foot, out room3CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                cost3Foot = Console.ReadLine();
            }
            room3CostSqFoot = double.Parse(cost3Foot);
            Console.Write("\tThe cost per square foot is " + room3CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Fourth Room"
            //------------------------------------
            // - Fourth Room -
            //------------------------------------
            Console.BackgroundColor = ConsoleColor.Gray;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.Magenta;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your second bedroom.");
            length4String = Console.ReadLine();
            while (!double.TryParse(length4String, out room4Length))
            {
                Console.WriteLine("This is not a number!");
                length4String = Console.ReadLine();
            }
            room4Length = double.Parse(length4String);
            Console.Write("\tThe length is " + room4Length + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And what is the width of your second bedroom?");
            width4String = Console.ReadLine();
            while (!double.TryParse(width4String, out room4Width))
            {
                Console.WriteLine("This is not a number!");
                width4String = Console.ReadLine();
            }
            room4Width = double.Parse(width4String);
            Console.Write("\tThe width is " + room4Width + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost4Foot = Console.ReadLine();
            while (!double.TryParse(cost4Foot, out room4CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                cost4Foot = Console.ReadLine();
            }
            room4CostSqFoot = double.Parse(cost4Foot);
            Console.Write("\tThe cost per square foot is " + room4CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Fifth Room"
            //------------------------------------
            // - Fifth Room -
            //------------------------------------
            Console.BackgroundColor = ConsoleColor.DarkMagenta;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkYellow;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your master bedroom.");
            length5String = Console.ReadLine();
            while (!double.TryParse(length5String, out room5Length))
            {
                Console.WriteLine("This is not a number!");
                length5String = Console.ReadLine();
            }
            room5Length = double.Parse(length5String);
            Console.Write("\tThe length is " + room5Length + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And what is the width of your master bedroom?");
            width5String = Console.ReadLine();
            while (!double.TryParse(width5String, out room5Width))
            {
                Console.WriteLine("This is not a number!");
                widthString = Console.ReadLine();
            }
            room5Width = double.Parse(width5String);
            Console.Write("\tThe width is " + room5Width + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost5Foot = Console.ReadLine();
            while (!double.TryParse(cost5Foot, out room5CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                costFoot = Console.ReadLine();
            }
            room5CostSqFoot = double.Parse(cost5Foot);
            Console.Write("\tThe cost per square foot is " + room5CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Sixth Room"
            //------------------------------------
            // - Sixth Room -
            //------------------------------------
            Console.BackgroundColor = ConsoleColor.Black;
            Console.Clear();
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please tell me the length of your bathroom.");
            length6String = Console.ReadLine();
            while (!double.TryParse(length6String, out room6Length))
            {
                Console.WriteLine("This is not a number!");
                length6String = Console.ReadLine();
            }
            room6Length = double.Parse(length6String);
            Console.Write("\tThe length is " + room6Length + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("And what is the width of your bathroom?");
            width6String = Console.ReadLine();
            while (!double.TryParse(width6String, out room6Width))
            {
                Console.WriteLine("This is not a number!");
                width6String = Console.ReadLine();
            }
            room6Width = double.Parse(width6String);
            Console.Write("\tThe width is " + room6Width + " feet.");

            Console.WriteLine();
            Console.WriteLine();
            Console.WriteLine("Please enter the cost per sq foot.");
            cost6Foot = Console.ReadLine();
            while (!double.TryParse(cost6Foot, out room6CostSqFoot))
            {
                Console.WriteLine("This is not a number!");
                cost6Foot = Console.ReadLine();
            }
            room6CostSqFoot = double.Parse(cost6Foot);
            Console.Write("\tThe cost per square foot is " + room6CostSqFoot + " dollars.");

            Console.WriteLine();
            Console.Clear();
            #endregion

            #region "Display Setup"
            //---------------------------------
            // - Display flooring cost by room -
            //---------------------------------
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
            Console.WriteLine("\t\tFlooring Cost By Room.");
            Console.WriteLine();

            //--------------------------
            // - Display Table Headers -
            //--------------------------

            Console.WriteLine(
            "Room".PadRight(15) +
            "Length".PadLeft(10) +
            "Width".PadLeft(10) +
            "Area".PadLeft(10) +
            "Cost/SqFt".PadLeft(15) +
            "Cost".PadLeft(10)
             );
            Console.WriteLine(
            "----".PadRight(15) +
            "------".PadLeft(10) +
            "-----".PadLeft(10) +
            "----".PadLeft(10) +
            "---------".PadLeft(15) +
            "----".PadLeft(10)
            );
            #endregion

            #region "Calculations"
            //---------------------------
            // - Calculate Table Values -
            //---------------------------
            room1Area = room1Length * room1Width;
            room1Cost = room1Area * room1CostSqFoot;
            room2Area = room2Length * room2Width;
            room2Cost = room2Area * room2CostSqFoot;
            room3Area = room3Length * room3Width;
            room3Cost = room3Area * room3CostSqFoot;
            room4Area = room4Length * room4Width;
            room4Cost = room4Area * room4CostSqFoot;
            room5Area = room5Length * room5Width;
            room5Cost = room5Area * room5CostSqFoot;
            room6Area = room6Length * room6Width;
            room6Cost = room6Area * room6CostSqFoot;
            totalArea = room1Area + room2Area;
            totalCost = room1Cost + room2Cost;
            #endregion

            #region "Table Values"
            //-------------------------
            // - Display Table Values -
            //-------------------------
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine(
            room1Name.PadRight(15) +
            room1Length.ToString("f").PadLeft(10) +
            room1Width.ToString("f").PadLeft(10) +
            room1Area.ToString("f").PadLeft(10) +
            room1CostSqFoot.ToString("c").PadLeft(15) +
            room1Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room2Name.PadRight(15) +
            room2Length.ToString("f").PadLeft(10) +
            room2Width.ToString("f").PadLeft(10) +
            room2Area.ToString("#.###").PadLeft(10) +
            room2CostSqFoot.ToString("c").PadLeft(15) +
            room2Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room3Name.PadRight(15) +
            room3Length.ToString("f").PadLeft(10) +
            room3Width.ToString("f").PadLeft(10) +
            room3Area.ToString("#.###").PadLeft(10) +
            room3CostSqFoot.ToString("c").PadLeft(15) +
            room3Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room4Name.PadRight(15) +
            room4Length.ToString("f").PadLeft(10) +
            room4Width.ToString("f").PadLeft(10) +
            room4Area.ToString("#.###").PadLeft(10) +
            room4CostSqFoot.ToString("c").PadLeft(15) +
            room4Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room5Name.PadRight(15) +
            room5Length.ToString("f").PadLeft(10) +
            room5Width.ToString("f").PadLeft(10) +
            room5Area.ToString("#.###").PadLeft(10) +
            room5CostSqFoot.ToString("c").PadLeft(15) +
            room5Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
            room6Name.PadRight(15) +
            room6Length.ToString("f").PadLeft(10) +
            room6Width.ToString("f").PadLeft(10) +
            room6Area.ToString("#.###").PadLeft(10) +
            room6CostSqFoot.ToString("c").PadLeft(15) +
            room6Cost.ToString("c").PadLeft(10)
            );

            Console.WriteLine(
                "------".PadLeft(45) +
                "------".PadLeft(25)
                );

            Console.WriteLine(
            "Total".PadLeft(5) +
            totalArea.ToString("f").PadLeft(40) +
            totalCost.ToString("c").PadLeft(25)
            );
            #endregion

            #region "End Screen"
            //
            //Pause For User
            //
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine();
            Console.WriteLine("Thank you for using my application.");
            Console.WriteLine("\tPress any key to exit.");
            Console.ReadKey();
            #endregion


        }
    }
}