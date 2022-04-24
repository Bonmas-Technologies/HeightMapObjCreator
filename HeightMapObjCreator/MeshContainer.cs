using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightMapObjCreator
{
    internal class MeshContainer
    {
        public ObjVector[] vertices;
        public List<ObjTriangle> triangles;

        public MeshContainer(int width, int height)
        {
            vertices = new ObjVector[width * height];

            triangles = new List<ObjTriangle>(width * height * 2);
        }

        public void AddTriangle(int a, int b, int c)
        {
            triangles.Add(new ObjTriangle(a, b, c));
        }

        public string GetObjMesh()
        {
            StringBuilder objFile = new StringBuilder();

            foreach (ObjVector vertice in vertices)
            {
                objFile.AppendLine(vertice.ToString());
            }

            objFile.AppendLine("");

            foreach (ObjTriangle triangle in triangles)
            {
                objFile.AppendLine(triangle.ToString());
            }

            return objFile.ToString();
        }
    }

    internal struct ObjTriangle
    {
        int partA;
        int partB;
        int partC;

        public ObjTriangle(int a, int b, int c)
        {
            partA = a;
            partB = b;
            partC = c;
        }

        public override string ToString()
        {
            return $"f {partA} {partB} {partC}";
        }
    }

    internal struct ObjVector
    {
        public readonly float X;
        public readonly float Y;
        public readonly float Z;

        public ObjVector(float x, float y, float z)
        {
            X = x;
            Y = y;
            Z = z;
        }
        
        public override string ToString()
        {
            return $"v {X} {Y} {Z}";
        }
    }
}
