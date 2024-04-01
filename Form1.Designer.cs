namespace testvar
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
            components = new System.ComponentModel.Container();
            dataGridView1 = new DataGridView();
            contextMenuStrip4 = new ContextMenuStrip(components);
            удалитьТестToolStripMenuItem = new ToolStripMenuItem();
            добавитьТестToolStripMenuItem = new ToolStripMenuItem();
            изменитьТестToolStripMenuItem = new ToolStripMenuItem();
            dataGridView2 = new DataGridView();
            contextMenuStrip5 = new ContextMenuStrip(components);
            удалитьВопросToolStripMenuItem = new ToolStripMenuItem();
            добавитьВопросToolStripMenuItem = new ToolStripMenuItem();
            изменитьВопросToolStripMenuItem = new ToolStripMenuItem();
            dataGridView3 = new DataGridView();
            contextMenuStrip6 = new ContextMenuStrip(components);
            удалитьОтветToolStripMenuItem = new ToolStripMenuItem();
            добавитьОтветToolStripMenuItem = new ToolStripMenuItem();
            зменитьОтветыToolStripMenuItem = new ToolStripMenuItem();
            tableLayoutPanel1 = new TableLayoutPanel();
            textBox5 = new TextBox();
            textBox3 = new TextBox();
            label1 = new Label();
            label5 = new Label();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            textBox8 = new TextBox();
            textBox7 = new TextBox();
            textBox6 = new TextBox();
            label2 = new Label();
            label4 = new Label();
            label3 = new Label();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            textBox4 = new TextBox();
            comboBox2 = new ComboBox();
            radioButton1 = new RadioButton();
            radioButton2 = new RadioButton();
            radioButton3 = new RadioButton();
            radioButton4 = new RadioButton();
            button1 = new Button();
            button2 = new Button();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            contextMenuStrip4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            contextMenuStrip5.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)dataGridView3).BeginInit();
            contextMenuStrip6.SuspendLayout();
            tableLayoutPanel1.SuspendLayout();
            SuspendLayout();
            // 
            // dataGridView1
            // 
            dataGridView1.AllowUserToAddRows = false;
            dataGridView1.AllowUserToDeleteRows = false;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView1, 2);
            dataGridView1.ContextMenuStrip = contextMenuStrip4;
            dataGridView1.Dock = DockStyle.Fill;
            dataGridView1.Location = new Point(3, 3);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.Size = new Size(234, 324);
            dataGridView1.TabIndex = 0;
            dataGridView1.CellMouseClick += dataGridView1_CellMouseClick;
            dataGridView1.CellMouseDown += dataGridView1_CellMouseDown;
            // 
            // contextMenuStrip4
            // 
            contextMenuStrip4.Items.AddRange(new ToolStripItem[] { удалитьТестToolStripMenuItem, добавитьТестToolStripMenuItem, изменитьТестToolStripMenuItem });
            contextMenuStrip4.Name = "contextMenuStrip4";
            contextMenuStrip4.Size = new Size(154, 70);
            // 
            // удалитьТестToolStripMenuItem
            // 
            удалитьТестToolStripMenuItem.Name = "удалитьТестToolStripMenuItem";
            удалитьТестToolStripMenuItem.Size = new Size(153, 22);
            удалитьТестToolStripMenuItem.Text = "Удалить Тест";
            удалитьТестToolStripMenuItem.Click += удалитьТестToolStripMenuItem_Click;
            // 
            // добавитьТестToolStripMenuItem
            // 
            добавитьТестToolStripMenuItem.Name = "добавитьТестToolStripMenuItem";
            добавитьТестToolStripMenuItem.Size = new Size(153, 22);
            добавитьТестToolStripMenuItem.Text = "Добавить тест";
            добавитьТестToolStripMenuItem.Click += добавитьТестToolStripMenuItem_Click;
            // 
            // изменитьТестToolStripMenuItem
            // 
            изменитьТестToolStripMenuItem.Name = "изменитьТестToolStripMenuItem";
            изменитьТестToolStripMenuItem.Size = new Size(153, 22);
            изменитьТестToolStripMenuItem.Text = "Изменить тест";
            изменитьТестToolStripMenuItem.Click += изменитьТестToolStripMenuItem_Click;
            // 
            // dataGridView2
            // 
            dataGridView2.AllowUserToAddRows = false;
            dataGridView2.AllowUserToDeleteRows = false;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView2, 3);
            dataGridView2.ContextMenuStrip = contextMenuStrip5;
            dataGridView2.Dock = DockStyle.Fill;
            dataGridView2.Location = new Point(243, 3);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(330, 324);
            dataGridView2.TabIndex = 1;
            dataGridView2.CellMouseClick += dataGridView2_CellMouseClick;
            dataGridView2.CellMouseDown += dataGridView2_CellMouseDown;
            // 
            // contextMenuStrip5
            // 
            contextMenuStrip5.Items.AddRange(new ToolStripItem[] { удалитьВопросToolStripMenuItem, добавитьВопросToolStripMenuItem, изменитьВопросToolStripMenuItem });
            contextMenuStrip5.Name = "contextMenuStrip5";
            contextMenuStrip5.Size = new Size(172, 70);
            // 
            // удалитьВопросToolStripMenuItem
            // 
            удалитьВопросToolStripMenuItem.Name = "удалитьВопросToolStripMenuItem";
            удалитьВопросToolStripMenuItem.Size = new Size(171, 22);
            удалитьВопросToolStripMenuItem.Text = "Удалить вопрос";
            удалитьВопросToolStripMenuItem.Click += удалитьВопросToolStripMenuItem_Click;
            // 
            // добавитьВопросToolStripMenuItem
            // 
            добавитьВопросToolStripMenuItem.Name = "добавитьВопросToolStripMenuItem";
            добавитьВопросToolStripMenuItem.Size = new Size(171, 22);
            добавитьВопросToolStripMenuItem.Text = "Добавить вопрос";
            добавитьВопросToolStripMenuItem.Click += добавитьВопросToolStripMenuItem_Click;
            // 
            // изменитьВопросToolStripMenuItem
            // 
            изменитьВопросToolStripMenuItem.Name = "изменитьВопросToolStripMenuItem";
            изменитьВопросToolStripMenuItem.Size = new Size(171, 22);
            изменитьВопросToolStripMenuItem.Text = "Изменить вопрос";
            изменитьВопросToolStripMenuItem.Click += изменитьВопросToolStripMenuItem_Click;
            // 
            // dataGridView3
            // 
            dataGridView3.AllowUserToAddRows = false;
            dataGridView3.AllowUserToDeleteRows = false;
            dataGridView3.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            tableLayoutPanel1.SetColumnSpan(dataGridView3, 4);
            dataGridView3.ContextMenuStrip = contextMenuStrip6;
            dataGridView3.Dock = DockStyle.Fill;
            dataGridView3.Location = new Point(579, 3);
            dataGridView3.Name = "dataGridView3";
            dataGridView3.Size = new Size(380, 324);
            dataGridView3.TabIndex = 2;
            dataGridView3.CellMouseClick += dataGridView3_CellMouseClick;
            dataGridView3.CellMouseDown += dataGridView3_CellMouseDown;
            // 
            // contextMenuStrip6
            // 
            contextMenuStrip6.Items.AddRange(new ToolStripItem[] { удалитьОтветToolStripMenuItem, добавитьОтветToolStripMenuItem, зменитьОтветыToolStripMenuItem });
            contextMenuStrip6.Name = "contextMenuStrip6";
            contextMenuStrip6.Size = new Size(163, 70);
            // 
            // удалитьОтветToolStripMenuItem
            // 
            удалитьОтветToolStripMenuItem.Name = "удалитьОтветToolStripMenuItem";
            удалитьОтветToolStripMenuItem.Size = new Size(162, 22);
            удалитьОтветToolStripMenuItem.Text = "Удалить ответ";
            удалитьОтветToolStripMenuItem.Click += удалитьОтветToolStripMenuItem_Click;
            // 
            // добавитьОтветToolStripMenuItem
            // 
            добавитьОтветToolStripMenuItem.Name = "добавитьОтветToolStripMenuItem";
            добавитьОтветToolStripMenuItem.Size = new Size(162, 22);
            добавитьОтветToolStripMenuItem.Text = "Добавить ответ";
            добавитьОтветToolStripMenuItem.Click += добавитьОтветToolStripMenuItem_Click;
            // 
            // зменитьОтветыToolStripMenuItem
            // 
            зменитьОтветыToolStripMenuItem.Name = "зменитьОтветыToolStripMenuItem";
            зменитьОтветыToolStripMenuItem.Size = new Size(162, 22);
            зменитьОтветыToolStripMenuItem.Text = "Зменить ответы";
            зменитьОтветыToolStripMenuItem.Click += зменитьОтветыToolStripMenuItem_Click;
            // 
            // tableLayoutPanel1
            // 
            tableLayoutPanel1.ColumnCount = 9;
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 15F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.ColumnStyles.Add(new ColumnStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Controls.Add(textBox5, 5, 1);
            tableLayoutPanel1.Controls.Add(textBox3, 3, 1);
            tableLayoutPanel1.Controls.Add(dataGridView1, 0, 0);
            tableLayoutPanel1.Controls.Add(label1, 0, 1);
            tableLayoutPanel1.Controls.Add(label5, 4, 1);
            tableLayoutPanel1.Controls.Add(textBox1, 1, 1);
            tableLayoutPanel1.Controls.Add(label8, 4, 6);
            tableLayoutPanel1.Controls.Add(label7, 4, 5);
            tableLayoutPanel1.Controls.Add(label6, 4, 3);
            tableLayoutPanel1.Controls.Add(textBox8, 5, 6);
            tableLayoutPanel1.Controls.Add(textBox7, 5, 5);
            tableLayoutPanel1.Controls.Add(textBox6, 5, 3);
            tableLayoutPanel1.Controls.Add(label2, 0, 3);
            tableLayoutPanel1.Controls.Add(label4, 2, 3);
            tableLayoutPanel1.Controls.Add(label3, 2, 1);
            tableLayoutPanel1.Controls.Add(textBox2, 1, 3);
            tableLayoutPanel1.Controls.Add(comboBox1, 1, 2);
            tableLayoutPanel1.Controls.Add(textBox4, 3, 3);
            tableLayoutPanel1.Controls.Add(comboBox2, 3, 2);
            tableLayoutPanel1.Controls.Add(radioButton1, 6, 1);
            tableLayoutPanel1.Controls.Add(radioButton2, 6, 3);
            tableLayoutPanel1.Controls.Add(radioButton3, 6, 5);
            tableLayoutPanel1.Controls.Add(radioButton4, 6, 6);
            tableLayoutPanel1.Controls.Add(dataGridView2, 2, 0);
            tableLayoutPanel1.Controls.Add(dataGridView3, 5, 0);
            tableLayoutPanel1.Controls.Add(button1, 8, 5);
            tableLayoutPanel1.Controls.Add(button2, 8, 6);
            tableLayoutPanel1.Dock = DockStyle.Fill;
            tableLayoutPanel1.Location = new Point(0, 0);
            tableLayoutPanel1.Name = "tableLayoutPanel1";
            tableLayoutPanel1.RowCount = 7;
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 60F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 5F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.RowStyles.Add(new RowStyle(SizeType.Percent, 10F));
            tableLayoutPanel1.Size = new Size(962, 551);
            tableLayoutPanel1.TabIndex = 3;
            // 
            // textBox5
            // 
            textBox5.Dock = DockStyle.Fill;
            textBox5.Enabled = false;
            textBox5.Location = new Point(579, 333);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(138, 23);
            textBox5.TabIndex = 15;
            textBox5.Visible = false;
            // 
            // textBox3
            // 
            textBox3.Dock = DockStyle.Fill;
            textBox3.Enabled = false;
            textBox3.Location = new Point(339, 333);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(138, 23);
            textBox3.TabIndex = 13;
            textBox3.Visible = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Dock = DockStyle.Fill;
            label1.Enabled = false;
            label1.Font = new Font("Times New Roman", 12F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label1.Location = new Point(3, 330);
            label1.Name = "label1";
            tableLayoutPanel1.SetRowSpan(label1, 2);
            label1.Size = new Size(90, 54);
            label1.TabIndex = 3;
            label1.Text = "Номер теста";
            label1.TextAlign = ContentAlignment.MiddleCenter;
            label1.Visible = false;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Dock = DockStyle.Fill;
            label5.Enabled = false;
            label5.Font = new Font("Times New Roman", 11.25F);
            label5.Location = new Point(483, 330);
            label5.Name = "label5";
            tableLayoutPanel1.SetRowSpan(label5, 2);
            label5.Size = new Size(90, 54);
            label5.TabIndex = 7;
            label5.Text = "Ответ 1";
            label5.TextAlign = ContentAlignment.TopCenter;
            label5.Visible = false;
            // 
            // textBox1
            // 
            textBox1.Dock = DockStyle.Fill;
            textBox1.Enabled = false;
            textBox1.Location = new Point(99, 333);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(138, 23);
            textBox1.TabIndex = 11;
            textBox1.Visible = false;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Dock = DockStyle.Fill;
            label8.Enabled = false;
            label8.Font = new Font("Times New Roman", 11.25F);
            label8.Location = new Point(483, 493);
            label8.Name = "label8";
            label8.Size = new Size(90, 58);
            label8.TabIndex = 10;
            label8.Text = "Ответ 4";
            label8.TextAlign = ContentAlignment.TopCenter;
            label8.Visible = false;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Dock = DockStyle.Fill;
            label7.Enabled = false;
            label7.Font = new Font("Times New Roman", 11.25F);
            label7.Location = new Point(483, 438);
            label7.Name = "label7";
            label7.Size = new Size(90, 55);
            label7.TabIndex = 9;
            label7.Text = "Ответ 3";
            label7.TextAlign = ContentAlignment.TopCenter;
            label7.Visible = false;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Dock = DockStyle.Fill;
            label6.Enabled = false;
            label6.Font = new Font("Times New Roman", 11.25F);
            label6.Location = new Point(483, 384);
            label6.Name = "label6";
            tableLayoutPanel1.SetRowSpan(label6, 2);
            label6.Size = new Size(90, 54);
            label6.TabIndex = 8;
            label6.Text = "Ответ 2";
            label6.TextAlign = ContentAlignment.TopCenter;
            label6.Visible = false;
            // 
            // textBox8
            // 
            textBox8.Dock = DockStyle.Fill;
            textBox8.Enabled = false;
            textBox8.Location = new Point(579, 496);
            textBox8.Name = "textBox8";
            textBox8.Size = new Size(138, 23);
            textBox8.TabIndex = 18;
            textBox8.Visible = false;
            // 
            // textBox7
            // 
            textBox7.Dock = DockStyle.Fill;
            textBox7.Enabled = false;
            textBox7.Location = new Point(579, 441);
            textBox7.Name = "textBox7";
            textBox7.Size = new Size(138, 23);
            textBox7.TabIndex = 17;
            textBox7.Visible = false;
            // 
            // textBox6
            // 
            textBox6.Dock = DockStyle.Fill;
            textBox6.Enabled = false;
            textBox6.Location = new Point(579, 387);
            textBox6.Name = "textBox6";
            tableLayoutPanel1.SetRowSpan(textBox6, 2);
            textBox6.Size = new Size(138, 23);
            textBox6.TabIndex = 16;
            textBox6.Visible = false;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Dock = DockStyle.Fill;
            label2.Enabled = false;
            label2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            label2.Location = new Point(3, 384);
            label2.Name = "label2";
            tableLayoutPanel1.SetRowSpan(label2, 2);
            label2.Size = new Size(90, 54);
            label2.TabIndex = 4;
            label2.Text = "Название теста";
            label2.TextAlign = ContentAlignment.TopCenter;
            label2.Visible = false;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Dock = DockStyle.Fill;
            label4.Enabled = false;
            label4.Font = new Font("Times New Roman", 11.25F);
            label4.Location = new Point(243, 384);
            label4.Name = "label4";
            tableLayoutPanel1.SetRowSpan(label4, 2);
            label4.Size = new Size(90, 54);
            label4.TabIndex = 6;
            label4.Text = "Вопрос";
            label4.TextAlign = ContentAlignment.TopCenter;
            label4.Visible = false;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Dock = DockStyle.Fill;
            label3.Enabled = false;
            label3.Font = new Font("Times New Roman", 11.25F);
            label3.Location = new Point(243, 330);
            label3.Name = "label3";
            tableLayoutPanel1.SetRowSpan(label3, 2);
            label3.Size = new Size(90, 54);
            label3.TabIndex = 5;
            label3.Text = "Номер вопроса";
            label3.TextAlign = ContentAlignment.MiddleCenter;
            label3.Visible = false;
            // 
            // textBox2
            // 
            textBox2.Dock = DockStyle.Fill;
            textBox2.Enabled = false;
            textBox2.Location = new Point(99, 387);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(138, 23);
            textBox2.TabIndex = 12;
            textBox2.Visible = false;
            // 
            // comboBox1
            // 
            comboBox1.Dock = DockStyle.Fill;
            comboBox1.Enabled = false;
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(99, 360);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(138, 23);
            comboBox1.TabIndex = 19;
            comboBox1.Visible = false;
            // 
            // textBox4
            // 
            textBox4.Dock = DockStyle.Fill;
            textBox4.Enabled = false;
            textBox4.Location = new Point(339, 387);
            textBox4.Name = "textBox4";
            textBox4.Size = new Size(138, 23);
            textBox4.TabIndex = 14;
            textBox4.Visible = false;
            // 
            // comboBox2
            // 
            comboBox2.Enabled = false;
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(339, 360);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(101, 23);
            comboBox2.TabIndex = 20;
            comboBox2.Visible = false;
            // 
            // radioButton1
            // 
            radioButton1.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(radioButton1, 2);
            radioButton1.Dock = DockStyle.Top;
            radioButton1.Enabled = false;
            radioButton1.Font = new Font("Times New Roman", 11.25F);
            radioButton1.Location = new Point(723, 333);
            radioButton1.Name = "radioButton1";
            tableLayoutPanel1.SetRowSpan(radioButton1, 2);
            radioButton1.Size = new Size(138, 21);
            radioButton1.TabIndex = 21;
            radioButton1.TabStop = true;
            radioButton1.Text = "Правильный ответ";
            radioButton1.UseVisualStyleBackColor = true;
            radioButton1.Visible = false;
            radioButton1.CheckedChanged += radioButton1_CheckedChanged;
            // 
            // radioButton2
            // 
            radioButton2.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(radioButton2, 2);
            radioButton2.Dock = DockStyle.Top;
            radioButton2.Enabled = false;
            radioButton2.Font = new Font("Times New Roman", 11.25F);
            radioButton2.Location = new Point(723, 387);
            radioButton2.Name = "radioButton2";
            tableLayoutPanel1.SetRowSpan(radioButton2, 2);
            radioButton2.Size = new Size(138, 21);
            radioButton2.TabIndex = 22;
            radioButton2.TabStop = true;
            radioButton2.Text = "Правильный ответ";
            radioButton2.UseVisualStyleBackColor = true;
            radioButton2.Visible = false;
            radioButton2.CheckedChanged += radioButton2_CheckedChanged;
            // 
            // radioButton3
            // 
            radioButton3.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(radioButton3, 2);
            radioButton3.Dock = DockStyle.Top;
            radioButton3.Enabled = false;
            radioButton3.Font = new Font("Times New Roman", 11.25F);
            radioButton3.Location = new Point(723, 441);
            radioButton3.Name = "radioButton3";
            radioButton3.Size = new Size(138, 21);
            radioButton3.TabIndex = 23;
            radioButton3.TabStop = true;
            radioButton3.Text = "Правильный ответ";
            radioButton3.UseVisualStyleBackColor = true;
            radioButton3.Visible = false;
            radioButton3.CheckedChanged += radioButton3_CheckedChanged;
            // 
            // radioButton4
            // 
            radioButton4.AutoSize = true;
            tableLayoutPanel1.SetColumnSpan(radioButton4, 2);
            radioButton4.Dock = DockStyle.Top;
            radioButton4.Enabled = false;
            radioButton4.Font = new Font("Times New Roman", 11.25F);
            radioButton4.Location = new Point(723, 496);
            radioButton4.Name = "radioButton4";
            radioButton4.Size = new Size(138, 21);
            radioButton4.TabIndex = 24;
            radioButton4.TabStop = true;
            radioButton4.Text = "Правильный ответ";
            radioButton4.UseVisualStyleBackColor = true;
            radioButton4.Visible = false;
            radioButton4.CheckedChanged += radioButton4_CheckedChanged;
            // 
            // button1
            // 
            button1.Dock = DockStyle.Fill;
            button1.Enabled = false;
            button1.Font = new Font("Times New Roman", 9F);
            button1.Location = new Point(867, 441);
            button1.Name = "button1";
            button1.Size = new Size(92, 49);
            button1.TabIndex = 25;
            button1.Text = "Добавить";
            button1.UseVisualStyleBackColor = true;
            button1.Visible = false;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Dock = DockStyle.Fill;
            button2.Enabled = false;
            button2.Font = new Font("Times New Roman", 11.25F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(867, 496);
            button2.Name = "button2";
            button2.Size = new Size(92, 52);
            button2.TabIndex = 26;
            button2.Text = "Сохранить";
            button2.UseVisualStyleBackColor = true;
            button2.Visible = false;
            button2.Click += button2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(962, 551);
            Controls.Add(tableLayoutPanel1);
            Name = "Form1";
            Text = "Form1";
            Load += Form1_Load;
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            contextMenuStrip4.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            contextMenuStrip5.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)dataGridView3).EndInit();
            contextMenuStrip6.ResumeLayout(false);
            tableLayoutPanel1.ResumeLayout(false);
            tableLayoutPanel1.PerformLayout();
            ResumeLayout(false);
        }

        #endregion

        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private DataGridView dataGridView3;
        private TableLayoutPanel tableLayoutPanel1;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox5;
        private TextBox textBox3;
        private TextBox textBox2;
        private TextBox textBox4;
        private TextBox textBox6;
        private TextBox textBox7;
        private TextBox textBox8;
        private TextBox textBox1;
        private ComboBox comboBox1;
        private ComboBox comboBox2;
        private RadioButton radioButton1;
        private RadioButton radioButton2;
        private RadioButton radioButton3;
        private RadioButton radioButton4;
        private ContextMenuStrip contextMenuStrip1;
        private ToolStripMenuItem удалитьToolStripMenuItem;
        private ToolStripMenuItem добавитьToolStripMenuItem;
        private ToolStripMenuItem изменитьToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip2;
        private ToolStripMenuItem toolStripMenuItem1;
        private ToolStripMenuItem toolStripMenuItem2;
        private ToolStripMenuItem toolStripMenuItem3;
        private ContextMenuStrip contextMenuStrip3;
        private ToolStripMenuItem toolStripMenuItem7;
        private ToolStripMenuItem toolStripMenuItem8;
        private ToolStripMenuItem toolStripMenuItem9;
        private ContextMenuStrip contextMenuStrip4;
        private ToolStripMenuItem удалитьТестToolStripMenuItem;
        private ContextMenuStrip contextMenuStrip5;
        private ContextMenuStrip contextMenuStrip6;
        private ToolStripMenuItem удалитьВопросToolStripMenuItem;
        private ToolStripMenuItem удалитьОтветToolStripMenuItem;
        private ToolStripMenuItem добавитьТестToolStripMenuItem;
        private Button button1;
        private ToolStripMenuItem добавитьВопросToolStripMenuItem;
        private ToolStripMenuItem добавитьОтветToolStripMenuItem;
        private Button button2;
        private ToolStripMenuItem изменитьТестToolStripMenuItem;
        private ToolStripMenuItem изменитьВопросToolStripMenuItem;
        private ToolStripMenuItem зменитьОтветыToolStripMenuItem;
    }
}
