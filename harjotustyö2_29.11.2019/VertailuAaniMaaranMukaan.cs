using System;
using System.Collections.Generic;
using System.Text;

namespace harjotustyö2_29._11._2019
{
    class VertailuAaniMaaranMukaan : IComparer<Ehdokas>
    {
        public int Compare(Ehdokas x, Ehdokas y)
        {
            return x.Aanimaara - y.Aanimaara;
        }

        public static IComparer<Ehdokas> AanienMukaan()
        {
            return new VertailuAaniMaaranMukaan();
        }
    }
}
