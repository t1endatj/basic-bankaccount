namespace MiniBankAccount
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            label2 = new Label();
            OwnerTxt = new TextBox();
            AmountNum = new NumericUpDown();
            BankAccountGrid = new DataGridView();
            DepositeBtn = new Button();
            WithdrawBtn = new Button();
            button3 = new Button();
            ((System.ComponentModel.ISupportInitialize)AmountNum).BeginInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).BeginInit();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label1.Location = new Point(58, 28);
            label1.Name = "label1";
            label1.Size = new Size(79, 30);
            label1.TabIndex = 0;
            label1.Text = "Owner:";
            label1.Click += CreateAccountBtn_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Segoe UI", 15.75F, FontStyle.Regular, GraphicsUnit.Point, 163);
            label2.Location = new Point(58, 228);
            label2.Name = "label2";
            label2.Size = new Size(81, 30);
            label2.TabIndex = 1;
            label2.Text = "Amont:";
            // 
            // OwnerTxt
            // 
            OwnerTxt.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            OwnerTxt.Location = new Point(132, 28);
            OwnerTxt.Name = "OwnerTxt";
            OwnerTxt.Size = new Size(163, 29);
            OwnerTxt.TabIndex = 2;
            OwnerTxt.TextChanged += textBox1_TextChanged;
            // 
            // AmountNum
            // 
            AmountNum.Font = new Font("Segoe UI", 12F, FontStyle.Regular, GraphicsUnit.Point, 163);
            AmountNum.Location = new Point(132, 228);
            AmountNum.Name = "AmountNum";
            AmountNum.Size = new Size(163, 29);
            AmountNum.TabIndex = 3;
            // 
            // BankAccountGrid
            // 
            BankAccountGrid.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            BankAccountGrid.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            BankAccountGrid.Location = new Point(377, 28);
            BankAccountGrid.Name = "BankAccountGrid";
            BankAccountGrid.Size = new Size(411, 199);
            BankAccountGrid.TabIndex = 4;
            // 
            // DepositeBtn
            // 
            DepositeBtn.Location = new Point(377, 228);
            DepositeBtn.Name = "DepositeBtn";
            DepositeBtn.Size = new Size(126, 57);
            DepositeBtn.TabIndex = 5;
            DepositeBtn.Text = "Deposite";
            DepositeBtn.UseVisualStyleBackColor = true;
            DepositeBtn.Click += DepositeBtn_Click;
            // 
            // WithdrawBtn
            // 
            WithdrawBtn.Location = new Point(662, 228);
            WithdrawBtn.Name = "WithdrawBtn";
            WithdrawBtn.Size = new Size(126, 57);
            WithdrawBtn.TabIndex = 6;
            WithdrawBtn.Text = "Withdraw";
            WithdrawBtn.UseVisualStyleBackColor = true;
            WithdrawBtn.Click += WithdrawBtn_Click;
            // 
            // button3
            // 
            button3.Location = new Point(132, 63);
            button3.Name = "button3";
            button3.Size = new Size(163, 46);
            button3.TabIndex = 7;
            button3.Text = "Create Account";
            button3.UseVisualStyleBackColor = true;
            button3.Click += CreateAccountBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 302);
            Controls.Add(button3);
            Controls.Add(WithdrawBtn);
            Controls.Add(DepositeBtn);
            Controls.Add(BankAccountGrid);
            Controls.Add(AmountNum);
            Controls.Add(OwnerTxt);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)AmountNum).EndInit();
            ((System.ComponentModel.ISupportInitialize)BankAccountGrid).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private TextBox OwnerTxt;
        private NumericUpDown AmountNum;
        private DataGridView BankAccountGrid;
        private Button DepositeBtn;
        private Button WithdrawBtn;
        private Button button3;
    }
}
