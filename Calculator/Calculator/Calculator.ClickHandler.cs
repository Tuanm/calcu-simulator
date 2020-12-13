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

            string text = _screen;
            expression = $"{expression}{text} = ";
            _screen = expression;
            _result = preOperand.ToString();
            expression = string.Empty;
            curOperator = Operator.Empty;
            hasFinished = true; // set it to true,
                               // clicking some buttons may clear the textbox
        }

        // what happens when clicking button = (while solving equation)
        private void solveEquation_Click(object sender, EventArgs e) {
            string text = _screen;
            _screen = string.Empty;
            int n = equation.N;
            if (!hasFinished) {
                try {
                    double a = double.Parse(text);
                    equation.A.Add(a);
                    _result = equation.GetCurrentString();
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
                _screen = equation.ToString();
                _result = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        // what happens when clicking button = (while solving 2-var equations)
        private void solve2VarEquations_Click(object sender, EventArgs e) {
            string text = _screen;
            _screen = string.Empty;
            if (!hasFinished) {
                try {
                    double a = double.Parse(text);
                    equations.A.Add(a);
                    _result = equations.ToString();
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
                _screen = equations.ToString();
                _result = roots[0];
                roots.RemoveAt(0);
                if (roots.Count == 0) {
                    ResetCalculateButton();
                }
            }
        }

        // what happens when clicking button = (while evaluating Polish Notation)
        private void evaluatePolishNotation_Click(object sender, EventArgs e) {
            if (hasFinished) {
                _screen = string.Empty; // clear the screen if it's finished
                _result = "0";
                hasFinished = false;
                return;
            }
            string text = _screen;
            try {
                _result = PolishNotation.PolishNotation.Evaluate(text).ToString();
            } catch (Exception) {
                _result = "ERROR";
            } finally {
                hasFinished = true;
            }
        }

        // as its name
        private void squareRootFunctionButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation || isEvaluatingPN) {
                return; // cannot press this button while solving equation
            }

            string symbol = squareRootFunctionButton.Text;
            _operator = symbol;
            _screen = string.Empty;
            _result = "0";
            expression = $"{symbol}";
            curOperator = Operator.SquareRoot;
        }

        // as its name
        private void nSquareRootFunctionButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation || isEvaluatingPN) {
                return; // cannot press this button while solving equation
            }

            string symbol = nSquareRootFunctionButton.Text;
            _operator = symbol;
            if (hasFinished) {
                _screen = _result;
            }

            Calculate();
            if (hasFinished) return; // double-check
            
            string text = _screen;
            preOperand = (int)preOperand;
            _result = preOperand.ToString();
            _screen = string.Empty;
            expression = $"[{expression}{text}]{symbol}";
            curOperator = Operator.NSquareRoot;
        }

        // what happens when clicking button %
        private void percentageButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation || isEvaluatingPN) {
                return; // cannot press this button while solving equation
            }

            if (hasFinished) return;
            
            Operator preOperator = curOperator;
            Calculate(); // get pre-operand
            curOperator = Operator.Percentage;
            Calculate(); // finish calculating
            if (hasFinished) return; // double-check

            string text = _screen;
            if (preOperator == Operator.Empty) {
                expression = $"{text}% = ";
            }
            else {
                expression = $"({expression}{text})% = ";
            }
            _screen = expression;
            _result = preOperand.ToString();
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
                _screen = _result;
            }

            if (isEvaluatingPN) {
                _screen += button.Text;
                return;
            }

            Calculate();
            if (hasFinished) return; // double-check

            string text = _screen;
            _result = preOperand.ToString();
            _screen = string.Empty;
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
            _operator = button.Text;
        }

        // what happens when clicking button + or button -
        private void operatorAddSubButtons_Click(object sender, EventArgs e) {
            if (isSolvingEquation) {
                return; // cannot press this button while solving equation
            }

            Button button = sender as Button;

            if (isEvaluatingPN) {
                _screen += button.Text;
                return;
            }

            if (hasFinished) {
                _screen = _result;
            }

            Calculate();
            if (hasFinished) return; // double-check

            string text = _screen;
            _result = preOperand.ToString();
            _screen = string.Empty;
            expression = $"{expression}{text}{button.Text}";
            curOperator = button.Text.Equals(operatorAddButton.Text) ?
                Operator.Add : Operator.Subtract;
            _operator = button.Text;
        }

        // just print whatever button's text to screen
        private void printableButtons_Click(object sender, EventArgs e) {
            if (hasFinished) {
                _screen = string.Empty;
                hasFinished = false;
            }
            Button button = sender as Button;
            string buttonText = button.Text;
            if (buttonText.Equals(dotButton.Text)) {
                if (_screen.Contains(buttonText)) return; // cannot have more than
                                                         // one dot on the screen
            }
            _screen += buttonText;
            calculateButton.Select();
        }

        // load stuff from memory if it exists
        private void memoryRecallButton_Click(object sender, EventArgs e) {
            if (memory != 0) {
                _screen = memory.ToString();
            }
        }

        // add stuff to memory
        private void memoryStoreButton_Click(object sender, EventArgs e) {
            if (isSolvingEquation || isEvaluatingPN) {
                return; // cannot press this button while solving equation
            }

            Calculate();
            _screen = string.Empty;
            _result = preOperand.ToString();
            Button button = sender as Button;
            if (button.Text.Equals(memoryAddButton.Text)) {
                memory += preOperand;
            }
            else {
                memory -= preOperand;
            }
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
                _screen = string.Empty;
                return;
            }

            string text = _screen;
            if (text.Length > 0) {
                _screen
                    = text.Substring(0, text.Length - 1); // just remove the last
                                                         // character on the screen
            }
        }

        // set button ='s click event to default
        private void ResetCalculateButton() {
            isSolvingEquation = false;
            isEvaluatingPN = false;
            calculateButton.Click -= solveEquation_Click;
            calculateButton.Click -= solve2VarEquations_Click;
            calculateButton.Click -= evaluatePolishNotation_Click;
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
            SetDefaultTaskbarDisplay();
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click -= solveEquation_Click;
            calculateButton.Click -= solve2VarEquations_Click;
            calculateButton.Click -= evaluatePolishNotation_Click;
            calculateButton.Click += calculateButton_Click;
            isSolvingEquation = false;
            isEvaluatingPN = false;

            expression = string.Empty;
            preOperand = 0;
            curOperator = Operator.Empty;
        }

        // clear screen
        private void SetDefaultDisplay() {
            EnableAllButtons();
            _screen = string.Empty;
            _result = "0";
        }

        // clean shits on screen
        private void SetDefaultTaskbarDisplay() {
            _operator = string.Empty;
            curFunctionLabel.Text = string.Empty;
        }
    }
}
