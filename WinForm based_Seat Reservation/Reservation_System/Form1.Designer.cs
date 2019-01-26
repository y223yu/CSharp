namespace Reservation_System
{
    partial class Form1
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
            this.richTextBoxWaitingList = new System.Windows.Forms.RichTextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.buttonAddWaitingList = new System.Windows.Forms.Button();
            this.buttonCancel = new System.Windows.Forms.Button();
            this.buttonBooking = new System.Windows.Forms.Button();
            this.labelStatus = new System.Windows.Forms.Label();
            this.buttonStatus = new System.Windows.Forms.Button();
            this.listBoxColumn = new System.Windows.Forms.ListBox();
            this.listBoxRow = new System.Windows.Forms.ListBox();
            this.textBoxName = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.seatE1 = new System.Windows.Forms.Button();
            this.seatE0 = new System.Windows.Forms.Button();
            this.seatE2 = new System.Windows.Forms.Button();
            this.buttonShowWaitingList = new System.Windows.Forms.Button();
            this.richTextBoxShowAll = new System.Windows.Forms.RichTextBox();
            this.buttonShowAll = new System.Windows.Forms.Button();
            this.buttonFillAll = new System.Windows.Forms.Button();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.seatD2 = new System.Windows.Forms.Button();
            this.seatD1 = new System.Windows.Forms.Button();
            this.seatD0 = new System.Windows.Forms.Button();
            this.seatC2 = new System.Windows.Forms.Button();
            this.seatC1 = new System.Windows.Forms.Button();
            this.seatC0 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.seatB2 = new System.Windows.Forms.Button();
            this.seatB1 = new System.Windows.Forms.Button();
            this.seatB0 = new System.Windows.Forms.Button();
            this.seatA2 = new System.Windows.Forms.Button();
            this.seatA1 = new System.Windows.Forms.Button();
            this.seatA0 = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.buttonReleaseAll = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBoxWaitingList
            // 
            this.richTextBoxWaitingList.BackColor = System.Drawing.Color.White;
            this.richTextBoxWaitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxWaitingList.Location = new System.Drawing.Point(422, 379);
            this.richTextBoxWaitingList.Name = "richTextBoxWaitingList";
            this.richTextBoxWaitingList.ReadOnly = true;
            this.richTextBoxWaitingList.Size = new System.Drawing.Size(313, 300);
            this.richTextBoxWaitingList.TabIndex = 61;
            this.richTextBoxWaitingList.Text = "";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.buttonAddWaitingList);
            this.groupBox1.Controls.Add(this.buttonCancel);
            this.groupBox1.Controls.Add(this.buttonBooking);
            this.groupBox1.Controls.Add(this.labelStatus);
            this.groupBox1.Controls.Add(this.buttonStatus);
            this.groupBox1.Controls.Add(this.listBoxColumn);
            this.groupBox1.Controls.Add(this.listBoxRow);
            this.groupBox1.Controls.Add(this.textBoxName);
            this.groupBox1.Controls.Add(this.label9);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(461, 25);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(528, 263);
            this.groupBox1.TabIndex = 56;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Booling and Cancellation";
            // 
            // buttonAddWaitingList
            // 
            this.buttonAddWaitingList.Location = new System.Drawing.Point(307, 155);
            this.buttonAddWaitingList.Name = "buttonAddWaitingList";
            this.buttonAddWaitingList.Size = new System.Drawing.Size(215, 39);
            this.buttonAddWaitingList.TabIndex = 28;
            this.buttonAddWaitingList.Text = "Add To Waiting List";
            this.buttonAddWaitingList.UseVisualStyleBackColor = true;
            this.buttonAddWaitingList.Click += new System.EventHandler(this.buttonAddWaitingList_Click);
            // 
            // buttonCancel
            // 
            this.buttonCancel.Location = new System.Drawing.Point(307, 98);
            this.buttonCancel.Name = "buttonCancel";
            this.buttonCancel.Size = new System.Drawing.Size(215, 39);
            this.buttonCancel.TabIndex = 27;
            this.buttonCancel.Text = "Cancel";
            this.buttonCancel.UseVisualStyleBackColor = true;
            this.buttonCancel.Click += new System.EventHandler(this.buttonCancel_Click);
            // 
            // buttonBooking
            // 
            this.buttonBooking.Location = new System.Drawing.Point(307, 41);
            this.buttonBooking.Name = "buttonBooking";
            this.buttonBooking.Size = new System.Drawing.Size(215, 39);
            this.buttonBooking.TabIndex = 26;
            this.buttonBooking.Text = "Book";
            this.buttonBooking.UseVisualStyleBackColor = true;
            this.buttonBooking.Click += new System.EventHandler(this.buttonBooking_Click);
            // 
            // labelStatus
            // 
            this.labelStatus.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.labelStatus.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.labelStatus.Location = new System.Drawing.Point(95, 218);
            this.labelStatus.Name = "labelStatus";
            this.labelStatus.Size = new System.Drawing.Size(427, 39);
            this.labelStatus.TabIndex = 25;
            this.labelStatus.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // buttonStatus
            // 
            this.buttonStatus.Location = new System.Drawing.Point(12, 218);
            this.buttonStatus.Name = "buttonStatus";
            this.buttonStatus.Size = new System.Drawing.Size(77, 39);
            this.buttonStatus.TabIndex = 24;
            this.buttonStatus.Text = "status";
            this.buttonStatus.UseVisualStyleBackColor = true;
            this.buttonStatus.Click += new System.EventHandler(this.buttonStatus_Click);
            // 
            // listBoxColumn
            // 
            this.listBoxColumn.FormattingEnabled = true;
            this.listBoxColumn.ItemHeight = 25;
            this.listBoxColumn.Items.AddRange(new object[] {
            "0",
            "1",
            "2"});
            this.listBoxColumn.Location = new System.Drawing.Point(178, 78);
            this.listBoxColumn.Name = "listBoxColumn";
            this.listBoxColumn.Size = new System.Drawing.Size(123, 129);
            this.listBoxColumn.TabIndex = 3;
            // 
            // listBoxRow
            // 
            this.listBoxRow.FormattingEnabled = true;
            this.listBoxRow.ItemHeight = 25;
            this.listBoxRow.Items.AddRange(new object[] {
            "A",
            "B",
            "C",
            "D",
            "E"});
            this.listBoxRow.Location = new System.Drawing.Point(12, 78);
            this.listBoxRow.Name = "listBoxRow";
            this.listBoxRow.Size = new System.Drawing.Size(123, 129);
            this.listBoxRow.TabIndex = 2;
            // 
            // textBoxName
            // 
            this.textBoxName.Location = new System.Drawing.Point(95, 41);
            this.textBoxName.Name = "textBoxName";
            this.textBoxName.Size = new System.Drawing.Size(206, 30);
            this.textBoxName.TabIndex = 1;
            // 
            // label9
            // 
            this.label9.Location = new System.Drawing.Point(7, 41);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(82, 31);
            this.label9.TabIndex = 0;
            this.label9.Text = "Name:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(49, 253);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(25, 25);
            this.label8.TabIndex = 55;
            this.label8.Text = "E";
            // 
            // seatE1
            // 
            this.seatE1.BackColor = System.Drawing.Color.LightBlue;
            this.seatE1.Location = new System.Drawing.Point(204, 245);
            this.seatE1.Name = "seatE1";
            this.seatE1.Size = new System.Drawing.Size(117, 44);
            this.seatE1.TabIndex = 53;
            this.seatE1.UseVisualStyleBackColor = false;
            this.seatE1.Click += new System.EventHandler(this.seatE1_Click);
            // 
            // seatE0
            // 
            this.seatE0.BackColor = System.Drawing.Color.LightBlue;
            this.seatE0.Location = new System.Drawing.Point(81, 245);
            this.seatE0.Name = "seatE0";
            this.seatE0.Size = new System.Drawing.Size(117, 44);
            this.seatE0.TabIndex = 52;
            this.seatE0.UseVisualStyleBackColor = false;
            this.seatE0.Click += new System.EventHandler(this.seatE0_Click);
            // 
            // seatE2
            // 
            this.seatE2.BackColor = System.Drawing.Color.LightBlue;
            this.seatE2.Location = new System.Drawing.Point(327, 245);
            this.seatE2.Name = "seatE2";
            this.seatE2.Size = new System.Drawing.Size(117, 44);
            this.seatE2.TabIndex = 54;
            this.seatE2.UseVisualStyleBackColor = false;
            this.seatE2.Click += new System.EventHandler(this.seatE2_Click);
            // 
            // buttonShowWaitingList
            // 
            this.buttonShowWaitingList.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowWaitingList.Location = new System.Drawing.Point(419, 320);
            this.buttonShowWaitingList.Name = "buttonShowWaitingList";
            this.buttonShowWaitingList.Size = new System.Drawing.Size(316, 39);
            this.buttonShowWaitingList.TabIndex = 60;
            this.buttonShowWaitingList.Text = "Show Waiting List";
            this.buttonShowWaitingList.UseVisualStyleBackColor = true;
            this.buttonShowWaitingList.Click += new System.EventHandler(this.buttonShowWaitingList_Click);
            // 
            // richTextBoxShowAll
            // 
            this.richTextBoxShowAll.BackColor = System.Drawing.Color.White;
            this.richTextBoxShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.richTextBoxShowAll.Location = new System.Drawing.Point(84, 379);
            this.richTextBoxShowAll.Name = "richTextBoxShowAll";
            this.richTextBoxShowAll.ReadOnly = true;
            this.richTextBoxShowAll.Size = new System.Drawing.Size(313, 300);
            this.richTextBoxShowAll.TabIndex = 59;
            this.richTextBoxShowAll.Text = "seatA1: \nseatA2: \nseatB0: \nseatB1: \nseatB2: \nseatC0: \nseatC1: \nseatC2: \nseatD0: \n" +
    "seatD1: \nseatD2: \nseatE0: \nseatE1:\nseatE2: ";
            // 
            // buttonShowAll
            // 
            this.buttonShowAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonShowAll.Location = new System.Drawing.Point(81, 320);
            this.buttonShowAll.Name = "buttonShowAll";
            this.buttonShowAll.Size = new System.Drawing.Size(316, 39);
            this.buttonShowAll.TabIndex = 58;
            this.buttonShowAll.Text = "Show All";
            this.buttonShowAll.UseVisualStyleBackColor = true;
            this.buttonShowAll.Click += new System.EventHandler(this.buttonShowAll_Click);
            // 
            // buttonFillAll
            // 
            this.buttonFillAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonFillAll.Location = new System.Drawing.Point(768, 320);
            this.buttonFillAll.Name = "buttonFillAll";
            this.buttonFillAll.Size = new System.Drawing.Size(221, 39);
            this.buttonFillAll.TabIndex = 57;
            this.buttonFillAll.Text = "Fill All (debug)";
            this.buttonFillAll.UseVisualStyleBackColor = true;
            this.buttonFillAll.Click += new System.EventHandler(this.buttonFillAll_Click);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(49, 203);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(26, 25);
            this.label7.TabIndex = 51;
            this.label7.Text = "D";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(49, 153);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 25);
            this.label6.TabIndex = 50;
            this.label6.Text = "C";
            // 
            // seatD2
            // 
            this.seatD2.BackColor = System.Drawing.Color.LightBlue;
            this.seatD2.Location = new System.Drawing.Point(327, 195);
            this.seatD2.Name = "seatD2";
            this.seatD2.Size = new System.Drawing.Size(117, 44);
            this.seatD2.TabIndex = 49;
            this.seatD2.UseVisualStyleBackColor = false;
            this.seatD2.Click += new System.EventHandler(this.seatD2_Click);
            // 
            // seatD1
            // 
            this.seatD1.BackColor = System.Drawing.Color.LightBlue;
            this.seatD1.Location = new System.Drawing.Point(204, 195);
            this.seatD1.Name = "seatD1";
            this.seatD1.Size = new System.Drawing.Size(117, 44);
            this.seatD1.TabIndex = 48;
            this.seatD1.UseVisualStyleBackColor = false;
            this.seatD1.Click += new System.EventHandler(this.seatD1_Click);
            // 
            // seatD0
            // 
            this.seatD0.BackColor = System.Drawing.Color.LightBlue;
            this.seatD0.Location = new System.Drawing.Point(81, 195);
            this.seatD0.Name = "seatD0";
            this.seatD0.Size = new System.Drawing.Size(117, 44);
            this.seatD0.TabIndex = 47;
            this.seatD0.UseVisualStyleBackColor = false;
            this.seatD0.Click += new System.EventHandler(this.seatD0_Click);
            // 
            // seatC2
            // 
            this.seatC2.BackColor = System.Drawing.Color.LightBlue;
            this.seatC2.Location = new System.Drawing.Point(327, 145);
            this.seatC2.Name = "seatC2";
            this.seatC2.Size = new System.Drawing.Size(117, 44);
            this.seatC2.TabIndex = 46;
            this.seatC2.UseVisualStyleBackColor = false;
            this.seatC2.Click += new System.EventHandler(this.seatC2_Click);
            // 
            // seatC1
            // 
            this.seatC1.BackColor = System.Drawing.Color.LightBlue;
            this.seatC1.Location = new System.Drawing.Point(204, 145);
            this.seatC1.Name = "seatC1";
            this.seatC1.Size = new System.Drawing.Size(117, 44);
            this.seatC1.TabIndex = 45;
            this.seatC1.UseVisualStyleBackColor = false;
            this.seatC1.Click += new System.EventHandler(this.seatC1_Click);
            // 
            // seatC0
            // 
            this.seatC0.BackColor = System.Drawing.Color.LightBlue;
            this.seatC0.Location = new System.Drawing.Point(81, 145);
            this.seatC0.Name = "seatC0";
            this.seatC0.Size = new System.Drawing.Size(117, 44);
            this.seatC0.TabIndex = 44;
            this.seatC0.UseVisualStyleBackColor = false;
            this.seatC0.Click += new System.EventHandler(this.seatC0_Click);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(49, 103);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(25, 25);
            this.label5.TabIndex = 43;
            this.label5.Text = "B";
            // 
            // seatB2
            // 
            this.seatB2.BackColor = System.Drawing.Color.LightBlue;
            this.seatB2.Location = new System.Drawing.Point(327, 95);
            this.seatB2.Name = "seatB2";
            this.seatB2.Size = new System.Drawing.Size(117, 44);
            this.seatB2.TabIndex = 42;
            this.seatB2.UseVisualStyleBackColor = false;
            this.seatB2.Click += new System.EventHandler(this.seatB2_Click);
            // 
            // seatB1
            // 
            this.seatB1.BackColor = System.Drawing.Color.LightBlue;
            this.seatB1.Location = new System.Drawing.Point(204, 95);
            this.seatB1.Name = "seatB1";
            this.seatB1.Size = new System.Drawing.Size(117, 44);
            this.seatB1.TabIndex = 41;
            this.seatB1.UseVisualStyleBackColor = false;
            this.seatB1.Click += new System.EventHandler(this.seatB1_Click);
            // 
            // seatB0
            // 
            this.seatB0.BackColor = System.Drawing.Color.LightBlue;
            this.seatB0.Location = new System.Drawing.Point(81, 95);
            this.seatB0.Name = "seatB0";
            this.seatB0.Size = new System.Drawing.Size(117, 44);
            this.seatB0.TabIndex = 40;
            this.seatB0.UseVisualStyleBackColor = false;
            this.seatB0.Click += new System.EventHandler(this.seatB0_Click);
            // 
            // seatA2
            // 
            this.seatA2.BackColor = System.Drawing.Color.LightBlue;
            this.seatA2.Location = new System.Drawing.Point(327, 45);
            this.seatA2.Name = "seatA2";
            this.seatA2.Size = new System.Drawing.Size(117, 44);
            this.seatA2.TabIndex = 39;
            this.seatA2.UseVisualStyleBackColor = false;
            this.seatA2.Click += new System.EventHandler(this.seatA2_Click);
            // 
            // seatA1
            // 
            this.seatA1.BackColor = System.Drawing.Color.LightBlue;
            this.seatA1.Location = new System.Drawing.Point(204, 45);
            this.seatA1.Name = "seatA1";
            this.seatA1.Size = new System.Drawing.Size(117, 44);
            this.seatA1.TabIndex = 38;
            this.seatA1.UseVisualStyleBackColor = false;
            this.seatA1.Click += new System.EventHandler(this.seatA1_Click);
            // 
            // seatA0
            // 
            this.seatA0.BackColor = System.Drawing.Color.LightBlue;
            this.seatA0.Location = new System.Drawing.Point(81, 45);
            this.seatA0.Name = "seatA0";
            this.seatA0.Size = new System.Drawing.Size(117, 44);
            this.seatA0.TabIndex = 37;
            this.seatA0.UseVisualStyleBackColor = false;
            this.seatA0.Click += new System.EventHandler(this.seatA0_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(49, 53);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(26, 25);
            this.label4.TabIndex = 36;
            this.label4.Text = "A";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(252, 18);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(23, 25);
            this.label3.TabIndex = 35;
            this.label3.Text = "1";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(374, 18);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(23, 25);
            this.label2.TabIndex = 34;
            this.label2.Text = "2";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(129, 17);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(23, 25);
            this.label1.TabIndex = 33;
            this.label1.Text = "0";
            // 
            // buttonReleaseAll
            // 
            this.buttonReleaseAll.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonReleaseAll.Location = new System.Drawing.Point(768, 379);
            this.buttonReleaseAll.Name = "buttonReleaseAll";
            this.buttonReleaseAll.Size = new System.Drawing.Size(221, 39);
            this.buttonReleaseAll.TabIndex = 62;
            this.buttonReleaseAll.Text = "Release All";
            this.buttonReleaseAll.UseVisualStyleBackColor = true;
            this.buttonReleaseAll.Visible = false;
            this.buttonReleaseAll.Click += new System.EventHandler(this.buttonReleaseAll_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1020, 697);
            this.Controls.Add(this.buttonReleaseAll);
            this.Controls.Add(this.richTextBoxWaitingList);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.seatE1);
            this.Controls.Add(this.seatE0);
            this.Controls.Add(this.seatE2);
            this.Controls.Add(this.buttonShowWaitingList);
            this.Controls.Add(this.richTextBoxShowAll);
            this.Controls.Add(this.buttonShowAll);
            this.Controls.Add(this.buttonFillAll);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.seatD2);
            this.Controls.Add(this.seatD1);
            this.Controls.Add(this.seatD0);
            this.Controls.Add(this.seatC2);
            this.Controls.Add(this.seatC1);
            this.Controls.Add(this.seatC0);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.seatB2);
            this.Controls.Add(this.seatB1);
            this.Controls.Add(this.seatB0);
            this.Controls.Add(this.seatA2);
            this.Controls.Add(this.seatA1);
            this.Controls.Add(this.seatA0);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBoxWaitingList;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button buttonAddWaitingList;
        private System.Windows.Forms.Button buttonCancel;
        private System.Windows.Forms.Button buttonBooking;
        private System.Windows.Forms.Label labelStatus;
        private System.Windows.Forms.Button buttonStatus;
        private System.Windows.Forms.ListBox listBoxColumn;
        private System.Windows.Forms.ListBox listBoxRow;
        private System.Windows.Forms.TextBox textBoxName;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Button seatE1;
        private System.Windows.Forms.Button seatE0;
        private System.Windows.Forms.Button seatE2;
        private System.Windows.Forms.Button buttonShowWaitingList;
        private System.Windows.Forms.RichTextBox richTextBoxShowAll;
        private System.Windows.Forms.Button buttonShowAll;
        private System.Windows.Forms.Button buttonFillAll;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button seatD2;
        private System.Windows.Forms.Button seatD1;
        private System.Windows.Forms.Button seatD0;
        private System.Windows.Forms.Button seatC2;
        private System.Windows.Forms.Button seatC1;
        private System.Windows.Forms.Button seatC0;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button seatB2;
        private System.Windows.Forms.Button seatB1;
        private System.Windows.Forms.Button seatB0;
        private System.Windows.Forms.Button seatA2;
        private System.Windows.Forms.Button seatA1;
        private System.Windows.Forms.Button seatA0;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button buttonReleaseAll;
    }
}

