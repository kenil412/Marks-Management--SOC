namespace MarksManagementClient
{
    partial class Form5
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
            this.addmarks = new System.Windows.Forms.Button();
            this.mar_u = new System.Windows.Forms.NumericUpDown();
            this.sub_u = new System.Windows.Forms.NumericUpDown();
            this.sem_u = new System.Windows.Forms.NumericUpDown();
            this.DelSem = new System.Windows.Forms.NumericUpDown();
            this.UpdateButton = new System.Windows.Forms.Button();
            this.label16 = new System.Windows.Forms.Label();
            this.label15 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.DeleteButton = new System.Windows.Forms.Button();
            this.label10 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.SearchButton = new System.Windows.Forms.Button();
            this.SearchID = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.mar_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_u)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSem)).BeginInit();
            this.SuspendLayout();
            // 
            // addmarks
            // 
            this.addmarks.Location = new System.Drawing.Point(720, 66);
            this.addmarks.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.addmarks.Name = "addmarks";
            this.addmarks.Size = new System.Drawing.Size(126, 34);
            this.addmarks.TabIndex = 69;
            this.addmarks.Text = "Add New Marks";
            this.addmarks.UseVisualStyleBackColor = true;
            this.addmarks.Click += new System.EventHandler(this.addmarks_Click);
            // 
            // mar_u
            // 
            this.mar_u.Location = new System.Drawing.Point(704, 387);
            this.mar_u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.mar_u.Name = "mar_u";
            this.mar_u.Size = new System.Drawing.Size(89, 22);
            this.mar_u.TabIndex = 68;
            // 
            // sub_u
            // 
            this.sub_u.Location = new System.Drawing.Point(704, 354);
            this.sub_u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sub_u.Name = "sub_u";
            this.sub_u.Size = new System.Drawing.Size(89, 22);
            this.sub_u.TabIndex = 67;
            // 
            // sem_u
            // 
            this.sem_u.Location = new System.Drawing.Point(704, 321);
            this.sem_u.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.sem_u.Name = "sem_u";
            this.sem_u.Size = new System.Drawing.Size(89, 22);
            this.sem_u.TabIndex = 66;
            // 
            // DelSem
            // 
            this.DelSem.Location = new System.Drawing.Point(657, 208);
            this.DelSem.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DelSem.Name = "DelSem";
            this.DelSem.Size = new System.Drawing.Size(107, 22);
            this.DelSem.TabIndex = 65;
            // 
            // UpdateButton
            // 
            this.UpdateButton.Location = new System.Drawing.Point(816, 351);
            this.UpdateButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.UpdateButton.Name = "UpdateButton";
            this.UpdateButton.Size = new System.Drawing.Size(92, 29);
            this.UpdateButton.TabIndex = 64;
            this.UpdateButton.Text = "Update";
            this.UpdateButton.UseVisualStyleBackColor = true;
            this.UpdateButton.Click += new System.EventHandler(this.UpdateButton_Click);
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.Location = new System.Drawing.Point(654, 390);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(46, 17);
            this.label16.TabIndex = 63;
            this.label16.Text = "Marks";
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.Location = new System.Drawing.Point(644, 358);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(55, 17);
            this.label15.TabIndex = 62;
            this.label15.Text = "Subject";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.Location = new System.Drawing.Point(631, 322);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(68, 17);
            this.label14.TabIndex = 61;
            this.label14.Text = "Semester";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Location = new System.Drawing.Point(616, 294);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(279, 17);
            this.label11.TabIndex = 60;
            this.label11.Text = "Enter the following details to update marks:";
            // 
            // DeleteButton
            // 
            this.DeleteButton.Location = new System.Drawing.Point(794, 203);
            this.DeleteButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.DeleteButton.Name = "DeleteButton";
            this.DeleteButton.Size = new System.Drawing.Size(92, 29);
            this.DeleteButton.TabIndex = 59;
            this.DeleteButton.Text = "Delete";
            this.DeleteButton.UseVisualStyleBackColor = true;
            this.DeleteButton.Click += new System.EventHandler(this.DeleteButton_Click);
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(616, 181);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(307, 17);
            this.label10.TabIndex = 55;
            this.label10.Text = "Enter the semester number to delete the entry :";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(40, 158);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(88, 17);
            this.label5.TabIndex = 58;
            this.label5.Text = "Your marks :";
            // 
            // listView1
            // 
            this.listView1.Location = new System.Drawing.Point(43, 181);
            this.listView1.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(568, 228);
            this.listView1.TabIndex = 57;
            this.listView1.UseCompatibleStateImageBehavior = false;
            // 
            // SearchButton
            // 
            this.SearchButton.Location = new System.Drawing.Point(415, 93);
            this.SearchButton.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchButton.Name = "SearchButton";
            this.SearchButton.Size = new System.Drawing.Size(68, 26);
            this.SearchButton.TabIndex = 56;
            this.SearchButton.Text = "Search";
            this.SearchButton.UseVisualStyleBackColor = true;
            // 
            // SearchID
            // 
            this.SearchID.Location = new System.Drawing.Point(235, 95);
            this.SearchID.Margin = new System.Windows.Forms.Padding(3, 2, 3, 2);
            this.SearchID.Name = "SearchID";
            this.SearchID.Size = new System.Drawing.Size(162, 22);
            this.SearchID.TabIndex = 54;
            this.SearchID.TextChanged += new System.EventHandler(this.SearchID_TextChanged);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Location = new System.Drawing.Point(449, 42);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(72, 17);
            this.label12.TabIndex = 52;
            this.label12.Text = "Welcome!!";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.Location = new System.Drawing.Point(40, 98);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(190, 17);
            this.label13.TabIndex = 53;
            this.label13.Text = "Enter the ID to be searched :";
            // 
            // Form5
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(950, 450);
            this.Controls.Add(this.addmarks);
            this.Controls.Add(this.mar_u);
            this.Controls.Add(this.sub_u);
            this.Controls.Add(this.sem_u);
            this.Controls.Add(this.DelSem);
            this.Controls.Add(this.UpdateButton);
            this.Controls.Add(this.label16);
            this.Controls.Add(this.label15);
            this.Controls.Add(this.label14);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.DeleteButton);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.SearchButton);
            this.Controls.Add(this.SearchID);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.label13);
            this.Name = "Form5";
            this.Text = "Form5";
            ((System.ComponentModel.ISupportInitialize)(this.mar_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sub_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sem_u)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DelSem)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button addmarks;
        private System.Windows.Forms.NumericUpDown mar_u;
        private System.Windows.Forms.NumericUpDown sub_u;
        private System.Windows.Forms.NumericUpDown sem_u;
        private System.Windows.Forms.NumericUpDown DelSem;
        private System.Windows.Forms.Button UpdateButton;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Button DeleteButton;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button SearchButton;
        private System.Windows.Forms.TextBox SearchID;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
    }
}