
namespace WindowsFormsApp
{
    partial class AppForm
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
            this.btnScores = new System.Windows.Forms.Button();
            this.dgwScores = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.dgwScores)).BeginInit();
            this.SuspendLayout();
            // 
            // btnScores
            // 
            this.btnScores.AutoSize = true;
            this.btnScores.Location = new System.Drawing.Point(317, 12);
            this.btnScores.Name = "btnScores";
            this.btnScores.Size = new System.Drawing.Size(157, 37);
            this.btnScores.TabIndex = 0;
            this.btnScores.Text = "AvgScorecard";
            this.btnScores.UseVisualStyleBackColor = true;
            this.btnScores.Click += new System.EventHandler(this.btnScores_Click);
            // 
            // dgwScores
            // 
            this.dgwScores.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dgwScores.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgwScores.Location = new System.Drawing.Point(34, 12);
            this.dgwScores.Name = "dgwScores";
            this.dgwScores.Size = new System.Drawing.Size(277, 214);
            this.dgwScores.TabIndex = 1;
            // 
            // AppForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoValidate = System.Windows.Forms.AutoValidate.EnableAllowFocusChange;
            this.ClientSize = new System.Drawing.Size(535, 252);
            this.Controls.Add(this.dgwScores);
            this.Controls.Add(this.btnScores);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(161)));
            this.Margin = new System.Windows.Forms.Padding(6, 6, 6, 6);
            this.Name = "AppForm";
            this.Text = "AppDanaos";
            ((System.ComponentModel.ISupportInitialize)(this.dgwScores)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnScores;
        private System.Windows.Forms.DataGridView dgwScores;
    }
}

