using System;
using System.ComponentModel;

namespace binarytree
{
    class Program
    {
        public class Knoten
        {
            public Knoten links { get; set; }
            public Knoten rechts { get; set; }
            public int data { get; set; }

        }
        public class BinaryTree
        {
            
            public void Ausgabe(Knoten root)
            {
                Console.WriteLine("Wurzel Wert:{0}", root.data);
                Console.WriteLine("Linker Wurzel Wert:{0}", root.links.data );
                Console.WriteLine("Rechter Wurzel Wert:{0}", root.rechts.data);   
            }
            public Knoten Einfuegen(Knoten root, string value)
            {
                if (root == null)
                {
                    root = new Knoten();
                    root.data = Convert.ToInt32(value);
                }
                else if (Convert.ToInt32(value) < root.data)
                {
                    root.links = Einfuegen(root.links, value);
                }
                else
                {
                    root.rechts = Einfuegen(root.rechts, value);
                }
                return root;
            }

        }
        static void Main(string[] args)
        {
            var tree = new BinaryTree();
            tree.Einfuegen(new Knoten(), "1");
            tree.Einfuegen(new Knoten(), "2");
            tree.Einfuegen(new Knoten(), "1");

            Console.WriteLine(tree);
    


        }
    }
}
