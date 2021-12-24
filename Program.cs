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
            Console.WriteLine("Welcome you");


            do
            {
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
                    Dictionary<int, object> My_dict =
new Dictionary<int, object>();
                    Console.WriteLine("Enter number According to Option: 1:B.Com \n 2:B.E \n 3:B.sc");
                    string optiom = Console.ReadLine();
                    int option = Int32.Parse(optiom);
                    {
                        if (option == 1)
                        {
                            Console.WriteLine("Thank you for selecting B.Com");
                            Console.WriteLine("The amount need to be paid :5000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");
                            str = Console.ReadLine();

                            Admission admidssion = new Admission(firstName, secondName, contactNo, dob, "B.Com", 5000);
                            My_dict.Add(123, admidssion);


                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Thank you for selecting B.E");
                            Console.WriteLine("The amount need to be paid :50000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");
                            str = Console.ReadLine();

                            Admission admidssion = new Admission(firstName, secondName, contactNo, dob, "B.E", 50000);

                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Thank you for selecting B.Sc");
                            Console.WriteLine("The ount need to be paid :20000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");

                            str = Console.ReadLine();

                            Admission admidssion = new Admission(firstName, secondName, contactNo, dob, "B.Sc", 20000);

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
            Console.WriteLine("Do you whant to print details press 1 \nIf need to display your");
            string print = Console.ReadLine();
            int val;
            if (int.TryParse(print, out val))
            {
                Console.WriteLine("");
            }
            else
            {
                Console.WriteLine("You had entered a invalid number so the process is stopped");
            }
        }

    }
    class Admission
    {
        public string name;
        public int age;
        public string firstName;
        public string lastName;
        public string contact;
        public string dob;
        public string course;
        public int fee;
        public Admission(string firstName, string lastName, string contact, string course, string dob, int fee)  // Instance constructor.
        {
            this.firstName = firstName;
            this.lastName = lastName;
            this.contact = contact;
            this.dob = dob;
            this.course = course;
            this.fee = fee;

        }
    }
}