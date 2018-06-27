namespace MathTest
{
    partial class MathQuiz
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MathQuiz));
            this.lbl_title = new System.Windows.Forms.Label();
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.grpBox_score = new System.Windows.Forms.GroupBox();
            this.txtBox_name = new System.Windows.Forms.TextBox();
            this.lbl_score = new System.Windows.Forms.Label();
            this.lbl_nameTitle = new System.Windows.Forms.Label();
            this.lbl_scoreTitle = new System.Windows.Forms.Label();
            this.btn_submitScore = new System.Windows.Forms.Button();
            this.dom_div = new System.Windows.Forms.NumericUpDown();
            this.dom_mult = new System.Windows.Forms.NumericUpDown();
            this.dom_subs = new System.Windows.Forms.NumericUpDown();
            this.dom_sum = new System.Windows.Forms.NumericUpDown();
            this.btn_startButton = new System.Windows.Forms.Button();
            this.lbl_equal4 = new System.Windows.Forms.Label();
            this.lbl_divNum2 = new System.Windows.Forms.Label();
            this.lbl_div = new System.Windows.Forms.Label();
            this.lbl_divNum1 = new System.Windows.Forms.Label();
            this.lbl_equal3 = new System.Windows.Forms.Label();
            this.lbl_multNum2 = new System.Windows.Forms.Label();
            this.lbl_mult = new System.Windows.Forms.Label();
            this.lbl_multNum1 = new System.Windows.Forms.Label();
            this.lbl_equal2 = new System.Windows.Forms.Label();
            this.lbl_subsNum2 = new System.Windows.Forms.Label();
            this.lbl_subs = new System.Windows.Forms.Label();
            this.lbl_subsNum1 = new System.Windows.Forms.Label();
            this.lbl_equal1 = new System.Windows.Forms.Label();
            this.lbl_timeRemaining = new System.Windows.Forms.Label();
            this.lbl_timeTitle = new System.Windows.Forms.Label();
            this.lbl_addNum2 = new System.Windows.Forms.Label();
            this.lbl_sum = new System.Windows.Forms.Label();
            this.lbl_addNum1 = new System.Windows.Forms.Label();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.playeridDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerNameDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.playerScoreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.tblPlayerBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.scoresDBDataSet = new MathTest.ScoresDBDataSet();
            this.tmr_quizTime = new System.Windows.Forms.Timer(this.components);
            this.tbl_PlayerTableAdapter = new MathTest.ScoresDBDataSetTableAdapters.Tbl_PlayerTableAdapter();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.grpBox_score.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dom_div)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_mult)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_subs)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_sum)).BeginInit();
            this.tabPage2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayerBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDBDataSet)).BeginInit();
            this.SuspendLayout();
            // 
            // lbl_title
            // 
            this.lbl_title.AutoSize = true;
            this.lbl_title.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.lbl_title.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_title.Location = new System.Drawing.Point(209, 9);
            this.lbl_title.Name = "lbl_title";
            this.lbl_title.Size = new System.Drawing.Size(129, 25);
            this.lbl_title.TabIndex = 0;
            this.lbl_title.Text = "Math Quiz :)";
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(12, 51);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(547, 275);
            this.tabControl1.TabIndex = 13;
            this.tabControl1.SelectedIndexChanged += new System.EventHandler(this.OnTabIndexChanged);
            this.tabControl1.TabIndexChanged += new System.EventHandler(this.OnTabIndexChanged);
            // 
            // tabPage1
            // 
            this.tabPage1.Controls.Add(this.grpBox_score);
            this.tabPage1.Controls.Add(this.dom_div);
            this.tabPage1.Controls.Add(this.dom_mult);
            this.tabPage1.Controls.Add(this.dom_subs);
            this.tabPage1.Controls.Add(this.dom_sum);
            this.tabPage1.Controls.Add(this.btn_startButton);
            this.tabPage1.Controls.Add(this.lbl_equal4);
            this.tabPage1.Controls.Add(this.lbl_divNum2);
            this.tabPage1.Controls.Add(this.lbl_div);
            this.tabPage1.Controls.Add(this.lbl_divNum1);
            this.tabPage1.Controls.Add(this.lbl_equal3);
            this.tabPage1.Controls.Add(this.lbl_multNum2);
            this.tabPage1.Controls.Add(this.lbl_mult);
            this.tabPage1.Controls.Add(this.lbl_multNum1);
            this.tabPage1.Controls.Add(this.lbl_equal2);
            this.tabPage1.Controls.Add(this.lbl_subsNum2);
            this.tabPage1.Controls.Add(this.lbl_subs);
            this.tabPage1.Controls.Add(this.lbl_subsNum1);
            this.tabPage1.Controls.Add(this.lbl_equal1);
            this.tabPage1.Controls.Add(this.lbl_timeRemaining);
            this.tabPage1.Controls.Add(this.lbl_timeTitle);
            this.tabPage1.Controls.Add(this.lbl_addNum2);
            this.tabPage1.Controls.Add(this.lbl_sum);
            this.tabPage1.Controls.Add(this.lbl_addNum1);
            this.tabPage1.Location = new System.Drawing.Point(4, 22);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(539, 249);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Quiz";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // grpBox_score
            // 
            this.grpBox_score.Controls.Add(this.txtBox_name);
            this.grpBox_score.Controls.Add(this.lbl_score);
            this.grpBox_score.Controls.Add(this.lbl_nameTitle);
            this.grpBox_score.Controls.Add(this.lbl_scoreTitle);
            this.grpBox_score.Controls.Add(this.btn_submitScore);
            this.grpBox_score.Location = new System.Drawing.Point(6, 15);
            this.grpBox_score.Name = "grpBox_score";
            this.grpBox_score.Size = new System.Drawing.Size(152, 228);
            this.grpBox_score.TabIndex = 47;
            this.grpBox_score.TabStop = false;
            this.grpBox_score.Text = "Score";
            // 
            // txtBox_name
            // 
            this.txtBox_name.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBox_name.Location = new System.Drawing.Point(14, 138);
            this.txtBox_name.Name = "txtBox_name";
            this.txtBox_name.Size = new System.Drawing.Size(118, 27);
            this.txtBox_name.TabIndex = 4;
            // 
            // lbl_score
            // 
            this.lbl_score.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_score.Location = new System.Drawing.Point(23, 59);
            this.lbl_score.Name = "lbl_score";
            this.lbl_score.Size = new System.Drawing.Size(90, 20);
            this.lbl_score.TabIndex = 3;
            this.lbl_score.Text = "0";
            this.lbl_score.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_nameTitle
            // 
            this.lbl_nameTitle.AutoSize = true;
            this.lbl_nameTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_nameTitle.Location = new System.Drawing.Point(10, 99);
            this.lbl_nameTitle.Name = "lbl_nameTitle";
            this.lbl_nameTitle.Size = new System.Drawing.Size(130, 20);
            this.lbl_nameTitle.TabIndex = 2;
            this.lbl_nameTitle.Text = "Enter your name:";
            // 
            // lbl_scoreTitle
            // 
            this.lbl_scoreTitle.AutoSize = true;
            this.lbl_scoreTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_scoreTitle.Location = new System.Drawing.Point(23, 30);
            this.lbl_scoreTitle.Name = "lbl_scoreTitle";
            this.lbl_scoreTitle.Size = new System.Drawing.Size(90, 20);
            this.lbl_scoreTitle.TabIndex = 1;
            this.lbl_scoreTitle.Text = "Your score:";
            // 
            // btn_submitScore
            // 
            this.btn_submitScore.AutoSize = true;
            this.btn_submitScore.Enabled = false;
            this.btn_submitScore.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_submitScore.Location = new System.Drawing.Point(14, 194);
            this.btn_submitScore.Name = "btn_submitScore";
            this.btn_submitScore.Size = new System.Drawing.Size(118, 30);
            this.btn_submitScore.TabIndex = 0;
            this.btn_submitScore.Text = "Submit score";
            this.btn_submitScore.UseVisualStyleBackColor = true;
            this.btn_submitScore.Click += new System.EventHandler(this.btn_submitScore_Click);
            // 
            // dom_div
            // 
            this.dom_div.AutoSize = true;
            this.dom_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dom_div.Location = new System.Drawing.Point(391, 155);
            this.dom_div.Name = "dom_div";
            this.dom_div.Size = new System.Drawing.Size(120, 27);
            this.dom_div.TabIndex = 46;
            this.dom_div.ValueChanged += new System.EventHandler(this.OnValueChanged);
            this.dom_div.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnValueChanged);
            // 
            // dom_mult
            // 
            this.dom_mult.AutoSize = true;
            this.dom_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dom_mult.Location = new System.Drawing.Point(391, 122);
            this.dom_mult.Name = "dom_mult";
            this.dom_mult.Size = new System.Drawing.Size(120, 27);
            this.dom_mult.TabIndex = 45;
            this.dom_mult.ValueChanged += new System.EventHandler(this.OnValueChanged);
            this.dom_mult.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnValueChanged);
            // 
            // dom_subs
            // 
            this.dom_subs.AutoSize = true;
            this.dom_subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dom_subs.Location = new System.Drawing.Point(391, 89);
            this.dom_subs.Name = "dom_subs";
            this.dom_subs.Size = new System.Drawing.Size(120, 27);
            this.dom_subs.TabIndex = 44;
            this.dom_subs.ValueChanged += new System.EventHandler(this.OnValueChanged);
            this.dom_subs.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnValueChanged);
            // 
            // dom_sum
            // 
            this.dom_sum.AutoSize = true;
            this.dom_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 12.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dom_sum.Location = new System.Drawing.Point(391, 56);
            this.dom_sum.Name = "dom_sum";
            this.dom_sum.Size = new System.Drawing.Size(120, 27);
            this.dom_sum.TabIndex = 43;
            this.dom_sum.ValueChanged += new System.EventHandler(this.OnValueChanged);
            this.dom_sum.Enter += new System.EventHandler(this.answer_Enter);
            this.dom_sum.KeyUp += new System.Windows.Forms.KeyEventHandler(this.OnValueChanged);
            // 
            // btn_startButton
            // 
            this.btn_startButton.AutoSize = true;
            this.btn_startButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_startButton.Location = new System.Drawing.Point(306, 209);
            this.btn_startButton.Name = "btn_startButton";
            this.btn_startButton.Size = new System.Drawing.Size(100, 34);
            this.btn_startButton.TabIndex = 1;
            this.btn_startButton.Text = "Start Quiz";
            this.btn_startButton.UseVisualStyleBackColor = true;
            this.btn_startButton.Click += new System.EventHandler(this.btn_startButton_Click);
            // 
            // lbl_equal4
            // 
            this.lbl_equal4.AutoSize = true;
            this.lbl_equal4.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equal4.Location = new System.Drawing.Point(342, 158);
            this.lbl_equal4.Name = "lbl_equal4";
            this.lbl_equal4.Size = new System.Drawing.Size(21, 24);
            this.lbl_equal4.TabIndex = 42;
            this.lbl_equal4.Text = "=";
            this.lbl_equal4.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_divNum2
            // 
            this.lbl_divNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_divNum2.Location = new System.Drawing.Point(284, 158);
            this.lbl_divNum2.Name = "lbl_divNum2";
            this.lbl_divNum2.Size = new System.Drawing.Size(52, 24);
            this.lbl_divNum2.TabIndex = 41;
            this.lbl_divNum2.Text = "?";
            this.lbl_divNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_div
            // 
            this.lbl_div.AutoSize = true;
            this.lbl_div.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_div.Location = new System.Drawing.Point(247, 158);
            this.lbl_div.Name = "lbl_div";
            this.lbl_div.Size = new System.Drawing.Size(15, 24);
            this.lbl_div.TabIndex = 40;
            this.lbl_div.Text = "/";
            this.lbl_div.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_divNum1
            // 
            this.lbl_divNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_divNum1.Location = new System.Drawing.Point(175, 158);
            this.lbl_divNum1.Name = "lbl_divNum1";
            this.lbl_divNum1.Size = new System.Drawing.Size(52, 24);
            this.lbl_divNum1.TabIndex = 39;
            this.lbl_divNum1.Text = "?";
            this.lbl_divNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_equal3
            // 
            this.lbl_equal3.AutoSize = true;
            this.lbl_equal3.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equal3.Location = new System.Drawing.Point(342, 125);
            this.lbl_equal3.Name = "lbl_equal3";
            this.lbl_equal3.Size = new System.Drawing.Size(21, 24);
            this.lbl_equal3.TabIndex = 37;
            this.lbl_equal3.Text = "=";
            this.lbl_equal3.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_multNum2
            // 
            this.lbl_multNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multNum2.Location = new System.Drawing.Point(284, 125);
            this.lbl_multNum2.Name = "lbl_multNum2";
            this.lbl_multNum2.Size = new System.Drawing.Size(52, 24);
            this.lbl_multNum2.TabIndex = 36;
            this.lbl_multNum2.Text = "?";
            this.lbl_multNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_mult
            // 
            this.lbl_mult.AutoSize = true;
            this.lbl_mult.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_mult.Location = new System.Drawing.Point(247, 125);
            this.lbl_mult.Name = "lbl_mult";
            this.lbl_mult.Size = new System.Drawing.Size(20, 24);
            this.lbl_mult.TabIndex = 35;
            this.lbl_mult.Text = "x";
            this.lbl_mult.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_multNum1
            // 
            this.lbl_multNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_multNum1.Location = new System.Drawing.Point(175, 125);
            this.lbl_multNum1.Name = "lbl_multNum1";
            this.lbl_multNum1.Size = new System.Drawing.Size(52, 24);
            this.lbl_multNum1.TabIndex = 34;
            this.lbl_multNum1.Text = "?";
            this.lbl_multNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_equal2
            // 
            this.lbl_equal2.AutoSize = true;
            this.lbl_equal2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equal2.Location = new System.Drawing.Point(342, 92);
            this.lbl_equal2.Name = "lbl_equal2";
            this.lbl_equal2.Size = new System.Drawing.Size(21, 24);
            this.lbl_equal2.TabIndex = 32;
            this.lbl_equal2.Text = "=";
            this.lbl_equal2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subsNum2
            // 
            this.lbl_subsNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subsNum2.Location = new System.Drawing.Point(284, 92);
            this.lbl_subsNum2.Name = "lbl_subsNum2";
            this.lbl_subsNum2.Size = new System.Drawing.Size(52, 24);
            this.lbl_subsNum2.TabIndex = 31;
            this.lbl_subsNum2.Text = "?";
            this.lbl_subsNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subs
            // 
            this.lbl_subs.AutoSize = true;
            this.lbl_subs.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subs.Location = new System.Drawing.Point(247, 92);
            this.lbl_subs.Name = "lbl_subs";
            this.lbl_subs.Size = new System.Drawing.Size(16, 24);
            this.lbl_subs.TabIndex = 30;
            this.lbl_subs.Text = "-";
            this.lbl_subs.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_subsNum1
            // 
            this.lbl_subsNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_subsNum1.Location = new System.Drawing.Point(175, 92);
            this.lbl_subsNum1.Name = "lbl_subsNum1";
            this.lbl_subsNum1.Size = new System.Drawing.Size(52, 24);
            this.lbl_subsNum1.TabIndex = 29;
            this.lbl_subsNum1.Text = "?";
            this.lbl_subsNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_equal1
            // 
            this.lbl_equal1.AutoSize = true;
            this.lbl_equal1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_equal1.Location = new System.Drawing.Point(342, 59);
            this.lbl_equal1.Name = "lbl_equal1";
            this.lbl_equal1.Size = new System.Drawing.Size(21, 24);
            this.lbl_equal1.TabIndex = 27;
            this.lbl_equal1.Text = "=";
            this.lbl_equal1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_timeRemaining
            // 
            this.lbl_timeRemaining.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.lbl_timeRemaining.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeRemaining.Location = new System.Drawing.Point(338, 15);
            this.lbl_timeRemaining.Name = "lbl_timeRemaining";
            this.lbl_timeRemaining.Size = new System.Drawing.Size(150, 30);
            this.lbl_timeRemaining.TabIndex = 26;
            // 
            // lbl_timeTitle
            // 
            this.lbl_timeTitle.AutoSize = true;
            this.lbl_timeTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_timeTitle.Location = new System.Drawing.Point(198, 16);
            this.lbl_timeTitle.Name = "lbl_timeTitle";
            this.lbl_timeTitle.Size = new System.Drawing.Size(123, 20);
            this.lbl_timeTitle.TabIndex = 25;
            this.lbl_timeTitle.Text = "Time Remaining";
            // 
            // lbl_addNum2
            // 
            this.lbl_addNum2.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addNum2.Location = new System.Drawing.Point(284, 59);
            this.lbl_addNum2.Name = "lbl_addNum2";
            this.lbl_addNum2.Size = new System.Drawing.Size(52, 24);
            this.lbl_addNum2.TabIndex = 15;
            this.lbl_addNum2.Text = "?";
            this.lbl_addNum2.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_sum
            // 
            this.lbl_sum.AutoSize = true;
            this.lbl_sum.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_sum.Location = new System.Drawing.Point(247, 59);
            this.lbl_sum.Name = "lbl_sum";
            this.lbl_sum.Size = new System.Drawing.Size(21, 24);
            this.lbl_sum.TabIndex = 14;
            this.lbl_sum.Text = "+";
            this.lbl_sum.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // lbl_addNum1
            // 
            this.lbl_addNum1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_addNum1.Location = new System.Drawing.Point(175, 59);
            this.lbl_addNum1.Name = "lbl_addNum1";
            this.lbl_addNum1.Size = new System.Drawing.Size(52, 24);
            this.lbl_addNum1.TabIndex = 13;
            this.lbl_addNum1.Text = "?";
            this.lbl_addNum1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.dataGridView1);
            this.tabPage2.Location = new System.Drawing.Point(4, 22);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(539, 249);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "High Scores";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoGenerateColumns = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.playeridDataGridViewTextBoxColumn,
            this.playerNameDataGridViewTextBoxColumn,
            this.playerScoreDataGridViewTextBoxColumn});
            this.dataGridView1.DataSource = this.tblPlayerBindingSource;
            this.dataGridView1.Location = new System.Drawing.Point(6, 6);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(527, 237);
            this.dataGridView1.TabIndex = 0;
            // 
            // playeridDataGridViewTextBoxColumn
            // 
            this.playeridDataGridViewTextBoxColumn.DataPropertyName = "Player_id";
            this.playeridDataGridViewTextBoxColumn.HeaderText = "Player_id";
            this.playeridDataGridViewTextBoxColumn.Name = "playeridDataGridViewTextBoxColumn";
            // 
            // playerNameDataGridViewTextBoxColumn
            // 
            this.playerNameDataGridViewTextBoxColumn.DataPropertyName = "Player_Name";
            this.playerNameDataGridViewTextBoxColumn.HeaderText = "Player_Name";
            this.playerNameDataGridViewTextBoxColumn.Name = "playerNameDataGridViewTextBoxColumn";
            // 
            // playerScoreDataGridViewTextBoxColumn
            // 
            this.playerScoreDataGridViewTextBoxColumn.DataPropertyName = "Player_Score";
            this.playerScoreDataGridViewTextBoxColumn.HeaderText = "Player_Score";
            this.playerScoreDataGridViewTextBoxColumn.Name = "playerScoreDataGridViewTextBoxColumn";
            // 
            // tblPlayerBindingSource
            // 
            this.tblPlayerBindingSource.DataMember = "Tbl_Player";
            this.tblPlayerBindingSource.DataSource = this.scoresDBDataSet;
            // 
            // scoresDBDataSet
            // 
            this.scoresDBDataSet.DataSetName = "ScoresDBDataSet";
            this.scoresDBDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // tmr_quizTime
            // 
            this.tmr_quizTime.Interval = 1000;
            this.tmr_quizTime.Tick += new System.EventHandler(this.tmr_quizTime_Tick);
            // 
            // tbl_PlayerTableAdapter
            // 
            this.tbl_PlayerTableAdapter.ClearBeforeFill = true;
            // 
            // MathQuiz
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(564, 331);
            this.Controls.Add(this.tabControl1);
            this.Controls.Add(this.lbl_title);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MathQuiz";
            this.Text = "Math Quiz";
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.grpBox_score.ResumeLayout(false);
            this.grpBox_score.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dom_div)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_mult)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_subs)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dom_sum)).EndInit();
            this.tabPage2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.tblPlayerBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scoresDBDataSet)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbl_title;
        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Label lbl_addNum2;
        private System.Windows.Forms.Label lbl_sum;
        private System.Windows.Forms.Label lbl_addNum1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.Label lbl_timeRemaining;
        private System.Windows.Forms.Label lbl_timeTitle;
        private System.Windows.Forms.Label lbl_equal1;
        private System.Windows.Forms.Label lbl_equal4;
        private System.Windows.Forms.Label lbl_divNum2;
        private System.Windows.Forms.Label lbl_div;
        private System.Windows.Forms.Label lbl_divNum1;
        private System.Windows.Forms.Label lbl_equal3;
        private System.Windows.Forms.Label lbl_multNum2;
        private System.Windows.Forms.Label lbl_mult;
        private System.Windows.Forms.Label lbl_multNum1;
        private System.Windows.Forms.Label lbl_equal2;
        private System.Windows.Forms.Label lbl_subsNum2;
        private System.Windows.Forms.Label lbl_subs;
        private System.Windows.Forms.Label lbl_subsNum1;
        private System.Windows.Forms.Button btn_startButton;
        private System.Windows.Forms.NumericUpDown dom_div;
        private System.Windows.Forms.NumericUpDown dom_mult;
        private System.Windows.Forms.NumericUpDown dom_subs;
        private System.Windows.Forms.NumericUpDown dom_sum;
        private System.Windows.Forms.GroupBox grpBox_score;
        private System.Windows.Forms.Button btn_submitScore;
        private System.Windows.Forms.Label lbl_scoreTitle;
        private System.Windows.Forms.TextBox txtBox_name;
        private System.Windows.Forms.Label lbl_score;
        private System.Windows.Forms.Label lbl_nameTitle;
        private System.Windows.Forms.Timer tmr_quizTime;
        private System.Windows.Forms.DataGridView dataGridView1;
        private ScoresDBDataSet scoresDBDataSet;
        private System.Windows.Forms.BindingSource tblPlayerBindingSource;
        private ScoresDBDataSetTableAdapters.Tbl_PlayerTableAdapter tbl_PlayerTableAdapter;
        private System.Windows.Forms.DataGridViewTextBoxColumn playeridDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerNameDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn playerScoreDataGridViewTextBoxColumn;
    }
}

