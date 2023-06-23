
namespace FarmFeedingAppVersion2
{
    partial class AnimalConsumption
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
            this.addAnimallbl = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.addAnimalbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.day1updown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.day1updown)).BeginInit();
            this.SuspendLayout();
            // 
            // addAnimallbl
            // 
            this.addAnimallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimallbl.ForeColor = System.Drawing.SystemColors.ControlText;
            this.addAnimallbl.Location = new System.Drawing.Point(12, 9);
            this.addAnimallbl.Name = "addAnimallbl";
            this.addAnimallbl.Size = new System.Drawing.Size(776, 33);
            this.addAnimallbl.TabIndex = 0;
            this.addAnimallbl.Text = "Add Animal";
            this.addAnimallbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(168, 74);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(511, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the amount of food consumed per day";
            // 
            // addAnimalbtn
            // 
            this.addAnimalbtn.Location = new System.Drawing.Point(713, 415);
            this.addAnimalbtn.Name = "addAnimalbtn";
            this.addAnimalbtn.Size = new System.Drawing.Size(75, 23);
            this.addAnimalbtn.TabIndex = 9;
            this.addAnimalbtn.Text = "Add Animal";
            this.addAnimalbtn.UseVisualStyleBackColor = true;
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(484, 415);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(75, 23);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(241, 137);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(304, 259);
            this.richTextBox1.TabIndex = 11;
            this.richTextBox1.Text = "Summary";
            // 
            // day1updown
            // 
            this.day1updown.Location = new System.Drawing.Point(327, 100);
            this.day1updown.Name = "day1updown";
            this.day1updown.Size = new System.Drawing.Size(120, 20);
            this.day1updown.TabIndex = 12;
            // 
            // AnimalConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.day1updown);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.addAnimalbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAnimallbl);
            this.Name = "AnimalConsumption";
            this.Text = "AddAnimalStage2";
            this.Load += new System.EventHandler(this.AnimalConsumption_Load);
            ((System.ComponentModel.ISupportInitialize)(this.day1updown)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addAnimallbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAnimalbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.NumericUpDown day1updown;
    }
}