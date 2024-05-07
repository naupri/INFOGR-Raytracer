using System.Drawing;
using OpenTK.Mathematics;

namespace Template
{
    public class Ray
    {
        public Vector3 point;
        public Vector3 origin;
        public Vector3 Point
        {
            get {return point;}
            set {point = Vector3.Add(Camera.TopLeft, Vector3.Multiply()}
        }
        public Vector3 Origin
        {
            get {return origin;}
            private set {origin = Camera.Position;}
        }
        public Vector3 Direction { get; private set; }
        public float Parameter { get; set; }

        public Ray(Vector3 direction)
        {
            Direction = direction;
        }
    }
}