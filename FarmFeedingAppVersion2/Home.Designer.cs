
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
            this.button1 = new System.Windows.Forms.Button();
            this.btnsearch = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainTitlelbl
            // 
            this.mainTitlelbl.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.mainTitlelbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.mainTitlelbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.mainTitlelbl.Location = new System.Drawing.Point(12, 9);
            this.mainTitlelbl.Name = "mainTitlelbl";
            this.mainTitlelbl.Size = new System.Drawing.Size(776, 82);
            this.mainTitlelbl.TabIndex = 0;
            this.mainTitlelbl.Text = "Farm Feeding App";
            this.mainTitlelbl.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // addAnimalbtn
            // 
            this.addAnimalbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.addAnimalbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.addAnimalbtn.Location = new System.Drawing.Point(324, 111);
            this.addAnimalbtn.Name = "addAnimalbtn";
            this.addAnimalbtn.Size = new System.Drawing.Size(141, 34);
            this.addAnimalbtn.TabIndex = 1;
            this.addAnimalbtn.Text = "Add Animal ";
            this.addAnimalbtn.UseVisualStyleBackColor = false;
            this.addAnimalbtn.Click += new System.EventHandler(this.addAnimalbtn_Click_1);
            // 
            // registeredAnimalsbtn
            // 
            this.registeredAnimalsbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.registeredAnimalsbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.registeredAnimalsbtn.Location = new System.Drawing.Point(324, 290);
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
            this.exitbtn.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.exitbtn.Location = new System.Drawing.Point(324, 350);
            this.exitbtn.Name = "exitbtn";
            this.exitbtn.Size = new System.Drawing.Size(141, 35);
            this.exitbtn.TabIndex = 3;
            this.exitbtn.Text = "Exit";
            this.exitbtn.UseVisualStyleBackColor = false;
            this.exitbtn.Click += new System.EventHandler(this.exitbtn_Click_1);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.button1.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.button1.Location = new System.Drawing.Point(324, 166);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(141, 34);
            this.button1.TabIndex = 4;
            this.button1.Text = "Add Daily Consumption";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btnsearch
            // 
            this.btnsearch.Location = new System.Drawing.Point(324, 225);
            this.btnsearch.Name = "btnsearch";
            this.btnsearch.Size = new System.Drawing.Size(141, 34);
            this.btnsearch.TabIndex = 5;
            this.btnsearch.Text = "Animal Search";
            this.btnsearch.UseVisualStyleBackColor = true;
            this.btnsearch.Click += new System.EventHandler(this.btnsearch_Click);
            // 
            // Home
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(26)))), ((int)(((byte)(26)))), ((int)(((byte)(26)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.btnsearch);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.exitbtn);
            this.Controls.Add(this.registeredAnimalsbtn);
            this.Controls.Add(this.addAnimalbtn);
            this.Controls.Add(this.mainTitlelbl);
            this.Name = "Home";
            this.Text = "Home";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Label mainTitlelbl;
        private System.Windows.Forms.Button addAnimalbtn;
        private System.Windows.Forms.Button registeredAnimalsbtn;
        private System.Windows.Forms.Button exitbtn;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button btnsearch;
    }
}

