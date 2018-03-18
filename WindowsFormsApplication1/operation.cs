using System.Linq;
using System.Text.RegularExpressions;

namespace WindowsFormsApplication1
{
     class operation
    {
        public static string Calc(string exp, char sign)
        {
            var r = new Regex(string.Format(@"(\d+)\{0}(\d+)", sign));
            var exps = r.Matches(exp);
            if (exps.Count == 0) return exp;
            exp = exps.Cast<Match>().Aggregate(exp, (current, p) => current.Replace(p.ToString(), Operate(p.ToString(), sign).ToString()));
            exp = Calc(exp, sign);
            return exp;
        }
        private static double Operate(string exp, char sign)
        {
            var arr = exp.Split(sign);
            double result = 0;
            var numA = double.Parse(arr[0]);
            var numB = double.Parse(arr[1]);
            switch (sign)
            {
                case '+':
                    result = numA + numB;
                    break;
                case '-':
                    result = numA - numB;
                    break;
                case '*':
                    result = numA * numB;
                    break;
                case '/':
                    result = numB != 0 ? numA / numB : 0;
                    break;
            }
            return result;
        }
    }
}