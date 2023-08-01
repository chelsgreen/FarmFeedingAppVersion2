
namespace FarmFeedingAppVersion2
{
    partial class AddAnimal
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
            this.addAnimalTitle = new System.Windows.Forms.Label();
            this.enterSpecieslbl = new System.Windows.Forms.Label();
            this.speciescbx = new System.Windows.Forms.ComboBox();
            this.exitAddAnimalbtn = new System.Windows.Forms.Button();
            this.continuebtn = new System.Windows.Forms.Button();
            this.dateTimePicker1 = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // addAnimalTitle
            // 
            this.addAnimalTitle.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.addAnimalTitle.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.addAnimalTitle.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addAnimalTitle.Location = new System.Drawing.Point(242, 9);
            this.addAnimalTitle.Name = "addAnimalTitle";
            this.addAnimalTitle.Size = new System.Drawing.Size(316, 36);
            this.addAnimalTitle.TabIndex = 0;
            this.addAnimalTitle.Text = "Add Animal";
            this.addAnimalTitle.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // enterSpecieslbl
            // 
            this.enterSpecieslbl.AutoSize = true;
            this.enterSpecieslbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.enterSpecieslbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.enterSpecieslbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.enterSpecieslbl.Location = new System.Drawing.Point(292, 98);
            this.enterSpecieslbl.Name = "enterSpecieslbl";
            this.enterSpecieslbl.Size = new System.Drawing.Size(206, 24);
            this.enterSpecieslbl.TabIndex = 1;
            this.enterSpecieslbl.Text = "Please select a species";
            this.enterSpecieslbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // speciescbx
            // 
            this.speciescbx.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.speciescbx.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.speciescbx.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.speciescbx.FormattingEnabled = true;
            this.speciescbx.Items.AddRange(new object[] {
            "Chicken",
            "Sheep",
            "Pig"});
            this.speciescbx.Location = new System.Drawing.Point(335, 143);
            this.speciescbx.Name = "speciescbx";
            this.speciescbx.Size = new System.Drawing.Size(121, 21);
            this.speciescbx.TabIndex = 2;
          
            // 
            // exitAddAnimalbtn
            // 
            this.exitAddAnimalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitAddAnimalbtn.Location = new System.Drawing.Point(33, 403);
            this.exitAddAnimalbtn.Name = "exitAddAnimalbtn";
            this.exitAddAnimalbtn.Size = new System.Drawing.Size(75, 23);
            this.exitAddAnimalbtn.TabIndex = 3;
            this.exitAddAnimalbtn.Text = "Cancel";
            this.exitAddAnimalbtn.UseVisualStyleBackColor = false;
            this.exitAddAnimalbtn.Click += new System.EventHandler(this.exitAddAnimalbtn_Click);
            // 
            // continuebtn
            // 
            this.continuebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.continuebtn.Location = new System.Drawing.Point(694, 403);
            this.continuebtn.Name = "continuebtn";
            this.continuebtn.Size = new System.Drawing.Size(75, 23);
            this.continuebtn.TabIndex = 4;
            this.continuebtn.Text = "Continue";
            this.continuebtn.UseVisualStyleBackColor = false;
            this.continuebtn.Click += new System.EventHandler(this.continuebtn_Click);
            // 
            // dateTimePicker1
            // 
            this.dateTimePicker1.CalendarMonthBackground = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.dateTimePicker1.Location = new System.Drawing.Point(296, 220);
            this.dateTimePicker1.Name = "dateTimePicker1";
            this.dateTimePicker1.Size = new System.Drawing.Size(200, 20);
            this.dateTimePicker1.TabIndex = 5;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.label1.Location = new System.Drawing.Point(312, 181);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(167, 24);
            this.label1.TabIndex = 6;
            this.label1.Text = "Select Date of Birth";
            this.label1.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // AddAnimal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.dateTimePicker1);
            this.Controls.Add(this.continuebtn);
            this.Controls.Add(this.exitAddAnimalbtn);
            this.Controls.Add(this.speciescbx);
            this.Controls.Add(this.enterSpecieslbl);
            this.Controls.Add(this.addAnimalTitle);
            this.Name = "AddAnimal";
            this.Text = "AddAnimal";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label addAnimalTitle;
        private System.Windows.Forms.Label enterSpecieslbl;
        private System.Windows.Forms.ComboBox speciescbx;
        private System.Windows.Forms.Button exitAddAnimalbtn;
        private System.Windows.Forms.Button continuebtn;
        private System.Windows.Forms.DateTimePicker dateTimePicker1;
        private System.Windows.Forms.Label label1;
    }
}