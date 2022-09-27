using System;

namespace Csharp_Intermediate_Udemy.Delegates
{
    public class PhotoFilters
    {
        public void ApplyBrightness(Photo photo)
        {
            Console.WriteLine("Applying brightness");
        }
        public void ApplyContrast(Photo photo)
        {
            Console.WriteLine("Applying contrast");
        }
        public void Resize(Photo photo)
        {
            Console.WriteLine("Resize photo");
        }
    }

}
