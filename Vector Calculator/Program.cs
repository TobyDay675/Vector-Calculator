using System;

namespace Vector_Calculator
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Choose the x value of the first vector.");
            string PlayerXImput1 = Console.ReadLine();
            float vectorX1 = Convert.ToSingle(PlayerXImput1);
            
            Console.WriteLine("Choose the y value of the first vector.");
            string PlayerYImput1 = Console.ReadLine();
            float vectorY1 = Convert.ToSingle(PlayerYImput1);
            
            Console.WriteLine("Choose the z value of the first vector.");
            string PlayerZImput1 = Console.ReadLine();
            float vectorZ1 = Convert.ToSingle(PlayerZImput1);
            
            Console.WriteLine("Choose the x value of the second vector.");
            string PlayerXImput2 = Console.ReadLine();
            float vectorX2 = Convert.ToSingle(PlayerXImput2);
            
            Console.WriteLine("Choose the y value of the second vector.");
            string PlayerYImput2 = Console.ReadLine();
            float vectorY2 = Convert.ToSingle(PlayerYImput2);
            
            Console.WriteLine("Choose the z value of the second vector.");
            string PlayerZImput2 = Console.ReadLine();
            float vectorZ2 = Convert.ToSingle(PlayerZImput2);
            
            Console.WriteLine("Choose the scale that you want to multiply the first Vector by.");
            string PlayerScalarImput = Console.ReadLine();
            float Scalar = Convert.ToSingle(PlayerScalarImput);
            
            Console.WriteLine("Choose the scale that you want to multiply second Vector by.");
            string PlayerScalarImput2 = Console.ReadLine();
            float Scalar2 = Convert.ToSingle(PlayerScalarImput2);


            Vector test1 = new Vector(vectorX1, vectorY1, vectorZ1);
            Vector test2 = new Vector(vectorX2, vectorY2, vectorZ2);


            // This should be 0, 4, 0
            Console.WriteLine("Here is your first vector " + " [" + vectorX1 + ", " + vectorY1 + ", " + vectorZ1 + "]");
            Console.WriteLine("Here is your second vector " + " [" + vectorX2 + ", " + vectorY2 + ", " + vectorZ2 + "]");
            
            Console.WriteLine("Here are the vectors added together:");
            Console.WriteLine(Vector.Add(test1, test2));
           
            Console.WriteLine("Here are the vectors subtracted together:");
            Console.WriteLine(Vector.Subtract(test1, test2));
            
            Console.WriteLine("Here is the direction of the first vector:");
            Console.WriteLine(test1.GetDirection());
            
            Console.WriteLine("Here is the direction of the second vector:");
            Console.WriteLine(test2.GetDirection());
            
            Console.WriteLine("Here is the magnitude of the first vector:");
            Console.WriteLine(test1.GetMagnitude());
            
            Console.WriteLine("Here is the magnitude of the second vector:");
            Console.WriteLine(test2.GetMagnitude());
            
            Console.WriteLine("Here is the first vector negated:");
            Console.WriteLine(Vector.Negate(test1));
            
            Console.WriteLine("Here is the second vector negated:");
            Console.WriteLine(Vector.Negate(test2));
            
            Console.WriteLine("Here is the first vector normalized:");
            Console.WriteLine(Vector.Normalize(test1));
           
            Console.WriteLine("Here is the second vector normalized:");
            Console.WriteLine(Vector.Normalize(test2));
            Console.WriteLine("Here is the first vector scaled by " + Scalar + ":");
            
            Console.WriteLine(Vector.Scale(test1, Scalar));
            
            Console.WriteLine("Here is the second vector scaled by " + Scalar2 + ":");
            Console.WriteLine(Vector.Scale(test2, Scalar2));
            
            Console.WriteLine("This is the dot product of the two vectors:");
            Console.WriteLine(Vector.DotProduct(test1, test2));
            
            Console.WriteLine("This is the cross product of the two vectors:");
            Console.WriteLine(Vector.CrossProduct(test1, test2));
            
            Console.WriteLine("This is the angle in between the vectors in rad:");
            Console.WriteLine(Vector.AngleBetween(test1, test2));

            Console.WriteLine("This is vector 1 projected onto vector 2:");
            Console.WriteLine(Vector.ProjectOnto(test1, test2));
        }
    }
}
