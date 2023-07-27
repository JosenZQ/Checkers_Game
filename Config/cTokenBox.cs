using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Checkers_Game.Config
{
    public class cTokenBox
    {
        private PictureBox TokenBox;
        private bool Selection;
        private string TokenColor;

        public void setBox(PictureBox _Box)
        {
            this.TokenBox = _Box;
        }

        public PictureBox getBox()
        {
            return TokenBox;
        }

        public void setSelection(bool _Selection)
        {
            this.Selection = _Selection;
        }

        public bool getSelection() 
        {
            return this.Selection;
        }

        public void setTokenColor(string _TokenColor)
        {
            this.TokenColor = _TokenColor;
        }

        public string getTokenColor()
        {
            return this.TokenColor;
        }

    }
}
