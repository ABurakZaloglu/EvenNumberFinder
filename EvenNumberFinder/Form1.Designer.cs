
namespace EvenNumberFinder
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
            this.lbxAllNumbers = new System.Windows.Forms.ListBox();
            this.lbxEvenNumbers = new System.Windows.Forms.ListBox();
            this.btnChanger = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbxAllNumbers
            // 
            this.lbxAllNumbers.FormattingEnabled = true;
            this.lbxAllNumbers.Location = new System.Drawing.Point(36, 22);
            this.lbxAllNumbers.Name = "lbxAllNumbers";
            this.lbxAllNumbers.Size = new System.Drawing.Size(211, 381);
            this.lbxAllNumbers.TabIndex = 0;
            // 
            // lbxEvenNumbers
            // 
            this.lbxEvenNumbers.FormattingEnabled = true;
            this.lbxEvenNumbers.Location = new System.Drawing.Point(573, 22);
            this.lbxEvenNumbers.Name = "lbxEvenNumbers";
            this.lbxEvenNumbers.Size = new System.Drawing.Size(194, 381);
            this.lbxEvenNumbers.TabIndex = 1;
            // 
            // btnChanger
            // 
            this.btnChanger.Location = new System.Drawing.Point(324, 344);
            this.btnChanger.Name = "btnChanger";
            this.btnChanger.Size = new System.Drawing.Size(159, 59);
            this.btnChanger.TabIndex = 2;
            this.btnChanger.Text = "Is That Even Number ?";
            this.btnChanger.UseVisualStyleBackColor = true;
            this.btnChanger.Click += new System.EventHandler(this.btnChanger_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnChanger);
            this.Controls.Add(this.lbxEvenNumbers);
            this.Controls.Add(this.lbxAllNumbers);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ListBox lbxAllNumbers;
        private System.Windows.Forms.ListBox lbxEvenNumbers;
        private System.Windows.Forms.Button btnChanger;
    }
}

