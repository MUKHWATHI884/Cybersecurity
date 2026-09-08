using System;
using System.Media;

namespace Cybersecurity
{
    public class Program
    {
        static void Main(string[] args)
        {
            // Display logo
            Logo logo = new Logo();
            logo.ShowLogo();

            // Play sound
            try
            {
                SoundPlayer player = new SoundPlayer("C:\\Users\\Student\\source\\repos\\Cybersecurity\\ai sound\\ai sound.wav");
                player.Play();
            }
            catch
            {
                Console.WriteLine("Sound could not be played.");
            }

            // Start chatbot
            Response response = new Response();
            response.StartChat();
        }
    }
}
