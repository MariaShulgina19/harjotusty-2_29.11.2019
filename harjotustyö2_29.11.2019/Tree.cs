using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotustyö2_29._11._2019
{
    class Tree
    {
        public TreeNode Root { get; set; }



        public static void traverse_preorder(TreeNode t)

        {

            if (t != null)

            {



                //visit(t); 

                Console.WriteLine(t.ToString());

                traverse_preorder(t.Left);



                traverse_preorder(t.Right);

                //PMSALE 

            }

        }



        public static void traverse_inorder(TreeNode t)

        {

            if (t != null)

            {







                traverse_inorder(t.Left);

                //visit(t); 

                Console.WriteLine(t.ToString());

                traverse_inorder(t.Right);

                //ASMPLE 

            }

        }



        public static void traverse_postorder(TreeNode t)

        {

            if (t != null)

            {







                traverse_postorder(t.Left);



                traverse_postorder(t.Right);

                //visit(t); 

                Console.WriteLine(t.ToString());

                //ASMELP 

            }

        }



        //pino 

        public static void traverse_preorder2(TreeNode t)



        {

            Stack<TreeNode> pino = new Stack<TreeNode>();

            //peek see but not delete 

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
