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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormInicio));
            this.PLAY = new System.Windows.Forms.Button();
            this.CLASSIFICACAO = new System.Windows.Forms.Button();
            this.EXIT = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // PLAY
            // 
            this.PLAY.BackColor = System.Drawing.Color.Indigo;
            this.PLAY.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.PLAY.ForeColor = System.Drawing.Color.White;
            this.PLAY.Location = new System.Drawing.Point(232, 40);
            this.PLAY.Name = "PLAY";
            this.PLAY.Size = new System.Drawing.Size(337, 80);
            this.PLAY.TabIndex = 4;
            this.PLAY.Text = "PLAY";
            this.PLAY.UseVisualStyleBackColor = false;
            this.PLAY.Click += new System.EventHandler(this.PLAY_Click_1);
            // 
            // CLASSIFICACAO
            // 
            this.CLASSIFICACAO.BackColor = System.Drawing.Color.Indigo;
            this.CLASSIFICACAO.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CLASSIFICACAO.ForeColor = System.Drawing.Color.White;
            this.CLASSIFICACAO.Location = new System.Drawing.Point(130, 185);
            this.CLASSIFICACAO.Name = "CLASSIFICACAO";
            this.CLASSIFICACAO.Size = new System.Drawing.Size(540, 80);
            this.CLASSIFICACAO.TabIndex = 5;
            this.CLASSIFICACAO.Text = "CLASSIFICAÇÃO";
            this.CLASSIFICACAO.UseVisualStyleBackColor = false;
            this.CLASSIFICACAO.Click += new System.EventHandler(this.CLASSIFICACAO_Click_1);
            // 
            // EXIT
            // 
            this.EXIT.BackColor = System.Drawing.Color.Indigo;
            this.EXIT.Font = new System.Drawing.Font("Bell MT", 48F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EXIT.ForeColor = System.Drawing.Color.White;
            this.EXIT.Location = new System.Drawing.Point(232, 330);
            this.EXIT.Name = "EXIT";
            this.EXIT.Size = new System.Drawing.Size(337, 80);
            this.EXIT.TabIndex = 6;
            this.EXIT.Text = "EXIT";
            this.EXIT.UseVisualStyleBackColor = false;
            this.EXIT.Click += new System.EventHandler(this.EXIT_Click_1);
            // 
            // FormInicio
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.EXIT);
            this.Controls.Add(this.CLASSIFICACAO);
            this.Controls.Add(this.PLAY);
            this.DoubleBuffered = true;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "FormInicio";
            this.Text = "ExpaceMax";
            this.Load += new System.EventHandler(this.FormInicio_Load);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button PLAY;
        private System.Windows.Forms.Button CLASSIFICACAO;
        private System.Windows.Forms.Button EXIT;
    }
}