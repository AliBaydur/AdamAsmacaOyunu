
namespace AdamAsmaca
{
    partial class Form1
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
            this.pckb_AdamAs = new System.Windows.Forms.PictureBox();
            this.toolStrip1 = new System.Windows.Forms.ToolStrip();
            this.lbl_mesaj = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pckb_AdamAs)).BeginInit();
            this.SuspendLayout();
            // 
            // pckb_AdamAs
            // 
            this.pckb_AdamAs.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pckb_AdamAs.Location = new System.Drawing.Point(812, 46);
            this.pckb_AdamAs.Name = "pckb_AdamAs";
            this.pckb_AdamAs.Size = new System.Drawing.Size(288, 329);
            this.pckb_AdamAs.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pckb_AdamAs.TabIndex = 0;
            this.pckb_AdamAs.TabStop = false;
            // 
            // toolStrip1
            // 
            this.toolStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.toolStrip1.Location = new System.Drawing.Point(0, 0);
            this.toolStrip1.Name = "toolStrip1";
            this.toolStrip1.Size = new System.Drawing.Size(1112, 25);
            this.toolStrip1.TabIndex = 1;
            this.toolStrip1.Text = "toolStrip1";
            // 
            // lbl_mesaj
            // 
            this.lbl_mesaj.AutoSize = true;
            this.lbl_mesaj.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lbl_mesaj.Location = new System.Drawing.Point(412, 58);
            this.lbl_mesaj.Name = "lbl_mesaj";
            this.lbl_mesaj.Size = new System.Drawing.Size(0, 14);
            this.lbl_mesaj.TabIndex = 2;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1112, 450);
            this.Controls.Add(this.lbl_mesaj);
            this.Controls.Add(this.toolStrip1);
            this.Controls.Add(this.pckb_AdamAs);
            this.Name = "Form1";
            this.Text = "Adam Asmaca Oyunu ";
            ((System.ComponentModel.ISupportInitialize)(this.pckb_AdamAs)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pckb_AdamAs;
        private System.Windows.Forms.ToolStrip toolStrip1;
        private System.Windows.Forms.Label lbl_mesaj;
    }
}

