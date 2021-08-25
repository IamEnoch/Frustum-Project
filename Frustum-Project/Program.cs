using System;

namespace Frustum_Project
{
    class Bucket
    {
        public double TopRadius;
        public double BottomRadius;
        public double SlantHeight;
        public double SheetNumber;
        public double Length;
        public double Width;
    }
    class Program
    {
        static double AreaOfSheets(double SheetNumber,double Length,double Width) 
        {
            return SheetNumber * Length * Width;
        }
        static double BucketSA(double SlantHeight,double BottomRadius,double TopRadius) 
        {
            return Math.PI * SlantHeight * (BottomRadius + TopRadius) + (Math.PI * BottomRadius * BottomRadius);
        }
        static double Buckets(double AreaOfsheets, double BucketSA)
        {
            return AreaOfsheets / BucketSA;
        }
        static void Main(string[] args)
        {
            //all units dimensions should be uniform
            //Metallic sheets are rectangular
            //Dimensions needed for the buckets include == top radius, Bottom radius, Salnt height
            Bucket customer1 = new Bucket();
            
            Console.WriteLine("Bucket Dimensions\nEnter the length of the Top Radius");
            customer1.TopRadius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the bottom Radius");
            customer1.BottomRadius = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the length of the slant height");
            customer1.SlantHeight = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Enter the number of sheets you would like to use");
            customer1.SheetNumber = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Length of the sheet");
            customer1.Length = Convert.ToDouble(Console.ReadLine());

            Console.WriteLine("Width of the sheet");
            customer1.Width = Convert.ToDouble(Console.ReadLine());

            //var area_of_sheets = AreaOfSheets(SheetNumber, Length, Width);
            //var bucket_SA = BucketSA(SlantHeight, BottomRadius, TopRadius);
            var buckets = Buckets(AreaOfSheets(customer1.SheetNumber, customer1.Length, customer1.Width), BucketSA(customer1.SlantHeight, customer1.BottomRadius, customer1.TopRadius));

            Console.WriteLine($"The total number of buckets that can be made is {Math.Floor(buckets)}");                

        }
    }
}
