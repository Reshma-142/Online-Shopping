using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;

namespace onlineshoppingprojecct
{ 
internal class Program
    {
        public static int c1;
       public static string pattern = @"^[6-9]\d{9}$";
        public static string pattern1 = @"^[a-zA-Z0-9._%+-]+@[a-zA-Z0-9.-]+\.[a-zA-Z]{2,}$";

        public static double gst1;
    public static List<int> a9 = new List<int>();
        public static int a, a2, a5, a6, a8, a10, a11, a12, a13, a14,a20;
        public static string a1 = "ADMIN", a3, a4;
        public static double total1;
        public static int b;
        public static string[] d3 = new string[100];
        public static int[] d4 = new int[100];
        static void Main(string[] args)
        {


            List<int> a9 = new List<int>();
            Console.ForegroundColor = ConsoleColor.Yellow;
            Console.WriteLine("-------------------WELCOME TO ONLINE SHOPPING--------------------");
            Console.WriteLine();
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine();
        Y: Console.WriteLine("               Choose the Login type");
            Console.WriteLine("                   1. ADMIN");
            Console.WriteLine("                   2. USER");
            a = Convert.ToInt32(Console.ReadLine());
           
            if (a == 1)
            {
                Console.ForegroundColor = ConsoleColor.Green;
                Console.WriteLine("              WELCOME TO ADMIN PAGE     ");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("              ADMIN Login ID : ADMIN");
                Console.WriteLine("              ADMIN Password : ADMIN");
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Cyan;
                Console.WriteLine("         Do you want to reset Admin password");
                Console.WriteLine("                1. Yes");
                Console.WriteLine("                2. No");
                a2 = Convert.ToInt32(Console.ReadLine());
                
                if (a2 == 1)
                {
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Blue;
                B: Console.Write("Enter new password (8 characters Only) : ");
                    a3 = Console.ReadLine();
                    
                    if (a3.Length > 8)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Entered password is not in specified format!! Please try again ");
                        
                        goto B;
                        
                    }
                    else
                    {
                        Console.WriteLine("Admin Password updated Successfully..");
                        a1 = a3;
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine("             WELCOME TO LOGIN PAGE");
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine();
                C: Console.WriteLine("              ADMIN Login ID : ADMIN");
                    Console.Write("              ADMIN Password : ");
                    a4 = Console.ReadLine();
                    
                    if (a4 == a1)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("         WELCOME TO ADMIN DASHBOARD");
                    }
                    else
                    {
                        Console.WriteLine("Password is Incoorect!Please tryagain");
                        goto C;
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Green;
                    Console.WriteLine("           Do You want to add items");
                    Console.WriteLine("                1. Yes");
                    Console.WriteLine("                2. No");
                    a5 = Convert.ToInt32(Console.ReadLine());
                   
                    if (a5 == 1)
                    {
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter number of items to be added : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        
                        for (int i = 1; i <= b; i++)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("Enter the name of the " + i + " item : ");
                            d3[i] = Console.ReadLine();
                            Console.Write("Enter the Cost of the " + i + " item : ");
                            d4[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Name of the item" + "             " + "Cost of the item");
                        for (int i = 1; i <= b; i++)
                        {
                            Console.WriteLine("    " + d3[i] + "                    " + d4[i]);

                        }
                        



                        goto Y;
                    }
                    if (a5 == 2)
                    {
                        Console.WriteLine("NAME OF THE ITEM"+"                 "+"COST OF THE ITEM");
                    }
                }
                if(a2==2)
                {
                    Console.WriteLine();
                    Console.WriteLine("WELCOME TO ADMIN LOGIN");
                    Console.WriteLine("ADMIN LOGIN : ADMIN");
                        Console . WriteLine("ADMIN PASSWORD : ADMIN");
                    Console.WriteLine();
                    Console.WriteLine("           Do You want to add items");
                    Console.WriteLine("                1. Yes");
                    Console.WriteLine("                2. No");
                    a5 = Convert.ToInt32(Console.ReadLine());
                    
                    if (a5 == 1)
                    {
                        Console.WriteLine();

                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Enter number of items to be added : ");
                        b = Convert.ToInt32(Console.ReadLine());
                        for (int i = 1; i <= b; i++)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkCyan;
                            Console.Write("Enter the name of the " + i + " item : ");
                            d3[i] = Console.ReadLine();
                            Console.Write("Enter the Cost of the " + i + " item : ");
                            d4[i] = Convert.ToInt32(Console.ReadLine());
                        }
                        
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.WriteLine("Name of the item" + "             " + "Cost of the item");
                        for (int i = 1; i <= b; i++)
                        {
                            Console.WriteLine("    " + d3[i] + "                     " + d4[i]);

                        }
                        


                        goto Y;
                    }
                    
                }
            }
            if (a == 2)
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine("Name of the item" + "                 " + "Cost of the item");
                Console.ForegroundColor = ConsoleColor.DarkGray;

                for (int i = 1; i <= b; i++)
                {
                    Console.WriteLine("    " + d3[i] + "                    " + d4[i]);

                }
                Console.WriteLine();
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.Write("Enter no of items to add in your cart : ");
                a12 = Convert.ToInt32(Console.ReadLine());
                if (a12 != 0)
                {
                    int[] a16 = new int[a12];
                    for (int i = 0; a16.Length > i; i++)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.Write("Please enter the index number you want to add the item in your cart :");
                        a16[i] = Convert.ToInt32(Console.ReadLine());
                        Console.Write("Enter how many units you need : ");
                        a14 = Convert.ToInt32(Console.ReadLine());
                        a9.Add(a14);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Magenta;
                    Console.WriteLine("=====CART=====");
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.DarkBlue;
                    Console.WriteLine("NAME OF THE ITEM" + "                        " + "UNITS" + "                            " + "COST OF THE ITEM");
                    
                    for (int i = 0; a16.Length > i; i++)
                    {
                        Console.WriteLine(d3[a16[i]] + "                                       " + a9[i] + "                                              " + d4[a16[i]]);
                    }
                    Console.WriteLine();
                    Console.ForegroundColor = ConsoleColor.Red;
                O: Console.WriteLine("Do You want to continue shopping");
                    Console.WriteLine("1. Yes");
                    Console.WriteLine("2. No");
                    a12 = Convert.ToInt32(Console.ReadLine());
                    if (a12 == 1)
                    {
                        Console.WriteLine("Name of the item" + "                 " + "Cost of the item");
                        Console.ForegroundColor = ConsoleColor.DarkGray;

                        for (int i = 1; i <= b; i++)
                        {
                            Console.WriteLine("    " + d3[i] + "                      " + d4[i]);

                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Magenta;
                        Console.Write("Enter number of items to be added : ");
                        a20=Convert.ToInt32(Console.ReadLine());
                         int[] c10 = new int[a20];
                        for(int i=0;c10.Length>i;i++)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Blue;
                            Console.Write("Please enter the index number you want to add the item in your cart : ");
                            a16[i] = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            Console.Write("Enter how many units you need : ");
                            a14 = Convert.ToInt32(Console.ReadLine());
                            a9.Add(a14);
                        }
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("NAME OF THE ITEM" + "                        " + "UNITS" + "                            " + "COST OF THE ITEM");
                        for (int i = 0; a16.Length > i; i++)
                        {
                            Console.WriteLine(d3[a16[i]] + "                                       " + a9[i] + "                                              " + d4[a16[i]]);
                        }
                        for (int i = 1; c10.Length > i; i++)
                        {
                            Console.WriteLine(d3[c10[i]] + "                      " + a9[i] + "                          " + d4[c10[i]]);
                        }

                        

                        Console.ForegroundColor = ConsoleColor.DarkCyan;
                        for (int i = 0; c10.Length > i; i++)
                        {
                            int m, o;
                            string n;
                            m = d4[a16[i]];
                            n = d3[a16[i]];
                            o = a9[i];
                            total1 = total1 + (m * o);

                            Console.WriteLine(n + "                                 " + o + "                               " + m);
                        }


                        double gsta;
                        gsta = (total1 * 18) / 100;
                        gst1= total1 + gsta;

                        goto O;

                    }
                    if (a12 == 2)
                    {
                        Console.WriteLine();
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Are you ready for billing");
                        Console.WriteLine("1. Yes");
                        Console.WriteLine("2. No");
                        a10 = Convert.ToInt32(Console.ReadLine());
                        
                        if (a10 == 1)
                        {
                            string name, email, str, lan, ci, st, cu, us, p, mob, u1, p1;
                            int pin;
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.Write("Name      :");
                            Console.WriteLine();
                            name = Console.ReadLine();
                        V: Console.Write("Contact no :");
                            Console.WriteLine();
                            mob = Console.ReadLine();
                            Regex x = new Regex(pattern);
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (x.IsMatch(mob.ToString()))
                            {
                                Console.WriteLine("VALID");
                            }
                            else
                            {
                                Console.WriteLine("INVALID");
                                goto V;

                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine();
                        N1: Console.Write("Mail Id   : ");

                            email = Console.ReadLine();
                            Regex x1 = new Regex(pattern1);
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (x1.IsMatch(email))
                            {
                                Console.WriteLine();
                                Console.WriteLine("VALID");
                            }
                            else
                            {
                                Console.WriteLine("INVALID");
                                goto N1;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                            Console.WriteLine();
                            Console.WriteLine("Address:");
                            Console.WriteLine();
                            Console.Write("Street name :");
                            str = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("Land mark :");
                            lan = Console.ReadLine();
                            Console.WriteLine();
                            Console.Write("City      :");
                            ci = Console.ReadLine();
                            Console.WriteLine();
                        N4: Console.Write("Pincode   :");
                            pin = Convert.ToInt32(Console.ReadLine());
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (pin.ToString().Length > 7)
                            {
                                Console.WriteLine("VALID");
                                goto N4;
                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;

                            Console.Write("State    :");
                            st = Console.ReadLine();
                            Console.Write("Country  : ");
                            cu = Console.ReadLine();
                        N2: Console.Write("User Id  :");
                            us = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (us.Length > 9)
                            {
                                Console.WriteLine("Please Specify Only 8 characters");
                                goto N2;

                            }
                            Console.ForegroundColor = ConsoleColor.DarkGreen;
                        N3: Console.Write("User Password :");
                            p = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Red;
                            if (p.Length > 8)
                            {
                                Console.WriteLine("Enter password in specified format");
                                goto N3;
                            }


                            
                            Console.ForegroundColor = ConsoleColor.Magenta;
                            Console.WriteLine("WELCOME TO USER LOGIN FORM");
                            Console.Write("USER ID         : ");
                            u1 = Console.ReadLine();
                            Console.WriteLine("PASSWORD    :");
                            p1 = Console.ReadLine();
                            Console.ForegroundColor = ConsoleColor.Green;
                            if (u1 == us && p1 == p)
                            {
                                Console.WriteLine("Logged in Successfully");
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("Name of the item" + "                  " + "Units " + "                           " + "Cost of the item");
                                double total = 0;
                                Console.ForegroundColor = ConsoleColor.DarkCyan;
                                for (int i = 0; a16.Length > i; i++)
                                {
                                    int m, o;
                                    string n;
                                    m = d4[a16[i]];
                                    n = d3[a16[i]];
                                    o = a9[i];
                                    total = total + (m * o);

                                    Console.WriteLine(n + "                                 " + o + "                               " + m);
                                }


                                double gsta, gst;
                                gsta = (total * 18) / 100;
                                gst = total + gsta+gst1;
                                Console.WriteLine("================================================================================================================================");
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Yellow;
                                Console.WriteLine("_ BILLING_");
                                Console.WriteLine("Name : " + name);
                                Console.WriteLine("Contact number" + mob);
                                Console.WriteLine("NAME OF THE ITEM" + "             " + "UNITS" + "                 " + "COST OF THE ITEM");
                                for (int i = 0; a16.Length > i; i++)
                                {
                                    int m, o;
                                    string n;
                                    m = d4[a16[i]];
                                    n = d3[a16[i]];
                                    o = a9[i];


                                    Console.WriteLine(n + "                                   " + o + "                               " + m);
                                }
                                Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Total:" + "                               " + total);
                                Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("GST: 18%");
                                Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                Console.WriteLine("Total Bill:" + "                            " + gst);

                            }

                        }
                        if(a10==2)
                        {
                            Console.WriteLine();
                            Console.ForegroundColor = ConsoleColor.Yellow;
                        P: Console.WriteLine("    Do You want to remove any item in the cart");
                            Console.WriteLine("                  1. Yes");
                            Console.WriteLine("                  2. No");
                            a12 = Convert.ToInt32(Console.ReadLine());
                            if (a12 == 1)
                            {
                                for (int i = 0; a16.Length > i; i++)
                                {
                                    Console.WriteLine(d3[a16[i]] + "                                   " + a9[i] + "                                  " + d4[a16[i]]);
                                }
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Blue;
                                Console.WriteLine("Enter how many items to be removed");
                                a14 = Convert.ToInt32(Console.ReadLine());
                                if (a14 >= 0 && a14 < a16.Length)
                                {
                                    a16 = a16.Where((val, idx) => idx != a14).ToArray();
                                    a9.RemoveAt(a14);
                                    Console.WriteLine("Item removed from cart Successfully");

                                }
                                else
                                {
                                    Console.WriteLine("Invalid Item Index!Please.Try again");

                                }
                                for (int i = 0; a16.Length > i; i++)
                                {
                                    Console.WriteLine(d3[a16[i]] + "                    " + a9[i] + "                          " + d4[a16[i]]);
                                }
                                goto P;
                            }
                            if(a12==2)
                            {
                                string name, email, str, lan, ci, st, cu, us, p, mob, u1, p1;
                                int pin;
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.Write("Name      :");
                                Console.WriteLine();
                                name = Console.ReadLine();
                            V: Console.Write("Contact no :");
                                Console.WriteLine();
                                mob = Console.ReadLine();
                                Regex x = new Regex(pattern);
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (x.IsMatch(mob.ToString()))
                                {
                                    Console.WriteLine("String matched");
                                }
                                else
                                {
                                    Console.WriteLine("String not matched");
                                    goto V;

                                }
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine();
                            N1: Console.Write("Mail Id   : ");

                                email = Console.ReadLine();
                                Regex x1 = new Regex(pattern1);
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (x1.IsMatch(email))
                                {
                                    Console.WriteLine();
                                    Console.WriteLine("Entered email is in correct format");
                                }
                                else
                                {
                                    Console.WriteLine("Entered Email is not in Correct format!Please try again");
                                    goto N1;
                                }
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                                Console.WriteLine();
                                Console.WriteLine("Address:");
                                Console.WriteLine();
                                Console.Write("Street name :");
                                str = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("Land mark :");
                                lan = Console.ReadLine();
                                Console.WriteLine();
                                Console.Write("City      :");
                                ci = Console.ReadLine();
                                Console.WriteLine();
                            N4: Console.Write("Pincode   :");
                                pin = Convert.ToInt32(Console.ReadLine());
                                Console.WriteLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (pin.ToString().Length > 7)
                                {
                                    Console.WriteLine("Enter the pin code correctly...");
                                    goto N4;
                                }
                                Console.ForegroundColor = ConsoleColor.DarkGreen;

                                Console.Write("State    :");
                                st = Console.ReadLine();
                                Console.Write("Country  : ");
                                cu = Console.ReadLine();
                            N2: Console.Write("User Id  :");
                                us = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (us.Length > 9)
                                {
                                    Console.WriteLine("Please Specify Only 8 characters");
                                    goto N2;

                                }
                                Console.ForegroundColor = ConsoleColor.DarkGreen;
                            N3: Console.Write("User Password :");
                                p = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Red;
                                if (p.Length > 8)
                                {
                                    Console.WriteLine("Enter password in specified format");
                                    goto N3;
                                }


                                
                                Console.ForegroundColor = ConsoleColor.Magenta;
                                Console.WriteLine("WELCOME TO USER LOGIN FORM");
                                Console.Write("USER ID         : ");
                                u1 = Console.ReadLine();
                                Console.WriteLine("PASSWORD    :");
                                p1 = Console.ReadLine();
                                Console.ForegroundColor = ConsoleColor.Green;
                                if (u1 == us && p1 == p)
                                {
                                    Console.WriteLine("Logged in Successfully");
                                    Console.ForegroundColor = ConsoleColor.Magenta;
                                    Console.WriteLine("Name of the item" + "                  " + "Units " + "                           " + "Cost of the item");
                                    double total = 0;
                                    Console.ForegroundColor = ConsoleColor.DarkCyan;
                                    for (int i = 0; a16.Length > i; i++)
                                    {
                                        int m, o;
                                        string n;
                                        m = d4[a16[i]];
                                        n = d3[a16[i]];
                                        o = a9[i];
                                        total = total + (m * o);

                                        Console.WriteLine(n + "                                 " + o + "                               " + m);
                                    }


                                    double gsta, gst;
                                    gsta = (total * 18) / 100;
                                    gst = total + gsta + gst1;
                                    Console.WriteLine("================================================================================================================================");
                                    Console.WriteLine();
                                    Console.ForegroundColor = ConsoleColor.Yellow;
                                    Console.WriteLine("_ BILLING_");
                                    Console.WriteLine("Name : " + name);
                                    Console.WriteLine("Contact number" + mob);
                                    Console.WriteLine("NAME OF THE ITEM" + "             " + "UNITS" + "                 " + "COST OF THE ITEM");
                                    for (int i = 0; a16.Length > i; i++)
                                    {
                                        int m, o;
                                        string n;
                                        m = d4[a16[i]];
                                        n = d3[a16[i]];
                                        o = a9[i];


                                        Console.WriteLine(n + "                                   " + o + "                               " + m);
                                    }
                                    Console.WriteLine("-------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Total:" + "                               " + total);
                                    Console.WriteLine("--------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("GST: 18%");
                                    Console.WriteLine("---------------------------------------------------------------------------------------------------------------");
                                    Console.WriteLine("Total Bill:" + "                            " + gst);

                                }


                            }
                        }
                    }
                }
            }
        }
    }
}


