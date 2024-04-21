using Microsoft.VisualBasic.FileIO;
using OfficeOpenXml;
using System.Data;
using System.Reflection.Emit;
using System.Text;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace read_csv_form
{
    public partial class btnClickThis : Form
    {
        public btnClickThis()
        {
            InitializeComponent();
        }
        // global variable
        DataTable splitted_dt_dec = new DataTable();
        DataTable splitted_dt_bin = new DataTable();
        DataTable result_dt = new DataTable();
        DataTable result_table = new DataTable();
        DataTable overall_raw_dt = new DataTable();



        int row_count;
        int row_index;
        String mode;
        string csv_filePath = string.Empty;
        string filename;

        private void loadCSVToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var fileContent = string.Empty;
            // csv_filePath = string.Empty;

            using (OpenFileDialog openFileDialog = new OpenFileDialog())
            {
                openFileDialog.InitialDirectory = "c:\\";
                openFileDialog.Filter = "csv files (*.csv)|*.csv|All files (*.*)|*.*";
                openFileDialog.FilterIndex = 2;
                openFileDialog.RestoreDirectory = true;

                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    //Get the path of specified file
                    csv_filePath = openFileDialog.FileName;

                    //Read the contents of the file into a stream
                    //var fileStream = openFileDialog.OpenFile();

                    //using (StreamReader reader = new StreamReader(fileStream))
                    //{
                    //    fileContent = reader.ReadToEnd();
                    //}
                }
            }

            filename = Path.GetFileNameWithoutExtension(csv_filePath);
            var splitted_dt = Split_RTD(csv_filePath);
            splitted_dt_dec = splitted_dt.split_dataTable;
            splitted_dt_bin = splitted_dt.split_dataTable_bin;
            //MessageBox.Show(fileContent, "File Content at path: " + csv_filePath, MessageBoxButtons.OK);
            MessageBox.Show("CSV Loaded");
        }

        private void runToolStripMenuItem_Click(object sender, EventArgs e)
        {
            var station_stopping_dt = Station_Stopping(splitted_dt_dec);
            DataTable logDev_col = new DataTable();
            result_dt = station_stopping_dt.result_dataTable;
            overall_raw_dt = station_stopping_dt.logDev_col_dt;
            WriteDataTableToCSV(overall_raw_dt, "C:\\temp_files\\overall_raw_dt.csv");
            dataGridView1.DataSource = result_dt; // Bind the DataGridView to your DataTable
            dataGridView1.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
        }

        public static (DataTable split_dataTable, DataTable split_dataTable_bin) Split_RTD(string filePath)
        {
            // Path to the CSV file
            //string filePath = "C:\\temp_files\\20231113_T29_cpu1.csv";

            // Create a DataTable
            DataTable dataTable = new DataTable();

            // Read the CSV file
            using (TextFieldParser parser = new TextFieldParser(filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Read the header row
                if (!parser.EndOfData)
                {
                    string[] headers = parser.ReadFields();
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                }

                // Read the data rows
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    if (fields.Length == 3)
                    {
                        dataTable.Rows.Add(fields);
                    }
                }
            }

            DataTable split_dataTable = new DataTable();
            DataTable split_dataTable_bin = new DataTable();

            string[] columnNames = { "Index", "Date", "Time", "C17D", "C44C", "C133", "C433", "C43C", "C219", "C573", "C12C", "C118", "C117", "C116", "C089", "C088", "C08B", "C08A", "C17B" };
            foreach (string columnName in columnNames)
            {
                split_dataTable.Columns.Add(columnName);
                split_dataTable_bin.Columns.Add(columnName);
            }
            //PrintDataTable(dataTable);

            DataRow row;
            DataRow row_bin;
            int row_count = dataTable.Rows.Count;
            for (int row_index = 0; row_index < row_count; row_index++)
            {
                row = split_dataTable.NewRow();
                row_bin = split_dataTable_bin.NewRow();

                string date = dataTable.Rows[row_index][0].ToString();
                string time = dataTable.Rows[row_index][1].ToString();
                string row_value = dataTable.Rows[row_index][2].ToString();
                string index = row_index.ToString();

                //row[0] = index;
                row[0] = index;
                row[1] = date;
                row[2] = time;
                //row_bin[0] = index;
                row_bin[0] = date;
                row_bin[1] = time;
                if (row_value.Length == 32)
                {
                    for (int i = 3; i < 19; i++)
                    {
                        row[i] = row_value.Substring((i * 2) - 6, 2);
                        row_bin[i] = hex2bin(row[i].ToString());
                    }
                    split_dataTable.Rows.Add(row);
                    split_dataTable_bin.Rows.Add(row_bin);

                }
                else
                {
                    row.Delete();
                }


            }

            return (split_dataTable, split_dataTable_bin);

            //station_stopping(split_dataTable);
        }

        private static readonly Dictionary<char, string> hexCharacterToBinary = new Dictionary<char, string> {
    { '0', "0000" },
    { '1', "0001" },
    { '2', "0010" },
    { '3', "0011" },
    { '4', "0100" },
    { '5', "0101" },
    { '6', "0110" },
    { '7', "0111" },
    { '8', "1000" },
    { '9', "1001" },
    { 'a', "1010" },
    { 'b', "1011" },
    { 'c', "1100" },
    { 'd', "1101" },
    { 'e', "1110" },
    { 'f', "1111" }
    };

        public static string hex2bin(string hex)
        {
            StringBuilder result = new StringBuilder();
            foreach (char c in hex)
            {
                // This will crash for non-hex characters. You might want to handle that differently.
                result.Append(hexCharacterToBinary[char.ToLower(c)]);
            }
            return result.ToString();
        }

        //public static DataTable Station_Stopping(DataTable split_dataTable)
        public static (DataTable result_dataTable, DataTable logDev_col_dt) Station_Stopping(DataTable split_dataTable)
        {
            DataTable result_dataTable = new DataTable();
            DataTable logDev_col_dt = split_dataTable.Copy();
            DataRow result_row;
            DataRow overall_row;
            int stop_count = 0;
            int result_count = 0;
            int xg0_row = 0;
            string[] column_names = new string[] { "item", "Time", "Platform", "Deviation", "Dock", "Proxmity", "mode", "Row Index" };
            string position_lock = "un-locked";

            foreach (string column_name in column_names)
            {
                result_dataTable.Columns.Add(column_name);
            }
            
            logDev_col_dt.Columns.Add("Log Deviation");
            logDev_col_dt.Columns.Add("Mode");
            logDev_col_dt.Columns.Add("Speed");

            //Console.WriteLine(split_dataTable.Rows.Count);

            for (int row_index = 0; row_index < split_dataTable.Rows.Count - 1; row_index++)
            {
                string vcc = split_dataTable.Rows[row_index]["C433"].ToString();
                string loop = split_dataTable.Rows[row_index]["C43C"].ToString();
                string vcc_dec = Convert.ToInt32(vcc, 16).ToString();
                string loop_dec = Convert.ToInt32(loop, 16).ToString();
                string psd = split_dataTable.Rows[row_index]["C573"].ToString();
                string c118 = split_dataTable.Rows[row_index]["C118"].ToString();
                string mode = "";
                decimal deviation = 0;
                string speed = train_speed(split_dataTable, row_index).ToString();

                string[] mainline_vcc = new string[] { "01", "02", "04", "05", "06", "07", "08", "09", "0C" };

                //if (row_index < split_dataTable.Rows.Count - 1)
                //{
                //    logDev_col_dt.Rows[row_index][21] = speed;
                //}
                logDev_col_dt.Rows[row_index][21] = speed;

                if (mainline_vcc.Contains(vcc) && psd != "00")
                {
                    result_row = result_dataTable.NewRow();
                    //overall_row = logDev_col_dt.NewRow();
                    string dock = split_dataTable.Rows[row_index]["C44C"].ToString();
                    string prox = split_dataTable.Rows[row_index]["C219"].ToString();
                    string stop_flag = split_dataTable.Rows[row_index]["C17D"].ToString();
                    string wegx07 = split_dataTable.Rows[row_index]["C133"].ToString();
                    string wegx00 = split_dataTable.Rows[row_index]["C12C"].ToString();
                    decimal deviation_lock;
                    //string mode;
                    var bytes = Convert.FromHexString(prox);

                    if (stop_flag == "01")
                    {
                        stop_count = stop_count + 1;
                    }
                    else
                    {
                        stop_count = 0;
                    }

                    if (wegx07 == "00" && wegx00 == "00" && position_lock == "un-locked" && stop_flag == "00")
                    {
                        position_lock = "locked";
                        xg0_row = row_index;
                        //Console.WriteLine(row_index);
                    }

                    if (stop_count == 4)
                    {
                        result_count++;
                        string time = split_dataTable.Rows[row_index]["Time"].ToString();
                        string platform = Train_Platform(vcc_dec, loop_dec, c118);

                        if (wegx07 == "00" && wegx00 == "00" && position_lock == "locked")
                        {
                            string xg0_pos = Train_Position(split_dataTable, xg0_row);
                            double xg0_pos_dec = Convert.ToInt32(xg0_pos, 16) * 0.00076;
                            decimal xg0_pos_round = RoundDecimal(xg0_pos_dec, 3);

                            string stationary_pos = Train_Position(split_dataTable, row_index);
                            double stationary_pos_dec = Convert.ToInt32(stationary_pos, 16) * 0.00076;
                            decimal stationary_pos_round = RoundDecimal(stationary_pos_dec, 3);

                            deviation = (stationary_pos_round - xg0_pos_round);

                            if (deviation == 0)
                            {
                                mode = "Exact";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;

                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                xg0_row = 0;
                                position_lock = "un-locked";
                            }
                            else
                            {
                                mode = "Over";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;

                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                xg0_row = 0;
                                position_lock = "un-locked";

                            }
                        }
                        else if (wegx07 == "FE" && wegx00 == "00")
                        {
                            if (position_lock == "locked")
                            {

                                string xg0_pos = Train_Position(split_dataTable, xg0_row);
                                double xg0_pos_dec = Convert.ToInt32(xg0_pos, 16) * 0.00076;
                                decimal xg0_pos_round = RoundDecimal(xg0_pos_dec, 3);

                                string stationary_pos = Train_Position(split_dataTable, row_index);
                                double stationary_pos_dec = Convert.ToInt32(stationary_pos, 16) * 0.00076;
                                decimal stationary_pos_round = RoundDecimal(stationary_pos_dec, 3);
                                deviation = (stationary_pos_round - xg0_pos_round);

                                mode = "Over-FE";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;

                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                position_lock = "un-locked";
                            }

                            else if (position_lock == "un-locked")
                            {
                                mode = "Problem";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;

                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                position_lock = "un-locked";
                            }
                        }

                        else if (wegx07 == "FF" && wegx00 == "00")
                        {
                            if (position_lock == "locked")
                            {

                                string xg0_pos = Train_Position(split_dataTable, xg0_row);
                                double xg0_pos_dec = Convert.ToInt32(xg0_pos, 16) * 0.00076;
                                decimal xg0_pos_round = RoundDecimal(xg0_pos_dec, 3);

                                string stationary_pos = Train_Position(split_dataTable, row_index);
                                double stationary_pos_dec = Convert.ToInt32(stationary_pos, 16) * 0.00076;
                                decimal stationary_pos_round = RoundDecimal(stationary_pos_dec, 3);
                                deviation = (stationary_pos_round - xg0_pos_round);
                                deviation_lock = (stationary_pos_round - xg0_pos_round);

                                mode = "Over-FF";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;
                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                //overall_row = logDev_col_dt.NewRow();

                                //overall_row[row_index][19] = deviation;
                                //overall_row[20] = mode;
                                //logDev_col_dt.Rows.Add(overall_row);
                                position_lock = "un-locked";
                            }

                            else if (position_lock == "un-locked")
                            {
                                mode = "Over-FF";
                                result_row[0] = result_count;
                                result_row[1] = time;
                                result_row[2] = platform;
                                result_row[3] = deviation;
                                result_row[4] = dock_status(dock);
                                result_row[5] = prox_status(prox);
                                result_row[6] = mode;
                                result_row[7] = row_index;
                                result_dataTable.Rows.Add(result_row);
                                logDev_col_dt.Rows[row_index][19] = deviation;
                                logDev_col_dt.Rows[row_index][20] = mode;
                                //overall_row = logDev_col_dt.NewRow();
                                //overall_row[19] = deviation;
                                //overall_row[20] = mode;
                                //logDev_col_dt.Rows.Add(overall_row);
                                position_lock = "un-locked";
                            }
                        }

                        else if (wegx07 != "00" && wegx00 != "00")
                        {
                            string d2g = dist2go(split_dataTable, row_index);
                            double d2g_dec = Convert.ToInt32(d2g, 16) * 25 / 32768;
                            decimal d2g_round = RoundDecimal(d2g_dec, 3);

                            string stationary_pos = Train_Position(split_dataTable, row_index);
                            double stationary_pos_dec = Convert.ToInt32(stationary_pos, 16) * 25 / 32768;
                            decimal stationary_pos_round = RoundDecimal(stationary_pos_dec, 3);
                            deviation = -1 * d2g_round * 1000;

                            mode = "short";
                            result_row[0] = result_count;
                            result_row[1] = time;
                            result_row[2] = platform;
                            result_row[3] = deviation;
                            result_row[4] = dock_status(dock);
                            result_row[5] = prox_status(prox);
                            result_row[6] = mode;
                            result_row[7] = row_index;

                            result_dataTable.Rows.Add(result_row);
                            logDev_col_dt.Rows[row_index][19] = deviation;
                            logDev_col_dt.Rows[row_index][20] = mode;
                            position_lock = "un-locked";
                        }
                    }                
                }
            }


            return (result_dataTable, logDev_col_dt);
        }

        public static double train_speed(DataTable split_dataTable, int row_index)
        {
            string c117_1 = split_dataTable.Rows[row_index]["C117"].ToString();
            double c117_1_dec = Convert.ToInt32(c117_1, 16);
            decimal c117_1_round = RoundDecimal(c117_1_dec, 3);
            string c117_2 = split_dataTable.Rows[row_index+1]["C117"].ToString();
            double c117_2_dec = Convert.ToInt32(c117_2, 16);
            decimal c117_2_round = RoundDecimal(c117_2_dec, 3);

            double displayment = c117_2_dec - c117_1_dec;
            double speed = displayment * 0.5;
            return Math.Abs(speed);
        }

        public static decimal RoundDecimal(double value, int places)
        {
            decimal value_decimal = Convert.ToDecimal(value);
            value_decimal = decimal.Round(value_decimal, places);
            return value_decimal;
        }

        public static String Train_Position(DataTable split_dataTable, int row_index)
        {
            string c118_value = split_dataTable.Rows[row_index]["C118"].ToString();
            string c117_value = split_dataTable.Rows[row_index]["C117"].ToString();
            string c116_value = split_dataTable.Rows[row_index]["C116"].ToString();
            string position = c118_value + c117_value + c116_value;
            return position;
        }

        public static String dist2go(DataTable split_dataTable, int row_index)
        {
            string wegx07_value = split_dataTable.Rows[row_index]["C133"].ToString();
            string wegx00_value = split_dataTable.Rows[row_index]["C12C"].ToString();

            string position = wegx07_value + wegx00_value;
            return position;
        }

        public static String train_moving(DataTable split_dataTable, int row_index)
        {
            string moving_bit = split_dataTable.Rows[row_index]["C17D"].ToString();
            string moving_status = "";
            if (moving_bit == "01")
            {
                moving_status = "Stopped";
            }

            else
            {
                moving_status = "Moving";
            }

            return moving_status;
        }

        public static String dock_status(string dock_bit)
        {
            string dock_status = "";
            if (dock_bit == "01")
            {
                dock_status = "Docked";
            }

            else
            {
                dock_status = "No Dock";
            }

            return dock_status;
        }

        public static String prox_status(string prox_bit)
        {
            string prox_status = "";
            if (prox_bit == "10")
            {
                prox_status = "Detected";
            }

            else
            {
                prox_status = "Not-Detected";
            }

            return prox_status;
        }

        public static String Train_Platform(string vcc, string loop, string c118)
        {
            string platform_filePath = "C:\\temp_files\\platform.csv";

            // Create a DataTable
            DataTable dataTable = new DataTable();
            string platform = " ";

            // Read the CSV file
            using (TextFieldParser parser = new TextFieldParser(platform_filePath))
            {
                parser.TextFieldType = FieldType.Delimited;
                parser.SetDelimiters(",");

                // Read the header row
                if (!parser.EndOfData)
                {
                    string[] headers = parser.ReadFields();
                    foreach (string header in headers)
                    {
                        dataTable.Columns.Add(header);
                    }
                }

                // Read the data rows
                while (!parser.EndOfData)
                {
                    string[] fields = parser.ReadFields();
                    dataTable.Rows.Add(fields);
                }
            }

            //string platform = dataTable.Rows[int.Parse(vcc) - 1][int.Parse(loop)].ToString();

            if (vcc == "12" && loop == "4" && c118 == "3F")
            {
                platform = "SHM1";

            }

            else if (vcc == "12" && loop == "4" && c118 == "30")
            {
                platform = "CIO1";
            }

            else if (vcc == "12" && loop == "3" && c118 == "09")
            {
                platform = "CIO2";
            }

            else if (vcc == "12" && loop == "3" && c118 == "17")
            {
                platform = "SHM2";
            }

            else
            {
                platform = dataTable.Rows[int.Parse(vcc) - 1][int.Parse(loop)].ToString();
            }
            return platform;
        }

        // Helper method to print the DataTable
        static void PrintDataTable(DataTable dataTable)
        {
            foreach (DataRow row in dataTable.Rows)
            {
                foreach (var item in row.ItemArray)
                {
                    Console.Write(item.ToString() + "\t");
                }
                Console.WriteLine();
            }
        }

        static void WriteDataTableToCSV(DataTable dataTable, string filePath)
        {
            StringBuilder sb = new StringBuilder();

            // Column headers
            string[] columnNames = dataTable.Columns.Cast<DataColumn>().Select(column => column.ColumnName).ToArray();
            sb.AppendLine(string.Join(",", columnNames));

            // Rows data
            foreach (DataRow row in dataTable.Rows)
            {
                string[] fields = row.ItemArray.Select(field => field.ToString()).ToArray();
                sb.AppendLine(string.Join(",", fields));
            }

            File.WriteAllText(filePath, sb.ToString());
        }

        private void dataGridView1_CellContentClick_2(object sender, DataGridViewCellEventArgs e)
        {
            //DataTable result_table = new DataTable();
            //dataGridView1.DataSource = result_table;
        }

        private void hScrollBar1_Scroll(object sender, ScrollEventArgs e)
        {
            int count = splitted_dt_dec.Rows.Count;
            hScrollBar1.Minimum = 0;
            hScrollBar1.Maximum = count;
            string docking = dock_status(splitted_dt_dec.Rows[hScrollBar1.Value]["C44C"].ToString());
            string prox_detect = prox_status(splitted_dt_dec.Rows[hScrollBar1.Value]["C219"].ToString());
            Index.Text = "Index: " + overall_raw_dt.Rows[hScrollBar1.Value]["Index"].ToString();
            Time.Text = "Time: " + splitted_dt_dec.Rows[hScrollBar1.Value]["Time"].ToString();
            C17D.Text = "C17D: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C17D"].ToString();
            C44C.Text = "C44C: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C44C"].ToString();
            C133.Text = "C133: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C133"].ToString();
            C433.Text = "C433: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C433"].ToString();
            C43C.Text = "C43C: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C43C"].ToString();
            C219.Text = "C219: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C219"].ToString();
            C573.Text = "C573: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C573"].ToString();
            C12C.Text = "C12C: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C12C"].ToString();
            C118.Text = "C118: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C118"].ToString();
            C117.Text = "C117: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C117"].ToString();
            C116.Text = "C116: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C116"].ToString();
            C089.Text = "C089: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C089"].ToString();
            C088.Text = "C088: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C088"].ToString();
            C08B.Text = "C08B: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C08B"].ToString();
            C08A.Text = "C08A: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C08A"].ToString();
            C17B.Text = "C17B: " + splitted_dt_dec.Rows[hScrollBar1.Value]["C17B"].ToString();
            LogDeviation.Text = "Logical Deviation: " + overall_raw_dt.Rows[hScrollBar1.Value]["Log Deviation"].ToString();
            remain_target.Text = "Remain Target: " + dist2go(splitted_dt_dec,hScrollBar1.Value).ToString();
            train_stationary.Text = "Train: " + train_moving(splitted_dt_dec, hScrollBar1.Value).ToString();
            dock.Text = "Dock Status: " + docking;
            platform.Text = "Platform: " + Train_Platform(Convert.ToInt32(splitted_dt_dec.Rows[hScrollBar1.Value]["C433"].ToString(), 16).ToString(), Convert.ToInt32(splitted_dt_dec.Rows[hScrollBar1.Value]["C43C"].ToString(), 16).ToString(), splitted_dt_dec.Rows[hScrollBar1.Value]["C118"].ToString());
            proxmity.Text = "Proxmity Plate: " + prox_detect;
            over_under.Text = "Over/Undershoot: " + overall_raw_dt.Rows[hScrollBar1.Value]["Mode"].ToString();
            trainspeed.Text = "Train Speed: " + overall_raw_dt.Rows[hScrollBar1.Value]["Speed"].ToString();

            //conditional color
            if (docking == "Docked")
            {
                dock.BackColor = System.Drawing.Color.Orange;
            }
            else
            {
                dock.BackColor = System.Drawing.Color.Transparent;
            }
            
            if (prox_detect == "Detected")
            {
                proxmity.BackColor = System.Drawing.Color.Green;
            }
            else
            {
                proxmity.BackColor = System.Drawing.Color.Transparent;
            }
        }

        private void exportSplittedDecDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(sfd.FileName);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Splitted Data");
                        worksheet.Cells.LoadFromDataTable(splitted_dt_dec, true);
                        excelPackage.Save();
                        MessageBox.Show("Splitted Dec Data Exported");
                    }
                }
            }
        }

        private void rAWDatabinToolStripMenuItem_Click(object sender, EventArgs e)
        {
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(sfd.FileName);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Splitted Data");
                        worksheet.Cells.LoadFromDataTable(splitted_dt_bin, true);
                        excelPackage.Save();
                        MessageBox.Show("Splitted Bin Data Exported");
                    }
                }
            }
        }

        private void stoppingDataToolStripMenuItem_Click(object sender, EventArgs e)
        {
            //DataTable result_dt = Station_Stopping(splitted_dt_dec);
            var station_stopping_dt = Station_Stopping(splitted_dt_dec);
            result_dt = station_stopping_dt.result_dataTable;
            using (SaveFileDialog sfd = new SaveFileDialog() { Filter = "Excel Workbook|*.xlsx" })
            {
                if (sfd.ShowDialog() == DialogResult.OK)
                {
                    var fileInfo = new FileInfo(sfd.FileName);
                    using (ExcelPackage excelPackage = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = excelPackage.Workbook.Worksheets.Add("Stopping Data");
                        worksheet.Cells.LoadFromDataTable(result_dt, true);
                        excelPackage.Save();
                        MessageBox.Show("Stopping Data Exported");
                    }
                }
            }
        }


    }
}
