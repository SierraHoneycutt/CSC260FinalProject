using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FinalProject.MediaTracker
{
	public class MediaTracker
    {
        //media list
        private List<Media> mediaItems = new List<Media>();
        public void AddMediaItem(Media media)
        {
            mediaItems.Add(media);
        }
        // add other methods to get and display media for user

        //main method to run console UI
        static void Main(string[] args)
        {
            MediaTracker tracker = new MediaTracker();
            //loop for user interface
            while (true)
            {
                Console.WriteLine("Welcome to your personal media tracker!");
                Console.WriteLine("What would you like to do?");
                Console.WriteLine("(1) Add Media");
                Console.WriteLine("(2) View Media");
                Console.WriteLine("(3) Exit");
                Console.WriteLine("Please choose a number: ");
                string choice = Console.ReadLine();

                switch (choice)
                {
                    case "1":
                        addMedia(tracker);
                        break;
                    case "2":
                        viewMedia(tracker);
                        break;
                    case "3":
                        Console.WriteLine("Thank you for using your Media Tracker. See you later!");
                        return;
                    default:
                        Console.WriteLine("Please choose a valid option");
                        break;
                }
            }
        }
        private static void addMedia(MediaTracker tracker)
        {
            throw new NotImplementedException();
        }
        private static void viewMedia(MediaTracker tracker)
        {
            throw new NotImplementedException();
        }
    }
    }


