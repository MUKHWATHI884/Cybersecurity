using System;

namespace Cybersecurity
{
    public class Logo
    {
        public void ShowLogo()
        {
            Console.ForegroundColor = ConsoleColor.Red;

            Console.WriteLine(
                "████████╗██╗  ██╗██╗ █████╗  ██████╗  ██████╗ \r\n" +
                "╚══██╔══╝██║  ██║██║██╔══██╗██╔════╝ ██╔═══██╗\r\n" +
                "   ██║   ███████║██║███████║██║  ███╗██║   ██║\r\n" +
                "   ██║   ██╔══██║██║██╔══██║██║   ██║██║   ██║\r\n" +
                "   ██║   ██║  ██║██║██║  ██║╚██████╔╝╚██████╔╝\r\n" +
                "   ╚═╝   ╚═╝  ╚═╝╚═╝╚═╝  ╚═╝ ╚═════╝  ╚═════╝"
            );

            Console.ResetColor();

            Console.WriteLine();
        }
    }
}
