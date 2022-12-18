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
				System.Console.WriteLine("TO DO: Main menu here");
			}

			// About to exit
			System.Console.WriteLine("Thank you! Visit again.");
			System.Console.ReadKey();
		}
	}
}
