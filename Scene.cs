using System.Reflection.Metadata.Ecma335;
using OpenTK.Mathematics;

namespace Template
{
    public class Scene
    {
        public List<Primitive> Primitives { get; set; }
        public List<Light> LightSources { get; set; }

        public Intersection Intersect(Ray ray) //either make a return statement or void the function;
        {
            foreach (Primitive scenePrimitive in this.Primitives)
            {
                if (scenePrimitive is Sphere)
                {
                    //Sphere sceneSphere = (Sphere)scenePrimitive;
                    //scenePrimitive.
                    //find the intersection of input vector 'direction' and the sphere
                }

                if (scenePrimitive is Plane)
                {
                    //find the intersection of input vector 'direction' and the plane
                    Plane scenePlane = (Plane)scenePrimitive; 
                    try
                    {
                        ray.Parameter =
                            Vector3.Dot(Vector3.Add(scenePlane.PlanePoint, Vector3.Multiply(ray.Origin, -1f)),
                                scenePlane.Normal) / Vector3.Dot(ray.Direction, scenePlane.Normal);
                    }
                    catch (Exception ex) 
                    {
                        ray.Parameter = float.PositiveInfinity;
                    }
                }
                
                /* at the end of each foreach round, update float t to the new value
                if the new value is smaller than the current one */
            }
            
            //at the end Intersect() needs to return the closest object to the starting point
        }
    }
}