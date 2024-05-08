using System.Drawing;
using OpenTK.Mathematics;

namespace Template
{
    public class Ray
    {
        Camera one = new Camera();
        public float Avalue { get; set; }
        public float Bvalue { get; set; }           
        public Vector3 Origin { get; set; }
        public Vector3 Point { get; set; }
        public Vector3 Direction { get; set; }
        public float Distance { get; set; }
        public Vector3 RayEquation { get; set; }

        public Ray()
        {
            Avalue = 1f;
            Bvalue = 1f;
            Distance = 1f;            
            Origin = one.Position;
            RaySetup();
        }

        private void RaySetup()
        {
            Point = Vector3.Add(Vector3.Add(one.TopLeft, Vector3.Multiply(one.BasisU,Avalue)), Vector3.Multiply(one.BasisV,Bvalue));
            Direction = Vector3.Normalize(Vector3.Add(Point, Vector3.Multiply(Origin,-1)));
            RayEquation = Vector3.Add(Origin, Vector3.Multiply(Direction,Distance));
        }
    }
}