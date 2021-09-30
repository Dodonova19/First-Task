namespace First_Task
{
    public class Logic
    {
        public static int Solve(int a)
        {
            int b = 0;
            int c = 0;
            int d = 0;

            b = a % 10;
            a = a / 10;
            c = a % 10;
            a = a / 10;
            d = a % 10;

            if (b >= c && b >= d)
            {
                return b;
            }
            else if (c >= b && c >= d)
            {
                return c;
            }
            else
            {
                return d;
            }
        }
    }
}
