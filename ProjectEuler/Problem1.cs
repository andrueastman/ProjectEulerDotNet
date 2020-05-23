namespace Project_Euler
{
    public class Problem1 : Problem
    {
        private const int Maximum = 1000;
        public override string Answer()
        {
            long total = 0;

            for (var i = 0; i < Maximum; i++)
            {
                if (i % 3 == 0 || i % 5 == 0)
                {
                    total += i;
                }
            }

            return $"{total}";
        }
    }
}