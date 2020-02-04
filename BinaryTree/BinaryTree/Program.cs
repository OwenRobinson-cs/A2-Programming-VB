using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinaryTree
{
    class Program
    {
        public struct Node
        {
            public int leftptr;
            public int rightptr;
            public string NodeData;
        }

        public static Node[] BinaryTree = new Node[9];
        static void Main(string[] args)
        {
            int choice = 0;
            bool loop = true;
            bool found;
            string query;
            FillTree();
            choice = DisplayMenu();

            while (loop == true)
            {
                switch (choice)
                {
                    case 1:
                        Console.Clear();
                        DisplayTree(0);
                        break;
                    case 2:
                        Console.Clear();
                        DisplayTreePost(0);
                        break;
                    case 3:
                        Console.Clear();
                        DisplayTreePre(0);
                        break;
                    case 4:
                        Console.Clear();
                        ArrayDump();
                        break;
                    case 5:
                        Console.WriteLine("Enter the Search Query: ");
                        query = Console.ReadLine();
                        found = SearchTree(BinaryTree, query, 0);

                        if (found == true)
                        {
                            Console.WriteLine("The search Query is contained in the tree.");

                        }
                        else
                        {
                            Console.WriteLine("The Search Query is not contained in the tree.");
                        }
                        break;
                    default:
                        
                        Console.Clear();
                        loop = false;
                        break;

                }
                
                Console.ReadKey();

                if (loop == true)
                {
                    choice = DisplayMenu();
                }
            }
            
        }

        static void ArrayDump()
        {
            Console.WriteLine("Index |      Data    | Left | Right");
            Console.WriteLine("=====================================");

                for (int i = 0; i < BinaryTree.Length; i++)
                {
                    Console.Write(i.ToString().PadRight(6));
                    Console.Write("|");
                    Console.Write(BinaryTree[i].NodeData.PadLeft(10));
                    Console.Write("    |".PadRight(0));
                    Console.Write(BinaryTree[i].leftptr.ToString().PadRight(6));
                    Console.Write("|");
                    Console.WriteLine(BinaryTree[i].rightptr + " ");
                    Console.WriteLine("=====================================");
                }

        }

        static int DisplayMenu()
        {
            int choice;
            Console.WriteLine("Menu: \n \n ");
            Console.WriteLine("Do you Wish to: ");
            Console.WriteLine("1) Display the tree");
            Console.WriteLine("2) Display the Tree in Post Order ");
            Console.WriteLine("3) Display the Tree in Pre-Order");
            Console.WriteLine("4) Dump the Array");
            Console.WriteLine("5) Search the Tree");
            Console.WriteLine("9) Close");

            int.TryParse(Console.ReadLine(), out choice);

            return choice;
        }

        static void FillTree()
        {
            BinaryTree[0].NodeData = "Ford";
            BinaryTree[0].leftptr = 3;
            BinaryTree[0].rightptr = 1;

            BinaryTree[1].NodeData = "Porsche";
            BinaryTree[1].leftptr = 2;
            BinaryTree[1].rightptr = 6;

            BinaryTree[2].NodeData = "Mercedes";
            BinaryTree[2].leftptr = -1;
            BinaryTree[2].rightptr = 4;

            BinaryTree[3].NodeData = "Ferrari";
            BinaryTree[3].leftptr = 5;
            BinaryTree[3].rightptr = -1;

            BinaryTree[4].NodeData = "Nissan";
            BinaryTree[4].leftptr = -1;
            BinaryTree[4].rightptr = -1;

            BinaryTree[5].NodeData = "BMW";
            BinaryTree[5].leftptr = 7;
            BinaryTree[5].rightptr = -1;

            BinaryTree[6].NodeData = "Vauxhall";
            BinaryTree[6].leftptr = -1;
            BinaryTree[6].rightptr = -1;

            BinaryTree[7].NodeData = "Alfa-Romeo";
            BinaryTree[7].leftptr = -1;
            BinaryTree[7].rightptr = -1;

            BinaryTree[8].NodeData = "";
            BinaryTree[8].leftptr = -1;
            BinaryTree[8].rightptr = -1;

        }

        static void DisplayTree(int node)
        {
            if (BinaryTree[node].leftptr != -1)
            {
                DisplayTree(BinaryTree[node].leftptr);
            }
            Console.WriteLine(BinaryTree[node].NodeData);
            if (BinaryTree[node].rightptr != -1)
            {
                DisplayTree(BinaryTree[node].rightptr);
            }
        }

        static void DisplayTreePost(int node)
        {
            if (BinaryTree[node].leftptr != -1)
            {
                DisplayTreePost(BinaryTree[node].leftptr);
            }
            if (BinaryTree[node].rightptr != -1)
            {
                DisplayTreePost(BinaryTree[node].rightptr);
            }
            Console.Write(BinaryTree[node].NodeData);
        }
        static void DisplayTreePre(int node)
        {
            Console.Write(BinaryTree[node].NodeData);
            if (BinaryTree[node].leftptr != -1)
            {
                DisplayTreePre(BinaryTree[node].leftptr);
            }
            if (BinaryTree[node].rightptr != -1)
            {
                DisplayTreePre(BinaryTree[node].rightptr);
            }
            
        }

        static bool SearchTree(Node[] BinaryTree, string searchItem, int currentNode)
        {
            bool found = false;

            if (BinaryTree[currentNode].NodeData == searchItem)
            {
                found = true;
            }
            else
            {
               if (searchItem.CompareTo(BinaryTree[currentNode].NodeData) < 0)
                {
                    //go left
                    if (BinaryTree[currentNode].leftptr == -1)
                    {
                        found = false;
                    }
                    else
                    {
                        found = SearchTree(BinaryTree, searchItem, BinaryTree[currentNode].leftptr);
                    }
                }
               else
                {
                    //go right
                    if (BinaryTree[currentNode].rightptr == -1)
                    {
                        found = false;
                    }
                    else
                    {
                        found = SearchTree(BinaryTree, searchItem, BinaryTree[currentNode].rightptr);
                    }
                }
            }
            return found;
        }
    }
}
