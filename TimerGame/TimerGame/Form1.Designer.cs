namespace TimerGame
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
            this.components = new System.ComponentModel.Container();
            this.lblsec = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.lblhr = new System.Windows.Forms.Label();
            this.lblmin = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.timer2 = new System.Windows.Forms.Timer(this.components);
            this.timer3 = new System.Windows.Forms.Timer(this.components);
            this.SuspendLayout();
            // 
            // lblsec
            // 
            this.lblsec.AutoSize = true;
            this.lblsec.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblsec.Location = new System.Drawing.Point(191, 69);
            this.lblsec.Name = "lblsec";
            this.lblsec.Size = new System.Drawing.Size(75, 82);
            this.lblsec.TabIndex = 0;
            this.lblsec.Text = "0";
            this.lblsec.Click += new System.EventHandler(this.label1_Click);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(288, 304);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 39);
            this.button1.TabIndex = 1;
            this.button1.Text = "start";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(381, 304);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(75, 39);
            this.button2.TabIndex = 2;
            this.button2.Text = "stop";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // lblhr
            // 
            this.lblhr.AutoSize = true;
            this.lblhr.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblhr.Location = new System.Drawing.Point(527, 69);
            this.lblhr.Name = "lblhr";
            this.lblhr.Size = new System.Drawing.Size(75, 82);
            this.lblhr.TabIndex = 3;
            this.lblhr.Text = "0";
            this.lblhr.Click += new System.EventHandler(this.label2_Click);
            // 
            // lblmin
            // 
            this.lblmin.AutoSize = true;
            this.lblmin.Font = new System.Drawing.Font("Microsoft Sans Serif", 36F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblmin.Location = new System.Drawing.Point(367, 69);
            this.lblmin.Name = "lblmin";
            this.lblmin.Size = new System.Drawing.Size(75, 82);
            this.lblmin.TabIndex = 4;
            this.lblmin.Text = "0";
            this.lblmin.Click += new System.EventHandler(this.label3_Click);
            // 
            // timer1
            // 
            this.timer1.Interval = 500;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // timer2
            // 
            this.timer2.Interval = 1000;
            this.timer2.Tick += new System.EventHandler(this.timer2_Tick);
            // 
            // timer3
            // 
            this.timer3.Interval = 1500;
            this.timer3.Tick += new System.EventHandler(this.timer3_Tick);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.lblmin);
            this.Controls.Add(this.lblhr);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.lblsec);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lblsec;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label lblhr;
        private System.Windows.Forms.Label lblmin;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Timer timer2;
        private System.Windows.Forms.Timer timer3;
    }
}

