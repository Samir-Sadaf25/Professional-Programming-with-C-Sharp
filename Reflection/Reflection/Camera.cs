using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Reflection
{
    public class Camera : Iproduct
    {
        public int Pixel {  get; set; }
        public string Model { get; set; }
        public string Name { get; set; }

        public Camera(string model,int pixel)
        {
            Pixel = pixel;
            Model = model;
        }
        public void takePicture()
        {
            Console.WriteLine("Picture taken");
        }
    }
}
