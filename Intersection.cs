using OpenTK.Mathematics;

namespace Template
{
    public class Intersection
    {
        public float Distance { get; set; } 
        public Primitive NearestPrimitive { get; set; }
        public Vector3 Normal { get; set; }
    }
}