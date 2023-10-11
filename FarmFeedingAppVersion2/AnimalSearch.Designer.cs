
namespace FarmFeedingAppVersion2
{
    partial class AnimalSearch
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
            this.pigpb = new System.Windows.Forms.PictureBox();
            this.Chickspb = new System.Windows.Forms.PictureBox();
            this.cowpb = new System.Windows.Forms.PictureBox();
            this.Chickenspb = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pigpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chickspb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowpb)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chickenspb)).BeginInit();
            this.SuspendLayout();
            // 
            // animalFinderlbl
            // 
            this.animalFinderlbl.Font = new System.Drawing.Font("Microsoft Sans Serif", 21.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.animalFinderlbl.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(242)))), ((int)(((byte)(242)))), ((int)(((byte)(242)))));
            this.animalFinderlbl.Location = new System.Drawing.Point(43, 13);
            this.animalFinderlbl.Name = "animalFinderlbl";
            this.animalFinderlbl.Size = new System.Drawing.Size(280, 34);
            this.animalFinderlbl.TabIndex = 0;
            this.animalFinderlbl.Text = "Animal Search";
            this.animalFinderlbl.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // tbxSearch
            // 
            this.tbxSearch.Location = new System.Drawing.Point(43, 50);
            this.tbxSearch.Name = "tbxSearch";
            this.tbxSearch.Size = new System.Drawing.Size(280, 20);
            this.tbxSearch.TabIndex = 1;
            this.tbxSearch.TextChanged += new System.EventHandler(this.tbxSearch_TextChanged);
            // 
            // listvSearch
            // 
            this.listvSearch.FullRowSelect = true;
            this.listvSearch.HideSelection = false;
            this.listvSearch.Location = new System.Drawing.Point(43, 87);
            this.listvSearch.Name = "listvSearch";
            this.listvSearch.Size = new System.Drawing.Size(280, 300);
            this.listvSearch.TabIndex = 2;
            this.listvSearch.UseCompatibleStateImageBehavior = false;
           
            this.listvSearch.SelectedIndexChanged += new System.EventHandler(this.listvSearch_SelectedIndexChanged);
            // 
            // exitafbtn
            // 
            this.exitafbtn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(51)))), ((int)(((byte)(51)))));
            this.exitafbtn.Location = new System.Drawing.Point(12, 415);
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
            this.updatebtn.Location = new System.Drawing.Point(713, 415);
            this.updatebtn.Name = "updatebtn";
            this.updatebtn.Size = new System.Drawing.Size(75, 23);
            this.updatebtn.TabIndex = 4;
            this.updatebtn.Text = "Update";
            this.updatebtn.UseVisualStyleBackColor = false;
            this.updatebtn.Click += new System.EventHandler(this.updatebtn_Click);
            // 
            // pigpb
            // 
            this.pigpb.Image = global::FarmFeedingAppVersion2.Properties.Resources.fauna_2713066_1280;
            this.pigpb.Location = new System.Drawing.Point(563, 229);
            this.pigpb.Name = "pigpb";
            this.pigpb.Size = new System.Drawing.Size(187, 171);
            this.pigpb.TabIndex = 8;
            this.pigpb.TabStop = false;
            // 
            // Chickspb
            // 
            this.Chickspb.Image = global::FarmFeedingAppVersion2.Properties.Resources.birds_5014150_1280;
            this.Chickspb.Location = new System.Drawing.Point(563, 39);
            this.Chickspb.Name = "Chickspb";
            this.Chickspb.Size = new System.Drawing.Size(187, 171);
            this.Chickspb.TabIndex = 7;
            this.Chickspb.TabStop = false;
            // 
            // cowpb
            // 
            this.cowpb.Image = global::FarmFeedingAppVersion2.Properties.Resources.cow_1839118_1280;
            this.cowpb.Location = new System.Drawing.Point(345, 229);
            this.cowpb.Name = "cowpb";
            this.cowpb.Size = new System.Drawing.Size(187, 171);
            this.cowpb.TabIndex = 6;
            this.cowpb.TabStop = false;
            // 
            // Chickenspb
            // 
            this.Chickenspb.Image = global::FarmFeedingAppVersion2.Properties.Resources.chicken_3727097_1280;
            this.Chickenspb.Location = new System.Drawing.Point(345, 39);
            this.Chickenspb.Name = "Chickenspb";
            this.Chickenspb.Size = new System.Drawing.Size(187, 171);
            this.Chickenspb.TabIndex = 5;
            this.Chickenspb.TabStop = false;
            // 
            // AnimalSearch
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(38)))), ((int)(((byte)(38)))), ((int)(((byte)(38)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.pigpb);
            this.Controls.Add(this.Chickspb);
            this.Controls.Add(this.cowpb);
            this.Controls.Add(this.Chickenspb);
            this.Controls.Add(this.updatebtn);
            this.Controls.Add(this.exitafbtn);
            this.Controls.Add(this.listvSearch);
            this.Controls.Add(this.tbxSearch);
            this.Controls.Add(this.animalFinderlbl);
            this.Name = "AnimalSearch";
            this.Text = "AnimalFinder";
            ((System.ComponentModel.ISupportInitialize)(this.pigpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chickspb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.cowpb)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chickenspb)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label animalFinderlbl;
        private System.Windows.Forms.TextBox tbxSearch;
        private System.Windows.Forms.ListView listvSearch;
        private System.Windows.Forms.Button exitafbtn;
        private System.Windows.Forms.Button updatebtn;
        private System.Windows.Forms.PictureBox Chickenspb;
        private System.Windows.Forms.PictureBox cowpb;
        private System.Windows.Forms.PictureBox Chickspb;
        private System.Windows.Forms.PictureBox pigpb;
    }
}