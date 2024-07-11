namespace Airport
{
    partial class FlightTbl
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FlightTbl));
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            label7 = new Label();
            label8 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            comboBox1 = new ComboBox();
            dateTimePicker1 = new DateTimePicker();
            textBox3 = new TextBox();
            comboBox2 = new ComboBox();
            dateTimePicker2 = new DateTimePicker();
            record = new Button();
            button2 = new Button();
            airportName = new Label();
            newFlights = new Label();
            comboBox3 = new ComboBox();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 12F);
            label1.Location = new Point(26, 125);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 1;
            label1.Text = "flight_id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 12F);
            label2.Location = new Point(26, 182);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 2;
            label2.Text = "flight_number";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 12F);
            label3.Location = new Point(26, 245);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 3;
            label3.Text = "arrival_airport";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 12F);
            label4.Location = new Point(26, 307);
            label4.Name = "label4";
            label4.Size = new Size(147, 24);
            label4.TabIndex = 4;
            label4.Text = "arrival_datetime";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Imprint MT Shadow", 12F);
            label5.Location = new Point(385, 125);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 5;
            label5.Text = "airline";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Imprint MT Shadow", 12F);
            label6.Location = new Point(381, 182);
            label6.Name = "label6";
            label6.Size = new Size(159, 24);
            label6.TabIndex = 6;
            label6.Text = "departure_airport";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Imprint MT Shadow", 12F);
            label7.Location = new Point(381, 249);
            label7.Name = "label7";
            label7.Size = new Size(175, 24);
            label7.TabIndex = 7;
            label7.Text = "departure_datetime";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Imprint MT Shadow", 12F);
            label8.Location = new Point(389, 307);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 8;
            label8.Text = "status";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 125);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 9;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 179);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 10;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(192, 245);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 11;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(192, 304);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 27);
            dateTimePicker1.TabIndex = 12;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Imprint MT Shadow", 10.2F);
            textBox3.Location = new Point(489, 125);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 13;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(576, 178);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 28);
            comboBox2.TabIndex = 14;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(576, 249);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 27);
            dateTimePicker2.TabIndex = 15;
            // 
            // record
            // 
            record.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            record.Location = new Point(389, 381);
            record.Name = "record";
            record.Size = new Size(125, 40);
            record.TabIndex = 16;
            record.Text = "Record";
            record.UseVisualStyleBackColor = true;
            record.Click += record_Click;
            // 
            // button2
            // 
            button2.Location = new Point(694, 409);
            button2.Name = "button2";
            button2.Size = new Size(94, 29);
            button2.TabIndex = 17;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // airportName
            // 
            airportName.AutoSize = true;
            airportName.BackColor = SystemColors.InactiveCaption;
            airportName.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            airportName.ForeColor = SystemColors.ActiveCaptionText;
            airportName.Image = Properties.Resources.why_sky_blue_2db86ae;
            airportName.Location = new Point(266, 9);
            airportName.Name = "airportName";
            airportName.Size = new Size(232, 34);
            airportName.TabIndex = 18;
            airportName.Text = "Airport Sofia";
            // 
            // newFlights
            // 
            newFlights.AutoSize = true;
            newFlights.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newFlights.ForeColor = SystemColors.HotTrack;
            newFlights.Location = new Point(272, 60);
            newFlights.Name = "newFlights";
            newFlights.Size = new Size(226, 23);
            newFlights.TabIndex = 19;
            newFlights.Text = "Record New Flights";
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(476, 307);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 20;
            // 
            // FlightTbl
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(800, 450);
            Controls.Add(comboBox3);
            Controls.Add(newFlights);
            Controls.Add(airportName);
            Controls.Add(button2);
            Controls.Add(record);
            Controls.Add(dateTimePicker2);
            Controls.Add(comboBox2);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(comboBox1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "FlightTbl";
            Text = "FlightTbl";
            Load += FlightTbl_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private Label label7;
        private Label label8;
        private TextBox textBox1;
        private TextBox textBox2;
        private ComboBox comboBox1;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox3;
        private ComboBox comboBox2;
        private DateTimePicker dateTimePicker2;
        private Button record;
        private Button button2;
        private Label airportName;
        private Label newFlights;
        private ComboBox comboBox3;
    }
}