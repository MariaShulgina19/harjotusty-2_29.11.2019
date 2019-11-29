using System;
using System.Collections.Generic;
using System.Linq;
using System.IO;

namespace harjotustyö2_29._11._2019
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("test_29.11.2019");
            // lista ehdokkaista
            List<Ehdokas> ehdokkaat =
                new List<Ehdokas>();

            // luetaan tiedosto https://docs.microsoft.com/en-us/dotnet/csharp/programming-guide/file-system/how-to-read-a-text-file-one-line-at-a-time

            int counter = 0;
            string line;

            // Read the file and display it line by line.  
            StreamReader file =
                // new StreamReader(@"c:\temp\ehdokkaat.txt");
                new StreamReader(@"C:\Users\Käyttäjä\Desktop\SEAMK\Tietorakeneet2019\ehdokkaat.txt");
            while ((line = file.ReadLine()) != null)
            {
                // Alpo	Kitinoja	KOK	223
                string[] osat = line.Split();

                string en = osat[0];
                string sn = osat[1];
                string puolue = osat[2];
                int aanimaara = int.Parse(osat[3]);
                // tehdään olio
                Ehdokas e = new Ehdokas(en, sn, puolue,
                    aanimaara);
                // lisätään olio listaan
                ehdokkaat.Add(e);

                //Console.WriteLine(osat[0] + " " + osat[1]);                
                counter++;
            }

            file.Close();
            // järjestetään lista
            //Basic sort by surname and name 
            //ehdokkaat.Sort();


            //ehdokkaat.Sort(VertailuAaniMaaranMukaan.AanienMukaan());
 
            // käydään lista läpi
            foreach (var ehdokas in ehdokkaat)
            {
                Console.WriteLine(ehdokas);
            }
            Console.ReadLine();


            //TREE
            


            //creating new tree
            Ehdokas juuri1 = ehdokkaat[0];
           TreeNode juuri = new TreeNode(juuri1);

            for (int i = 1; i < ehdokkaat.Count; i++) //starting from 2 juuri.count  [0]

            {

                //Tree.Insert(juuri, ehdokkaat[i]);
                Tree.Insert(juuri, ehdokkaat[i]);

            }

            Tree.traverse_inorder(juuri);



            TreeNode h = Tree.Find(juuri, 'h');

            Console.WriteLine(h.ToString());

         



        }
    }
}
