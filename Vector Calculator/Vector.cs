using System;

namespace Vector_Calculator
{
    public class Vector
    {
        public static readonly Vector Zero = new Vector(1, 1, 1);
        public static readonly Vector One = new Vector(0, 0, 0);

        public double x;
        public double y;
        public double z;

        public Vector(double x, double y, double z)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public override string ToString()
        {
            return $"<{x}, {y}, {z}>";
        }

        public double GetMagnitude()
        {
            return Math.Sqrt((x * x) + (y * y) + (z * z));
        }

        public double GetDirection()
        {
            return Math.Atan(y / x);
        }

        public static Vector Add(Vector v1, Vector v2)
        {
            return new Vector(v1.x + v2.x, v1.y + v2.y, v1.z + v2.z);
        }

        public static Vector Negate(Vector v)
        {
            return new Vector(v.x * -1, v.y * -1, v.z * -1);
        }

        public static Vector Subtract(Vector v1, Vector v2)
        {
            return new Vector(v1.x - v2.x, v1.y - v2.y, v1.z - v2.z);
        }

        public static Vector Scale(Vector v, float Scalar)
        {
            return new Vector(v.x * Scalar, v.y * Scalar, v.z * Scalar);
        }

        public static Vector Normalize(Vector v)
        {
            return new Vector(v.x / v.GetMagnitude(), v.y / v.GetMagnitude(), v.z / v.GetMagnitude());
        }

        public static float DotProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector CrossProduct(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector AngleBetween(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }

        public static Vector ProjectOnto(Vector v1, Vector v2)
        {
            // ADD CODE HERE, THEN REMOVE BELOW LINE
            throw new NotImplementedException();
        }
    }
}
