
namespace FarmFeedingAppVersion2
{
    partial class AnimalSummary
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
            this.label1 = new System.Windows.Forms.Label();
            this.homeBtn = new System.Windows.Forms.Button();
            this.animalsumcbx = new System.Windows.Forms.ComboBox();
            this.rtbSummary = new System.Windows.Forms.RichTextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(244)))));
            this.label1.Location = new System.Drawing.Point(18, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(304, 36);
            this.label1.TabIndex = 0;
            this.label1.Text = "Animal Summary";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // homeBtn
            // 
            this.homeBtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.homeBtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(191)))), ((int)(((byte)(191)))), ((int)(((byte)(191)))));
            this.homeBtn.Location = new System.Drawing.Point(362, 404);
            this.homeBtn.Name = "homeBtn";
            this.homeBtn.Size = new System.Drawing.Size(75, 23);
            this.homeBtn.TabIndex = 1;
            this.homeBtn.Text = "Home";
            this.homeBtn.UseVisualStyleBackColor = false;
            this.homeBtn.Click += new System.EventHandler(this.homeBtn_Click);
            // 
            // animalsumcbx
            // 
            this.animalsumcbx.FormattingEnabled = true;
            this.animalsumcbx.Items.AddRange(new object[] {
            "All",
            "Chicken",
            "Sheep",
            "Pig"});
            this.animalsumcbx.Location = new System.Drawing.Point(100, 48);
            this.animalsumcbx.Name = "animalsumcbx";
            this.animalsumcbx.Size = new System.Drawing.Size(121, 21);
            this.animalsumcbx.TabIndex = 4;
            this.animalsumcbx.SelectedIndexChanged += new System.EventHandler(this.animalsumcbx_SelectedIndexChanged);
            // 
            // rtbSummary
            // 
            this.rtbSummary.Location = new System.Drawing.Point(24, 89);
            this.rtbSummary.Name = "rtbSummary";
            this.rtbSummary.Size = new System.Drawing.Size(311, 320);
            this.rtbSummary.TabIndex = 5;
            this.rtbSummary.Text = "";
            // 
            // AnimalSummary
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(36)))), ((int)(((byte)(36)))), ((int)(((byte)(36)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.rtbSummary);
            this.Controls.Add(this.animalsumcbx);
            this.Controls.Add(this.homeBtn);
            this.Controls.Add(this.label1);
            this.Name = "AnimalSummary";
            this.Text = "AnimalSummary";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button homeBtn;
        private System.Windows.Forms.ComboBox animalsumcbx;
        private System.Windows.Forms.RichTextBox rtbSummary;
    }
}