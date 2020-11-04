namespace Programa3
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.cbANDROID = new System.Windows.Forms.CheckBox();
            this.cbIOS = new System.Windows.Forms.CheckBox();
            this.picIOS = new System.Windows.Forms.PictureBox();
            this.picANDROID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picANDROID)).BeginInit();
            this.SuspendLayout();
            // 
            // cbANDROID
            // 
            this.cbANDROID.AutoSize = true;
            this.cbANDROID.Checked = true;
            this.cbANDROID.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbANDROID.Location = new System.Drawing.Point(326, 12);
            this.cbANDROID.Name = "cbANDROID";
            this.cbANDROID.Size = new System.Drawing.Size(62, 17);
            this.cbANDROID.TabIndex = 1;
            this.cbANDROID.Text = "Android";
            this.cbANDROID.UseVisualStyleBackColor = true;
            this.cbANDROID.CheckedChanged += new System.EventHandler(this.cbANDROID_CheckedChanged);
            // 
            // cbIOS
            // 
            this.cbIOS.AutoSize = true;
            this.cbIOS.Checked = true;
            this.cbIOS.CheckState = System.Windows.Forms.CheckState.Checked;
            this.cbIOS.Location = new System.Drawing.Point(82, 12);
            this.cbIOS.Name = "cbIOS";
            this.cbIOS.Size = new System.Drawing.Size(43, 17);
            this.cbIOS.TabIndex = 2;
            this.cbIOS.Text = "iOS";
            this.cbIOS.UseVisualStyleBackColor = true;
            this.cbIOS.CheckedChanged += new System.EventHandler(this.cbIOS_CheckedChanged);
            // 
            // picIOS
            // 
            this.picIOS.Image = ((System.Drawing.Image)(resources.GetObject("picIOS.Image")));
            this.picIOS.Location = new System.Drawing.Point(12, 35);
            this.picIOS.Name = "picIOS";
            this.picIOS.Size = new System.Drawing.Size(208, 201);
            this.picIOS.TabIndex = 3;
            this.picIOS.TabStop = false;
            this.picIOS.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // picANDROID
            // 
            this.picANDROID.Image = ((System.Drawing.Image)(resources.GetObject("picANDROID.Image")));
            this.picANDROID.Location = new System.Drawing.Point(242, 35);
            this.picANDROID.Name = "picANDROID";
            this.picANDROID.Size = new System.Drawing.Size(207, 201);
            this.picANDROID.TabIndex = 4;
            this.picANDROID.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(513, 310);
            this.Controls.Add(this.picANDROID);
            this.Controls.Add(this.picIOS);
            this.Controls.Add(this.cbIOS);
            this.Controls.Add(this.cbANDROID);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.picIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picANDROID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.CheckBox cbANDROID;
        private System.Windows.Forms.CheckBox cbIOS;
        private System.Windows.Forms.PictureBox picIOS;
        private System.Windows.Forms.PictureBox picANDROID;
    }
}

