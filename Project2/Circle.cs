using Microsoft.Xna.Framework;
using Microsoft.Xna.Framework.Graphics;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;

namespace ACC
{
    public class Circle
    {
        public Texture2D circleTexture;
        public Vector2 circlePosition;
        protected Texture2D _texture;
        Random rnd = new Random();
       
        public Circle() { 
        circlePosition = circlePosition = new Vector2(rnd.Next(0,400),rnd.Next(0,400));
        }

        public Circle(int x, int y,Texture2D texture2D)
        {
            circlePosition = new Vector2(x,y);
            _texture = texture2D;



        }
        public Vector2 GetPos()
        {
            return circlePosition;
        }
        public void SetPos(int x, int y)
        {
            circlePosition.X = x;
            circlePosition.Y = y; 
        }

        public void onPress() { 
        }
    }

}