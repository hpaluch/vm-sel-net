namespace VmSelNet
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /*
         */

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
            this.writeToRegistrycb = new System.Windows.Forms.CheckBox();
            this.videoModeCombo = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // writeToRegistrycb
            // 
            this.writeToRegistrycb.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.writeToRegistrycb.AutoSize = true;
            this.writeToRegistrycb.Location = new System.Drawing.Point(12, 48);
            this.writeToRegistrycb.Name = "writeToRegistrycb";
            this.writeToRegistrycb.Size = new System.Drawing.Size(125, 17);
            this.writeToRegistrycb.TabIndex = 1;
            this.writeToRegistrycb.Text = "write mode to registry";
            this.writeToRegistrycb.UseVisualStyleBackColor = true;
            // 
            // videoModeCombo
            // 
            this.videoModeCombo.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Left | System.Windows.Forms.AnchorStyles.Right)));
            this.videoModeCombo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.videoModeCombo.FormattingEnabled = true;
            this.videoModeCombo.Location = new System.Drawing.Point(12, 12);
            this.videoModeCombo.Name = "videoModeCombo";
            this.videoModeCombo.Size = new System.Drawing.Size(264, 21);
            this.videoModeCombo.TabIndex = 2;
            this.videoModeCombo.SelectedIndexChanged += new System.EventHandler(this.videoModeCombo_SelectedIndexChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(288, 88);
            this.Controls.Add(this.videoModeCombo);
            this.Controls.Add(this.writeToRegistrycb);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox writeToRegistrycb;
        private System.Windows.Forms.ComboBox videoModeCombo;
    }
}

