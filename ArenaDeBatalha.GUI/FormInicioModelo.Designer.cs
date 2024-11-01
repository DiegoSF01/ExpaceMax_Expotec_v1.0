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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.txtNome = new System.Windows.Forms.TextBox();
            this.FRIENDLY = new System.Windows.Forms.Button();
            this.COMPETITIVE = new System.Windows.Forms.Button();
            this.RETURN = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BackColor = System.Drawing.Color.Transparent;
            this.pictureBox1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(-72, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(462, 94);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.pictureBox1.TabIndex = 4;
            this.pictureBox1.TabStop = false;
            // 
            // txtNome
            // 
            this.txtNome.Font = new System.Drawing.Font("Microsoft Sans Serif", 57F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtNome.Location = new System.Drawing.Point(310, 12);
            this.txtNome.Name = "txtNome";
            this.txtNome.Size = new System.Drawing.Size(465, 94);
            this.txtNome.TabIndex = 7;
            // 
            // FRIENDLY
            // 
            this.FRIENDLY.BackColor = System.Drawing.Color.Indigo;
            this.FRIENDLY.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FRIENDLY.ForeColor = System.Drawing.Color.White;
            this.FRIENDLY.Location = new System.Drawing.Point(196, 132);
            this.FRIENDLY.Name = "FRIENDLY";
            this.FRIENDLY.Size = new System.Drawing.Size(409, 80);
            this.FRIENDLY.TabIndex = 8;
            this.FRIENDLY.Text = "FRIENDLY";
            this.FRIENDLY.UseVisualStyleBackColor = false;
            this.FRIENDLY.Click += new System.EventHandler(this.FRIENDLY_Click);
            // 
            // COMPETITIVE
            // 
            this.COMPETITIVE.BackColor = System.Drawing.Color.Indigo;
            this.COMPETITIVE.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.COMPETITIVE.ForeColor = System.Drawing.Color.White;
            this.COMPETITIVE.Location = new System.Drawing.Point(151, 237);
            this.COMPETITIVE.Name = "COMPETITIVE";
            this.COMPETITIVE.Size = new System.Drawing.Size(498, 80);
            this.COMPETITIVE.TabIndex = 9;
            this.COMPETITIVE.Text = "COMPETITIVE";
            this.COMPETITIVE.UseVisualStyleBackColor = false;
            this.COMPETITIVE.Click += new System.EventHandler(this.COMPETITIVE_Click_1);
            // 
            // RETURN
            // 
            this.RETURN.BackColor = System.Drawing.Color.Indigo;
            this.RETURN.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.RETURN.ForeColor = System.Drawing.Color.White;
            this.RETURN.Location = new System.Drawing.Point(232, 342);
            this.RETURN.Name = "RETURN";
            this.RETURN.Size = new System.Drawing.Size(337, 80);
            this.RETURN.TabIndex = 10;
            this.RETURN.Text = "RETURN";
            this.RETURN.UseVisualStyleBackColor = false;
            this.RETURN.Click += new System.EventHandler(this.RETURN_Click);
            // 
            // FormInicioModelo
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArenaDeBatalha.GUI.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.RETURN);
            this.Controls.Add(this.COMPETITIVE);
            this.Controls.Add(this.FRIENDLY);
            this.Controls.Add(this.txtNome);
            this.Controls.Add(this.pictureBox1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicioModelo";
            this.Text = "ExpaceMax";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.TextBox txtNome;
        private System.Windows.Forms.Button FRIENDLY;
        private System.Windows.Forms.Button COMPETITIVE;
        private System.Windows.Forms.Button RETURN;
    }
}