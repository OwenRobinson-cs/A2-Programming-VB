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
            FillTree();
            choice = DisplayMenu();

            while (loop == true)
            {
                switch (choice)
                {
                    case 1:
                        DisplayTree(0);
                        break;
                    case 2:
                        DisplayTreePost(0);
                        break;
                    case 3:
                        DisplayTreePre(0);
                        break;
                    case 4:
                        Console.WriteLine("            "
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

        static int DisplayMenu()
        {
            int choice;
            Console.WriteLine("Menu: \n \n ");
            Console.WriteLine("Do you Wish to: ");
            Console.WriteLine("1) Display the tree");
            Console.WriteLine("2) Display the Tree in Post Order ");
            Console.WriteLine("3) Display the Tree in Pre-Order");
            Console.WriteLine("4) Search the Tree: ")
            Console.WriteLine("9) Close");

            int.TryParse(Console.ReadLine(), out choice);

            return choice;
        }

        static void FillTree()
        {
            BinaryTree[0].NodeData = "+";
            BinaryTree[0].leftptr = 1;
            BinaryTree[0].rightptr = 2;

            BinaryTree[1].NodeData = "*";
            BinaryTree[1].leftptr = 3;
            BinaryTree[1].rightptr = 4;

            BinaryTree[2].NodeData = "/";
            BinaryTree[2].leftptr = 5;
            BinaryTree[2].rightptr = 6;

            BinaryTree[3].NodeData = "4";
            BinaryTree[3].leftptr = -1;
            BinaryTree[3].rightptr = -1;

            BinaryTree[4].NodeData = "3";
            BinaryTree[4].leftptr = -1;
            BinaryTree[4].rightptr = -1;

            BinaryTree[5].NodeData = "8";
            BinaryTree[5].leftptr = -1;
            BinaryTree[5].rightptr = -1;

            BinaryTree[6].NodeData = "+";
            BinaryTree[6].leftptr = 7;
            BinaryTree[6].rightptr = 8;

            BinaryTree[7].NodeData = "3";
            BinaryTree[7].leftptr = -1;
            BinaryTree[7].rightptr = -1;

            BinaryTree[8].NodeData = "1";
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
    }
}
