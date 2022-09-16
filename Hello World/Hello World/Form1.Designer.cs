namespace Hello_World
{
    partial class Form1
    {
        /// <summary>
        /// 設計工具所需的變數。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清除任何使用中的資源。
        /// </summary>
        /// <param name="disposing">如果應該處置受控資源則為 true，否則為 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 設計工具產生的程式碼

        /// <summary>
        /// 此為設計工具支援所需的方法 - 請勿使用程式碼編輯器修改
        /// 這個方法的內容。
        /// </summary>
        private void InitializeComponent()
        {
            this.btnSay = new System.Windows.Forms.Button();
            this.labHelloWorld = new System.Windows.Forms.Label();
            this.btnCount = new System.Windows.Forms.Button();
            this.labCount = new System.Windows.Forms.Label();
            this.labDateTime = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // btnSay
            // 
            this.btnSay.Location = new System.Drawing.Point(44, 153);
            this.btnSay.Name = "btnSay";
            this.btnSay.Size = new System.Drawing.Size(101, 23);
            this.btnSay.TabIndex = 0;
            this.btnSay.Text = "Say Hello";
            this.btnSay.UseVisualStyleBackColor = true;
            this.btnSay.Click += new System.EventHandler(this.btnSay_Click);
            // 
            // labHelloWorld
            // 
            this.labHelloWorld.AutoSize = true;
            this.labHelloWorld.Location = new System.Drawing.Point(65, 209);
            this.labHelloWorld.Name = "labHelloWorld";
            this.labHelloWorld.Size = new System.Drawing.Size(33, 12);
            this.labHelloWorld.TabIndex = 1;
            this.labHelloWorld.Text = "label1";
            // 
            // btnCount
            // 
            this.btnCount.Location = new System.Drawing.Point(267, 153);
            this.btnCount.Name = "btnCount";
            this.btnCount.Size = new System.Drawing.Size(75, 23);
            this.btnCount.TabIndex = 2;
            this.btnCount.Text = "Count";
            this.btnCount.UseVisualStyleBackColor = true;
            this.btnCount.Click += new System.EventHandler(this.btnCount_Click);
            // 
            // labCount
            // 
            this.labCount.AutoSize = true;
            this.labCount.Location = new System.Drawing.Point(300, 209);
            this.labCount.Name = "labCount";
            this.labCount.Size = new System.Drawing.Size(11, 12);
            this.labCount.TabIndex = 3;
            this.labCount.Text = "0";
            // 
            // labDateTime
            // 
            this.labDateTime.AutoSize = true;
            this.labDateTime.Font = new System.Drawing.Font("新細明體", 12F);
            this.labDateTime.Location = new System.Drawing.Point(125, 70);
            this.labDateTime.Name = "labDateTime";
            this.labDateTime.Size = new System.Drawing.Size(72, 16);
            this.labDateTime.TabIndex = 4;
            this.labDateTime.Text = "Date Time";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(397, 300);
            this.Controls.Add(this.labDateTime);
            this.Controls.Add(this.labCount);
            this.Controls.Add(this.btnCount);
            this.Controls.Add(this.labHelloWorld);
            this.Controls.Add(this.btnSay);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnSay;
        private System.Windows.Forms.Label labHelloWorld;
        private System.Windows.Forms.Button btnCount;
        private System.Windows.Forms.Label labCount;
        private System.Windows.Forms.Label labDateTime;
    }
}

