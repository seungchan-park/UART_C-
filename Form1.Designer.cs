namespace stm32v1
{
    partial class Form1
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
            this.components = new System.ComponentModel.Container();
            this.label1 = new System.Windows.Forms.Label();
            this.btn1 = new System.Windows.Forms.Button();
            this.btn2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.tbrx = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.cbport = new System.Windows.Forms.ComboBox();
            this.label4 = new System.Windows.Forms.Label();
            this.cbbaud = new System.Windows.Forms.ComboBox();
            this.serialPort1 = new System.IO.Ports.SerialPort(this.components);
            this.btn3 = new System.Windows.Forms.Button();
            this.tbtx = new System.Windows.Forms.TextBox();
            this.btntx = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("굴림", 15F);
            this.label1.Location = new System.Drawing.Point(3, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(88, 25);
            this.label1.TabIndex = 0;
            this.label1.Text = "STM32";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // btn1
            // 
            this.btn1.Location = new System.Drawing.Point(323, 159);
            this.btn1.Name = "btn1";
            this.btn1.Size = new System.Drawing.Size(87, 45);
            this.btn1.TabIndex = 1;
            this.btn1.Text = "ONEN";
            this.btn1.UseVisualStyleBackColor = true;
            this.btn1.Click += new System.EventHandler(this.btn1_Click);
            // 
            // btn2
            // 
            this.btn2.Location = new System.Drawing.Point(416, 159);
            this.btn2.Name = "btn2";
            this.btn2.Size = new System.Drawing.Size(90, 45);
            this.btn2.TabIndex = 2;
            this.btn2.Text = "CLOSE";
            this.btn2.UseVisualStyleBackColor = true;
            this.btn2.Click += new System.EventHandler(this.btn2_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label2.Location = new System.Drawing.Point(12, 46);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(34, 20);
            this.label2.TabIndex = 3;
            this.label2.Text = "RX";
            // 
            // tbrx
            // 
            this.tbrx.Location = new System.Drawing.Point(8, 69);
            this.tbrx.Multiline = true;
            this.tbrx.Name = "tbrx";
            this.tbrx.Size = new System.Drawing.Size(271, 214);
            this.tbrx.TabIndex = 4;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label3.Location = new System.Drawing.Point(319, 69);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(60, 20);
            this.label3.TabIndex = 5;
            this.label3.Text = "PORT";
            // 
            // cbport
            // 
            this.cbport.FormattingEnabled = true;
            this.cbport.Location = new System.Drawing.Point(385, 70);
            this.cbport.Name = "cbport";
            this.cbport.Size = new System.Drawing.Size(121, 23);
            this.cbport.TabIndex = 6;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.label4.Location = new System.Drawing.Point(319, 115);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "BAUD";
            // 
            // cbbaud
            // 
            this.cbbaud.FormattingEnabled = true;
            this.cbbaud.Items.AddRange(new object[] {
            "4800",
            "9600",
            "19200",
            "38400",
            "57600",
            "115200"});
            this.cbbaud.Location = new System.Drawing.Point(385, 115);
            this.cbbaud.Name = "cbbaud";
            this.cbbaud.Size = new System.Drawing.Size(121, 23);
            this.cbbaud.TabIndex = 8;
            // 
            // serialPort1
            // 
            this.serialPort1.DataReceived += new System.IO.Ports.SerialDataReceivedEventHandler(this.serialPort1_DataReceived);
            // 
            // btn3
            // 
            this.btn3.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btn3.Location = new System.Drawing.Point(8, 289);
            this.btn3.Name = "btn3";
            this.btn3.Size = new System.Drawing.Size(271, 28);
            this.btn3.TabIndex = 9;
            this.btn3.Text = "CLEAR";
            this.btn3.UseVisualStyleBackColor = true;
            this.btn3.Click += new System.EventHandler(this.btn3_Click);
            // 
            // tbtx
            // 
            this.tbtx.Location = new System.Drawing.Point(8, 365);
            this.tbtx.Name = "tbtx";
            this.tbtx.Size = new System.Drawing.Size(271, 25);
            this.tbtx.TabIndex = 10;
            // 
            // btntx
            // 
            this.btntx.Font = new System.Drawing.Font("굴림", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(129)));
            this.btntx.Location = new System.Drawing.Point(8, 396);
            this.btntx.Name = "btntx";
            this.btntx.Size = new System.Drawing.Size(271, 28);
            this.btntx.TabIndex = 11;
            this.btntx.Text = "SEND";
            this.btntx.UseVisualStyleBackColor = true;
            this.btntx.Click += new System.EventHandler(this.btntx_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(534, 450);
            this.Controls.Add(this.btntx);
            this.Controls.Add(this.tbtx);
            this.Controls.Add(this.btn3);
            this.Controls.Add(this.cbbaud);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.cbport);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.tbrx);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.btn2);
            this.Controls.Add(this.btn1);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn1;
        private System.Windows.Forms.Button btn2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tbrx;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ComboBox cbport;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.ComboBox cbbaud;
        private System.IO.Ports.SerialPort serialPort1;
        private System.Windows.Forms.Button btn3;
        private System.Windows.Forms.TextBox tbtx;
        private System.Windows.Forms.Button btntx;
    }
}

