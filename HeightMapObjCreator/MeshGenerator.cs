using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HeightMapObjCreator
{
    public static class MeshGenerator
    {
        public static string GetObjectByImage(string path)
        {
            Bitmap image = (Bitmap)Image.FromFile(path.ToString());

            var container = new MeshContainer(image.Width, image.Height);

            int vertexIndex = 1;

            for (int z = 0; z < image.Width; z++)
            {
                for (int x = 0; x < image.Height; x++)
                {
                    float posX = x;
                    float posZ = z;

                    float scaleY = image.Width / 10;

                    container.vertices[vertexIndex - 1] = new ObjVector(posX, image.GetPixel(x, z).R / (float)byte.MaxValue * scaleY, posZ);


                    if (x < (image.Width - 1) && z < (image.Height - 1))
                    {
                        container.AddTriangle(vertexIndex, vertexIndex + image.Width + 1, vertexIndex + image.Width);
                        container.AddTriangle(vertexIndex + image.Width + 1, vertexIndex, vertexIndex + 1);
                    }

                    vertexIndex++;
                }
            }

            return container.GetObjMesh();
        }

    }
}
