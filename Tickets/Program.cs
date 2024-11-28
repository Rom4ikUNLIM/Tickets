using System;
using System.Collections.Generic;
using System.Linq;
using System.Numerics;
using System.Text;
using System.Threading.Tasks;
using Tickets;
using Tickets.TicketTypes;

public class Tickets_Management
{
    public static void Main(string[] args)
    {
        TicketDispenser order;

        string selectedTicketType = "";

        while (true)
        {
            Console.WriteLine($"Choose the type of ticket you want to order: \n1 - Standart(150)\n2 - VIP(220)");
            string choice = Console.ReadLine();

            if (choice == "1")
            {
                selectedTicketType = "Standart";
                order = new Standart();
                break;
            }
            else if (choice == "2")
            {
                selectedTicketType = "VIP";
                order = new VIP();
                break;
            }
            else
            {
                Console.WriteLine("Invalid choice. Please choose 1 or 2");
            }
        }

        while (true)
        {
            Console.WriteLine("Choose the number of tickets: ");
            if (int.TryParse(Console.ReadLine(), out int ticketCount) && ticketCount > 0)
            {
                if (selectedTicketType == "Standart" && order is Standart standartTicketType)
                {
                    if (ticketCount > 0)
                    {
                        int totalCost = standartTicketType.Price * ticketCount;
                        Console.WriteLine($"Total cost for {ticketCount} Standart tickets is {totalCost}. Enjoy your movie! :)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a number greater than 0.\"");
                    }
                }
                else if (selectedTicketType == "VIP" && order is VIP vipTicketType)
                {
                    if (ticketCount > 0)
                    {
                        int totalCost = vipTicketType.Price * ticketCount;
                        Console.WriteLine($"Total cost for {ticketCount} VIP tickets is {totalCost}. Enjoy your movie! :)");
                        break;
                    }
                    else
                    {
                        Console.WriteLine("\"Invalid input. Please enter a number greater than 0.\"");
                    }
                }
            }
            else
            {
                Console.WriteLine("Invalid input. Please enter a positive number.");
            }
        }
    }
}