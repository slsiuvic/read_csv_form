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
            fileToolStripMenuItem = new ToolStripMenuItem();
            loadcsv_menu = new ToolStripMenuItem();
            exportToolStripMenuItem = new ToolStripMenuItem();
            exportSplittedDecDataToolStripMenuItem = new ToolStripMenuItem();
            rAWDatabinToolStripMenuItem = new ToolStripMenuItem();
            exitToolStripMenuItem = new ToolStripMenuItem();
            analysisToolStripMenuItem = new ToolStripMenuItem();
            runToolStripMenuItem = new ToolStripMenuItem();
            openFileDialog1 = new OpenFileDialog();
            btnClickThisBindingSource = new BindingSource(components);
            dataGridView1 = new DataGridView();
            hScrollBar1 = new HScrollBar();
            C08A = new Label();
            Time = new Label();
            C17D = new Label();
            C44C = new Label();
            C133 = new Label();
            C433 = new Label();
            C43C = new Label();
            C219 = new Label();
            C573 = new Label();
            C12C = new Label();
            C118 = new Label();
            C117 = new Label();
            C116 = new Label();
            C089 = new Label();
            C088 = new Label();
            C08B = new Label();
            C17B = new Label();
            Index = new Label();
            saveFileDialog1 = new SaveFileDialog();
            stoppingDataToolStripMenuItem = new ToolStripMenuItem();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
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
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Size = new Size(1085, 24);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadcsv_menu, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(37, 20);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadcsv_menu
            // 
            loadcsv_menu.Name = "loadcsv_menu";
            loadcsv_menu.Size = new Size(180, 22);
            loadcsv_menu.Text = "Load csv";
            loadcsv_menu.Click += loadCSVToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportSplittedDecDataToolStripMenuItem, rAWDatabinToolStripMenuItem, stoppingDataToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(180, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportSplittedDecDataToolStripMenuItem
            // 
            exportSplittedDecDataToolStripMenuItem.Name = "exportSplittedDecDataToolStripMenuItem";
            exportSplittedDecDataToolStripMenuItem.Size = new Size(180, 22);
            exportSplittedDecDataToolStripMenuItem.Text = "RAW data (dec)";
            exportSplittedDecDataToolStripMenuItem.Click += exportSplittedDecDataToolStripMenuItem_Click;
            // 
            // rAWDatabinToolStripMenuItem
            // 
            rAWDatabinToolStripMenuItem.Name = "rAWDatabinToolStripMenuItem";
            rAWDatabinToolStripMenuItem.Size = new Size(180, 22);
            rAWDatabinToolStripMenuItem.Text = "RAW data (bin)";
            rAWDatabinToolStripMenuItem.Click += rAWDatabinToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(180, 22);
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
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(534, 357);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(256, 24);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // C08A
            // 
            C08A.AutoSize = true;
            C08A.Location = new Point(543, 283);
            C08A.Name = "C08A";
            C08A.Size = new Size(35, 15);
            C08A.TabIndex = 7;
            C08A.Text = "C08A";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Location = new Point(543, 58);
            Time.Name = "Time";
            Time.Size = new Size(33, 15);
            Time.TabIndex = 8;
            Time.Text = "Time";
            // 
            // C17D
            // 
            C17D.AutoSize = true;
            C17D.Location = new Point(543, 73);
            C17D.Name = "C17D";
            C17D.Size = new Size(35, 15);
            C17D.TabIndex = 9;
            C17D.Text = "C17D";
            // 
            // C44C
            // 
            C44C.AutoSize = true;
            C44C.Location = new Point(543, 88);
            C44C.Name = "C44C";
            C44C.Size = new Size(35, 15);
            C44C.TabIndex = 10;
            C44C.Text = "C44C";
            // 
            // C133
            // 
            C133.AutoSize = true;
            C133.Location = new Point(543, 103);
            C133.Name = "C133";
            C133.Size = new Size(33, 15);
            C133.TabIndex = 11;
            C133.Text = "C133";
            // 
            // C433
            // 
            C433.AutoSize = true;
            C433.Location = new Point(543, 118);
            C433.Name = "C433";
            C433.Size = new Size(33, 15);
            C433.TabIndex = 12;
            C433.Text = "C433";
            // 
            // C43C
            // 
            C43C.AutoSize = true;
            C43C.Location = new Point(543, 133);
            C43C.Name = "C43C";
            C43C.Size = new Size(35, 15);
            C43C.TabIndex = 13;
            C43C.Text = "C43C";
            // 
            // C219
            // 
            C219.AutoSize = true;
            C219.Location = new Point(543, 148);
            C219.Name = "C219";
            C219.Size = new Size(33, 15);
            C219.TabIndex = 14;
            C219.Text = "C219";
            // 
            // C573
            // 
            C573.AutoSize = true;
            C573.Location = new Point(543, 163);
            C573.Name = "C573";
            C573.Size = new Size(33, 15);
            C573.TabIndex = 15;
            C573.Text = "C573";
            // 
            // C12C
            // 
            C12C.AutoSize = true;
            C12C.Location = new Point(543, 178);
            C12C.Name = "C12C";
            C12C.Size = new Size(35, 15);
            C12C.TabIndex = 16;
            C12C.Text = "C12C";
            // 
            // C118
            // 
            C118.AutoSize = true;
            C118.Location = new Point(543, 193);
            C118.Name = "C118";
            C118.Size = new Size(33, 15);
            C118.TabIndex = 17;
            C118.Text = "C118";
            // 
            // C117
            // 
            C117.AutoSize = true;
            C117.Location = new Point(543, 208);
            C117.Name = "C117";
            C117.Size = new Size(33, 15);
            C117.TabIndex = 18;
            C117.Text = "C117";
            // 
            // C116
            // 
            C116.AutoSize = true;
            C116.Location = new Point(543, 223);
            C116.Name = "C116";
            C116.Size = new Size(33, 15);
            C116.TabIndex = 19;
            C116.Text = "C116";
            // 
            // C089
            // 
            C089.AutoSize = true;
            C089.Location = new Point(543, 238);
            C089.Name = "C089";
            C089.Size = new Size(33, 15);
            C089.TabIndex = 20;
            C089.Text = "C089";
            // 
            // C088
            // 
            C088.AutoSize = true;
            C088.Location = new Point(543, 253);
            C088.Name = "C088";
            C088.Size = new Size(33, 15);
            C088.TabIndex = 21;
            C088.Text = "C088";
            // 
            // C08B
            // 
            C08B.AutoSize = true;
            C08B.Location = new Point(542, 268);
            C08B.Name = "C08B";
            C08B.Size = new Size(34, 15);
            C08B.TabIndex = 22;
            C08B.Text = "C08B";
            // 
            // C17B
            // 
            C17B.AutoSize = true;
            C17B.Location = new Point(542, 298);
            C17B.Name = "C17B";
            C17B.Size = new Size(34, 15);
            C17B.TabIndex = 23;
            C17B.Text = "C17B";
            // 
            // Index
            // 
            Index.AutoSize = true;
            Index.Location = new Point(542, 43);
            Index.Name = "Index";
            Index.Size = new Size(36, 15);
            Index.TabIndex = 24;
            Index.Text = "Index";
            // 
            // stoppingDataToolStripMenuItem
            // 
            stoppingDataToolStripMenuItem.Name = "stoppingDataToolStripMenuItem";
            stoppingDataToolStripMenuItem.Size = new Size(180, 22);
            stoppingDataToolStripMenuItem.Text = "Stopping data";
            stoppingDataToolStripMenuItem.Click += stoppingDataToolStripMenuItem_Click;
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 576);
            Controls.Add(Index);
            Controls.Add(C17B);
            Controls.Add(C08B);
            Controls.Add(C088);
            Controls.Add(C089);
            Controls.Add(C116);
            Controls.Add(C117);
            Controls.Add(C118);
            Controls.Add(C12C);
            Controls.Add(C573);
            Controls.Add(C219);
            Controls.Add(C43C);
            Controls.Add(C433);
            Controls.Add(C133);
            Controls.Add(C44C);
            Controls.Add(C17D);
            Controls.Add(Time);
            Controls.Add(C08A);
            Controls.Add(hScrollBar1);
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
        private HScrollBar hScrollBar1;
        private Label C08A;
        private Label Time;
        private Label C17D;
        private Label C44C;
        private Label C133;
        private Label C433;
        private Label C43C;
        private Label C219;
        private Label C573;
        private Label C12C;
        private Label C118;
        private Label C117;
        private Label C116;
        private Label C089;
        private Label C088;
        private Label C08B;
        private Label C17B;
        private Label Index;
        private SaveFileDialog saveFileDialog1;
        private ToolStripMenuItem exportToolStripMenuItem;
        private ToolStripMenuItem exportSplittedDecDataToolStripMenuItem;
        private ToolStripMenuItem rAWDatabinToolStripMenuItem;
        private ToolStripMenuItem stoppingDataToolStripMenuItem;
    }
}
