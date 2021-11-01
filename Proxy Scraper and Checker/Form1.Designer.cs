
namespace Proxy_Scraper_and_Checker
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
            this.textBox_Results = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.radioButton_Socks5 = new System.Windows.Forms.RadioButton();
            this.radioButton_Socks4 = new System.Windows.Forms.RadioButton();
            this.radioButton_Http = new System.Windows.Forms.RadioButton();
            this.button_Start = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label_TotalProxy = new System.Windows.Forms.Label();
            this.label_GoodProxy = new System.Windows.Forms.Label();
            this.label_BadProxy = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // textBox_Results
            // 
            this.textBox_Results.Location = new System.Drawing.Point(12, 12);
            this.textBox_Results.Multiline = true;
            this.textBox_Results.Name = "textBox_Results";
            this.textBox_Results.Size = new System.Drawing.Size(516, 330);
            this.textBox_Results.TabIndex = 0;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.radioButton_Socks5);
            this.groupBox1.Controls.Add(this.radioButton_Socks4);
            this.groupBox1.Controls.Add(this.radioButton_Http);
            this.groupBox1.Location = new System.Drawing.Point(12, 358);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(139, 148);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Proxy Type";
            // 
            // radioButton_Socks5
            // 
            this.radioButton_Socks5.AutoSize = true;
            this.radioButton_Socks5.Location = new System.Drawing.Point(13, 108);
            this.radioButton_Socks5.Name = "radioButton_Socks5";
            this.radioButton_Socks5.Size = new System.Drawing.Size(79, 21);
            this.radioButton_Socks5.TabIndex = 2;
            this.radioButton_Socks5.TabStop = true;
            this.radioButton_Socks5.Text = "Socks 5";
            this.radioButton_Socks5.UseVisualStyleBackColor = true;
            // 
            // radioButton_Socks4
            // 
            this.radioButton_Socks4.AutoSize = true;
            this.radioButton_Socks4.Location = new System.Drawing.Point(13, 75);
            this.radioButton_Socks4.Name = "radioButton_Socks4";
            this.radioButton_Socks4.Size = new System.Drawing.Size(79, 21);
            this.radioButton_Socks4.TabIndex = 1;
            this.radioButton_Socks4.TabStop = true;
            this.radioButton_Socks4.Text = "Socks 4";
            this.radioButton_Socks4.UseVisualStyleBackColor = true;
            // 
            // radioButton_Http
            // 
            this.radioButton_Http.AutoSize = true;
            this.radioButton_Http.Location = new System.Drawing.Point(13, 43);
            this.radioButton_Http.Name = "radioButton_Http";
            this.radioButton_Http.Size = new System.Drawing.Size(79, 21);
            this.radioButton_Http.TabIndex = 0;
            this.radioButton_Http.TabStop = true;
            this.radioButton_Http.Text = "HTTP/S";
            this.radioButton_Http.UseVisualStyleBackColor = true;
            // 
            // button_Start
            // 
            this.button_Start.Location = new System.Drawing.Point(347, 446);
            this.button_Start.Name = "button_Start";
            this.button_Start.Size = new System.Drawing.Size(181, 60);
            this.button_Start.TabIndex = 2;
            this.button_Start.Text = "Start";
            this.button_Start.UseVisualStyleBackColor = true;
            this.button_Start.Click += new System.EventHandler(this.button_Start_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(220, 358);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(79, 17);
            this.label1.TabIndex = 3;
            this.label1.Text = "Total Proxy";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(220, 392);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(82, 17);
            this.label2.TabIndex = 4;
            this.label2.Text = "Good Proxy";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(415, 358);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(72, 17);
            this.label3.TabIndex = 5;
            this.label3.Text = "Bad Proxy";
            // 
            // label_TotalProxy
            // 
            this.label_TotalProxy.AutoSize = true;
            this.label_TotalProxy.Location = new System.Drawing.Point(312, 359);
            this.label_TotalProxy.Name = "label_TotalProxy";
            this.label_TotalProxy.Size = new System.Drawing.Size(16, 17);
            this.label_TotalProxy.TabIndex = 6;
            this.label_TotalProxy.Text = "0";
            // 
            // label_GoodProxy
            // 
            this.label_GoodProxy.AutoSize = true;
            this.label_GoodProxy.Location = new System.Drawing.Point(312, 392);
            this.label_GoodProxy.Name = "label_GoodProxy";
            this.label_GoodProxy.Size = new System.Drawing.Size(16, 17);
            this.label_GoodProxy.TabIndex = 7;
            this.label_GoodProxy.Text = "0";
            // 
            // label_BadProxy
            // 
            this.label_BadProxy.AutoSize = true;
            this.label_BadProxy.Location = new System.Drawing.Point(493, 359);
            this.label_BadProxy.Name = "label_BadProxy";
            this.label_BadProxy.Size = new System.Drawing.Size(16, 17);
            this.label_BadProxy.TabIndex = 8;
            this.label_BadProxy.Text = "0";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(540, 518);
            this.Controls.Add(this.label_BadProxy);
            this.Controls.Add(this.label_GoodProxy);
            this.Controls.Add(this.label_TotalProxy);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button_Start);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.textBox_Results);
            this.Name = "Form1";
            this.Text = "Proxy Scraper and Checker";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox_Results;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton radioButton_Socks5;
        private System.Windows.Forms.RadioButton radioButton_Socks4;
        private System.Windows.Forms.RadioButton radioButton_Http;
        private System.Windows.Forms.Button button_Start;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label_TotalProxy;
        private System.Windows.Forms.Label label_GoodProxy;
        private System.Windows.Forms.Label label_BadProxy;
    }
}

