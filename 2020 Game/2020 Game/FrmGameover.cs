using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace _2020_Game
{
    public partial class FrmGameover : Form
    {
        public FrmGameover()
        {
            InitializeComponent();
            Cursor.Show();
        }

        private void btnStart_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            Hide();
            form1.ShowDialog();
        }
    }
}
