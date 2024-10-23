namespace ArenaDeBatalha.GUI
{
    partial class FormInicio
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
            this.exit = new System.Windows.Forms.PictureBox();
            this.classification = new System.Windows.Forms.PictureBox();
            this.play = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.exit)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.classification)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).BeginInit();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.Image = global::ArenaDeBatalha.GUI.Properties.Resources.PLAYo_removebg_preview;
            this.exit.Location = new System.Drawing.Point(230, 311);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(285, 99);
            this.exit.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.exit.TabIndex = 1;
            this.exit.TabStop = false;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // classification
            // 
            this.classification.BackColor = System.Drawing.Color.Transparent;
            this.classification.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.classification.Image = global::ArenaDeBatalha.GUI.Properties.Resources.PLAYo__3__removebg_preview;
            this.classification.Location = new System.Drawing.Point(135, 172);
            this.classification.Name = "classification";
            this.classification.Size = new System.Drawing.Size(499, 99);
            this.classification.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.classification.TabIndex = 2;
            this.classification.TabStop = false;
            // 
            // play
            // 
            this.play.BackColor = System.Drawing.Color.Transparent;
            this.play.Image = global::ArenaDeBatalha.GUI.Properties.Resources.play_removebg_preview;
            this.play.Location = new System.Drawing.Point(230, 37);
            this.play.Name = "play";
            this.play.Size = new System.Drawing.Size(285, 99);
            this.play.SizeMode = System.Windows.Forms.PictureBoxSizeMode.CenterImage;
            this.play.TabIndex = 3;
            this.play.TabStop = false;
            this.play.Click += new System.EventHandler(this.play_Click_1);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::ArenaDeBatalha.GUI.Properties.Resources.fundo1;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.play);
            this.Controls.Add(this.classification);
            this.Controls.Add(this.exit);
            this.Name = "FormInicio";
            this.Text = "ExpaceMax";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            ((System.ComponentModel.ISupportInitialize)(this.exit)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.classification)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.play)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.PictureBox exit;
        private System.Windows.Forms.PictureBox classification;
        private System.Windows.Forms.PictureBox play;
    }
}