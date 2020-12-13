namespace Calculator {
    partial class Box {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Box));
            this.exit = new System.Windows.Forms.Label();
            this.current = new System.Windows.Forms.Label();
            this.save = new FontAwesome.Sharp.IconButton();
            this.toolTip = new System.Windows.Forms.ToolTip(this.components);
            this.clear = new FontAwesome.Sharp.IconButton();
            this.open = new FontAwesome.Sharp.IconButton();
            this.SuspendLayout();
            // 
            // exit
            // 
            this.exit.AutoSize = true;
            this.exit.BackColor = System.Drawing.Color.Transparent;
            this.exit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.exit.Font = new System.Drawing.Font("Bradley Hand ITC", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exit.Location = new System.Drawing.Point(0, 0);
            this.exit.Name = "exit";
            this.exit.Size = new System.Drawing.Size(63, 60);
            this.exit.TabIndex = 0;
            this.exit.Text = "╳";
            this.exit.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.exit.Click += new System.EventHandler(this.exit_Click);
            // 
            // current
            // 
            this.current.AutoSize = true;
            this.current.BackColor = System.Drawing.Color.Transparent;
            this.current.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.current.Font = new System.Drawing.Font("Segoe UI Light", 27.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.current.ForeColor = System.Drawing.Color.Black;
            this.current.Location = new System.Drawing.Point(12, 741);
            this.current.Name = "current";
            this.current.Size = new System.Drawing.Size(0, 50);
            this.current.TabIndex = 1;
            // 
            // save
            // 
            this.save.BackColor = System.Drawing.Color.Transparent;
            this.save.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.save.FlatAppearance.BorderSize = 0;
            this.save.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.save.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.save.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.save.ForeColor = System.Drawing.Color.White;
            this.save.IconChar = FontAwesome.Sharp.IconChar.Image;
            this.save.IconColor = System.Drawing.Color.White;
            this.save.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.save.Location = new System.Drawing.Point(739, 0);
            this.save.Name = "save";
            this.save.Size = new System.Drawing.Size(63, 60);
            this.save.TabIndex = 2;
            this.toolTip.SetToolTip(this.save, "Save to Image");
            this.save.UseVisualStyleBackColor = false;
            // 
            // clear
            // 
            this.clear.BackColor = System.Drawing.Color.Transparent;
            this.clear.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.clear.FlatAppearance.BorderSize = 0;
            this.clear.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.clear.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clear.ForeColor = System.Drawing.Color.White;
            this.clear.IconChar = FontAwesome.Sharp.IconChar.Eraser;
            this.clear.IconColor = System.Drawing.Color.White;
            this.clear.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.clear.Location = new System.Drawing.Point(670, 0);
            this.clear.Name = "clear";
            this.clear.Size = new System.Drawing.Size(63, 60);
            this.clear.TabIndex = 3;
            this.toolTip.SetToolTip(this.clear, "Clear");
            this.clear.UseVisualStyleBackColor = false;
            // 
            // open
            // 
            this.open.BackColor = System.Drawing.Color.Transparent;
            this.open.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Zoom;
            this.open.FlatAppearance.BorderSize = 0;
            this.open.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.open.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.open.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.open.ForeColor = System.Drawing.Color.White;
            this.open.IconChar = FontAwesome.Sharp.IconChar.File;
            this.open.IconColor = System.Drawing.Color.White;
            this.open.IconFont = FontAwesome.Sharp.IconFont.Auto;
            this.open.Location = new System.Drawing.Point(601, 0);
            this.open.Name = "open";
            this.open.Size = new System.Drawing.Size(63, 60);
            this.open.TabIndex = 4;
            this.toolTip.SetToolTip(this.open, "Open Image");
            this.open.UseVisualStyleBackColor = false;
            // 
            // Box
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(55F, 120F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(800, 800);
            this.Controls.Add(this.open);
            this.Controls.Add(this.clear);
            this.Controls.Add(this.save);
            this.Controls.Add(this.current);
            this.Controls.Add(this.exit);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Font = new System.Drawing.Font("Bradley Hand ITC", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Margin = new System.Windows.Forms.Padding(28);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Box";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "z";
            this.TopMost = true;
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label exit;
        private System.Windows.Forms.Label current;
        private FontAwesome.Sharp.IconButton save;
        private System.Windows.Forms.ToolTip toolTip;
        private FontAwesome.Sharp.IconButton clear;
        private FontAwesome.Sharp.IconButton open;
    }
}