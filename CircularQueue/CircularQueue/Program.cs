using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CircularQueue
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
            bool FullQueue = false;
            bool EmptyQueue = true;


            while (Loop == true)
            {
                if (NFS > MyQueue.Length - 1)
                {
                    NFS = 0;
                }
                if (FQ > MyQueue.Length - 1)
                {
                    FQ = 0;
                }
                Console.WriteLine(NFS + "        " + FQ);
                if (FullQueue == true)
                {
                    Console.WriteLine("Which option do you wish to choose?\n1) Remove from the Queue\n2) Close the Program\n3) Display the Queue");
                    Console.WriteLine("You are unable to add to the queue for the following reason(s): Queue Full.");
                    int.TryParse(Console.ReadLine(), out Selection);

                    if (Selection == 1)
                    {
                        Console.Clear();
                        RemoveFromQueue(ref FQ, ref MyQueue, NFS, ref EmptyQueue, ref FullQueue);
                    }
                    else if (Selection == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("_____________________");
                        for (int i = 0; i < MyQueue.Length; i++)
                        {

                            Console.WriteLine(MyQueue[i]);
                            Console.WriteLine("_____________________");
                        }
                        Console.WriteLine("The Next free space is in location: {0}", NFS);
                        Console.WriteLine("The front of the Queue is in location: {0}", FQ);
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                    }
                    else if (Selection == 2)
                    {
                        Loop = false;
                        Console.Clear();
                        Console.WriteLine("Press any key to close the console.");
                        Console.ReadKey();
                    }
                }
                else if (EmptyQueue == true)
                {
                    Console.WriteLine("Which option do you wish to choose?\n1) Add to the Queue\n2) Close the Program\n3) Display the Queue");
                    Console.WriteLine("You are unable to remove from the queue due to it being empty.");
                    int.TryParse(Console.ReadLine(), out Selection);
                    if (Selection == 1)
                    {
                        Console.Clear();
                        AddToQueue(ref NFS, ref MyQueue, FQ, ref FullQueue, ref EmptyQueue);
                    }

                    else if (Selection == 3)
                    {
                        Console.Clear();
                        Console.WriteLine("_____________________");
                        for (int i = 0; i < MyQueue.Length; i++)
                        {

                            Console.WriteLine(MyQueue[i]);
                            Console.WriteLine("_____________________");
                        }
                        Console.WriteLine("The Next free space is in location: {0}", NFS);
                        Console.WriteLine("The front of the Queue is in location: {0}", FQ);
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                    }
                    else if (Selection == 2)
                    {
                        Loop = false;
                        Console.Clear();
                        Console.WriteLine("Press any key to close the console.");
                        Console.ReadKey();
                    }
                }
                else
                {
                    Console.WriteLine("Which option do you wish to choose?\n1) Add to the Queue\n2) Remove from the Queue\n3) Close the Program\n4) Display the Queue");
                    int.TryParse(Console.ReadLine(), out Selection);
                    if (Selection == 1)
                    {
                        Console.Clear();
                        AddToQueue(ref NFS, ref MyQueue, FQ, ref FullQueue, ref EmptyQueue);
                    }
                    else if (Selection == 2)
                    {
                        Console.Clear();
                        RemoveFromQueue(ref FQ, ref MyQueue, NFS, ref EmptyQueue, ref FullQueue);
                    }
                    else if (Selection == 4)
                    {
                        Console.Clear();
                        Console.WriteLine("_____________________");
                        for (int i = 0; i < MyQueue.Length; i++)
                        {

                            Console.WriteLine(MyQueue[i]);
                            Console.WriteLine("_____________________");
                        }
                        Console.WriteLine("The Next free space is in location: {0}", NFS);
                        Console.WriteLine("The front of the Queue is in location: {0}", FQ);
                        Console.WriteLine("Press Any Key to Continue");
                        Console.ReadKey();
                    }
                    else if (Selection == 3)
                    {
                        Loop = false;
                        Console.Clear();
                        Console.WriteLine("Press any key to close the console.");
                        Console.ReadKey();
                    }
                }
                FullQueue = false; 
            }

        }

        static void AddToQueue(ref int NFS, ref string[] MyQueue, int FQ, ref bool Queuefull, ref bool QueueEmpty)
        {
            QueueEmpty = false;
            Console.Write("Enter content to be added to queue: ");
            MyQueue[NFS] = Console.ReadLine();
            NFS++;

            if (FQ == NFS) { Queuefull = true; }
        }

        static void RemoveFromQueue(ref int FQ, ref string[] MyQueue, int NFS, ref bool QueueEmpty, ref bool QueueFull)
        {
            Console.WriteLine("The content that has been removed from the queue is: {0}", MyQueue[FQ]);
            MyQueue[FQ] = "";
            FQ++;
            if (FQ == NFS) { QueueEmpty = true; }
        }



    }
}