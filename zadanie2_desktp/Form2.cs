using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace zadanie2_desktp
{
    public partial class Form2 : Form
    {

        public Form2()
        {
            InitializeComponent();
            
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void Dodaj_button_Click(object sender, EventArgs e)
        {
            

            var imie = Imie_input.Text;
            var nazwisko = Nazwisko_input.Text;
            var klasa = Klasa_input.Text;

            if (imie == "" || nazwisko == "" || klasa == "")
            {
                MessageBox.Show("Pola nie mogą być puste", "Warning");
            }
            else
            {
                FileStream plik = new FileStream(@"C:\Users\student\source\repos\Oskar621\zadanie2_desktp\asd\uczen.txt", FileMode.Open);
                StreamWriter fs = new StreamWriter(plik);
                StreamReader odczyt = new StreamReader(plik);
                int liczba = 0;
                string linia;
                string id_ucznia = "";
                while ((linia = odczyt.ReadLine()) != null)
                {
                    liczba++;
                }
                if (liczba > 100)
                {
                    id_ucznia = liczba.ToString();
                }
                else if(liczba > 10)
                {
                    id_ucznia = "0" + liczba.ToString();
                }
                else
                {
                    id_ucznia = "00" + liczba.ToString();
                }
                string do_dopisania = $"{id_ucznia};{imie};{nazwisko};{klasa}";
                fs.Write(do_dopisania);
                odczyt.Close();
                plik.Close();
            }
        }
    }
}
