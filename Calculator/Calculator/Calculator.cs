using Calculator;
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
            InitializeKeyboardEvents();
            InitFields();
            InitStuffs();
            CenterToScreen();
        }

        #region Fields
        private List<string> roots; // for solving equation
        private Equation equation; // for solving equation
        private TwoVarEquations equations; // for solving 2-var equations

        private double preOperand;
        private Operator curOperator;
        private string expression;
        private bool hasFinished;
        private bool isSolvingEquation;
        private bool isEvaluatingPN;
        private double memory; // saved by pressing M+; press MR to recall

        #region Text Fields
        private string _screen {
            get => screenTextBox.Text;
            set => screenTextBox.Text = value;
        }

        private string _result {
            get => resultTextBox.Text;
            set => resultTextBox.Text = value;
        }

        private string _operator {
            get => curOperatorLabel.Text;
            set => curOperatorLabel.Text = value;
        }
        #endregion
        #endregion

        #region Methods
        private void Calculate() {
            _operator = string.Empty;

            if (!double.TryParse(_screen, out double operand)) {
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
                    if (preOperand % 2 != 0) {
                        if (operand < 0) {
                            preOperand = -Math.Pow(-operand, 1 / preOperand);
                        }
                    }
                    else preOperand = Math.Pow(operand, 1 / preOperand);
                    break;
                case Operator.Percentage:
                    preOperand = preOperand / 100;
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
            _result = equation.GetCurrentString();
        }

        private void SolveCubicEquation() {
            isSolvingEquation = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += solveEquation_Click;
            curFunctionLabel.Text = "EQN 3";
            equation = new Equation();
            equation.N = 3;
            _result = equation.GetCurrentString();
        }

        private void Solve2VarEquations() {
            isSolvingEquation = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += solve2VarEquations_Click;
            curFunctionLabel.Text = "2 EQNs";
            equations = new TwoVarEquations();
            _result = equations.ToString();
        }

        private void StartPolishNotationMode() {
            isEvaluatingPN = true;
            hasFinished = false;
            calculateButton.Click -= calculateButton_Click;
            calculateButton.Click += evaluatePolishNotation_Click;
            curFunctionLabel.Text = "PN";
        }

        private void StartFunction(int index) {
            SetDefault();
            switch (index) {
                case 0:
                    SolveQuadratic();
                    break;
                case 1:
                    SolveCubicEquation();
                    break;
                case 2:
                    Solve2VarEquations();
                    break;
                case 3:
                    new Tuan(this).Show();
                    break;
                case 4:
                    StartPolishNotationMode();
                    break;
            }
        }
        #endregion
    }
}
