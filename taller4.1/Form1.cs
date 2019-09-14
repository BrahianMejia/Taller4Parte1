using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace taller4._1
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnir_Click(object sender, EventArgs e)
        {
            int numero, total, cont;
            numero = int.Parse(txtnumero.Text);
            cont = 0;
            int lim = 10;
            for (int i = 1; i <= lim; i++)
            {
                cont += 1;
                total = numero * cont;               
                dgtabla.Rows.Add(numero, cont.ToString(), total.ToString());
            }
        }

        private void btnborrar_Click(object sender, EventArgs e)
        {

            dgtabla.Rows.Clear();


            txtnumero.Text = "";
            txtnumero.Focus();
        }

    }
}
