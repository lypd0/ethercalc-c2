namespace ethercalc_c2_control
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.sheetIdBox = new System.Windows.Forms.TextBox();
            this.confirmBtn = new System.Windows.Forms.Button();
            this.editBtn = new System.Windows.Forms.Button();
            this.sheetNumBox = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.commandsOutBox = new System.Windows.Forms.RichTextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.groupBox3 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.editBtn2 = new System.Windows.Forms.Button();
            this.confirmBtn2 = new System.Windows.Forms.Button();
            this.encryptionKeyBox = new System.Windows.Forms.TextBox();
            this.confirmationLabel1 = new System.Windows.Forms.Label();
            this.confirmationLabel2 = new System.Windows.Forms.Label();
            this.commandText = new System.Windows.Forms.Label();
            this.commandBox = new System.Windows.Forms.TextBox();
            this.useEncryptionCheckbox = new System.Windows.Forms.CheckBox();
            this.Polling = new System.Windows.Forms.Timer(this.components);
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox3.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.confirmationLabel1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.sheetNumBox);
            this.groupBox1.Controls.Add(this.editBtn);
            this.groupBox1.Controls.Add(this.confirmBtn);
            this.groupBox1.Controls.Add(this.sheetIdBox);
            this.groupBox1.Location = new System.Drawing.Point(12, 8);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(235, 112);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Ethercalc Settings";
            // 
            // sheetIdBox
            // 
            this.sheetIdBox.Location = new System.Drawing.Point(16, 41);
            this.sheetIdBox.Name = "sheetIdBox";
            this.sheetIdBox.Size = new System.Drawing.Size(155, 20);
            this.sheetIdBox.TabIndex = 2;
            // 
            // confirmBtn
            // 
            this.confirmBtn.Location = new System.Drawing.Point(16, 67);
            this.confirmBtn.Name = "confirmBtn";
            this.confirmBtn.Size = new System.Drawing.Size(100, 23);
            this.confirmBtn.TabIndex = 123;
            this.confirmBtn.Text = "Confirm";
            this.confirmBtn.UseVisualStyleBackColor = true;
            this.confirmBtn.Click += new System.EventHandler(this.button1_Click);
            // 
            // editBtn
            // 
            this.editBtn.Enabled = false;
            this.editBtn.Location = new System.Drawing.Point(117, 67);
            this.editBtn.Name = "editBtn";
            this.editBtn.Size = new System.Drawing.Size(100, 23);
            this.editBtn.TabIndex = 2234;
            this.editBtn.Text = "Edit";
            this.editBtn.UseVisualStyleBackColor = true;
            this.editBtn.Click += new System.EventHandler(this.editBtn_Click);
            // 
            // sheetNumBox
            // 
            this.sheetNumBox.Location = new System.Drawing.Point(177, 41);
            this.sheetNumBox.Name = "sheetNumBox";
            this.sheetNumBox.Size = new System.Drawing.Size(40, 20);
            this.sheetNumBox.TabIndex = 3234;
            this.sheetNumBox.Text = "1";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Consolas", 7F);
            this.label1.Location = new System.Drawing.Point(15, 27);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(45, 12);
            this.label1.TabIndex = 2;
            this.label1.Text = "Sheet ID";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Consolas", 7F);
            this.label2.Location = new System.Drawing.Point(176, 27);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 12);
            this.label2.TabIndex = 4;
            this.label2.Text = "Sheet #";
            // 
            // commandsOutBox
            // 
            this.commandsOutBox.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandsOutBox.BackColor = System.Drawing.Color.White;
            this.commandsOutBox.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.commandsOutBox.Font = new System.Drawing.Font("Consolas", 7F);
            this.commandsOutBox.Location = new System.Drawing.Point(16, 25);
            this.commandsOutBox.Name = "commandsOutBox";
            this.commandsOutBox.ReadOnly = true;
            this.commandsOutBox.Size = new System.Drawing.Size(434, 304);
            this.commandsOutBox.TabIndex = 2;
            this.commandsOutBox.Text = "";
            // 
            // groupBox2
            // 
            this.groupBox2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.groupBox2.Controls.Add(this.commandText);
            this.groupBox2.Controls.Add(this.commandBox);
            this.groupBox2.Controls.Add(this.commandsOutBox);
            this.groupBox2.Location = new System.Drawing.Point(253, 8);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(467, 393);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Commands";
            // 
            // groupBox3
            // 
            this.groupBox3.Controls.Add(this.useEncryptionCheckbox);
            this.groupBox3.Controls.Add(this.confirmationLabel2);
            this.groupBox3.Controls.Add(this.label4);
            this.groupBox3.Controls.Add(this.editBtn2);
            this.groupBox3.Controls.Add(this.confirmBtn2);
            this.groupBox3.Controls.Add(this.encryptionKeyBox);
            this.groupBox3.Location = new System.Drawing.Point(12, 126);
            this.groupBox3.Name = "groupBox3";
            this.groupBox3.Size = new System.Drawing.Size(235, 143);
            this.groupBox3.TabIndex = 4;
            this.groupBox3.TabStop = false;
            this.groupBox3.Text = "Agent Settings";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Consolas", 7F);
            this.label4.Location = new System.Drawing.Point(15, 27);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(75, 12);
            this.label4.TabIndex = 2;
            this.label4.Text = "Encryption Key";
            // 
            // editBtn2
            // 
            this.editBtn2.Enabled = false;
            this.editBtn2.Location = new System.Drawing.Point(117, 103);
            this.editBtn2.Name = "editBtn2";
            this.editBtn2.Size = new System.Drawing.Size(100, 23);
            this.editBtn2.TabIndex = 23544;
            this.editBtn2.Text = "Edit";
            this.editBtn2.UseVisualStyleBackColor = true;
            this.editBtn2.Click += new System.EventHandler(this.editBtn2_Click);
            // 
            // confirmBtn2
            // 
            this.confirmBtn2.Location = new System.Drawing.Point(16, 103);
            this.confirmBtn2.Name = "confirmBtn2";
            this.confirmBtn2.Size = new System.Drawing.Size(100, 23);
            this.confirmBtn2.TabIndex = 2552;
            this.confirmBtn2.Text = "Confirm";
            this.confirmBtn2.UseVisualStyleBackColor = true;
            this.confirmBtn2.Click += new System.EventHandler(this.confirmBtn2_Click);
            // 
            // encryptionKeyBox
            // 
            this.encryptionKeyBox.Location = new System.Drawing.Point(16, 41);
            this.encryptionKeyBox.Name = "encryptionKeyBox";
            this.encryptionKeyBox.Size = new System.Drawing.Size(200, 20);
            this.encryptionKeyBox.TabIndex = 23434;
            // 
            // confirmationLabel1
            // 
            this.confirmationLabel1.AutoSize = true;
            this.confirmationLabel1.Font = new System.Drawing.Font("Consolas", 7F);
            this.confirmationLabel1.ForeColor = System.Drawing.Color.DarkOrange;
            this.confirmationLabel1.Location = new System.Drawing.Point(178, 1);
            this.confirmationLabel1.Name = "confirmationLabel1";
            this.confirmationLabel1.Size = new System.Drawing.Size(60, 12);
            this.confirmationLabel1.TabIndex = 5;
            this.confirmationLabel1.Text = "UNCONFIRMED";
            // 
            // confirmationLabel2
            // 
            this.confirmationLabel2.AutoSize = true;
            this.confirmationLabel2.Font = new System.Drawing.Font("Consolas", 7F);
            this.confirmationLabel2.ForeColor = System.Drawing.Color.DarkOrange;
            this.confirmationLabel2.Location = new System.Drawing.Point(177, 0);
            this.confirmationLabel2.Name = "confirmationLabel2";
            this.confirmationLabel2.Size = new System.Drawing.Size(60, 12);
            this.confirmationLabel2.TabIndex = 6;
            this.confirmationLabel2.Text = "UNCONFIRMED";
            // 
            // commandText
            // 
            this.commandText.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.commandText.AutoSize = true;
            this.commandText.Font = new System.Drawing.Font("Consolas", 7F);
            this.commandText.Location = new System.Drawing.Point(15, 340);
            this.commandText.Name = "commandText";
            this.commandText.Size = new System.Drawing.Size(250, 12);
            this.commandText.TabIndex = 4;
            this.commandText.Text = "Please confirm settings before executing commands";
            // 
            // commandBox
            // 
            this.commandBox.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.commandBox.Enabled = false;
            this.commandBox.Location = new System.Drawing.Point(16, 354);
            this.commandBox.Name = "commandBox";
            this.commandBox.Size = new System.Drawing.Size(434, 20);
            this.commandBox.TabIndex = 1;
            this.commandBox.Enter += new System.EventHandler(this.commandBox_Enter);
            this.commandBox.KeyDown += new System.Windows.Forms.KeyEventHandler(this.commandBox_KeyDown);
            // 
            // useEncryptionCheckbox
            // 
            this.useEncryptionCheckbox.AutoSize = true;
            this.useEncryptionCheckbox.Checked = true;
            this.useEncryptionCheckbox.CheckState = System.Windows.Forms.CheckState.Checked;
            this.useEncryptionCheckbox.Location = new System.Drawing.Point(17, 67);
            this.useEncryptionCheckbox.Name = "useEncryptionCheckbox";
            this.useEncryptionCheckbox.Size = new System.Drawing.Size(110, 17);
            this.useEncryptionCheckbox.TabIndex = 323345;
            this.useEncryptionCheckbox.Text = "Use Encryption";
            this.useEncryptionCheckbox.UseVisualStyleBackColor = true;
            // 
            // Polling
            // 
            this.Polling.Enabled = true;
            this.Polling.Interval = 10000;
            this.Polling.Tick += new System.EventHandler(this.Polling_Tick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.label3.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.label3.Location = new System.Drawing.Point(64, 289);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(119, 15);
            this.label3.TabIndex = 5;
            this.label3.Text = "github.com/lypd0";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Consolas", 9.25F);
            this.label5.Location = new System.Drawing.Point(32, 304);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(182, 15);
            this.label5.TabIndex = 6;
            this.label5.Text = "Educational Purposes Only";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(733, 414);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.groupBox3);
            this.Controls.Add(this.groupBox2);
            this.Controls.Add(this.groupBox1);
            this.Font = new System.Drawing.Font("Consolas", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Name = "Form1";
            this.Text = "Ethercalc C2 | Control";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox3.ResumeLayout(false);
            this.groupBox3.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Button editBtn;
        private System.Windows.Forms.Button confirmBtn;
        private System.Windows.Forms.TextBox sheetIdBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox sheetNumBox;
        private System.Windows.Forms.RichTextBox commandsOutBox;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.GroupBox groupBox3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button editBtn2;
        private System.Windows.Forms.Button confirmBtn2;
        private System.Windows.Forms.TextBox encryptionKeyBox;
        private System.Windows.Forms.Label confirmationLabel1;
        private System.Windows.Forms.Label confirmationLabel2;
        private System.Windows.Forms.Label commandText;
        private System.Windows.Forms.TextBox commandBox;
        private System.Windows.Forms.CheckBox useEncryptionCheckbox;
        private System.Windows.Forms.Timer Polling;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label5;
    }
}

