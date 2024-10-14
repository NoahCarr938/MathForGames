using MathLibrary;
using Raylib_cs;


namespace Sandbox
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Raylib.InitWindow(800, 480, "Hello World");

            //MathLibrary.Vector2 a = new MathLibrary.Vector2(1, 2);
            //Console.WriteLine(a.ToString());
            //Console.WriteLine(a.Normalized.Magnitude);
            //Console.WriteLine((a.Normalized *5).Magnitude);
            //MathLibrary.Vector2 b = new MathLibrary.Vector2();
            //Console.WriteLine(a == b);
            //Console.WriteLine(a != b);

            while (!Raylib.WindowShouldClose())
            {
                Raylib.BeginDrawing();
                Raylib.ClearBackground(Color.Gray);
                Raylib.SetTargetFPS(60);
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
