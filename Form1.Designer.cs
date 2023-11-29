namespace CS_ATM
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.btnWithdrawal = new System.Windows.Forms.Button();
            this.btnBalance = new System.Windows.Forms.Button();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.lblPin = new System.Windows.Forms.Label();
            this.lblLoan = new System.Windows.Forms.Label();
            this.lblDeposit = new System.Windows.Forms.Label();
            this.lblWithdrawal = new System.Windows.Forms.Label();
            this.lblBalance = new System.Windows.Forms.Label();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.btnDeposit = new System.Windows.Forms.Button();
            this.btnLoan = new System.Windows.Forms.Button();
            this.btnEnter = new System.Windows.Forms.Button();
            this.btn9 = new System.Windows.Forms.Button();
            this.btn8 = new System.Windows.Forms.Button();
            this.btn7 = new System.Windows.Forms.Button();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.btn3 = new System.Windows.Forms.Button();
            this.btnCancel = new System.Windows.Forms.Button();
            this.btn4 = new System.Windows.Forms.Button();
            this.btn5 = new System.Windows.Forms.Button();
            this.btn6 = new System.Windows.Forms.Button();
            this.btnClear = new System.Windows.Forms.Button();
            this.groupBox4 = new System.Windows.Forms.GroupBox();
            this.button16 = new System.Windows.Forms.Button();
            this.button15 = new System.Windows.Forms.Button();
            this.btn0 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnExit = new System.Windows.Forms.Button();
            this.btnReset = new System.Windows.Forms.Button();
            this.btnReceipt = new System.Windows.Forms.Button();
            this.btnLoanSystem = new System.Windows.Forms.Button();
            this.rtfReceipt = new System.Windows.Forms.RichTextBox();
            this.lblTotalPayment = new System.Windows.Forms.TextBox();
            this.lblMonthlyPayment = new System.Windows.Forms.TextBox();
            this.txtInterestRate = new System.Windows.Forms.TextBox();
            this.txtNumberOfYears = new System.Windows.Forms.TextBox();
            this.txtAmountOfLoan = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.groupBox4.SuspendLayout();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.btnWithdrawal);
            this.groupBox1.Controls.Add(this.btnBalance);
            this.groupBox1.Location = new System.Drawing.Point(47, 149);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(110, 189);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            // 
            // btnWithdrawal
            // 
            this.btnWithdrawal.Image = ((System.Drawing.Image)(resources.GetObject("btnWithdrawal.Image")));
            this.btnWithdrawal.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWithdrawal.Location = new System.Drawing.Point(6, 106);
            this.btnWithdrawal.Name = "btnWithdrawal";
            this.btnWithdrawal.Size = new System.Drawing.Size(104, 57);
            this.btnWithdrawal.TabIndex = 1;
            this.btnWithdrawal.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnWithdrawal.UseVisualStyleBackColor = true;
            // 
            // btnBalance
            // 
            this.btnBalance.Image = ((System.Drawing.Image)(resources.GetObject("btnBalance.Image")));
            this.btnBalance.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBalance.Location = new System.Drawing.Point(6, 28);
            this.btnBalance.Name = "btnBalance";
            this.btnBalance.Size = new System.Drawing.Size(104, 56);
            this.btnBalance.TabIndex = 0;
            this.btnBalance.TextAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnBalance.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(255)))), ((int)(((byte)(192)))));
            this.groupBox2.Controls.Add(this.lblPin);
            this.groupBox2.Controls.Add(this.lblLoan);
            this.groupBox2.Controls.Add(this.lblDeposit);
            this.groupBox2.Controls.Add(this.lblWithdrawal);
            this.groupBox2.Controls.Add(this.lblBalance);
            this.groupBox2.Location = new System.Drawing.Point(163, 149);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(206, 189);
            this.groupBox2.TabIndex = 1;
            this.groupBox2.TabStop = false;
            // 
            // lblPin
            // 
            this.lblPin.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.lblPin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblPin.Location = new System.Drawing.Point(13, 80);
            this.lblPin.Name = "lblPin";
            this.lblPin.Size = new System.Drawing.Size(187, 46);
            this.lblPin.TabIndex = 0;
            this.lblPin.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.lblPin.Click += new System.EventHandler(this.lblPin_Click);
            // 
            // lblLoan
            // 
            this.lblLoan.AutoSize = true;
            this.lblLoan.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblLoan.Location = new System.Drawing.Point(140, 39);
            this.lblLoan.Name = "lblLoan";
            this.lblLoan.Size = new System.Drawing.Size(60, 25);
            this.lblLoan.TabIndex = 0;
            this.lblLoan.Text = "Loan";
            // 
            // lblDeposit
            // 
            this.lblDeposit.AutoSize = true;
            this.lblDeposit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblDeposit.Location = new System.Drawing.Point(121, 126);
            this.lblDeposit.Name = "lblDeposit";
            this.lblDeposit.Size = new System.Drawing.Size(85, 25);
            this.lblDeposit.TabIndex = 0;
            this.lblDeposit.Text = "Deposit";
            // 
            // lblWithdrawal
            // 
            this.lblWithdrawal.AutoSize = true;
            this.lblWithdrawal.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblWithdrawal.Location = new System.Drawing.Point(-5, 126);
            this.lblWithdrawal.Name = "lblWithdrawal";
            this.lblWithdrawal.Size = new System.Drawing.Size(119, 25);
            this.lblWithdrawal.TabIndex = 0;
            this.lblWithdrawal.Text = "Withdrawal";
            // 
            // lblBalance
            // 
            this.lblBalance.AutoSize = true;
            this.lblBalance.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.lblBalance.Location = new System.Drawing.Point(6, 41);
            this.lblBalance.Name = "lblBalance";
            this.lblBalance.Size = new System.Drawing.Size(90, 25);
            this.lblBalance.TabIndex = 0;
            this.lblBalance.Text = "Balance";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.btnDeposit);
            this.groupBox3.Controls.Add(this.btnLoan);
            this.groupBox3.Location = new System.Drawing.Point(375, 149);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(134, 189);
            this.groupBox3.TabIndex = 1;
            this.groupBox3.TabStop = false;
            this.groupBox3.Enter += new System.EventHandler(this.groupBox3_Enter);
            // 
            // btnDeposit
            // 
            this.btnDeposit.Image = ((System.Drawing.Image)(resources.GetObject("btnDeposit.Image")));
            this.btnDeposit.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnDeposit.Location = new System.Drawing.Point(6, 106);
            this.btnDeposit.Name = "btnDeposit";
            this.btnDeposit.Size = new System.Drawing.Size(102, 57);
            this.btnDeposit.TabIndex = 2;
            this.btnDeposit.UseVisualStyleBackColor = true;
            // 
            // btnLoan
            // 
            this.btnLoan.Image = ((System.Drawing.Image)(resources.GetObject("btnLoan.Image")));
            this.btnLoan.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnLoan.Location = new System.Drawing.Point(6, 28);
            this.btnLoan.Name = "btnLoan";
            this.btnLoan.Size = new System.Drawing.Size(102, 56);
            this.btnLoan.TabIndex = 1;
            this.btnLoan.UseVisualStyleBackColor = true;
            this.btnLoan.Click += new System.EventHandler(this.btnLoan_Click);
            // 
            // btnEnter
            // 
            this.btnEnter.Image = ((System.Drawing.Image)(resources.GetObject("btnEnter.Image")));
            this.btnEnter.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnEnter.Location = new System.Drawing.Point(328, 145);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(102, 57);
            this.btnEnter.TabIndex = 16;
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // btn9
            // 
            this.btn9.Image = ((System.Drawing.Image)(resources.GetObject("btn9.Image")));
            this.btn9.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn9.Location = new System.Drawing.Point(223, 145);
            this.btn9.Name = "btn9";
            this.btn9.Size = new System.Drawing.Size(99, 57);
            this.btn9.TabIndex = 15;
            this.btn9.UseVisualStyleBackColor = true;
            this.btn9.Click += new System.EventHandler(this.btn9_Click);
            // 
            // btn8
            // 
            this.btn8.Image = ((System.Drawing.Image)(resources.GetObject("btn8.Image")));
            this.btn8.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn8.Location = new System.Drawing.Point(116, 145);
            this.btn8.Name = "btn8";
            this.btn8.Size = new System.Drawing.Size(101, 57);
            this.btn8.TabIndex = 14;
            this.btn8.UseVisualStyleBackColor = true;
            this.btn8.Click += new System.EventHandler(this.btn8_Click);
            // 
            // btn7
            // 
            this.btn7.Image = ((System.Drawing.Image)(resources.GetObject("btn7.Image")));
            this.btn7.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn7.Location = new System.Drawing.Point(6, 145);
            this.btn7.Name = "btn7";
            this.btn7.Size = new System.Drawing.Size(104, 57);
            this.btn7.TabIndex = 13;
            this.btn7.UseVisualStyleBackColor = true;
            this.btn7.Click += new System.EventHandler(this.btn7_Click);
            // 
            // btn1
            // 
            this.btn1.Image = ((System.Drawing.Image)(resources.GetObject("btn1.Image")));
            this.btn1.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn1.Location = new System.Drawing.Point(6, 21);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(104, 55);
            this.btn1.TabIndex = 1;
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Image = ((System.Drawing.Image)(resources.GetObject("btn2.Image")));
            this.btn2.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn2.Location = new System.Drawing.Point(116, 21);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(101, 55);
            this.btn2.TabIndex = 2;
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // btn3
            // 
            this.btn3.Image = ((System.Drawing.Image)(resources.GetObject("btn3.Image")));
            this.btn3.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn3.Location = new System.Drawing.Point(223, 21);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(99, 55);
            this.btn3.TabIndex = 3;
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // btnCancel
            // 
            this.btnCancel.Image = ((System.Drawing.Image)(resources.GetObject("btnCancel.Image")));
            this.btnCancel.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnCancel.Location = new System.Drawing.Point(328, 21);
            this.btnCancel.Name = "btnCancel";
            this.btnCancel.Size = new System.Drawing.Size(102, 55);
            this.btnCancel.TabIndex = 4;
            this.btnCancel.UseVisualStyleBackColor = true;
            this.btnCancel.Click += new System.EventHandler(this.btnCancel_Click);
            // 
            // btn4
            // 
            this.btn4.Image = ((System.Drawing.Image)(resources.GetObject("btn4.Image")));
            this.btn4.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn4.Location = new System.Drawing.Point(6, 82);
            this.btn4.Name = "btn4";
            this.btn4.Size = new System.Drawing.Size(104, 57);
            this.btn4.TabIndex = 5;
            this.btn4.UseVisualStyleBackColor = true;
            this.btn4.Click += new System.EventHandler(this.btn4_Click);
            // 
            // btn5
            // 
            this.btn5.Image = ((System.Drawing.Image)(resources.GetObject("btn5.Image")));
            this.btn5.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn5.Location = new System.Drawing.Point(116, 82);
            this.btn5.Name = "btn5";
            this.btn5.Size = new System.Drawing.Size(101, 57);
            this.btn5.TabIndex = 6;
            this.btn5.UseVisualStyleBackColor = true;
            this.btn5.Click += new System.EventHandler(this.btn5_Click);
            // 
            // btn6
            // 
            this.btn6.Image = ((System.Drawing.Image)(resources.GetObject("btn6.Image")));
            this.btn6.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn6.Location = new System.Drawing.Point(223, 82);
            this.btn6.Name = "btn6";
            this.btn6.Size = new System.Drawing.Size(99, 57);
            this.btn6.TabIndex = 7;
            this.btn6.UseVisualStyleBackColor = true;
            this.btn6.Click += new System.EventHandler(this.btn6_Click);
            // 
            // btnClear
            // 
            this.btnClear.Image = ((System.Drawing.Image)(resources.GetObject("btnClear.Image")));
            this.btnClear.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btnClear.Location = new System.Drawing.Point(328, 82);
            this.btnClear.Name = "btnClear";
            this.btnClear.Size = new System.Drawing.Size(102, 57);
            this.btnClear.TabIndex = 8;
            this.btnClear.UseVisualStyleBackColor = true;
            this.btnClear.Click += new System.EventHandler(this.btnClear_Click);
            // 
            // groupBox4
            // 
            this.groupBox4.Controls.Add(this.button16);
            this.groupBox4.Controls.Add(this.button15);
            this.groupBox4.Controls.Add(this.btn0);
            this.groupBox4.Controls.Add(this.button13);
            this.groupBox4.Controls.Add(this.btnEnter);
            this.groupBox4.Controls.Add(this.btnClear);
            this.groupBox4.Controls.Add(this.btn6);
            this.groupBox4.Controls.Add(this.btn9);
            this.groupBox4.Controls.Add(this.btn5);
            this.groupBox4.Controls.Add(this.btn4);
            this.groupBox4.Controls.Add(this.btn8);
            this.groupBox4.Controls.Add(this.btn7);
            this.groupBox4.Controls.Add(this.btnCancel);
            this.groupBox4.Controls.Add(this.btn3);
            this.groupBox4.Controls.Add(this.btn2);
            this.groupBox4.Controls.Add(this.btn1);
            this.groupBox4.Location = new System.Drawing.Point(47, 344);
            this.groupBox4.Name = "groupBox4";
            this.groupBox4.Size = new System.Drawing.Size(462, 300);
            this.groupBox4.TabIndex = 1;
            this.groupBox4.TabStop = false;
            // 
            // button16
            // 
            this.button16.Image = ((System.Drawing.Image)(resources.GetObject("button16.Image")));
            this.button16.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button16.Location = new System.Drawing.Point(328, 208);
            this.button16.Name = "button16";
            this.button16.Size = new System.Drawing.Size(102, 58);
            this.button16.TabIndex = 20;
            this.button16.UseVisualStyleBackColor = true;
            // 
            // button15
            // 
            this.button15.Image = ((System.Drawing.Image)(resources.GetObject("button15.Image")));
            this.button15.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button15.Location = new System.Drawing.Point(223, 208);
            this.button15.Name = "button15";
            this.button15.Size = new System.Drawing.Size(99, 58);
            this.button15.TabIndex = 19;
            this.button15.UseVisualStyleBackColor = true;
            // 
            // btn0
            // 
            this.btn0.Image = ((System.Drawing.Image)(resources.GetObject("btn0.Image")));
            this.btn0.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.btn0.Location = new System.Drawing.Point(116, 208);
            this.btn0.Name = "btn0";
            this.btn0.Size = new System.Drawing.Size(101, 58);
            this.btn0.TabIndex = 18;
            this.btn0.UseVisualStyleBackColor = true;
            this.btn0.Click += new System.EventHandler(this.btn0_Click);
            // 
            // button13
            // 
            this.button13.Image = ((System.Drawing.Image)(resources.GetObject("button13.Image")));
            this.button13.ImageAlign = System.Drawing.ContentAlignment.TopLeft;
            this.button13.Location = new System.Drawing.Point(6, 208);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(104, 58);
            this.button13.TabIndex = 17;
            this.button13.UseVisualStyleBackColor = true;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.btnExit);
            this.panel1.Controls.Add(this.btnReset);
            this.panel1.Controls.Add(this.btnReceipt);
            this.panel1.Controls.Add(this.btnLoanSystem);
            this.panel1.Controls.Add(this.rtfReceipt);
            this.panel1.Controls.Add(this.lblTotalPayment);
            this.panel1.Controls.Add(this.lblMonthlyPayment);
            this.panel1.Controls.Add(this.txtInterestRate);
            this.panel1.Controls.Add(this.txtNumberOfYears);
            this.panel1.Controls.Add(this.txtAmountOfLoan);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(528, 149);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(656, 495);
            this.panel1.TabIndex = 2;
            // 
            // btnExit
            // 
            this.btnExit.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnExit.Location = new System.Drawing.Point(533, 412);
            this.btnExit.Name = "btnExit";
            this.btnExit.Size = new System.Drawing.Size(107, 67);
            this.btnExit.TabIndex = 3;
            this.btnExit.Text = "Exit";
            this.btnExit.UseVisualStyleBackColor = true;
            this.btnExit.Click += new System.EventHandler(this.btnExit_Click);
            // 
            // btnReset
            // 
            this.btnReset.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReset.Location = new System.Drawing.Point(342, 412);
            this.btnReset.Name = "btnReset";
            this.btnReset.Size = new System.Drawing.Size(107, 67);
            this.btnReset.TabIndex = 3;
            this.btnReset.Text = "Reset";
            this.btnReset.UseVisualStyleBackColor = true;
            this.btnReset.Click += new System.EventHandler(this.btnReset_Click);
            // 
            // btnReceipt
            // 
            this.btnReceipt.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnReceipt.Location = new System.Drawing.Point(208, 412);
            this.btnReceipt.Name = "btnReceipt";
            this.btnReceipt.Size = new System.Drawing.Size(107, 67);
            this.btnReceipt.TabIndex = 3;
            this.btnReceipt.Text = "Receipt";
            this.btnReceipt.UseVisualStyleBackColor = true;
            this.btnReceipt.Click += new System.EventHandler(this.btnReceipt_Click);
            // 
            // btnLoanSystem
            // 
            this.btnLoanSystem.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.btnLoanSystem.Location = new System.Drawing.Point(13, 414);
            this.btnLoanSystem.Name = "btnLoanSystem";
            this.btnLoanSystem.Size = new System.Drawing.Size(107, 67);
            this.btnLoanSystem.TabIndex = 3;
            this.btnLoanSystem.Text = "Loan";
            this.btnLoanSystem.UseVisualStyleBackColor = true;
            this.btnLoanSystem.Click += new System.EventHandler(this.btnLoanSystem_Click);
            // 
            // rtfReceipt
            // 
            this.rtfReceipt.Location = new System.Drawing.Point(341, 24);
            this.rtfReceipt.Name = "rtfReceipt";
            this.rtfReceipt.Size = new System.Drawing.Size(299, 364);
            this.rtfReceipt.TabIndex = 2;
            this.rtfReceipt.Text = "";
            // 
            // lblTotalPayment
            // 
            this.lblTotalPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.lblTotalPayment.Location = new System.Drawing.Point(222, 354);
            this.lblTotalPayment.Multiline = true;
            this.lblTotalPayment.Name = "lblTotalPayment";
            this.lblTotalPayment.Size = new System.Drawing.Size(100, 34);
            this.lblTotalPayment.TabIndex = 1;
            // 
            // lblMonthlyPayment
            // 
            this.lblMonthlyPayment.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.lblMonthlyPayment.Location = new System.Drawing.Point(222, 277);
            this.lblMonthlyPayment.Multiline = true;
            this.lblMonthlyPayment.Name = "lblMonthlyPayment";
            this.lblMonthlyPayment.Size = new System.Drawing.Size(100, 34);
            this.lblMonthlyPayment.TabIndex = 1;
            // 
            // txtInterestRate
            // 
            this.txtInterestRate.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.txtInterestRate.Location = new System.Drawing.Point(222, 188);
            this.txtInterestRate.Multiline = true;
            this.txtInterestRate.Name = "txtInterestRate";
            this.txtInterestRate.Size = new System.Drawing.Size(100, 34);
            this.txtInterestRate.TabIndex = 1;
            // 
            // txtNumberOfYears
            // 
            this.txtNumberOfYears.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.txtNumberOfYears.Location = new System.Drawing.Point(222, 106);
            this.txtNumberOfYears.Multiline = true;
            this.txtNumberOfYears.Name = "txtNumberOfYears";
            this.txtNumberOfYears.Size = new System.Drawing.Size(100, 34);
            this.txtNumberOfYears.TabIndex = 1;
            // 
            // txtAmountOfLoan
            // 
            this.txtAmountOfLoan.AccessibleRole = System.Windows.Forms.AccessibleRole.ButtonDropDownGrid;
            this.txtAmountOfLoan.Location = new System.Drawing.Point(222, 28);
            this.txtAmountOfLoan.Multiline = true;
            this.txtAmountOfLoan.Name = "txtAmountOfLoan";
            this.txtAmountOfLoan.Size = new System.Drawing.Size(100, 34);
            this.txtAmountOfLoan.TabIndex = 1;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label5.Location = new System.Drawing.Point(3, 350);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(151, 25);
            this.label5.TabIndex = 0;
            this.label5.Text = "Total Payment";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label4.Location = new System.Drawing.Point(3, 274);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(178, 25);
            this.label4.TabIndex = 0;
            this.label4.Text = "Monthly Payment";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label3.Location = new System.Drawing.Point(3, 188);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 25);
            this.label3.TabIndex = 0;
            this.label3.Text = "Enter interest Rate";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label2.Location = new System.Drawing.Point(2, 106);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(216, 25);
            this.label2.TabIndex = 0;
            this.label2.Text = "Enter number of Year";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(3, 30);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(218, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "Enter amount of Loan";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label6.Location = new System.Drawing.Point(373, 9);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(495, 46);
            this.label6.TabIndex = 3;
            this.label6.Text = "Zhumaev Baizak COM 21";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label7.Location = new System.Drawing.Point(393, 87);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(431, 22);
            this.label7.TabIndex = 4;
            this.label7.Text = "ATM System with a Loan Management Systems";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1247, 715);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox4);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox4.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Button btnWithdrawal;
        private System.Windows.Forms.Button btnBalance;
        private System.Windows.Forms.Button btnDeposit;
        private System.Windows.Forms.Button btnLoan;
        private System.Windows.Forms.Button btnEnter;
        private System.Windows.Forms.Button btn9;
        private System.Windows.Forms.Button btn8;
        private System.Windows.Forms.Button btn7;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.Button btnCancel;
        private System.Windows.Forms.Button btn4;
        private System.Windows.Forms.Button btn5;
        private System.Windows.Forms.Button btn6;
        private System.Windows.Forms.Button btnClear;
        private System.Windows.Forms.GroupBox groupBox4;
        private System.Windows.Forms.Button button16;
        private System.Windows.Forms.Button button15;
        private System.Windows.Forms.Button btn0;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Label lblLoan;
        private System.Windows.Forms.Label lblDeposit;
        private System.Windows.Forms.Label lblWithdrawal;
        private System.Windows.Forms.Label lblBalance;
        private System.Windows.Forms.Label lblPin;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtAmountOfLoan;
        private System.Windows.Forms.RichTextBox rtfReceipt;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox lblTotalPayment;
        private System.Windows.Forms.TextBox lblMonthlyPayment;
        private System.Windows.Forms.TextBox txtNumberOfYears;
        private System.Windows.Forms.Button btnExit;
        private System.Windows.Forms.Button btnReset;
        private System.Windows.Forms.Button btnReceipt;
        private System.Windows.Forms.Button btnLoanSystem;
        private System.Windows.Forms.TextBox txtInterestRate;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
    }
}

