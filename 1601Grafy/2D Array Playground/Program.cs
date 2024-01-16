using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

/*
 * Made by Jan Borecky for PRG seminar at Gymnazium Voderadska, year 2023-2024.
 * Extended by students.
 */

namespace _2D_Array_Playground
{
    internal class Program
    {
        class Node
        {
            private int index;
            private List<Node> neighbors;
            public Node(int index)
            {
                this.index = index;
                neighbors = new List<Node>();
            }
            public void Addneighbor(Node node)
            {
                if (neighbors.Contains(node))
                {
                    Console.WriteLine($"This node " + node.index + " is already a neighbor of " + node.index);
                }
                else
                {
                    neighbors.Add(node);
                    Console.WriteLine($"Added " + node.index + " to the neighbors of " + node.index);
                }
            }
            public int GetIndex()
            {
                return index;
            }
            public int[] GetNeighborsIndices()
            {
                int[] indices = new int[neighbors.Count];
                for (int i = 0; i < neighbors.Count; i++)
                {
                    indices[i] = neighbors[i].index;
                }
                return indices;
            }
            public Node MoveToNeighbor(int index)
            {
                foreach (Node neighbor in neighbors)
                {
                    if (neighbor.index == index)
                        return neighbor;
                }
                Console.WriteLine("Node " + index + " is not a neighbor of " + this.index);
                return this;
            }
        }
            static void Main(string[] args)
            {
                /* Sousedi
                 * 1 - 4, 6
                 * 2 - 3, 5, 6
                 * 3 - 2, 5
                 * 4 - 1, 6
                 * 5 - 2, 3
                 * 6 - 1, 2, 4
                 */
                Node node1 = new Node(1);
                Node node2 = new Node(2);
                Node node3 = new Node(3);
                Node node4 = new Node(4);
                Node node5 = new Node(5);
                Node node6 = new Node(6);

                node1.Addneighbor(node4);
                node1.Addneighbor(node6);

                node2.Addneighbor(node3);
                node2.Addneighbor(node5);
                node2.Addneighbor(node6);

                node3.Addneighbor(node2);
                node3.Addneighbor(node5);

                node4.Addneighbor(node1);
                node4.Addneighbor(node6);

                node5.Addneighbor(node2);
                node5.Addneighbor(node3);

                node6.Addneighbor(node1);
                node6.Addneighbor(node2);
                node6.Addneighbor(node4);

                Node currentNode = node1;
                while (true)
                {
                    Console.WriteLine("Current node: " + currentNode.GetIndex());
                    Console.Write("Neighbors ");
                    foreach (int neighborIndex in currentNode.GetNeighborsIndices())
                    {
                        Console.Write(neighborIndex + " ");
                    }
                    Console.Write("\n");
                    Console.WriteLine("Choose where to go.");
                    int desireNeighbor = int.Parse(Console.ReadLine());
                    currentNode = currentNode.MoveToNeighbor(desireNeighbor);
                }
                Console.ReadKey();

            }
        }
    }
