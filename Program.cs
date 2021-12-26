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
            int j = 1001;
            IDictionary<int, string> lNames = new Dictionary<int, string>();
            IDictionary<int, string> fNames = new Dictionary<int, string>();
            IDictionary<int, string> ddob = new Dictionary<int, string>();
            IDictionary<int, string> contact = new Dictionary<int, string>();
            IDictionary<int, string> course = new Dictionary<int, string>();
            IDictionary<int, int> admitionId = new Dictionary<int, int>();
            IDictionary<int, int> amount = new Dictionary<int, int>();
            IDictionary<int, int> st = new Dictionary<int, int>();
            do{
                
        
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
                            lNames.Add(new KeyValuePair<int, string>(idnum, secondName));
                            fNames.Add(new KeyValuePair<int, string>(idnum, firstName));
                            ddob.Add(new KeyValuePair<int, string>(idnum, dob));
                            contact.Add(new KeyValuePair<int, string>(idnum, contactNo));
                            course.Add(new KeyValuePair<int, string>(idnum, "B.Com"));
                            admitionId.Add(new KeyValuePair<int, int>(idnum, j));
                            amount.Add(new KeyValuePair<int, int>(idnum, 5000));
                            st.Add(new KeyValuePair<int, int>(idnum, 5000));
                            j++;
                        }
                        else if (option == 2)
                        {
                            Console.WriteLine("Thank you for selecting B.E");
                            Console.WriteLine("The amount need to be paid :50000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");
                            str = Console.ReadLine();
                            lNames.Add(new KeyValuePair<int, string>(idnum, secondName));
                            fNames.Add(new KeyValuePair<int, string>(idnum, firstName));
                            ddob.Add(new KeyValuePair<int, string>(idnum, dob));
                            contact.Add(new KeyValuePair<int, string>(idnum, contactNo));
                            course.Add(new KeyValuePair<int, string>(idnum, "B.E"));
                            amount.Add(new KeyValuePair<int, int>(idnum, 500000));
                            admitionId.Add(new KeyValuePair<int, int>(idnum, j));
                            st.Add(new KeyValuePair<int, int>(idnum, 500000));
                            j++;
                        }
                        else if (option == 3)
                        {
                            Console.WriteLine("Thank you for selecting B.Sc");
                            Console.WriteLine("The amount need to be paid :20000");
                            Console.WriteLine("Enter 1 to add new user  else press any other key");
                            str = Console.ReadLine();
                            lNames.Add(new KeyValuePair<int, string>(idnum, secondName));
                            fNames.Add(new KeyValuePair<int, string>(idnum, firstName));
                            ddob.Add(new KeyValuePair<int, string>(idnum, dob));
                            contact.Add(new KeyValuePair<int, string>(idnum, contactNo));
                            course.Add(new KeyValuePair<int, string>(idnum, "B.Sc"));
                            amount.Add(new KeyValuePair<int, int>(idnum, 20000));
                            admitionId.Add(new KeyValuePair<int, int>(idnum, j));
                            st.Add(new KeyValuePair<int, int>(idnum, 20000));
                            j++;
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
            Console.WriteLine("Enter 1 to display the Register Detail");
            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
            Console.WriteLine("Enter 3 to display the selected course");
            Console.WriteLine("Enter 4 other key to exit");
            string opt = Console.ReadLine();
            int op;
            if (int.TryParse(opt, out op))
                do
                {
                    if (op == 1)
                    {
                        Console.WriteLine("Enter your reg no");
                        string adm = Console.ReadLine();
                        int x = Int32.Parse(adm);
                        if (lNames.ContainsKey(x))
                        {
                            Console.WriteLine("First Name : {0} ", fNames[x]);
                            Console.WriteLine("Last Name : {0}", lNames[x]);
                            Console.WriteLine("Date of birth : {0}", ddob[x]);
                            Console.WriteLine("Contact No : {0}", contact[x]);
                            Console.WriteLine("Course : {0}", course[x]);
                            Console.WriteLine("Amount : {0}", amount[x]);
                            Console.WriteLine("Admission ID :{0}", admitionId[x]);
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());

                        }
                        else
                        {
                            Console.WriteLine("Incorrect reg no");
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());

                        }
                    }
                    else if (op == 2)
                    {
                        Console.WriteLine("Enter your reg no");
                        string adm = Console.ReadLine();
                        int x = Int32.Parse(adm);
                        if (lNames.ContainsKey(x))
                        {
                            Console.WriteLine("Amount : {0}", amount[x]);
                            int amo = amount[x];
                            do
                            {
                                Console.WriteLine("Amount need to be paid {0}", st[x]);

                                Console.WriteLine("Do you like to pay ammount : If yes press 1 Else press 2");
                                string check = Console.ReadLine();
                                if (check == "1")
                                {
                                    Console.WriteLine("Enter the ammount need to be paid");
                                    string pay = Console.ReadLine();
                                    int a = Int32.Parse(pay);
                                    if (a <= amo)
                                    {
                                        //Console.WriteLine("Ammount remmain to be paid : {0}", amo - a);
                                        amo = amo - a;
                                        st[x]=amo;
                                        Console.WriteLine("Amount need to be paid {0}", st[x]);
                                        if (amo <= 0)
                                        {
                                            op = 2;
                                        }
    
                                    }
                                    else
                                    {
                                        Console.WriteLine("The ammount given is higher than amount need to be paid ");
                                        Console.WriteLine("Do you like to pay ammount : If yes press 1 Else press 2");
                                        op = int.Parse(Console.ReadLine());
                                    }
                                }

                            }
                            while (op == 1);
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect reg no");
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());


                        }

                    }
                    if (op == 3)
                    {
                        Console.WriteLine("Enter your reg no");
                        string adm = Console.ReadLine();
                        int x = Int32.Parse(adm);
                        if (lNames.ContainsKey(x))
                        {
                            Console.WriteLine("Course : {0}", course[x]);
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());
                        }
                        else
                        {
                            Console.WriteLine("Incorrect reg no");
                            Console.WriteLine("Enter 1 to display the Register Detail");
                            Console.WriteLine("Enter 2 to display the total ammount and balance to be paid ");
                            Console.WriteLine("Enter 3 to display the selected course");
                            Console.WriteLine("Enter 4 other key to exit");
                            op = int.Parse(Console.ReadLine());

                        }
                    }

                }

                while (op < 4);
            {
                Console.WriteLine("You had been exited");
            }

        }
    }
}
