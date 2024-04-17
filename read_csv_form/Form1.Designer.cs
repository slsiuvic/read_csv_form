namespace read_csv_form
{
    partial class btnClickThis
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
            menuStrip1 = new MenuStrip();
            menuStrip2 = new MenuStrip();
            fileToolStripMenuItem1 = new ToolStripMenuItem();
            loadToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem1 = new ToolStripMenuItem();
            analysisToolStripMenuItem1 = new ToolStripMenuItem();
            runToolStripMenuItem1 = new ToolStripMenuItem();
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadcsv_menu = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            analysisToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            btnClickThisBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            dataGridView2 = new DataGridView();
            hScrollBar1 = new HScrollBar();
            label1 = new Label();
            Time = new Label();
            C17D = new Label();
            C44C = new Label();
            C133 = new Label();
            label5 = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.Location = new Point(0, 24);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Size = new Size(1085, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem1, analysisToolStripMenuItem1, fileToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1085, 24);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem1
            // 
            fileToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { loadToolStripMenuItem, exitToolStripMenuItem1 });
            fileToolStripMenuItem1.Name = "fileToolStripMenuItem1";
            fileToolStripMenuItem1.Size = new Size(37, 20);
            fileToolStripMenuItem1.Text = "File";
            // 
            // loadToolStripMenuItem
            // 
            loadToolStripMenuItem.Name = "loadToolStripMenuItem";
            loadToolStripMenuItem.Size = new Size(100, 22);
            loadToolStripMenuItem.Text = "Load";
            loadToolStripMenuItem.Click += loadToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem1
            // 
            exitToolStripMenuItem1.Name = "exitToolStripMenuItem1";
            exitToolStripMenuItem1.Size = new Size(100, 22);
            exitToolStripMenuItem1.Text = "Exit";
            // 
            // analysisToolStripMenuItem1
            // 
            analysisToolStripMenuItem1.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem1 });
            analysisToolStripMenuItem1.Name = "analysisToolStripMenuItem1";
            analysisToolStripMenuItem1.Size = new Size(62, 20);
            analysisToolStripMenuItem1.Text = "Analysis";
            // 
            // runToolStripMenuItem1
            // 
            runToolStripMenuItem1.Name = "runToolStripMenuItem1";
            runToolStripMenuItem1.Size = new Size(95, 22);
            runToolStripMenuItem1.Text = "Run";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadcsv_menu, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadcsv_menu
            // 
            loadcsv_menu.Name = "loadcsv_menu";
            loadcsv_menu.Size = new Size(120, 22);
            loadcsv_menu.Text = "Load csv";
            loadcsv_menu.Click += loadCSVToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(120, 22);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new Size(62, 20);
            analysisToolStripMenuItem.Text = "Analysis";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(95, 22);
            runToolStripMenuItem.Text = "Run";
            runToolStripMenuItem.Click += runToolStripMenuItem_Click;
            // 
            // openFileDialog1
            // 
            openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnClickThisBindingSource
            // 
            btnClickThisBindingSource.DataSource = typeof(btnClickThis);
            // 
            // dataGridView1
            // 
            dataGridView1.BackgroundColor = SystemColors.Control;
            dataGridView1.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView1.Location = new Point(12, 40);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 21;
            dataGridView1.Size = new Size(509, 353);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // dataGridView2
            // 
            dataGridView2.BackgroundColor = SystemColors.Control;
            dataGridView2.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridView2.Location = new Point(12, 414);
            dataGridView2.Name = "dataGridView2";
            dataGridView2.Size = new Size(1065, 150);
            dataGridView2.TabIndex = 5;
            dataGridView2.CellContentClick += dataGridView2_CellContentClick;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(534, 357);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(256, 24);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(615, 331);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 7;
            label1.Text = "label1";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Location = new Point(548, 59);
            Time.Name = "Time";
            Time.Size = new Size(33, 15);
            Time.TabIndex = 8;
            Time.Text = "Time";
            // 
            // C17D
            // 
            C17D.AutoSize = true;
            C17D.Location = new Point(546, 84);
            C17D.Name = "C17D";
            C17D.Size = new Size(35, 15);
            C17D.TabIndex = 9;
            C17D.Text = "C17D";
            // 
            // C44C
            // 
            C44C.AutoSize = true;
            C44C.Location = new Point(548, 109);
            C44C.Name = "C44C";
            C44C.Size = new Size(35, 15);
            C44C.TabIndex = 10;
            C44C.Text = "C44C";
            // 
            // C133
            // 
            C133.AutoSize = true;
            C133.Location = new Point(548, 137);
            C133.Name = "C133";
            C133.Size = new Size(33, 15);
            C133.TabIndex = 11;
            C133.Text = "C133";
            // 
            // label5
            // 
            label5.Location = new Point(0, 0);
            label5.Name = "label5";
            label5.Size = new Size(100, 23);
            label5.TabIndex = 0;
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 576);
            Controls.Add(label5);
            Controls.Add(C133);
            Controls.Add(C44C);
            Controls.Add(C17D);
            Controls.Add(Time);
            Controls.Add(label1);
            Controls.Add(hScrollBar1);
            Controls.Add(dataGridView2);
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip1);
            Controls.Add(menuStrip2);
            MainMenuStrip = menuStrip1;
            Name = "btnClickThis";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView2).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip1;
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadcsv_menu;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private BindingSource btnClickThisBindingSource;
        private DataGridView dataGridView1;
        private DataGridView dataGridView2;
        private HScrollBar hScrollBar1;
        private Label label1;
        private Label Time;
        private Label C17D;
        private Label C44C;
        private Label C133;
        private Label label5;
        private ToolStripMenuItem fileToolStripMenuItem1;
        private ToolStripMenuItem loadToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem1;
        private ToolStripMenuItem analysisToolStripMenuItem1;
        private ToolStripMenuItem runToolStripMenuItem1;
    }
}
