namespace KidsFair
{
    internal class TicketSeller
    {
        private string? name;
        private double price = 100;
        private int numberOfAdults;
        private int numberOfChildren;
        private double totalAmountToPay;
        
    /// <summary>
    /// reads start method
    /// </summary>
    public void Start()
    {
        ReadName();
        NumberOfAdults();
        NumberOfChildren();
        AmountToPay();
    }
    /// <summary>
    /// read name method
    /// </summary>
    private void ReadName()
       {
          Console.WriteLine("Welcome to KIDS' FAIR");

          Console.WriteLine("Children always get a 75% discount!");//text to show users the children discount

          Console.WriteLine();

          Console.WriteLine("Your name please:");

          name = Console.ReadLine();

          Console.WriteLine();
        }

    /// <summary>
    /// reads methods for adult number
    /// </summary>
    private void NumberOfAdults()
        {
            Console.WriteLine("Number of adults:");

            string? stringNumberOfAdults = Console.ReadLine()!;//number of adults should allow the user to add number of adults in integer


            numberOfAdults = int.Parse(stringNumberOfAdults)!;

            Console.WriteLine();
         }
     /// <summary>
     /// reads method for number of children
     /// </summary>
     private void NumberOfChildren()
        {
            Console.WriteLine("Number of children:");

            string? stringNumberOfChildren = Console.ReadLine();//number of children should allow the user to add number of children in integer

            numberOfChildren = int.Parse(stringNumberOfChildren!);

            Console.WriteLine();
        }
    /// <summary>
    /// reads method for amont to pay
    /// </summary>
     private void AmountToPay()
        {
            double adultPrice;
            double childrenPrice;

            adultPrice = price * numberOfAdults;

            childrenPrice = price * numberOfChildren * (1 - 0.75);//this calculates the 75 % discount price for children

            totalAmountToPay = childrenPrice + adultPrice;

            Console.WriteLine("+++ " + "Your receipt" + " +++");

            //using stringFormat to show decimal
            Console.WriteLine("+++ Amount to pay = " + String.Format("{0:0.00}", totalAmountToPay));//this prints the total amount for the user that needs to paid for both adults and children

            Console.WriteLine();

            Console.WriteLine("+++ " + "Thank you " + "" + name + "" + " and please come back!" + " +++");
  
            Console.WriteLine("Press Enter to start next page!");

            Console.WriteLine();
        }
    } 
}
