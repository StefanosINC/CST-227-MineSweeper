namespace CST_227Milestone4
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
            this.rdo_easy = new System.Windows.Forms.RadioButton();
            this.rdo_medium = new System.Windows.Forms.RadioButton();
            this.rdo_hard = new System.Windows.Forms.RadioButton();
            this.btn_play = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // rdo_easy
            // 
            this.rdo_easy.AutoSize = true;
            this.rdo_easy.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_easy.Location = new System.Drawing.Point(36, 81);
            this.rdo_easy.Name = "rdo_easy";
            this.rdo_easy.Size = new System.Drawing.Size(59, 25);
            this.rdo_easy.TabIndex = 0;
            this.rdo_easy.TabStop = true;
            this.rdo_easy.Text = "Easy";
            this.rdo_easy.UseVisualStyleBackColor = true;
            // 
            // rdo_medium
            // 
            this.rdo_medium.AutoSize = true;
            this.rdo_medium.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_medium.Location = new System.Drawing.Point(36, 126);
            this.rdo_medium.Name = "rdo_medium";
            this.rdo_medium.Size = new System.Drawing.Size(86, 25);
            this.rdo_medium.TabIndex = 1;
            this.rdo_medium.TabStop = true;
            this.rdo_medium.Text = "Medium";
            this.rdo_medium.UseVisualStyleBackColor = true;
            this.rdo_medium.CheckedChanged += new System.EventHandler(this.rdo_medium_CheckedChanged);
            // 
            // rdo_hard
            // 
            this.rdo_hard.AutoSize = true;
            this.rdo_hard.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdo_hard.Location = new System.Drawing.Point(36, 169);
            this.rdo_hard.Name = "rdo_hard";
            this.rdo_hard.Size = new System.Drawing.Size(62, 25);
            this.rdo_hard.TabIndex = 2;
            this.rdo_hard.TabStop = true;
            this.rdo_hard.Text = "Hard";
            this.rdo_hard.UseVisualStyleBackColor = true;
            // 
            // btn_play
            // 
            this.btn_play.BackColor = System.Drawing.Color.WhiteSmoke;
            this.btn_play.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_play.Location = new System.Drawing.Point(165, 115);
            this.btn_play.Name = "btn_play";
            this.btn_play.Size = new System.Drawing.Size(123, 45);
            this.btn_play.TabIndex = 3;
            this.btn_play.Text = "Play";
            this.btn_play.UseVisualStyleBackColor = false;
            this.btn_play.Click += new System.EventHandler(this.btn_play_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(488, 25);
            this.label1.TabIndex = 4;
            this.label1.Text = "Welcome to Minesweepr, Choose a difficulty to get started ";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuBar;
            this.ClientSize = new System.Drawing.Size(498, 238);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_play);
            this.Controls.Add(this.rdo_hard);
            this.Controls.Add(this.rdo_medium);
            this.Controls.Add(this.rdo_easy);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rdo_easy;
        private System.Windows.Forms.RadioButton rdo_medium;
        private System.Windows.Forms.RadioButton rdo_hard;
        private System.Windows.Forms.Button btn_play;
        private System.Windows.Forms.Label label1;
    }
}

