using System;
using System.Windows.Forms;


namespace Calculator {
    partial class Calculator {

        // Calculate the expression, and display the result
        private void calculateButton_Click(object sender, EventArgs e) {
            if (hasFinished) {
                SetDefault();
                return;
            }
            
            Calculate();
            if (hasFinished) return; // double-check

            string text = screenTextBox.Text;
            expression = $"{expression}{text} = ";
            screenTextBox.Text = expression;
            resultTextBox.Text = preOperand.ToString();
            expression = string.Empty;
            curOperator = Operator.Empty;
            hasFinished = true; // set it to true,
                                // clicking some buttons may clear the textbox
        }

        private void solveEquation_Click(object sender, EventArgs e) {
            string text = screenTextBox.Text;
            screenTextBox.Text = string.Empty;
            int n = equation.N;
            if (!hasFinished) {
                try {
                    double a = double.Parse(text);
                    equation.A.Add(a);
                    resultTextBox.Text = equation.GetCurrentString();
                } catch (Exception) {
                    // SetDefault();
                }
            }
            if (equation.A.Count == n + 1) {
                if (!hasFinished) {
                    roots = equation.Solve();
                    hasFinished = true;
                    DisableAllButtons(except: true);
                }
                screenTextBox.Text = equation.ToString();
                resultTextBox.Text = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        private void solve2VarEquations_Click(object sender, EventArgs e) {
            string text = screenTextBox.Text;
            screenTextBox.Text = string.Empty;
            if (!hasFinished) {
                try {
                    double a = double.Parse(text);
                    equations.A.Add(a);
                    resultTextBox.Text = equations.ToString();
                } catch (Exception) {
                    // SetDefault();
                }
            }
            if (equations.A.Count == equations.N) {
                if (!hasFinished) {
                    roots = equations.Solve();
                    hasFinished = true;
                    DisableAllButtons(except: true);
                }
                screenTextBox.Text = equations.ToString();
                resultTextBox.Text = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        private void squareRootFunctionButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            string symbol = squareRootFunctionButton.Text;
            curOperatorLabel.Text = symbol;
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = "0";
            expression = $"{symbol}";
            curOperator = Operator.SquareRoot;
        }

        private void nSquareRootFunctionButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            string symbol = nSquareRootFunctionButton.Text;
            curOperatorLabel.Text = symbol;
            if (hasFinished) {
                screenTextBox.Text = resultTextBox.Text;
            }

            Calculate();
            if (hasFinished) return; // double-check
            
            string text = screenTextBox.Text;
            preOperand = (int)preOperand;
            resultTextBox.Text = preOperand.ToString();
            screenTextBox.Text = string.Empty;
            expression = $"[{expression}{text}]{symbol}";
            curOperator = Operator.NSquareRoot;
        }

        private void percentageButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            if (hasFinished) return;
            
            Operator preOperator = curOperator;
            Calculate();
            curOperator = Operator.Percentage;
            Calculate();
            if (hasFinished) return; // double-check

            string text = screenTextBox.Text;
            if (preOperator == Operator.Empty) {
                expression = $"{text}% = ";
            }
            else {
                expression = $"({expression}{text})% = ";
            }
            screenTextBox.Text = expression;
            resultTextBox.Text = preOperand.ToString();
            expression = string.Empty;
            curOperator = Operator.Empty;
            hasFinished = true; // set it to true,
                                // clicking some buttons may clear the textbox
        }

        private void operatorMulDivButtons_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Button button = sender as Button;

            if (hasFinished) {
                screenTextBox.Text = resultTextBox.Text;
            }
            
            Calculate();
            if (hasFinished) return; // double-check

            string text = screenTextBox.Text;
            resultTextBox.Text = preOperand.ToString();
            screenTextBox.Text = string.Empty;
            if (curOperator == Operator.Empty
                || curOperator == Operator.Multiply
                || curOperator == Operator.Divide) {
                expression = $"{expression}{text}{button.Text}";
            }
            else {
                expression = $"({expression}{text}){button.Text}";
            }
            curOperator = button.Text.Equals(operatorMultiplyButton.Text) ?
                Operator.Multiply : Operator.Divide;
            curOperatorLabel.Text = button.Text;
        }

        private void operatorAddSubButtons_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Button button = sender as Button;

            if (hasFinished) {
                screenTextBox.Text = resultTextBox.Text;
            }

            Calculate();
            if (hasFinished) return; // double-check

            string text = screenTextBox.Text;
            resultTextBox.Text = preOperand.ToString();
            screenTextBox.Text = string.Empty;
            expression = $"{expression}{text}{button.Text}";
            curOperator = button.Text.Equals(operatorAddButton.Text) ?
                Operator.Add : Operator.Subtract;
            curOperatorLabel.Text = button.Text;
        }

        private void printableButtons_Click(object sender, EventArgs e) {
            if (hasFinished) {
                screenTextBox.Text = string.Empty;
                hasFinished = false;
            }
            Button button = sender as Button;
            string buttonText = button.Text;
            string text = screenTextBox.Text;
            if (buttonText.Equals(dotButton.Text)) {
                if (text.Contains(buttonText)) return;
            }
            screenTextBox.Text += buttonText;
        }

        private void memoryRecallButton_Click(object sender, EventArgs e) {
            if (memory != 0) {
                screenTextBox.Text = memory.ToString();
            }
        }

        private void memoryAddButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Calculate();
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = preOperand.ToString();
            memory = preOperand;
            if (memory != 0) {
                memoryStatusLabel.Text = "M";
            }
            else {
                memoryStatusLabel.Text = string.Empty;
            }
        }

        private void allCancelButton_Click(object sender, EventArgs e) {
            SetDefault();
        }

        private void cancelEntryButton_Click(object sender, EventArgs e) {
            if (hasFinished) {
                screenTextBox.Text = string.Empty;
                return;
            }
            string text = screenTextBox.Text;
            if (text.Length > 0) {
                screenTextBox.Text = text.Substring(0, text.Length - 1);
            }
        }

        private void ResetCalculateButton() {
            isSolvingEquation = false;
            calculateButton.Click -= solveEquation_Click;
            calculateButton.Click -= solve2VarEquations_Click;
            calculateButton.Click += calculateButton_Click;
        }

        private void SetDefault() {
            SetDefaultValue();
            SetDefaultDisplay();
            SetDefaultTaskbarDisplay();
        }

        private void SetDefaultValue() {
            if (isSolvingEquation) {
                SetDefaultTaskbarDisplay();
                calculateButton.Click -= solveEquation_Click;
                calculateButton.Click += calculateButton_Click;
                isSolvingEquation = false;
            }

            expression = string.Empty;
            preOperand = 0;
            curOperator = Operator.Empty;
        }

        private void SetDefaultDisplay() {
            EnableAllButtons();
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = "0";
        }

        private void SetDefaultTaskbarDisplay() {
            curOperatorLabel.Text = string.Empty;
            curFunctionLabel.Text = string.Empty;
        }
    }
}
