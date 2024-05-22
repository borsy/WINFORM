namespace WINFORM
{
    partial class Form1
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
            this.button_orszag = new System.Windows.Forms.Button();
            this.button_osszemeletek = new System.Windows.Forms.Button();
            this.label_orszag = new System.Windows.Forms.Label();
            this.label_osszemelet = new System.Windows.Forms.Label();
            this.dataGridView_adatmegjelenites = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatmegjelenites)).BeginInit();
            this.SuspendLayout();
            // 
            // button_orszag
            // 
            this.button_orszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_orszag.Location = new System.Drawing.Point(23, 26);
            this.button_orszag.Name = "button_orszag";
            this.button_orszag.Size = new System.Drawing.Size(100, 40);
            this.button_orszag.TabIndex = 0;
            this.button_orszag.Text = "Ország";
            this.button_orszag.UseVisualStyleBackColor = true;
            this.button_orszag.Click += new System.EventHandler(this.button_orszag_Click);
            // 
            // button_osszemeletek
            // 
            this.button_osszemeletek.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button_osszemeletek.Location = new System.Drawing.Point(23, 219);
            this.button_osszemeletek.Name = "button_osszemeletek";
            this.button_osszemeletek.Size = new System.Drawing.Size(120, 40);
            this.button_osszemeletek.TabIndex = 1;
            this.button_osszemeletek.Text = "Összemelet";
            this.button_osszemeletek.UseVisualStyleBackColor = true;
            this.button_osszemeletek.Click += new System.EventHandler(this.button_osszemeletek_Click);
            // 
            // label_orszag
            // 
            this.label_orszag.AutoSize = true;
            this.label_orszag.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_orszag.Location = new System.Drawing.Point(30, 79);
            this.label_orszag.Name = "label_orszag";
            this.label_orszag.Size = new System.Drawing.Size(58, 17);
            this.label_orszag.TabIndex = 2;
            this.label_orszag.Text = "Ország:";
            // 
            // label_osszemelet
            // 
            this.label_osszemelet.AutoSize = true;
            this.label_osszemelet.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_osszemelet.Location = new System.Drawing.Point(30, 276);
            this.label_osszemelet.Name = "label_osszemelet";
            this.label_osszemelet.Size = new System.Drawing.Size(309, 15);
            this.label_osszemelet.TabIndex = 3;
            this.label_osszemelet.Text = "A 400 m-nél magasabb épületek átlagos emeletszáma:";
            // 
            // dataGridView_adatmegjelenites
            // 
            this.dataGridView_adatmegjelenites.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView_adatmegjelenites.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.DisplayedCells;
            this.dataGridView_adatmegjelenites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView_adatmegjelenites.Dock = System.Windows.Forms.DockStyle.Right;
            this.dataGridView_adatmegjelenites.Location = new System.Drawing.Point(404, 0);
            this.dataGridView_adatmegjelenites.Name = "dataGridView_adatmegjelenites";
            this.dataGridView_adatmegjelenites.Size = new System.Drawing.Size(485, 450);
            this.dataGridView_adatmegjelenites.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ControlDark;
            this.ClientSize = new System.Drawing.Size(889, 450);
            this.Controls.Add(this.dataGridView_adatmegjelenites);
            this.Controls.Add(this.label_osszemelet);
            this.Controls.Add(this.label_orszag);
            this.Controls.Add(this.button_osszemeletek);
            this.Controls.Add(this.button_orszag);
            this.Name = "Form1";
            this.Text = "100 Legmagasabb épület";
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView_adatmegjelenites)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button button_orszag;
        private System.Windows.Forms.Button button_osszemeletek;
        private System.Windows.Forms.Label label_orszag;
        private System.Windows.Forms.Label label_osszemelet;
        private System.Windows.Forms.DataGridView dataGridView_adatmegjelenites;
    }
}

