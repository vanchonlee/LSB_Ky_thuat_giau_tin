namespace LSB
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
            this.imageImput = new System.Windows.Forms.PictureBox();
            this.imageOutput = new System.Windows.Forms.PictureBox();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.btnImageInput = new System.Windows.Forms.Button();
            this.btnLSB = new System.Windows.Forms.Button();
            this.btnExtract = new System.Windows.Forms.Button();
            this.lblKq = new System.Windows.Forms.Label();
            this.txtInput = new System.Windows.Forms.TextBox();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog2 = new System.Windows.Forms.OpenFileDialog();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.imageImput)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).BeginInit();
            this.SuspendLayout();
            // 
            // imageImput
            // 
            this.imageImput.Location = new System.Drawing.Point(12, 54);
            this.imageImput.Name = "imageImput";
            this.imageImput.Size = new System.Drawing.Size(157, 96);
            this.imageImput.TabIndex = 0;
            this.imageImput.TabStop = false;
            // 
            // imageOutput
            // 
            this.imageOutput.Location = new System.Drawing.Point(238, 54);
            this.imageOutput.Name = "imageOutput";
            this.imageOutput.Size = new System.Drawing.Size(157, 96);
            this.imageOutput.TabIndex = 1;
            this.imageOutput.TabStop = false;
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // btnImageInput
            // 
            this.btnImageInput.Location = new System.Drawing.Point(12, 169);
            this.btnImageInput.Name = "btnImageInput";
            this.btnImageInput.Size = new System.Drawing.Size(75, 23);
            this.btnImageInput.TabIndex = 2;
            this.btnImageInput.Text = "select ";
            this.btnImageInput.UseVisualStyleBackColor = true;
            this.btnImageInput.Click += new System.EventHandler(this.btnImageInput_Click);
            // 
            // btnLSB
            // 
            this.btnLSB.Location = new System.Drawing.Point(12, 227);
            this.btnLSB.Name = "btnLSB";
            this.btnLSB.Size = new System.Drawing.Size(383, 81);
            this.btnLSB.TabIndex = 3;
            this.btnLSB.Text = "LSB";
            this.btnLSB.UseVisualStyleBackColor = true;
            this.btnLSB.Click += new System.EventHandler(this.btnLSB_Click);
            // 
            // btnExtract
            // 
            this.btnExtract.Location = new System.Drawing.Point(238, 169);
            this.btnExtract.Name = "btnExtract";
            this.btnExtract.Size = new System.Drawing.Size(75, 23);
            this.btnExtract.TabIndex = 4;
            this.btnExtract.Text = "extract";
            this.btnExtract.UseVisualStyleBackColor = true;
            this.btnExtract.Click += new System.EventHandler(this.btnExtract_Click);
            // 
            // lblKq
            // 
            this.lblKq.AutoSize = true;
            this.lblKq.Location = new System.Drawing.Point(235, 204);
            this.lblKq.Name = "lblKq";
            this.lblKq.Size = new System.Drawing.Size(35, 13);
            this.lblKq.TabIndex = 5;
            this.lblKq.Text = "label1";
            // 
            // txtInput
            // 
            this.txtInput.Location = new System.Drawing.Point(12, 201);
            this.txtInput.Name = "txtInput";
            this.txtInput.Size = new System.Drawing.Size(157, 20);
            this.txtInput.TabIndex = 6;
            // 
            // openFileDialog2
            // 
            this.openFileDialog2.FileName = "openFileDialog2";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(320, 169);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 7;
            this.button1.Text = "select";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(94, 169);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 23);
            this.button2.TabIndex = 8;
            this.button2.Text = "save";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(12, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(387, 17);
            this.label1.TabIndex = 9;
            this.label1.Text = "LÊ VĂN CHƠN - N14DCAT076 -- lỚP D14CQAT01_N";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 324);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtInput);
            this.Controls.Add(this.lblKq);
            this.Controls.Add(this.btnExtract);
            this.Controls.Add(this.btnLSB);
            this.Controls.Add(this.btnImageInput);
            this.Controls.Add(this.imageOutput);
            this.Controls.Add(this.imageImput);
            this.Name = "Form1";
            this.Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)(this.imageImput)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.imageOutput)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox imageImput;
        private System.Windows.Forms.PictureBox imageOutput;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.Button btnImageInput;
        private System.Windows.Forms.Button btnLSB;
        private System.Windows.Forms.Button btnExtract;
        private System.Windows.Forms.Label lblKq;
        private System.Windows.Forms.TextBox txtInput;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog2;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label1;
    }
}

