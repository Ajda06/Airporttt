namespace Airport
{
    partial class AddPassengers
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
            comboBox3 = new ComboBox();
            newFlights = new Label();
            airportName = new Label();
            record = new Button();
            textBox3 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            textBox2 = new TextBox();
            textBox1 = new TextBox();
            label8 = new Label();
            label5 = new Label();
            label4 = new Label();
            label3 = new Label();
            label2 = new Label();
            label1 = new Label();
            textBox5 = new TextBox();
            SuspendLayout();
            // 
            // comboBox3
            // 
            comboBox3.FormattingEnabled = true;
            comboBox3.Location = new Point(469, 309);
            comboBox3.Name = "comboBox3";
            comboBox3.Size = new Size(193, 28);
            comboBox3.TabIndex = 40;
            // 
            // newFlights
            // 
            newFlights.AutoSize = true;
            newFlights.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newFlights.ForeColor = SystemColors.HotTrack;
            newFlights.Location = new Point(287, 55);
            newFlights.Name = "newFlights";
            newFlights.Size = new Size(166, 23);
            newFlights.TabIndex = 39;
            newFlights.Text = "Add Passenger";
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
            record.Location = new Point(311, 382);
            record.Name = "record";
            record.Size = new Size(125, 40);
            record.TabIndex = 36;
            record.Text = "Add";
            record.UseVisualStyleBackColor = true;
            record.Click += record_Click;
            // 
            // textBox3
            // 
            textBox3.Font = new Font("Imprint MT Shadow", 10.2F);
            textBox3.Location = new Point(482, 127);
            textBox3.Name = "textBox3";
            textBox3.Size = new Size(180, 28);
            textBox3.TabIndex = 33;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(148, 306);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(167, 27);
            dateTimePicker1.TabIndex = 32;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(148, 225);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(167, 27);
            textBox2.TabIndex = 30;
            // 
            // textBox1
            // 
            textBox1.Location = new Point(148, 127);
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
            label8.Size = new Size(68, 24);
            label8.TabIndex = 28;
            label8.Text = "gender";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Font = new Font("Imprint MT Shadow", 12F);
            label5.Location = new Point(378, 127);
            label5.Name = "label5";
            label5.Size = new Size(95, 24);
            label5.TabIndex = 25;
            label5.Text = "first name";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Imprint MT Shadow", 12F);
            label4.Location = new Point(19, 309);
            label4.Name = "label4";
            label4.Size = new Size(97, 24);
            label4.TabIndex = 24;
            label4.Text = "nationality";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Imprint MT Shadow", 12F);
            label3.Location = new Point(382, 228);
            label3.Name = "label3";
            label3.Size = new Size(81, 24);
            label3.TabIndex = 23;
            label3.Text = "passport";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Imprint MT Shadow", 12F);
            label2.Location = new Point(19, 225);
            label2.Name = "label2";
            label2.Size = new Size(90, 24);
            label2.TabIndex = 22;
            label2.Text = "last name";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Imprint MT Shadow", 12F);
            label1.Location = new Point(19, 127);
            label1.Name = "label1";
            label1.Size = new Size(119, 24);
            label1.TabIndex = 21;
            label1.Text = "passenger_id";
            // 
            // textBox5
            // 
            textBox5.Font = new Font("Imprint MT Shadow", 10.2F);
            textBox5.Location = new Point(482, 225);
            textBox5.Name = "textBox5";
            textBox5.Size = new Size(180, 28);
            textBox5.TabIndex = 41;
            // 
            // AddPassengers
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 454);
            Controls.Add(textBox5);
            Controls.Add(comboBox3);
            Controls.Add(newFlights);
            Controls.Add(airportName);
            Controls.Add(record);
            Controls.Add(textBox3);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label8);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "AddPassengers";
            Text = "AddPassengers";
            Load += AddPassengers_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox comboBox3;
        private Label newFlights;
        private Label airportName;
        private Button record;
        private TextBox textBox3;
        private DateTimePicker dateTimePicker1;
        private TextBox textBox2;
        private TextBox textBox1;
        private Label label8;
        private Label label5;
        private Label label4;
        private Label label3;
        private Label label2;
        private Label label1;
        private TextBox textBox5;
    }
}