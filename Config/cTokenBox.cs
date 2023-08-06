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
        private string TokenName;
        private bool Selection;
        private string Alignment;
        private string Color;

        public List<cTokenBox> mTokenList = new List<cTokenBox>();

        public cTokenBox()
        {
            this.TokenName = string.Empty;
            this.Selection = false;
            this.Alignment = string.Empty;
            this.Color = string.Empty;
        }

        public string _TokenName
        {
           get { return TokenName; }
           set { TokenName = value; }
        }

        public bool _Selection
        {
            get { return Selection; }
            set { Selection = value; }
        }

        public string _Alignment
        {
            get { return Alignment; }
            set { Alignment = value; }
        }

        public string _Color
        {
            get { return Color; }
            set { Color = value; }
        }

        public void Add_To_Token_List(string _Name, bool _Selection, string _Color)
        {
            cTokenBox mToken = new cTokenBox();
            mToken.TokenName = _Name;
            mToken.Selection = _Selection;
            mToken.Color = _Color;
            mTokenList.Add(mToken);
        }

        public void Set_Selection_On_List_Item(string _Name)
        {
            int i = 0;

            for (i = 0; i < mTokenList.Count();)
            {
                if (mTokenList[i].TokenName == _Name)
                {
                    mTokenList[i].Selection = true;
                    i = 65; //SON 65 POR QUE EN TOTAL SON 64 FICHAS, ES PARA QUE ROMPA EL CICLO
                }
                else
                {
                    i++;
                }
            }
        }

        public void Clear_Selections()
        {
            for (int i = 0; i < mTokenList.Count(); i++)
            {
                mTokenList[i].Selection = false;
            }
        }

        public cTokenBox Return_List_Item_By_Selection()
        {
            int i;

            for (i = 0; i < mTokenList.Count();)
            {
                if (mTokenList[i].Selection == true)
                {
                    return mTokenList[i];
                    i = 65;
                    Clear_Selections();
                }
                else
                {
                    i++;
                }
            }
            return null;
        }              

        public cTokenBox Return_List_Item_By_Name(string _Name)
        {
            int i = 0;

            try
            {
                for(i = 0; i < mTokenList.Count();)
                {
                    if (mTokenList[i].TokenName == _Name)
                    {
                        return mTokenList[i];
                        i = 65;
                    }
                    else
                    {
                        i++;
                    }
                }
                return null;
            }
            catch(Exception)
            {
                return null;
            }
        }

    }
}
