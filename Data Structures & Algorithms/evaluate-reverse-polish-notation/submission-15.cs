public class Solution {
    public int Arithmetic(string op, string expr1, string expr2) {
        int answer = -100;

        if (op == "+")
            answer = (int.Parse(expr1) + int.Parse(expr2));

        else if (op == "-")
            answer = (int.Parse(expr1) - int.Parse(expr2));

        else if (op == "*")
            answer = (int.Parse(expr1) * int.Parse(expr2));

        else if (op == "/")
            answer = (int.Parse(expr1) / int.Parse(expr2));

        return answer;
    }

    public void PrintList(List<string> list) {
        foreach (var s in list) {
            Console.WriteLine($"\t\t{s}");
        }
    }

    public int EvalRPN(string[] tokens) {
        List<string> opSymbol = new List<string>();
        Stack<string> stack = new Stack<string>();

        opSymbol.Add("/");
        opSymbol.Add("*");
        opSymbol.Add("+");
        opSymbol.Add("-");

        var list = tokens.ToList();

        for (int i = 0; i < list.Count; i++) {
            if (list[i] == "/" || list[i] == "*" || list[i] == "-" || list[i] == "+") {
                var expr2 = stack.Pop();
                var expr1 = stack.Pop();
                string op = list[i];

                int answer = Arithmetic(op, expr1.ToString(), expr2.ToString());
                stack.Push(answer.ToString());
            } else
                stack.Push(list[i]);
        }

        var answer1 = stack.Pop();

        return int.Parse(answer1);
    }
}