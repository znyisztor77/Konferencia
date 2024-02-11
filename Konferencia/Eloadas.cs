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
        readonly int konferencia_id;
        string cim;
        int sorDb;
        int helyDb;
        int[,] ertekeles;

        public int Konferencia_id => konferencia_id;
        
        public string Cim { get => cim; set => cim = value; }
        public int SorDb { get => sorDb; set =>  sorDb =value; }
        public int HelyDb { get => helyDb; set => helyDb = value; } 
        public int[,] Ertekeles { get => ertekeles; set => ertekeles = value; }

        public Eloadas(int konferencia_id, string cim, int sorDb, int helyDb)
        {
            this.konferencia_id = konferencia_id;
            Cim = cim;
            SorDb = sorDb;
            HelyDb = helyDb;
            this.ertekeles = new int[sorDb, helyDb];
        }
        public Image getKoltoKep()
        {
            return Image.FromFile($"Kepek{Path.DirectorySeparatorChar}{this.cim}.jpg");
        }

        public Image getErtekelesKep(int sorDb, int helyDb)
        {
            Image ErtekelesKep;
            switch (Ertekeles[sorDb, helyDb])
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

    }
}
