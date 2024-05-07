using OpenTK.Mathematics;

namespace Template
{
    public class Ray
    {
        public Vector3 Origin { get; private set; }
        public Vector3 Direction { get; private set; }
        public float Parameter { get; set; }

        public Ray(Vector3 origin, Vector3 direction)
        {
            Origin = origin;
            Direction = direction;
        }
    }
}