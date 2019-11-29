using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotustyö2_29._11._2019
{
    class TreeNode 
    {
        // malli NEw

        public Ehdokas _ehdokas { get; set; }



       // public char Data { get; set; }

        public TreeNode Left { get; set; }

        public TreeNode Right { get; set; }



       
        public TreeNode (Ehdokas z) //NEW 29.11
        {
            this._ehdokas = z;
        }

        public override string ToString()

        {

            return this._ehdokas.ToString();

        }
        /* OLD
        public TreeNode(char x)

        {

            this.Data = x;

        }


        public override string ToString()

        {

            return this.Data.ToString();

        }
        OLD*/ 
    }
}
