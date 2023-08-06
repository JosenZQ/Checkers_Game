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
        int mFirstPlayerTokens = 0, mSecondPlayerTokens = 0;
        bool mAdvice = true;
        cTokenBox mControl = new cTokenBox();

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

        private void fn_DealTokens(PictureBox _Box, string _PictureBoxName)
        {
            if (mTokensCount > 0)
            {
                if(_Box.BackgroundImage == null)
                {
                    if (mTurn == "FirstPlayer")
                    {                        
                        mControl.Add_To_Token_List(_PictureBoxName, false, "Black");
                        _Box.BackgroundImage = Resources.board_black_token;
                        mTurn = "SecondPlayer";
                        pbxTurn.Image = Resources.label_button_second_player;
                        mFirstPlayerTokens += 1;
                        lblFirstPlayerTokens.Text = mFirstPlayerTokens.ToString();
                        mTokensCount--;
                    }
                    else
                    {
                        mControl.Add_To_Token_List(_PictureBoxName, false, "White");
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
                if(mAdvice != false)
                {
                    MessageBox.Show("¡Puede empezar a mover fichas!");
                    mAdvice = false;
                }
                fn_MoveTokens(_Box, _PictureBoxName);
            }
        }

        private void fn_MoveTokens(PictureBox _Box, string _BoxName)
        {
            try
            {
                mControl.Set_Selection_On_List_Item(_BoxName);
                cTokenBox mToken = mControl.Return_List_Item_By_Selection();

                if(mToken._Selection != false)
                {
                    MessageBox.Show($"PictureBox seleccionado: {mToken._TokenName}");
                    _Box.BackColor = Color.FromArgb(224, 224, 224);
                }
                else
                {

                }
            }
            catch(Exception)
            {
                MessageBox.Show("Error al seleccionar");
            }
        }

        private void fn_SelectItem()
        {

        }



        //----------------------------- CONTROLES -----------------------------
        private void btnHelp_Click(object sender, EventArgs e)
        {
            frmHelp mHelp = new frmHelp();
            mHelp.Show();
        }      

        //--------------------------- PICTUREBOXES A ----------------------------
        private void pbxA1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA1, "A1");
        }

        private void pbxA2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA2, "A2");
        }

        private void pbxA3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA3, "A3");
        }

        private void pbxA4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA4, "A4");
        }

        private void pbxA5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA5, "A5");
        }

        private void pbxA6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA6, "A6");
        }

        private void pbxA7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA7, "A7");
        }

        private void pbxA8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxA8, "A8");
        }

        //--------------------------- PICTUREBOXES B ----------------------------
        private void pbxB1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB1, "B1");
        }

        private void pbxB2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB2, "B2");
        }

        private void pbxB3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB3, "B3");
        }

        private void pbxB4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB4, "B4");
        }

        private void pbxB5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB5, "B5");
        }

        private void pbxB6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB6, "B6");
        }

        private void pbxB7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB7, "B7");
        }

        private void pbxB8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxB8, "B8");
        }

        //--------------------------- PICTUREBOXES C ----------------------------
        private void pbxC1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC1, "C1");
        }

        private void pbxC2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC2, "C2");
        }

        private void pbxC3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC3, "C3");
        }

        private void pbxC4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC4, "C4");
        }

        private void pbxC5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC5, "C5");
        }

        private void pbxC6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC6, "C6");
        }

        private void pbxC7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC7, "C7");
        }

        private void pbxC8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxC8, "C8");
        }

        //--------------------------- PICTUREBOXES D ----------------------------
        private void pbxD1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD1, "D1");
        }

        private void pbxD2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD2, "D2");
        }

        private void pbxD3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD3, "D3");
        }

        private void pbxD4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD4, "D4");
        }

        private void pbxD5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD5, "D5");
        }

        private void pbxD6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD6, "D6");
        }

        private void pbxD7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD7, "D7");
        }

        private void pbxD8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxD8, "D8");
        }

        //--------------------------- PICTUREBOXES E ----------------------------
        private void pbxE1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE1, "E1");
        }

        private void pbxE2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE2, "E2");
        }

        private void pbxE3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE3, "E3");
        }

        private void pbxE4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE4, "E4");
        }

        private void pbxE5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE5, "E5");
        }

        private void pbxE6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE6, "E6");
        }

        private void pbxE7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE7, "E7");
        }

        private void pbxE8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxE8, "E8");
        }

        //--------------------------- PICTUREBOXES F ----------------------------
        private void pbxF1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF1, "F1");
        }

        private void pbxF2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF2, "F2");
        }

        private void pbxF3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF3, "F3");
        }

        private void pbxF4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF4, "F4");
        }

        private void pbxF5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF5, "F5");
        }

        private void pbxF6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF6, "F6");
        }

        private void pbxF7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF7, "F7");
        }

        private void pbxF8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxF8, "F8");
        }

        //--------------------------- PICTUREBOXES G ----------------------------
        private void pbxG1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG1, "G1");
        }

        private void pbxG2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG2, "G2");
        }

        private void pbxG3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG3, "G3");
        }

        private void pbxG4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG4, "G4");
        }

        private void pbxG5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG5, "G5");
        }

        private void pbxG6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG6, "G6");
        }

        private void pbxG7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG7, "G7");
        }

        private void pbxG8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxG8, "G8");
        }

        //--------------------------- PICTUREBOXES H ----------------------------
        private void pbxH1_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH1, "H1");
        }

        private void pbxH2_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH2, "H2");
        }

        private void pbxH3_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH3, "H3");
        }

        private void pbxH4_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH4, "H4");
        }

        private void pbxH5_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH5, "H5");
        }

        private void pbxH6_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH6, "H6");
        }

        private void pbxH7_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH7, "H7");
        }

        private void pbxH8_Click(object sender, EventArgs e)
        {
            fn_DealTokens(pbxH8, "H8");
        }        
        //--------------------------- FIN DE PICTUREBOXES -----------------------
    }
}
