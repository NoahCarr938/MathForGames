# Documentation for Math Library
Here is a list of all of my Vector and Matrix classes, and their functions.
- [Vector2](#Vector2)
- [Vector3](#Vector3)
- [Vector4](#Vector4)
- [Matrix3](#Matrix3)
- [Matrix4](#Matrix4)

- # Vector 2
- ## Properites
| Properties | What It Does
| :-- | :--: |
| Normalize | Returns a Normalized Vector based on the Current Vector 
| Magnitude |  The Length of Vector
| X | The X Coordinate of the Vector
| Y | The Y Coordinate of the Vector
- ## Methods
| Methods | What it does | How To Use 
| :-- | :--: | :--: |
| Normalize | Makes the magnitude of the Vector 1
| ToString |  Returns a string form of the Vector
| DotProduct | Returns the (x,y) of the vector multiplied by the other (x,y)| (Vector2 other)
| Distance |  Get the distance between the vector and something else|  (Vector2 other)
| Angle |  Get the angle between the vector|(Vector2 other)
- ## Operator Overloads
| Operator Overloads | What it does | How To Use
| :-- | :--: | :--: |
| Operator + | Adds two vectors together| (Vector2 left, Vector2 right)
| Operator - | Subtracts two vectors| (Vector2 left, Vector2 right)
| Operator * |  Multiplys a vector by a scalar| (Vector2 left, float scalar)
| Operator * |  Multiplies by a vector| (float scalar, Vector2 left)
| Operator / |  Divides by a scalar| (Vector2 left, float scalar)
| System.Numerics Vector2|  Converts from a Vector2 back to a System.Numerics Vector2| (Vector2 vector)
| Vector2 | Converts from a System.Numerics Vector2 to a Vector2| (System.Numerics.Vector2 vector)


- # Vector 3
- ## Properties
| Properties | What It Does
| :-- | :--: |
| Normalize | Returns a Normalized Vector based on the Current Vector 
| Magnitude |  The Length of Vector
| X | The X Coordinate of the Vector
| Y | The Y Coordinate of the Vector
| Z | The Z Coordinate of the Vector
- ## Methods
| Methods | What it does | How To Use 
| :-- | :--: | :--: |
| Normalize | Makes the magnitude of the Vector 1
| ToString |  Returns a string form of the Vector
| DotProduct | Returns the (x,y,z) of the vector multiplied by the other (x,y,z)| (Vector3 other)
| Distance |  Get the distance between the vector and something else|  (Vector3 other)
| Angle |  Get the angle between the vector|(Vector3 other)
- ## Operator Overloads
| Operator Overloads | What it does | How To Use
| :-- | :--: | :--: |
| Operator + | Adds two vectors together| (Vector3 left, Vector3 right)
| Operator - | Subtracts two vectors| (Vector3 left, Vector3 right)
| Operator * |  Multiplys a vector by a scalar| (Vector3 left, float scalar)
| Operator * |  Multiplies by a vector| (float scalar, Vector3 left)
| Operator / |  Divides by a scalar| (Vector3 left, float scalar)
| System.Numerics Vector3|  Converts from a Vector3 back to a System.Numerics Vector3| (Vector3 vector)
| Vector3 | Converts from a System.Numerics Vector3 to a Vector3| (System.Numerics.Vector3 vector)


- # Vector 4
## Properties
| Properties | What It Does
| :-- | :--: |
| Normalize | Returns a Normalized Vector based on the Current Vector 
| Magnitude |  The Length of Vector
| X | The X Coordinate of the Vector
| Y | The Y Coordinate of the Vector
| Z | The Z Coordinate of the Vector
| W | The W Coordinate of the Vector
- ## Methods
| Methods | What it does | How To Use 
| :-- | :--: | :--: |
| Normalize | Makes the magnitude of the Vector 1
| ToString |  Returns a string form of the Vector
| DotProduct | Returns the (x,y,z,w) of the vector multiplied by the other (x,y,z,w)| (Vector4 other)
| Distance |  Get the distance between the vector and something else|  (Vector4 other)
| Angle |  Get the angle between the vector|(Vector4 other)
- ## Operator Overloads
| Operator Overloads | What it does | How To Use
| :-- | :--: | :--: |
| Operator + | Adds two vectors together| (Vector4 left, Vector4 right)
| Operator - | Subtracts two vectors| (Vector4 left, Vector4 right)
| Operator * |  Multiplys a vector by a scalar| (Vector4 left, float scalar)
| Operator * |  Multiplies by a vector| (float scalar, Vector4 left)
| Operator / |  Divides by a scalar| (Vector4 left, float scalar)
| System.Numerics Vector4|  Converts from a Vector4 back to a System.Numerics Vector4| (Vector4 vector)
| Vector4 | Converts from a System.Numerics Vector4 to a Vector4| (System.Numerics.Vector4 vector)


- # Matrix 3
- ## Properties
| Properties | What It does |
| :-- | :--: |
| Identity | Returns new Matrix where the diagonals are 1 and all other numbers are 0 |
- ## Methods
| Methods | What It does | How To Use
| :-- | :--: | :--: |
| ToString | Returns the Matrix as a string|
| CreateTranslation |  Translates the Matrix in a direction| (float x, float y)|
| CreateRotation |  Rotates the Matrix| (float radians)|
| CreateScale |  Scales the Matrix| (float x, float y)|
- ## Operator Overloads
| Operator Overloads | What It does | How To Use
| :-- | :--: | :--: |
| Operator * | Multiplies a matrix3 by a vector3| (Matrix3 a, Vector3 b)|
| Operator + | Adds together two matrix3| (Matrix3 a, Matrix3 b)|
| Operator - | Subtracts two matrix3| (Matrix3 a, Matrix3 b)|
| Operator * | Multiplies two matrix3| (Matrix3 a, Matrix3 b)|


- # Matrix 4
- ## Properties
| Properties | What It does |
| :-- | :--: |
| Identity | Returns new Matrix where the diagonals are 1 and all other numbers are 0 |
- ## Methods
| Methods | What It does | How To Use
| :-- | :--: | :--: |
| ToString | Returns the Matrix as a string|
| CreateTranslation |  Translates the Matrix in a direction| (float x, float y, float z)|
| CreateRotation  |  Rotates the Matrix| (float radians)|
| CreateRotationX |  Rotates the Matrix| (float radians)|
| CreateRotationY |  Rotates the Matrix| (float radians)|
| CreateRotationZ |  Rotates the Matrix| (float radians)|
| CreateScale |  Scales the Matrix| (float x, float y, float z)|
- ## Operator Overloads
| Operator Overloads | What It does | How To Use
| :-- | :--: | :--: |
| Operator * | Multiplies a matrix4 by a vector4| (Matrix4 a, Vector4 b)|
| Operator + | Adds together two matrix4| (Matrix4 a, Matrix4 b)|
| Operator - | Subtracts two matrix3| (Matrix4 a, Matrix4 b)|
| Operator * | Multiplies two matrix3| (Matrix4 a, Matrix4 b)|