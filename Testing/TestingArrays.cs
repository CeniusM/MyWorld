using CS_MyConsole;

namespace CS_Testing
{
    class TestingArrays
    {
        public static void TestArray() // not sure???
        {
            // H = Height, W = Width
            //                   H   W
            int[,] arr = new int[3, 5];
            for (int i = 0; i < 3; i++)
            {
                arr[i,1] = 1;
            }

            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 5; j++)
                {
                    MyConsole.Write(arr[i, j].ToString());
                }
                MyConsole.WriteLine(" ");
            }
        }
    }
}