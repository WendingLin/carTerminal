namespace WifiVideo
{
    partial class Form1
    {
        /// <summary>
        /// 必需的设计器变量。
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// 清理所有正在使用的资源。
        /// </summary>
        /// <param name="disposing">如果应释放托管资源，为 true；否则为 false。</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows 窗体设计器生成的代码

        /// <summary>
        /// 设计器支持所需的方法 - 不要
        /// 使用代码编辑器修改此方法的内容。
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.ledoff = new System.Windows.Forms.Button();
            this.ledon = new System.Windows.Forms.Button();
            this.btnEngineright = new System.Windows.Forms.Button();
            this.btnEngineleft = new System.Windows.Forms.Button();
            this.buttonRight2 = new System.Windows.Forms.Button();
            this.buttonLeft2 = new System.Windows.Forms.Button();
            this.buttonRight1 = new System.Windows.Forms.Button();
            this.buttonLeft1 = new System.Windows.Forms.Button();
            this.btnEngineDown = new System.Windows.Forms.Button();
            this.btnEngineUp = new System.Windows.Forms.Button();
            this.buttonStop = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.buttonBackward = new System.Windows.Forms.Button();
            this.buttonRight = new System.Windows.Forms.Button();
            this.buttonLeft = new System.Windows.Forms.Button();
            this.buttonForward = new System.Windows.Forms.Button();
            this.button1 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.pictureBox1.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox1.Image")));
            this.pictureBox1.Location = new System.Drawing.Point(4, 87);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(533, 380);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            this.pictureBox1.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 200;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.ledoff);
            this.groupBox1.Controls.Add(this.ledon);
            this.groupBox1.Controls.Add(this.btnEngineright);
            this.groupBox1.Controls.Add(this.btnEngineleft);
            this.groupBox1.Controls.Add(this.buttonRight2);
            this.groupBox1.Controls.Add(this.buttonLeft2);
            this.groupBox1.Controls.Add(this.buttonRight1);
            this.groupBox1.Controls.Add(this.buttonLeft1);
            this.groupBox1.Controls.Add(this.btnEngineDown);
            this.groupBox1.Controls.Add(this.btnEngineUp);
            this.groupBox1.Controls.Add(this.buttonStop);
            this.groupBox1.Controls.Add(this.button6);
            this.groupBox1.Controls.Add(this.buttonBackward);
            this.groupBox1.Controls.Add(this.buttonRight);
            this.groupBox1.Controls.Add(this.buttonLeft);
            this.groupBox1.Controls.Add(this.buttonForward);
            this.groupBox1.Controls.Add(this.button1);
            this.groupBox1.Location = new System.Drawing.Point(4, 473);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(682, 179);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "操作指令";
            // 
            // ledoff
            // 
            this.ledoff.Location = new System.Drawing.Point(385, 85);
            this.ledoff.Name = "ledoff";
            this.ledoff.Size = new System.Drawing.Size(75, 23);
            this.ledoff.TabIndex = 26;
            this.ledoff.Text = "灯关";
            this.ledoff.UseVisualStyleBackColor = true;
            this.ledoff.Click += new System.EventHandler(this.ledoff_Click);
            // 
            // ledon
            // 
            this.ledon.Location = new System.Drawing.Point(385, 40);
            this.ledon.Name = "ledon";
            this.ledon.Size = new System.Drawing.Size(75, 23);
            this.ledon.TabIndex = 25;
            this.ledon.Text = "灯开";
            this.ledon.UseVisualStyleBackColor = true;
            this.ledon.Click += new System.EventHandler(this.ledon_Click);
            // 
            // btnEngineright
            // 
            this.btnEngineright.Location = new System.Drawing.Point(618, 114);
            this.btnEngineright.Name = "btnEngineright";
            this.btnEngineright.Size = new System.Drawing.Size(63, 42);
            this.btnEngineright.TabIndex = 24;
            this.btnEngineright.Text = "舵机右(L)";
            this.btnEngineright.UseVisualStyleBackColor = true;
            this.btnEngineright.Click += new System.EventHandler(this.btnEngineright_Click);
            // 
            // btnEngineleft
            // 
            this.btnEngineleft.Location = new System.Drawing.Point(480, 114);
            this.btnEngineleft.Name = "btnEngineleft";
            this.btnEngineleft.Size = new System.Drawing.Size(63, 42);
            this.btnEngineleft.TabIndex = 23;
            this.btnEngineleft.Text = "舵机左(J)";
            this.btnEngineleft.UseVisualStyleBackColor = true;
            this.btnEngineleft.Click += new System.EventHandler(this.btnEngineleft_Click);
            // 
            // buttonRight2
            // 
            this.buttonRight2.Location = new System.Drawing.Point(172, 133);
            this.buttonRight2.Name = "buttonRight2";
            this.buttonRight2.Size = new System.Drawing.Size(64, 42);
            this.buttonRight2.TabIndex = 22;
            this.buttonRight2.Text = "右\r\n(C)";
            this.buttonRight2.UseVisualStyleBackColor = true;
            this.buttonRight2.Click += new System.EventHandler(this.button13_Click);
            // 
            // buttonLeft2
            // 
            this.buttonLeft2.Location = new System.Drawing.Point(33, 133);
            this.buttonLeft2.Name = "buttonLeft2";
            this.buttonLeft2.Size = new System.Drawing.Size(64, 42);
            this.buttonLeft2.TabIndex = 21;
            this.buttonLeft2.Text = "左\r\n(Z)";
            this.buttonLeft2.UseVisualStyleBackColor = true;
            this.buttonLeft2.Click += new System.EventHandler(this.button12_Click);
            // 
            // buttonRight1
            // 
            this.buttonRight1.Location = new System.Drawing.Point(172, 37);
            this.buttonRight1.Name = "buttonRight1";
            this.buttonRight1.Size = new System.Drawing.Size(64, 42);
            this.buttonRight1.TabIndex = 20;
            this.buttonRight1.Text = "右\r\n(E)";
            this.buttonRight1.UseVisualStyleBackColor = true;
            this.buttonRight1.Click += new System.EventHandler(this.button11_Click);
            // 
            // buttonLeft1
            // 
            this.buttonLeft1.Location = new System.Drawing.Point(33, 37);
            this.buttonLeft1.Name = "buttonLeft1";
            this.buttonLeft1.Size = new System.Drawing.Size(64, 42);
            this.buttonLeft1.TabIndex = 19;
            this.buttonLeft1.Text = "左\r\n(Q)";
            this.buttonLeft1.UseVisualStyleBackColor = true;
            this.buttonLeft1.Click += new System.EventHandler(this.button10_Click);
            // 
            // btnEngineDown
            // 
            this.btnEngineDown.Location = new System.Drawing.Point(549, 114);
            this.btnEngineDown.Name = "btnEngineDown";
            this.btnEngineDown.Size = new System.Drawing.Size(63, 42);
            this.btnEngineDown.TabIndex = 18;
            this.btnEngineDown.Text = "舵机下(K)";
            this.btnEngineDown.UseVisualStyleBackColor = true;
            this.btnEngineDown.Click += new System.EventHandler(this.btnEngineDown_Click);
            // 
            // btnEngineUp
            // 
            this.btnEngineUp.Location = new System.Drawing.Point(549, 66);
            this.btnEngineUp.Name = "btnEngineUp";
            this.btnEngineUp.Size = new System.Drawing.Size(63, 42);
            this.btnEngineUp.TabIndex = 17;
            this.btnEngineUp.Text = "舵机上(I)";
            this.btnEngineUp.UseVisualStyleBackColor = true;
            this.btnEngineUp.Click += new System.EventHandler(this.btnEngineUp_Click);
            // 
            // buttonStop
            // 
            this.buttonStop.Location = new System.Drawing.Point(103, 85);
            this.buttonStop.Name = "buttonStop";
            this.buttonStop.Size = new System.Drawing.Size(63, 42);
            this.buttonStop.TabIndex = 16;
            this.buttonStop.Text = "停";
            this.buttonStop.UseVisualStyleBackColor = true;
            this.buttonStop.Click += new System.EventHandler(this.buttonStop_Click);
            // 
            // button6
            // 
            this.button6.Location = new System.Drawing.Point(279, 82);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(75, 28);
            this.button6.TabIndex = 15;
            this.button6.Text = "设置";
            this.button6.UseVisualStyleBackColor = true;
            this.button6.Click += new System.EventHandler(this.button6_Click);
            // 
            // buttonBackward
            // 
            this.buttonBackward.Location = new System.Drawing.Point(103, 133);
            this.buttonBackward.Name = "buttonBackward";
            this.buttonBackward.Size = new System.Drawing.Size(63, 42);
            this.buttonBackward.TabIndex = 14;
            this.buttonBackward.Text = "后\r\n(S)";
            this.buttonBackward.UseVisualStyleBackColor = true;
            this.buttonBackward.Click += new System.EventHandler(this.button5_Click);
            // 
            // buttonRight
            // 
            this.buttonRight.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.buttonRight.Location = new System.Drawing.Point(172, 85);
            this.buttonRight.Name = "buttonRight";
            this.buttonRight.Size = new System.Drawing.Size(64, 42);
            this.buttonRight.TabIndex = 13;
            this.buttonRight.Text = "右\r\n(D)";
            this.buttonRight.UseVisualStyleBackColor = true;
            this.buttonRight.Click += new System.EventHandler(this.button4_Click);
            // 
            // buttonLeft
            // 
            this.buttonLeft.Location = new System.Drawing.Point(33, 85);
            this.buttonLeft.Name = "buttonLeft";
            this.buttonLeft.Size = new System.Drawing.Size(64, 42);
            this.buttonLeft.TabIndex = 12;
            this.buttonLeft.Text = "左\r\n(A)";
            this.buttonLeft.UseVisualStyleBackColor = true;
            this.buttonLeft.Click += new System.EventHandler(this.button3_Click);
            // 
            // buttonForward
            // 
            this.buttonForward.Location = new System.Drawing.Point(103, 37);
            this.buttonForward.Name = "buttonForward";
            this.buttonForward.Size = new System.Drawing.Size(63, 42);
            this.buttonForward.TabIndex = 11;
            this.buttonForward.Text = "前\r\n（W）";
            this.buttonForward.UseVisualStyleBackColor = true;
            this.buttonForward.Click += new System.EventHandler(this.button2_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(279, 37);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 28);
            this.button1.TabIndex = 10;
            this.button1.Text = "视频";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 12F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 664);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox1);
            this.KeyPreview = true;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "WIFI  ROBOT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button btnEngineDown;
        private System.Windows.Forms.Button btnEngineUp;
        private System.Windows.Forms.Button buttonStop;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button buttonBackward;
        private System.Windows.Forms.Button buttonRight;
        private System.Windows.Forms.Button buttonLeft;
        private System.Windows.Forms.Button buttonForward;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button buttonRight1;
        private System.Windows.Forms.Button buttonLeft1;
        private System.Windows.Forms.Button ledoff;
        private System.Windows.Forms.Button ledon;
        private System.Windows.Forms.Button btnEngineright;
        private System.Windows.Forms.Button btnEngineleft;
        private System.Windows.Forms.Button buttonRight2;
        private System.Windows.Forms.Button buttonLeft2;
    }
}

