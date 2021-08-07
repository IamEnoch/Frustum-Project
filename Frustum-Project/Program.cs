using System;

namespace Frustum_Project
{
    class Program
    {
        static void Main(string[] args)
        {
            //all units dimensions should be uniform
            //Metallic sheets are rectangular
            //Dimensions needed for the buckets include == top radius, Bottom radius, Salnt height
            
            const double pi = 3.14;

            Console.WriteLine("Bucket Dimensions\nEnter the length of the Top Radius");
            var topRad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the bottom Radius");
            var bottRad = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the slant height");
            var slantHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of sheets you would like to use");
            int sheetsNo = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length of the sheet");
            var len = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Width of the sheet");
            var width = Convert.ToDouble(Console.ReadLine());

            var area_of_sheets = sheetsNo * len * width;
            var bucket_SA = pi * slantHeight * (bottRad + topRad) + (pi * bottRad * bottRad);
            var buckets = area_of_sheets / bucket_SA;

            Console.WriteLine("The total number of buckets that can be made is {0}", Math.Floor(buckets));                

        }
    }
}
