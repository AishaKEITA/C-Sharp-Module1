namespace KidsFair;
internal class Pet
{   //input variables
    private string? name;//to store name of the pet as text
    private int? age;//to store the age of the pet
    private bool isFemale;//to check if age is yes or no

    /// <summary>
    ///  Reads the different methods used in the applicatio
    ///  The methods used are saved in ReadAndSavePetData()
    ///  which is called in the Progrm.cs file
    /// </summary>
    public void ReadAndSavePetData()
    {
        Start();
        ReadName();
        ReadAge();
        ReadPetGender();
        DisplayPetInfo();
    }
    /// <summary>
    /// method for start()
    /// </summary>
    private void Start()
    {             
        Console.WriteLine();

        Console.WriteLine("Greetings from MyPet class!");//writes the text to the console window
    }

    /// <summary>
    /// Reads the name of the pet 
    /// </summary>
    private void ReadName()
    {

        Console.WriteLine();//creates a blank line

        Console.WriteLine("What is the name of your pet?");//prompt the user to write input of their pet name

        name = Console.ReadLine();//returns a line of text from the console window

        Console.WriteLine();
    }

    /// <summary>
    ///  Reads the age of the pet
    /// </summary>
    private void ReadAge()
    {
        Console.WriteLine($"What is {name}'s age?");//gets the name of the pet

        string? strAge = Console.ReadLine()!;

        age = int.Parse(strAge);//convert the text to number 

        Console.WriteLine();
    }

    /// <summary>
    /// Reads and returns pet gender 
    /// </summary>
    /// <returns></returns>
    private bool ReadPetGender()
    {
        Console.WriteLine("Is your pet a female (y/n)");//write the text to the console for user input

        string? response = Console.ReadLine();

        response = response!.ToLower(); //user input can be the following Y, Yes, and yes with the help of ToLower


        if ((response == "y") || (response == "Yes"))

        {
            isFemale = true;//checks if isFemale is true
        }
        else
        {
            
            isFemale = false;//checks if isFemale is false
        }

        Console.WriteLine();//creates blank space

        return isFemale;//return bool
    }

    /// <summary>
    /// Displays general of the pet to the user
    /// </summary>
    /// </summary>
    private void DisplayPetInfo()
    {
        string displayInfo = $"Name: {name}  Age: {age}";//concatinates name and age for the user to see

        string displayWellWishes = name + " is a good dog!";//displays name for the user

        Console.WriteLine("*******************************");// creates blank line

        Console.WriteLine(displayInfo);//displays all the information to the user

        Console.WriteLine(displayWellWishes);//displays well wishes for the user to come back again

        Console.WriteLine("*********************************");

        Console.WriteLine();

        Console.WriteLine("Press Enter to start next page!");//tels the user to click for the next page
    }
}
