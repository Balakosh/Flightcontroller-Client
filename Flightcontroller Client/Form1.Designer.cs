namespace Flightcontroller_Client
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.txtIP = new System.Windows.Forms.TextBox();
            this.btnConnect = new System.Windows.Forms.Button();
            this.lblFrameCounter = new System.Windows.Forms.Label();
            this.lblAccX = new System.Windows.Forms.Label();
            this.lblAccY = new System.Windows.Forms.Label();
            this.lblAccZ = new System.Windows.Forms.Label();
            this.gbAcc = new System.Windows.Forms.GroupBox();
            this.gbOmg = new System.Windows.Forms.GroupBox();
            this.lblOmgX = new System.Windows.Forms.Label();
            this.lblOmgZ = new System.Windows.Forms.Label();
            this.lblOmgY = new System.Windows.Forms.Label();
            this.lblTemperature = new System.Windows.Forms.Label();
            this.gbRPY = new System.Windows.Forms.GroupBox();
            this.lblRoll = new System.Windows.Forms.Label();
            this.lblYaw = new System.Windows.Forms.Label();
            this.lblPitch = new System.Windows.Forms.Label();
            this.gbAcc.SuspendLayout();
            this.gbOmg.SuspendLayout();
            this.gbRPY.SuspendLayout();
            this.SuspendLayout();
            // 
            // txtIP
            // 
            this.txtIP.Location = new System.Drawing.Point(12, 12);
            this.txtIP.Name = "txtIP";
            this.txtIP.Size = new System.Drawing.Size(100, 23);
            this.txtIP.TabIndex = 0;
            this.txtIP.Text = "192.168.0.5";
            // 
            // btnConnect
            // 
            this.btnConnect.Location = new System.Drawing.Point(118, 11);
            this.btnConnect.Name = "btnConnect";
            this.btnConnect.Size = new System.Drawing.Size(127, 23);
            this.btnConnect.TabIndex = 1;
            this.btnConnect.Text = "Connect";
            this.btnConnect.UseVisualStyleBackColor = true;
            this.btnConnect.Click += new System.EventHandler(this.btnConnect_Click);
            // 
            // lblFrameCounter
            // 
            this.lblFrameCounter.AutoSize = true;
            this.lblFrameCounter.Location = new System.Drawing.Point(294, 84);
            this.lblFrameCounter.Name = "lblFrameCounter";
            this.lblFrameCounter.Size = new System.Drawing.Size(103, 15);
            this.lblFrameCounter.TabIndex = 2;
            this.lblFrameCounter.Text = "FrameCounter = 0";
            // 
            // lblAccX
            // 
            this.lblAccX.AutoSize = true;
            this.lblAccX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccX.Location = new System.Drawing.Point(6, 19);
            this.lblAccX.Name = "lblAccX";
            this.lblAccX.Size = new System.Drawing.Size(126, 25);
            this.lblAccX.TabIndex = 3;
            this.lblAccX.Text = "AccX = 0.00 g";
            // 
            // lblAccY
            // 
            this.lblAccY.AutoSize = true;
            this.lblAccY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccY.Location = new System.Drawing.Point(7, 45);
            this.lblAccY.Name = "lblAccY";
            this.lblAccY.Size = new System.Drawing.Size(126, 25);
            this.lblAccY.TabIndex = 4;
            this.lblAccY.Text = "AccY = 0.00 g";
            // 
            // lblAccZ
            // 
            this.lblAccZ.AutoSize = true;
            this.lblAccZ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblAccZ.Location = new System.Drawing.Point(7, 76);
            this.lblAccZ.Name = "lblAccZ";
            this.lblAccZ.Size = new System.Drawing.Size(126, 25);
            this.lblAccZ.TabIndex = 5;
            this.lblAccZ.Text = "AccZ = 0.00 g";
            // 
            // gbAcc
            // 
            this.gbAcc.Controls.Add(this.lblAccX);
            this.gbAcc.Controls.Add(this.lblAccZ);
            this.gbAcc.Controls.Add(this.lblAccY);
            this.gbAcc.Location = new System.Drawing.Point(287, 111);
            this.gbAcc.Name = "gbAcc";
            this.gbAcc.Size = new System.Drawing.Size(228, 114);
            this.gbAcc.TabIndex = 6;
            this.gbAcc.TabStop = false;
            this.gbAcc.Text = "Acceleration";
            // 
            // gbOmg
            // 
            this.gbOmg.Controls.Add(this.lblOmgX);
            this.gbOmg.Controls.Add(this.lblOmgZ);
            this.gbOmg.Controls.Add(this.lblOmgY);
            this.gbOmg.Location = new System.Drawing.Point(287, 231);
            this.gbOmg.Name = "gbOmg";
            this.gbOmg.Size = new System.Drawing.Size(228, 114);
            this.gbOmg.TabIndex = 7;
            this.gbOmg.TabStop = false;
            this.gbOmg.Text = "Angular rates";
            // 
            // lblOmgX
            // 
            this.lblOmgX.AutoSize = true;
            this.lblOmgX.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOmgX.Location = new System.Drawing.Point(6, 19);
            this.lblOmgX.Name = "lblOmgX";
            this.lblOmgX.Size = new System.Drawing.Size(148, 25);
            this.lblOmgX.TabIndex = 3;
            this.lblOmgX.Text = "OmgX = 0.00 °/s";
            // 
            // lblOmgZ
            // 
            this.lblOmgZ.AutoSize = true;
            this.lblOmgZ.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOmgZ.Location = new System.Drawing.Point(7, 76);
            this.lblOmgZ.Name = "lblOmgZ";
            this.lblOmgZ.Size = new System.Drawing.Size(148, 25);
            this.lblOmgZ.TabIndex = 5;
            this.lblOmgZ.Text = "OmgZ = 0.00 °/s";
            // 
            // lblOmgY
            // 
            this.lblOmgY.AutoSize = true;
            this.lblOmgY.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblOmgY.Location = new System.Drawing.Point(7, 45);
            this.lblOmgY.Name = "lblOmgY";
            this.lblOmgY.Size = new System.Drawing.Size(148, 25);
            this.lblOmgY.TabIndex = 4;
            this.lblOmgY.Text = "OmgY = 0.00 °/s";
            // 
            // lblTemperature
            // 
            this.lblTemperature.AutoSize = true;
            this.lblTemperature.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblTemperature.Location = new System.Drawing.Point(530, 149);
            this.lblTemperature.Name = "lblTemperature";
            this.lblTemperature.Size = new System.Drawing.Size(199, 25);
            this.lblTemperature.TabIndex = 8;
            this.lblTemperature.Text = "Temperature = 0.00 °C";
            // 
            // gbRPY
            // 
            this.gbRPY.Controls.Add(this.lblRoll);
            this.gbRPY.Controls.Add(this.lblYaw);
            this.gbRPY.Controls.Add(this.lblPitch);
            this.gbRPY.Location = new System.Drawing.Point(530, 231);
            this.gbRPY.Name = "gbRPY";
            this.gbRPY.Size = new System.Drawing.Size(228, 114);
            this.gbRPY.TabIndex = 7;
            this.gbRPY.TabStop = false;
            this.gbRPY.Text = "RPY";
            // 
            // lblRoll
            // 
            this.lblRoll.AutoSize = true;
            this.lblRoll.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblRoll.Location = new System.Drawing.Point(6, 19);
            this.lblRoll.Name = "lblRoll";
            this.lblRoll.Size = new System.Drawing.Size(112, 25);
            this.lblRoll.TabIndex = 3;
            this.lblRoll.Text = "Roll = 0.00 °";
            // 
            // lblYaw
            // 
            this.lblYaw.AutoSize = true;
            this.lblYaw.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblYaw.Location = new System.Drawing.Point(7, 76);
            this.lblYaw.Name = "lblYaw";
            this.lblYaw.Size = new System.Drawing.Size(114, 25);
            this.lblYaw.TabIndex = 5;
            this.lblYaw.Text = "Yaw = 0.00 °";
            // 
            // lblPitch
            // 
            this.lblPitch.AutoSize = true;
            this.lblPitch.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.lblPitch.Location = new System.Drawing.Point(7, 45);
            this.lblPitch.Name = "lblPitch";
            this.lblPitch.Size = new System.Drawing.Size(123, 25);
            this.lblPitch.TabIndex = 4;
            this.lblPitch.Text = "Pitch = 0.00 °";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.gbRPY);
            this.Controls.Add(this.lblTemperature);
            this.Controls.Add(this.gbOmg);
            this.Controls.Add(this.gbAcc);
            this.Controls.Add(this.lblFrameCounter);
            this.Controls.Add(this.btnConnect);
            this.Controls.Add(this.txtIP);
            this.Name = "Form1";
            this.Text = "Flightcontroller Client";
            this.gbAcc.ResumeLayout(false);
            this.gbAcc.PerformLayout();
            this.gbOmg.ResumeLayout(false);
            this.gbOmg.PerformLayout();
            this.gbRPY.ResumeLayout(false);
            this.gbRPY.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private TextBox txtIP;
        private Button btnConnect;
        private Label lblFrameCounter;
        private Label lblAccX;
        private Label lblAccY;
        private Label lblAccZ;
        private GroupBox gbAcc;
        private GroupBox gbOmg;
        private Label lblOmgX;
        private Label lblOmgZ;
        private Label lblOmgY;
        private Label lblTemperature;
        private GroupBox gbRPY;
        private Label lblRoll;
        private Label lblYaw;
        private Label lblPitch;
    }
}