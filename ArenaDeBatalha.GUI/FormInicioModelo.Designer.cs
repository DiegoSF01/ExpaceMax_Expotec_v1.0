namespace ArenaDeBatalha.GUI
{
    partial class FormInicioModelo
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
            this.friendly = new System.Windows.Forms.PictureBox();
            this.competitive = new System.Windows.Forms.PictureBox();
            this.retornar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornar)).BeginInit();
            this.SuspendLayout();
            // 
            // friendly
            // 
            this.friendly.BackColor = System.Drawing.Color.Transparent;
            this.friendly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.friendly.Image = global::ArenaDeBatalha.GUI.Properties.Resources.PLAYo__2__removebg_preview;
            this.friendly.Location = new System.Drawing.Point(176, 48);
            this.friendly.Name = "friendly";
            this.friendly.Size = new System.Drawing.Size(433, 94);
            this.friendly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.friendly.TabIndex = 1;
            this.friendly.TabStop = false;
            this.friendly.Click += new System.EventHandler(this.friendly_Click);
            // 
            // competitive
            // 
            this.competitive.BackColor = System.Drawing.Color.Transparent;
            this.competitive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.competitive.Image = global::ArenaDeBatalha.GUI.Properties.Resources.PLAYo__1__removebg_preview;
            this.competitive.Location = new System.Drawing.Point(138, 183);
            this.competitive.Name = "competitive";
            this.competitive.Size = new System.Drawing.Size(509, 105);
            this.competitive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.competitive.TabIndex = 2;
            this.competitive.TabStop = false;
            // 
            // retornar
            // 
            this.retornar.BackColor = System.Drawing.Color.Transparent;
            this.retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retornar.Image = global::ArenaDeBatalha.GUI.Properties.Resources.PLAYo__4__removebg_preview;
            this.retornar.Location = new System.Drawing.Point(176, 323);
            this.retornar.Name = "retornar";
            this.retornar.Size = new System.Drawing.Size(433, 94);
            this.retornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.retornar.TabIndex = 3;
            this.retornar.TabStop = false;
            this.retornar.Click += new System.EventHandler(this.retornar_Click);
            // 
            // FormInicioModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArenaDeBatalha.GUI.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.retornar);
            this.Controls.Add(this.competitive);
            this.Controls.Add(this.friendly);
            this.Name = "FormInicioModelo";
            this.Text = "ExpaceMax";
            ((System.ComponentModel.ISupportInitialize)(this.friendly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornar)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox friendly;
        private System.Windows.Forms.PictureBox competitive;
        private System.Windows.Forms.PictureBox retornar;
    }
}