using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace harjotustyö2_29._11._2019
{
    class VertailuSukunimenMukaan : IComparer<Ehdokas>
    {
        //Can be delited hole class
        public int Compare(Ehdokas x, Ehdokas y)
        {
            return x.Aanimaara - y.Aanimaara; // string.. d
        }

        public static IComparer<Ehdokas> SukunimenMukaan()
        {
            return new VertailuSukunimenMukaan();
        }
    }
}
