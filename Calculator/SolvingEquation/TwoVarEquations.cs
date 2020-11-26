using System.Collections.Generic;


namespace Calculator {
    class TwoVarEquations {

        public List<double> A; // coefficient list
        public int N {
            get;
        }

        public TwoVarEquations() {
            A = new List<double>();
            N = 6; // 6 coefficients
        }

        public List<string> Solve() {
            List<string> roots = new List<string>();

            // 2-variable equations
            // A0 x + A1 y = A2
            // A3 x + A4 y = A5

            double d = A[0] * A[4] - A[1] * A[3];
            double dx = A[2] * A[4] - A[1] * A[5];
            double dy = A[0] * A[5] - A[2] * A[3];

            if (d == 0) {
                if (dx == 0 && dy == 0) {
                    roots.Add($"All Numbers");
                }
                else {
                    roots.Add("No Solution");
                }
            }
            else {
                roots.Add($"x = {dx / d}, y = {dy / d}");
            }

            return roots;
        }

        public override string ToString() {
            switch (A.Count) {
                case 0:
                    return $"... x {timeSymbols[0]}";
                case 1:
                    return $"{A[0]}x + ... y {timeSymbols[0]}";
                case 2:
                    return $"{A[0]}x + {A[1]}y = ... {timeSymbols[0]}";
                case 3:
                    return $"... x {timeSymbols[1]}";
                case 4:
                    return $"{A[3]}x + ... y {timeSymbols[1]}";
                case 5:
                    return $"{A[3]}x + {A[4]}y = ... {timeSymbols[1]}";
            }

            string text = string.Empty;
            if (A[0] != 0) {
                if (A[1] > 0) {
                    text += $"{A[0]}x + {A[1]}y = {A[2]}, ";
                }
                else if (A[1] < 0) {
                    text += $"{A[0]}x - {-A[1]}y = {A[2]}, ";
                }
                else {
                    text += $"{A[0]}x = {A[2]}, ";
                }
            }
            else {
                if (A[1] != 0) {
                    text += $"{A[1]}y = {A[2]}, ";
                }
                else {
                    text += $"0 = {A[2]}, ";
                }
            }

            if (A[3] != 0) {
                if (A[4] > 0) {
                    text += $"{A[3]}x + {A[4]}y = {A[5]}.";
                }
                else if (A[4] < 0) {
                    text += $"{A[3]}x - {-A[4]}y = {A[5]}.";
                }
                else {
                    text += $"{A[3]}x = {A[5]}.";
                }
            }
            else {
                if (A[4] != 0) {
                    text += $"{A[4]}y = {A[5]}.";
                }
                else {
                    text += $"0 = {A[5]}.";
                }
            }

            return text;
        }

        // symbols from Wikipedia
        // source: https://en.wikipedia.org/wiki/List_of_Unicode_characters#Superscripts_and_Subscripts
        private string[] timeSymbols = { "₍₁₎", "₍₂₎" };
    }
}
