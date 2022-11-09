using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BagApp
{
    internal class Bag
    {
        //describe three variables
        private string? nameOfBag; //stores the name of the bag
        private double costOfBag; //stores the cost of the bag
        private int quantityOfBag; //store how many bags does the user wants
        private bool isBagAvailable;//specifies if the bag is available or not
        public void DisplayBagInfo()
        {
            Start();
            ReadNameOfbag();
            ReadQuantityOfBag();
            ReadCostOfBag();
            ReadIsBagAvailable();
            PurchasedbBagSummary();
        }
        private void Start()
        {
            Console.WriteLine();

            Console.WriteLine("Welcome to the BagApp store! Enjoy shopping our lovely bags!");//displays the welcome message to the user

            Console.WriteLine();
        }
        private void ReadNameOfbag()
        {
            Console.WriteLine("What is the name of the bag/brand?");//text input for the name bag

            nameOfBag = Console.ReadLine();

            Console.WriteLine();//blank line
        }
        private void ReadQuantityOfBag()
        {

            Console.Write("What is the quantity of the bag?");//text input for the quantity of bag

            Console.WriteLine();

            string? intQuantityOfBag = Console.ReadLine();

            quantityOfBag = int.Parse(intQuantityOfBag!);//parse string to number

            Console.WriteLine(); 
        }
        private void ReadCostOfBag()
        {
            Console.WriteLine("What is the price of a " + nameOfBag + " bag?");//text input for the name of the bag

            string? strNamOfBag = Console.ReadLine();

            costOfBag = double.Parse(strNamOfBag!);//user input for cost of bag in double

            Console.WriteLine();
        }

        private void ReadIsBagAvailable()
        {
            Console.WriteLine("Add (Yes/No) if " + nameOfBag + " is available" );

            string? userResponse = Console.ReadLine();//variable to store user response
            userResponse = userResponse!.ToLower();//to change string to lower cases

            if ((userResponse == "Yes") || (userResponse == "Y") || (userResponse == "y") )//show if the bag is available (return true)
                isBagAvailable = true;
            else
                isBagAvailable = false;//otherwise return false

            Console.WriteLine();
        }

        private void PurchasedbBagSummary()
        {
            Console.WriteLine("++++ " + "Here is the summary of your purchase" + " ++++");//summarize the information that the user enter

            Console.WriteLine("Name:" + nameOfBag);//summary name of the bag

            Console.WriteLine();

            Console.WriteLine("Quantity: " + quantityOfBag);//summary quantity of the bag

            Console.WriteLine();

            Console.WriteLine("Total price: " + String.Format("{0:0.00}", costOfBag * quantityOfBag));//summary multiply cost of bag with the quantity

            Console.WriteLine();

            Console.WriteLine("Is bag available: " + isBagAvailable);//summary show if bag is available or not

            Console.WriteLine();

            Console.WriteLine("Datestamp:" + DateTime.Now.ToLongDateString());//get the current date

            Console.WriteLine();

            Console.WriteLine("++++ " + "Thank you for your purchase. Please welcome back" + "++++ ");

            Console.WriteLine();

            Console.WriteLine("Please press enter to exit!");
        }
    }
}
