
namespace FarmFeedingAppVersion2
{
    partial class AnimalFinder
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
            this.animalFinderlbl = new System.Windows.Forms.Label();
            this.tbxSearch = new System.Windows.Forms.TextBox();
            this.listvSearch = new System.Windows.Forms.ListView();
            this.exitafbtn = new System.Windows.Forms.Button();
            this.updatebtn = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // animalFinderlbl
            // 
            this.animalFinderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalFinderlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.animalFinderlbl.Location = new System.Drawing.Point(12, 9);
            this.animalFinderlbl.Name = "animalFinderlbl";
            this.animalFinderlbl.Size = new System.Drawing.Size(784, 34);
            this.animalFinderlbl.TabIndex = 0;
            this.animalFinderlbl.Text = "Animal Finder";
            this.animalFinderlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(260, 46);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(275, 20);
            this.tbxSearch.TabIndex = 1;
            // 
            // listvSearch
            // 
            this.listvSearch.HideSelection = false;
            this.listvSearch.Location = new System.Drawing.Point(260, 86);
            this.listvSearch.Name = "listvSearch";
            this.listvSearch.Size = new System.Drawing.Size(275, 271);
            this.listvSearch.TabIndex = 2;
            this.listvSearch.UseCompatibleStateImageBehavior = false;
            this.listvSearch.SelectedIndexChanged += new System.EventHandler(this.listvSearch_SelectedIndexChanged);
            // 
            // exitafbtn
            // 
            this.exitafbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitafbtn.Location = new System.Drawing.Point(260, 390);
            this.exitafbtn.Name = "exitafbtn";
            this.exitafbtn.Size = new System.Drawing.Size(75, 23);
            this.exitafbtn.TabIndex = 3;
            this.exitafbtn.Text = "Exit";
            this.exitafbtn.UseVisualStyleBackColor = false;
            this.exitafbtn.Click += new System.EventHandler(this.exitafbtn_Click);
            // 
            // updatebtn
            // 
            this.updatebtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(255)))), ((int)(((byte)(102)))));
            this.updatebtn.Location = new System.Drawing.Point(460, 390);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // AnimalFinder
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.exitafbtn);
            this.Controls.Add(this.listvSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.animalFinderlbl);
            this.Name = "AnimalFinder";
            this.Text = "AnimalFinder";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label animalFinderlbl;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListView listvSearch;
        private System.Windows.Forms.Button exitafbtn;
        private System.Windows.Forms.Button updatebtn;
    }
}