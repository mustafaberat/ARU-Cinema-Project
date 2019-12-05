namespace DataBase_CinemaProject
{
    partial class HelloIamEmployee
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(HelloIamEmployee));
            this.label2 = new System.Windows.Forms.Label();
            this.employeeNameLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.goShoppingButton = new System.Windows.Forms.Button();
            this.lookfilms = new System.Windows.Forms.Button();
            this.aboutUsButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label2.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(71, 33);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(131, 31);
            this.label2.TabIndex = 1;
            this.label2.Text = "Hello I am";
            // 
            // employeeNameLabel
            // 
            this.employeeNameLabel.AutoSize = true;
            this.employeeNameLabel.BackColor = System.Drawing.SystemColors.HotTrack;
            this.employeeNameLabel.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameLabel.ForeColor = System.Drawing.Color.White;
            this.employeeNameLabel.Location = new System.Drawing.Point(202, 33);
            this.employeeNameLabel.Name = "employeeNameLabel";
            this.employeeNameLabel.Size = new System.Drawing.Size(94, 31);
            this.employeeNameLabel.TabIndex = 2;
            this.employeeNameLabel.Text = "Furkan";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.SystemColors.HotTrack;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(71, 76);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(240, 31);
            this.label1.TabIndex = 3;
            this.label1.Text = "How can i help you?";
            // 
            // goShoppingButton
            // 
            this.goShoppingButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.goShoppingButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.goShoppingButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.goShoppingButton.ForeColor = System.Drawing.Color.White;
            this.goShoppingButton.Location = new System.Drawing.Point(435, 238);
            this.goShoppingButton.Name = "goShoppingButton";
            this.goShoppingButton.Size = new System.Drawing.Size(170, 46);
            this.goShoppingButton.TabIndex = 5;
            this.goShoppingButton.Text = "Go Shopping";
            this.goShoppingButton.UseVisualStyleBackColor = false;
            this.goShoppingButton.Click += new System.EventHandler(this.goShoppingButton_Click);
            // 
            // lookfilms
            // 
            this.lookfilms.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.lookfilms.Cursor = System.Windows.Forms.Cursors.Hand;
            this.lookfilms.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.lookfilms.ForeColor = System.Drawing.Color.White;
            this.lookfilms.Location = new System.Drawing.Point(435, 186);
            this.lookfilms.Name = "lookfilms";
            this.lookfilms.Size = new System.Drawing.Size(170, 46);
            this.lookfilms.TabIndex = 6;
            this.lookfilms.Text = "Look at the films";
            this.lookfilms.UseVisualStyleBackColor = false;
            this.lookfilms.Click += new System.EventHandler(this.lookfilms_Click);
            // 
            // aboutUsButton
            // 
            this.aboutUsButton.BackColor = System.Drawing.SystemColors.ControlDarkDark;
            this.aboutUsButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.aboutUsButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.aboutUsButton.ForeColor = System.Drawing.Color.White;
            this.aboutUsButton.Location = new System.Drawing.Point(435, 134);
            this.aboutUsButton.Name = "aboutUsButton";
            this.aboutUsButton.Size = new System.Drawing.Size(170, 46);
            this.aboutUsButton.TabIndex = 7;
            this.aboutUsButton.Text = "About Us";
            this.aboutUsButton.UseVisualStyleBackColor = false;
            this.aboutUsButton.Click += new System.EventHandler(this.aboutUsButton_Click);
            // 
            // HelloIamEmployee
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.ClientSize = new System.Drawing.Size(640, 320);
            this.Controls.Add(this.aboutUsButton);
            this.Controls.Add(this.lookfilms);
            this.Controls.Add(this.goShoppingButton);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.employeeNameLabel);
            this.Controls.Add(this.label2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "HelloIamEmployee";
            this.Text = "Welcome to Box Office";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label employeeNameLabel;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button goShoppingButton;
        private System.Windows.Forms.Button lookfilms;
        private System.Windows.Forms.Button aboutUsButton;
    }
}