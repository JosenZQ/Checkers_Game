﻿using System;
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
    public partial class frmGameBoard : Form
    {
        public frmGameBoard()
        {
            InitializeComponent();
        }

        private void frmGameBoard_Load(object sender, EventArgs e)
        {
            tlpGameBoard.Parent = pbxGameBoard;
            tlpGameBoard.BackColor = Color.Transparent;
        }
    }
}
