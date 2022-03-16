using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PROYECTO_POS_NHZ
{
    public partial class Form2_pantalla_principalopc : Form
    {
        public Form2_pantalla_principalopc()
        {
            InitializeComponent();
        }

        private void butn_salir_princi_Click(object sender, EventArgs e)
        {
            this.Hide();
        }
    }
}
