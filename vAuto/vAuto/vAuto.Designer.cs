namespace vAuto
{
    partial class vAuto
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
            this.btnProcess = new System.Windows.Forms.Button();
            this.lblDatasetId = new System.Windows.Forms.Label();
            this.txtDatasetId = new System.Windows.Forms.TextBox();
            this.txtResponse = new System.Windows.Forms.TextBox();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.lblResponce = new System.Windows.Forms.Label();
            this.lblloading = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnProcess
            // 
            this.btnProcess.BackColor = System.Drawing.SystemColors.Highlight;
            this.btnProcess.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnProcess.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnProcess.ForeColor = System.Drawing.Color.White;
            this.btnProcess.Location = new System.Drawing.Point(423, 12);
            this.btnProcess.Name = "btnProcess";
            this.btnProcess.Size = new System.Drawing.Size(119, 38);
            this.btnProcess.TabIndex = 0;
            this.btnProcess.Text = "Process";
            this.btnProcess.UseVisualStyleBackColor = false;
            this.btnProcess.Click += new System.EventHandler(this.btnProcess_Click);
            // 
            // lblDatasetId
            // 
            this.lblDatasetId.AutoSize = true;
            this.lblDatasetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblDatasetId.Location = new System.Drawing.Point(8, 15);
            this.lblDatasetId.Name = "lblDatasetId";
            this.lblDatasetId.Size = new System.Drawing.Size(96, 20);
            this.lblDatasetId.TabIndex = 1;
            this.lblDatasetId.Text = "Dataset Id : ";
            // 
            // txtDatasetId
            // 
            this.txtDatasetId.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtDatasetId.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDatasetId.Location = new System.Drawing.Point(110, 12);
            this.txtDatasetId.Name = "txtDatasetId";
            this.txtDatasetId.ReadOnly = true;
            this.txtDatasetId.Size = new System.Drawing.Size(255, 26);
            this.txtDatasetId.TabIndex = 2;
            // 
            // txtResponse
            // 
            this.txtResponse.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtResponse.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtResponse.Location = new System.Drawing.Point(406, 92);
            this.txtResponse.Multiline = true;
            this.txtResponse.Name = "txtResponse";
            this.txtResponse.ReadOnly = true;
            this.txtResponse.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtResponse.Size = new System.Drawing.Size(266, 383);
            this.txtResponse.TabIndex = 3;
            // 
            // txtInput
            // 
            this.txtInput.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtInput.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtInput.Location = new System.Drawing.Point(12, 92);
            this.txtInput.Multiline = true;
            this.txtInput.Name = "txtInput";
            this.txtInput.ReadOnly = true;
            this.txtInput.ScrollBars = System.Windows.Forms.ScrollBars.Both;
            this.txtInput.Size = new System.Drawing.Size(388, 383);
            this.txtInput.TabIndex = 4;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(470, 72);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(72, 17);
            this.label2.TabIndex = 6;
            this.label2.Text = "Response";
            // 
            // lblResponce
            // 
            this.lblResponce.AutoSize = true;
            this.lblResponce.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Underline, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblResponce.Location = new System.Drawing.Point(107, 72);
            this.lblResponce.Name = "lblResponce";
            this.lblResponce.Size = new System.Drawing.Size(68, 17);
            this.lblResponce.TabIndex = 7;
            this.lblResponce.Text = "Post data";
            // 
            // lblloading
            // 
            this.lblloading.AutoSize = true;
            this.lblloading.Font = new System.Drawing.Font("Leelawadee UI Semilight", 45F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblloading.ForeColor = System.Drawing.SystemColors.ControlText;
            this.lblloading.Location = new System.Drawing.Point(187, 214);
            this.lblloading.Name = "lblloading";
            this.lblloading.Size = new System.Drawing.Size(386, 81);
            this.lblloading.TabIndex = 8;
            this.lblloading.Text = "Processing......";
            this.lblloading.Visible = false;
            // 
            // vAuto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.ClientSize = new System.Drawing.Size(684, 503);
            this.Controls.Add(this.lblloading);
            this.Controls.Add(this.lblResponce);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.txtResponse);
            this.Controls.Add(this.txtDatasetId);
            this.Controls.Add(this.lblDatasetId);
            this.Controls.Add(this.btnProcess);
            this.Name = "vAuto";
            this.Text = "VAuto";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnProcess;
        private System.Windows.Forms.Label lblDatasetId;
        private System.Windows.Forms.TextBox txtDatasetId;
        private System.Windows.Forms.TextBox txtResponse;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblResponce;
        private System.Windows.Forms.Label lblloading;
    }
}

