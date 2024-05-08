using System.Reflection.Metadata.Ecma335;
using System.Collections.Generic;
using OpenTK.Mathematics;
/*
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
                    Sphere sceneSphere = (Sphere)scenePrimitive;
                    //float quadA = Vector3.LengthSquared(ray.Direction);
                    //float quadB = 2 * (Vector3.Dot(ray.Origin, ray.Direction) - 
                                       //Vector3.Dot(ray.Direction, sceneSphere.Position));
                                       //float quadC = ray.Origin.LengthSquared - 2 * Vector3.Dot(ray.Origin, sceneSphere.Position)
                                       //+ Vector3.LengthSquared(sceneSphere.Position) - sceneSphere.Radius * sceneSphere.Radius;
                                       // float discriminant = quadB * quadB - 4 * quadA * quadC;
                }

                if (scenePrimitive is Plane)
                {
                    //find the intersection of input ray and the plane
                    Plane scenePlane = (Plane)scenePrimitive; 
                    try
                    {
                        ray.Parameter =
                            Vector3.Dot(Vector3.Subtract(scenePlane.PlanePoint, ray.Origin), scenePlane.Normal) 
                            / Vector3.Dot(ray.Direction, scenePlane.Normal);
                    }
                    catch (Exception ex)
                    {
                        ray.Parameter = float.PositiveInfinity;
                    }
                }
                
                 at the end of each foreach round, update float t to the new value
                if the new value is smaller than the current one 
            }
            
            //at the end Intersect() needs to return the closest object to the starting point
        }
    }
}*/