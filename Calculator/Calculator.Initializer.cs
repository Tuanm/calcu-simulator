using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator {
    partial class Calculator {
        private void InitFields() {
            curOperator = Operator.Empty;
            expression = string.Empty;
            screenTextBox.Text = string.Empty;
        }

        private void InitActionButtons() {
            allCancelButton.Select();
            allCancelButton.Click += allCancelButton_Click;
            cancelEntryButton.Click += cancelEntryButton_Click;
            memoryAddButton.Click += memoryAddButton_Click;
            memoryRecallButton.Click += memoryRecallButton_Click;
            calculateButton.Click += calculateButton_Click;
            squareRootFunctionButton.Click += squareRootFunctionButton_Click;
            nSquareRootFunctionButton.Click += nSquareRootFunctionButton_Click;
            percentageButton.Click += percentageButton_Click;
            operatorAddButton.Click += operatorAddSubButtons_Click;
            operatorSubtractButton.Click += operatorAddSubButtons_Click;
            operatorMultiplyButton.Click += operatorMulDivButtons_Click;
            operatorDivideButton.Click += operatorMulDivButtons_Click;
        }

        private void InitPrintableButtons() {
            List<Button> printableButtons = new List<Button>() {
                digit0Button, dotButton,
                digit1Button, digit2Button, digit3Button,
                digit4Button, digit5Button, digit6Button,
                digit7Button, digit8Button, digit9Button
            };

            signSwitcherButton.Click += (object sender, EventArgs e) => {
                if (hasFinished) {
                    screenTextBox.Text = string.Empty;
                    hasFinished = false;
                }
                string text = screenTextBox.Text;
                string sqrtSymbol = squareRootFunctionButton.Text;
                if (!IsCalculable()) {
                    screenTextBox.Text = "-";
                }
                else {
                    double number = -double.Parse(text);
                    screenTextBox.Text = number.ToString();
                }

                if (curOperator != Operator.SquareRoot) {
                    expression = string.Empty;
                    curOperatorLabel.Text = string.Empty;
                }
                if (!isSolvingEquation) resultTextBox.Text = "0";
                preOperand = 0;
                
            };

            foreach (Button button in printableButtons) {
                button.Click += printableButtons_Click;
            }
        }

        private void InitStuffs() {
            menuLabel.Click += (object sender, EventArgs e) => {
                ShowUpMenu(1);
            };
            menuPanel.Location = new Point(-ClientSize.Width, 0);
            menuPanel.Visible = true;
            menuPanel.AutoScroll = true;
            menuPanel.Click += (object sender, EventArgs e) => {
                ShowUpMenu(-5);
            };

            AddFunctionToMenu("Quadratic");
            AddFunctionToMenu("Cubic Equation");
            AddFunctionToMenu("2-Var Equations");
            AddFunctionToMenu("Box Drawing");
        }

        private void DisableAllButtons() {
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    control.Enabled = !control.Enabled;
                }
            }
        }

        private void ShowUpMenu(int flag) {
            int current = flag > 0 ? -ClientSize.Width : 0;
            int target = current + flag * ClientSize.Width;
            while (true) {
                current += flag;
                if (current * flag >= target * flag) break;
                menuPanel.Location = new Point(current, 0);
            }
            menuPanel.Location = new Point(target, 0);
            this.Refresh();
        }

        private void AddFunctionToMenu(string text) {
            int index = menuPanel.Controls.Count;
            Label label = new Label();
            menuPanel.Controls.Add(label);
            label.Text = text;
            label.AutoSize = true;
            label.Left = menuPanel.Width / 2 - label.Width / 2;
            label.Top = int.Parse($"{Math.Floor(label.Height * (index + 0.5) * 1.5)}");
            label.Click += (object sender, EventArgs e) => {
                ShowUpMenu(-5);
                StartFunction(index);
            };
            label.MouseHover += (object sender, EventArgs e) => {
                label.ForeColor = Color.White;
            };
            label.MouseLeave += (object sender, EventArgs e) => {
                label.ForeColor = Color.Black;
            };
        }
    }
}
