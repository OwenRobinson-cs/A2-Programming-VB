using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MyQueueFiFo
{
    class Program
    {
        static void Main(string[] args)
        {
            int FQ = 0;
            int NFS = 0;
            string[] MyQueue = new string[10];
            bool Loop = true;
            int Selection = 0;
            
            while (Loop == true)
            {
                if (FQ == NFS)
                {
                    FQ = 0;
                    NFS = 0;
                }
                if (NFS == MyQueue.Length && NFS != FQ)
                {
                    Console.WriteLine("Which option do you wish to choose?\n1) Remove from the Queue\n2) Close the Program\n3) Display the Queue");
                    Console.WriteLine("You are unable to add to the queue for the following reason(s): Queue Full.");
                    int.TryParse(Console.ReadLine(), out Selection);

                    if (Selection == 1)
                    {
                        Console.Clear();
                        RemoveFromQueue(ref FQ, ref MyQueue);
                    }
                    else if (Selection == 3)
                    {
                        Console.Clear();
                        for (int i = 0; i < MyQueue.Length; i++)
                        {

                            Console.WriteLine(MyQueue[i]);
                        }
                        Console.WriteLine("The Next free space is in location: {0}", NFS);
                        Console.WriteLine("The front of the Queue is in location: {0}", FQ);
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Loop = false;
                        Console.Clear();
                        Console.WriteLine("Press any key to close the console.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Which option do you wish to choose?\n1) Add to the Queue\n2) Remove from the Queue\n3) Close the Programa\n4) Display the Queue");
                    int.TryParse(Console.ReadLine(), out Selection);
                    if (Selection == 1)
                    {
                        Console.Clear();
                        AddToQueue(ref NFS, ref MyQueue);
                    }
                    else if (Selection == 2)
                    {
                        Console.Clear();
                        RemoveFromQueue(ref FQ, ref MyQueue);
                    }
                    else if (Selection == 4)
                    {
                        Console.Clear();
                        for (int i = 0; i < MyQueue.Length; i++)
                        {

                            Console.WriteLine(MyQueue[i]);
                        }
                        Console.WriteLine("The Next free space is in location: {0}", NFS);
                        Console.WriteLine("The front of the Queue is in location: {0}", FQ);
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                    }
                    else
                    {
                        Loop = false;
                        Console.Clear();
                        Console.WriteLine("Press any key to close the console.");
                        Console.ReadKey();
                    }
                }

                Selection = 0;
            }
            
        }

        static void AddToQueue(ref int NFS, ref string[] MyQueue)
        {
            Console.Write("Enter content to be added to queue: ");
            MyQueue[NFS] = Console.ReadLine();
            NFS++;
        }

        static void RemoveFromQueue(ref int FQ, ref string[] MyQueue)
        {
            Console.WriteLine("The content that has been removed from the queue is: {0}", MyQueue[FQ]);
            MyQueue[FQ] = "";
            FQ++;
        }
    

    
    }
}
