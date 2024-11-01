using MathLibrary;
using Raylib_cs;


namespace Sandbox
{
    internal class Program
    {
        const float SCALE_MULTIPLIER = 100;
        static void Main(string[] args)
        {

            Raylib.InitWindow(800, 480, "Hello World");
            Raylib.SetTargetFPS(60);

            Actor a = new Actor();

            Transform2D t1 = new Transform2D(a);
            t1.LocalScale = new Vector2(100, 100);
            Vector2 offset = new Vector2(t1.LocalScale.x * SCALE_MULTIPLIER / 2, t1.LocalScale.y * SCALE_MULTIPLIER / 2);
            t1.LocalPosition = new Vector2(
                (Raylib.GetScreenWidth() * 0.33f) - offset.x,
                (Raylib.GetScreenHeight() * 0.33f) - offset.y);


            Transform2D t2 = new Transform2D(a);
            t1.AddChild(t2);
            t2.LocalScale = new Vector2(.5f, .5f);
            t2.LocalPosition = new Vector2(
                (100) - offset.x,
                (50) - offset.y);

            t1.LocalPosition = new Vector2(
                (Raylib.GetScreenHeight() * 0.33f) - offset.y);

            

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.White);

                t1.Translate(t1.Forward * 50 * Raylib.GetFrameTime());
                t1.Rotate(0.5f * Raylib.GetFrameTime());

                t2.Rotate(0.5f * Raylib.GetFrameTime());

                // Draw t1
                //Raylib.DrawRectanglePro(new Rectangle(t1.GlobalPosition, t1.GlobalScale), t1.GlobalPosition
                Rectangle rect = new Rectangle(t1.GlobalPosition + offset, t1.GlobalScale);
                Raylib.DrawRectanglePro(
                    rect,
                    new Vector2(0, 0) + offset,
                    -t1.GlobalRotationAngle * (180 / (float)Math.PI),
                    Color.Blue);

                // Draw t2
                rect = new Rectangle(t2.GlobalPosition + offset, t2.GlobalScale * SCALE_MULTIPLIER);
                Raylib.DrawRectanglePro(
                    rect,
                    new Vector2(0, 0) + offset / 2,
                    -t2.GlobalRotationAngle * (180 / (float)Math.PI),
                    Color.Green);

                Raylib.DrawLineV(t1.GlobalPosition + offset, t1.GlobalPosition + offset + (t1.Forward * 100), Color.Red);
                Raylib.EndDrawing();
            }
            //// Test to see if vector2 DotProduct works. (It does)
            //Vector2 vector2test1 = new Vector2(2, 2);
            //Vector2 vector2test2 = new Vector2(4, 4);
            //float vector2sum;
            //vector2sum = vector2test1.DotProduct(vector2test2);

            //Console.WriteLine(vector2test1.x + " " + vector2test1.y);
            //Console.WriteLine(vector2test2.x + " " + vector2test2.y);
            //Console.WriteLine(vector2sum);

            //// Test to see if vector3 DotProduct works. (It does)
            //Vector3 vector3test1 = new Vector3(2, 2, 2);
            //Vector3 vector3test2 = new Vector3(4, 4, 4);
            //float vector3sum;
            //vector3sum = vector3test1.DotProduct(vector3test2);
            //Console.WriteLine(vector3test1.x + " " + vector3test1.y + " " + vector3test1.z);
            //Console.WriteLine(vector3test2.x + " " + vector3test2.y + " " + vector3test2.z);
            //Console.WriteLine(vector3sum);

            //// Test to see if vector3 CrossProduct works. (It does)
            //Vector3 vector3test3 = new Vector3(2, 3, 2);
            //Vector3 vector3test4 = new Vector3(5, 2, 2);
            //Vector3 vector3crossproduct;
            //vector3crossproduct = vector3test3.CrossProduct(vector3test4);
            //Console.WriteLine(vector3test3.x + " " + vector3test3.y + " " + vector3test3.z);
            //Console.WriteLine(vector3test4.x + " " + vector3test4.y + " " + vector3test4.z);
            //Console.WriteLine(vector3crossproduct);

            //// Matrix 3 Tests

            //// Addition
            //Matrix3 matrixtest1 = new Matrix3(3, 12, 1, 2, 3, 2, 1, 2, 3);
            //Matrix3 matrixtest2 = new Matrix3(2, 2, 7, 2, 8, 1, 4, 5, 7);
            //// Making a variable that stores the sum
            //Matrix3 matrix3sum;
            //matrix3sum = matrixtest1 + (matrixtest2);
            //Console.WriteLine(matrix3sum);

            //// Subtraction
            //Matrix3 matrixtest3 = new Matrix3(3, 12, 1, 2, 3, 2, 1, 2, 3);
            //Matrix3 matrixtest4 = new Matrix3(2, 2, 7, 2, 8, 1, 4, 5, 7);
            //Matrix3 matrix3sub;
            //matrix3sub = matrixtest3 - (matrixtest4);
            //Console.WriteLine(matrix3sub);

            //// Multiplictaion
            //Matrix3 matrixtest5 = new Matrix3(3, 12, 1, 2, 3, 2, 1, 2, 3);
            //Matrix3 matrixtest6 = new Matrix3(2, 2, 7, 2, 8, 1, 4, 5, 7);
            //Matrix3 matrix3multiply;
            //matrix3multiply = matrixtest5 * (matrixtest6);
            //Console.WriteLine(matrix3multiply);


            //// Translation of a Matrix3
            //// Rotation of a Matrix3
            //// Scale of a Matrix3





            //Raylib.InitWindow(800, 480, "Hello World");

            //Vector2 screenDimensions = 
            //    new Vector2(Raylib.GetScreenWidth(), Raylib.GetScreenHeight());

