using Checkers_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Game
{
    public partial class frmHome : Form
    {
        public frmHome()
        {
            InitializeComponent();
        }

        private void frmHome_Load(object sender, EventArgs e)
        {
            pbxHomeBackground.Image = Resources.pixel_art_castle;
            pbxHomeBackground.SizeMode = PictureBoxSizeMode.StretchImage;

            lblHomeTitle.Parent = pbxHomeBackground;
            lblHomeTitle.BackColor = Color.Transparent;

            btnPlay.Parent = pbxHomeBackground;
            btnPlay.BackColor = Color.Transparent; 
        }
    }
}
