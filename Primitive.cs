using System.Drawing;
using OpenTK.Mathematics;

namespace Template
{
    public abstract class Primitive  
    {
        public Color Color { get; set; }
        //public abstract Vector3 Intersection(); - i guess we will implement it in Scene?
    }

    class Sphere : Primitive
    {
        public Vector3 Position { get; private set; } 
        public float Radius { get; private set; }

        public Sphere(Vector3 position, float radius)
        {
            Position = position;
            Radius = radius;
        }
        //public override Vector3 Intersection
    }

    class Plane : Primitive
    {
        public Vector3 Normal { get; private set; }
        public Vector3 PlanePoint { get; private set; }

        public Plane(Vector3 normal, Vector3 planePoint)
        {
            Normal = normal;
            PlanePoint = planePoint;
        }
    }
}