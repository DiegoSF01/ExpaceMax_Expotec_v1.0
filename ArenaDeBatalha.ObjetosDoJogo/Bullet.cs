using System.Drawing;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public class Bullet : GameObject
    {
        static int speed = 12;

        public Bullet(Size bounds, Graphics graphics, Point position) : base(bounds, graphics)
        {
            if (ControladorPontuacao.Pontuacao % 1500 == 0 && ControladorPontuacao.Pontuacao != 0)
            {
                speed += 2;
            }

            this.Top = position.Y;
            this.Left = position.X;
            this.Speed = speed;
            this.Sound = Media.Missile;
            this.PlaySound();
        }

        public override Bitmap GetSprite()
        {
            return Media.Bullet;
        }
        
        public override void UpdateObject()
        {
            this.MoveUp();
            base.UpdateObject();
        }

        public static void ResetSpeed()
        {
            speed = 12;
        }
    }
}
