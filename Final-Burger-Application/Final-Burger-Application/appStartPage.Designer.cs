namespace Final_Burger_Application
{
    partial class Ordering
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
            this.btnOne = new System.Windows.Forms.Button();
            this.lblOne = new System.Windows.Forms.Label();
            this.lblOutput = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnOne
            // 
            this.btnOne.Location = new System.Drawing.Point(283, 205);
            this.btnOne.Name = "btnOne";
            this.btnOne.Size = new System.Drawing.Size(655, 124);
            this.btnOne.TabIndex = 0;
            this.btnOne.Text = "Submit";
            this.btnOne.UseVisualStyleBackColor = true;
            this.btnOne.Click += new System.EventHandler(this.btnOne_Click);
            // 
            // lblOne
            // 
            this.lblOne.AutoSize = true;
            this.lblOne.Font = new System.Drawing.Font("Microsoft Sans Serif", 72F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblOne.Location = new System.Drawing.Point(260, 9);
            this.lblOne.Name = "lblOne";
            this.lblOne.Size = new System.Drawing.Size(678, 135);
            this.lblOne.TabIndex = 1;
            this.lblOne.Text = "Hello World";
            // 
            // lblOutput
            // 
            this.lblOutput.AutoSize = true;
            this.lblOutput.Location = new System.Drawing.Point(420, 416);
            this.lblOutput.Name = "lblOutput";
            this.lblOutput.Size = new System.Drawing.Size(30, 17);
            this.lblOutput.TabIndex = 2;
            this.lblOutput.Text = "text";
            this.lblOutput.TextChanged += new System.EventHandler(this.lblOutput_TextChanged);
            // 
            // Ordering
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1161, 631);
            this.Controls.Add(this.lblOutput);
            this.Controls.Add(this.lblOne);
            this.Controls.Add(this.btnOne);
            this.Name = "Ordering";
            this.Text = "appStartPage";
            this.Load += new System.EventHandler(this.appStartPage_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnOne;
        private System.Windows.Forms.Label lblOne;
        private System.Windows.Forms.Label lblOutput;
    }
}

