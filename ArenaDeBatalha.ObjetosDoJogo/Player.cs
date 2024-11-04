using System.Collections.Generic;
using System.Drawing;
using System.Runtime.CompilerServices;

namespace ArenaDeBatalha.ObjetosDoJogo
{
    public class Player : GameObject
    {
        List<GameObject> gameObjects;

        static int speed = 6;

        public Player(Size bounds, Graphics graphics, List<GameObject> gameObjects) : base(bounds, graphics)
        {
            if (ControladorPontuacao.Pontuacao % 1000 == 0 && ControladorPontuacao.Pontuacao != 0)
            {
                speed += 1;
            }
            SetStartPosition();
            this.gameObjects = gameObjects;
            this.Speed = speed;
            this.Sound = Media.ExplosionLong;
        }

        public void SetStartPosition()
        {
            this.Left = this.Bounds.Width / 2 - this.Width / 2;
            this.Top = this.Bounds.Height - this.Height;
        }

        public override Bitmap GetSprite()
        {
            return Media.Player;
        }

        public GameObject Shoot()
        {
            Bullet bullet = new Bullet(this.Bounds, this.Screen, new Point(this.Left + this.Width/2, this.Top - this.Height/2));
            bullet.Left -= bullet.Width / 2;
            return bullet;
        }

        public override void UpdateObject()
        {                                    
            base.UpdateObject();
        }

        public override void MoveDown()
        {
            if (this.Top < this.Bounds.Height - this.Height)
                this.Top += this.Speed;
        }

        public override void MoveUp()
        {
            if (this.Top > 0)
                this.Top -= this.Speed;
        }

        public static void ResetSpeed()
        {
            speed = 6;
        }
    }
}
