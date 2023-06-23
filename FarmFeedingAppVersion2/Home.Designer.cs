
namespace FarmFeedingAppVersion2
{
    partial class Home
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
            this.mainTitlelbl = new System.Windows.Forms.Label();
            this.addAnimalbtn = new System.Windows.Forms.Button();
            this.registeredAnimalsbtn = new System.Windows.Forms.Button();
            this.exitbtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitlelbl
            // 
            this.mainTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitlelbl.Location = new System.Drawing.Point(12, 9);
            this.mainTitlelbl.Name = "mainTitlelbl";
            this.mainTitlelbl.Size = new System.Drawing.Size(776, 43);
            this.mainTitlelbl.TabIndex = 0;
            this.mainTitlelbl.Text = "Farm Feeding App";
            this.mainTitlelbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // addAnimalbtn
            // 
            this.addAnimalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.addAnimalbtn.Location = new System.Drawing.Point(335, 103);
            this.addAnimalbtn.Name = "addAnimalbtn";
            this.addAnimalbtn.Size = new System.Drawing.Size(141, 34);
            this.addAnimalbtn.TabIndex = 1;
            this.addAnimalbtn.Text = "Add Animal ";
            this.addAnimalbtn.UseVisualStyleBackColor = false;
            this.addAnimalbtn.Click += new System.EventHandler(this.addAnimalbtn_Click_1);
            // 
            // registeredAnimalsbtn
            // 
            this.registeredAnimalsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(64)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.registeredAnimalsbtn.Location = new System.Drawing.Point(335, 171);
            this.registeredAnimalsbtn.Name = "registeredAnimalsbtn";
            this.registeredAnimalsbtn.Size = new System.Drawing.Size(141, 35);
            this.registeredAnimalsbtn.TabIndex = 2;
            this.registeredAnimalsbtn.Text = "Registered Animals ";
            this.registeredAnimalsbtn.UseVisualStyleBackColor = false;
            this.registeredAnimalsbtn.Click += new System.EventHandler(this.registeredAnimalsbtn_Click_1);
            // 
            // exitbtn
            // 
            this.exitbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitbtn.Location = new System.Drawing.Point(335, 232);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(141, 35);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.registeredAnimalsbtn);
            this.Controls.Add(this.addAnimalbtn);
            this.Controls.Add(this.mainTitlelbl);
            this.Name = "Home";
            this.Text = "Home";
            this.Load += new System.EventHandler(this.Home_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitlelbl;
        private System.Windows.Forms.Button addAnimalbtn;
        private System.Windows.Forms.Button registeredAnimalsbtn;
        private System.Windows.Forms.Button exitbtn;
    }
}

