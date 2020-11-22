using System;
using System.Collections.Generic;


namespace Calculator {
    class Equation {

        public List<double> A; // coefficient list

        public int N {
            get; set;
        }

        public Equation() {
            this.A = new List<double>();
        }

        // Return a list of solution strings
        public List<string> Solve() {
            List<string> x = new List<string>();

            if (N == 2) {
                if (A[0] == 0) {
                    if (A[1] == 0) {
                        if (A[2] == 0) {
                            x.Add("All Numbers");
                            return x;
                        }
                        x.Add("No Solution");
                        return x;
                    }
                    x.Add($"x = {A[2] / A[1]}");
                    return x;
                }
                double delta = A[1] * A[1] - 4 * A[0] * A[2];
                if (delta == 0) {
                    x.Add($"x = {-A[1] / 2 / A[0]}");
                    return x;
                }
                if (delta > 0) {
                    x.Add($"x = {(-A[1] + Math.Sqrt(delta)) / 2 / A[0]}");
                    x.Add($"x = {(-A[1] - Math.Sqrt(delta)) / 2 / A[0]}");
                    return x;
                }
                double r = -A[1] / 2 / A[0];
                double i = Math.Sqrt(-delta) / 2 / A[0];
                if (r == 0) {
                    x.Add($"x = {i}i");
                    x.Add($"x = {-i}i");
                    return x;
                }
                x.Add($"x = {r} + {i}i");
                x.Add($"x = {r} - {i}i");
                return x;
            }

            if (N == 3) {
                
            }

            return new List<string>() { "ERROR" };
        }

        // TODO
        private double Newton(double x0, double e) {
            double x = 0;

            while (true) {
                x = x0 - F(x0) / DF(x0);
                if (Math.Abs(F(x)) < e) break;
                x0 = x;
            }
            
            return x;
        }

        private double DF(double x) {
            double df = 0;
            for (var i = 0; i < N; i++) {
                df += (N - i) * A[i] * Math.Pow(x, N - i - 1);
            }
            return df;
        }

        private double F(double x) {
            double f = 0;
            for (var i = 0; i <= N; i++) {
                f += A[i] * Math.Pow(x, N - i);
            }
            return f;
        }

        private static string[] symbols = { string.Empty, "x", "x²", "x³" };

        // Return a temporary string of the equation
        public string GetCurrentString() {
            if (A.Count == 0) return $"... {symbols[N]}";
            if (A.Count == N + 1) return this.ToString();
            string text = this.ToString();
            text = text.Replace(" = 0", $" + ... {symbols[N - A.Count]}");
            return text;
        }

        public override string ToString() {
            string text = string.Empty;
            if (A[0] != 0) {
                text += $"{A[0]}{symbols[N]}";
            }
            for (var i = 1; i <= A.Count - 1; i++) {
                if (A[i] > 0) {
                    text += $" + {A[i]}{symbols[N - i]}";
                }
                else if (A[i] < 0) {
                    text += $" - {-A[i]}{symbols[N - i]}";
                }
            }
            if (text.Length == 0) text = "0";
            return text + " = 0 ";
        }
    }
}
