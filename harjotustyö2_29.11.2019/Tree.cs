using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotustyö2_29._11._2019
{
    class Tree
    {
        /*public int CompareTo(Ehdokas other)
        {
            
            int ret = this.Sukunimi.CompareTo(other.Sukunimi);
            if (ret == 0)
                ret = this.Etunimi.CompareTo(other.Etunimi);
            return ret;
        }*/
        public TreeNode Root { get; set; }

        // public static TreeNode Find(TreeNode t, char c)

        public static TreeNode Find(TreeNode t, Ehdokas c)
        {
            TreeNode node = null;

            while (t != null)
            {
                //if (c == t.Data)
                int ret = c.Sukunimi.CompareTo(t._ehdokas.Sukunimi);
                if (ret == 0)//if (c.Sukunimi == t._ehdokas.Sukunimi)
                {
                                //if Surnames are same, need to check names

                                // int ret_name = c.Etunimi.CompareTo(t._ehdokas.Etunimi);
                                //      if (ret_name == 0)

                                //          {
                                //               node = t;
                                //                break;

                                //   else if (ret_name < 0) //to be continued
                                //
                                //              {
                                //               t = t.Left;
                                //              }
                                //      else
                                //              {
                                //                 t = t.Right;
                                //               }
                                //          return node;
                                //              }
                    node = t;
                    break;
                }
                //else if (c < t.Data) //
                 else if (ret < 0) //CHECK IF IT <0 or >o
                        {
                    t = t.Left;
                }
                else
                {
                    t = t.Right;
                }
            }

            return node;
        }

       // public static void Insert(TreeNode root, char c)
        public static void Insert(TreeNode root, Ehdokas c)
        {
            TreeNode daddy = null;

            while (root != null)
            {
                daddy = root;
                int ret = c.Sukunimi.CompareTo(root._ehdokas.Sukunimi);


                //if (c < root.Data)
                if (ret < 0) //ret < 0 if (c < root._ehdokas)
                {
                    // mennään vasemmalle
                    root = root.Left;
                }
                else
                {
                    root = root.Right;
                }
            }
            TreeNode newNode = new TreeNode(c);
            int ret1 = c.Sukunimi.CompareTo(daddy._ehdokas.Sukunimi);

            //if (c < daddy.Data)
            if (ret1 < 0) //if (c. < daddy._ehdokas)
                daddy.Left = newNode;
            else
                daddy.Right = newNode;
        }

        public static void traverse_preorder(TreeNode t)
        {
            if (t != null)
            {
                // visit(t);
                Console.WriteLine(t.ToString());
                traverse_preorder(t.Left);
                traverse_preorder(t.Right);
            }
        }

        public static void traverse_inorder(TreeNode t)
        {
            if (t != null)
            {
                traverse_inorder(t.Left);
                // visit(t);
                Console.WriteLine(t.ToString());
                traverse_inorder(t.Right);
            }
        }

        public static void traverse_postorder(TreeNode t)
        {
            if (t != null)
            {
                traverse_postorder(t.Left);
                traverse_postorder(t.Right);
                // visit(t);
                Console.WriteLine(t.ToString());
            }
        }

        public static void traverse_preorder2(TreeNode t)
        {
            Stack<TreeNode> pino = new Stack<TreeNode>();

            pino.Push(t);

            do
            {
                t = pino.Pop();
                if (t != null)
                {
                    Console.WriteLine(t.ToString());
                    pino.Push(t.Right);
                    pino.Push(t.Left);
                }
            } while (pino.Count > 0);
        }
    }
}
