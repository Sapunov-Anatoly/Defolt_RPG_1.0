using System;
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
            createhero.ShowDialog();
        }

        private void buttonLoadGame_Click(object sender, EventArgs e)
        {
            LoadHero loadhero = new LoadHero();

            loadhero.ShowDialog();
        }
    }
}
