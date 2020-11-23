using System;
using System.Collections.Generic;
using System.Windows.Forms;


namespace Calculator {

    enum Operator {
        Add,
        Subtract,
        Multiply,
        Divide,
        SquareRoot,
        NSquareRoot,
        Percentage,
        Empty
    }

    public partial class Calculator : Form {
        public Calculator() {
            InitializeComponent();
            InitPrintableButtons();
            InitActionButtons();
            InitFields();
            InitStuffs();
            CenterToScreen();
        }

        #region Fields
        private List<string> roots; // for solving equation
        private Equation equation; // for solving equation

        private double preOperand;
        private Operator curOperator;
        private string expression;
        private bool hasFinished;
        private bool isSolvingEquation;
        private double memory; // saved by pressing M+; press MR to recall
        #endregion

        #region Methods
        private void Calculate() {
            curOperatorLabel.Text = string.Empty;

            if (!double.TryParse(screenTextBox.Text, out double operand)) {
                SetDefaultDisplay();
                hasFinished = true;
                return;
            }

            switch (curOperator) {
                case Operator.Add:
                    preOperand = preOperand + operand;
                    break;
                case Operator.Subtract:
                    preOperand = preOperand - operand;
                    break;
                case Operator.Multiply:
                    preOperand = preOperand * operand;
                    break;
                case Operator.Divide:
                    preOperand = preOperand / operand;
                    break;
                case Operator.SquareRoot:
                    preOperand = Math.Sqrt(operand);
                    break;
                case Operator.NSquareRoot:
                    preOperand = Math.Pow(operand, 1 / preOperand);
                    break;
                case Operator.Percentage:
                    preOperand = operand / 100;
                    break;
                case Operator.Empty:
                    preOperand = operand;
                    break;
            }
        }

        private void SolveQuadratic() {
            isSolvingEquation = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += solveEquation_Click;
            curFunctionLabel.Text = "EQN 2";
            equation = new Equation();
            equation.N = 2;
            resultTextBox.Text = equation.GetCurrentString();
        }

        private void SolveCubicEquation() {
            isSolvingEquation = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += solveEquation_Click;
            curFunctionLabel.Text = "EQN 3";
            equation = new Equation();
            equation.N = 3;
            resultTextBox.Text = equation.GetCurrentString();
        }

        // TODO
        private void Solve2VarEquations() {
            isSolvingEquation = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += solveEquation_Click;
            curFunctionLabel.Text = "2 EQNs";
            resultTextBox.Text = "UPDATING...";
        }

        private void StartFunction(int index) {
            SetDefaultDisplay();
            switch (index) {
                case 0:
                    SolveQuadratic();
                    break;
                case 1:
                    SolveCubicEquation(); // TODO
                    break;
                case 2:
                    Solve2VarEquations(); // TODO
                    break;
                case 3:
                    new Calculator().Show(); // TODO
                    break;
            }
        }
        #endregion

        private void Help(object sender, EventArgs e) {
            Program.ForFun(n: 10, bg: true); // TODO
        }
    }
}
