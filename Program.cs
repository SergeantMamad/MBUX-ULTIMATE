using System;

namespace ConsoleApp46
{
    class Program
    {
        static void Main(string[] args)
        {
            int Tb;
            double numberc, Sum,an,ans,min,max,n1;
            int c;
            ans = 0;
            Sum = 0;
            string name, Opc = null, OpY = null;
            Console.ForegroundColor = ConsoleColor.Cyan;
            Console.WriteLine(@"                                                                                        

MMMMMMMM               MMMMMMMMBBBBBBBBBBBBBBBBB   
M:::::::M             M:::::::MB::::::::::::::::B  
M::::::::M           M::::::::MB::::::BBBBBB:::::B 
M:::::::::M         M:::::::::MBB:::::B     B:::::B
M::::::::::M       M::::::::::M  B::::B     B:::::B
M:::::::::::M     M:::::::::::M  B::::B     B:::::B
M:::::::M::::M   M::::M:::::::M  B::::BBBBBB:::::B 
M::::::M M::::M M::::M M::::::M  B:::::::::::::BB  
M::::::M  M::::M::::M  M::::::M  B::::BBBBBB:::::B 
M::::::M   M:::::::M   M::::::M  B::::B     B:::::B
M::::::M    M:::::M    M::::::M  B::::B     B:::::B
M::::::M     MMMMM     M::::::M  B::::B     B:::::B
M::::::M               M::::::MBB:::::BBBBBB::::::B
M::::::M               M::::::MB:::::::::::::::::B 
M::::::M               M::::::MB::::::::::::::::B  
MMMMMMMM               MMMMMMMMBBBBBBBBBBBBBBBBB   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                   
                                                                                                                                                                               
                                                                                                                                                                               
UUUUUUUU     UUUUUUUULLLLLLLLLLL       TTTTTTTTTTTTTTTTTTTTTTTIIIIIIIIIIMMMMMMMM               MMMMMMMM               AAA         TTTTTTTTTTTTTTTTTTTTTTTEEEEEEEEEEEEEEEEEEEEEE
U::::::U     U::::::UL:::::::::L       T:::::::::::::::::::::TI::::::::IM:::::::M             M:::::::M              A:::A        T:::::::::::::::::::::TE::::::::::::::::::::E
U::::::U     U::::::UL:::::::::L       T:::::::::::::::::::::TI::::::::IM::::::::M           M::::::::M             A:::::A       T:::::::::::::::::::::TE::::::::::::::::::::E
UU:::::U     U:::::UULL:::::::LL       T:::::TT:::::::TT:::::TII::::::IIM:::::::::M         M:::::::::M            A:::::::A      T:::::TT:::::::TT:::::TEE::::::EEEEEEEEE::::E
 U:::::U     U:::::U   L:::::L         TTTTTT  T:::::T  TTTTTT  I::::I  M::::::::::M       M::::::::::M           A:::::::::A     TTTTTT  T:::::T  TTTTTT  E:::::E       EEEEEE
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M:::::::::::M     M:::::::::::M          A:::::A:::::A            T:::::T          E:::::E             
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M:::::::M::::M   M::::M:::::::M         A:::::A A:::::A           T:::::T          E::::::EEEEEEEEEE   
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M::::::M M::::M M::::M M::::::M        A:::::A   A:::::A          T:::::T          E:::::::::::::::E   
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M::::::M  M::::M::::M  M::::::M       A:::::A     A:::::A         T:::::T          E:::::::::::::::E   
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M::::::M   M:::::::M   M::::::M      A:::::AAAAAAAAA:::::A        T:::::T          E::::::EEEEEEEEEE   
 U:::::D     D:::::U   L:::::L                 T:::::T          I::::I  M::::::M    M:::::M    M::::::M     A:::::::::::::::::::::A       T:::::T          E:::::E             
 U::::::U   U::::::U   L:::::L         LLLLLL  T:::::T          I::::I  M::::::M     MMMMM     M::::::M    A:::::AAAAAAAAAAAAA:::::A      T:::::T          E:::::E       EEEEEE
 U:::::::UUU:::::::U LL:::::::LLLLLLLLL:::::LTT:::::::TT      II::::::IIM::::::M               M::::::M   A:::::A             A:::::A   TT:::::::TT      EE::::::EEEEEEEE:::::E
  UU:::::::::::::UU  L::::::::::::::::::::::LT:::::::::T      I::::::::IM::::::M               M::::::M  A:::::A               A:::::A  T:::::::::T      E::::::::::::::::::::E
    UU:::::::::UU    L::::::::::::::::::::::LT:::::::::T      I::::::::IM::::::M               M::::::M A:::::A                 A:::::A T:::::::::T      E::::::::::::::::::::E
      UUUUUUUUU      LLLLLLLLLLLLLLLLLLLLLLLLTTTTTTTTTTT      IIIIIIIIIIMMMMMMMM               MMMMMMMMAAAAAAA                   AAAAAAATTTTTTTTTTT      EEEEEEEEEEEEEEEEEEEEEE

                                                                                                                                                        ");
            Console.ResetColor();
            Console.Write("Enter Your Name:");
            name = Console.ReadLine();
            byte Op;
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│                                                                    │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│█████                                                               │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│█████████████████████                                               │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│██████████████████████████████████████                              │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│███████████████████████████████████████████████                     │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│███████████████████████████████████████████████████████████         │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("┌────────────────────────────────────────────────────────────────────┐");
            Console.WriteLine("│█████████████████████████████████████████████████████████████████   │");
            Console.WriteLine("└────────────────────────────────────────────────────────────────────┘");
            Console.WriteLine("                              Loading...                              ");
            System.Threading.Thread.Sleep(3000);
            Console.Clear();
            Console.WriteLine("Welcome {0}", name);
            while (true)
            {
                Console.Clear();
                OpY = null;
                Console.WriteLine("What Do You Want?");
                Console.Write("1)Calculator\n2)Multiplication Table\n3)Averaging numbers\n4)Comparison Numbers\n5)Fun Tools\n6)Exit From Program\n");
                Console.Write("Choose It From Table:");
                if (!byte.TryParse(Console.ReadLine(), out Op))
                {
                    Console.WriteLine("Can you enter Number?");
                    Console.WriteLine("Choose It From Table:");
                }
                else if (Op > 6 || Op < 1)
                {
                    Console.WriteLine("Enter Number From Table Above");
                    Console.WriteLine("Choose It From Table:");
                }
                else if(Op==6)
                {
                    Console.Write("Thanks For Using My Program ");
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(name);
                    System.Threading.Thread.Sleep(3000);
                    break;
                    
                }
                else if(Op==5)
                {
                    Console.Clear();
                    Console.Write(@"@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@...%@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@......@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@.........@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@............@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@...............@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@......(@@@@&.....@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@&.....@@@@@@@@@......@@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@........@@@@@@@@.......@@@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@.........@@@@@@@@.........@@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@...........@@@@@@@@..........@@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@............@@@@@@@@...........@@@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@...............@@@@@@&.............@@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@................@@@@@@...............@@@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@.................@@@@@@.................@@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@....................@@@@...................@@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@@@.............................................@@@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@@.....................@@@@@@@@....................@@@@@@@@@@@@@@@
@@@@@@@@@@@@@@@......................@@@@@@@@.....................@@@@@@@@@@@@@@
@@@@@@@@@@@@@.........................@@@@@@........................@@@@@@@@@@@@
@@@@@@@@@@@@.........................................................@@@@@@@@@@@
@@@@@@@@@@@...........................................................@@@@@@@@@@
@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@@");
                    Console.WriteLine("\nUnder Construction...");
                    System.Threading.Thread.Sleep(5000);
                }
                else if(Op==4)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@" ██████╗ ██████╗ ███╗   ███╗██████╗  █████╗ ██████╗ ███████╗██╗ ██████╗ ███╗   ██╗    ███╗   ██╗██╗   ██╗███╗   ███╗██████╗ ███████╗██████╗ ███████╗
██╔════╝██╔═══██╗████╗ ████║██╔══██╗██╔══██╗██╔══██╗██╔════╝██║██╔═══██╗████╗  ██║    ████╗  ██║██║   ██║████╗ ████║██╔══██╗██╔════╝██╔══██╗██╔════╝
██║     ██║   ██║██╔████╔██║██████╔╝███████║██████╔╝███████╗██║██║   ██║██╔██╗ ██║    ██╔██╗ ██║██║   ██║██╔████╔██║██████╔╝█████╗  ██████╔╝███████╗
██║     ██║   ██║██║╚██╔╝██║██╔═══╝ ██╔══██║██╔══██╗╚════██║██║██║   ██║██║╚██╗██║    ██║╚██╗██║██║   ██║██║╚██╔╝██║██╔══██╗██╔══╝  ██╔══██╗╚════██║
╚██████╗╚██████╔╝██║ ╚═╝ ██║██║     ██║  ██║██║  ██║███████║██║╚██████╔╝██║ ╚████║    ██║ ╚████║╚██████╔╝██║ ╚═╝ ██║██████╔╝███████╗██║  ██║███████║
 ╚═════╝ ╚═════╝ ╚═╝     ╚═╝╚═╝     ╚═╝  ╚═╝╚═╝  ╚═╝╚══════╝╚═╝ ╚═════╝ ╚═╝  ╚═══╝    ╚═╝  ╚═══╝ ╚═════╝ ╚═╝     ╚═╝╚═════╝ ╚══════╝╚═╝  ╚═╝╚══════╝");
                    Console.ResetColor();
                    Console.WriteLine("\nGuide:If You Want See Resault Type 1 In The Box");
                    while(true)
                    {
                        if (OpY == "N" || OpY == "n")
                        {
                            Console.Clear();
                            break;
                        }
                        Console.WriteLine("Enter Your Number:");
                        while (!double.TryParse(Console.ReadLine(),out n1))
                        {
                            Console.WriteLine("Enter A Number...");
                            Console.WriteLine("Enter Your Number:");
                        }
                        max = min = n1;
                        while (true)
                        {
                            Console.WriteLine("Enter Your Number:");
                            while (!double.TryParse(Console.ReadLine(), out n1))
                            {
                                Console.WriteLine("Enter A Number...");
                                Console.WriteLine("Enter Your Number:");
                            }
                            if (n1 == 1)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Biggest Number Is {0} And Your Smallest Number Is {1}", max, min);
                                Console.ResetColor();
                                Console.Write("Do You Want Still Countinue?Type Y If You Want To Countinue And If You Dont Want Prees N:");
                                OpY = Console.ReadLine();
                                if (OpY == "Y" || OpY == "y")
                                {
                                    continue;
                                }
                                else if (OpY == "N" || OpY == "n")
                                {
                                    Console.Clear();
                                    break;
                                }

                                else
                                {
                                    Console.WriteLine("Please Type Y Or N");
                                }
                            }
                            if (n1 < min)
                            {
                                min = n1;
                            }
                            else if (max < n1)
                            {
                                max = n1;
                            }
                        }
                        }
                        
                        
                    
                }
                else if(Op==3)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@" @@@@@@   @@@  @@@  @@@@@@@@  @@@@@@@    @@@@@@    @@@@@@@@  @@@  @@@  @@@   @@@@@@@@     @@@  @@@  @@@  @@@  @@@@@@@@@@   @@@@@@@   @@@@@@@@  @@@@@@@   
@@@@@@@@  @@@  @@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@@  @@@  @@@@ @@@  @@@@@@@@@     @@@@ @@@  @@@  @@@  @@@@@@@@@@@  @@@@@@@@  @@@@@@@@  @@@@@@@@  
@@!  @@@  @@!  @@@  @@!       @@!  @@@  @@!  @@@  !@@        @@!  @@!@!@@@  !@@           @@!@!@@@  @@!  @@@  @@! @@! @@!  @@!  @@@  @@!       @@!  @@@  
!@!  @!@  !@!  @!@  !@!       !@!  @!@  !@!  @!@  !@!        !@!  !@!!@!@!  !@!           !@!!@!@!  !@!  @!@  !@! !@! !@!  !@   @!@  !@!       !@!  @!@  
@!@!@!@!  @!@  !@!  @!!!:!    @!@!!@!   @!@!@!@!  !@! @!@!@  !!@  @!@ !!@!  !@! @!@!@     @!@ !!@!  @!@  !@!  @!! !!@ @!@  @!@!@!@   @!!!:!    @!@!!@!   
!!!@!!!!  !@!  !!!  !!!!!:    !!@!@!    !!!@!!!!  !!! !!@!!  !!!  !@!  !!!  !!! !!@!!     !@!  !!!  !@!  !!!  !@!   ! !@!  !!!@!!!!  !!!!!:    !!@!@!    
!!:  !!!  :!:  !!:  !!:       !!: :!!   !!:  !!!  :!!   !!:  !!:  !!:  !!!  :!!   !!:     !!:  !!!  !!:  !!!  !!:     !!:  !!:  !!!  !!:       !!: :!!   
:!:  !:!   ::!!:!   :!:       :!:  !:!  :!:  !:!  :!:   !::  :!:  :!:  !:!  :!:   !::     :!:  !:!  :!:  !:!  :!:     :!:  :!:  !:!  :!:       :!:  !:!  
::   :::    ::::     :: ::::  ::   :::  ::   :::   ::: ::::   ::   ::   ::   ::: ::::      ::   ::  ::::: ::  :::     ::    :: ::::   :: ::::  ::   :::  
 :   : :     :      : :: ::    :   : :   :   : :   :: :: :   :    ::    :    :: :: :      ::    :    : :  :    :      :    :: : ::   : :: ::    :   : :  ");
                    Console.ResetColor();
                    while (true)
                    {
                        if (OpY == "N" || OpY == "n")
                        {
                            Console.Clear();
                            break;
                            
                        }
                        Console.WriteLine("\nGuide:If You Want See Resault Type 1");
                        for (c=0;c>-1;c++)
                        {
                            if(OpY == "N" || OpY == "n")
                            {
                                Console.Clear();
                                break;
                            }
                            Console.Write("\nEnter Your Number:");
                            while (!double.TryParse(Console.ReadLine(), out an))
                            {
                                Console.WriteLine("Please Enter A Number...");
                                Console.Write("Enter Your Number:");
                            }
                            ans=ans + an;
                            if (an == 1)
                            {
                                ans -=1;
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.WriteLine("Your Resault Is:{0}",ans / c);
                                Console.ResetColor();
                                Console.Write("Do You Want Still Countinue?Type Y If You Want To Countinue And If You Dont Want Prees N:");
                                OpY = Console.ReadLine();
                                if (OpY == "Y" || OpY == "y")
                                {
                                    continue;
                                }
                                else if (OpY == "N" || OpY == "n")
                                {
                                    Console.Clear();
                                    break;
                                }
                                else
                                {
                                    Console.WriteLine("Please Type Y Or N");
                                }
                            }

                        }
                        
                    }
                }
                else if (Op == 2)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.Write(@" ██████   ██████            ████   █████     ███            ████   ███                      █████     ███                         ███████████           █████     ████          
░░██████ ██████            ░░███  ░░███     ░░░            ░░███  ░░░                      ░░███     ░░░                         ░█░░░███░░░█          ░░███     ░░███          
 ░███░█████░███  █████ ████ ░███  ███████   ████  ████████  ░███  ████   ██████   ██████   ███████   ████   ██████  ████████     ░   ░███  ░   ██████   ░███████  ░███   ██████ 
 ░███░░███ ░███ ░░███ ░███  ░███ ░░░███░   ░░███ ░░███░░███ ░███ ░░███  ███░░███ ░░░░░███ ░░░███░   ░░███  ███░░███░░███░░███        ░███     ░░░░░███  ░███░░███ ░███  ███░░███
 ░███ ░░░  ░███  ░███ ░███  ░███   ░███     ░███  ░███ ░███ ░███  ░███ ░███ ░░░   ███████   ░███     ░███ ░███ ░███ ░███ ░███        ░███      ███████  ░███ ░███ ░███ ░███████ 
 ░███      ░███  ░███ ░███  ░███   ░███ ███ ░███  ░███ ░███ ░███  ░███ ░███  ███ ███░░███   ░███ ███ ░███ ░███ ░███ ░███ ░███        ░███     ███░░███  ░███ ░███ ░███ ░███░░░  
 █████     █████ ░░████████ █████  ░░█████  █████ ░███████  █████ █████░░██████ ░░████████  ░░█████  █████░░██████  ████ █████       █████   ░░████████ ████████  █████░░██████ 
░░░░░     ░░░░░   ░░░░░░░░ ░░░░░    ░░░░░  ░░░░░  ░███░░░  ░░░░░ ░░░░░  ░░░░░░   ░░░░░░░░    ░░░░░  ░░░░░  ░░░░░░  ░░░░ ░░░░░       ░░░░░     ░░░░░░░░ ░░░░░░░░  ░░░░░  ░░░░░░  
                                                  ░███                                                                                                                          
                                                  █████                                                                                                                         
                                                 ░░░░░                                                                                                                          ");
                    Console.ResetColor();
                    while (true)
                    {
                        Console.Write("\nType Numbers Of Table:");
                        while (!int.TryParse(Console.ReadLine(), out Tb))
                        {
                            Console.WriteLine("Please Enter A Valid Number.");
                            Console.Write("Type Numbers Of Table:");
                        }
                        for (int a = 1; a <= Tb; a++)
                        {
                            for (int b = 1; b <= Tb; b++)
                            {
                                Console.ForegroundColor = ConsoleColor.Green;
                                Console.Write("{0,2} ", a * b);
                                Console.ResetColor();
                            }
                            Console.WriteLine();
                        }
                        Console.Write("Do You Want Still Countinue?Type Y If You Want To Countinue And If You Dont Want Prees N:");
                        OpY = Console.ReadLine();
                        if (OpY == "Y" || OpY == "y")
                        {
                            continue;
                        }
                        else if (OpY == "N" || OpY == "n")
                        {
                            Console.Clear();
                            break;
                            
                        }
                        else
                        {
                            Console.WriteLine("Please Type Y Or N");
                        }
                    }
                }
                else if (Op == 1)
                {
                    Console.Clear();
                    Console.ForegroundColor = ConsoleColor.Red;
                    Console.WriteLine(@" ____              ___                    ___             __                   
/\  _`\           /\_ \                  /\_ \           /\ \__                
\ \ \/\_\     __  \//\ \     ___   __  __\//\ \      __  \ \ ,_\   ___   _ __  
 \ \ \/_/_  /'__`\  \ \ \   /'___\/\ \/\ \ \ \ \   /'__`\ \ \ \/  / __`\/\`'__\
  \ \ \L\ \/\ \L\.\_ \_\ \_/\ \__/\ \ \_\ \ \_\ \_/\ \L\.\_\ \ \_/\ \L\ \ \ \/ 
   \ \____/\ \__/.\_\/\____\ \____\\ \____/ /\____\ \__/.\_\\ \__\ \____/\ \_\ 
    \/___/  \/__/\/_/\/____/\/____/ \/___/  \/____/\/__/\/_/ \/__/\/___/  \/_/ 
                                                                              ");
                    Console.ResetColor();
                    Console.WriteLine("Guide:\nIf You Want To Sum Type +\nIf You Want Subtract Type -\nIf You Want Multiplication Type *\nIf You Want Devide Type /\nIf You Want See Final Answer Type =");
                    while (true)
                    {
                        do
                        {

                            Console.Write("Please Enter A Valid Number:");

                        } while (!Double.TryParse(Console.ReadLine(), out numberc));
                        //Console.WriteLine("Enter Your Op:");
                        //Opc = Console.ReadLine();
                        if (Opc == null)
                        {
                            Sum = numberc;
                        }
                        else if (Opc == "-")
                        {
                            Sum -= numberc;
                        }
                        else if (Opc == "+")
                        {
                            Sum += numberc;
                        }
                        else if (Opc == "*")
                        {
                            Sum *= numberc;
                        }
                        else if (Opc == "/")
                        {
                            Sum /= numberc;
                        }

                        Console.WriteLine("Enter Your Op:");
                        Opc = Console.ReadLine();

                        if (Opc == "=")
                        {
                            Console.WriteLine("Your Final Answer Is:{0}", Sum);
                            Console.Write("Do You Want Still Countinue?Type Y If You Want To Countinue And If You Dont Want Prees N:");
                            OpY = Console.ReadLine();
                            if (OpY == "Y" || OpY == "y")
                            {
                                continue;
                            }
                            else if (OpY == "N" || OpY == "n")
                            {
                                Console.Clear();
                                break;
                            }
                            else
                            {
                                Console.WriteLine("Please Type Y Or N");
                            }

                        }
                    }
                 
                }




            }
        }
    }
    }

