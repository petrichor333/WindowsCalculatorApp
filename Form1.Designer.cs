///////////////////////////////////////////////////////
//t info 200 A
//L4calc - a simple calculator app in c#
// 1/19/22 - ericrod - initialization of project
namespace Calculator
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.equalBtn = new System.Windows.Forms.Button();
            this.dotBtn = new System.Windows.Forms.Button();
            this.number0Btn = new System.Windows.Forms.Button();
            this.signBtn = new System.Windows.Forms.Button();
            this.addBtn = new System.Windows.Forms.Button();
            this.number3Btn = new System.Windows.Forms.Button();
            this.number2Btn = new System.Windows.Forms.Button();
            this.number1Btn = new System.Windows.Forms.Button();
            this.minusBtn = new System.Windows.Forms.Button();
            this.number6Btn = new System.Windows.Forms.Button();
            this.number5Btn = new System.Windows.Forms.Button();
            this.number4Btn = new System.Windows.Forms.Button();
            this.timesBtn = new System.Windows.Forms.Button();
            this.number9Btn = new System.Windows.Forms.Button();
            this.number8Btn = new System.Windows.Forms.Button();
            this.number7Btn = new System.Windows.Forms.Button();
            this.divideBtn = new System.Windows.Forms.Button();
            this.deleteBtn = new System.Windows.Forms.Button();
            this.clearBtn = new System.Windows.Forms.Button();
            this.displayWindow = new System.Windows.Forms.TextBox();
            this.clearEntryBtn = new System.Windows.Forms.Button();
            this.tableLayoutPanel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 4;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 25F));
            this.tableLayoutPanel1.Controls.Add(this.equalBtn, 3, 5);
            this.tableLayoutPanel1.Controls.Add(this.dotBtn, 2, 5);
            this.tableLayoutPanel1.Controls.Add(this.number0Btn, 1, 5);
            this.tableLayoutPanel1.Controls.Add(this.signBtn, 0, 5);
            this.tableLayoutPanel1.Controls.Add(this.addBtn, 3, 4);
            this.tableLayoutPanel1.Controls.Add(this.number3Btn, 2, 4);
            this.tableLayoutPanel1.Controls.Add(this.number2Btn, 1, 4);
            this.tableLayoutPanel1.Controls.Add(this.number1Btn, 0, 4);
            this.tableLayoutPanel1.Controls.Add(this.minusBtn, 3, 3);
            this.tableLayoutPanel1.Controls.Add(this.number6Btn, 2, 3);
            this.tableLayoutPanel1.Controls.Add(this.number5Btn, 1, 3);
            this.tableLayoutPanel1.Controls.Add(this.number4Btn, 0, 3);
            this.tableLayoutPanel1.Controls.Add(this.timesBtn, 3, 2);
            this.tableLayoutPanel1.Controls.Add(this.number9Btn, 2, 2);
            this.tableLayoutPanel1.Controls.Add(this.number8Btn, 1, 2);
            this.tableLayoutPanel1.Controls.Add(this.number7Btn, 0, 2);
            this.tableLayoutPanel1.Controls.Add(this.divideBtn, 3, 1);
            this.tableLayoutPanel1.Controls.Add(this.deleteBtn, 2, 1);
            this.tableLayoutPanel1.Controls.Add(this.clearBtn, 1, 1);
            this.tableLayoutPanel1.Controls.Add(this.displayWindow, 0, 0);
            this.tableLayoutPanel1.Controls.Add(this.clearEntryBtn, 0, 1);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 0);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 6;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 15F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 17F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(384, 461);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // equalBtn
            // 
            this.equalBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.equalBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.equalBtn.Location = new System.Drawing.Point(291, 384);
            this.equalBtn.Name = "equalBtn";
            this.equalBtn.Size = new System.Drawing.Size(90, 74);
            this.equalBtn.TabIndex = 20;
            this.equalBtn.Text = "=";
            this.equalBtn.UseVisualStyleBackColor = true;
            this.equalBtn.Click += new System.EventHandler(this.equalBtn_Click);
            // 
            // dotBtn
            // 
            this.dotBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.dotBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dotBtn.Location = new System.Drawing.Point(195, 384);
            this.dotBtn.Name = "dotBtn";
            this.dotBtn.Size = new System.Drawing.Size(90, 74);
            this.dotBtn.TabIndex = 19;
            this.dotBtn.Text = ".";
            this.dotBtn.UseVisualStyleBackColor = true;
            this.dotBtn.Click += new System.EventHandler(this.dotBtn_Click);
            // 
            // number0Btn
            // 
            this.number0Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number0Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number0Btn.Location = new System.Drawing.Point(99, 384);
            this.number0Btn.Name = "number0Btn";
            this.number0Btn.Size = new System.Drawing.Size(90, 74);
            this.number0Btn.TabIndex = 18;
            this.number0Btn.Text = "0";
            this.number0Btn.UseVisualStyleBackColor = true;
            this.number0Btn.Click += new System.EventHandler(this.number0Btn_Click);
            // 
            // signBtn
            // 
            this.signBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.signBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.signBtn.Location = new System.Drawing.Point(3, 384);
            this.signBtn.Name = "signBtn";
            this.signBtn.Size = new System.Drawing.Size(90, 74);
            this.signBtn.TabIndex = 17;
            this.signBtn.Text = "+/-";
            this.signBtn.UseVisualStyleBackColor = true;
            this.signBtn.Click += new System.EventHandler(this.signBtn_Click);
            // 
            // addBtn
            // 
            this.addBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.addBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addBtn.Location = new System.Drawing.Point(291, 306);
            this.addBtn.Name = "addBtn";
            this.addBtn.Size = new System.Drawing.Size(90, 72);
            this.addBtn.TabIndex = 16;
            this.addBtn.Text = "+";
            this.addBtn.UseVisualStyleBackColor = true;
            this.addBtn.Click += new System.EventHandler(this.addBtn_Click);
            // 
            // number3Btn
            // 
            this.number3Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number3Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number3Btn.Location = new System.Drawing.Point(195, 306);
            this.number3Btn.Name = "number3Btn";
            this.number3Btn.Size = new System.Drawing.Size(90, 72);
            this.number3Btn.TabIndex = 15;
            this.number3Btn.Text = "3";
            this.number3Btn.UseVisualStyleBackColor = true;
            this.number3Btn.Click += new System.EventHandler(this.number3Btn_Click);
            // 
            // number2Btn
            // 
            this.number2Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number2Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number2Btn.Location = new System.Drawing.Point(99, 306);
            this.number2Btn.Name = "number2Btn";
            this.number2Btn.Size = new System.Drawing.Size(90, 72);
            this.number2Btn.TabIndex = 14;
            this.number2Btn.Text = "2";
            this.number2Btn.UseVisualStyleBackColor = true;
            this.number2Btn.Click += new System.EventHandler(this.number2Btn_Click);
            // 
            // number1Btn
            // 
            this.number1Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number1Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number1Btn.Location = new System.Drawing.Point(3, 306);
            this.number1Btn.Name = "number1Btn";
            this.number1Btn.Size = new System.Drawing.Size(90, 72);
            this.number1Btn.TabIndex = 13;
            this.number1Btn.Text = "1";
            this.number1Btn.UseVisualStyleBackColor = true;
            this.number1Btn.Click += new System.EventHandler(this.number1Btn_Click);
            // 
            // minusBtn
            // 
            this.minusBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.minusBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.minusBtn.Location = new System.Drawing.Point(291, 228);
            this.minusBtn.Name = "minusBtn";
            this.minusBtn.Size = new System.Drawing.Size(90, 72);
            this.minusBtn.TabIndex = 12;
            this.minusBtn.Text = "-";
            this.minusBtn.UseVisualStyleBackColor = true;
            this.minusBtn.Click += new System.EventHandler(this.minusBtn_Click);
            // 
            // number6Btn
            // 
            this.number6Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number6Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number6Btn.Location = new System.Drawing.Point(195, 228);
            this.number6Btn.Name = "number6Btn";
            this.number6Btn.Size = new System.Drawing.Size(90, 72);
            this.number6Btn.TabIndex = 11;
            this.number6Btn.Text = "6";
            this.number6Btn.UseVisualStyleBackColor = true;
            this.number6Btn.Click += new System.EventHandler(this.number6Btn_Click);
            // 
            // number5Btn
            // 
            this.number5Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number5Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number5Btn.Location = new System.Drawing.Point(99, 228);
            this.number5Btn.Name = "number5Btn";
            this.number5Btn.Size = new System.Drawing.Size(90, 72);
            this.number5Btn.TabIndex = 10;
            this.number5Btn.Text = "5";
            this.number5Btn.UseVisualStyleBackColor = true;
            this.number5Btn.Click += new System.EventHandler(this.number5Btn_Click);
            // 
            // number4Btn
            // 
            this.number4Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number4Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number4Btn.Location = new System.Drawing.Point(3, 228);
            this.number4Btn.Name = "number4Btn";
            this.number4Btn.Size = new System.Drawing.Size(90, 72);
            this.number4Btn.TabIndex = 9;
            this.number4Btn.Text = "4";
            this.number4Btn.UseVisualStyleBackColor = true;
            this.number4Btn.Click += new System.EventHandler(this.number4Btn_Click);
            // 
            // timesBtn
            // 
            this.timesBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.timesBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.timesBtn.Location = new System.Drawing.Point(291, 150);
            this.timesBtn.Name = "timesBtn";
            this.timesBtn.Size = new System.Drawing.Size(90, 72);
            this.timesBtn.TabIndex = 8;
            this.timesBtn.Text = "X";
            this.timesBtn.UseVisualStyleBackColor = true;
            this.timesBtn.Click += new System.EventHandler(this.timesBtn_Click);
            // 
            // number9Btn
            // 
            this.number9Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number9Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number9Btn.Location = new System.Drawing.Point(195, 150);
            this.number9Btn.Name = "number9Btn";
            this.number9Btn.Size = new System.Drawing.Size(90, 72);
            this.number9Btn.TabIndex = 7;
            this.number9Btn.Text = "9";
            this.number9Btn.UseVisualStyleBackColor = true;
            this.number9Btn.Click += new System.EventHandler(this.number9Btn_Click);
            // 
            // number8Btn
            // 
            this.number8Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number8Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number8Btn.Location = new System.Drawing.Point(99, 150);
            this.number8Btn.Name = "number8Btn";
            this.number8Btn.Size = new System.Drawing.Size(90, 72);
            this.number8Btn.TabIndex = 6;
            this.number8Btn.Text = "8";
            this.number8Btn.UseVisualStyleBackColor = true;
            this.number8Btn.Click += new System.EventHandler(this.number8Btn_Click);
            // 
            // number7Btn
            // 
            this.number7Btn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.number7Btn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.number7Btn.Location = new System.Drawing.Point(3, 150);
            this.number7Btn.Name = "number7Btn";
            this.number7Btn.Size = new System.Drawing.Size(90, 72);
            this.number7Btn.TabIndex = 5;
            this.number7Btn.Text = "7";
            this.number7Btn.UseVisualStyleBackColor = true;
            this.number7Btn.Click += new System.EventHandler(this.number7Btn_Click);
            // 
            // divideBtn
            // 
            this.divideBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.divideBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.divideBtn.Location = new System.Drawing.Point(291, 72);
            this.divideBtn.Name = "divideBtn";
            this.divideBtn.Size = new System.Drawing.Size(90, 72);
            this.divideBtn.TabIndex = 4;
            this.divideBtn.Text = "/";
            this.divideBtn.UseVisualStyleBackColor = true;
            this.divideBtn.Click += new System.EventHandler(this.divideBtn_Click);
            // 
            // deleteBtn
            // 
            this.deleteBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.deleteBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteBtn.Location = new System.Drawing.Point(195, 72);
            this.deleteBtn.Name = "deleteBtn";
            this.deleteBtn.Size = new System.Drawing.Size(90, 72);
            this.deleteBtn.TabIndex = 3;
            this.deleteBtn.Text = "<<";
            this.deleteBtn.UseVisualStyleBackColor = true;
            this.deleteBtn.Click += new System.EventHandler(this.deleteBtn_Click);
            // 
            // clearBtn
            // 
            this.clearBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearBtn.Location = new System.Drawing.Point(99, 72);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(90, 72);
            this.clearBtn.TabIndex = 2;
            this.clearBtn.Text = "C";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.clearBtn_Click);
            // 
            // displayWindow
            // 
            this.tableLayoutPanel1.SetColumnSpan(this.displayWindow, 4);
            this.displayWindow.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.displayWindow.Location = new System.Drawing.Point(3, 3);
            this.displayWindow.Name = "displayWindow";
            this.displayWindow.Size = new System.Drawing.Size(378, 44);
            this.displayWindow.TabIndex = 0;
            // 
            // clearEntryBtn
            // 
            this.clearEntryBtn.Dock = System.Windows.Forms.DockStyle.Fill;
            this.clearEntryBtn.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.clearEntryBtn.Location = new System.Drawing.Point(3, 72);
            this.clearEntryBtn.Name = "clearEntryBtn";
            this.clearEntryBtn.Size = new System.Drawing.Size(90, 72);
            this.clearEntryBtn.TabIndex = 1;
            this.clearEntryBtn.Text = "CE";
            this.clearEntryBtn.UseVisualStyleBackColor = true;
            this.clearEntryBtn.Click += new System.EventHandler(this.clearEntryBtn_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(384, 461);
            this.Controls.Add(this.tableLayoutPanel1);
            this.MaximumSize = new System.Drawing.Size(1200, 1000);
            this.MinimumSize = new System.Drawing.Size(324, 100);
            this.Name = "Form1";
            this.Text = "Tinfo-200-Calculator-ericrod";
            this.tableLayoutPanel1.ResumeLayout(false);
            this.tableLayoutPanel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private System.Windows.Forms.TextBox displayWindow;
        private System.Windows.Forms.Button clearEntryBtn;
        private System.Windows.Forms.Button equalBtn;
        private System.Windows.Forms.Button dotBtn;
        private System.Windows.Forms.Button number0Btn;
        private System.Windows.Forms.Button signBtn;
        private System.Windows.Forms.Button addBtn;
        private System.Windows.Forms.Button number3Btn;
        private System.Windows.Forms.Button number2Btn;
        private System.Windows.Forms.Button number1Btn;
        private System.Windows.Forms.Button minusBtn;
        private System.Windows.Forms.Button number6Btn;
        private System.Windows.Forms.Button number5Btn;
        private System.Windows.Forms.Button number4Btn;
        private System.Windows.Forms.Button timesBtn;
        private System.Windows.Forms.Button number9Btn;
        private System.Windows.Forms.Button number8Btn;
        private System.Windows.Forms.Button number7Btn;
        private System.Windows.Forms.Button divideBtn;
        private System.Windows.Forms.Button deleteBtn;
        private System.Windows.Forms.Button clearBtn;
    }
}

