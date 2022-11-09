using System;
namespace KidsFair;
public class Program
{
    static void Main(string[] args)
    {
        Pet pet = new Pet();

        pet.ReadAndSavePetData();

        Console.WriteLine();

        {
            Console.WriteLine();
            
            TicketSeller ticketSeller = new TicketSeller();
            
            ticketSeller.Start();

        }
        {
            Album album = new Album();

            album.displayInfoAlbum();
        }
    }
  
}