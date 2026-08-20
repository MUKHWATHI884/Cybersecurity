using System;
using System.Collections.Generic;
using System.Media;
using Cybersecurity;


namespace Cybersecurity
{

    public class Programming
    {
        static void Main(string[] args)
        {
            Logo logo = new Logo();
            logo.ShowLogo();

            SoundPlayer player = new System.Media.SoundPlayer();
            player.Play();

            Responspe response = new Response();
            response.StartChat();
        }
    }

}
