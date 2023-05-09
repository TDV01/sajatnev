using sajatnev;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace sajatnevGUI
{
    public partial class Form1 : Form
    {
        Adatbazis db = new Adatbazis();
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            vasarlokbetolt();
        }

        private void vasarlokbetolt()//vasarlokbetolt
        {
            listboxvasarlok.Items.Clear();
            listboxvasarlok.Items.AddRange(db.getvasarlok().ToArray());
        }

        private void konyvToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void megveszem_Click(object sender, EventArgs e)
        {

        }
    }
}
