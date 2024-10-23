using System.Drawing;
using System.Runtime.Remoting.Metadata.W3cXsd2001;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public class Enemy : GameObject
    {
        static int speed = 5;
        public Enemy(Size bounds, Graphics graphics, Point position) : base(bounds, graphics)
        {
            if (ControladorPontuacao.Pontuacao % 250 == 0 && ControladorPontuacao.Pontuacao != 0)
            {
                speed += 5;
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
    }
}
