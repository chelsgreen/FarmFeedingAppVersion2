
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
            this.foodcounternud = new System.Windows.Forms.NumericUpDown();
            this.Summaryrtbx = new System.Windows.Forms.RichTextBox();
            ((System.ComponentModel.ISupportInitialize)(this.foodcounternud)).BeginInit();
            this.SuspendLayout();
            // 
            // addAnimallbl
            // 
            this.addAnimallbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.addAnimallbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimallbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addAnimallbl.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.addAnimallbl.Location = new System.Drawing.Point(12, 9);
            this.addAnimallbl.Name = "addAnimallbl";
            this.addAnimallbl.Size = new System.Drawing.Size(776, 33);
            this.addAnimallbl.TabIndex = 0;
            this.addAnimallbl.Text = "Add Animal Consumption";
            this.addAnimallbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // label1
            // 
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(34)))), ((int)(((byte)(34)))), ((int)(((byte)(34)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(14, 55);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(774, 23);
            this.label1.TabIndex = 1;
            this.label1.Text = "Please enter the amount of food consumed per day per grams";
            this.label1.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addAnimalbtn
            // 
            this.addAnimalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.addAnimalbtn.Location = new System.Drawing.Point(423, 402);
            this.addAnimalbtn.Name = "addAnimalbtn";
            this.addAnimalbtn.Size = new System.Drawing.Size(98, 23);
            this.addAnimalbtn.TabIndex = 9;
            this.addAnimalbtn.Text = "Add Consumption";
            this.addAnimalbtn.UseVisualStyleBackColor = false;
            this.addAnimalbtn.Click += new System.EventHandler(this.addAnimalbtn_Click);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitbtn.ForeColor = System.Drawing.Color.Black;
            this.exitbtn.Location = new System.Drawing.Point(261, 402);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(99, 23);
            this.exitbtn.TabIndex = 10;
            this.exitbtn.Text = "Cancel";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click);
            // 
            // foodcounternud
            // 
            this.foodcounternud.Location = new System.Drawing.Point(327, 100);
            this.foodcounternud.Name = "foodcounternud";
            this.foodcounternud.Size = new System.Drawing.Size(120, 20);
            this.foodcounternud.TabIndex = 12;
            this.foodcounternud.ValueChanged += new System.EventHandler(this.day1updown_ValueChanged);
            // 
            // Summaryrtbx
            // 
            this.Summaryrtbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.Summaryrtbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.Summaryrtbx.Location = new System.Drawing.Point(261, 135);
            this.Summaryrtbx.Name = "Summaryrtbx";
            this.Summaryrtbx.Size = new System.Drawing.Size(260, 252);
            this.Summaryrtbx.TabIndex = 15;
            this.Summaryrtbx.Text = "                                   Summary";
            // 
            // AnimalConsumption
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Summaryrtbx);
            this.Controls.Add(this.foodcounternud);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.addAnimalbtn);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.addAnimallbl);
            this.Name = "AnimalConsumption";
            this.Text = "AddAnimalStage2";                 
            ((System.ComponentModel.ISupportInitialize)(this.foodcounternud)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label addAnimallbl;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button addAnimalbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.NumericUpDown foodcounternud;
        private System.Windows.Forms.RichTextBox Summaryrtbx;
    }
}