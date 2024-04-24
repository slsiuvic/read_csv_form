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
            trackBar1 = new TrackBar();
            menuStrip2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).BeginInit();
            SuspendLayout();
            // 
            // menuStrip2
            // 
            menuStrip2.ImageScalingSize = new Size(28, 28);
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
            loadcsv_menu.Size = new Size(120, 22);
            loadcsv_menu.Text = "Load csv";
            loadcsv_menu.Click += loadCSVToolStripMenuItem_Click;
            // 
            // exportToolStripMenuItem
            // 
            exportToolStripMenuItem.DropDownItems.AddRange(new ToolStripItem[] { exportSplittedDecDataToolStripMenuItem, rAWDatabinToolStripMenuItem, stoppingDataToolStripMenuItem });
            exportToolStripMenuItem.Name = "exportToolStripMenuItem";
            exportToolStripMenuItem.Size = new Size(120, 22);
            exportToolStripMenuItem.Text = "Export";
            // 
            // exportSplittedDecDataToolStripMenuItem
            // 
            exportSplittedDecDataToolStripMenuItem.Name = "exportSplittedDecDataToolStripMenuItem";
            exportSplittedDecDataToolStripMenuItem.Size = new Size(155, 22);
            exportSplittedDecDataToolStripMenuItem.Text = "RAW data (dec)";
            exportSplittedDecDataToolStripMenuItem.Click += exportSplittedDecDataToolStripMenuItem_Click;
            // 
            // rAWDatabinToolStripMenuItem
            // 
            rAWDatabinToolStripMenuItem.Name = "rAWDatabinToolStripMenuItem";
            rAWDatabinToolStripMenuItem.Size = new Size(155, 22);
            rAWDatabinToolStripMenuItem.Text = "RAW data (bin)";
            rAWDatabinToolStripMenuItem.Click += rAWDatabinToolStripMenuItem_Click;
            // 
            // stoppingDataToolStripMenuItem
            // 
            stoppingDataToolStripMenuItem.Name = "stoppingDataToolStripMenuItem";
            stoppingDataToolStripMenuItem.Size = new Size(155, 22);
            stoppingDataToolStripMenuItem.Text = "Stopping data";
            stoppingDataToolStripMenuItem.Click += stoppingDataToolStripMenuItem_Click;
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
            dataGridView1.Location = new Point(8, 54);
            dataGridView1.Name = "dataGridView1";
            dataGridView1.RowHeadersWidth = 21;
            dataGridView1.Size = new Size(390, 351);
            dataGridView1.TabIndex = 4;
            dataGridView1.CellContentClick += dataGridView1_CellContentClick_2;
            // 
            // C08A
            // 
            C08A.AutoSize = true;
            C08A.Font = new Font("Consolas", 12F);
            C08A.Location = new Point(418, 338);
            C08A.Name = "C08A";
            C08A.Size = new Size(45, 19);
            C08A.TabIndex = 7;
            C08A.Text = "C08A";
            // 
            // Time
            // 
            Time.AutoSize = true;
            Time.Font = new Font("Consolas", 12F);
            Time.Location = new Point(615, 105);
            Time.Name = "Time";
            Time.Size = new Size(45, 19);
            Time.TabIndex = 8;
            Time.Text = "Time";
            Time.Click += Time_Click;
            // 
            // C17D
            // 
            C17D.AutoSize = true;
            C17D.Font = new Font("Consolas", 12F);
            C17D.Location = new Point(418, 114);
            C17D.Name = "C17D";
            C17D.Size = new Size(45, 19);
            C17D.TabIndex = 9;
            C17D.Text = "C17D";
            // 
            // C44C
            // 
            C44C.AutoSize = true;
            C44C.Font = new Font("Consolas", 12F);
            C44C.Location = new Point(418, 130);
            C44C.Name = "C44C";
            C44C.Size = new Size(45, 19);
            C44C.TabIndex = 10;
            C44C.Text = "C44C";
            // 
            // C133
            // 
            C133.AutoSize = true;
            C133.Font = new Font("Consolas", 12F);
            C133.Location = new Point(418, 146);
            C133.Name = "C133";
            C133.Size = new Size(45, 19);
            C133.TabIndex = 11;
            C133.Text = "C133";
            // 
            // C433
            // 
            C433.AutoSize = true;
            C433.Font = new Font("Consolas", 12F);
            C433.Location = new Point(418, 162);
            C433.Name = "C433";
            C433.Size = new Size(45, 19);
            C433.TabIndex = 12;
            C433.Text = "C433";
            // 
            // C43C
            // 
            C43C.AutoSize = true;
            C43C.Font = new Font("Consolas", 12F);
            C43C.Location = new Point(418, 178);
            C43C.Name = "C43C";
            C43C.Size = new Size(45, 19);
            C43C.TabIndex = 13;
            C43C.Text = "C43C";
            // 
            // C219
            // 
            C219.AutoSize = true;
            C219.Font = new Font("Consolas", 12F);
            C219.Location = new Point(418, 194);
            C219.Name = "C219";
            C219.Size = new Size(45, 19);
            C219.TabIndex = 14;
            C219.Text = "C219";
            // 
            // C573
            // 
            C573.AutoSize = true;
            C573.Font = new Font("Consolas", 12F);
            C573.Location = new Point(418, 210);
            C573.Name = "C573";
            C573.Size = new Size(45, 19);
            C573.TabIndex = 15;
            C573.Text = "C573";
            // 
            // C12C
            // 
            C12C.AutoSize = true;
            C12C.Font = new Font("Consolas", 12F);
            C12C.Location = new Point(418, 226);
            C12C.Name = "C12C";
            C12C.Size = new Size(45, 19);
            C12C.TabIndex = 16;
            C12C.Text = "C12C";
            // 
            // C118
            // 
            C118.AutoSize = true;
            C118.Font = new Font("Consolas", 12F);
            C118.Location = new Point(418, 242);
            C118.Name = "C118";
            C118.Size = new Size(45, 19);
            C118.TabIndex = 17;
            C118.Text = "C118";
            // 
            // C117
            // 
            C117.AutoSize = true;
            C117.Font = new Font("Consolas", 12F);
            C117.Location = new Point(418, 258);
            C117.Name = "C117";
            C117.Size = new Size(45, 19);
            C117.TabIndex = 18;
            C117.Text = "C117";
            // 
            // C116
            // 
            C116.AutoSize = true;
            C116.Font = new Font("Consolas", 12F);
            C116.Location = new Point(418, 274);
            C116.Name = "C116";
            C116.Size = new Size(45, 19);
            C116.TabIndex = 19;
            C116.Text = "C116";
            // 
            // C089
            // 
            C089.AutoSize = true;
            C089.Font = new Font("Consolas", 12F);
            C089.Location = new Point(418, 290);
            C089.Name = "C089";
            C089.Size = new Size(45, 19);
            C089.TabIndex = 20;
            C089.Text = "C089";
            // 
            // C088
            // 
            C088.AutoSize = true;
            C088.Font = new Font("Consolas", 12F);
            C088.Location = new Point(418, 306);
            C088.Name = "C088";
            C088.Size = new Size(45, 19);
            C088.TabIndex = 21;
            C088.Text = "C088";
            // 
            // C08B
            // 
            C08B.AutoSize = true;
            C08B.Font = new Font("Consolas", 12F);
            C08B.Location = new Point(417, 322);
            C08B.Name = "C08B";
            C08B.Size = new Size(45, 19);
            C08B.TabIndex = 22;
            C08B.Text = "C08B";
            // 
            // C17B
            // 
            C17B.AutoSize = true;
            C17B.Font = new Font("Consolas", 12F);
            C17B.Location = new Point(417, 354);
            C17B.Name = "C17B";
            C17B.Size = new Size(45, 19);
            C17B.TabIndex = 23;
            C17B.Text = "C17B";
            // 
            // Index
            // 
            Index.AutoSize = true;
            Index.Font = new Font("Consolas", 12F);
            Index.Location = new Point(417, 95);
            Index.Name = "Index";
            Index.Size = new Size(54, 19);
            Index.TabIndex = 24;
            Index.Text = "Index";
            // 
            // LogDeviation
            // 
            LogDeviation.AutoSize = true;
            LogDeviation.Font = new Font("Consolas", 12F);
            LogDeviation.Location = new Point(615, 165);
            LogDeviation.Margin = new Padding(2, 0, 2, 0);
            LogDeviation.Name = "LogDeviation";
            LogDeviation.Size = new Size(162, 19);
            LogDeviation.TabIndex = 25;
            LogDeviation.Text = "Logical Deviation";
            LogDeviation.TextAlign = ContentAlignment.BottomRight;
            // 
            // remain_target
            // 
            remain_target.AutoSize = true;
            remain_target.Font = new Font("Consolas", 12F);
            remain_target.Location = new Point(871, 165);
            remain_target.Margin = new Padding(2, 0, 2, 0);
            remain_target.Name = "remain_target";
            remain_target.Size = new Size(126, 19);
            remain_target.TabIndex = 26;
            remain_target.Text = "Remain Target";
            // 
            // train_stationary
            // 
            train_stationary.AutoSize = true;
            train_stationary.Font = new Font("Consolas", 12F);
            train_stationary.Location = new Point(871, 124);
            train_stationary.Margin = new Padding(2, 0, 2, 0);
            train_stationary.Name = "train_stationary";
            train_stationary.Size = new Size(54, 19);
            train_stationary.TabIndex = 27;
            train_stationary.Text = "Train";
            // 
            // dock
            // 
            dock.AutoSize = true;
            dock.Font = new Font("Consolas", 12F);
            dock.Location = new Point(871, 144);
            dock.Margin = new Padding(2, 0, 2, 0);
            dock.Name = "dock";
            dock.Size = new Size(108, 19);
            dock.TabIndex = 28;
            dock.Text = "Dock Status";
            // 
            // platform
            // 
            platform.AutoSize = true;
            platform.Font = new Font("Consolas", 12F);
            platform.Location = new Point(871, 186);
            platform.Margin = new Padding(2, 0, 2, 0);
            platform.Name = "platform";
            platform.Size = new Size(81, 19);
            platform.TabIndex = 29;
            platform.Text = "Platform";
            // 
            // proxmity
            // 
            proxmity.AutoSize = true;
            proxmity.Font = new Font("Consolas", 12F);
            proxmity.Location = new Point(615, 144);
            proxmity.Margin = new Padding(2, 0, 2, 0);
            proxmity.Name = "proxmity";
            proxmity.Size = new Size(90, 19);
            proxmity.TabIndex = 30;
            proxmity.Text = "Proximity";
            // 
            // over_under
            // 
            over_under.AutoSize = true;
            over_under.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            over_under.Location = new Point(615, 186);
            over_under.Margin = new Padding(2, 0, 2, 0);
            over_under.Name = "over_under";
            over_under.Size = new Size(144, 19);
            over_under.TabIndex = 31;
            over_under.Text = "Over/Undershoot";
            // 
            // trainspeed
            // 
            trainspeed.AutoSize = true;
            trainspeed.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainspeed.Location = new Point(871, 210);
            trainspeed.Margin = new Padding(2, 0, 2, 0);
            trainspeed.Name = "trainspeed";
            trainspeed.Size = new Size(108, 19);
            trainspeed.TabIndex = 32;
            trainspeed.Text = "Train Speed";
            // 
            // logdate
            // 
            logdate.AutoSize = true;
            logdate.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            logdate.Location = new Point(871, 105);
            logdate.Margin = new Padding(2, 0, 2, 0);
            logdate.Name = "logdate";
            logdate.Size = new Size(45, 19);
            logdate.TabIndex = 33;
            logdate.Text = "Date";
            // 
            // trainID
            // 
            trainID.AutoSize = true;
            trainID.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            trainID.Location = new Point(615, 124);
            trainID.Margin = new Padding(2, 0, 2, 0);
            trainID.Name = "trainID";
            trainID.Size = new Size(81, 19);
            trainID.TabIndex = 34;
            trainID.Text = "Train ID";
            // 
            // psd
            // 
            psd.AutoSize = true;
            psd.Font = new Font("Consolas", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            psd.Location = new Point(615, 210);
            psd.Margin = new Padding(2, 0, 2, 0);
            psd.Name = "psd";
            psd.Size = new Size(126, 19);
            psd.TabIndex = 35;
            psd.Text = "Platform Door";
            // 
            // trackBar1
            // 
            trackBar1.Location = new Point(418, 54);
            trackBar1.Margin = new Padding(2);
            trackBar1.Name = "trackBar1";
            trackBar1.Size = new Size(656, 45);
            trackBar1.TabIndex = 39;
            trackBar1.Scroll += trackBar1_Scroll;
            // 
            // btnClickThis
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1085, 530);
            Controls.Add(trackBar1);
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
            Controls.Add(dataGridView1);
            Controls.Add(menuStrip2);
            Name = "btnClickThis";
            Text = "Form1";
            menuStrip2.ResumeLayout(false);
            menuStrip2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)btnClickThisBindingSource).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridView1).EndInit();
            ((System.ComponentModel.ISupportInitialize)trackBar1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion
        private MenuStrip menuStrip2;
        private ToolStripMenuItem fileToolStripMenuItem;
        private ToolStripMenuItem loadcsv_menu;
        private ToolStripMenuItem analysisToolStripMenuItem;
        private ToolStripMenuItem runToolStripMenuItem;
        private ToolStripMenuItem exitToolStripMenuItem;
        private OpenFileDialog openFileDialog1;
        private BindingSource btnClickThisBindingSource;
        private DataGridView dataGridView1;
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
        private TrackBar trackBar1;
    }
}
