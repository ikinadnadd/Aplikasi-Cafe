using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace aplikasi_cafe
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double menucoffeMilk, menucappucino, menuredVelved, menumatchaLatte, menubrownSugar, menutotalBayar, menuuang, menupajak, menukembalian;
            double hargacoffeMilk, hargacappucino, hargaredVelvet, hargamatchaLatte, hargabrownSugar, menupembayaran;

            menucoffeMilk = double.Parse(milk.Text);
            menucappucino = double.Parse(capucino.Text);
            menuredVelved = double.Parse(velvet.Text);
            menumatchaLatte = double.Parse(matcha.Text);
            menubrownSugar = double.Parse(sugar.Text);
            menuuang = double.Parse(UANGYGDBYR.Text);

            hargacoffeMilk = menucoffeMilk * 10000;
            hargacappucino = menucappucino * 11000;
            hargaredVelvet = menuredVelved * 12000;
            hargamatchaLatte = menumatchaLatte * 13000;
            hargabrownSugar = menubrownSugar * 14000;

            menutotalBayar = hargacoffeMilk + hargacappucino + hargaredVelvet + hargamatchaLatte + hargabrownSugar;
            menupajak = menutotalBayar * 0.05;

            menupembayaran = menutotalBayar + menupajak;
            menukembalian = menuuang - menupembayaran;

            TOTALBYR.Text = menutotalBayar.ToString();
            PAJAK.Text = menupajak.ToString();
            PMBYRN.Text = menupembayaran.ToString();
            KMBLIAN.Text = menukembalian.ToString();






































































        
        }
    }
}
