using System;
using System.Collections.Generic;
using System.Numerics;
using System.Windows.Forms;

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
            if (N == 2) {
                return SolveQuadratic(A);
            }

            // TODO
            if (N == 3) {

                // cubic equation ax^3 + bx^2 + cx + d = 0
                double a = A[0];
                double b = A[1];
                double c = A[2];
                double d = A[3];

                if (a == 0) {
                    return SolveQuadratic(new List<double>() { b, c, d });
                }

                List<string> X = new List<string>();

                if (d == 0) {
                    X = SolveQuadratic(new List<double>() { a, b, c });
                    X.Add($"{rootSymbols[3]} = {0}");
                    return X;
                }

                double x = 0;

                // delta = b^2 - 3ac
                double delta = b * b - 3 * a * c;

                if (delta == 0) {
                    double delta_ = b * b * b - 27 * a * a * d;
                    if (delta_ == 0) {
                        x = -b / 3 / a;
                        return new List<string>() {
                            $"{rootSymbols[0]} = {x}"
                        };
                    }
                    int sign = delta_ > 0 ? 1 : -1;
                    x = -b / 3 / a
                        + sign * Math.Pow(sign * delta_, 1.0 / 3) / 3 / a;
                    return new List<string>() {
                        $"{rootSymbols[0]} = {x}"
                    };
                }

                double k = (9 * a * b * c - 2 * b * b * b - 27 * a * a * d)
                    / 2 / Math.Sqrt(delta * delta * Math.Abs(delta));

                if (delta < 0) {
                    double k1 = k + Math.Sqrt(k * k + 1);
                    double k2 = k - Math.Sqrt(k * k + 1);
                    int sign1 = k1 > 0 ? 1 : -1;
                    int sign2 = k2 > 0 ? 1 : -1;
                    x = Math.Sqrt(Math.Abs(delta)) / 3 / a
                        * (sign1 * Math.Pow(sign1 * k1, 1.0 / 3)
                        + sign2 * Math.Pow(sign2 * k2, 1.0 / 3))
                        - b / 3 / a;   
                }
                else {
                    double sign = 1;
                    if (k < 0) {
                        sign = -1;
                        k = -k;
                    }
                    if (k <= 1) {
                        x = 2 * Math.Sqrt(delta) / 3 / a
                            * (Math.Cos(Math.Acos(sign * k) / 3))
                            - b / 3 / a;
                    }
                    else {
                        x = sign * Math.Sqrt(delta) / 3 / a
                            * (Math.Pow(k + Math.Sqrt(k * k - 1), 1.0 / 3)
                            + Math.Pow(k - Math.Sqrt(k * k - 1), 1.0 / 3))
                            - b / 3 / a;
                    }
                }

                X = SolveQuadratic(new List<double>() {
                    a,
                    b + a * x,
                    c + b * x + a * x * x
                });

                return new List<string>() {
                        X[0],
                        X[1],
                        $"{rootSymbols[3]} = {x}"
                };
            }

            return new List<string>() { "ERROR" };
        }

        private List<string> SolveQuadratic(List<double> a) {
            List<string> x = new List<string>();
            if (a[0] == 0) {
                if (a[1] == 0) {
                    if (a[2] == 0) {
                        x.Add("All Numbers");
                        return x;
                    }
                    x.Add("No Solution");
                    return x;
                }
                x.Add($"{rootSymbols[0]} = {a[2] / a[1]}");
                return x;
            }

            double delta = a[1] * a[1] - 4 * a[0] * a[2];
            
            if (delta == 0) {
                x.Add($"{rootSymbols[0]} = {-a[1] / 2 / a[0]}");
                return x;
            }

            return new List<string>() {
                $"{rootSymbols[1]} = {ComplexToString((-a[1] + Complex.Sqrt(delta)) / 2 / a[0])}",
                $"{rootSymbols[2]} = {ComplexToString((-a[1] - Complex.Sqrt(delta)) / 2 / a[0])}"
            };
        }

        private string ComplexToString(Complex c) {
            double r = c.Real;
            double i = c.Imaginary;
            if (i == 0) return r.ToString();
            if (r == 0) return $"{i}i";
            if (i < 0) return $"{r} - {-i}i";
            return $"{r} + {i}i";
        }

        // symbols from Wikipedia
        // source: https://en.wikipedia.org/wiki/List_of_Unicode_characters#Superscripts_and_Subscripts
        private static string[] symbols = { string.Empty, "x", "x²", "x³" };
        private static string[] rootSymbols = { "x", "x₁", "x₂", "x₃" };

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
