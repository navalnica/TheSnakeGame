using System;
using System.Collections.Generic;
namespace new_snake
{
    public class Cell
    {
        public int x { get; set; }
        public int y { get; set; }
    }

    public class Snake
    {
        public int vx, vy;  // velocity in x- and y-directoins
        public int cs, cn;  // cell size & number
        public int hx, hy;  // head coordinates
        public int ax, ay;  // apple coordinates
        public int tail, startTail;

        private Random r;

        public List<Cell> trail;    
        public Snake()
        {
            vx = vy = 0;
            cs = 25;
            cn = 20;
            hx = hy = 15;
            startTail = 2;
            tail = startTail;
            trail = new List<Cell>();
            trail.Add(new Cell{ x = hx, y = hy });
            r = new Random();
            PlaceApple();
        }
        public void PlaceApple()
        {
            bool unacceptableLocation;
            while (true)
            {
                unacceptableLocation = false;
                ax = r.Next(0, cn);
                ay = r.Next(0, cn);
                for (int i = 0; i < trail.Count; i++)
                {
                    if (trail[i].x == ax && trail[i].y == ay)
                    {
                        unacceptableLocation = true;
                        break;
                    }
                }
                if (unacceptableLocation == false)
                    break;
            }
        }
        public int Move()
        {
            hx += vx;
            hy += vy;

            if (hx < 0)
                hx = cn - 1;
            if (hx >= cn)
                hx = 0;
            if (hy < 0)
                hy = cn - 1;
            if (hy >= cn)
                hy = 0;

            for (int i = 0; i < trail.Count; i++)
            {
                if (trail[i].x == hx && trail[i].y == hy &&
                    (vx != vy))
                {
                    // collision
                    return -1;
                }
            }

            while (trail.Count > tail)
                trail.RemoveAt(0);

            trail.Add(new Cell{ x = hx, y = hy});

            if (hx == ax && hy == ay)
            {
                tail++;
                PlaceApple();
            }

            return 0; 
        }
    }
}
