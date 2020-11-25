using System;
using System.Windows.Forms;


namespace Calculator {
    partial class Calculator {

        // calculate the expression, and display the result (button ='s default clicking event)
        private void calculateButton_Click(object sender, EventArgs e) {
            if (hasFinished) {
                SetDefault(); // if it's finished, clear the textbox
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

        // what happens when clicking button = (while solving equation)
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
                    DisableAllButtons(except: true); // let users be able to click
                                                    // a few buttons
                }
                screenTextBox.Text = equation.ToString();
                resultTextBox.Text = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        // what happens when clicking button = (while solving 2-var equations)
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
                    DisableAllButtons(except: true); // let users be able to click
                                                    // a few buttons
                }
                screenTextBox.Text = equations.ToString();
                resultTextBox.Text = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        // as its name
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

        // as its name
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

        // what happens when clicking button %
        private void percentageButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            if (hasFinished) return;
            
            Operator preOperator = curOperator;
            Calculate(); // get pre-operand
            curOperator = Operator.Percentage;
            Calculate(); // finish calculating
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

        // what happens when clicking button * or button /
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

        // what happens when clicking button + or button -
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

        // just print whatever button's text to screen
        private void printableButtons_Click(object sender, EventArgs e) {
            if (hasFinished) {
                screenTextBox.Text = string.Empty;
                hasFinished = false;
            }
            Button button = sender as Button;
            string buttonText = button.Text;
            string text = screenTextBox.Text;
            if (buttonText.Equals(dotButton.Text)) {
                if (text.Contains(buttonText)) return; // cannot have more than
                                                      // one dot on the screen
            }
            screenTextBox.Text += buttonText;
        }

        // load stuff from memory if it exists
        private void memoryRecallButton_Click(object sender, EventArgs e) {
            if (memory != 0) {
                screenTextBox.Text = memory.ToString();
            }
        }

        // store stuff to memory if it's non-zero; otherwise, get it out from memory
        private void memoryAddButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Calculate();
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = preOperand.ToString();
            memory = preOperand;
            if (memory != 0) {
                memoryStatusLabel.Text = "M"; // display a shit on the screen
                                             // that stupid users can realize
                                            // there's stuff in memory
            }
            else {
                memoryStatusLabel.Text = string.Empty; // just remove the shit
                                                      // we added before
            }
        }

        // what happens when clicking button AC
        private void allCancelButton_Click(object sender, EventArgs e) {
            SetDefault(); // it's the only button AC's usefulness
        }

        // what happens when clicking button CE
        private void cancelEntryButton_Click(object sender, EventArgs e) {
            if (hasFinished) {
                screenTextBox.Text = string.Empty;
                return;
            }

            string text = screenTextBox.Text;
            if (text.Length > 0) {
                screenTextBox.Text
                    = text.Substring(0, text.Length - 1); // just remove the last
                                                         // character on the screen
            }
        }

        // set button ='s click event to default
        private void ResetCalculateButton() {
            isSolvingEquation = false;
            calculateButton.Click -= solveEquation_Click;
            calculateButton.Click -= solve2VarEquations_Click;
            calculateButton.Click += calculateButton_Click;
        }

        // set all controls to default
        private void SetDefault() {
            SetDefaultValue();
            SetDefaultDisplay();
            SetDefaultTaskbarDisplay();
            this.Refresh();
        }

        // set all fields to their default value
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

        // clear screen
        private void SetDefaultDisplay() {
            EnableAllButtons();
            screenTextBox.Text = string.Empty;
            resultTextBox.Text = "0";
        }

        // clean shits on screen
        private void SetDefaultTaskbarDisplay() {
            curOperatorLabel.Text = string.Empty;
            curFunctionLabel.Text = string.Empty;
        }
    }
}
