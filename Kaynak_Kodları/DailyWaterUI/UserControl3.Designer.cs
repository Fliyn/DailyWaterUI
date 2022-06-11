
namespace DailyWaterUI
{
    partial class UserControl3
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
            this.Button3 = new Guna.UI2.WinForms.Guna2Button();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Panel2 = new Guna.UI2.WinForms.Guna2Panel();
            this.UserControl5 = new DailyWaterUI.UserControl5();
            this.UserControl7 = new DailyWaterUI.UserControl7();
            this.Button4 = new Guna.UI2.WinForms.Guna2Button();
            this.Panel1.SuspendLayout();
            this.Panel2.SuspendLayout();
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
            this.Label1.Size = new System.Drawing.Size(86, 34);
            this.Label1.TabIndex = 2;
            this.Label1.Text = "Mağaza";
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
            this.Separator1.TabIndex = 22;
            // 
            // Panel1
            // 
            this.Panel1.Controls.Add(this.Button3);
            this.Panel1.Controls.Add(this.Button1);
            this.Panel1.Location = new System.Drawing.Point(0, 64);
            this.Panel1.Margin = new System.Windows.Forms.Padding(0);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(800, 29);
            this.Panel1.TabIndex = 23;
            // 
            // Button3
            // 
            this.Button3.Animated = true;
            this.Button3.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button3.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.Button3.CheckedState.Parent = this.Button3;
            this.Button3.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Button3.CustomImages.Parent = this.Button3;
            this.Button3.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button3.FillColor = System.Drawing.Color.Transparent;
            this.Button3.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button3.ForeColor = System.Drawing.Color.White;
            this.Button3.HoverState.Parent = this.Button3;
            this.Button3.Location = new System.Drawing.Point(116, 0);
            this.Button3.Name = "Button3";
            this.Button3.ShadowDecoration.Parent = this.Button3;
            this.Button3.Size = new System.Drawing.Size(116, 29);
            this.Button3.TabIndex = 2;
            this.Button3.Text = "Animasyonlar";
            this.Button3.CheckedChanged += new System.EventHandler(this.Button3_CheckedChanged);
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.ButtonMode = Guna.UI2.WinForms.Enums.ButtonMode.RadioButton;
            this.Button1.Checked = true;
            this.Button1.CheckedState.CustomBorderColor = System.Drawing.Color.DodgerBlue;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.CustomBorderThickness = new System.Windows.Forms.Padding(0, 0, 0, 2);
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.Dock = System.Windows.Forms.DockStyle.Left;
            this.Button1.FillColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(0, 0);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(116, 29);
            this.Button1.TabIndex = 0;
            this.Button1.Text = "Efektler";
            this.Button1.CheckedChanged += new System.EventHandler(this.Button1_CheckedChanged);
            // 
            // Panel2
            // 
            this.Panel2.Controls.Add(this.UserControl5);
            this.Panel2.Controls.Add(this.UserControl7);
            this.Panel2.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel2.Location = new System.Drawing.Point(0, 93);
            this.Panel2.Margin = new System.Windows.Forms.Padding(0);
            this.Panel2.Name = "Panel2";
            this.Panel2.ShadowDecoration.Parent = this.Panel2;
            this.Panel2.Size = new System.Drawing.Size(800, 360);
            this.Panel2.TabIndex = 3;
            // 
            // UserControl5
            // 
            this.UserControl5.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UserControl5.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl5.Location = new System.Drawing.Point(0, 0);
            this.UserControl5.Name = "UserControl5";
            this.UserControl5.Size = new System.Drawing.Size(800, 360);
            this.UserControl5.TabIndex = 0;
            // 
            // UserControl7
            // 
            this.UserControl7.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.UserControl7.Dock = System.Windows.Forms.DockStyle.Fill;
            this.UserControl7.Location = new System.Drawing.Point(0, 0);
            this.UserControl7.Name = "UserControl7";
            this.UserControl7.Size = new System.Drawing.Size(800, 360);
            this.UserControl7.TabIndex = 2;
            // 
            // Button4
            // 
            this.Button4.Animated = true;
            this.Button4.BorderRadius = 10;
            this.Button4.CheckedState.Parent = this.Button4;
            this.Button4.CustomImages.Parent = this.Button4;
            this.Button4.FillColor = System.Drawing.Color.DodgerBlue;
            this.Button4.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button4.ForeColor = System.Drawing.Color.White;
            this.Button4.HoverState.Parent = this.Button4;
            this.Button4.Location = new System.Drawing.Point(633, 8);
            this.Button4.Name = "Button4";
            this.Button4.ShadowDecoration.Parent = this.Button4;
            this.Button4.Size = new System.Drawing.Size(152, 34);
            this.Button4.TabIndex = 24;
            this.Button4.Text = "Efektleri Sıfırla";
            this.Button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // UserControl3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(51)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.Controls.Add(this.Button4);
            this.Controls.Add(this.Panel2);
            this.Controls.Add(this.Panel1);
            this.Controls.Add(this.Separator1);
            this.Controls.Add(this.Label1);
            this.Name = "UserControl3";
            this.Size = new System.Drawing.Size(800, 453);
            this.Panel1.ResumeLayout(false);
            this.Panel2.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private Guna.UI2.WinForms.Guna2Separator Separator1;
        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2Button Button1;
        private Guna.UI2.WinForms.Guna2Button Button3;
        private Guna.UI2.WinForms.Guna2Panel Panel2;
        private UserControl5 UserControl5;
        private UserControl7 UserControl7;
        public Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2Button Button4;
    }
}
