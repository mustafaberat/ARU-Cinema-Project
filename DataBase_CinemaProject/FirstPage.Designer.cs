namespace DataBase_CinemaProject
{
    partial class FirstPage
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FirstPage));
            this.label1 = new System.Windows.Forms.Label();
            this.customerButton = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.managerButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Black;
            this.label1.Font = new System.Drawing.Font("Bernard MT Condensed", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.White;
            this.label1.Location = new System.Drawing.Point(259, 253);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(143, 31);
            this.label1.TabIndex = 0;
            this.label1.Text = "Welcome to";
            // 
            // customerButton
            // 
            this.customerButton.BackColor = System.Drawing.Color.Black;
            this.customerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.customerButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.customerButton.ForeColor = System.Drawing.Color.White;
            this.customerButton.Location = new System.Drawing.Point(377, 357);
            this.customerButton.Name = "customerButton";
            this.customerButton.Size = new System.Drawing.Size(170, 46);
            this.customerButton.TabIndex = 4;
            this.customerButton.Text = "Customer";
            this.customerButton.UseVisualStyleBackColor = false;
            this.customerButton.Click += new System.EventHandler(this.customerButton_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Black;
            this.label3.Font = new System.Drawing.Font("Bernard MT Condensed", 36F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.White;
            this.label3.Location = new System.Drawing.Point(206, 284);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(252, 57);
            this.label3.TabIndex = 5;
            this.label3.Text = "ARU Cinema";
            // 
            // managerButton
            // 
            this.managerButton.BackColor = System.Drawing.Color.Black;
            this.managerButton.Cursor = System.Windows.Forms.Cursors.Hand;
            this.managerButton.Font = new System.Drawing.Font("Microsoft YaHei", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.managerButton.ForeColor = System.Drawing.Color.White;
            this.managerButton.Location = new System.Drawing.Point(117, 357);
            this.managerButton.Name = "managerButton";
            this.managerButton.Size = new System.Drawing.Size(170, 46);
            this.managerButton.TabIndex = 6;
            this.managerButton.Text = "Manager";
            this.managerButton.UseVisualStyleBackColor = false;
            this.managerButton.Click += new System.EventHandler(this.managerButton_Click);
            // 
            // FirstPage
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(640, 426);
            this.Controls.Add(this.managerButton);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerButton);
            this.Controls.Add(this.label1);
            this.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FirstPage";
            this.Text = "ARU Cinema";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button customerButton;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button managerButton;
    }
}

