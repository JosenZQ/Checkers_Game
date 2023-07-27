using Checkers_Game.Config;
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
        //VARIABLES GLOBALES
        int mTokensCount = 24;
        string mTurn = "FirstPlayer";
        List<cTokenBox> mTokenBoxesList = new List<cTokenBox>();
        int mFirstPlayerTokens = 0, mSecondPlayerTokens = 0;

        public frmGameBoard()
        {
            InitializeComponent();
            this.FormClosing += frmGameBoard_FormClosing;
        }

        private void frmGameBoard_Load(object sender, EventArgs e)
        {
            //tlpGameBoard.Parent = pbxGameBoard;
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

        private void fn_DealTokens(PictureBox _Box)
        {
            if (mTokensCount > 0)
            {
                if(_Box.BackgroundImage == null)
                {
                    if (mTurn == "FirstPlayer")
                    {
                        cTokenBox mTokenBox = new cTokenBox();
                        mTokenBox.setBox(_Box);
                        mTokenBox.setTokenColor("Black");
                        mTokenBoxesList.Add(mTokenBox);
                        _Box.BackgroundImage = Resources.board_black_token;
                        mTurn = "SecondPlayer";
                        pbxTurn.Image = Resources.label_button_second_player;
                        mFirstPlayerTokens += 1;
                        lblFirstPlayerTokens.Text = mFirstPlayerTokens.ToString();
                        mTokensCount--;
                    }
                    else
                    {
                        cTokenBox mTokenBox = new cTokenBox();
                        mTokenBox.setBox(_Box);
                        mTokenBox.setTokenColor("White");
                        mTokenBoxesList.Add(mTokenBox);
                        _Box.BackgroundImage = Resources.board_white_token;
                        mTurn = "FirstPlayer";
                        pbxTurn.Image = Resources.label_button_first_player;
                        mSecondPlayerTokens += 1;
                        lblSecondPlayerTokens.Text = mSecondPlayerTokens.ToString();
                        mTokensCount--;
                    }
                }
                else
                {
                    MessageBox.Show("Campo ya ocupado");
                }
            }
            else
            {
                MessageBox.Show("¡Puede empezar a mover fichas!");
            }
        }

        //--------------------------- CONTROLES ----------------------------
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp mHelp = new frmHelp();
            mHelp.Show();
        }      

        //--------------------------- PICTUREBOXES A ----------------------------
        private void pbxA1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA1);
        }

        private void pbxA2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA2);
        }

        private void pbxA3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA3);
        }

        private void pbxA4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA4);
        }

        private void pbxA5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA5);
        }

        private void pbxA6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA6);
        }

        private void pbxA7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA7);
        }

        private void pbxA8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA8);
        }

        //--------------------------- PICTUREBOXES B ----------------------------
        private void pbxB1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB1);
        }

        private void pbxB2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB2);
        }

        private void pbxB3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB3);
        }

        private void pbxB4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB4);
        }

        private void pbxB5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB5);
        }

        private void pbxB6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB6);
        }

        private void pbxB7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB7);
        }

        private void pbxB8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB8);
        }

        //--------------------------- PICTUREBOXES C ----------------------------
        private void pbxC1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC1);
        }

        private void pbxC2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC2);
        }

        private void pbxC3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC3);
        }

        private void pbxC4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC4);
        }

        private void pbxC5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC5);
        }

        private void pbxC6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC6);
        }

        private void pbxC7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC7);
        }

        private void pbxC8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC8);
        }

        //--------------------------- PICTUREBOXES D ----------------------------
        private void pbxD1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD1);
        }

        private void pbxD2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD2);
        }

        private void pbxD3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD3);
        }

        private void pbxD4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD4);
        }

        private void pbxD5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD5);
        }

        private void pbxD6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD6);
        }

        private void pbxD7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD7);
        }

        private void pbxD8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD8);
        }

        //--------------------------- PICTUREBOXES E ----------------------------
        private void pbxE1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE1);
        }

        private void pbxE2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE2);
        }

        private void pbxE3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE3);
        }

        private void pbxE4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE4);
        }

        private void pbxE5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE5);
        }

        private void pbxE6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE6);
        }

        private void pbxE7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE7);
        }

        private void pbxE8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE8);
        }

        //--------------------------- PICTUREBOXES F ----------------------------
        private void pbxF1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF1);
        }

        private void pbxF2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF2);
        }

        private void pbxF3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF3);
        }

        private void pbxF4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF4);
        }

        private void pbxF5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF5);
        }

        private void pbxF6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF6);
        }

        private void pbxF7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF7);
        }

        private void pbxF8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF8);
        }

        //--------------------------- PICTUREBOXES G ----------------------------
        private void pbxG1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG1);
        }

        private void pbxG2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG2);
        }

        private void pbxG3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG3);
        }

        private void pbxG4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG4);
        }

        private void pbxG5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG5);
        }

        private void pbxG6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG6);
        }

        private void pbxG7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG7);
        }

        private void pbxG8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG8);
        }

        //--------------------------- PICTUREBOXES H ----------------------------
        private void pbxH1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH1);
        }

        private void pbxH2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH2);
        }

        private void pbxH3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH3);
        }

        private void pbxH4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH4);
        }

        private void pbxH5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH5);
        }

        private void pbxH6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH6);
        }

        private void pbxH7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH7);
        }

        private void pbxH8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH8);
        }        
        //--------------------------- FIN DE PICTUREBOXES -----------------------
    }
}
