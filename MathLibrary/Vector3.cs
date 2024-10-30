using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MathLibrary
{
    public struct Vector3
    {
        public float x, y, z;

        public float Magnitude
        {
            get
            {
                // c = sqrt(x^2 + y^2 + z^2 + w^2)
                return (float)Math.Abs(Math.Sqrt(Math.Pow(x, 2) + Math.Pow(y, 2) + Math.Pow(z, 2)));
            }
        }

        public Vector3 Normalized
        {
            get
            {
                if (Magnitude == 0)
                    return new Vector3();
                return this / Magnitude;
            }
        }
        public Vector3(float x = 0, float y = 0, float z = 0)
        {
            this.x = x;
            this.y = y;
            this.z = z;
        }

        public Vector3 Normalize()
        {
            this = Normalized;
            return this;
        }

        public override string ToString()
        {
            // (x,y,z)
            return "(" + x + ", " + y + ", " + z + ", " + ")";
        }

        public float DotProduct(Vector3 other)
        {
            return (x * other.x) + (y * other.y) + (z * other.z);
        }

        public Vector3 CrossProduct(Vector3 other)
        {
            return new Vector3((y * other.z - z * other.y), (z * other.x - x * other.z), (x * other.y - y * other.x));
        }

        public static bool operator ==(Vector3 left, Vector3 right)
        {
            return (left.x == right.x) && (left.y == right.y) && (left.z == right.z);

        }

        public static bool operator !=(Vector3 left, Vector3 right)
        {
            return !(left == right);
        }


        // Operator overload for addition
        public static Vector3 operator +(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x + right.x, left.y + right.y, left.z + right.z);
        }

        //Operator overload for subtraction
        public static Vector3 operator -(Vector3 left, Vector3 right)
        {
            return new Vector3(left.x - right.x, left.y - right.y, left.z - right.z);
        }


        // Operator overload for multiplication by a scalar
        public static Vector3 operator *(Vector3 left, float scalar)
        {
            return new Vector3(left.x * scalar, left.y * scalar, left.z * scalar);
        }

        // Operator overload for multiplication by a vector
        public static Vector3 operator *(float scalar, Vector3 left)
        {
            return new Vector3(scalar * left.x, scalar * left.y, scalar * left.z);
        }

        // Operator overload for divison
        public static Vector3 operator /(Vector3 left, float scalar)
        {
            return new Vector3(left.x / scalar, left.y / scalar, left.z / scalar);
        }



        // implicit conversation from System.Numerics.Vector4 to Vector 4
        public static implicit operator Vector3(System.Numerics.Vector3 vector)
        {
            return new Vector3(vector.X, vector.Y, vector.Z);
        }

        // implicit conversion from Vector4 to System.Numerics.Vector4
        public static implicit operator System.Numerics.Vector3(Vector3 vector)
        {
            return new System.Numerics.Vector3(vector.x, vector.y, vector.z);
        }
    }
}
