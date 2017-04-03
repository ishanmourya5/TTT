namespace TTT
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
            this.peer_ip_textbox = new System.Windows.Forms.TextBox();
            this.connect_button = new System.Windows.Forms.Button();
            this.peer_port_textbox = new System.Windows.Forms.TextBox();
            this.my_port_textbox = new System.Windows.Forms.TextBox();
            this.my_ip_textbox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.b1 = new System.Windows.Forms.Button();
            this.b2 = new System.Windows.Forms.Button();
            this.b3 = new System.Windows.Forms.Button();
            this.b4 = new System.Windows.Forms.Button();
            this.b5 = new System.Windows.Forms.Button();
            this.b6 = new System.Windows.Forms.Button();
            this.b7 = new System.Windows.Forms.Button();
            this.b8 = new System.Windows.Forms.Button();
            this.b9 = new System.Windows.Forms.Button();
            this.label_turn = new System.Windows.Forms.Label();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.newGameToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.helpToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.aboutToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // peer_ip_textbox
            // 
            this.peer_ip_textbox.Location = new System.Drawing.Point(77, 95);
            this.peer_ip_textbox.Name = "peer_ip_textbox";
            this.peer_ip_textbox.Size = new System.Drawing.Size(125, 20);
            this.peer_ip_textbox.TabIndex = 2;
            // 
            // connect_button
            // 
            this.connect_button.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.connect_button.Location = new System.Drawing.Point(298, 68);
            this.connect_button.Name = "connect_button";
            this.connect_button.Size = new System.Drawing.Size(73, 46);
            this.connect_button.TabIndex = 3;
            this.connect_button.Text = "Connect";
            this.connect_button.UseVisualStyleBackColor = true;
            this.connect_button.Click += new System.EventHandler(this.connect_button_Click);
            // 
            // peer_port_textbox
            // 
            this.peer_port_textbox.Location = new System.Drawing.Point(208, 94);
            this.peer_port_textbox.Name = "peer_port_textbox";
            this.peer_port_textbox.Size = new System.Drawing.Size(68, 20);
            this.peer_port_textbox.TabIndex = 5;
            // 
            // my_port_textbox
            // 
            this.my_port_textbox.Location = new System.Drawing.Point(208, 68);
            this.my_port_textbox.Name = "my_port_textbox";
            this.my_port_textbox.Size = new System.Drawing.Size(68, 20);
            this.my_port_textbox.TabIndex = 6;
            // 
            // my_ip_textbox
            // 
            this.my_ip_textbox.Location = new System.Drawing.Point(77, 68);
            this.my_ip_textbox.Name = "my_ip_textbox";
            this.my_ip_textbox.Size = new System.Drawing.Size(125, 20);
            this.my_ip_textbox.TabIndex = 8;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(135, 52);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(19, 13);
            this.label2.TabIndex = 9;
            this.label2.Text = "IP";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(224, 52);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(30, 13);
            this.label3.TabIndex = 10;
            this.label3.Text = "Port";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(36, 71);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(32, 13);
            this.label4.TabIndex = 11;
            this.label4.Text = "Own";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(36, 98);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(33, 13);
            this.label5.TabIndex = 12;
            this.label5.Text = "Peer";
            // 
            // b1
            // 
            this.b1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b1.Location = new System.Drawing.Point(102, 177);
            this.b1.Name = "b1";
            this.b1.Size = new System.Drawing.Size(60, 60);
            this.b1.TabIndex = 13;
            this.b1.UseVisualStyleBackColor = true;
            this.b1.Click += new System.EventHandler(this.b1_Click);
            // 
            // b2
            // 
            this.b2.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b2.Location = new System.Drawing.Point(168, 177);
            this.b2.Name = "b2";
            this.b2.Size = new System.Drawing.Size(60, 60);
            this.b2.TabIndex = 13;
            this.b2.UseVisualStyleBackColor = true;
            this.b2.Click += new System.EventHandler(this.b1_Click);
            // 
            // b3
            // 
            this.b3.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b3.Location = new System.Drawing.Point(234, 177);
            this.b3.Name = "b3";
            this.b3.Size = new System.Drawing.Size(60, 60);
            this.b3.TabIndex = 13;
            this.b3.UseVisualStyleBackColor = true;
            this.b3.Click += new System.EventHandler(this.b1_Click);
            // 
            // b4
            // 
            this.b4.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b4.Location = new System.Drawing.Point(102, 243);
            this.b4.Name = "b4";
            this.b4.Size = new System.Drawing.Size(60, 60);
            this.b4.TabIndex = 13;
            this.b4.UseVisualStyleBackColor = true;
            this.b4.Click += new System.EventHandler(this.b1_Click);
            // 
            // b5
            // 
            this.b5.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b5.Location = new System.Drawing.Point(168, 243);
            this.b5.Name = "b5";
            this.b5.Size = new System.Drawing.Size(60, 60);
            this.b5.TabIndex = 13;
            this.b5.UseVisualStyleBackColor = true;
            this.b5.Click += new System.EventHandler(this.b1_Click);
            // 
            // b6
            // 
            this.b6.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b6.Location = new System.Drawing.Point(234, 243);
            this.b6.Name = "b6";
            this.b6.Size = new System.Drawing.Size(60, 60);
            this.b6.TabIndex = 13;
            this.b6.UseVisualStyleBackColor = true;
            this.b6.Click += new System.EventHandler(this.b1_Click);
            // 
            // b7
            // 
            this.b7.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b7.Location = new System.Drawing.Point(102, 309);
            this.b7.Name = "b7";
            this.b7.Size = new System.Drawing.Size(60, 60);
            this.b7.TabIndex = 13;
            this.b7.UseVisualStyleBackColor = true;
            this.b7.Click += new System.EventHandler(this.b1_Click);
            // 
            // b8
            // 
            this.b8.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b8.Location = new System.Drawing.Point(168, 309);
            this.b8.Name = "b8";
            this.b8.Size = new System.Drawing.Size(60, 60);
            this.b8.TabIndex = 13;
            this.b8.UseVisualStyleBackColor = true;
            this.b8.Click += new System.EventHandler(this.b1_Click);
            // 
            // b9
            // 
            this.b9.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.b9.Location = new System.Drawing.Point(234, 309);
            this.b9.Name = "b9";
            this.b9.Size = new System.Drawing.Size(60, 60);
            this.b9.TabIndex = 13;
            this.b9.UseVisualStyleBackColor = true;
            this.b9.Click += new System.EventHandler(this.b1_Click);
            // 
            // label_turn
            // 
            this.label_turn.AutoSize = true;
            this.label_turn.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.5F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label_turn.Location = new System.Drawing.Point(202, 147);
            this.label_turn.Name = "label_turn";
            this.label_turn.Size = new System.Drawing.Size(0, 15);
            this.label_turn.TabIndex = 15;
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(407, 24);
            this.menuStrip1.TabIndex = 16;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.newGameToolStripMenuItem,
            this.helpToolStripMenuItem,
            this.aboutToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(37, 20);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // newGameToolStripMenuItem
            // 
            this.newGameToolStripMenuItem.Name = "newGameToolStripMenuItem";
            this.newGameToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.newGameToolStripMenuItem.Text = "New Game";
            this.newGameToolStripMenuItem.Click += new System.EventHandler(this.newGameToolStripMenuItem_Click);
            // 
            // helpToolStripMenuItem
            // 
            this.helpToolStripMenuItem.Name = "helpToolStripMenuItem";
            this.helpToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.helpToolStripMenuItem.Text = "Help";
            this.helpToolStripMenuItem.Click += new System.EventHandler(this.helpToolStripMenuItem_Click);
            // 
            // aboutToolStripMenuItem
            // 
            this.aboutToolStripMenuItem.Name = "aboutToolStripMenuItem";
            this.aboutToolStripMenuItem.Size = new System.Drawing.Size(152, 22);
            this.aboutToolStripMenuItem.Text = "About ";
            this.aboutToolStripMenuItem.Click += new System.EventHandler(this.aboutToolStripMenuItem_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(407, 410);
            this.Controls.Add(this.label_turn);
            this.Controls.Add(this.b9);
            this.Controls.Add(this.b8);
            this.Controls.Add(this.b7);
            this.Controls.Add(this.b6);
            this.Controls.Add(this.b5);
            this.Controls.Add(this.b4);
            this.Controls.Add(this.b3);
            this.Controls.Add(this.b2);
            this.Controls.Add(this.b1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.my_ip_textbox);
            this.Controls.Add(this.my_port_textbox);
            this.Controls.Add(this.peer_port_textbox);
            this.Controls.Add(this.connect_button);
            this.Controls.Add(this.peer_ip_textbox);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox peer_ip_textbox;
        private System.Windows.Forms.Button connect_button;
        private System.Windows.Forms.TextBox peer_port_textbox;
        private System.Windows.Forms.TextBox my_port_textbox;
        private System.Windows.Forms.TextBox my_ip_textbox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Button b1;
        private System.Windows.Forms.Button b2;
        private System.Windows.Forms.Button b3;
        private System.Windows.Forms.Button b4;
        private System.Windows.Forms.Button b5;
        private System.Windows.Forms.Button b6;
        private System.Windows.Forms.Button b7;
        private System.Windows.Forms.Button b8;
        private System.Windows.Forms.Button b9;
        private System.Windows.Forms.Label label_turn;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem newGameToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem helpToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem aboutToolStripMenuItem;
    }
}

