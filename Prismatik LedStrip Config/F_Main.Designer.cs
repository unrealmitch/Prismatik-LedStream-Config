namespace Prismatik_LedStrip_Config
{
    partial class F_Main
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(F_Main));
            this.GB_Add = new System.Windows.Forms.GroupBox();
            this.BT_DeleteSel = new System.Windows.Forms.Button();
            this.BT_Auto = new System.Windows.Forms.Button();
            this.BT_Y_L = new System.Windows.Forms.Button();
            this.BT_Y_P = new System.Windows.Forms.Button();
            this.BT_X_L = new System.Windows.Forms.Button();
            this.BT_X_P = new System.Windows.Forms.Button();
            this.BT_Delete = new System.Windows.Forms.Button();
            this.TB_NLeds = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.RB_Down = new System.Windows.Forms.RadioButton();
            this.RB_Up = new System.Windows.Forms.RadioButton();
            this.RB_Right = new System.Windows.Forms.RadioButton();
            this.RB_Left = new System.Windows.Forms.RadioButton();
            this.TB_SizeY = new System.Windows.Forms.TextBox();
            this.TB_SizeX = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TB_StartY = new System.Windows.Forms.TextBox();
            this.TB_StartX = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.BT_Add = new System.Windows.Forms.Button();
            this.LB_Leds = new System.Windows.Forms.ListBox();
            this.GB_Led = new System.Windows.Forms.GroupBox();
            this.TB_led_sizeY = new System.Windows.Forms.TextBox();
            this.TB_led_sizeX = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.TB_led_startY = new System.Windows.Forms.TextBox();
            this.TB_led_startX = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.label12 = new System.Windows.Forms.Label();
            this.GB_Preview = new System.Windows.Forms.GroupBox();
            this.BT_Preview = new System.Windows.Forms.Button();
            this.NUM_Scale = new System.Windows.Forms.NumericUpDown();
            this.label13 = new System.Windows.Forms.Label();
            this.TB_ResY = new System.Windows.Forms.TextBox();
            this.TB_ResX = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.BT_Gen = new System.Windows.Forms.Button();
            this.TB_Config = new System.Windows.Forms.TextBox();
            this.BT_Save = new System.Windows.Forms.Button();
            this.BT_Load = new System.Windows.Forms.Button();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.TB_Head = new System.Windows.Forms.TextBox();
            this.RB_Ws = new System.Windows.Forms.RadioButton();
            this.RB_Wm = new System.Windows.Forms.RadioButton();
            this.RB_Wl = new System.Windows.Forms.RadioButton();
            this.label14 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.TB_totaleds = new System.Windows.Forms.TextBox();
            this.GB_Add.SuspendLayout();
            this.GB_Led.SuspendLayout();
            this.GB_Preview.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Scale)).BeginInit();
            this.SuspendLayout();
            // 
            // GB_Add
            // 
            this.GB_Add.Controls.Add(this.BT_DeleteSel);
            this.GB_Add.Controls.Add(this.BT_Auto);
            this.GB_Add.Controls.Add(this.BT_Y_L);
            this.GB_Add.Controls.Add(this.BT_Y_P);
            this.GB_Add.Controls.Add(this.BT_X_L);
            this.GB_Add.Controls.Add(this.BT_X_P);
            this.GB_Add.Controls.Add(this.BT_Delete);
            this.GB_Add.Controls.Add(this.TB_NLeds);
            this.GB_Add.Controls.Add(this.label6);
            this.GB_Add.Controls.Add(this.label5);
            this.GB_Add.Controls.Add(this.RB_Down);
            this.GB_Add.Controls.Add(this.RB_Up);
            this.GB_Add.Controls.Add(this.RB_Right);
            this.GB_Add.Controls.Add(this.RB_Left);
            this.GB_Add.Controls.Add(this.TB_SizeY);
            this.GB_Add.Controls.Add(this.TB_SizeX);
            this.GB_Add.Controls.Add(this.label3);
            this.GB_Add.Controls.Add(this.label4);
            this.GB_Add.Controls.Add(this.TB_StartY);
            this.GB_Add.Controls.Add(this.TB_StartX);
            this.GB_Add.Controls.Add(this.label2);
            this.GB_Add.Controls.Add(this.label1);
            this.GB_Add.Controls.Add(this.BT_Add);
            this.GB_Add.Location = new System.Drawing.Point(15, 12);
            this.GB_Add.Name = "GB_Add";
            this.GB_Add.Size = new System.Drawing.Size(206, 143);
            this.GB_Add.TabIndex = 0;
            this.GB_Add.TabStop = false;
            this.GB_Add.Text = "Leds";
            // 
            // BT_DeleteSel
            // 
            this.BT_DeleteSel.Location = new System.Drawing.Point(114, 116);
            this.BT_DeleteSel.Name = "BT_DeleteSel";
            this.BT_DeleteSel.Size = new System.Drawing.Size(79, 20);
            this.BT_DeleteSel.TabIndex = 22;
            this.BT_DeleteSel.Text = "Delete Last";
            this.BT_DeleteSel.UseVisualStyleBackColor = true;
            this.BT_DeleteSel.Click += new System.EventHandler(this.BT_DeleteSel_Click);
            // 
            // BT_Auto
            // 
            this.BT_Auto.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Auto.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_Auto.Location = new System.Drawing.Point(31, 68);
            this.BT_Auto.Name = "BT_Auto";
            this.BT_Auto.Size = new System.Drawing.Size(16, 14);
            this.BT_Auto.TabIndex = 21;
            this.BT_Auto.Text = "A";
            this.BT_Auto.UseVisualStyleBackColor = true;
            this.BT_Auto.Click += new System.EventHandler(this.BT_Auto_Click);
            // 
            // BT_Y_L
            // 
            this.BT_Y_L.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Y_L.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_Y_L.Location = new System.Drawing.Point(127, 5);
            this.BT_Y_L.Name = "BT_Y_L";
            this.BT_Y_L.Size = new System.Drawing.Size(16, 14);
            this.BT_Y_L.TabIndex = 19;
            this.BT_Y_L.Text = "-";
            this.BT_Y_L.UseVisualStyleBackColor = true;
            this.BT_Y_L.Click += new System.EventHandler(this.BT_Y_L_Click);
            // 
            // BT_Y_P
            // 
            this.BT_Y_P.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_Y_P.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_Y_P.Location = new System.Drawing.Point(190, 5);
            this.BT_Y_P.Name = "BT_Y_P";
            this.BT_Y_P.Size = new System.Drawing.Size(16, 14);
            this.BT_Y_P.TabIndex = 20;
            this.BT_Y_P.Text = "+";
            this.BT_Y_P.UseVisualStyleBackColor = true;
            this.BT_Y_P.Click += new System.EventHandler(this.BT_Y_P_Click);
            // 
            // BT_X_L
            // 
            this.BT_X_L.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_X_L.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_X_L.Location = new System.Drawing.Point(42, 5);
            this.BT_X_L.Name = "BT_X_L";
            this.BT_X_L.Size = new System.Drawing.Size(16, 14);
            this.BT_X_L.TabIndex = 6;
            this.BT_X_L.Text = "-";
            this.BT_X_L.UseVisualStyleBackColor = true;
            this.BT_X_L.Click += new System.EventHandler(this.BT_X_L_Click);
            // 
            // BT_X_P
            // 
            this.BT_X_P.Cursor = System.Windows.Forms.Cursors.Default;
            this.BT_X_P.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.BT_X_P.Location = new System.Drawing.Point(105, 5);
            this.BT_X_P.Name = "BT_X_P";
            this.BT_X_P.Size = new System.Drawing.Size(16, 14);
            this.BT_X_P.TabIndex = 7;
            this.BT_X_P.Text = "+";
            this.BT_X_P.UseVisualStyleBackColor = true;
            this.BT_X_P.Click += new System.EventHandler(this.BT_X_P_Click);
            // 
            // BT_Delete
            // 
            this.BT_Delete.Location = new System.Drawing.Point(11, 116);
            this.BT_Delete.Name = "BT_Delete";
            this.BT_Delete.Size = new System.Drawing.Size(97, 20);
            this.BT_Delete.TabIndex = 18;
            this.BT_Delete.Text = "Delete All";
            this.BT_Delete.UseVisualStyleBackColor = true;
            this.BT_Delete.Click += new System.EventHandler(this.BT_Delete_Click);
            // 
            // TB_NLeds
            // 
            this.TB_NLeds.Location = new System.Drawing.Point(53, 90);
            this.TB_NLeds.Name = "TB_NLeds";
            this.TB_NLeds.Size = new System.Drawing.Size(55, 20);
            this.TB_NLeds.TabIndex = 15;
            this.TB_NLeds.Text = "10";
            this.TB_NLeds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_NLeds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_NLeds_KeyPress);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(6, 94);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(41, 13);
            this.label6.TabIndex = 14;
            this.label6.Text = "NLeds:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(7, 68);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(23, 13);
            this.label5.TabIndex = 13;
            this.label5.Text = "Dir:";
            // 
            // RB_Down
            // 
            this.RB_Down.AutoSize = true;
            this.RB_Down.Location = new System.Drawing.Point(162, 67);
            this.RB_Down.Name = "RB_Down";
            this.RB_Down.Size = new System.Drawing.Size(31, 17);
            this.RB_Down.TabIndex = 12;
            this.RB_Down.Text = "v";
            this.RB_Down.UseVisualStyleBackColor = true;
            // 
            // RB_Up
            // 
            this.RB_Up.AutoSize = true;
            this.RB_Up.Location = new System.Drawing.Point(127, 67);
            this.RB_Up.Name = "RB_Up";
            this.RB_Up.Size = new System.Drawing.Size(31, 17);
            this.RB_Up.TabIndex = 11;
            this.RB_Up.Text = "^";
            this.RB_Up.UseVisualStyleBackColor = true;
            // 
            // RB_Right
            // 
            this.RB_Right.AutoSize = true;
            this.RB_Right.Checked = true;
            this.RB_Right.Location = new System.Drawing.Point(90, 67);
            this.RB_Right.Name = "RB_Right";
            this.RB_Right.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.RB_Right.Size = new System.Drawing.Size(31, 17);
            this.RB_Right.TabIndex = 10;
            this.RB_Right.TabStop = true;
            this.RB_Right.Text = ">";
            this.RB_Right.UseVisualStyleBackColor = true;
            // 
            // RB_Left
            // 
            this.RB_Left.AutoSize = true;
            this.RB_Left.Location = new System.Drawing.Point(53, 67);
            this.RB_Left.Name = "RB_Left";
            this.RB_Left.Size = new System.Drawing.Size(31, 17);
            this.RB_Left.TabIndex = 9;
            this.RB_Left.Text = "<";
            this.RB_Left.UseVisualStyleBackColor = true;
            // 
            // TB_SizeY
            // 
            this.TB_SizeY.Location = new System.Drawing.Point(138, 38);
            this.TB_SizeY.Name = "TB_SizeY";
            this.TB_SizeY.Size = new System.Drawing.Size(55, 20);
            this.TB_SizeY.TabIndex = 8;
            this.TB_SizeY.Text = "60";
            this.TB_SizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_SizeY.TextChanged += new System.EventHandler(this.TB_SizeY_TextChanged);
            this.TB_SizeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SizeY_KeyPress);
            // 
            // TB_SizeX
            // 
            this.TB_SizeX.Location = new System.Drawing.Point(54, 38);
            this.TB_SizeX.Name = "TB_SizeX";
            this.TB_SizeX.Size = new System.Drawing.Size(55, 20);
            this.TB_SizeX.TabIndex = 7;
            this.TB_SizeX.Text = "60";
            this.TB_SizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_SizeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_SizeX_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(116, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(17, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Y:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(7, 42);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(43, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Size  X:";
            // 
            // TB_StartY
            // 
            this.TB_StartY.Location = new System.Drawing.Point(138, 13);
            this.TB_StartY.Name = "TB_StartY";
            this.TB_StartY.Size = new System.Drawing.Size(55, 20);
            this.TB_StartY.TabIndex = 4;
            this.TB_StartY.Text = "0";
            this.TB_StartY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_StartY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_StartY_KeyPress);
            // 
            // TB_StartX
            // 
            this.TB_StartX.Location = new System.Drawing.Point(54, 13);
            this.TB_StartX.Name = "TB_StartX";
            this.TB_StartX.Size = new System.Drawing.Size(55, 20);
            this.TB_StartX.TabIndex = 3;
            this.TB_StartX.Text = "0";
            this.TB_StartX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_StartX.TextChanged += new System.EventHandler(this.TB_StartX_TextChanged);
            this.TB_StartX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_StartX_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(116, 17);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(17, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Y:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(7, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(42, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Start X:";
            // 
            // BT_Add
            // 
            this.BT_Add.Location = new System.Drawing.Point(114, 90);
            this.BT_Add.Name = "BT_Add";
            this.BT_Add.Size = new System.Drawing.Size(79, 20);
            this.BT_Add.TabIndex = 16;
            this.BT_Add.Text = "Add";
            this.BT_Add.UseVisualStyleBackColor = true;
            this.BT_Add.Click += new System.EventHandler(this.BT_Add_Click);
            // 
            // LB_Leds
            // 
            this.LB_Leds.FormattingEnabled = true;
            this.LB_Leds.Location = new System.Drawing.Point(227, 12);
            this.LB_Leds.Name = "LB_Leds";
            this.LB_Leds.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.LB_Leds.SelectionMode = System.Windows.Forms.SelectionMode.MultiExtended;
            this.LB_Leds.Size = new System.Drawing.Size(92, 290);
            this.LB_Leds.TabIndex = 1;
            this.LB_Leds.SelectedIndexChanged += new System.EventHandler(this.LB_Leds_SelectedIndexChanged);
            // 
            // GB_Led
            // 
            this.GB_Led.Controls.Add(this.TB_led_sizeY);
            this.GB_Led.Controls.Add(this.TB_led_sizeX);
            this.GB_Led.Controls.Add(this.label9);
            this.GB_Led.Controls.Add(this.label10);
            this.GB_Led.Controls.Add(this.TB_led_startY);
            this.GB_Led.Controls.Add(this.TB_led_startX);
            this.GB_Led.Controls.Add(this.label11);
            this.GB_Led.Controls.Add(this.label12);
            this.GB_Led.Enabled = false;
            this.GB_Led.Location = new System.Drawing.Point(15, 161);
            this.GB_Led.Name = "GB_Led";
            this.GB_Led.Size = new System.Drawing.Size(206, 69);
            this.GB_Led.TabIndex = 2;
            this.GB_Led.TabStop = false;
            this.GB_Led.Text = "LED[NS]";
            // 
            // TB_led_sizeY
            // 
            this.TB_led_sizeY.Location = new System.Drawing.Point(138, 38);
            this.TB_led_sizeY.Name = "TB_led_sizeY";
            this.TB_led_sizeY.Size = new System.Drawing.Size(55, 20);
            this.TB_led_sizeY.TabIndex = 8;
            this.TB_led_sizeY.Text = "0";
            this.TB_led_sizeY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_led_sizeY.TextChanged += new System.EventHandler(this.TB_led_sizeY_TextChanged);
            this.TB_led_sizeY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_led_sizeY_KeyPress);
            // 
            // TB_led_sizeX
            // 
            this.TB_led_sizeX.Location = new System.Drawing.Point(54, 38);
            this.TB_led_sizeX.Name = "TB_led_sizeX";
            this.TB_led_sizeX.Size = new System.Drawing.Size(55, 20);
            this.TB_led_sizeX.TabIndex = 7;
            this.TB_led_sizeX.Text = "0";
            this.TB_led_sizeX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_led_sizeX.TextChanged += new System.EventHandler(this.TB_led_sizeX_TextChanged);
            this.TB_led_sizeX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_led_sizeX_KeyPress);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(116, 42);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(17, 13);
            this.label9.TabIndex = 6;
            this.label9.Text = "Y:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(7, 42);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(43, 13);
            this.label10.TabIndex = 5;
            this.label10.Text = "Size  X:";
            // 
            // TB_led_startY
            // 
            this.TB_led_startY.Location = new System.Drawing.Point(138, 13);
            this.TB_led_startY.Name = "TB_led_startY";
            this.TB_led_startY.Size = new System.Drawing.Size(55, 20);
            this.TB_led_startY.TabIndex = 4;
            this.TB_led_startY.Text = "0";
            this.TB_led_startY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_led_startY.TextChanged += new System.EventHandler(this.TB_led_startY_TextChanged);
            this.TB_led_startY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_led_startY_KeyPress);
            // 
            // TB_led_startX
            // 
            this.TB_led_startX.Location = new System.Drawing.Point(54, 13);
            this.TB_led_startX.Name = "TB_led_startX";
            this.TB_led_startX.Size = new System.Drawing.Size(55, 20);
            this.TB_led_startX.TabIndex = 3;
            this.TB_led_startX.Text = "0";
            this.TB_led_startX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_led_startX.TextChanged += new System.EventHandler(this.TB_led_startX_TextChanged);
            this.TB_led_startX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_led_startX_KeyPress);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(116, 17);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(17, 13);
            this.label11.TabIndex = 1;
            this.label11.Text = "Y:";
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(7, 17);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(42, 13);
            this.label12.TabIndex = 0;
            this.label12.Text = "Start X:";
            // 
            // GB_Preview
            // 
            this.GB_Preview.Controls.Add(this.BT_Preview);
            this.GB_Preview.Controls.Add(this.NUM_Scale);
            this.GB_Preview.Controls.Add(this.label13);
            this.GB_Preview.Controls.Add(this.TB_ResY);
            this.GB_Preview.Controls.Add(this.TB_ResX);
            this.GB_Preview.Controls.Add(this.label7);
            this.GB_Preview.Controls.Add(this.label8);
            this.GB_Preview.Location = new System.Drawing.Point(15, 236);
            this.GB_Preview.Name = "GB_Preview";
            this.GB_Preview.Size = new System.Drawing.Size(206, 63);
            this.GB_Preview.TabIndex = 3;
            this.GB_Preview.TabStop = false;
            this.GB_Preview.Text = "Preview";
            // 
            // BT_Preview
            // 
            this.BT_Preview.Location = new System.Drawing.Point(119, 37);
            this.BT_Preview.Name = "BT_Preview";
            this.BT_Preview.Size = new System.Drawing.Size(75, 20);
            this.BT_Preview.TabIndex = 12;
            this.BT_Preview.Text = "SAVE!";
            this.BT_Preview.UseVisualStyleBackColor = true;
            this.BT_Preview.Click += new System.EventHandler(this.BT_Preview_Click);
            // 
            // NUM_Scale
            // 
            this.NUM_Scale.Location = new System.Drawing.Point(55, 37);
            this.NUM_Scale.Name = "NUM_Scale";
            this.NUM_Scale.RightToLeft = System.Windows.Forms.RightToLeft.Yes;
            this.NUM_Scale.Size = new System.Drawing.Size(55, 20);
            this.NUM_Scale.TabIndex = 11;
            this.NUM_Scale.TextAlign = System.Windows.Forms.HorizontalAlignment.Right;
            this.NUM_Scale.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(8, 41);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(37, 13);
            this.label13.TabIndex = 9;
            this.label13.Text = "Scale:";
            // 
            // TB_ResY
            // 
            this.TB_ResY.Location = new System.Drawing.Point(139, 12);
            this.TB_ResY.Name = "TB_ResY";
            this.TB_ResY.Size = new System.Drawing.Size(55, 20);
            this.TB_ResY.TabIndex = 8;
            this.TB_ResY.Text = "1080";
            this.TB_ResY.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResY.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ResY_KeyPress);
            // 
            // TB_ResX
            // 
            this.TB_ResX.Location = new System.Drawing.Point(55, 12);
            this.TB_ResX.Name = "TB_ResX";
            this.TB_ResX.Size = new System.Drawing.Size(55, 20);
            this.TB_ResX.TabIndex = 7;
            this.TB_ResX.Text = "1920";
            this.TB_ResX.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_ResX.TextChanged += new System.EventHandler(this.TB_ResX_TextChanged);
            this.TB_ResX.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.TB_ResX_KeyPress);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(117, 16);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(17, 13);
            this.label7.TabIndex = 6;
            this.label7.Text = "Y:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(8, 16);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(39, 13);
            this.label8.TabIndex = 5;
            this.label8.Text = "Res X:";
            // 
            // BT_Gen
            // 
            this.BT_Gen.Location = new System.Drawing.Point(227, 305);
            this.BT_Gen.Name = "BT_Gen";
            this.BT_Gen.Size = new System.Drawing.Size(92, 23);
            this.BT_Gen.TabIndex = 4;
            this.BT_Gen.Text = "Generate";
            this.BT_Gen.UseVisualStyleBackColor = true;
            this.BT_Gen.Click += new System.EventHandler(this.button1_Click);
            // 
            // TB_Config
            // 
            this.TB_Config.Location = new System.Drawing.Point(344, 12);
            this.TB_Config.Multiline = true;
            this.TB_Config.Name = "TB_Config";
            this.TB_Config.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Config.Size = new System.Drawing.Size(328, 290);
            this.TB_Config.TabIndex = 5;
            // 
            // BT_Save
            // 
            this.BT_Save.Location = new System.Drawing.Point(562, 305);
            this.BT_Save.Name = "BT_Save";
            this.BT_Save.Size = new System.Drawing.Size(110, 23);
            this.BT_Save.TabIndex = 7;
            this.BT_Save.Text = "Save";
            this.BT_Save.UseVisualStyleBackColor = true;
            this.BT_Save.Click += new System.EventHandler(this.BT_Save_Click);
            // 
            // BT_Load
            // 
            this.BT_Load.Location = new System.Drawing.Point(451, 305);
            this.BT_Load.Name = "BT_Load";
            this.BT_Load.Size = new System.Drawing.Size(110, 23);
            this.BT_Load.TabIndex = 8;
            this.BT_Load.Text = "Open && Load";
            this.BT_Load.UseVisualStyleBackColor = true;
            this.BT_Load.Click += new System.EventHandler(this.BT_Load_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFile";
            // 
            // TB_Head
            // 
            this.TB_Head.Location = new System.Drawing.Point(694, 12);
            this.TB_Head.Multiline = true;
            this.TB_Head.Name = "TB_Head";
            this.TB_Head.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.TB_Head.Size = new System.Drawing.Size(328, 290);
            this.TB_Head.TabIndex = 9;
            this.TB_Head.Text = resources.GetString("TB_Head.Text");
            // 
            // RB_Ws
            // 
            this.RB_Ws.AutoSize = true;
            this.RB_Ws.Location = new System.Drawing.Point(71, 305);
            this.RB_Ws.Name = "RB_Ws";
            this.RB_Ws.Size = new System.Drawing.Size(47, 17);
            this.RB_Ws.TabIndex = 10;
            this.RB_Ws.Text = "Little";
            this.RB_Ws.UseVisualStyleBackColor = true;
            this.RB_Ws.CheckedChanged += new System.EventHandler(this.RB_Ws_CheckedChanged);
            // 
            // RB_Wm
            // 
            this.RB_Wm.AutoSize = true;
            this.RB_Wm.Checked = true;
            this.RB_Wm.Location = new System.Drawing.Point(124, 305);
            this.RB_Wm.Name = "RB_Wm";
            this.RB_Wm.Size = new System.Drawing.Size(42, 17);
            this.RB_Wm.TabIndex = 11;
            this.RB_Wm.TabStop = true;
            this.RB_Wm.Text = "Mid";
            this.RB_Wm.UseVisualStyleBackColor = true;
            this.RB_Wm.CheckedChanged += new System.EventHandler(this.RB_Wm_CheckedChanged);
            // 
            // RB_Wl
            // 
            this.RB_Wl.AutoSize = true;
            this.RB_Wl.Location = new System.Drawing.Point(172, 305);
            this.RB_Wl.Name = "RB_Wl";
            this.RB_Wl.Size = new System.Drawing.Size(36, 17);
            this.RB_Wl.TabIndex = 12;
            this.RB_Wl.Text = "All";
            this.RB_Wl.UseVisualStyleBackColor = true;
            this.RB_Wl.CheckedChanged += new System.EventHandler(this.RB_Wl_CheckedChanged);
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(16, 307);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(49, 13);
            this.label14.TabIndex = 13;
            this.label14.Text = "Window:";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(341, 310);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(60, 13);
            this.label15.TabIndex = 14;
            this.label15.Text = "Total Leds:";
            // 
            // TB_totaleds
            // 
            this.TB_totaleds.Location = new System.Drawing.Point(404, 306);
            this.TB_totaleds.Name = "TB_totaleds";
            this.TB_totaleds.Size = new System.Drawing.Size(38, 20);
            this.TB_totaleds.TabIndex = 15;
            this.TB_totaleds.Text = "0";
            this.TB_totaleds.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.TB_totaleds.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            // 
            // F_Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1034, 335);
            this.Controls.Add(this.TB_totaleds);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.RB_Wl);
            this.Controls.Add(this.RB_Wm);
            this.Controls.Add(this.RB_Ws);
            this.Controls.Add(this.TB_Head);
            this.Controls.Add(this.BT_Load);
            this.Controls.Add(this.BT_Save);
            this.Controls.Add(this.TB_Config);
            this.Controls.Add(this.BT_Gen);
            this.Controls.Add(this.GB_Preview);
            this.Controls.Add(this.GB_Led);
            this.Controls.Add(this.LB_Leds);
            this.Controls.Add(this.GB_Add);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "F_Main";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Prismatik LedStrip Configuration 0.4 [Unrealmitch@gmail.com ®]";
            this.Load += new System.EventHandler(this.F_Main_Load);
            this.GB_Add.ResumeLayout(false);
            this.GB_Add.PerformLayout();
            this.GB_Led.ResumeLayout(false);
            this.GB_Led.PerformLayout();
            this.GB_Preview.ResumeLayout(false);
            this.GB_Preview.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.NUM_Scale)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox GB_Add;
        private System.Windows.Forms.Button BT_Add;
        private System.Windows.Forms.TextBox TB_NLeds;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.RadioButton RB_Down;
        private System.Windows.Forms.RadioButton RB_Up;
        private System.Windows.Forms.RadioButton RB_Right;
        private System.Windows.Forms.RadioButton RB_Left;
        private System.Windows.Forms.TextBox TB_SizeY;
        private System.Windows.Forms.TextBox TB_SizeX;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox TB_StartY;
        private System.Windows.Forms.TextBox TB_StartX;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ListBox LB_Leds;
        private System.Windows.Forms.GroupBox GB_Led;
        private System.Windows.Forms.TextBox TB_led_sizeY;
        private System.Windows.Forms.TextBox TB_led_sizeX;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox TB_led_startY;
        private System.Windows.Forms.TextBox TB_led_startX;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.GroupBox GB_Preview;
        private System.Windows.Forms.Button BT_Preview;
        private System.Windows.Forms.NumericUpDown NUM_Scale;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox TB_ResY;
        private System.Windows.Forms.TextBox TB_ResX;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button BT_Gen;
        private System.Windows.Forms.TextBox TB_Config;
        private System.Windows.Forms.Button BT_Delete;
        private System.Windows.Forms.Button BT_Auto;
        private System.Windows.Forms.Button BT_Y_L;
        private System.Windows.Forms.Button BT_Y_P;
        private System.Windows.Forms.Button BT_X_L;
        private System.Windows.Forms.Button BT_X_P;
        private System.Windows.Forms.Button BT_DeleteSel;
        private System.Windows.Forms.Button BT_Save;
        private System.Windows.Forms.Button BT_Load;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.TextBox TB_Head;
        private System.Windows.Forms.RadioButton RB_Ws;
        private System.Windows.Forms.RadioButton RB_Wm;
        private System.Windows.Forms.RadioButton RB_Wl;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox TB_totaleds;
    }
}