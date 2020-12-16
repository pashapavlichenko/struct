using System;

public class Class1
{
    public struct Vector
    {
        public float x = 120;
        public float y = 150;
        public float dt = 1 / 60;
        public float a;
        public averride ToString();
        Vector x = new Vector(0, 0);
        Vector V = new Vector(x, y);
        Vector g = new Vector(0, -10);
    }
    public Class1()
    {
        while (y > 0 & x > 0)
        {
            V = g * dt;
            x = V * dt;
        }
    }
}
