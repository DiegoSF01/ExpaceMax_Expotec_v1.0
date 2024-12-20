﻿using System.Drawing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public class Enemy : GameObject
    {
        static int speed = 3;
        public Enemy(Size bounds, Graphics graphics, Point position) : base(bounds, graphics)
        {
            if (ControladorPontuacao.Pontuacao % 500 == 0 && ControladorPontuacao.Pontuacao != 0)
            {
                speed += 1;
            }
            this.Left = position.X;
            this.Top = position.Y;
            this.Speed = speed;
            this.Sound = Media.ExplosionShort;
        }

        public override Bitmap GetSprite()
        {
            return Media.Enemy;
        }

        public override void UpdateObject()
        {
            this.MoveDown();
            base.UpdateObject();
        }

        public static void ResetSpeed()
        {
            speed = 3;
        }
    }
}
