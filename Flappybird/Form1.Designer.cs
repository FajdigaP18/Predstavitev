namespace Flappybird
{
    partial class Flappy
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
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.tockeL = new System.Windows.Forms.Label();
            this.najboljsiL = new System.Windows.Forms.Label();
            this.najboljseTocke = new System.Windows.Forms.Label();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.tla = new System.Windows.Forms.PictureBox();
            this.oviraSpodaj = new System.Windows.Forms.PictureBox();
            this.oviraZgoraj = new System.Windows.Forms.PictureBox();
            this.flappybird = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraSpodaj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraZgoraj)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).BeginInit();
            this.SuspendLayout();
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(49, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(94, 35);
            this.label1.TabIndex = 4;
            this.label1.Text = "Točke: ";
            // 
            // tockeL
            // 
            this.tockeL.AutoSize = true;
            this.tockeL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.tockeL.Location = new System.Drawing.Point(49, 88);
            this.tockeL.Name = "tockeL";
            this.tockeL.Size = new System.Drawing.Size(29, 35);
            this.tockeL.TabIndex = 5;
            this.tockeL.Text = "0";
            // 
            // najboljsiL
            // 
            this.najboljsiL.AutoSize = true;
            this.najboljsiL.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.najboljsiL.Location = new System.Drawing.Point(12, 679);
            this.najboljsiL.Name = "najboljsiL";
            this.najboljsiL.Size = new System.Drawing.Size(214, 35);
            this.najboljsiL.TabIndex = 10;
            this.najboljsiL.Text = "Najboljsi rezultat:";
            // 
            // najboljseTocke
            // 
            this.najboljseTocke.AutoSize = true;
            this.najboljseTocke.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.najboljseTocke.Location = new System.Drawing.Point(232, 679);
            this.najboljseTocke.Name = "najboljseTocke";
            this.najboljseTocke.Size = new System.Drawing.Size(29, 35);
            this.najboljseTocke.TabIndex = 11;
            this.najboljseTocke.Text = "0";
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Flappybird.Properties.Resources.R;
            this.pictureBox1.Location = new System.Drawing.Point(282, 252);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(189, 181);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 6;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // tla
            // 
            this.tla.Image = global::Flappybird.Properties.Resources.tla;
            this.tla.Location = new System.Drawing.Point(0, 667);
            this.tla.Name = "tla";
            this.tla.Size = new System.Drawing.Size(765, 57);
            this.tla.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.tla.TabIndex = 3;
            this.tla.TabStop = false;
            // 
            // oviraSpodaj
            // 
            this.oviraSpodaj.Image = global::Flappybird.Properties.Resources.OviraGor;
            this.oviraSpodaj.Location = new System.Drawing.Point(428, 425);
            this.oviraSpodaj.Name = "oviraSpodaj";
            this.oviraSpodaj.Size = new System.Drawing.Size(100, 246);
            this.oviraSpodaj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraSpodaj.TabIndex = 2;
            this.oviraSpodaj.TabStop = false;
            // 
            // oviraZgoraj
            // 
            this.oviraZgoraj.Image = global::Flappybird.Properties.Resources.OviraDol;
            this.oviraZgoraj.Location = new System.Drawing.Point(522, 0);
            this.oviraZgoraj.Name = "oviraZgoraj";
            this.oviraZgoraj.Size = new System.Drawing.Size(100, 180);
            this.oviraZgoraj.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.oviraZgoraj.TabIndex = 1;
            this.oviraZgoraj.TabStop = false;
            // 
            // flappybird
            // 
            this.flappybird.Image = global::Flappybird.Properties.Resources.Ptic;
            this.flappybird.Location = new System.Drawing.Point(98, 252);
            this.flappybird.Name = "flappybird";
            this.flappybird.Size = new System.Drawing.Size(80, 60);
            this.flappybird.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.flappybird.TabIndex = 0;
            this.flappybird.TabStop = false;
            // 
            // Flappy
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(762, 723);
            this.Controls.Add(this.najboljseTocke);
            this.Controls.Add(this.najboljsiL);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.tockeL);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.tla);
            this.Controls.Add(this.oviraSpodaj);
            this.Controls.Add(this.oviraZgoraj);
            this.Controls.Add(this.flappybird);
            this.Name = "Flappy";
            this.Text = "Flappy Bird";
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.tipka_dol);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.tipka_gor);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tla)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraSpodaj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.oviraZgoraj)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.flappybird)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox flappybird;
        private System.Windows.Forms.PictureBox oviraZgoraj;
        private System.Windows.Forms.PictureBox oviraSpodaj;
        private System.Windows.Forms.PictureBox tla;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label tockeL;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label najboljsiL;
        private System.Windows.Forms.Label najboljseTocke;
    }
}

