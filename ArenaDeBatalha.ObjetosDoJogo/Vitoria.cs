﻿using System.Drawing;
using System.Windows.Media;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public class Vitoria : GameObject
    {
        public Vitoria(Size bounds, Graphics g) : base(bounds, g)
        {
            this.Left = this.Bounds.Width / 2 - this.Width / 2;
            this.Top = this.Bounds.Height / 2 - this.Height / 2;
            this.Speed = 0;
        }
        public override Bitmap GetSprite()
        {
            return new Bitmap(@"C:\Users\Usuario\source\repos\ExpaceMax_Expotec_v1.0\img\Vitoria.png");
        }
    }
}
