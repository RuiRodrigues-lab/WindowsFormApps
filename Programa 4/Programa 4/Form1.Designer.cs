namespace Programa_4
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
            this.rbIOS = new System.Windows.Forms.RadioButton();
            this.rbANDROID = new System.Windows.Forms.RadioButton();
            this.picIOS = new System.Windows.Forms.PictureBox();
            this.picANDROID = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picIOS)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picANDROID)).BeginInit();
            this.SuspendLayout();
            // 
            // rbIOS
            // 
            this.rbIOS.AutoSize = true;
            this.rbIOS.Location = new System.Drawing.Point(85, 12);
            this.rbIOS.Name = "rbIOS";
            this.rbIOS.Size = new System.Drawing.Size(42, 17);
            this.rbIOS.TabIndex = 0;
            this.rbIOS.Text = "iOS";
            this.rbIOS.UseVisualStyleBackColor = true;
            this.rbIOS.CheckedChanged += new System.EventHandler(this.rbIOS_CheckedChanged);
            // 
            // rbANDROID
            // 
            this.rbANDROID.AutoSize = true;
            this.rbANDROID.Location = new System.Drawing.Point(315, 12);
            this.rbANDROID.Name = "rbANDROID";
            this.rbANDROID.Size = new System.Drawing.Size(61, 17);
            this.rbANDROID.TabIndex = 1;
            this.rbANDROID.Text = "Android";
            this.rbANDROID.UseVisualStyleBackColor = true;
            this.rbANDROID.CheckedChanged += new System.EventHandler(this.rbANDROID_CheckedChanged);
            // 
            // picIOS
            // 
            this.picIOS.Image = ((System.Drawing.Image)(resources.GetObject("picIOS.Image")));
            this.picIOS.Location = new System.Drawing.Point(12, 35);
            this.picIOS.Name = "picIOS";
            this.picIOS.Size = new System.Drawing.Size(203, 208);
            this.picIOS.TabIndex = 2;
            this.picIOS.TabStop = false;
            // 
            // picANDROID
            // 
            this.picANDROID.Image = ((System.Drawing.Image)(resources.GetObject("picANDROID.Image")));
            this.picANDROID.Location = new System.Drawing.Point(237, 35);
            this.picANDROID.Name = "picANDROID";
            this.picANDROID.Size = new System.Drawing.Size(208, 208);
            this.picANDROID.TabIndex = 3;
            this.picANDROID.TabStop = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(502, 312);
            this.Controls.Add(this.picANDROID);
            this.Controls.Add(this.picIOS);
            this.Controls.Add(this.rbANDROID);
            this.Controls.Add(this.rbIOS);
            this.Name = "Form1";
            this.Text = "Programa 4";
            ((System.ComponentModel.ISupportInitialize)(this.picIOS)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picANDROID)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton rbIOS;
        private System.Windows.Forms.RadioButton rbANDROID;
        private System.Windows.Forms.PictureBox picIOS;
        private System.Windows.Forms.PictureBox picANDROID;
    }
}

