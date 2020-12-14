using System;
using System.Collections.Generic;
using System.Text;


namespace Calculator {
    class PolishNotation {
		public static string Evaluate(string exp) {
			if (!char.IsDigit(exp[0]) && exp[0] != '(') exp = "0" + exp;
			int length = exp.Length;
			Stack<double> values = new Stack<double>();
			Stack<char> ops = new Stack<char>();
			// travese all char in string
			for (int i = 0; i < length; i++) {
				// push operand to stack
				if (exp[i] >= '0' && exp[i] <= '9') {
					string s = "";
					while (i < length && ((exp[i] >= '0' && exp[i] <= '9') || exp[i] == '.')) {
						s = s + exp[i++];
					}
					values.Push(double.Parse(s));
					i--;
				}
				// push parenthese to stack ops
				else if (exp[i] == '(') {
					ops.Push(exp[i]);
				}
				else if (exp[i] == ')') {
					while (ops.Count > 0 && ops.Peek() != '(') {
						string c = OpsApply(ops.Pop(), values.Pop(), values.Pop());
						values.Push(double.Parse(c));
					}
					// Error caused lack of parentthese left
					if (ops.Count == 0)
						throw new Exception("Syntax error.");
					ops.Pop();
				}
				else if (exp[i] == '+' || exp[i] == '-' || exp[i] == '*' || exp[i] == '/') {
					while (ops.Count > 0 && HasPrecedence(exp[i], ops.Peek()) && values.Count > 1) {
						string c = OpsApply(ops.Pop(), values.Pop(), values.Pop());
						values.Push(double.Parse(c));
					}
					ops.Push(exp[i]);
				}
			}
			while (ops.Count > 0 && values.Count > 1) {
				string c = OpsApply(ops.Pop(), values.Pop(), values.Pop());
				values.Push(double.Parse(c));
			}
			// Error caused excess ops
			if (ops.Count > 0 || values.Count > 1)
				throw new Exception("Syntax error.");
			return values.Pop().ToString();
		}
		public static bool HasPrecedence(char op1, char op2) {
			if (op2 == '(' || op2 == ')') {
				return false;
			}
			if ((op1 == '*' || op1 == '/') &&
				(op2 == '+' || op2 == '-')) {
				return false;
			}
			else {
				return true;
			}
		}
		public static string OpsApply(char op, double b, double a) {
			switch (op) {
				case '+':
					return (a + b).ToString();
				case '-':
					return (a - b).ToString();
				case '*':
					return (a * b).ToString();
				case '/':
					if (b == 0) {
						throw new Exception("Cannot divide by zero.");
					}
					return (a / b).ToString();
			}
			return "0";
		}
	}
}
