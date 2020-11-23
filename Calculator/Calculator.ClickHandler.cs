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

            curOperatorLabel.Text = string.Empty;
            if (!IsCalculable()) {
                screenTextBox.Text = string.Empty;
                return;
            }

            Calculate();
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
            if (!IsCalculable()) return;
            string text = screenTextBox.Text;
            screenTextBox.Text = string.Empty;
            int n = equation.N;
            if (!hasFinished) {
                double a = double.Parse(text);
                equation.A.Add(a);
                resultTextBox.Text = equation.GetCurrentString();
            }
            if (equation.A.Count == n + 1) {
                if (!hasFinished) {
                    roots = equation.Solve();
                    hasFinished = true;
                }
                screenTextBox.Text = equation.ToString();
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
            if (!IsCalculable()) return;

            Calculate();
            string text = screenTextBox.Text;
            resultTextBox.Text = preOperand.ToString();
            screenTextBox.Text = string.Empty;
            expression = $"({expression}{text}){symbol}";
            curOperator = Operator.NSquareRoot;
        }

        private void percentageButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            if (hasFinished) return;

            curOperatorLabel.Text = string.Empty;
            if (!IsCalculable()) {
                screenTextBox.Text = string.Empty;
                return;
            }

            Operator preOperator = curOperator;
            curOperator = Operator.Percentage;
            Calculate();
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

            curOperatorLabel.Text = button.Text;
            if (hasFinished) {
                screenTextBox.Text = resultTextBox.Text;
            }
            if (!IsCalculable()) return;

            Calculate();
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
        }

        private void operatorAddSubButtons_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Button button = sender as Button;

            curOperatorLabel.Text = button.Text;
            if (hasFinished) {
                screenTextBox.Text = resultTextBox.Text;
            }
            if (!IsCalculable()) return;

            Calculate();
            string text = screenTextBox.Text;
            resultTextBox.Text = preOperand.ToString();
            screenTextBox.Text = string.Empty;
            expression = $"{expression}{text}{button.Text}";
            curOperator = button.Text.Equals(operatorAddButton.Text) ?
                Operator.Add : Operator.Subtract;
        }

        private void printableButtons_Click(object sender, EventArgs e) {
            if (hasFinished) {
                screenTextBox.Text = string.Empty;
                hasFinished = false;
            }
            Button button = sender as Button;
            screenTextBox.Text += button.Text;
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

            if (!IsCalculable()) {
                screenTextBox.Text = string.Empty;
                return;
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
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = "0";
        }

        private void SetDefaultTaskbarDisplay() {
            curOperatorLabel.Text = string.Empty;
            curFunctionLabel.Text = string.Empty;
        }
    }
}
