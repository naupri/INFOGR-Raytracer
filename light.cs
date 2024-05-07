using System.Drawing;
using OpenTK.Mathematics;
namespace Template
{
    public class Light
    {
        public Vector3 SourcePosition { get; set; }
        public Color SourceIntensity { get; set; }
        public Light(Vector3 sourcePosition, Color sourceIntensity)
        {
            SourcePosition = sourcePosition;
            SourceIntensity = sourceIntensity;
        }
    }
}