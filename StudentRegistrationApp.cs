using System;
using System.IO;  

class HelloWorld {
	static void Main() {
		Console.Write("Are you interested in enrolling to STI: ");
		string decide = Console.ReadLine();


        //will determine the users input if invalid or no
		if (decide == "Y" || decide == "y" || decide == "Yes" || decide == "yes" || decide == "YES") {
			Console.WriteLine("---------------------------------------------------------");
			Console.WriteLine("Proceed to enrollment form");
			Console.WriteLine("---------------------------------------------------------");
			
			Console.Write("Do you have your grades? (y/n) ");
            string grades = Console.ReadLine();
			
			Console.Write("Do you have your form137? (y/n) ");
            string form137 = Console.ReadLine();

            Console.Write("Do you have your PSA Birth Certificate? (y/n) ");
            string psa = Console.ReadLine();

            Console.Write("Do you have your Medical Certificate? (y/n) ");
            string medicalCert = Console.ReadLine();

			string directorPath = @"C:\Users\Kambal\source\repos\";  //file location

		

            string[] filesToCheck = {  // list of files
                "GoodMoral.pdf",
                "form137.pdf",
                "grades.xlsx",
                "MedicalCert.pdf"
            };

            // this will check if the file exist or not
            foreach (string fileName in filesToCheck) {
            string filePath = Path.Combine(directorPath, fileName);
                if (File.Exists(filePath)) {
                    Console.WriteLine($"File {fileName} exists.");
                } 
            else {
            Console.WriteLine($"File {fileName} does not exist.");
                }
            }

	
			Console.WriteLine("Thank you! Your documents will be reviewed.");
			} 
			
		else if (decide == "N" || decide == "n" || decide == "No" || decide == "NO") {
			Console.WriteLine("Thank You, i love you boss (Diane)");
		}
		
		else {
			Console.WriteLine("Invalid Input");
		}
	}
}