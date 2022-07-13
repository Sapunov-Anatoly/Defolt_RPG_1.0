using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Defolt_RPG_1._0
{
    public partial class MainMenu : Form
    {
        public MainMenu()
        {
            InitializeComponent();
        }

        private void buttonStartNewGame_Click(object sender, EventArgs e)
        {
            CreateHero createhero = new CreateHero();
            this.Hide();
            createhero.Show();
        }
    }
}
