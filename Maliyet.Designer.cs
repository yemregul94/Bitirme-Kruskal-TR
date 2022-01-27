namespace KruskalProjesi
{
    partial class MaliyetForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MaliyetForm));
            this.onaylaButton = new System.Windows.Forms.Button();
            this.anaLabel = new System.Windows.Forms.Label();
            this.MaliyetUpDown = new System.Windows.Forms.NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)(this.MaliyetUpDown)).BeginInit();
            this.SuspendLayout();
            // 
            // onaylaButton
            // 
            this.onaylaButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.onaylaButton.Location = new System.Drawing.Point(45, 106);
            this.onaylaButton.Name = "onaylaButton";
            this.onaylaButton.Size = new System.Drawing.Size(120, 38);
            this.onaylaButton.TabIndex = 0;
            this.onaylaButton.Text = "Onayla";
            this.onaylaButton.UseVisualStyleBackColor = true;
            this.onaylaButton.Click += new System.EventHandler(this.OnaylaButton_Click);
            // 
            // anaLabel
            // 
            this.anaLabel.AutoSize = true;
            this.anaLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.anaLabel.Location = new System.Drawing.Point(24, 9);
            this.anaLabel.Name = "anaLabel";
            this.anaLabel.Size = new System.Drawing.Size(163, 29);
            this.anaLabel.TabIndex = 2;
            this.anaLabel.Text = "Maliyet Giriniz";
            // 
            // MaliyetUpDown
            // 
            this.MaliyetUpDown.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(162)));
            this.MaliyetUpDown.Location = new System.Drawing.Point(66, 53);
            this.MaliyetUpDown.Maximum = new decimal(new int[] {
            1000,
            0,
            0,
            0});
            this.MaliyetUpDown.Minimum = new decimal(new int[] {
            1,
            0,
            0,
            0});
            this.MaliyetUpDown.Name = "MaliyetUpDown";
            this.MaliyetUpDown.Size = new System.Drawing.Size(78, 38);
            this.MaliyetUpDown.TabIndex = 3;
            this.MaliyetUpDown.Value = new decimal(new int[] {
            1,
            0,
            0,
            0});
            // 
            // MaliyetForm
            // 
            this.AcceptButton = this.onaylaButton;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(204, 161);
            this.Controls.Add(this.MaliyetUpDown);
            this.Controls.Add(this.anaLabel);
            this.Controls.Add(this.onaylaButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedSingle;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MaliyetForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.MaliyetForm_FormClosing);
            ((System.ComponentModel.ISupportInitialize)(this.MaliyetUpDown)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button onaylaButton;
        private System.Windows.Forms.Label anaLabel;
        private System.Windows.Forms.NumericUpDown MaliyetUpDown;
    }
}