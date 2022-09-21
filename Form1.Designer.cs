
namespace The_safe_of_the_Pilot_brothers
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
            this.CreateMap = new System.Windows.Forms.Button();
            this.NBox = new System.Windows.Forms.TextBox();
            this.Nlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // CreateMap
            // 
            this.CreateMap.Location = new System.Drawing.Point(12, 41);
            this.CreateMap.Name = "CreateMap";
            this.CreateMap.Size = new System.Drawing.Size(72, 38);
            this.CreateMap.TabIndex = 0;
            this.CreateMap.Text = "Создать карту NxN";
            this.CreateMap.UseVisualStyleBackColor = true;
            this.CreateMap.Click += new System.EventHandler(this.CreateMap_Click);
            // 
            // NBox
            // 
            this.NBox.Location = new System.Drawing.Point(53, 12);
            this.NBox.Name = "NBox";
            this.NBox.Size = new System.Drawing.Size(31, 23);
            this.NBox.TabIndex = 1;
            this.NBox.Text = "5";
            // 
            // Nlabel
            // 
            this.Nlabel.AutoSize = true;
            this.Nlabel.Location = new System.Drawing.Point(20, 15);
            this.Nlabel.Name = "Nlabel";
            this.Nlabel.Size = new System.Drawing.Size(27, 15);
            this.Nlabel.TabIndex = 2;
            this.Nlabel.Text = "N =";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(120, 103);
            this.Controls.Add(this.Nlabel);
            this.Controls.Add(this.NBox);
            this.Controls.Add(this.CreateMap);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button CreateMap;
        private System.Windows.Forms.TextBox NBox;
        private System.Windows.Forms.Label Nlabel;
    }
}

