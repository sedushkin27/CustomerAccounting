namespace WinFormsApp1
{
    partial class Form1
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
            buttonEnter = new Button();
            label1 = new Label();
            addName = new TextBox();
            label2 = new Label();
            startDateTime = new DateTimePicker();
            label3 = new Label();
            label4 = new Label();
            deleteName = new TextBox();
            label5 = new Label();
            buttonDelete = new Button();
            listBox1 = new ListBox();
            buttonDeleteAll = new Button();
            label6 = new Label();
            HowLongTime = new TextBox();
            SuspendLayout();
            // 
            // buttonEnter
            // 
            buttonEnter.Location = new Point(12, 189);
            buttonEnter.Name = "buttonEnter";
            buttonEnter.Size = new Size(128, 49);
            buttonEnter.TabIndex = 0;
            buttonEnter.Text = "Enter";
            buttonEnter.UseVisualStyleBackColor = true;
            buttonEnter.Click += buttonEnter_Click;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(12, 37);
            label1.Name = "label1";
            label1.Size = new Size(39, 15);
            label1.TabIndex = 1;
            label1.Text = "Name";
            // 
            // addName
            // 
            addName.Location = new Point(12, 55);
            addName.Name = "addName";
            addName.Size = new Size(128, 23);
            addName.TabIndex = 4;
            addName.TextChanged += nameText_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(12, 85);
            label2.Name = "label2";
            label2.Size = new Size(31, 15);
            label2.TabIndex = 6;
            label2.Text = "Date";
            // 
            // startDateTime
            // 
            startDateTime.CustomFormat = "dd.MM.yyyy HH:mm";
            startDateTime.Format = DateTimePickerFormat.Custom;
            startDateTime.Location = new Point(12, 103);
            startDateTime.Name = "startDateTime";
            startDateTime.Size = new Size(128, 23);
            startDateTime.TabIndex = 8;
            startDateTime.ValueChanged += dateTimePicker1_ValueChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(13, 9);
            label3.Name = "label3";
            label3.Size = new Size(94, 15);
            label3.TabIndex = 9;
            label3.Text = "Add a customer ";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(13, 250);
            label4.Name = "label4";
            label4.Size = new Size(105, 15);
            label4.TabIndex = 12;
            label4.Text = "Delete a customer ";
            // 
            // deleteName
            // 
            deleteName.Location = new Point(12, 296);
            deleteName.Name = "deleteName";
            deleteName.Size = new Size(128, 23);
            deleteName.TabIndex = 11;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(12, 278);
            label5.Name = "label5";
            label5.Size = new Size(39, 15);
            label5.TabIndex = 10;
            label5.Text = "Name";
            // 
            // buttonDelete
            // 
            buttonDelete.Location = new Point(12, 337);
            buttonDelete.Name = "buttonDelete";
            buttonDelete.Size = new Size(128, 49);
            buttonDelete.TabIndex = 13;
            buttonDelete.Text = "Delete";
            buttonDelete.UseVisualStyleBackColor = true;
            buttonDelete.Click += ButtonDelete_Click;
            // 
            // listBox1
            // 
            listBox1.Dock = DockStyle.Right;
            listBox1.Font = new Font("Segoe UI Semibold", 12F, FontStyle.Bold, GraphicsUnit.Point);
            listBox1.FormattingEnabled = true;
            listBox1.ItemHeight = 21;
            listBox1.Location = new Point(164, 0);
            listBox1.Name = "listBox1";
            listBox1.Size = new Size(391, 456);
            listBox1.TabIndex = 16;
            // 
            // buttonDeleteAll
            // 
            buttonDeleteAll.Location = new Point(12, 392);
            buttonDeleteAll.Name = "buttonDeleteAll";
            buttonDeleteAll.Size = new Size(128, 49);
            buttonDeleteAll.TabIndex = 17;
            buttonDeleteAll.Text = "delete all ";
            buttonDeleteAll.UseVisualStyleBackColor = true;
            buttonDeleteAll.Click += ButtonDeleteAll_Click;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(13, 129);
            label6.Name = "label6";
            label6.Size = new Size(115, 15);
            label6.TabIndex = 18;
            label6.Text = "How long it will take";
            // 
            // HowLongTime
            // 
            HowLongTime.Location = new Point(13, 147);
            HowLongTime.Name = "HowLongTime";
            HowLongTime.Size = new Size(127, 23);
            HowLongTime.TabIndex = 19;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(555, 456);
            Controls.Add(HowLongTime);
            Controls.Add(label6);
            Controls.Add(buttonDeleteAll);
            Controls.Add(listBox1);
            Controls.Add(buttonDelete);
            Controls.Add(label4);
            Controls.Add(deleteName);
            Controls.Add(label5);
            Controls.Add(label3);
            Controls.Add(startDateTime);
            Controls.Add(label2);
            Controls.Add(addName);
            Controls.Add(label1);
            Controls.Add(buttonEnter);
            Name = "Form1";
            Text = "clients";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button buttonEnter;
        private Label label1;
        private TextBox addName;
        private Label label2;
        private DateTimePicker startDateTime;
        private Label label3;
        private Label label4;
        private TextBox deleteName;
        private Label label5;
        private Button buttonDelete;
        private ListBox listBox1;
        private Button buttonDeleteAll;
        private Label label6;
        private TextBox HowLongTime;
    }
}