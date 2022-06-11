
namespace DailyWaterUI
{
    partial class msgbox
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
            this.components = new System.ComponentModel.Container();
            this.Panel1 = new Guna.UI2.WinForms.Guna2Panel();
            this.Label1 = new Guna.UI2.WinForms.Guna2HtmlLabel();
            this.ControlBox1 = new Guna.UI2.WinForms.Guna2ControlBox();
            this.Button1 = new Guna.UI2.WinForms.Guna2Button();
            this.Window1 = new Guna.UI2.WinForms.Guna2AnimateWindow(this.components);
            this.SuspendLayout();
            // 
            // Panel1
            // 
            this.Panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Panel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.Panel1.Location = new System.Drawing.Point(0, 138);
            this.Panel1.Name = "Panel1";
            this.Panel1.ShadowDecoration.Parent = this.Panel1;
            this.Panel1.Size = new System.Drawing.Size(300, 12);
            this.Panel1.TabIndex = 0;
            // 
            // Label1
            // 
            this.Label1.BackColor = System.Drawing.Color.Transparent;
            this.Label1.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.Label1.ForeColor = System.Drawing.Color.White;
            this.Label1.Location = new System.Drawing.Point(86, 52);
            this.Label1.Name = "Label1";
            this.Label1.Size = new System.Drawing.Size(127, 19);
            this.Label1.TabIndex = 1;
            this.Label1.Text = "Geçerli değer gir >:)";
            // 
            // ControlBox1
            // 
            this.ControlBox1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.ControlBox1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ControlBox1.FillColor = System.Drawing.Color.Transparent;
            this.ControlBox1.HoverState.FillColor = System.Drawing.Color.Red;
            this.ControlBox1.HoverState.Parent = this.ControlBox1;
            this.ControlBox1.IconColor = System.Drawing.Color.White;
            this.ControlBox1.Location = new System.Drawing.Point(255, 0);
            this.ControlBox1.Margin = new System.Windows.Forms.Padding(0);
            this.ControlBox1.Name = "ControlBox1";
            this.ControlBox1.ShadowDecoration.Parent = this.ControlBox1;
            this.ControlBox1.Size = new System.Drawing.Size(45, 29);
            this.ControlBox1.TabIndex = 2;
            // 
            // Button1
            // 
            this.Button1.Animated = true;
            this.Button1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Button1.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(215)))), ((int)(((byte)(35)))), ((int)(((byte)(35)))));
            this.Button1.BorderRadius = 5;
            this.Button1.BorderThickness = 2;
            this.Button1.CheckedState.Parent = this.Button1;
            this.Button1.Cursor = System.Windows.Forms.Cursors.Hand;
            this.Button1.CustomImages.Parent = this.Button1;
            this.Button1.FillColor = System.Drawing.Color.Transparent;
            this.Button1.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.Button1.ForeColor = System.Drawing.Color.White;
            this.Button1.HoverState.Parent = this.Button1;
            this.Button1.Location = new System.Drawing.Point(98, 88);
            this.Button1.Name = "Button1";
            this.Button1.ShadowDecoration.Parent = this.Button1;
            this.Button1.Size = new System.Drawing.Size(104, 29);
            this.Button1.TabIndex = 3;
            this.Button1.Text = "Tamam";
            this.Button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // Window1
            // 
            this.Window1.AnimationType = Guna.UI2.WinForms.Guna2AnimateWindow.AnimateWindowType.AW_BLEND;
            this.Window1.Interval = 100;
            this.Window1.TargetForm = this;
            // 
            // msgbox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(40)))), ((int)(((byte)(49)))));
            this.ClientSize = new System.Drawing.Size(300, 150);
            this.Controls.Add(this.Button1);
            this.Controls.Add(this.ControlBox1);
            this.Controls.Add(this.Label1);
            this.Controls.Add(this.Panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "msgbox";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form5";
            this.Load += new System.EventHandler(this.msgbox_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private Guna.UI2.WinForms.Guna2Panel Panel1;
        private Guna.UI2.WinForms.Guna2HtmlLabel Label1;
        private Guna.UI2.WinForms.Guna2ControlBox ControlBox1;
        private Guna.UI2.WinForms.Guna2Button Button1;
        public Guna.UI2.WinForms.Guna2AnimateWindow Window1;
    }
}