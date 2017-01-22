using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Input;
using System.Windows;

namespace Dracak.Map
{
    class Player : GameObject
    {
        public override void Update()
        {
            int speed = 3;
            if (Keyboard.IsKeyDown(Key.Right))
            {
                X += speed;
            }
            if (Keyboard.IsKeyDown(Key.Left))
            {
                X -= speed;
            }
            if (Keyboard.IsKeyDown(Key.Up))
            {
                Y -= speed;
            }
            if (Keyboard.IsKeyDown(Key.Down))
            {
                Y += speed;
            }
        }

        public override void OnCollision(GameObject gameObject)
        {
           
         }
    }
}
