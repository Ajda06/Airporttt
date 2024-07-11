namespace Airport
{
    partial class Cancellation
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
            airportName = new Label();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            textBox1 = new TextBox();
            textBox2 = new TextBox();
            dateTimePicker1 = new DateTimePicker();
            button1 = new Button();
            button2 = new Button();
            pictureBox1 = new PictureBox();
            newFlights = new Label();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            SuspendLayout();
            // 
            // airportName
            // 
            airportName.AutoSize = true;
            airportName.BackColor = SystemColors.InactiveCaption;
            airportName.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            airportName.ForeColor = SystemColors.ActiveCaptionText;
            airportName.Image = Properties.Resources.why_sky_blue_2db86ae;
            airportName.Location = new Point(230, 22);
            airportName.Name = "airportName";
            airportName.Size = new Size(232, 34);
            airportName.TabIndex = 59;
            airportName.Text = "Airport Sofia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(14, 155);
            label1.Name = "label1";
            label1.Size = new Size(63, 20);
            label1.TabIndex = 60;
            label1.Text = "Flight Id";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(14, 229);
            label2.Name = "label2";
            label2.Size = new Size(100, 20);
            label2.TabIndex = 61;
            label2.Text = "Booking Date";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(14, 300);
            label3.Name = "label3";
            label3.Size = new Size(104, 20);
            label3.TabIndex = 62;
            label3.Text = "Flight Number";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(124, 155);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(250, 27);
            textBox1.TabIndex = 63;
            // 
            // textBox2
            // 
            textBox2.Location = new Point(124, 297);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(250, 27);
            textBox2.TabIndex = 64;
            // 
            // dateTimePicker1
            // 
            dateTimePicker1.Location = new Point(124, 229);
            dateTimePicker1.Name = "dateTimePicker1";
            dateTimePicker1.Size = new Size(250, 27);
            dateTimePicker1.TabIndex = 65;
            // 
            // button1
            // 
            button1.Location = new Point(124, 381);
            button1.Name = "button1";
            button1.Size = new Size(250, 29);
            button1.TabIndex = 66;
            button1.Text = "Cancel";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(455, 381);
            button2.Name = "button2";
            button2.Size = new Size(158, 29);
            button2.TabIndex = 67;
            button2.Text = "Back";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = Properties.Resources.istockphoto_1280799994_612x612;
            pictureBox1.Location = new Point(433, 155);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(194, 193);
            pictureBox1.SizeMode = PictureBoxSizeMode.Zoom;
            pictureBox1.TabIndex = 68;
            pictureBox1.TabStop = false;
            // 
            // newFlights
            // 
            newFlights.AutoSize = true;
            newFlights.BackColor = Color.Red;
            newFlights.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newFlights.ForeColor = SystemColors.ControlText;
            newFlights.Location = new Point(230, 78);
            newFlights.Name = "newFlights";
            newFlights.Size = new Size(238, 23);
            newFlights.TabIndex = 69;
            newFlights.Text = "Flight cancellation";
            // 
            // Cancellation
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(647, 450);
            Controls.Add(newFlights);
            Controls.Add(pictureBox1);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(dateTimePicker1);
            Controls.Add(textBox2);
            Controls.Add(textBox1);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(airportName);
            Name = "Cancellation";
            Text = "Cancellation";
            Load += Cancellation_Load;
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label airportName;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox textBox1;
        private TextBox textBox2;
        private DateTimePicker dateTimePicker1;
        private Button button1;
        private Button button2;
        private PictureBox pictureBox1;
        private Label newFlights;
    }
}