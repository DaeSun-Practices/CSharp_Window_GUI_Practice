namespace Excersice1
{
    partial class Calculator
    {
        /// <summary>
        /// 필수 디자이너 변수입니다.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 사용 중인 모든 리소스를 정리합니다.
        /// </summary>
        /// <param name="disposing">관리되는 리소스를 삭제해야 하면 true이고, 그렇지 않으면 false입니다.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form 디자이너에서 생성한 코드

        /// <summary>
        /// 디자이너 지원에 필요한 메서드입니다. 
        /// 이 메서드의 내용을 코드 편집기로 수정하지 마세요.
        /// </summary>
        private void InitializeComponent()
        {
            this.HelloLabel = new System.Windows.Forms.Label();
            this.sum1 = new System.Windows.Forms.TextBox();
            this.sum2 = new System.Windows.Forms.TextBox();
            this.SumResult = new System.Windows.Forms.TextBox();
            this.SumButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // HelloLabel
            // 
            this.HelloLabel.AutoSize = true;
            this.HelloLabel.Location = new System.Drawing.Point(176, 131);
            this.HelloLabel.Name = "HelloLabel";
            this.HelloLabel.Size = new System.Drawing.Size(158, 18);
            this.HelloLabel.TabIndex = 0;
            this.HelloLabel.Text = "여기를 클릭하세요";
            this.HelloLabel.Click += new System.EventHandler(this.Label1_Click);
            // 
            // sum1
            // 
            this.sum1.Location = new System.Drawing.Point(130, 200);
            this.sum1.Name = "sum1";
            this.sum1.Size = new System.Drawing.Size(186, 28);
            this.sum1.TabIndex = 1;
            // 
            // sum2
            // 
            this.sum2.Location = new System.Drawing.Point(382, 199);
            this.sum2.Name = "sum2";
            this.sum2.Size = new System.Drawing.Size(209, 28);
            this.sum2.TabIndex = 2;
            // 
            // SumResult
            // 
            this.SumResult.Location = new System.Drawing.Point(827, 199);
            this.SumResult.Name = "SumResult";
            this.SumResult.Size = new System.Drawing.Size(216, 28);
            this.SumResult.TabIndex = 3;
            // 
            // SumButton
            // 
            this.SumButton.Location = new System.Drawing.Point(622, 199);
            this.SumButton.Name = "SumButton";
            this.SumButton.Size = new System.Drawing.Size(168, 25);
            this.SumButton.TabIndex = 4;
            this.SumButton.Text = "+";
            this.SumButton.UseVisualStyleBackColor = true;
            this.SumButton.Click += new System.EventHandler(this.SumButton_Click);
            // 
            // Calculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1224, 652);
            this.Controls.Add(this.SumButton);
            this.Controls.Add(this.SumResult);
            this.Controls.Add(this.sum2);
            this.Controls.Add(this.sum1);
            this.Controls.Add(this.HelloLabel);
            this.Name = "Calculator";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label HelloLabel;
        private System.Windows.Forms.TextBox sum1;
        private System.Windows.Forms.TextBox sum2;
        private System.Windows.Forms.TextBox SumResult;
        private System.Windows.Forms.Button SumButton;
    }
}

