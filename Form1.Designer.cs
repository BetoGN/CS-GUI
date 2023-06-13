namespace ProyParadigmas
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
            this.label1 = new System.Windows.Forms.Label();
            this.txtIn = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.result = new System.Windows.Forms.Label();
            this.CalcB = new System.Windows.Forms.Button();
            this.txtLog = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Verdana", 28.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(135, 64);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(319, 57);
            this.label1.TabIndex = 0;
            this.label1.Text = "Factorial de:";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // txtIn
            // 
            this.txtIn.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(102)))), ((int)(((byte)(102)))), ((int)(((byte)(255)))));
            this.txtIn.Font = new System.Drawing.Font("Verdana", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtIn.Location = new System.Drawing.Point(145, 139);
            this.txtIn.Name = "txtIn";
            this.txtIn.Size = new System.Drawing.Size(308, 44);
            this.txtIn.TabIndex = 1;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Verdana", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(252, 186);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 73);
            this.label2.TabIndex = 2;
            this.label2.Text = "=";
            // 
            // result
            // 
            this.result.AutoSize = true;
            this.result.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(148)))), ((int)(((byte)(150)))), ((int)(((byte)(255)))));
            this.result.Font = new System.Drawing.Font("Verdana", 19.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.result.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.result.Location = new System.Drawing.Point(187, 273);
            this.result.MinimumSize = new System.Drawing.Size(203, 0);
            this.result.Name = "result";
            this.result.Size = new System.Drawing.Size(203, 41);
            this.result.TabIndex = 3;
            // 
            // CalcB
            // 
            this.CalcB.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(117)))), ((int)(((byte)(26)))), ((int)(((byte)(255)))));
            this.CalcB.Cursor = System.Windows.Forms.Cursors.Hand;
            this.CalcB.Font = new System.Drawing.Font("Verdana", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.CalcB.Location = new System.Drawing.Point(552, 186);
            this.CalcB.Name = "CalcB";
            this.CalcB.Size = new System.Drawing.Size(185, 49);
            this.CalcB.TabIndex = 4;
            this.CalcB.Text = "Calcular";
            this.CalcB.UseVisualStyleBackColor = false;
            this.CalcB.Click += new System.EventHandler(this.CalcB_Click);
            // 
            // txtLog
            // 
            this.txtLog.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.txtLog.Cursor = System.Windows.Forms.Cursors.No;
            this.txtLog.Location = new System.Drawing.Point(833, 139);
            this.txtLog.Multiline = true;
            this.txtLog.Name = "txtLog";
            this.txtLog.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtLog.Size = new System.Drawing.Size(292, 320);
            this.txtLog.TabIndex = 5;
            this.txtLog.TextChanged += new System.EventHandler(this.txtLog_TextChanged);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(128)))), ((int)(((byte)(255)))));
            this.ClientSize = new System.Drawing.Size(1215, 553);
            this.Controls.Add(this.txtLog);
            this.Controls.Add(this.CalcB);
            this.Controls.Add(this.result);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.txtIn);
            this.Controls.Add(this.label1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Factorial";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtIn;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label result;
        private System.Windows.Forms.Button CalcB;
        private System.Windows.Forms.TextBox txtLog;
    }
}

