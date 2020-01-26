namespace eProdajaNamjestaja_UI
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
            this.korisniciGrid = new System.Windows.Forms.DataGridView();
            this.apiCallerButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // korisniciGrid
            // 
            this.korisniciGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.korisniciGrid.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.korisniciGrid.Location = new System.Drawing.Point(0, 73);
            this.korisniciGrid.Name = "korisniciGrid";
            this.korisniciGrid.Size = new System.Drawing.Size(457, 188);
            this.korisniciGrid.TabIndex = 0;
            // 
            // apiCallerButton
            // 
            this.apiCallerButton.Location = new System.Drawing.Point(12, 21);
            this.apiCallerButton.Name = "apiCallerButton";
            this.apiCallerButton.Size = new System.Drawing.Size(106, 23);
            this.apiCallerButton.TabIndex = 1;
            this.apiCallerButton.Text = "Call API";
            this.apiCallerButton.UseVisualStyleBackColor = true;
            this.apiCallerButton.Click += new System.EventHandler(this.apiCallerButton_Click);
            // 
            // Korisnici
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(457, 261);
            this.Controls.Add(this.apiCallerButton);
            this.Controls.Add(this.korisniciGrid);
            this.Name = "Korisnici";
            this.Text = "Korisnici";
            ((System.ComponentModel.ISupportInitialize)(this.korisniciGrid)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView korisniciGrid;
        private System.Windows.Forms.Button apiCallerButton;
    }
}

