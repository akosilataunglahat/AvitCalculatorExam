using System;
using System.Collections.Generic;
using System.Text;

namespace AvitCalculator_Exam
{
    public class Evaluation
    {
        public Stack<double> Evaluate(string expression, string[] num)
        {
            String expr = "(" + expression + ")";
            Stack<String> ops = new Stack<String>();
            Stack<double> result = new Stack<double>();

            foreach (var item in num)
            {
                result.Push(double.Parse(item));
            }

            for (int i = 0; i < expr.Length; i++)
            {
                String strValue = expr.Substring(i, 1);

                if (strValue.Equals("("))
                { }
                else if (strValue.Equals("+"))
                {
                    ops.Push(strValue);
                }
                else if (strValue.Equals("-"))
                {
                    ops.Push(strValue);
                }
                else if (strValue.Equals("*"))
                {
                    ops.Push(strValue);
                }
                else if (strValue.Equals("/"))
                {
                    ops.Push(strValue);
                }
                else if (strValue.Equals("sqrt"))
                {
                    ops.Push(strValue);
                }
                else if (strValue.Equals(")"))
                {
                    int count = ops.Count;
                    while (count > 0)
                    {
                        String operand = ops.Pop();
                        double ans = result.Pop();

                        ans = operand switch
                        {
                            "-" => result.Pop() - ans,
                            "+" => result.Pop() + ans,
                            "/" => result.Pop() / ans,
                            "*" => result.Pop() * ans,
                            "sqrt" => Math.Sqrt(ans),
                            _ => 0,
                        };

                        result.Push(ans);

                        count--;
                    }
                }
            }

            return result;
        }
    }
}
