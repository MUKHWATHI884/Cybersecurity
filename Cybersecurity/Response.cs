using System;

namespace Cybersecurity
{
    public class Response
    {
        public void StartChat()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine("==========================================");
            Console.WriteLine("       Welcome to Cybersecurity Bot!");
            Console.WriteLine("==========================================");
            Console.ResetColor();

           
            bool chatting = true;

            while (chatting)
            {
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.Write("You: ");
                Console.ResetColor();

                string input = Console.ReadLine();

                // Check if the user entered nothing
                if (string.IsNullOrWhiteSpace(input))
                {
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("CyberBot: Please enter a question.");
                    Console.ResetColor();

                    continue;
                }

                // Check if the user wants to exit
                if (input.ToLower().Contains("exit") ||
                    input.ToLower().Contains("quit") ||
                    input.ToLower().Contains("bye"))
                {
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("CyberBot: Goodbye! Stay safe online!");
                    Console.ResetColor();

                    chatting = false;
                }
                else
                {
                    string answer = GetResponse(input);

                    Console.ForegroundColor = ConsoleColor.Yellow;
                    Console.Write("CyberBot: ");
                    Console.ResetColor();

                    Console.WriteLine(answer);
                    Console.WriteLine();
                }
            }
        }


        private string GetResponse(string question)
        {
            question = question.ToLower().Trim();

            // Greeting
            if (question.Contains("hello") ||
                question.Contains("hi") ||
                question.Contains("hey"))
            {
                return "Hello! How can I help you with cybersecurity?";
            }

            // How are you?
            else if (question.Contains("how are you"))
            {
                return "I'm doing well and ready to help you stay safe online!";
            }

            // Purpose
            else if (question.Contains("purpose") ||
                     question.Contains("what do you do"))
            {
                return "My purpose is to provide basic cybersecurity information and help you stay safe online.";
            }

            // What can I ask?
            else if (question.Contains("what can i ask") ||
                     question.Contains("what can I ask"))
            {
                return "You can ask me about passwords, phishing, safe browsing and basic cybersecurity.";
            }

            // Password
            else if (question.Contains("password"))
            {
                return "Use strong and unique passwords. Avoid using personal information, don't reuse passwords across different accounts, and consider using a password manager and multi-factor authentication.";
            }

            // Phishing
            else if (question.Contains("phishing") ||
                     question.Contains("phish"))
            {
                return "Phishing is when criminals pretend to be a trusted person or organisation to trick you into giving away sensitive information. Be careful with suspicious emails, messages and links.";
            }

            // Safe browsing
            else if (question.Contains("safe browsing") ||
                     question.Contains("browsing") ||
                     question.Contains("browse"))
            {
                return "For safe browsing, use trusted websites, check website addresses carefully, keep your browser updated and avoid clicking suspicious links.";
            }

            // Cybersecurity
            else if (question.Contains("cybersecurity") ||
                     question.Contains("cyber security"))
            {
                return "Cybersecurity is the practice of protecting computers, networks, devices and information from online threats and unauthorised access.";
            }

            // Default response
            else
            {
                return "I didn't quite understand that. Could you rephrase? Try asking me about passwords, phishing or safe browsing.";
            }
        }
    }
}
