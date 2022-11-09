using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Diagnostics;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace KidsFair
{
    internal class Album
    {   //varible to use to get inputs
        private string? favoriteMusicAlbum;
        private string? nameOfAlbumOrBand;
        private int numberOfTracks;

        public void displayInfoAlbum()
        {
            Start();
            ReadFavoriteMusicAlbum();
            ReadNameOfAlbumOrBand();
            ReadNumberOfTracks();
            DisplayUserAnswers();
    }

            /// <summary>
            /// start method
            /// </summary>
            private void Start()
            {
                Console.WriteLine("Starting the Album program!");//text input for the start album page

                Console.WriteLine();//blank line
        }
        /// <summary>
        /// read favourite musiccian album
        /// </summary>
        private void ReadFavoriteMusicAlbum()
        {
            Console.WriteLine("What is the name of your favorite music Album?");//text input for name of music album

             favoriteMusicAlbum = Console.ReadLine();//favorite album user input
            
             Console.WriteLine();
        }
        /// <summary>
        /// read name of album or band method
        /// </summary>
        private void ReadNameOfAlbumOrBand()
        {   
            //name of artist or band text input 
            Console.WriteLine($"What is the name of the Artist or Band for {favoriteMusicAlbum}?");

            nameOfAlbumOrBand = Console.ReadLine();//user input name of album or band

            Console.WriteLine();
        }
        /// <summary>
        /// read number of tracks method
        /// </summary>
        private void ReadNumberOfTracks()
        {   //text input for how many tracks
            Console.WriteLine($"How many tracks does {favoriteMusicAlbum} have?");

            string? strNumberOfTracks = Console.ReadLine();

            numberOfTracks = int.Parse(strNumberOfTracks!);//user input  on number of tracks

            Console.WriteLine();
        }
        /// <summary>
        /// display users answer method
        /// </summary>
       private void DisplayUserAnswers()
        {
            Console.WriteLine($"Album Name: {favoriteMusicAlbum}");//summary album name

            Console.WriteLine();

            Console.WriteLine($"Artist/Band: {nameOfAlbumOrBand}");//summary name of band or album

            Console.WriteLine();

            Console.WriteLine($"Number of tracks:  {numberOfTracks}");//summary number of tracks

            Console.WriteLine();

            Console.WriteLine("Enjoy listening!");//text input for the user to enjoy listening
        }
    }
}
