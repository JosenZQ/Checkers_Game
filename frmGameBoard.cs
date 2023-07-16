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
        //ARRAY PARA LOS JUGADORES 
        string[] mPlayers = new string[2];

        public frmGameBoard()
        {
            InitializeComponent();
            this.FormClosing += frmGameBoard_FormClosing;
        }

        private void frmGameBoard_Load(object sender, EventArgs e)
        {
            mPlayers[0] = "FirstPlayer";
            mPlayers[1] = "SecondPlayer";

            tlpGameBoard.Parent = pbxGameBoard;
            tlpGameBoard.BackColor = Color.Transparent;

            pbxGameBoardButtons.Image = Resources.shiny_stars;
            pbxGameBoardButtons.SizeMode = PictureBoxSizeMode.StretchImage;

            pbxTurn.BackgroundImage = Resources.shiny_stars;
            pbxTurn.Image = Resources.label_button_first_player;

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

        //--------------------------- FUNCIONES ----------------------------






        //--------------------------- CONTROLES ----------------------------

        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp mHelp = new frmHelp();
            mHelp.Show();
        }

        //--------------------------- PICTUREBOXES A ----------------------------
        private void pbxA1_Click(object sender, EventArgs e)
        {

        }

        private void pbxA2_Click(object sender, EventArgs e)
        {

        }

        private void pbxA3_Click(object sender, EventArgs e)
        {

        }

        private void pbxA4_Click(object sender, EventArgs e)
        {

        }

        private void pbxA5_Click(object sender, EventArgs e)
        {

        }

        private void pbxA6_Click(object sender, EventArgs e)
        {

        }

        private void pbxA7_Click(object sender, EventArgs e)
        {

        }

        private void pbxA8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES B ----------------------------
        private void pbxB1_Click(object sender, EventArgs e)
        {

        }

        private void pbxB2_Click(object sender, EventArgs e)
        {

        }

        private void pbxB3_Click(object sender, EventArgs e)
        {

        }

        private void pbxB4_Click(object sender, EventArgs e)
        {

        }

        private void pbxB5_Click(object sender, EventArgs e)
        {

        }

        private void pbxB6_Click(object sender, EventArgs e)
        {

        }

        private void pbxB7_Click(object sender, EventArgs e)
        {

        }

        private void pbxB8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES C ----------------------------
        private void pbxC1_Click(object sender, EventArgs e)
        {

        }

        private void pbxC2_Click(object sender, EventArgs e)
        {

        }

        private void pbxC3_Click(object sender, EventArgs e)
        {

        }

        private void pbxC4_Click(object sender, EventArgs e)
        {

        }

        private void pbxC5_Click(object sender, EventArgs e)
        {

        }

        private void pbxC6_Click(object sender, EventArgs e)
        {

        }

        private void pbxC7_Click(object sender, EventArgs e)
        {

        }

        private void pbxC8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES D ----------------------------
        private void pbxD1_Click(object sender, EventArgs e)
        {

        }

        private void pbxD2_Click(object sender, EventArgs e)
        {

        }

        private void pbxD3_Click(object sender, EventArgs e)
        {

        }

        private void pbxD4_Click(object sender, EventArgs e)
        {

        }

        private void pbxD5_Click(object sender, EventArgs e)
        {

        }

        private void pbxD6_Click(object sender, EventArgs e)
        {

        }

        private void pbxD7_Click(object sender, EventArgs e)
        {

        }

        private void pbxD8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES E ----------------------------
        private void pbxE1_Click(object sender, EventArgs e)
        {

        }

        private void pbxE2_Click(object sender, EventArgs e)
        {

        }

        private void pbxE3_Click(object sender, EventArgs e)
        {

        }

        private void pbxE4_Click(object sender, EventArgs e)
        {

        }

        private void pbxE5_Click(object sender, EventArgs e)
        {

        }

        private void pbxE6_Click(object sender, EventArgs e)
        {

        }

        private void pbxE7_Click(object sender, EventArgs e)
        {

        }

        private void pbxE8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES F ----------------------------
        private void pbxF1_Click(object sender, EventArgs e)
        {

        }

        private void pbxF2_Click(object sender, EventArgs e)
        {

        }

        private void pbxF3_Click(object sender, EventArgs e)
        {

        }

        private void pbxF4_Click(object sender, EventArgs e)
        {

        }

        private void pbxF5_Click(object sender, EventArgs e)
        {

        }

        private void pbxF6_Click(object sender, EventArgs e)
        {

        }

        private void pbxF7_Click(object sender, EventArgs e)
        {

        }

        private void pbxF8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES G ----------------------------
        private void pbxG1_Click(object sender, EventArgs e)
        {

        }

        private void pbxG2_Click(object sender, EventArgs e)
        {

        }

        private void pbxG3_Click(object sender, EventArgs e)
        {

        }

        private void pbxG4_Click(object sender, EventArgs e)
        {

        }

        private void pbxG5_Click(object sender, EventArgs e)
        {

        }

        private void pbxG6_Click(object sender, EventArgs e)
        {

        }

        private void pbxG7_Click(object sender, EventArgs e)
        {

        }

        private void pbxG8_Click(object sender, EventArgs e)
        {

        }

        //--------------------------- PICTUREBOXES H ----------------------------
        private void pbxH1_Click(object sender, EventArgs e)
        {

        }

        private void pbxH2_Click(object sender, EventArgs e)
        {

        }

        private void pbxH3_Click(object sender, EventArgs e)
        {

        }

        private void pbxH4_Click(object sender, EventArgs e)
        {

        }

        private void pbxH5_Click(object sender, EventArgs e)
        {

        }

        private void pbxH6_Click(object sender, EventArgs e)
        {

        }

        private void pbxH7_Click(object sender, EventArgs e)
        {

        }

        private void pbxH8_Click(object sender, EventArgs e)
        {

        }        
        //--------------------------- FIN DE PICTUREBOXES -----------------------
    }
}
