namespace Airport
{
    partial class ViewFlights
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ViewFlights));
            comboBox3 = new ComboBox();
            newFlights = new Label();
            airportName = new Label();
            record = new Button();
            dateTimePicker2 = new DateTimePicker();
            comboBox2 = new ComboBox();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            comboBox1 = new ComboBox();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label7 = new Label();
            label6 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            button1 = new Button();
            button3 = new Button();
            button2 = new Button();
            listBox1 = new ListBox();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(469, 309);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(151, 28);
            comboBox3.TabIndex = 40;
            // 
            // newFlights
            // 
            newFlights.AutoSize = true;
            newFlights.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newFlights.ForeColor = SystemColors.HotTrack;
            newFlights.Location = new Point(243, 63);
            newFlights.Name = "newFlights";
            newFlights.Size = new Size(274, 23);
            newFlights.TabIndex = 39;
            newFlights.Text = "View Scheduled Flights";
            // 
            // airportName
            // 
            airportName.AutoSize = true;
            airportName.BackColor = SystemColors.InactiveCaption;
            airportName.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            airportName.ForeColor = SystemColors.ActiveCaptionText;
            airportName.Image = Properties.Resources.why_sky_blue_2db86ae;
            airportName.Location = new Point(259, 11);
            airportName.Name = "airportName";
            airportName.Size = new Size(232, 34);
            airportName.TabIndex = 38;
            airportName.Text = "Airport Sofia";
            // 
            // record
            // 
            record.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            record.Location = new Point(424, 383);
            record.Name = "record";
            record.Size = new Size(125, 40);
            record.TabIndex = 36;
            record.Text = "Reset";
            record.UseVisualStyleBackColor = true;
            // 
            // dateTimePicker2
            // 
            dateTimePicker2.Location = new Point(569, 251);
            dateTimePicker2.Name = "dateTimePicker2";
            dateTimePicker2.Size = new Size(193, 27);
            dateTimePicker2.TabIndex = 35;
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Location = new Point(569, 180);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(193, 28);
            comboBox2.TabIndex = 34;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Imprint MT Shadow", 10.2F);
            textBox3.Location = new Point(482, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(125, 28);
            textBox3.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(185, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Location = new Point(185, 247);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(167, 28);
            comboBox1.TabIndex = 31;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(185, 181);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(185, 127);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(167, 27);
            textBox1.TabIndex = 29;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Imprint MT Shadow", 12F);
            label8.Location = new Point(382, 309);
            label8.Name = "label8";
            label8.Size = new Size(58, 24);
            label8.TabIndex = 28;
            label8.Text = "status";
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Font = new Font("Imprint MT Shadow", 12F);
            label7.Location = new Point(374, 251);
            label7.Name = "label7";
            label7.Size = new Size(175, 24);
            label7.TabIndex = 27;
            label7.Text = "departure_datetime";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Font = new Font("Imprint MT Shadow", 12F);
            label6.Location = new Point(374, 184);
            label6.Name = "label6";
            label6.Size = new Size(159, 24);
            label6.TabIndex = 26;
            label6.Text = "departure_airport";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Imprint MT Shadow", 12F);
            label5.Location = new Point(378, 127);
            label5.Name = "label5";
            label5.Size = new Size(62, 24);
            label5.TabIndex = 25;
            label5.Text = "airline";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 12F);
            label4.Location = new Point(19, 309);
            label4.Name = "label4";
            label4.Size = new Size(147, 24);
            label4.TabIndex = 24;
            label4.Text = "arrival_datetime";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 12F);
            label3.Location = new Point(19, 247);
            label3.Name = "label3";
            label3.Size = new Size(131, 24);
            label3.TabIndex = 23;
            label3.Text = "arrival_airport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 12F);
            label2.Location = new Point(19, 184);
            label2.Name = "label2";
            label2.Size = new Size(131, 24);
            label2.TabIndex = 22;
            label2.Text = "flight_number";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 12F);
            label1.Location = new Point(19, 127);
            label1.Name = "label1";
            label1.Size = new Size(79, 24);
            label1.TabIndex = 21;
            label1.Text = "flight_id";
            // 
            // button1
            // 
            button1.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button1.Location = new Point(63, 383);
            button1.Name = "button1";
            button1.Size = new Size(125, 40);
            button1.TabIndex = 41;
            button1.Text = "Update";
            button1.UseVisualStyleBackColor = true;
            // 
            // button3
            // 
            button3.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button3.Location = new Point(259, 383);
            button3.Name = "button3";
            button3.Size = new Size(125, 40);
            button3.TabIndex = 42;
            button3.Text = "Delete";
            button3.UseVisualStyleBackColor = true;
            // 
            // button2
            // 
            button2.Font = new Font("Segoe UI", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 204);
            button2.Location = new Point(595, 383);
            button2.Name = "button2";
            button2.Size = new Size(125, 40);
            button2.TabIndex = 43;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            // 
            // listBox1
            // 
            listBox1.FormattingEnabled = true;
            listBox1.Location = new Point(38, 440);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(732, 184);
            listBox1.TabIndex = 44;
            // 
            // ViewFlights
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            ClientSize = new Size(875, 648);
            Controls.Add(listBox1);
            Controls.Add(button2);
            Controls.Add(button3);
            Controls.Add(button1);
            Controls.Add(comboBox3);
            Controls.Add(newFlights);
            Controls.Add(airportName);
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
            Name = "ViewFlights";
            Text = "ViewFlights";
            Load += ViewFlights_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox3;
        private Label newFlights;
        private Label airportName;
        private Button record;
        private DateTimePicker dateTimePicker2;
        private ComboBox comboBox2;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private ComboBox comboBox1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label7;
        private Label label6;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private Button button1;
        private Button button3;
        private Button button2;
        private ListBox listBox1;
    }
}