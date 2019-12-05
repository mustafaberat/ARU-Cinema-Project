namespace DataBase_CinemaProject
{
    partial class addSalon
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(addSalon));
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.addPositionButton = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.textBox2 = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.numericUpDownCapasity = new System.Windows.Forms.NumericUpDown();
            this.numericUpDownFloor = new System.Windows.Forms.NumericUpDown();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapasity)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).BeginInit();
            this.SuspendLayout();
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.Black;
            this.button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button1.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(149, 342);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(153, 46);
            this.button1.TabIndex = 33;
            this.button1.Text = "Refresh";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.Black;
            this.button2.Cursor = System.Windows.Forms.Cursors.Hand;
            this.button2.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.Location = new System.Drawing.Point(308, 342);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(246, 46);
            this.button2.TabIndex = 32;
            this.button2.Text = "Add Salon";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // addPositionButton
            // 
            this.addPositionButton.BackColor = System.Drawing.Color.Black;
            this.addPositionButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.addPositionButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.addPositionButton.ForeColor = System.Drawing.Color.White;
            this.addPositionButton.Location = new System.Drawing.Point(42, 342);
            this.addPositionButton.Name = "addPositionButton";
            this.addPositionButton.Size = new System.Drawing.Size(101, 46);
            this.addPositionButton.TabIndex = 31;
            this.addPositionButton.Text = "Close";
            this.addPositionButton.UseVisualStyleBackColor = false;
            this.addPositionButton.Click += new System.EventHandler(this.addPositionButton_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(42, 122);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.Size = new System.Drawing.Size(512, 191);
            this.dataGridView1.TabIndex = 30;
            // 
            // textBox2
            // 
            this.textBox2.Location = new System.Drawing.Point(140, 36);
            this.textBox2.Name = "textBox2";
            this.textBox2.Size = new System.Drawing.Size(414, 20);
            this.textBox2.TabIndex = 35;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(38, 37);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(96, 19);
            this.label1.TabIndex = 34;
            this.label1.Text = "Salon Name";
            // 
            // numericUpDownCapasity
            // 
            this.numericUpDownCapasity.Increment = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownCapasity.Location = new System.Drawing.Point(140, 73);
            this.numericUpDownCapasity.Maximum = new decimal(new int[] {
            400,
            0,
            0,
            0});
            this.numericUpDownCapasity.Minimum = new decimal(new int[] {
            60,
            0,
            0,
            0});
            this.numericUpDownCapasity.Name = "numericUpDownCapasity";
            this.numericUpDownCapasity.Size = new System.Drawing.Size(68, 20);
            this.numericUpDownCapasity.TabIndex = 48;
            this.numericUpDownCapasity.Value = new decimal(new int[] {
            60,
            0,
            0,
            0});
            // 
            // numericUpDownFloor
            // 
            this.numericUpDownFloor.Location = new System.Drawing.Point(511, 73);
            this.numericUpDownFloor.Maximum = new decimal(new int[] {
            10,
            0,
            0,
            0});
            this.numericUpDownFloor.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.numericUpDownFloor.Name = "numericUpDownFloor";
            this.numericUpDownFloor.Size = new System.Drawing.Size(43, 20);
            this.numericUpDownFloor.TabIndex = 47;
            this.numericUpDownFloor.Value = new decimal(new int[] {
            5,
            0,
            0,
            0});
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(438, 74);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 19);
            this.label3.TabIndex = 46;
            this.label3.Text = "Floor";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Black;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.label4.ForeColor = System.Drawing.Color.White;
            this.label4.Location = new System.Drawing.Point(38, 74);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(72, 19);
            this.label4.TabIndex = 45;
            this.label4.Text = "Capasity";
            // 
            // addSalon
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(603, 422);
            this.Controls.Add(this.numericUpDownCapasity);
            this.Controls.Add(this.numericUpDownFloor);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.textBox2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.addPositionButton);
            this.Controls.Add(this.dataGridView1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "addSalon";
            this.Text = "Adding Salon";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownCapasity)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numericUpDownFloor)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Button addPositionButton;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.TextBox textBox2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.NumericUpDown numericUpDownCapasity;
        private System.Windows.Forms.NumericUpDown numericUpDownFloor;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
    }
}