namespace Programa_6
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
            this.tbBASE = new System.Windows.Forms.TextBox();
            this.tbEXPOENTE = new System.Windows.Forms.TextBox();
            this.tbRESULTADO = new System.Windows.Forms.TextBox();
            this.btCALCULAR = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // tbBASE
            // 
            this.tbBASE.Location = new System.Drawing.Point(61, 26);
            this.tbBASE.Name = "tbBASE";
            this.tbBASE.Size = new System.Drawing.Size(80, 20);
            this.tbBASE.TabIndex = 0;
            this.tbBASE.TextChanged += new System.EventHandler(this.tbBASE_TextChanged);
            // 
            // tbEXPOENTE
            // 
            this.tbEXPOENTE.Location = new System.Drawing.Point(244, 26);
            this.tbEXPOENTE.Name = "tbEXPOENTE";
            this.tbEXPOENTE.Size = new System.Drawing.Size(80, 20);
            this.tbEXPOENTE.TabIndex = 1;
            this.tbEXPOENTE.TextChanged += new System.EventHandler(this.tbEXPOENTE_TextChanged);
            // 
            // tbRESULTADO
            // 
            this.tbRESULTADO.Location = new System.Drawing.Point(88, 66);
            this.tbRESULTADO.Name = "tbRESULTADO";
            this.tbRESULTADO.Size = new System.Drawing.Size(90, 20);
            this.tbRESULTADO.TabIndex = 2;
            this.tbRESULTADO.TextChanged += new System.EventHandler(this.tbRESULTADO_TextChanged);
            // 
            // btCALCULAR
            // 
            this.btCALCULAR.AutoEllipsis = true;
            this.btCALCULAR.Location = new System.Drawing.Point(220, 66);
            this.btCALCULAR.Name = "btCALCULAR";
            this.btCALCULAR.Size = new System.Drawing.Size(104, 20);
            this.btCALCULAR.TabIndex = 3;
            this.btCALCULAR.Text = "Calcular";
            this.btCALCULAR.UseVisualStyleBackColor = true;
            this.btCALCULAR.Click += new System.EventHandler(this.btCALCULAR_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(24, 29);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(31, 13);
            this.label1.TabIndex = 4;
            this.label1.Text = "Base";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(173, 29);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(52, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Expoente";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(24, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(58, 13);
            this.label3.TabIndex = 6;
            this.label3.Text = "Resultado:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(374, 123);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btCALCULAR);
            this.Controls.Add(this.tbRESULTADO);
            this.Controls.Add(this.tbEXPOENTE);
            this.Controls.Add(this.tbBASE);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox tbBASE;
        private System.Windows.Forms.TextBox tbEXPOENTE;
        private System.Windows.Forms.TextBox tbRESULTADO;
        private System.Windows.Forms.Button btCALCULAR;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
    }
}

