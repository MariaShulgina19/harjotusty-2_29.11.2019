using System;
using System.Collections.Generic;
using System.Text;

namespace harjotustyö2_29._11._2019
{
    class Ehdokas : IComparable<Ehdokas>
    {
        public string Etunimi { get; set; }
        public string Sukunimi { get; set; }
        public string Puolue { get; set; }
        public int Aanimaara { get; set; }
        public double Vertailuluku { get; set; }

        public Ehdokas(string en, string sn, string puolue, int aanimaara)
        {
            this.Etunimi = en;
            this.Sukunimi = sn;
            this.Puolue = puolue;
            this.Aanimaara = aanimaara;
        }

        //metod to compare names
        public int CompareTo(Ehdokas other)
        {
            // return this.Aanimaara - other.Aanimaara;


            int ret = this.Sukunimi.CompareTo(other.Sukunimi);
            if (ret == 0)
                ret = this.Etunimi.CompareTo(other.Etunimi);
            return ret;
        }

        public override string ToString()
        {
            return this.Sukunimi + " " + this.Etunimi + " " +
                this.Puolue + " " + this.Aanimaara + this.Vertailuluku;

        }
    }
}
