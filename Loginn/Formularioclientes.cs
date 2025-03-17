using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Loginn
{
    public partial class Formularioclientes : Form
    {
        public Formularioclientes()
        {
            InitializeComponent();
        }

        private void ormularioclientes_Load(object sender, EventArgs e)
        {

            for (int i = 0; i < 10; i++)
            {
                dgclientes.Rows.Add(i, $"Nombre{i} apellido1 apellido2", $"{i * 45678895}", $"{i * 12346567}");
            }



        }

        private void button2_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            formnuevotablas cliente = new formnuevotablas();
            cliente.ShowDialog();
        }
    }


}
