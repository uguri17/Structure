using System;

namespace Structure
{
	struct Point3D
	{
		public int X;
        public int Y;
        public int Z;

        public Point3D(int X, int Y, int Z) // parameter 있는 constructor
        {
            this.X = X; // 이름 충돌 방지용 this 사용
            this.Y = Y;
            this.Z = Z;
        }

        public override string ToString()
        {   // 내부를 보여주는 method로 override
            return string.Format($"{X}, {Y}, {Z}");
        }
    }

    class MainApp
    {
        static void Main(string[] args)
        {
            // 선언만으로 p3d1이라는 객체 생성
            Point3D p3d1; 
            p3d1.X = 10;
            p3d1.Y = 20;
            p3d1.Z = 40;
            Console.WriteLine("p3d1: " + p3d1.ToString());

            // constructor를 이용해서 객체 생성도 가능
            Point3D p3d2 = new Point3D(100, 200, 300); 
            Console.WriteLine("p3d2: " + p3d2.ToString());

            // Deep Copy(깊은 복사) structure니까
            Point3D p3d3 = p3d2; 
            Console.WriteLine("p3d3: " + p3d3.ToString());

            p3d2.Z = 500;
            Console.WriteLine("p3d2: " + p3d2.ToString());
        }
    }
}