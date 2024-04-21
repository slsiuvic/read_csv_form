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
            stoppingDataToolStripMenuItem = new ToolStripMenuItem();
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
            LogDeviation = new Label();
            remain_target = new Label();
            train_stationary = new Label();
            dock = new Label();
            platform = new Label();
            proxmity = new Label();
            over_under = new Label();
            trainspeed = new Label();
            logdate = new Label();
            trainID = new Label();
            psd = new Label();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip1
            // 
            menuStrip1.ImageScalingSize = new Size(28, 28);
            menuStrip1.Location = new Point(0, 42);
            menuStrip1.Name = "menuStrip1";
            menuStrip1.Padding = new Padding(10, 4, 0, 4);
            menuStrip1.Size = new Size(1860, 24);
            menuStrip1.TabIndex = 2;
            menuStrip1.Text = "menuStrip1";
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(28, 28);
            menuStrip2.Items.AddRange(new ToolStripItem[] { fileToolStripMenuItem, analysisToolStripMenuItem });
            menuStrip2.Location = new Point(0, 0);
            menuStrip2.Name = "menuStrip2";
            menuStrip2.Padding = new Padding(10, 4, 0, 4);
            menuStrip2.Size = new Size(1860, 42);
            menuStrip2.TabIndex = 3;
            menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            fileToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { loadcsv_menu, exportToolStripMenuItem, exitToolStripMenuItem });
            fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            fileToolStripMenuItem.Size = new Size(62, 34);
            fileToolStripMenuItem.Text = "File";
            // 
            // loadcsv_menu
            // 
            loadcsv_menu.Name = "loadcsv_menu";
            loadcsv_menu.Size = new Size(211, 40);
            loadcsv_menu.Text = "Load csv";
            loadcsv_menu.Click += loadCSVToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportSplittedDecDataToolStripMenuItem, rAWDatabinToolStripMenuItem, stoppingDataToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(211, 40);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportSplittedDecDataToolStripMenuItem
            // 
            exportSplittedDecDataToolStripMenuItem.Name = "exportSplittedDecDataToolStripMenuItem";
            exportSplittedDecDataToolStripMenuItem.Size = new Size(275, 40);
            exportSplittedDecDataToolStripMenuItem.Text = "RAW data (dec)";
            exportSplittedDecDataToolStripMenuItem.Click += exportSplittedDecDataToolStripMenuItem_Click;
            // 
            // rAWDatabinToolStripMenuItem
            // 
            rAWDatabinToolStripMenuItem.Name = "rAWDatabinToolStripMenuItem";
            rAWDatabinToolStripMenuItem.Size = new Size(275, 40);
            rAWDatabinToolStripMenuItem.Text = "RAW data (bin)";
            rAWDatabinToolStripMenuItem.Click += rAWDatabinToolStripMenuItem_Click;
            // 
            // stoppingDataToolStripMenuItem
            // 
            stoppingDataToolStripMenuItem.Name = "stoppingDataToolStripMenuItem";
            stoppingDataToolStripMenuItem.Size = new Size(275, 40);
            stoppingDataToolStripMenuItem.Text = "Stopping data";
            stoppingDataToolStripMenuItem.Click += stoppingDataToolStripMenuItem_Click;
            // 
            // exitToolStripMenuItem
            // 
            exitToolStripMenuItem.Name = "exitToolStripMenuItem";
            exitToolStripMenuItem.Size = new Size(211, 40);
            exitToolStripMenuItem.Text = "Exit";
            // 
            // analysisToolStripMenuItem
            // 
            analysisToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { runToolStripMenuItem });
            analysisToolStripMenuItem.Name = "analysisToolStripMenuItem";
            analysisToolStripMenuItem.Size = new Size(106, 34);
            analysisToolStripMenuItem.Text = "Analysis";
            // 
            // runToolStripMenuItem
            // 
            runToolStripMenuItem.Name = "runToolStripMenuItem";
            runToolStripMenuItem.Size = new Size(168, 40);
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
            dataGridView1.Location = new Point(21, 719);
            dataGridView1.Margin = new Padding(5, 6, 5, 6);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 21;
            dataGridView1.Size = new Size(1839, 275);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // hScrollBar1
            // 
            hScrollBar1.Location = new Point(21, 659);
            hScrollBar1.Name = "hScrollBar1";
            hScrollBar1.Size = new Size(1830, 42);
            hScrollBar1.TabIndex = 6;
            hScrollBar1.Scroll += hScrollBar1_Scroll;
            // 
            // C08A
            // 
            C08A.AutoSize = true;
            C08A.Font = new Font("Consolas", 12F);
            C08A.Location = new Point(1090, 557);
            C08A.Margin = new Padding(5, 0, 5, 0);
            C08A.Name = "C08A";
            C08A.Size = new Size(75, 33);
            C08A.TabIndex = 7;
            C08A.Text = "C08A";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Consolas", 12F);
            Time.Location = new Point(505, 77);
            Time.Margin = new Padding(5, 0, 5, 0);
            Time.Name = "Time";
            Time.Size = new Size(75, 33);
            Time.TabIndex = 8;
            Time.Text = "Time";
            // 
            // C17D
            // 
            C17D.AutoSize = true;
            C17D.Font = new Font("Consolas", 12F);
            C17D.Location = new Point(1090, 137);
            C17D.Margin = new Padding(5, 0, 5, 0);
            C17D.Name = "C17D";
            C17D.Size = new Size(75, 33);
            C17D.TabIndex = 9;
            C17D.Text = "C17D";
            // 
            // C44C
            // 
            C44C.AutoSize = true;
            C44C.Font = new Font("Consolas", 12F);
            C44C.Location = new Point(1090, 167);
            C44C.Margin = new Padding(5, 0, 5, 0);
            C44C.Name = "C44C";
            C44C.Size = new Size(75, 33);
            C44C.TabIndex = 10;
            C44C.Text = "C44C";
            // 
            // C133
            // 
            C133.AutoSize = true;
            C133.Font = new Font("Consolas", 12F);
            C133.Location = new Point(1090, 197);
            C133.Margin = new Padding(5, 0, 5, 0);
            C133.Name = "C133";
            C133.Size = new Size(75, 33);
            C133.TabIndex = 11;
            C133.Text = "C133";
            // 
            // C433
            // 
            C433.AutoSize = true;
            C433.Font = new Font("Consolas", 12F);
            C433.Location = new Point(1090, 227);
            C433.Margin = new Padding(5, 0, 5, 0);
            C433.Name = "C433";
            C433.Size = new Size(75, 33);
            C433.TabIndex = 12;
            C433.Text = "C433";
            // 
            // C43C
            // 
            C43C.AutoSize = true;
            C43C.Font = new Font("Consolas", 12F);
            C43C.Location = new Point(1090, 257);
            C43C.Margin = new Padding(5, 0, 5, 0);
            C43C.Name = "C43C";
            C43C.Size = new Size(75, 33);
            C43C.TabIndex = 13;
            C43C.Text = "C43C";
            // 
            // C219
            // 
            C219.AutoSize = true;
            C219.Font = new Font("Consolas", 12F);
            C219.Location = new Point(1090, 287);
            C219.Margin = new Padding(5, 0, 5, 0);
            C219.Name = "C219";
            C219.Size = new Size(75, 33);
            C219.TabIndex = 14;
            C219.Text = "C219";
            // 
            // C573
            // 
            C573.AutoSize = true;
            C573.Font = new Font("Consolas", 12F);
            C573.Location = new Point(1090, 317);
            C573.Margin = new Padding(5, 0, 5, 0);
            C573.Name = "C573";
            C573.Size = new Size(75, 33);
            C573.TabIndex = 15;
            C573.Text = "C573";
            // 
            // C12C
            // 
            C12C.AutoSize = true;
            C12C.Font = new Font("Consolas", 12F);
            C12C.Location = new Point(1090, 347);
            C12C.Margin = new Padding(5, 0, 5, 0);
            C12C.Name = "C12C";
            C12C.Size = new Size(75, 33);
            C12C.TabIndex = 16;
            C12C.Text = "C12C";
            // 
            // C118
            // 
            C118.AutoSize = true;
            C118.Font = new Font("Consolas", 12F);
            C118.Location = new Point(1090, 377);
            C118.Margin = new Padding(5, 0, 5, 0);
            C118.Name = "C118";
            C118.Size = new Size(75, 33);
            C118.TabIndex = 17;
            C118.Text = "C118";
            // 
            // C117
            // 
            C117.AutoSize = true;
            C117.Font = new Font("Consolas", 12F);
            C117.Location = new Point(1090, 407);
            C117.Margin = new Padding(5, 0, 5, 0);
            C117.Name = "C117";
            C117.Size = new Size(75, 33);
            C117.TabIndex = 18;
            C117.Text = "C117";
            // 
            // C116
            // 
            C116.AutoSize = true;
            C116.Font = new Font("Consolas", 12F);
            C116.Location = new Point(1090, 437);
            C116.Margin = new Padding(5, 0, 5, 0);
            C116.Name = "C116";
            C116.Size = new Size(75, 33);
            C116.TabIndex = 19;
            C116.Text = "C116";
            // 
            // C089
            // 
            C089.AutoSize = true;
            C089.Font = new Font("Consolas", 12F);
            C089.Location = new Point(1090, 467);
            C089.Margin = new Padding(5, 0, 5, 0);
            C089.Name = "C089";
            C089.Size = new Size(75, 33);
            C089.TabIndex = 20;
            C089.Text = "C089";
            // 
            // C088
            // 
            C088.AutoSize = true;
            C088.Font = new Font("Consolas", 12F);
            C088.Location = new Point(1090, 497);
            C088.Margin = new Padding(5, 0, 5, 0);
            C088.Name = "C088";
            C088.Size = new Size(75, 33);
            C088.TabIndex = 21;
            C088.Text = "C088";
            // 
            // C08B
            // 
            C08B.AutoSize = true;
            C08B.Font = new Font("Consolas", 12F);
            C08B.Location = new Point(1088, 527);
            C08B.Margin = new Padding(5, 0, 5, 0);
            C08B.Name = "C08B";
            C08B.Size = new Size(75, 33);
            C08B.TabIndex = 22;
            C08B.Text = "C08B";
            // 
            // C17B
            // 
            C17B.AutoSize = true;
            C17B.Font = new Font("Consolas", 12F);
            C17B.Location = new Point(1088, 587);
            C17B.Margin = new Padding(5, 0, 5, 0);
            C17B.Name = "C17B";
            C17B.Size = new Size(75, 33);
            C17B.TabIndex = 23;
            C17B.Text = "C17B";
            // 
            // Index
            // 
            Index.AutoSize = true;
            Index.Font = new Font("Consolas", 12F);
            Index.Location = new Point(1088, 77);
            Index.Margin = new Padding(5, 0, 5, 0);
            Index.Name = "Index";
            Index.Size = new Size(90, 33);
            Index.TabIndex = 24;
            Index.Text = "Index";
            // 
            // LogDeviation
            // 
            LogDeviation.AutoSize = true;
            LogDeviation.Font = new Font("Consolas", 12F);
            LogDeviation.Location = new Point(505, 206);
            LogDeviation.Name = "LogDeviation";
            LogDeviation.Size = new Size(270, 33);
            LogDeviation.TabIndex = 25;
            LogDeviation.Text = "Logical Deviation";
            LogDeviation.TextAlign = ContentAlignment.BottomRight;
            // 
            // remain_target
            // 
            remain_target.AutoSize = true;
            remain_target.Font = new Font("Consolas", 12F);
            remain_target.Location = new Point(37, 206);
            remain_target.Name = "remain_target";
            remain_target.Size = new Size(210, 33);
            remain_target.TabIndex = 26;
            remain_target.Text = "Remain Target";
            // 
            // train_stationary
            // 
            train_stationary.AutoSize = true;
            train_stationary.Font = new Font("Consolas", 12F);
            train_stationary.Location = new Point(37, 123);
            train_stationary.Name = "train_stationary";
            train_stationary.Size = new Size(90, 33);
            train_stationary.TabIndex = 27;
            train_stationary.Text = "Train";
            // 
            // dock
            // 
            dock.AutoSize = true;
            dock.Font = new Font("Consolas", 12F);
            dock.Location = new Point(37, 165);
            dock.Name = "dock";
            dock.Size = new Size(180, 33);
            dock.TabIndex = 28;
            dock.Text = "Dock Status";
            // 
            // platform
            // 
            platform.AutoSize = true;
            platform.Font = new Font("Consolas", 12F);
            platform.Location = new Point(37, 249);
            platform.Name = "platform";
            platform.Size = new Size(135, 33);
            platform.TabIndex = 29;
            platform.Text = "Platform";
            // 
            // proxmity
            // 
            proxmity.AutoSize = true;
            proxmity.Font = new Font("Consolas", 12F);
            proxmity.Location = new Point(505, 165);
            proxmity.Name = "proxmity";
            proxmity.Size = new Size(150, 33);
            proxmity.TabIndex = 30;
            proxmity.Text = "Proximity";
            // 
            // over_under
            // 
            over_under.AutoSize = true;
            over_under.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            over_under.Location = new Point(505, 249);
            over_under.Name = "over_under";
            over_under.Size = new Size(240, 33);
            over_under.TabIndex = 31;
            over_under.Text = "Over/Undershoot";
            // 
            // trainspeed
            // 
            trainspeed.AutoSize = true;
            trainspeed.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainspeed.Location = new Point(37, 296);
            trainspeed.Name = "trainspeed";
            trainspeed.Size = new Size(180, 33);
            trainspeed.TabIndex = 32;
            trainspeed.Text = "Train Speed";
            // 
            // logdate
            // 
            logdate.AutoSize = true;
            logdate.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logdate.Location = new Point(37, 77);
            logdate.Name = "logdate";
            logdate.Size = new Size(75, 33);
            logdate.TabIndex = 33;
            logdate.Text = "Date";
            // 
            // trainID
            // 
            trainID.AutoSize = true;
            trainID.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainID.Location = new Point(505, 123);
            trainID.Name = "trainID";
            trainID.Size = new Size(135, 33);
            trainID.TabIndex = 34;
            trainID.Text = "Train ID";
            // 
            // psd
            // 
            psd.AutoSize = true;
            psd.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            psd.Location = new Point(505, 296);
            psd.Name = "psd";
            psd.Size = new Size(210, 33);
            psd.TabIndex = 35;
            psd.Text = "Platform Door";
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(12F, 30F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1860, 1152);
            Controls.Add(psd);
            Controls.Add(trainID);
            Controls.Add(logdate);
            Controls.Add(trainspeed);
            Controls.Add(over_under);
            Controls.Add(proxmity);
            Controls.Add(platform);
            Controls.Add(dock);
            Controls.Add(train_stationary);
            Controls.Add(remain_target);
            Controls.Add(LogDeviation);
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
            Margin = new Padding(5, 6, 5, 6);
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
        private Label LogDeviation;
        private Label remain_target;
        private Label train_stationary;
        private Label dock;
        private Label platform;
        private Label proxmity;
        private Label over_under;
        private Label trainspeed;
        private Label logdate;
        private Label trainID;
        private Label psd;
    }
}
