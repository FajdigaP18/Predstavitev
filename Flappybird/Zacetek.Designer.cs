namespace Flappybird
{
    partial class Zacetek
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
            this.label1 = new System.Windows.Forms.Label();
            this.igralec = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label1.Location = new System.Drawing.Point(126, 90);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(128, 35);
            this.label1.TabIndex = 9;
            this.label1.Text = "Vnesi ime";
            // 
            // igralec
            // 
            this.igralec.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.igralec.Location = new System.Drawing.Point(96, 165);
            this.igralec.Name = "igralec";
            this.igralec.Size = new System.Drawing.Size(209, 40);
            this.igralec.TabIndex = 10;
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Calibri", 16.2F, System.Drawing.FontStyle.Bold);
            this.button1.Location = new System.Drawing.Point(96, 240);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(209, 47);
            this.button1.TabIndex = 11;
            this.button1.Text = "Vredu";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Zacetek
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.ClientSize = new System.Drawing.Size(392, 363);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.igralec);
            this.Controls.Add(this.label1);
            this.Name = "Zacetek";
            this.Text = "Zacetek";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox igralec;
        private System.Windows.Forms.Button button1;
    }
}