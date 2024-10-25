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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicioModelo));
            this.friendly = new System.Windows.Forms.PictureBox();
            this.competitive = new System.Windows.Forms.PictureBox();
            this.retornar = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.friendly)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitive)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // friendly
            // 
            this.friendly.BackColor = System.Drawing.Color.Transparent;
            this.friendly.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.friendly.Image = ((System.Drawing.Image)(resources.GetObject("friendly.Image")));
            this.friendly.Location = new System.Drawing.Point(167, 130);
            this.friendly.Name = "friendly";
            this.friendly.Size = new System.Drawing.Size(462, 94);
            this.friendly.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.friendly.TabIndex = 1;
            this.friendly.TabStop = false;
            this.friendly.Click += new System.EventHandler(this.friendly_Click);
            // 
            // competitive
            // 
            this.competitive.BackColor = System.Drawing.Color.Transparent;
            this.competitive.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.competitive.Image = ((System.Drawing.Image)(resources.GetObject("competitive.Image")));
            this.competitive.Location = new System.Drawing.Point(143, 230);
            this.competitive.Name = "competitive";
            this.competitive.Size = new System.Drawing.Size(509, 105);
            this.competitive.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.competitive.TabIndex = 2;
            this.competitive.TabStop = false;
            this.competitive.Click += new System.EventHandler(this.competitive_Click);
            // 
            // retornar
            // 
            this.retornar.BackColor = System.Drawing.Color.Transparent;
            this.retornar.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.retornar.Image = ((System.Drawing.Image)(resources.GetObject("retornar.Image")));
            this.retornar.Location = new System.Drawing.Point(177, 330);
            this.retornar.Name = "retornar";
            this.retornar.Size = new System.Drawing.Size(433, 94);
            this.retornar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.retornar.TabIndex = 3;
            this.retornar.TabStop = false;
            this.retornar.Click += new System.EventHandler(this.retornar_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(3, 30);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // textBox1
            // 
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(386, 30);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(382, 94);
            this.textBox1.TabIndex = 7;
            // 
            // FormInicioModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArenaDeBatalha.GUI.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.textBox1);
            this.Controls.Add(this.pictureBox1);
            this.Controls.Add(this.retornar);
            this.Controls.Add(this.competitive);
            this.Controls.Add(this.friendly);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicioModelo";
            this.Text = "ExpaceMax";
            ((System.ComponentModel.ISupportInitialize)(this.friendly)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.competitive)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.retornar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox friendly;
        private System.Windows.Forms.PictureBox competitive;
        private System.Windows.Forms.PictureBox retornar;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox textBox1;
    }
}