namespace Airport
{
    partial class Ticket
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
            richTextBox1 = new RichTextBox();
            richTextBox2 = new RichTextBox();
            airportName = new Label();
            label1 = new Label();
            newFlights = new Label();
            textBox1 = new TextBox();
            label2 = new Label();
            textBox2 = new TextBox();
            button1 = new Button();
            button2 = new Button();
            button3 = new Button();
            SuspendLayout();
            // 
            // richTextBox1
            // 
            richTextBox1.Location = new Point(54, 199);
            richTextBox1.Name = "richTextBox1";
            richTextBox1.Size = new Size(678, 209);
            richTextBox1.TabIndex = 0;
            richTextBox1.Text = "";
            // 
            // richTextBox2
            // 
            richTextBox2.Location = new Point(54, 464);
            richTextBox2.Name = "richTextBox2";
            richTextBox2.Size = new Size(678, 209);
            richTextBox2.TabIndex = 1;
            richTextBox2.Text = "";
            // 
            // airportName
            // 
            airportName.AutoSize = true;
            airportName.BackColor = SystemColors.InactiveCaption;
            airportName.Font = new Font("Algerian", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            airportName.ForeColor = SystemColors.ActiveCaptionText;
            airportName.Image = Properties.Resources.why_sky_blue_2db86ae;
            airportName.Location = new Point(288, 21);
            airportName.Name = "airportName";
            airportName.Size = new Size(232, 34);
            airportName.TabIndex = 58;
            airportName.Text = "Airport Sofia";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(69, 151);
            label1.Name = "label1";
            label1.Size = new Size(65, 20);
            label1.TabIndex = 59;
            label1.Text = "Ticket Id";
            // 
            // newFlights
            // 
            newFlights.AutoSize = true;
            newFlights.BackColor = Color.FromArgb(255, 192, 128);
            newFlights.Font = new Font("Courier New", 12F, FontStyle.Italic, GraphicsUnit.Point, 0);
            newFlights.ForeColor = SystemColors.HotTrack;
            newFlights.Location = new Point(337, 70);
            newFlights.Name = "newFlights";
            newFlights.Size = new Size(142, 23);
            newFlights.TabIndex = 60;
            newFlights.Text = "Information";
            // 
            // textBox1
            // 
            textBox1.Location = new Point(192, 151);
            textBox1.Name = "textBox1";
            textBox1.Size = new Size(220, 27);
            textBox1.TabIndex = 61;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(69, 425);
            label2.Name = "label2";
            label2.Size = new Size(63, 20);
            label2.TabIndex = 62;
            label2.Text = "Flight Id";
            // 
            // textBox2
            // 
            textBox2.Location = new Point(192, 422);
            textBox2.Name = "textBox2";
            textBox2.Size = new Size(220, 27);
            textBox2.TabIndex = 63;
            // 
            // button1
            // 
            button1.Location = new Point(469, 151);
            button1.Name = "button1";
            button1.Size = new Size(166, 29);
            button1.TabIndex = 64;
            button1.Text = "Info";
            button1.UseVisualStyleBackColor = true;
            button1.Click += button1_Click;
            // 
            // button2
            // 
            button2.Location = new Point(469, 422);
            button2.Name = "button2";
            button2.Size = new Size(166, 29);
            button2.TabIndex = 65;
            button2.Text = "Info";
            button2.UseVisualStyleBackColor = true;
            button2.Click += button2_Click;
            // 
            // button3
            // 
            button3.Location = new Point(337, 696);
            button3.Name = "button3";
            button3.Size = new Size(94, 29);
            button3.TabIndex = 66;
            button3.Text = "Back";
            button3.UseVisualStyleBackColor = true;
            button3.Click += button3_Click;
            // 
            // Ticket
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = Properties.Resources._37bf12e6f6e2466fa04766839978de31;
            ClientSize = new Size(800, 737);
            Controls.Add(button3);
            Controls.Add(button2);
            Controls.Add(button1);
            Controls.Add(textBox2);
            Controls.Add(label2);
            Controls.Add(textBox1);
            Controls.Add(newFlights);
            Controls.Add(label1);
            Controls.Add(airportName);
            Controls.Add(richTextBox2);
            Controls.Add(richTextBox1);
            Name = "Ticket";
            Text = "Ticket";
            Load += Ticket_Load;
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private RichTextBox richTextBox1;
        private RichTextBox richTextBox2;
        private Label airportName;
        private Label label1;
        private Label newFlights;
        private TextBox textBox1;
        private Label label2;
        private TextBox textBox2;
        private Button button1;
        private Button button2;
        private Button button3;
    }
}