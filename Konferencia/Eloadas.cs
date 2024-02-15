using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;

namespace Konferencia
{
    class Eloadas
    {
        readonly int eloadasid;
        string cim;
        int sor;
        int szek;
        int[,] ertekeles;

        public int Eloadasid => eloadasid;
        
        public string Cim { get => cim; set => cim = value; }
        public int SorDb { get => sor; set =>  sor =value; }
        public int HelyDb { get => szek; set => szek = value; } 
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }

        public Eloadas(int eloadasid, string cim, int sor, int szek)
        {
            this.eloadasid = eloadasid;
            Cim = cim;
            SorDb = sor;
            HelyDb = szek;
            this.ertekeles = new int[sor, szek];
        }
        public Image getKoltoKep()
        {
            return Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{this.cim}.jpg");
        }

        public Image getErtekelesKep(int sor, int szek)
        {
            Image ErtekelesKep;
            switch (Ertekeles[sor, szek])
            {
                case 1:
                    ErtekelesKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Pont1.jpg");
                    break;
                case 2:
                    ErtekelesKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Pont2.jpg");
                    break;
                case 3:
                    ErtekelesKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Pont3.jpg");
                    break;
               
                default:
                    ErtekelesKep = Image.FromFile($"Kepek{Path.DirectorySeparatorChar}Pont0.jpg");
                    break;



            }
            return ErtekelesKep;
        }
        internal void TeremAdat(int sor, int szek, int ertekeles)
        {
            this.ertekeles[sor - 1, szek - 1] = ertekeles;
        }
    }

}
}
