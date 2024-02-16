using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;
using static Mysqlx.Expect.Open.Types.Condition.Types;
using System.Reflection;

namespace Konferencia
{
    public partial class Form1 : Form
    {
        List<Eloadas> konferencia = new List<Eloadas>(); 
        Adatbazis db = new Adatbazis();
        int konferenciaIndex = 0;
        int erteklesKepMeret = 40;
        private object kep;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            konferencia = db.konferenciaAdatokBetolt();
            konferenciaAdatai();
        }

        private void konferenciaAdatai()
        {
            panelErtekeles.Controls.Clear();

            // költök képének a betöltése----------
            this.Text = $"{konferencia[konferenciaIndex].Cim}";
            foreach (string kepNeve in Directory.GetFiles("Kepek"))
                if (konferencia[konferenciaIndex].Cim.ToLower().Contains(kepNeve.ToLower().Split('.')[0].Split('\\')[1]))            
            pictureBoxKolto.Image = Image.FromFile(kepNeve);

            // értékelések betöltése--------------
            for (int sor = 0; sor < konferencia[konferenciaIndex].Szekek; sor++)
            {
                for(int szek =0; szek < konferencia[konferenciaIndex].Sorok; szek++)
                {
                    PictureBox pb = new PictureBox();
                    pb.Image = konferencia[konferenciaIndex].getErtekelesKep(sor, szek);
                    pb.SizeMode = PictureBoxSizeMode.StretchImage;
                    pb.Size = new Size(erteklesKepMeret, erteklesKepMeret);
                    pb.Location = new Point(sor*erteklesKepMeret, szek*erteklesKepMeret);
                    pb.Tag=$"{sor}, {szek}";
                    panelErtekeles.Controls.Add(pb);
                }
            }
            if (konferenciaIndex == 0)
            {
                buttonBalraranyil.Hide();
                buttonJobbranyil.Show();
            }
            else if(konferenciaIndex == konferencia.Count - 1)
            {
                buttonJobbranyil.Hide();
                buttonBalraranyil.Show();
            }
            else
            {
                buttonBalraranyil.Show();
                buttonJobbranyil.Show();
            }
        }

        private void buttonBalraranyil_Click(object sender, EventArgs e)
        {
            if(konferenciaIndex != 0)
            {
                konferenciaIndex--;
            }
            konferenciaAdatai();

        }

        private void buttonJobbranyil_Click(object sender, EventArgs e)
        {
            if (konferenciaIndex< konferencia.Count - 1)
            {
                konferenciaIndex++;
            }
            konferenciaAdatai();
        }

        
    }
}
