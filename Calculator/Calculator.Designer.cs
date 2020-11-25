namespace Calculator {
    partial class Calculator {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            this.screenTextBox = new System.Windows.Forms.TextBox();
            this.resultTextBox = new System.Windows.Forms.TextBox();
            this.memoryAddButton = new System.Windows.Forms.Button();
            this.memoryRecallButton = new System.Windows.Forms.Button();
            this.cancelEntryButton = new System.Windows.Forms.Button();
            this.allCancelButton = new System.Windows.Forms.Button();
            this.operatorDivideButton = new System.Windows.Forms.Button();
            this.digit9Button = new System.Windows.Forms.Button();
            this.digit8Button = new System.Windows.Forms.Button();
            this.digit7Button = new System.Windows.Forms.Button();
            this.operatorMultiplyButton = new System.Windows.Forms.Button();
            this.digit6Button = new System.Windows.Forms.Button();
            this.digit5Button = new System.Windows.Forms.Button();
            this.digit4Button = new System.Windows.Forms.Button();
            this.operatorSubtractButton = new System.Windows.Forms.Button();
            this.digit3Button = new System.Windows.Forms.Button();
            this.digit2Button = new System.Windows.Forms.Button();
            this.digit1Button = new System.Windows.Forms.Button();
            this.operatorAddButton = new System.Windows.Forms.Button();
            this.calculateButton = new System.Windows.Forms.Button();
            this.dotButton = new System.Windows.Forms.Button();
            this.digit0Button = new System.Windows.Forms.Button();
            this.memoryStatusLabel = new System.Windows.Forms.Label();
            this.curOperatorLabel = new System.Windows.Forms.Label();
            this.squareRootFunctionButton = new System.Windows.Forms.Button();
            this.nSquareRootFunctionButton = new System.Windows.Forms.Button();
            this.curFunctionLabel = new System.Windows.Forms.Label();
            this.signSwitcherButton = new System.Windows.Forms.Button();
            this.menuPanel = new System.Windows.Forms.Panel();
            this.exitMenuLabel = new System.Windows.Forms.Label();
            this.menuLabel = new System.Windows.Forms.Label();
            this.percentageButton = new System.Windows.Forms.Button();
            this.memorySubtractButton = new System.Windows.Forms.Button();
            this.menuPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // screenTextBox
            // 
            this.screenTextBox.BackColor = System.Drawing.Color.White;
            this.screenTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.screenTextBox.Enabled = false;
            this.screenTextBox.Font = new System.Drawing.Font("Segoe UI", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.screenTextBox.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.screenTextBox.Location = new System.Drawing.Point(20, 40);
            this.screenTextBox.MaxLength = 99;
            this.screenTextBox.Multiline = true;
            this.screenTextBox.Name = "screenTextBox";
            this.screenTextBox.ReadOnly = true;
            this.screenTextBox.Size = new System.Drawing.Size(460, 70);
            this.screenTextBox.TabIndex = 0;
            // 
            // resultTextBox
            // 
            this.resultTextBox.BackColor = System.Drawing.Color.White;
            this.resultTextBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.resultTextBox.Font = new System.Drawing.Font("Segoe UI", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resultTextBox.ForeColor = System.Drawing.Color.Black;
            this.resultTextBox.Location = new System.Drawing.Point(20, 80);
            this.resultTextBox.MaxLength = 99;
            this.resultTextBox.Name = "resultTextBox";
            this.resultTextBox.ReadOnly = true;
            this.resultTextBox.ScrollBars = System.Windows.Forms.ScrollBars.Horizontal;
            this.resultTextBox.Size = new System.Drawing.Size(460, 39);
            this.resultTextBox.TabIndex = 1;
            this.resultTextBox.Text = "0";
            this.resultTextBox.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            // 
            // memoryAddButton
            // 
            this.memoryAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.memoryAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.memoryAddButton.FlatAppearance.BorderSize = 0;
            this.memoryAddButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.memoryAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.memoryAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.memoryAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryAddButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryAddButton.ForeColor = System.Drawing.Color.Black;
            this.memoryAddButton.Location = new System.Drawing.Point(115, 150);
            this.memoryAddButton.Name = "memoryAddButton";
            this.memoryAddButton.Size = new System.Drawing.Size(75, 50);
            this.memoryAddButton.TabIndex = 2;
            this.memoryAddButton.Text = "M+";
            this.memoryAddButton.UseVisualStyleBackColor = false;
            // 
            // memoryRecallButton
            // 
            this.memoryRecallButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.memoryRecallButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.memoryRecallButton.FlatAppearance.BorderSize = 0;
            this.memoryRecallButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.memoryRecallButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.memoryRecallButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.memoryRecallButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memoryRecallButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryRecallButton.ForeColor = System.Drawing.Color.Black;
            this.memoryRecallButton.Location = new System.Drawing.Point(210, 150);
            this.memoryRecallButton.Name = "memoryRecallButton";
            this.memoryRecallButton.Size = new System.Drawing.Size(75, 50);
            this.memoryRecallButton.TabIndex = 3;
            this.memoryRecallButton.Text = "MR";
            this.memoryRecallButton.UseVisualStyleBackColor = false;
            // 
            // cancelEntryButton
            // 
            this.cancelEntryButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancelEntryButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.cancelEntryButton.FlatAppearance.BorderSize = 0;
            this.cancelEntryButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.cancelEntryButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(128)))));
            this.cancelEntryButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(255)))), ((int)(((byte)(210)))));
            this.cancelEntryButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.cancelEntryButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cancelEntryButton.ForeColor = System.Drawing.Color.Black;
            this.cancelEntryButton.Location = new System.Drawing.Point(305, 150);
            this.cancelEntryButton.Name = "cancelEntryButton";
            this.cancelEntryButton.Size = new System.Drawing.Size(75, 50);
            this.cancelEntryButton.TabIndex = 4;
            this.cancelEntryButton.Text = "CE";
            this.cancelEntryButton.UseVisualStyleBackColor = false;
            // 
            // allCancelButton
            // 
            this.allCancelButton.BackColor = System.Drawing.Color.Red;
            this.allCancelButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.allCancelButton.FlatAppearance.BorderSize = 0;
            this.allCancelButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.allCancelButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Red;
            this.allCancelButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.allCancelButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.allCancelButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.allCancelButton.ForeColor = System.Drawing.Color.White;
            this.allCancelButton.Location = new System.Drawing.Point(400, 150);
            this.allCancelButton.Name = "allCancelButton";
            this.allCancelButton.Size = new System.Drawing.Size(75, 50);
            this.allCancelButton.TabIndex = 5;
            this.allCancelButton.Text = "AC";
            this.allCancelButton.UseVisualStyleBackColor = false;
            // 
            // operatorDivideButton
            // 
            this.operatorDivideButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.operatorDivideButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.operatorDivideButton.FlatAppearance.BorderSize = 0;
            this.operatorDivideButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.operatorDivideButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.operatorDivideButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.operatorDivideButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorDivideButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorDivideButton.ForeColor = System.Drawing.Color.Black;
            this.operatorDivideButton.Location = new System.Drawing.Point(305, 220);
            this.operatorDivideButton.Name = "operatorDivideButton";
            this.operatorDivideButton.Size = new System.Drawing.Size(75, 50);
            this.operatorDivideButton.TabIndex = 9;
            this.operatorDivideButton.Text = " ÷ ";
            this.operatorDivideButton.UseVisualStyleBackColor = false;
            // 
            // digit9Button
            // 
            this.digit9Button.BackColor = System.Drawing.Color.White;
            this.digit9Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit9Button.FlatAppearance.BorderSize = 0;
            this.digit9Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit9Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit9Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit9Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit9Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit9Button.ForeColor = System.Drawing.Color.Black;
            this.digit9Button.Location = new System.Drawing.Point(210, 220);
            this.digit9Button.Name = "digit9Button";
            this.digit9Button.Size = new System.Drawing.Size(75, 50);
            this.digit9Button.TabIndex = 8;
            this.digit9Button.Text = "9";
            this.digit9Button.UseVisualStyleBackColor = false;
            // 
            // digit8Button
            // 
            this.digit8Button.BackColor = System.Drawing.Color.White;
            this.digit8Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit8Button.FlatAppearance.BorderSize = 0;
            this.digit8Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit8Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit8Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit8Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit8Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit8Button.ForeColor = System.Drawing.Color.Black;
            this.digit8Button.Location = new System.Drawing.Point(115, 220);
            this.digit8Button.Name = "digit8Button";
            this.digit8Button.Size = new System.Drawing.Size(75, 50);
            this.digit8Button.TabIndex = 7;
            this.digit8Button.Text = "8";
            this.digit8Button.UseVisualStyleBackColor = false;
            // 
            // digit7Button
            // 
            this.digit7Button.BackColor = System.Drawing.Color.White;
            this.digit7Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit7Button.FlatAppearance.BorderSize = 0;
            this.digit7Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit7Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit7Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit7Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit7Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit7Button.ForeColor = System.Drawing.Color.Black;
            this.digit7Button.Location = new System.Drawing.Point(20, 220);
            this.digit7Button.Name = "digit7Button";
            this.digit7Button.Size = new System.Drawing.Size(75, 50);
            this.digit7Button.TabIndex = 6;
            this.digit7Button.Text = "7";
            this.digit7Button.UseVisualStyleBackColor = false;
            // 
            // operatorMultiplyButton
            // 
            this.operatorMultiplyButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.operatorMultiplyButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.operatorMultiplyButton.FlatAppearance.BorderSize = 0;
            this.operatorMultiplyButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.operatorMultiplyButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.operatorMultiplyButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.operatorMultiplyButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorMultiplyButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorMultiplyButton.ForeColor = System.Drawing.Color.Black;
            this.operatorMultiplyButton.Location = new System.Drawing.Point(305, 290);
            this.operatorMultiplyButton.Name = "operatorMultiplyButton";
            this.operatorMultiplyButton.Size = new System.Drawing.Size(75, 50);
            this.operatorMultiplyButton.TabIndex = 13;
            this.operatorMultiplyButton.Text = " × ";
            this.operatorMultiplyButton.UseVisualStyleBackColor = false;
            // 
            // digit6Button
            // 
            this.digit6Button.BackColor = System.Drawing.Color.White;
            this.digit6Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit6Button.FlatAppearance.BorderSize = 0;
            this.digit6Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit6Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit6Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit6Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit6Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit6Button.ForeColor = System.Drawing.Color.Black;
            this.digit6Button.Location = new System.Drawing.Point(210, 290);
            this.digit6Button.Name = "digit6Button";
            this.digit6Button.Size = new System.Drawing.Size(75, 50);
            this.digit6Button.TabIndex = 12;
            this.digit6Button.Text = "6";
            this.digit6Button.UseVisualStyleBackColor = false;
            // 
            // digit5Button
            // 
            this.digit5Button.BackColor = System.Drawing.Color.White;
            this.digit5Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit5Button.FlatAppearance.BorderSize = 0;
            this.digit5Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit5Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit5Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit5Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit5Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit5Button.ForeColor = System.Drawing.Color.Black;
            this.digit5Button.Location = new System.Drawing.Point(115, 290);
            this.digit5Button.Name = "digit5Button";
            this.digit5Button.Size = new System.Drawing.Size(75, 50);
            this.digit5Button.TabIndex = 11;
            this.digit5Button.Text = "5";
            this.digit5Button.UseVisualStyleBackColor = false;
            // 
            // digit4Button
            // 
            this.digit4Button.BackColor = System.Drawing.Color.White;
            this.digit4Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit4Button.FlatAppearance.BorderSize = 0;
            this.digit4Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit4Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit4Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit4Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit4Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit4Button.ForeColor = System.Drawing.Color.Black;
            this.digit4Button.Location = new System.Drawing.Point(20, 290);
            this.digit4Button.Name = "digit4Button";
            this.digit4Button.Size = new System.Drawing.Size(75, 50);
            this.digit4Button.TabIndex = 10;
            this.digit4Button.Text = "4";
            this.digit4Button.UseVisualStyleBackColor = false;
            // 
            // operatorSubtractButton
            // 
            this.operatorSubtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.operatorSubtractButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.operatorSubtractButton.FlatAppearance.BorderSize = 0;
            this.operatorSubtractButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.operatorSubtractButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.operatorSubtractButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.operatorSubtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorSubtractButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorSubtractButton.ForeColor = System.Drawing.Color.Black;
            this.operatorSubtractButton.Location = new System.Drawing.Point(305, 360);
            this.operatorSubtractButton.Name = "operatorSubtractButton";
            this.operatorSubtractButton.Size = new System.Drawing.Size(75, 50);
            this.operatorSubtractButton.TabIndex = 17;
            this.operatorSubtractButton.Text = " - ";
            this.operatorSubtractButton.UseVisualStyleBackColor = false;
            // 
            // digit3Button
            // 
            this.digit3Button.BackColor = System.Drawing.Color.White;
            this.digit3Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit3Button.FlatAppearance.BorderSize = 0;
            this.digit3Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit3Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit3Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit3Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit3Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit3Button.ForeColor = System.Drawing.Color.Black;
            this.digit3Button.Location = new System.Drawing.Point(210, 360);
            this.digit3Button.Name = "digit3Button";
            this.digit3Button.Size = new System.Drawing.Size(75, 50);
            this.digit3Button.TabIndex = 16;
            this.digit3Button.Text = "3";
            this.digit3Button.UseVisualStyleBackColor = false;
            // 
            // digit2Button
            // 
            this.digit2Button.BackColor = System.Drawing.Color.White;
            this.digit2Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit2Button.FlatAppearance.BorderSize = 0;
            this.digit2Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit2Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit2Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit2Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit2Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit2Button.ForeColor = System.Drawing.Color.Black;
            this.digit2Button.Location = new System.Drawing.Point(115, 360);
            this.digit2Button.Name = "digit2Button";
            this.digit2Button.Size = new System.Drawing.Size(75, 50);
            this.digit2Button.TabIndex = 15;
            this.digit2Button.Text = "2";
            this.digit2Button.UseVisualStyleBackColor = false;
            // 
            // digit1Button
            // 
            this.digit1Button.BackColor = System.Drawing.Color.White;
            this.digit1Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit1Button.FlatAppearance.BorderSize = 0;
            this.digit1Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit1Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit1Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit1Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit1Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit1Button.ForeColor = System.Drawing.Color.Black;
            this.digit1Button.Location = new System.Drawing.Point(20, 360);
            this.digit1Button.Name = "digit1Button";
            this.digit1Button.Size = new System.Drawing.Size(75, 50);
            this.digit1Button.TabIndex = 14;
            this.digit1Button.Text = "1";
            this.digit1Button.UseVisualStyleBackColor = false;
            // 
            // operatorAddButton
            // 
            this.operatorAddButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.operatorAddButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.operatorAddButton.FlatAppearance.BorderSize = 0;
            this.operatorAddButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.operatorAddButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.operatorAddButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.operatorAddButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.operatorAddButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.operatorAddButton.ForeColor = System.Drawing.Color.Black;
            this.operatorAddButton.Location = new System.Drawing.Point(305, 430);
            this.operatorAddButton.Name = "operatorAddButton";
            this.operatorAddButton.Size = new System.Drawing.Size(75, 50);
            this.operatorAddButton.TabIndex = 21;
            this.operatorAddButton.Text = " + ";
            this.operatorAddButton.UseVisualStyleBackColor = false;
            // 
            // calculateButton
            // 
            this.calculateButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.calculateButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.calculateButton.FlatAppearance.BorderSize = 0;
            this.calculateButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.calculateButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(210)))), ((int)(((byte)(210)))));
            this.calculateButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(210)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.calculateButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.calculateButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.calculateButton.ForeColor = System.Drawing.Color.White;
            this.calculateButton.Location = new System.Drawing.Point(400, 430);
            this.calculateButton.Name = "calculateButton";
            this.calculateButton.Size = new System.Drawing.Size(75, 50);
            this.calculateButton.TabIndex = 20;
            this.calculateButton.Text = "=";
            this.calculateButton.UseVisualStyleBackColor = false;
            // 
            // dotButton
            // 
            this.dotButton.BackColor = System.Drawing.Color.White;
            this.dotButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.dotButton.FlatAppearance.BorderSize = 0;
            this.dotButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.dotButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dotButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.dotButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.dotButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotButton.ForeColor = System.Drawing.Color.Black;
            this.dotButton.Location = new System.Drawing.Point(115, 430);
            this.dotButton.Name = "dotButton";
            this.dotButton.Size = new System.Drawing.Size(75, 50);
            this.dotButton.TabIndex = 19;
            this.dotButton.Text = ".";
            this.dotButton.UseVisualStyleBackColor = false;
            // 
            // digit0Button
            // 
            this.digit0Button.BackColor = System.Drawing.Color.White;
            this.digit0Button.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.digit0Button.FlatAppearance.BorderSize = 0;
            this.digit0Button.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.digit0Button.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit0Button.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.digit0Button.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.digit0Button.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.digit0Button.ForeColor = System.Drawing.Color.Black;
            this.digit0Button.Location = new System.Drawing.Point(20, 430);
            this.digit0Button.Name = "digit0Button";
            this.digit0Button.Size = new System.Drawing.Size(75, 50);
            this.digit0Button.TabIndex = 18;
            this.digit0Button.Text = "0";
            this.digit0Button.UseVisualStyleBackColor = false;
            // 
            // memoryStatusLabel
            // 
            this.memoryStatusLabel.AutoSize = true;
            this.memoryStatusLabel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memoryStatusLabel.ForeColor = System.Drawing.Color.Black;
            this.memoryStatusLabel.Location = new System.Drawing.Point(60, 20);
            this.memoryStatusLabel.Name = "memoryStatusLabel";
            this.memoryStatusLabel.Size = new System.Drawing.Size(0, 13);
            this.memoryStatusLabel.TabIndex = 22;
            // 
            // curOperatorLabel
            // 
            this.curOperatorLabel.AutoSize = true;
            this.curOperatorLabel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curOperatorLabel.ForeColor = System.Drawing.Color.Black;
            this.curOperatorLabel.Location = new System.Drawing.Point(40, 20);
            this.curOperatorLabel.Name = "curOperatorLabel";
            this.curOperatorLabel.Size = new System.Drawing.Size(0, 13);
            this.curOperatorLabel.TabIndex = 23;
            // 
            // squareRootFunctionButton
            // 
            this.squareRootFunctionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.squareRootFunctionButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.squareRootFunctionButton.FlatAppearance.BorderSize = 0;
            this.squareRootFunctionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.squareRootFunctionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.squareRootFunctionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.squareRootFunctionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.squareRootFunctionButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.squareRootFunctionButton.ForeColor = System.Drawing.Color.Black;
            this.squareRootFunctionButton.Location = new System.Drawing.Point(400, 220);
            this.squareRootFunctionButton.Name = "squareRootFunctionButton";
            this.squareRootFunctionButton.Size = new System.Drawing.Size(75, 50);
            this.squareRootFunctionButton.TabIndex = 25;
            this.squareRootFunctionButton.Text = " √";
            this.squareRootFunctionButton.UseVisualStyleBackColor = false;
            // 
            // nSquareRootFunctionButton
            // 
            this.nSquareRootFunctionButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.nSquareRootFunctionButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.nSquareRootFunctionButton.FlatAppearance.BorderSize = 0;
            this.nSquareRootFunctionButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.nSquareRootFunctionButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.nSquareRootFunctionButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.nSquareRootFunctionButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.nSquareRootFunctionButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nSquareRootFunctionButton.ForeColor = System.Drawing.Color.Black;
            this.nSquareRootFunctionButton.Location = new System.Drawing.Point(400, 290);
            this.nSquareRootFunctionButton.Name = "nSquareRootFunctionButton";
            this.nSquareRootFunctionButton.Size = new System.Drawing.Size(75, 50);
            this.nSquareRootFunctionButton.TabIndex = 26;
            this.nSquareRootFunctionButton.Text = " ⁿ√";
            this.nSquareRootFunctionButton.UseVisualStyleBackColor = false;
            // 
            // curFunctionLabel
            // 
            this.curFunctionLabel.AutoSize = true;
            this.curFunctionLabel.Font = new System.Drawing.Font("Segoe UI Light", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.curFunctionLabel.ForeColor = System.Drawing.Color.Black;
            this.curFunctionLabel.Location = new System.Drawing.Point(80, 20);
            this.curFunctionLabel.Name = "curFunctionLabel";
            this.curFunctionLabel.Size = new System.Drawing.Size(0, 13);
            this.curFunctionLabel.TabIndex = 28;
            // 
            // signSwitcherButton
            // 
            this.signSwitcherButton.BackColor = System.Drawing.Color.White;
            this.signSwitcherButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.signSwitcherButton.FlatAppearance.BorderSize = 0;
            this.signSwitcherButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.signSwitcherButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(170)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signSwitcherButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.signSwitcherButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.signSwitcherButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signSwitcherButton.ForeColor = System.Drawing.Color.Black;
            this.signSwitcherButton.Location = new System.Drawing.Point(210, 430);
            this.signSwitcherButton.Name = "signSwitcherButton";
            this.signSwitcherButton.Size = new System.Drawing.Size(75, 50);
            this.signSwitcherButton.TabIndex = 29;
            this.signSwitcherButton.Text = "+/-";
            this.signSwitcherButton.UseVisualStyleBackColor = false;
            // 
            // menuPanel
            // 
            this.menuPanel.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.menuPanel.Controls.Add(this.exitMenuLabel);
            this.menuPanel.Font = new System.Drawing.Font("Segoe UI Light", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuPanel.ForeColor = System.Drawing.Color.Black;
            this.menuPanel.Location = new System.Drawing.Point(495, 0);
            this.menuPanel.Name = "menuPanel";
            this.menuPanel.Size = new System.Drawing.Size(495, 500);
            this.menuPanel.TabIndex = 30;
            this.menuPanel.Visible = false;
            // 
            // exitMenuLabel
            // 
            this.exitMenuLabel.AutoSize = true;
            this.exitMenuLabel.Font = new System.Drawing.Font("Segoe UI", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitMenuLabel.ForeColor = System.Drawing.Color.Black;
            this.exitMenuLabel.Location = new System.Drawing.Point(0, 0);
            this.exitMenuLabel.Name = "exitMenuLabel";
            this.exitMenuLabel.Size = new System.Drawing.Size(35, 37);
            this.exitMenuLabel.TabIndex = 33;
            this.exitMenuLabel.Text = "×";
            // 
            // menuLabel
            // 
            this.menuLabel.AutoSize = true;
            this.menuLabel.Font = new System.Drawing.Font("Segoe UI Light", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.menuLabel.ForeColor = System.Drawing.Color.Black;
            this.menuLabel.Location = new System.Drawing.Point(0, 0);
            this.menuLabel.Name = "menuLabel";
            this.menuLabel.Size = new System.Drawing.Size(35, 37);
            this.menuLabel.TabIndex = 31;
            this.menuLabel.Text = "≡";
            // 
            // percentageButton
            // 
            this.percentageButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.percentageButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.percentageButton.FlatAppearance.BorderSize = 0;
            this.percentageButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.percentageButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.percentageButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.percentageButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.percentageButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.percentageButton.ForeColor = System.Drawing.Color.Black;
            this.percentageButton.Location = new System.Drawing.Point(400, 360);
            this.percentageButton.Name = "percentageButton";
            this.percentageButton.Size = new System.Drawing.Size(75, 50);
            this.percentageButton.TabIndex = 32;
            this.percentageButton.Text = " %";
            this.percentageButton.UseVisualStyleBackColor = false;
            // 
            // memorySubtractButton
            // 
            this.memorySubtractButton.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(250)))), ((int)(((byte)(250)))), ((int)(((byte)(250)))));
            this.memorySubtractButton.FlatAppearance.BorderColor = System.Drawing.Color.White;
            this.memorySubtractButton.FlatAppearance.BorderSize = 0;
            this.memorySubtractButton.FlatAppearance.CheckedBackColor = System.Drawing.Color.Black;
            this.memorySubtractButton.FlatAppearance.MouseDownBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(170)))), ((int)(((byte)(170)))));
            this.memorySubtractButton.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(230)))), ((int)(((byte)(230)))), ((int)(((byte)(230)))));
            this.memorySubtractButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.memorySubtractButton.Font = new System.Drawing.Font("Segoe UI Light", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.memorySubtractButton.ForeColor = System.Drawing.Color.Black;
            this.memorySubtractButton.Location = new System.Drawing.Point(20, 150);
            this.memorySubtractButton.Name = "memorySubtractButton";
            this.memorySubtractButton.Size = new System.Drawing.Size(75, 50);
            this.memorySubtractButton.TabIndex = 33;
            this.memorySubtractButton.Text = "M-";
            this.memorySubtractButton.UseVisualStyleBackColor = false;
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(96F, 96F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Dpi;
            this.BackColor = System.Drawing.Color.White;
            this.ClientSize = new System.Drawing.Size(495, 500);
            this.Controls.Add(this.menuPanel);
            this.Controls.Add(this.curFunctionLabel);
            this.Controls.Add(this.curOperatorLabel);
            this.Controls.Add(this.memoryStatusLabel);
            this.Controls.Add(this.resultTextBox);
            this.Controls.Add(this.screenTextBox);
            this.Controls.Add(this.percentageButton);
            this.Controls.Add(this.signSwitcherButton);
            this.Controls.Add(this.nSquareRootFunctionButton);
            this.Controls.Add(this.squareRootFunctionButton);
            this.Controls.Add(this.operatorAddButton);
            this.Controls.Add(this.calculateButton);
            this.Controls.Add(this.dotButton);
            this.Controls.Add(this.digit0Button);
            this.Controls.Add(this.operatorSubtractButton);
            this.Controls.Add(this.digit3Button);
            this.Controls.Add(this.digit2Button);
            this.Controls.Add(this.digit1Button);
            this.Controls.Add(this.operatorMultiplyButton);
            this.Controls.Add(this.digit6Button);
            this.Controls.Add(this.digit5Button);
            this.Controls.Add(this.digit4Button);
            this.Controls.Add(this.operatorDivideButton);
            this.Controls.Add(this.digit9Button);
            this.Controls.Add(this.digit8Button);
            this.Controls.Add(this.digit7Button);
            this.Controls.Add(this.allCancelButton);
            this.Controls.Add(this.cancelEntryButton);
            this.Controls.Add(this.memoryRecallButton);
            this.Controls.Add(this.memoryAddButton);
            this.Controls.Add(this.menuLabel);
            this.Controls.Add(this.memorySubtractButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Calculator";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.Text = "Calculator";
            this.TopMost = true;
            this.menuPanel.ResumeLayout(false);
            this.menuPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox screenTextBox;
        private System.Windows.Forms.TextBox resultTextBox;
        private System.Windows.Forms.Button memoryAddButton;
        private System.Windows.Forms.Button memoryRecallButton;
        private System.Windows.Forms.Button cancelEntryButton;
        private System.Windows.Forms.Button allCancelButton;
        private System.Windows.Forms.Button operatorDivideButton;
        private System.Windows.Forms.Button digit9Button;
        private System.Windows.Forms.Button digit8Button;
        private System.Windows.Forms.Button digit7Button;
        private System.Windows.Forms.Button operatorMultiplyButton;
        private System.Windows.Forms.Button digit6Button;
        private System.Windows.Forms.Button digit5Button;
        private System.Windows.Forms.Button digit4Button;
        private System.Windows.Forms.Button operatorSubtractButton;
        private System.Windows.Forms.Button digit3Button;
        private System.Windows.Forms.Button digit2Button;
        private System.Windows.Forms.Button digit1Button;
        private System.Windows.Forms.Button operatorAddButton;
        private System.Windows.Forms.Button calculateButton;
        private System.Windows.Forms.Button dotButton;
        private System.Windows.Forms.Button digit0Button;
        private System.Windows.Forms.Label memoryStatusLabel;
        private System.Windows.Forms.Label curOperatorLabel;
        private System.Windows.Forms.Button squareRootFunctionButton;
        private System.Windows.Forms.Button nSquareRootFunctionButton;
        private System.Windows.Forms.Label curFunctionLabel;
        private System.Windows.Forms.Button signSwitcherButton;
        private System.Windows.Forms.Panel menuPanel;
        private System.Windows.Forms.Label menuLabel;
        private System.Windows.Forms.Button percentageButton;
        private System.Windows.Forms.Label exitMenuLabel;
        private System.Windows.Forms.Button memorySubtractButton;
    }
}

