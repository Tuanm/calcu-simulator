using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Calculator {
    partial class Calculator {

        private void InitFields() {
            SetDefault(); // yes, set all stuffs to their default
        }

        private void InitActionButtons() {
            allCancelButton.Select();
            allCancelButton.Click += allCancelButton_Click;
            cancelEntryButton.Click += cancelEntryButton_Click;
            memoryAddButton.Click += memoryStoreButton_Click;
            memorySubtractButton.Click += memoryStoreButton_Click;
            memoryRecallButton.Click += memoryRecallButton_Click;
            calculateButton.Click += calculateButton_Click;
            squareRootFunctionButton.Click += squareRootFunctionButton_Click;
            nSquareRootFunctionButton.Click += nSquareRootFunctionButton_Click;
            percentageButton.Click += percentageButton_Click;
            operatorAddButton.Click += operatorAddSubButtons_Click;
            operatorSubtractButton.Click += operatorAddSubButtons_Click;
            operatorMultiplyButton.Click += operatorMulDivButtons_Click;
            operatorDivideButton.Click += operatorMulDivButtons_Click;
            // too much things to deal with
        }

        private void InitPrintableButtons() {
            List<Button> printableButtons = new List<Button>() {
                digit0Button, dotButton,
                digit1Button, digit2Button, digit3Button,
                digit4Button, digit5Button, digit6Button,
                digit7Button, digit8Button, digit9Button
            }; // put all printable buttons in a list,
            // so it's easier to handle their click
            foreach (Button button in printableButtons) {
                button.Click += printableButtons_Click;
            }

            // this shit is used for switching sign of the number
            signSwitcherButton.Click += (object sender, EventArgs e) => {
                if (hasFinished) {
                    _screen = string.Empty;
                    hasFinished = false;
                }
                string text = _screen;
                try {
                    double number = -double.Parse(text);
                    _screen = number.ToString();
                } catch (Exception) {
                    if (text.Contains("-")) {
                        _screen = string.Empty;
                    }
                    else {
                        _screen = "-";
                    }
                }

                if (curOperator == Operator.Empty) {
                    curOperatorLabel.Text = string.Empty;
                    expression = string.Empty;
                    preOperand = 0;
                }
            };
        }

        private void InitializeKeyboardEvents() {
            List<Button> digitButtons = new List<Button>() {
                digit0Button,
                digit1Button, digit2Button, digit3Button,
                digit4Button, digit5Button, digit6Button,
                digit7Button, digit8Button, digit9Button
            };
            List<Keys> keys = new List<Keys>() {
                Keys.D0,
                Keys.D1, Keys.D2, Keys.D3,
                Keys.D4, Keys.D5, Keys.D6,
                Keys.D7, Keys.D8, Keys.D9
            };
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    control.KeyDown += (object sender, KeyEventArgs e) => {
                        foreach (Keys key in keys) {
                            if (e.KeyCode == key) {
                                digitButtons[keys.IndexOf(key)].PerformClick();
                            }
                        }
                    };
                }
            }
        }

        private void InitStuffs() {
            menuLabel.Click += (object sender, EventArgs e) => {
                ShowUpMenu(1);
            };
            menuPanel.Size = new Size(Width / 4 * 3, Height);
            menuPanel.Location = new Point(-menuPanel.Width, 0); // hidden
            menuPanel.Visible = true;
            menuPanel.AutoScroll = true;
            exitMenuLabel.Click += (object sender, EventArgs e) => {
                ShowUpMenu(-5);
            };
            exitMenuLabel.MouseHover += (object sender, EventArgs e) => {
                (sender as Label).ForeColor = Color.White;
            };
            exitMenuLabel.MouseLeave += (object sender, EventArgs e) => {
                (sender as Label).ForeColor = Color.Black;
            };

            AddFunctionToMenu("Quadratic");
            AddFunctionToMenu("Cubic Equation");
            AddFunctionToMenu("2-Var Equations");
            AddFunctionToMenu("Box Drawing");
            AddFunctionToMenu("Polish Notation");
            // Add more functions to menu here...

            // if there're too many controls on panel,
            // add an empty string to its end
            if (menuPanel.Controls.Count > 6) {
                AddFunctionToMenu(string.Empty);
            }
        }

        // don't ask me why the hell we need to disable all buttons
        private void DisableAllButtons(bool except = true) {
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    control.Enabled = false;
                }
            }

            memoryRecallButton.Enabled = true;
            allCancelButton.Enabled = true; // button AC cannot be disabled
            allCancelButton.Select();

            if (except) {
                calculateButton.Enabled = true; // keep it enabled for some reasons
                calculateButton.Select();
            }
        }

        // as its name
        private void EnableAllButtons() {
            foreach (Control control in this.Controls) {
                if (control is Button) {
                    control.Enabled = true;
                }
            }
            resultTextBox.Enabled = true;
            allCancelButton.Select();
        }

        // hide/show all controls in form
        private void SwitchVisibility() {
            foreach (Control control in this.Controls) {
                control.Visible = !control.Visible;
            }

            allCancelButton.Visible = true; // button AC is always visible
        }

        // display or hide the menu
        private void ShowUpMenu(int flag) {
            int current = flag > 0 ? -menuPanel.Width : 0;
            int target = current + flag * menuPanel.Width;
            while (true) {
                // if (current % 15 == 0) this.Refresh(); // flicked
                current += flag;
                if (current * flag >= target * flag) break;
                menuPanel.Location = new Point(current, 0);
            }
            menuPanel.Location = new Point(target, 0);
            if (flag > 0) {
                resultTextBox.Enabled = false;
                DisableAllButtons(except: false);
            }
            else {
                resultTextBox.Enabled = true;
                EnableAllButtons();
            }
            // this.Refresh();
        }

        // add a function to menu, and set its clicking event
        private void AddFunctionToMenu(string text) {
            int index = menuPanel.Controls.Count;
            Label label = new Label();
            menuPanel.Controls.Add(label);
            label.Text = text;
            label.AutoSize = true;
            label.Left = menuPanel.Width / 2 - label.Width / 2; // center to screen
            label.Top = int.Parse($"{Math.Floor(label.Height * index * 1.25)}");
            label.Click += (object sender, EventArgs e) => {
                ShowUpMenu(-5);
                StartFunction(index - 1); // 'cause there's a label in the panel
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
