using System;

namespace AmanBank.Presentation
{
	class Program
	{
		// Application execution starts here
		static void Main()
		{
			// Display title
			System.Console.WriteLine("************** Harsha Bank *****************");
			System.Console.WriteLine("::Login Page::");

			// Declare variables to store username and password;
			string userName = null, password = null;

			// Read userName from keyboard
			System.Console.Write("Username: ");
			userName = System.Console.ReadLine();

			// Read password from keyboard only if username is entered
			if (userName != "")
			{
				System.Console.Write("Password: ");
				password = System.Console.ReadLine();
			}

			// Check username and password
			if (userName == "system" && password == "manager")
			{
				// Declare variable to store menu choice
				int mainMenuChoice = -1;

				do
				{
					System.Console.WriteLine("TODO: Main menu here");
					System.Console.WriteLine("1. Customers");
					System.Console.WriteLine("2. Accounts");
					System.Console.WriteLine("3. Funds Transfer");
					System.Console.WriteLine("4. Funds Transfer Statement");
					System.Console.WriteLine("5. Account Statement");
					System.Console.WriteLine("0. Exit");

					System.Console.WriteLine("Enter choice");
					mainMenuChoice = int.Parse(System.Console.ReadLine());

					// Switch-case to check menu choice
					switch (mainMenuChoice)
					{
						// TODO: Customers
						case 1:
							break;
						// TODO:  Accounts
						case 2:
							break;
						// TODO: Funds Transfer
						case 3:
							break;
						// TODO: Funds Transfer Statement
						case 4:
							break;
						// TODO: Account Statement
						case 5:
							break;
					}
				} while (mainMenuChoice != 0);
			}
			else
			{
				System.Console.WriteLine("Invalid username and password");
			}

			// About to exit
			System.Console.WriteLine("Thank you! Visit again.");
			System.Console.ReadKey();
		}
	}
}