            //MathLibrary.Vector2 a = new MathLibrary.Vector2(1, 2);
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(a.Normalized.Magnitude);
            //Console.WriteLine((a.Normalized *5).Magnitude);
            //MathLibrary.Vector2 b = new MathLibrary.Vector2();
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            // Player
            //Vector2 playerPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.75f);
            //float playerRadius = 10;
            //Vector2 playerForward = new Vector2(0, 1).Normalized;
            //float playerSpeed = 50;

            //// Enemy
            //Vector2 enemyPosition = new Vector2(screenDimensions.x * 0.5f, screenDimensions.y * 0.5f);
            //float enemyRadius = 10;
            //Color enemyColor = Color.Red;

            //float playerViewAngle = 90;
            //float playerViewDistance = 300;


            //while (!Raylib.WindowShouldClose())
            {
                //Vector3 vectorA = new Vector3(10, 10, 10);
                //vectorA.DotProduct(vectorA);
                // Update
                // Movement

                //Vector2 movementInput = new Vector2();
                //movementInput.y -= Raylib.IsKeyDown(KeyboardKey.W);
                //movementInput.y += Raylib.IsKeyDown(KeyboardKey.S);
                //movementInput.x -= Raylib.IsKeyDown(KeyboardKey.A);
                //movementInput.x += Raylib.IsKeyDown(KeyboardKey.D);

                //playerPosition += movementInput * playerSpeed * Raylib.GetFrameTime();


                //// Calculate LOS
                //Vector2 playertoEnemyDirection = (playerPosition - enemyPosition).Normalized;
                //float distance = enemyPosition.Distance(playerPosition);
                //float angleToEnemy = (float)Math.Abs(playertoEnemyDirection.Angle(playerForward));

                //// If enemy is in sight
                //if (Math.Abs(angleToEnemy) < (playerViewAngle / 2) * (Math.PI / 180) && distance < playerViewDistance)
                //{
                //    enemyColor = Color.Purple;
                //}
                //else
                //{
                //    enemyColor = Color.Red;
                //}
                
                //// Draw 
                //Raylib.BeginDrawing();
                //Raylib.ClearBackground(Color.White);

                //// Draw Enemy
                //Raylib.DrawCircleV(enemyPosition, enemyRadius, enemyColor);

                //// Draw Player
                //Raylib.DrawCircleV(playerPosition, playerRadius, Color.Green);

                //// Draw player forward
                //Raylib.DrawLineEx(playerPosition, playerPosition - (playerForward * 100), 3, Color.Orange);

                //// Draw a view cone
                //Raylib.DrawCircleSectorLines(
                //    playerPosition,
                //    playerViewDistance,
                //    -90 - (playerViewAngle / 2),
                //    -90 + (playerViewAngle / 2),
                //    10,
                //    Color.Blue);

                //Raylib.EndDrawing();

                //Raylib.SetTargetFPS(60);
                //Raylib.DrawRectangle((int)position.X, (int)position.Y, 50, 50, Color.Red);


                //float speed = 100.0f;

                //int forward = Raylib.IsKeyDown(KeyboardKey.W);
                //int back = Raylib.IsKeyDown(KeyboardKey.S);
                //int left = Raylib.IsKeyDown(KeyboardKey.A);
                //int right = Raylib.IsKeyDown(KeyboardKey.D);

                //deltaPosition.Y -= forward;
                //deltaPosition.Y += back;
                //deltaPosition.X -= left;
                //deltaPosition.X += right;

                //position.X = deltaPosition.X;
                //position.Y = deltaPosition.Y;



                //Raylib.DrawText("Vector!! That's me. 'Cause I'm committing crimes with both direction and magnitude. OH YEAH!!!!!!!!!!!!", 12, 12, 16, Color.Orange);
                //// Head
                //Raylib.DrawCircle(375, 150, 55, Color.Beige);
                //// Glasses
                //Raylib.DrawRectangle(325, 130, 30, 25, Color.Black);
                //Raylib.DrawRectangle(395, 130, 30, 25, Color.Black);
                //Raylib.DrawRectangle(320, 138, 110, 6, Color.Black);
                //// Eyes
                //Raylib.DrawRectangle(330, 135, 25, 20, Color.White);
                //Raylib.DrawRectangle(342, 142, 10, 10, Color.Brown);
                //Raylib.DrawRectangle(395, 135, 25, 20, Color.White);
                //Raylib.DrawRectangle(398, 142, 10, 10, Color.Brown);
                //// Hair
                //Raylib.DrawRectangle(335, 95, 80, 20, Color.Brown);
                //Raylib.DrawRectangle(315, 110, 30, 10, Color.Brown);
                //Raylib.DrawRectangle(395, 110, 30, 10, Color.Brown);
                //// Body
                //Raylib.DrawRectangle(325, 200, 100, 200, Color.Orange);
                //// Arms
                //Raylib.DrawRectangle(310, 200, 15, 125, Color.Orange);
                //Raylib.DrawRectangle(425, 200, 15, 125, Color.Orange);
                //// Hands
                //Raylib.DrawRectangle(310, 320, 15, 20, Color.Beige);
                //Raylib.DrawRectangle(425, 320, 15, 20, Color.Beige);
                //// Zipper
                //Raylib.DrawRectangle(370, 200, 10, 120, Color.White);
                //// Legs
                //Raylib.DrawRectangle(325, 400, 10, 75, Color.Orange);
                //Raylib.DrawRectangle(415, 400, 10, 75, Color.Orange);
                //// Shoes
                //Raylib.DrawRectangle(325, 470, 10, 10, Color.White);
                //Raylib.DrawRectangle(415, 470, 10, 10, Color.White);

                //Raylib.EndDrawing();


            }

            Raylib.CloseWindow();
        }
    }
}
