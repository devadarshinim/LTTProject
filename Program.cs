using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LTTTask
{
    class Program
    {
        static void Main(string[] args)
        {
            string str = "0";

            do
            {
                Console.WriteLine("Welcome you");
                Console.WriteLine("Enter the Id to register");
                string id = Console.ReadLine();
                int idnum;
                if (int.TryParse(id, out idnum))
                {
                    Console.
                        WriteLine("Enter First Name");
                    string firstName = Console.ReadLine();
                    Console.
                        WriteLine("Enter Second Name");
                    string secondName = Console.ReadLine();
                    Console.WriteLine("Enter DOB in DD-MM-YYYY format");
                    string dob = Console.ReadLine();
                    Console.WriteLine("Enter your contact number");
                    string contactNo = Console.ReadLine();
                    Dictionary<int, string> My_dict =
new Dictionary<int, string>();
                    Console.WriteLine("Enter number According to Option: 1:B.Com \n 2:B.E \n 3:B.sc");
                    string optiom = Console.ReadLine();
                    int option = Int32.Parse(optiom);
                    {
                        if (option == 1)
                        {
                            Console.WriteLine("Thank you for selecting B.Com");
                            Console.WriteLine("The ount need to be paid :5000");
                            Console.WriteLine("Enter 1 to continue option Else the register process will star from first");
                            str = Console.ReadLine();
                            if (str == "1")
                            {

                                My_dict.Add(idnum, firstName);
                                My_dict.Add(idnum, secondName);
                                My_dict.Add(idnum, dob);
                                My_dict.Add(idnum, "B.COM");
                                My_dict.Add(idnum, contactNo);
                                My_dict.Add(idnum, "5000");


                            }
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Thank you for selecting B.E");
                            Console.WriteLine("The ount need to be paid :50000");
                            Console.WriteLine("Enter 1 to continue option Else the register process will start from first");
                            str = Console.ReadLine();
                            if (str == "1")
                            {

                                My_dict.Add(idnum, firstName);
                                My_dict.Add(idnum, secondName);
                                My_dict.Add(idnum, dob);
                                My_dict.Add(idnum, "B.E");
                                My_dict.Add(idnum, contactNo);
                                My_dict.Add(idnum, "50000");


                            }
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Thank you for selecting B.Sc");
                            Console.WriteLine("The ount need to be paid :20000");
                            Console.WriteLine("Enter 1 to continue option Else the register process will begin from first");
                            str = Console.ReadLine();
                            if (str == "1")
                            {

                                My_dict.Add(idnum, firstName);
                                My_dict.Add(idnum, secondName);
                                My_dict.Add(idnum, dob);
                                My_dict.Add(idnum, "B.Sc");
                                My_dict.Add(idnum, contactNo);
                                My_dict.Add(idnum, "20000");


                            }
                        }
                        else
                        {
                            Console.WriteLine("Invalid Entry");
                        }
                    }
                }
                else
                {
                    Console.WriteLine("You Shoud enter a number");
                }
            }
            while (str == "1");
            Console.WriteLine("Do you whant to print details press 1");


        }

    }
}