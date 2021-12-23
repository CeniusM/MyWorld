using CS_Physics_Engine.Vector;
using CS_MyConsole;

namespace CS_Testing
{
    class TestingVector
    {
        public static void TestVector2()
        {
            Vector2 vector = new Vector2(3, 4);

            MyConsole.WriteLine("hi");

            MyConsole.WriteLine(vector.GetString());

            MyConsole.WriteLine(vector.Lenght.ToString());

            vector.Reverse();

            MyConsole.WriteLine(vector.GetString());

            MyConsole.WriteLine(vector.Lenght.ToString());

            vector.Scale(2);

            MyConsole.WriteLine(vector.GetString());

            MyConsole.WriteLine(vector.Lenght.ToString());

            vector.Scale(0.25f);

            MyConsole.WriteLine(vector.GetString());

            MyConsole.WriteLine(vector.Lenght.ToString());

            vector.Add(new Vector2(3, 4));

            MyConsole.WriteLine(vector.GetString());

            MyConsole.WriteLine(vector.Lenght.ToString());
        }
    }
}