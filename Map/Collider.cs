using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Dracak.Map
{
    class Collider
    {
        static List<Collider> instances = new List<Collider>();

        GameObject gameObject;
        int width;
        int height;

        public Collider(int width, int height, GameObject gameObject)
        {
            instances.Add(this);
            this.width = width;
            this.height = height;
            this.gameObject = gameObject;
        }

        ~Collider()
        {
            instances.Remove(this);
        }

        //otestuje jestli by na daných souřadnicích došlo ke kolizi s jiným objektem
        public GameObject CheckCollision(int x, int y)
        {
            int leftX = x;
            int rightX = x + width;
            int topY = y;
            int bottomY = y + height;

            foreach(Collider c in instances)
            {
                int leftX2 = c.gameObject.X;
                int rightX2 = leftX2 + c.width;
                int topY2 = c.gameObject.Y;
                int bottomY2 = topY2 + c.height;

                if((leftX > leftX2 && leftX < rightX2 || rightX > leftX2 && rightX < rightX2)
                    && (topY > topY2 && topY < bottomY2 || bottomY > topY2 && bottomY < bottomY2))
                {
                    return c.gameObject;
                }               
            }
            return null;
        }
    }
}
