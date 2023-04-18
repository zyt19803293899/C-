using System;

namespace CustomGenericType
{
    struct Point<T>
    {
        T x;
        T y;
        public Point(T x, T y)
        {
            this.x = x;
            this.y = y;
        }
        public T X
        {
            get { return x; }
            set { this.x = value; }
        }

        public T Y
        {
            get { return y; }
            set { this.y = value; }
        }

        public void Print()
        {
            Console.WriteLine("({0}, {1})", x, y);
        }
    }
}
