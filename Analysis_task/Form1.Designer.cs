namespace Analysis_task
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
            this.AddActivityButton = new System.Windows.Forms.Button();
            this.AddDependencyButton = new System.Windows.Forms.Button();
            this.ActivityName = new System.Windows.Forms.TextBox();
            this.Activity2 = new System.Windows.Forms.TextBox();
            this.Activity1 = new System.Windows.Forms.TextBox();
            this.ActivityDuration = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // AddActivityButton
            // 
            this.AddActivityButton.Location = new System.Drawing.Point(562, 142);
            this.AddActivityButton.Name = "AddActivityButton";
            this.AddActivityButton.Size = new System.Drawing.Size(136, 23);
            this.AddActivityButton.TabIndex = 0;
            this.AddActivityButton.Text = "Add Activity";
            this.AddActivityButton.UseVisualStyleBackColor = true;
            this.AddActivityButton.Click += new System.EventHandler(this.AddActivityButton_Click);
            // 
            // AddDependencyButton
            // 
            this.AddDependencyButton.Location = new System.Drawing.Point(562, 207);
            this.AddDependencyButton.Name = "AddDependencyButton";
            this.AddDependencyButton.Size = new System.Drawing.Size(136, 23);
            this.AddDependencyButton.TabIndex = 1;
            this.AddDependencyButton.Text = "Add Dependency";
            this.AddDependencyButton.UseVisualStyleBackColor = true;
            this.AddDependencyButton.Click += new System.EventHandler(this.AddDependencyButton_Click);
            // 
            // ActivityName
            // 
            this.ActivityName.Location = new System.Drawing.Point(107, 142);
            this.ActivityName.Name = "ActivityName";
            this.ActivityName.Size = new System.Drawing.Size(199, 22);
            this.ActivityName.TabIndex = 2;
            // 
            // Activity2
            // 
            this.Activity2.Location = new System.Drawing.Point(333, 207);
            this.Activity2.Name = "Activity2";
            this.Activity2.Size = new System.Drawing.Size(181, 22);
            this.Activity2.TabIndex = 3;
            // 
            // Activity1
            // 
            this.Activity1.Location = new System.Drawing.Point(107, 206);
            this.Activity1.Name = "Activity1";
            this.Activity1.Size = new System.Drawing.Size(199, 22);
            this.Activity1.TabIndex = 4;
            // 
            // ActivityDuration
            // 
            this.ActivityDuration.Location = new System.Drawing.Point(333, 142);
            this.ActivityDuration.Name = "ActivityDuration";
            this.ActivityDuration.Size = new System.Drawing.Size(181, 22);
            this.ActivityDuration.TabIndex = 5;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ActivityDuration);
            this.Controls.Add(this.Activity1);
            this.Controls.Add(this.Activity2);
            this.Controls.Add(this.ActivityName);
            this.Controls.Add(this.AddDependencyButton);
            this.Controls.Add(this.AddActivityButton);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button AddActivityButton;
        private System.Windows.Forms.Button AddDependencyButton;
        private System.Windows.Forms.TextBox ActivityName;
        private System.Windows.Forms.TextBox Activity2;
        private System.Windows.Forms.TextBox Activity1;
        private System.Windows.Forms.TextBox ActivityDuration;
    }
}

