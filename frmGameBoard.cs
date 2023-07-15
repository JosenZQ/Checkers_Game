using Checkers_Game.Properties;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Reflection.Emit;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Game
{
    public partial class frmGameBoard : Form
    {
        public frmGameBoard()
        {
            InitializeComponent();
            this.FormClosing += frmGameBoard_FormClosing;
        }

        private void frmGameBoard_Load(object sender, EventArgs e)
        {
            tlpGameBoard.Parent = pbxGameBoard;
            tlpGameBoard.BackColor = Color.Transparent;

            pbxGameBoardButtons.Image = Resources.shiny_stars;
            pbxGameBoardButtons.SizeMode = PictureBoxSizeMode.StretchImage;

            var image = Resources.label_button_first_player;
            lblTurno.Size = image.Size;
            lblTurno.Image = image;
        }

        //ESTA FUNCIÓN ES PARA CONTROLAR EL CIERRE DE LA VENTANA
        //AQUÍ SE PUEDE HACER QUE EL PROGRAMA PARE O QUE SE DEVUELVA AL INICIO
        private void frmGameBoard_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
               frmHome mHome = new frmHome();
               mHome.Show();
               this.Hide();
            }
        }

    }
}
