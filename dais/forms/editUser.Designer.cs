namespace forms
{
    partial class editUser
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
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.priezviskotextBox = new System.Windows.Forms.TextBox();
            this.menotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.editB = new System.Windows.Forms.Button();
            this.generL = new System.Windows.Forms.Label();
            this.praceschopnostCB = new System.Windows.Forms.ComboBox();
            this.oddielCB = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(167, 32);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(160, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(45, 32);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(84, 17);
            this.label1.TabIndex = 25;
            this.label1.Text = "zamestanec";
            // 
            // priezviskotextBox
            // 
            this.priezviskotextBox.Location = new System.Drawing.Point(167, 181);
            this.priezviskotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.priezviskotextBox.Name = "priezviskotextBox";
            this.priezviskotextBox.Size = new System.Drawing.Size(369, 22);
            this.priezviskotextBox.TabIndex = 45;
            // 
            // menotextBox
            // 
            this.menotextBox.Location = new System.Drawing.Point(167, 149);
            this.menotextBox.Margin = new System.Windows.Forms.Padding(4);
            this.menotextBox.Name = "menotextBox";
            this.menotextBox.Size = new System.Drawing.Size(369, 22);
            this.menotextBox.TabIndex = 44;
            this.menotextBox.TextChanged += new System.EventHandler(this.menotextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(47, 249);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 42;
            this.label5.Text = "praceschopnosť";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(85, 217);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 41;
            this.label4.Text = "id_oddielu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(87, 185);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 40;
            this.label3.Text = "priezvisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(115, 153);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 39;
            this.label2.Text = "meno";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(131, 110);
            this.label6.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(27, 17);
            this.label6.TabIndex = 38;
            this.label6.Text = "pid";
            // 
            // editB
            // 
            this.editB.Location = new System.Drawing.Point(167, 300);
            this.editB.Margin = new System.Windows.Forms.Padding(4);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(371, 95);
            this.editB.TabIndex = 48;
            this.editB.Text = "Upraviť";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.editB_Click);
            // 
            // generL
            // 
            this.generL.AutoSize = true;
            this.generL.Location = new System.Drawing.Point(177, 107);
            this.generL.Name = "generL";
            this.generL.Size = new System.Drawing.Size(13, 17);
            this.generL.TabIndex = 51;
            this.generL.Text = "-";
            // 
            // praceschopnostCB
            // 
            this.praceschopnostCB.FormattingEnabled = true;
            this.praceschopnostCB.Items.AddRange(new object[] {
            "aktivny",
            "pn",
            "dovolenka"});
            this.praceschopnostCB.Location = new System.Drawing.Point(166, 243);
            this.praceschopnostCB.Margin = new System.Windows.Forms.Padding(4);
            this.praceschopnostCB.Name = "praceschopnostCB";
            this.praceschopnostCB.Size = new System.Drawing.Size(369, 24);
            this.praceschopnostCB.TabIndex = 53;
            this.praceschopnostCB.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // oddielCB
            // 
            this.oddielCB.FormattingEnabled = true;
            this.oddielCB.Location = new System.Drawing.Point(166, 210);
            this.oddielCB.Margin = new System.Windows.Forms.Padding(4);
            this.oddielCB.Name = "oddielCB";
            this.oddielCB.Size = new System.Drawing.Size(369, 24);
            this.oddielCB.TabIndex = 52;
            this.oddielCB.SelectedIndexChanged += new System.EventHandler(this.oddielCB_SelectedIndexChanged);
            // 
            // editUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(651, 474);
            this.Controls.Add(this.praceschopnostCB);
            this.Controls.Add(this.oddielCB);
            this.Controls.Add(this.generL);
            this.Controls.Add(this.editB);
            this.Controls.Add(this.priezviskotextBox);
            this.Controls.Add(this.menotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "editUser";
            this.Text = "editUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox priezviskotextBox;
        private System.Windows.Forms.TextBox menotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Label generL;
        private System.Windows.Forms.ComboBox praceschopnostCB;
        private System.Windows.Forms.ComboBox oddielCB;
    }
}