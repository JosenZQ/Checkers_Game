namespace Checkers_Game
{
    partial class frmGameBoard
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmGameBoard));
            this.pbxGameBoard = new System.Windows.Forms.PictureBox();
            this.tlpGameBoard = new System.Windows.Forms.TableLayoutPanel();
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameBoard)).BeginInit();
            this.SuspendLayout();
            // 
            // pbxGameBoard
            // 
            this.pbxGameBoard.Image = global::Checkers_Game.Properties.Resources.checkers_table;
            this.pbxGameBoard.Location = new System.Drawing.Point(12, 12);
            this.pbxGameBoard.Name = "pbxGameBoard";
            this.pbxGameBoard.Size = new System.Drawing.Size(533, 492);
            this.pbxGameBoard.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxGameBoard.TabIndex = 0;
            this.pbxGameBoard.TabStop = false;
            // 
            // tlpGameBoard
            // 
            this.tlpGameBoard.BackColor = System.Drawing.Color.Transparent;
            this.tlpGameBoard.ColumnCount = 8;
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 49.24242F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 50.75758F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 68F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 67F));
            this.tlpGameBoard.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpGameBoard.ForeColor = System.Drawing.Color.Black;
            this.tlpGameBoard.Location = new System.Drawing.Point(12, 12);
            this.tlpGameBoard.Name = "tlpGameBoard";
            this.tlpGameBoard.RowCount = 8;
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 50F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 64F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 61F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 62F));
            this.tlpGameBoard.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Absolute, 60F));
            this.tlpGameBoard.Size = new System.Drawing.Size(533, 492);
            this.tlpGameBoard.TabIndex = 1;
            // 
            // frmGameBoard
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 514);
            this.Controls.Add(this.tlpGameBoard);
            this.Controls.Add(this.pbxGameBoard);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.Name = "frmGameBoard";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "frmGameBoard";
            this.Load += new System.EventHandler(this.frmGameBoard_Load);
            ((System.ComponentModel.ISupportInitialize)(this.pbxGameBoard)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pbxGameBoard;
        private System.Windows.Forms.TableLayoutPanel tlpGameBoard;
    }
}