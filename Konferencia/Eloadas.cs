using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Drawing;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using System.Reflection;

namespace Konferencia
{
    class Eloadas
    {
        readonly int eloadasid;
        string cim;        
        int sorok;
        int szekek;
        int[,] ertekelesek;

        public int Eloadasid => eloadasid;
        
        public string Cim { get => cim; set => cim = value; }
        public int Sorok { get => sorok; set =>  sorok =value; }
        public int Szekek { get => szekek; set => szekek = value; } 
        public int[,] Ertekelesek { get => ertekelesek; set => ertekelesek = value; }

        public Eloadas( int eloadasid,string cim,int sorok, int szekek)
        {
            this.eloadasid = eloadasid;
            Cim = cim;
            Sorok = sorok;
            Szekek = szekek;
            this.ertekelesek = new int[sorok, szekek];
        }

       

        public Image getErtekelesKep(int sor, int szek)
        {
            Image ErtekelesKep;
            switch (Ertekelesek[szek, sor])
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
            this.ertekelesek[sor -1, szek -1] = ertekeles;
        }
    }

}

