using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GamerTool
{
    public partial class dimensionLog : Form
    {
        public NumericUpDown dimensionX { get { return this.DimensionX; }}
        public NumericUpDown dimensionY { get { return this.DimensionY; } }

        public dimensionLog()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
