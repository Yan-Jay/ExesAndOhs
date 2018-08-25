namespace ExesAndOhs
{
    public class Kata
    {
        public static bool XO(string input)
        {
            input = input.ToLower();
            var x = 0;
            var y = 0;
            foreach (var target in input)
            {
                switch (target)
                {
                    case 'o':
                        x++;
                        break;

                    case 'x':
                        y++;
                        break;

                    default:
                        continue;
                }
            }

            if (x == 0 && y == 0)
            {
                return true;
            }
            return x == y ? true : false;
        }
    }
}