using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Calculator.PolishNotation {
    class PolishNotation {
        private string expression;

        public PolishNotation() {
            this.expression = string.Empty;
        }

        public PolishNotation(string expression) {
            this.expression = expression.Replace(" ", string.Empty);
        }

        private static string[] parentheses = { "(", ")" };
        private static string[] operators = { "×", "÷", "+", "-" };

    }
}
