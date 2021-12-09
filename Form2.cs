using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace RockPaperScissors
{
    public partial class helpWindow : Form
    {
        public helpWindow()
        {
            InitializeComponent();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void txtHelp_TextChanged(object sender, EventArgs e)
        {
            txtHelp.Text = "Добро пожаловать в игру 'камень, ножницы, бумага'";
        }
    }
}
