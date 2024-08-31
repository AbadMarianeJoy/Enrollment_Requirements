using System;
using System.IO;

namespace EnrolliesReq
{
    internal class Program
    {
        static void Main(string[] args)
        {
            while (true)
            {
                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.WriteLine("֎֎֎֎֎֎֎֎ Hello,Fresh Graduates!!! ֎֎֎֎֎֎֎֎֎");


                Console.OutputEncoding = System.Text.Encoding.Unicode;
                Console.Write("\nᴥᴥᴥᴥ Please,enter your name: ");
                string Name = Console.ReadLine().Trim().ToLower();



                {
                    // Directory path where documents are expected to be
                    string directoryPath = @"C:\Users\YANYAN\Desktop\Enrollies_Requirement";


                    // Ask the user if they want to enroll
                    Console.OutputEncoding = System.Text.Encoding.Unicode;
                    Console.Write("☻☻☻☻ Do you want to enroll in our program? (yes/no): ");
                    string userInput = Console.ReadLine().Trim().ToLower();

                    if (userInput == "yes")
                    {
                        Console.OutputEncoding = System.Text.Encoding.Unicode;
                        Console.Write("\n♣♣♣♣This enrollment transaction needs more than ₱ 32 000,\nHow much money do you have?: ");
                        if (double.TryParse(Console.ReadLine(), out double money))
                        {
                            if (money > 32000)
                            {
                                Console.WriteLine("\nHave you submitted the following documents?\n");
                                Console.WriteLine("  → Form 138");
                                Console.WriteLine("  → SHS DIPLOMA");
                                Console.WriteLine("  → GOOD MORAL");
                                Console.WriteLine("  → PSA");
                                Console.WriteLine("  → MEDICAL CERTIFICATE");
                                Console.Write("\nEnter 'yes' if all documents are submitted: ");
                                string submit = Console.ReadLine().Trim().ToLower();

                                if (submit == "yes")
                                {
                                    if (Directory.Exists(directoryPath))
                                    {
                                        // File names to check
                                        string[] filesToCheck = {
                                        "Form_138.pdf",
                                        "SHS_DIPLOMA.pdf",
                                        "GOOD_MORAL.pdf",
                                        "PSA.pdf",
                                        "MEDICAL_CERTIFICATE.pdf"
                                    };

                                        bool allFilesExist = true;

                                        foreach (string filename in filesToCheck)
                                        {
                                            string filePath = Path.Combine(directoryPath, filename);
                                            if (File.Exists(filePath))
                                            {
                                                Console.WriteLine($"\nFile {filename} exists at \n→ {filePath}.");
                                            }
                                            else
                                            {
                                                Console.WriteLine($"\nFile {filename} does not exist at \n{filePath}.");
                                                allFilesExist = false;
                                            }
                                        }

                                        if (allFilesExist)
                                        {
                                            Console.WriteLine("All required files are present.");
                                            Console.WriteLine($"\nWELCOME TO OUR SCHOOL,{Name.ToUpper()}!!");
                                            Console.WriteLine("We're delighted to have you with us. \nPrepare yourself for a memorable and enjoyable experience");
                                            Console.WriteLine("☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺☺  \n\n\n");
                                            continue;
                                        }
                                        else
                                        {
                                            Console.WriteLine("\nPlease make sure all required files are submitted.\n\n");
                                            continue;
                                        }
                                    }
                                    else
                                    {
                                        Console.WriteLine("\nThe specified directory does not exist.\n\n");
                                        continue;
                                    }
                                }
                                else
                                {
                                    Console.WriteLine("\nPlease make sure you have submitted all required documents.\n\n");
                                    continue;
                                }
                            }
                            else
                            {
                                Console.WriteLine("\nSorry, you don't have enough money to enroll.\n\n");
                                continue;
                            }
                        }
                        else
                        {
                            Console.WriteLine("\nInvalid amount entered.\n\n");
                            continue;
                        }
                    }
                    else if (userInput == "no")
                    {
                        Console.WriteLine("No problem. Let us know if you change your mind.");
                        Console.WriteLine("Press enter key to exit ...");
                        Console.Read();
                        break; // Exit the loop
                    }
                    else
                    {
                        Console.WriteLine("Invalid input.\n\n");
                    }
                }

                // Keep the console open until the user presses a key
                Console.WriteLine("Press enter key to for next transaction...");
                Console.ReadKey();

            }
        }
    }
}