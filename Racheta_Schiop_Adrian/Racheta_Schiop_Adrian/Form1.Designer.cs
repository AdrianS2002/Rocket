namespace Racheta_Schiop_Adrian
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
            this.components = new System.ComponentModel.Container();
            this.r = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.a = new System.Windows.Forms.PictureBox();
            this.b = new System.Windows.Forms.PictureBox();
            this.c = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbl_vieti = new System.Windows.Forms.Label();
            this.glont = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lbl_scor = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.r)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.glont)).BeginInit();
            this.SuspendLayout();
            // 
            // r
            // 
            this.r.BackColor = System.Drawing.Color.Transparent;
            this.r.Image = global::Racheta_Schiop_Adrian.Properties.Resources.rr;
            this.r.Location = new System.Drawing.Point(183, 430);
            this.r.Name = "r";
            this.r.Size = new System.Drawing.Size(84, 87);
            this.r.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.r.TabIndex = 0;
            this.r.TabStop = false;
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Interval = 30;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // a
            // 
            this.a.BackColor = System.Drawing.Color.Transparent;
            this.a.Image = global::Racheta_Schiop_Adrian.Properties.Resources.asteroid;
            this.a.Location = new System.Drawing.Point(49, 46);
            this.a.Name = "a";
            this.a.Size = new System.Drawing.Size(58, 57);
            this.a.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.a.TabIndex = 1;
            this.a.TabStop = false;
            this.a.Tag = "asteroizi";
            // 
            // b
            // 
            this.b.BackColor = System.Drawing.Color.Transparent;
            this.b.Image = global::Racheta_Schiop_Adrian.Properties.Resources.asteroid;
            this.b.Location = new System.Drawing.Point(192, 113);
            this.b.Name = "b";
            this.b.Size = new System.Drawing.Size(75, 68);
            this.b.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.b.TabIndex = 2;
            this.b.TabStop = false;
            this.b.Tag = "asteroizi";
            // 
            // c
            // 
            this.c.BackColor = System.Drawing.Color.Transparent;
            this.c.Image = global::Racheta_Schiop_Adrian.Properties.Resources.asteroid;
            this.c.Location = new System.Drawing.Point(357, 12);
            this.c.Name = "c";
            this.c.Size = new System.Drawing.Size(58, 58);
            this.c.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.c.TabIndex = 3;
            this.c.TabStop = false;
            this.c.Tag = "asteroizi";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.ForeColor = System.Drawing.Color.Yellow;
            this.label1.Location = new System.Drawing.Point(10, 8);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(62, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Vieți:";
            // 
            // lbl_vieti
            // 
            this.lbl_vieti.AutoSize = true;
            this.lbl_vieti.BackColor = System.Drawing.Color.Transparent;
            this.lbl_vieti.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_vieti.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_vieti.Location = new System.Drawing.Point(78, 8);
            this.lbl_vieti.Name = "lbl_vieti";
            this.lbl_vieti.Size = new System.Drawing.Size(24, 25);
            this.lbl_vieti.TabIndex = 5;
            this.lbl_vieti.Text = "5";
            // 
            // glont
            // 
            this.glont.BackColor = System.Drawing.Color.Transparent;
            this.glont.Image = global::Racheta_Schiop_Adrian.Properties.Resources.glont;
            this.glont.Location = new System.Drawing.Point(216, 398);
            this.glont.Name = "glont";
            this.glont.Size = new System.Drawing.Size(20, 26);
            this.glont.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.glont.TabIndex = 6;
            this.glont.TabStop = false;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(320, 12);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(57, 25);
            this.label2.TabIndex = 7;
            this.label2.Text = "Scor";
            // 
            // lbl_scor
            // 
            this.lbl_scor.AutoSize = true;
            this.lbl_scor.BackColor = System.Drawing.Color.Transparent;
            this.lbl_scor.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.lbl_scor.ForeColor = System.Drawing.Color.Yellow;
            this.lbl_scor.Location = new System.Drawing.Point(392, 12);
            this.lbl_scor.Name = "lbl_scor";
            this.lbl_scor.Size = new System.Drawing.Size(24, 25);
            this.lbl_scor.TabIndex = 8;
            this.lbl_scor.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Racheta_Schiop_Adrian.Properties.Resources.fundal;
            this.ClientSize = new System.Drawing.Size(474, 538);
            this.Controls.Add(this.lbl_scor);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.glont);
            this.Controls.Add(this.lbl_vieti);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.c);
            this.Controls.Add(this.b);
            this.Controls.Add(this.a);
            this.Controls.Add(this.r);
            this.MaximumSize = new System.Drawing.Size(492, 585);
            this.Name = "Form1";
            this.Text = "Racheta";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.r)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.a)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.b)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.c)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.glont)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox r;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.PictureBox a;
        private System.Windows.Forms.PictureBox b;
        private System.Windows.Forms.PictureBox c;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbl_vieti;
        private System.Windows.Forms.PictureBox glont;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lbl_scor;
    }
}

