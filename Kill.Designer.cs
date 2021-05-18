
namespace bramerto_rob
{
    partial class Kill
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
            this.components = new System.ComponentModel.Container();
            this.Time1 = new System.Windows.Forms.Timer(this.components);
            this.Time3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // Time1
            // 
            this.Time1.Interval = 7000;
            this.Time1.Tick += new System.EventHandler(this.Time1_Tick_1);
            // 
            // Time3
            // 
            this.Time3.Interval = 60000;
            this.Time3.Tick += new System.EventHandler(this.Time3_Tick);
            // 
            // Kill
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Black;
            this.ClientSize = new System.Drawing.Size(560, 718);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedToolWindow;
            this.Name = "Kill";
            this.Text = "bramerto-robber";
            this.Load += new System.EventHandler(this.Form1_Load_1);
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Timer Time;
        private System.Windows.Forms.Timer Time1;
        private System.Windows.Forms.Timer Time3;
    }
}

