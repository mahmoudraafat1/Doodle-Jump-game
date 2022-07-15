using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DoodleJump.Classes
{
    public class Platform2
    {
        Image sprite;
        public Transform transform;
        public int sizeX;
        public int sizeY;
        public bool isTouchedByPlayer;

        
        public Platform2(PointF pos)
        {
            sprite = Properties.Resources.platform2;
            sizeX = 60;
            sizeY = 12;
            transform = new Transform(pos, new Size(sizeX, sizeY));
            isTouchedByPlayer = false;
        }

        public void DrawSprite(Graphics g)
        {
            for(int x = 0; x < 100; x++)
            g.DrawImage(sprite, transform.position.X+10, transform.position.Y+10, transform.size.Width, transform.size.Height);
        }

    }
}
