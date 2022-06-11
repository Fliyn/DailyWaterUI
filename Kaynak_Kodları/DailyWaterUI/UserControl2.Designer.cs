
namespace DailyWaterUI
{
    partial class UserControl2
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.Separator1 = new Guna.UI2.WinForms.Guna2Separator();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.userControl8 = new DailyWaterUI.UserControl8();
            this.Panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI Light", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.IsSelectionEnabled = false;
            this.Label1.Location = new System.Drawing.Point(15, 15);
            this.Label1.Margin = new System.Windows.Forms.Padding(15, 15, 0, 0);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(89, 34);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "İstatistik";
            // 
            // Separator1
            // 
            this.Separator1.BackColor = System.Drawing.Color.Transparent;
            this.Separator1.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(82)))), ((int)(((byte)(48)))), ((int)(((byte)(124)))));
            this.Separator1.FillThickness = 3;
            this.Separator1.Location = new System.Drawing.Point(0, 49);
            this.Separator1.Margin = new System.Windows.Forms.Padding(0);
            this.Separator1.Name = "Separator1";
            this.Separator1.Size = new System.Drawing.Size(800, 10);
            this.Separator1.TabIndex = 23;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.userControl8);
            this.Panel1.Location = new System.Drawing.Point(0, 59);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(800, 394);
            this.Panel1.TabIndex = 25;
            // 
            // userControl8
            // 
            this.userControl8.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.userControl8.Dock = System.Windows.Forms.DockStyle.Fill;
            this.userControl8.Location = new System.Drawing.Point(0, 0);
            this.userControl8.Name = "userControl8";
            this.userControl8.Size = new System.Drawing.Size(800, 394);
            this.userControl8.TabIndex = 0;
            // 
            // UserControl2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.Label1);
            this.Name = "UserControl2";
            this.Size = new System.Drawing.Size(800, 453);
            this.Panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private UserControl8 userControl8;
    }
}
