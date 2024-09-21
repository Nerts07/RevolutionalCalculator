namespace RevolutionalCalculator
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.PnlTitle = new System.Windows.Forms.Panel();
            this.BtnExit = new System.Windows.Forms.Button();
            this.PnlHistory = new System.Windows.Forms.Panel();
            this.clearBtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.track_listed = new System.Windows.Forms.ListBox();
            this.buttonEqual = new System.Windows.Forms.Button();
            this.button18 = new System.Windows.Forms.Button();
            this.button19 = new System.Windows.Forms.Button();
            this.button20 = new System.Windows.Forms.Button();
            this.button13 = new System.Windows.Forms.Button();
            this.buttonThree = new System.Windows.Forms.Button();
            this.buttonTwo = new System.Windows.Forms.Button();
            this.buttonOne = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.buttonSix = new System.Windows.Forms.Button();
            this.buttonFive = new System.Windows.Forms.Button();
            this.buttonFour = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.buttonNine = new System.Windows.Forms.Button();
            this.buttonEight = new System.Windows.Forms.Button();
            this.buttonSeven = new System.Windows.Forms.Button();
            this.TxtDisplay1 = new System.Windows.Forms.TextBox();
            this.TxtDisplay2 = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.button2 = new System.Windows.Forms.Button();
            this.button4 = new System.Windows.Forms.Button();
            this.button3 = new System.Windows.Forms.Button();
            this.BtnHistory = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.trackBar1 = new System.Windows.Forms.TrackBar();
            this.lbl_msg = new System.Windows.Forms.Label();
            this.progressBar1 = new System.Windows.Forms.ProgressBar();
            this.lbl_track_start = new System.Windows.Forms.Label();
            this.lbl_track_end = new System.Windows.Forms.Label();
            this.next_btn = new System.Windows.Forms.Button();
            this.prev_btn = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.PnlTitle.SuspendLayout();
            this.PnlHistory.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).BeginInit();
            this.SuspendLayout();
            // 
            // PnlTitle
            // 
            this.PnlTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(31)))), ((int)(((byte)(30)))), ((int)(((byte)(32)))));
            this.PnlTitle.Controls.Add(this.BtnExit);
            this.PnlTitle.Dock = System.Windows.Forms.DockStyle.Top;
            this.PnlTitle.Location = new System.Drawing.Point(0, 0);
            this.PnlTitle.Name = "PnlTitle";
            this.PnlTitle.Size = new System.Drawing.Size(669, 51);
            this.PnlTitle.TabIndex = 0;
            this.PnlTitle.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlTitle_Paint);
            // 
            // BtnExit
            // 
            this.BtnExit.Dock = System.Windows.Forms.DockStyle.Right;
            this.BtnExit.FlatAppearance.BorderSize = 0;
            this.BtnExit.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnExit.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnExit.Location = new System.Drawing.Point(0, 0);
            this.BtnExit.Margin = new System.Windows.Forms.Padding(0);
            this.BtnExit.Name = "BtnExit";
            this.BtnExit.Size = new System.Drawing.Size(669, 51);
            this.BtnExit.TabIndex = 0;
            this.BtnExit.Text = "Exit From The Revolutional Calculator";
            this.BtnExit.UseVisualStyleBackColor = true;
            this.BtnExit.Click += new System.EventHandler(this.BtnExit_Click);
            // 
            // PnlHistory
            // 
            this.PnlHistory.Controls.Add(this.clearBtn);
            this.PnlHistory.Controls.Add(this.richTextBox1);
            this.PnlHistory.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.PnlHistory.Location = new System.Drawing.Point(0, 389);
            this.PnlHistory.Name = "PnlHistory";
            this.PnlHistory.Size = new System.Drawing.Size(669, 111);
            this.PnlHistory.TabIndex = 1;
            this.PnlHistory.Paint += new System.Windows.Forms.PaintEventHandler(this.PnlHistory_Paint);
            // 
            // clearBtn
            // 
            this.clearBtn.FlatAppearance.BorderSize = 0;
            this.clearBtn.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Peru;
            this.clearBtn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.clearBtn.Location = new System.Drawing.Point(0, 78);
            this.clearBtn.Margin = new System.Windows.Forms.Padding(0);
            this.clearBtn.Name = "clearBtn";
            this.clearBtn.Size = new System.Drawing.Size(338, 33);
            this.clearBtn.TabIndex = 5;
            this.clearBtn.Text = "Clear History (Not Browser\'s)";
            this.clearBtn.UseVisualStyleBackColor = true;
            this.clearBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.richTextBox1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.richTextBox1.Location = new System.Drawing.Point(283, 3);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(55, 45);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.TextChanged += new System.EventHandler(this.richTextBox1_TextChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.prev_btn);
            this.panel1.Controls.Add(this.next_btn);
            this.panel1.Controls.Add(this.lbl_track_end);
            this.panel1.Controls.Add(this.lbl_track_start);
            this.panel1.Controls.Add(this.progressBar1);
            this.panel1.Controls.Add(this.lbl_msg);
            this.panel1.Controls.Add(this.trackBar1);
            this.panel1.Controls.Add(this.track_listed);
            this.panel1.Controls.Add(this.buttonEqual);
            this.panel1.Controls.Add(this.button18);
            this.panel1.Controls.Add(this.button19);
            this.panel1.Controls.Add(this.button20);
            this.panel1.Controls.Add(this.button13);
            this.panel1.Controls.Add(this.buttonThree);
            this.panel1.Controls.Add(this.buttonTwo);
            this.panel1.Controls.Add(this.buttonOne);
            this.panel1.Controls.Add(this.button9);
            this.panel1.Controls.Add(this.buttonSix);
            this.panel1.Controls.Add(this.buttonFive);
            this.panel1.Controls.Add(this.buttonFour);
            this.panel1.Controls.Add(this.button8);
            this.panel1.Controls.Add(this.buttonNine);
            this.panel1.Controls.Add(this.buttonEight);
            this.panel1.Controls.Add(this.buttonSeven);
            this.panel1.Controls.Add(this.TxtDisplay1);
            this.panel1.Controls.Add(this.TxtDisplay2);
            this.panel1.Controls.Add(this.panel2);
            this.panel1.Controls.Add(this.PnlHistory);
            this.panel1.Controls.Add(this.PnlTitle);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(669, 500);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // track_listed
            // 
            this.track_listed.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(30)))), ((int)(((byte)(35)))));
            this.track_listed.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.track_listed.Font = new System.Drawing.Font("Gadugi", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.track_listed.ForeColor = System.Drawing.SystemColors.ScrollBar;
            this.track_listed.FormattingEnabled = true;
            this.track_listed.ItemHeight = 19;
            this.track_listed.Location = new System.Drawing.Point(352, 202);
            this.track_listed.Margin = new System.Windows.Forms.Padding(0);
            this.track_listed.Name = "track_listed";
            this.track_listed.Size = new System.Drawing.Size(305, 249);
            this.track_listed.TabIndex = 21;
            this.track_listed.SelectedIndexChanged += new System.EventHandler(this.track_list_SelectedIndexChanged);
            // 
            // buttonEqual
            // 
            this.buttonEqual.BackColor = System.Drawing.Color.SteelBlue;
            this.buttonEqual.FlatAppearance.BorderSize = 0;
            this.buttonEqual.FlatAppearance.MouseDownBackColor = System.Drawing.Color.DarkSlateGray;
            this.buttonEqual.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEqual.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonEqual.Location = new System.Drawing.Point(263, 392);
            this.buttonEqual.Name = "buttonEqual";
            this.buttonEqual.Size = new System.Drawing.Size(73, 61);
            this.buttonEqual.TabIndex = 20;
            this.buttonEqual.Text = "=";
            this.buttonEqual.UseVisualStyleBackColor = false;
            this.buttonEqual.Click += new System.EventHandler(this.buttonEqual_Click);
            // 
            // button18
            // 
            this.button18.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.button18.FlatAppearance.BorderSize = 0;
            this.button18.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button18.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button18.Location = new System.Drawing.Point(184, 392);
            this.button18.Name = "button18";
            this.button18.Size = new System.Drawing.Size(73, 61);
            this.button18.TabIndex = 19;
            this.button18.Text = ".";
            this.button18.UseVisualStyleBackColor = false;
            this.button18.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // button19
            // 
            this.button19.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.button19.FlatAppearance.BorderSize = 0;
            this.button19.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button19.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button19.Location = new System.Drawing.Point(105, 392);
            this.button19.Name = "button19";
            this.button19.Size = new System.Drawing.Size(73, 61);
            this.button19.TabIndex = 18;
            this.button19.Text = "0";
            this.button19.UseVisualStyleBackColor = false;
            this.button19.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // button20
            // 
            this.button20.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(84)))));
            this.button20.FlatAppearance.BorderSize = 0;
            this.button20.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button20.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button20.Location = new System.Drawing.Point(26, 392);
            this.button20.Name = "button20";
            this.button20.Size = new System.Drawing.Size(73, 61);
            this.button20.TabIndex = 17;
            this.button20.Text = "/";
            this.button20.UseVisualStyleBackColor = false;
            this.button20.Click += new System.EventHandler(this.BtnMethOperats);
            // 
            // button13
            // 
            this.button13.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.button13.FlatAppearance.BorderSize = 0;
            this.button13.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button13.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button13.Location = new System.Drawing.Point(263, 325);
            this.button13.Name = "button13";
            this.button13.Size = new System.Drawing.Size(73, 61);
            this.button13.TabIndex = 16;
            this.button13.Text = "+";
            this.button13.UseVisualStyleBackColor = false;
            this.button13.Click += new System.EventHandler(this.BtnMethOperats);
            // 
            // buttonThree
            // 
            this.buttonThree.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonThree.FlatAppearance.BorderSize = 0;
            this.buttonThree.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonThree.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonThree.Location = new System.Drawing.Point(184, 325);
            this.buttonThree.Name = "buttonThree";
            this.buttonThree.Size = new System.Drawing.Size(73, 61);
            this.buttonThree.TabIndex = 15;
            this.buttonThree.Text = "3";
            this.buttonThree.UseVisualStyleBackColor = false;
            this.buttonThree.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonTwo
            // 
            this.buttonTwo.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonTwo.FlatAppearance.BorderSize = 0;
            this.buttonTwo.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonTwo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonTwo.Location = new System.Drawing.Point(105, 325);
            this.buttonTwo.Name = "buttonTwo";
            this.buttonTwo.Size = new System.Drawing.Size(73, 61);
            this.buttonTwo.TabIndex = 14;
            this.buttonTwo.Text = "2";
            this.buttonTwo.UseVisualStyleBackColor = false;
            this.buttonTwo.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonOne
            // 
            this.buttonOne.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonOne.FlatAppearance.BorderSize = 0;
            this.buttonOne.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonOne.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonOne.Location = new System.Drawing.Point(26, 325);
            this.buttonOne.Name = "buttonOne";
            this.buttonOne.Size = new System.Drawing.Size(73, 61);
            this.buttonOne.TabIndex = 13;
            this.buttonOne.Text = "1";
            this.buttonOne.UseVisualStyleBackColor = false;
            this.buttonOne.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.button9.FlatAppearance.BorderSize = 0;
            this.button9.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button9.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button9.Location = new System.Drawing.Point(263, 258);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(73, 61);
            this.button9.TabIndex = 12;
            this.button9.Text = "-";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.BtnMethOperats);
            // 
            // buttonSix
            // 
            this.buttonSix.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSix.FlatAppearance.BorderSize = 0;
            this.buttonSix.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonSix.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSix.Location = new System.Drawing.Point(184, 258);
            this.buttonSix.Name = "buttonSix";
            this.buttonSix.Size = new System.Drawing.Size(73, 61);
            this.buttonSix.TabIndex = 11;
            this.buttonSix.Text = "6";
            this.buttonSix.UseVisualStyleBackColor = false;
            this.buttonSix.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonFive
            // 
            this.buttonFive.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFive.FlatAppearance.BorderSize = 0;
            this.buttonFive.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonFive.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFive.Location = new System.Drawing.Point(105, 258);
            this.buttonFive.Name = "buttonFive";
            this.buttonFive.Size = new System.Drawing.Size(73, 61);
            this.buttonFive.TabIndex = 10;
            this.buttonFive.Text = "5";
            this.buttonFive.UseVisualStyleBackColor = false;
            this.buttonFive.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonFour
            // 
            this.buttonFour.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonFour.FlatAppearance.BorderSize = 0;
            this.buttonFour.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonFour.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonFour.Location = new System.Drawing.Point(26, 258);
            this.buttonFour.Name = "buttonFour";
            this.buttonFour.Size = new System.Drawing.Size(73, 61);
            this.buttonFour.TabIndex = 9;
            this.buttonFour.Text = "4";
            this.buttonFour.UseVisualStyleBackColor = false;
            this.buttonFour.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(74)))));
            this.button8.FlatAppearance.BorderSize = 0;
            this.button8.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.button8.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button8.Location = new System.Drawing.Point(263, 191);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(73, 61);
            this.button8.TabIndex = 8;
            this.button8.Text = "X";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.BtnMethOperats);
            // 
            // buttonNine
            // 
            this.buttonNine.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonNine.FlatAppearance.BorderSize = 0;
            this.buttonNine.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonNine.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonNine.Location = new System.Drawing.Point(184, 191);
            this.buttonNine.Name = "buttonNine";
            this.buttonNine.Size = new System.Drawing.Size(73, 61);
            this.buttonNine.TabIndex = 7;
            this.buttonNine.Text = "9";
            this.buttonNine.UseVisualStyleBackColor = false;
            this.buttonNine.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonEight
            // 
            this.buttonEight.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonEight.FlatAppearance.BorderSize = 0;
            this.buttonEight.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonEight.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonEight.Location = new System.Drawing.Point(105, 191);
            this.buttonEight.Name = "buttonEight";
            this.buttonEight.Size = new System.Drawing.Size(73, 61);
            this.buttonEight.TabIndex = 6;
            this.buttonEight.Text = "8";
            this.buttonEight.UseVisualStyleBackColor = false;
            this.buttonEight.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // buttonSeven
            // 
            this.buttonSeven.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.buttonSeven.FlatAppearance.BorderSize = 0;
            this.buttonSeven.FlatAppearance.MouseDownBackColor = System.Drawing.SystemColors.ControlText;
            this.buttonSeven.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.buttonSeven.Location = new System.Drawing.Point(26, 191);
            this.buttonSeven.Name = "buttonSeven";
            this.buttonSeven.Size = new System.Drawing.Size(73, 61);
            this.buttonSeven.TabIndex = 5;
            this.buttonSeven.Text = "7";
            this.buttonSeven.UseVisualStyleBackColor = false;
            this.buttonSeven.Click += new System.EventHandler(this.BtnNum_Click);
            // 
            // TxtDisplay1
            // 
            this.TxtDisplay1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay1.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay1.Font = new System.Drawing.Font("Gadugi", 36F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay1.ForeColor = System.Drawing.SystemColors.ControlLight;
            this.TxtDisplay1.Location = new System.Drawing.Point(0, 127);
            this.TxtDisplay1.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay1.Multiline = true;
            this.TxtDisplay1.Name = "TxtDisplay1";
            this.TxtDisplay1.Size = new System.Drawing.Size(350, 61);
            this.TxtDisplay1.TabIndex = 4;
            this.TxtDisplay1.Text = "0";
            this.TxtDisplay1.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay1.TextChanged += new System.EventHandler(this.TxtDisplay1_TextChanged);
            // 
            // TxtDisplay2
            // 
            this.TxtDisplay2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.TxtDisplay2.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.TxtDisplay2.Font = new System.Drawing.Font("Gadugi", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TxtDisplay2.ForeColor = System.Drawing.SystemColors.ControlDark;
            this.TxtDisplay2.Location = new System.Drawing.Point(0, 102);
            this.TxtDisplay2.Margin = new System.Windows.Forms.Padding(0);
            this.TxtDisplay2.Multiline = true;
            this.TxtDisplay2.Name = "TxtDisplay2";
            this.TxtDisplay2.Size = new System.Drawing.Size(350, 25);
            this.TxtDisplay2.TabIndex = 3;
            this.TxtDisplay2.Text = "0";
            this.TxtDisplay2.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.TxtDisplay2.TextChanged += new System.EventHandler(this.TxtDisplay2_TextChanged);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.button2);
            this.panel2.Controls.Add(this.button4);
            this.panel2.Controls.Add(this.button3);
            this.panel2.Controls.Add(this.BtnHistory);
            this.panel2.Location = new System.Drawing.Point(0, 54);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(350, 45);
            this.panel2.TabIndex = 2;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // button2
            // 
            this.button2.FlatAppearance.BorderSize = 0;
            this.button2.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button2.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.button2.Location = new System.Drawing.Point(0, 0);
            this.button2.Margin = new System.Windows.Forms.Padding(0);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(99, 45);
            this.button2.TabIndex = 5;
            this.button2.Text = "Select";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.ChangeMusic);
            // 
            // button4
            // 
            this.button4.FlatAppearance.BorderSize = 0;
            this.button4.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button4.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button4.Location = new System.Drawing.Point(264, 0);
            this.button4.Margin = new System.Windows.Forms.Padding(0);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(85, 45);
            this.button4.TabIndex = 6;
            this.button4.Text = "Resume";
            this.button4.UseVisualStyleBackColor = true;
            this.button4.Click += new System.EventHandler(this.Resume);
            // 
            // button3
            // 
            this.button3.FlatAppearance.BorderSize = 0;
            this.button3.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.button3.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.button3.Location = new System.Drawing.Point(198, 0);
            this.button3.Margin = new System.Windows.Forms.Padding(0);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(66, 45);
            this.button3.TabIndex = 5;
            this.button3.Text = "Pause";
            this.button3.UseVisualStyleBackColor = true;
            this.button3.Click += new System.EventHandler(this.PauseBtn);
            // 
            // BtnHistory
            // 
            this.BtnHistory.FlatAppearance.BorderSize = 0;
            this.BtnHistory.FlatAppearance.MouseOverBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.BtnHistory.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.BtnHistory.Location = new System.Drawing.Point(99, 0);
            this.BtnHistory.Margin = new System.Windows.Forms.Padding(0);
            this.BtnHistory.Name = "BtnHistory";
            this.BtnHistory.Size = new System.Drawing.Size(99, 45);
            this.BtnHistory.TabIndex = 3;
            this.BtnHistory.Text = "Play Music";
            this.BtnHistory.UseVisualStyleBackColor = true;
            this.BtnHistory.Click += new System.EventHandler(this.BtnPlayMusic);
            // 
            // backgroundWorker1
            // 
            this.backgroundWorker1.DoWork += new System.ComponentModel.DoWorkEventHandler(this.backgroundWorker1_DoWork);
            // 
            // trackBar1
            // 
            this.trackBar1.Location = new System.Drawing.Point(356, 54);
            this.trackBar1.Margin = new System.Windows.Forms.Padding(0);
            this.trackBar1.Maximum = 100;
            this.trackBar1.Name = "trackBar1";
            this.trackBar1.Size = new System.Drawing.Size(301, 45);
            this.trackBar1.TabIndex = 22;
            this.trackBar1.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar1.Value = 80;
            this.trackBar1.Scroll += new System.EventHandler(this.trackBar1_Scroll);
            // 
            // lbl_msg
            // 
            this.lbl_msg.AutoSize = true;
            this.lbl_msg.Location = new System.Drawing.Point(353, 92);
            this.lbl_msg.Name = "lbl_msg";
            this.lbl_msg.Size = new System.Drawing.Size(153, 19);
            this.lbl_msg.TabIndex = 23;
            this.lbl_msg.Text = "No Music Right Now";
            // 
            // progressBar1
            // 
            this.progressBar1.ForeColor = System.Drawing.SystemColors.Desktop;
            this.progressBar1.Location = new System.Drawing.Point(352, 174);
            this.progressBar1.Name = "progressBar1";
            this.progressBar1.Size = new System.Drawing.Size(305, 14);
            this.progressBar1.Style = System.Windows.Forms.ProgressBarStyle.Continuous;
            this.progressBar1.TabIndex = 24;
            // 
            // lbl_track_start
            // 
            this.lbl_track_start.AutoSize = true;
            this.lbl_track_start.Location = new System.Drawing.Point(352, 152);
            this.lbl_track_start.Name = "lbl_track_start";
            this.lbl_track_start.Size = new System.Drawing.Size(48, 19);
            this.lbl_track_start.TabIndex = 25;
            this.lbl_track_start.Text = "00:00";
            // 
            // lbl_track_end
            // 
            this.lbl_track_end.AutoSize = true;
            this.lbl_track_end.Location = new System.Drawing.Point(606, 152);
            this.lbl_track_end.Name = "lbl_track_end";
            this.lbl_track_end.Size = new System.Drawing.Size(48, 19);
            this.lbl_track_end.TabIndex = 26;
            this.lbl_track_end.Text = "00:00";
            this.lbl_track_end.Click += new System.EventHandler(this.remain);
            // 
            // next_btn
            // 
            this.next_btn.FlatAppearance.BorderSize = 0;
            this.next_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.next_btn.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.next_btn.Location = new System.Drawing.Point(594, 114);
            this.next_btn.Margin = new System.Windows.Forms.Padding(0);
            this.next_btn.Name = "next_btn";
            this.next_btn.Size = new System.Drawing.Size(60, 38);
            this.next_btn.TabIndex = 27;
            this.next_btn.Text = ">";
            this.next_btn.UseVisualStyleBackColor = true;
            this.next_btn.Click += new System.EventHandler(this.next_btn_Click);
            // 
            // prev_btn
            // 
            this.prev_btn.FlatAppearance.BorderSize = 0;
            this.prev_btn.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.prev_btn.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.prev_btn.Location = new System.Drawing.Point(352, 114);
            this.prev_btn.Margin = new System.Windows.Forms.Padding(0);
            this.prev_btn.Name = "prev_btn";
            this.prev_btn.Size = new System.Drawing.Size(60, 38);
            this.prev_btn.TabIndex = 28;
            this.prev_btn.Text = "<";
            this.prev_btn.UseVisualStyleBackColor = true;
            this.prev_btn.Click += new System.EventHandler(this.prev_btn_Click);
            // 
            // timer1
            // 
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // Form1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(32)))), ((int)(((byte)(32)))), ((int)(((byte)(32)))));
            this.ClientSize = new System.Drawing.Size(669, 500);
            this.Controls.Add(this.panel1);
            this.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.Color.White;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Revolutional Calculator";
            this.PnlTitle.ResumeLayout(false);
            this.PnlHistory.ResumeLayout(false);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel PnlTitle;
        private System.Windows.Forms.Button BtnExit;
        private System.Windows.Forms.Panel PnlHistory;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Button BtnHistory;
        private System.Windows.Forms.TextBox TxtDisplay2;
        private System.Windows.Forms.TextBox TxtDisplay1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.Button clearBtn;
        private System.Windows.Forms.Button button3;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button buttonSeven;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button buttonNine;
        private System.Windows.Forms.Button buttonEight;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button buttonSix;
        private System.Windows.Forms.Button buttonFive;
        private System.Windows.Forms.Button buttonFour;
        private System.Windows.Forms.Button buttonEqual;
        private System.Windows.Forms.Button button18;
        private System.Windows.Forms.Button button19;
        private System.Windows.Forms.Button button20;
        private System.Windows.Forms.Button button13;
        private System.Windows.Forms.Button buttonThree;
        private System.Windows.Forms.Button buttonTwo;
        private System.Windows.Forms.Button buttonOne;
        private System.Windows.Forms.ListBox track_listed;
        private System.Windows.Forms.TrackBar trackBar1;
        private System.Windows.Forms.Label lbl_msg;
        private System.Windows.Forms.Label lbl_track_start;
        private System.Windows.Forms.ProgressBar progressBar1;
        private System.Windows.Forms.Label lbl_track_end;
        private System.Windows.Forms.Button next_btn;
        private System.Windows.Forms.Button prev_btn;
        private System.Windows.Forms.Timer timer1;
    }
}

