namespace forms
{
    partial class addUser
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
            this.priezviskotextBox = new System.Windows.Forms.TextBox();
            this.menotextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.okB = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.generL = new System.Windows.Forms.Label();
            this.generB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // priezviskotextBox
            // 
            this.priezviskotextBox.Location = new System.Drawing.Point(149, 134);
            this.priezviskotextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.priezviskotextBox.Name = "priezviskotextBox";
            this.priezviskotextBox.Size = new System.Drawing.Size(369, 22);
            this.priezviskotextBox.TabIndex = 33;
            // 
            // menotextBox
            // 
            this.menotextBox.Location = new System.Drawing.Point(149, 102);
            this.menotextBox.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.menotextBox.Name = "menotextBox";
            this.menotextBox.Size = new System.Drawing.Size(369, 22);
            this.menotextBox.TabIndex = 32;
            this.menotextBox.TextChanged += new System.EventHandler(this.menotextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(29, 202);
            this.label5.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 17);
            this.label5.TabIndex = 30;
            this.label5.Text = "praceschopnosť";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(68, 170);
            this.label4.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(73, 17);
            this.label4.TabIndex = 29;
            this.label4.Text = "id_oddielu";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(69, 138);
            this.label3.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(71, 17);
            this.label3.TabIndex = 28;
            this.label3.Text = "priezvisko";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(97, 106);
            this.label2.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(43, 17);
            this.label2.TabIndex = 27;
            this.label2.Text = "meno";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(112, 62);
            this.label1.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(27, 17);
            this.label1.TabIndex = 26;
            this.label1.Text = "pid";
            // 
            // okB
            // 
            this.okB.Location = new System.Drawing.Point(149, 263);
            this.okB.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.okB.Name = "okB";
            this.okB.Size = new System.Drawing.Size(371, 79);
            this.okB.TabIndex = 24;
            this.okB.Text = "ok";
            this.okB.UseVisualStyleBackColor = true;
            this.okB.Click += new System.EventHandler(this.okB_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(149, 165);
            this.comboBox1.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(369, 24);
            this.comboBox1.TabIndex = 36;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Items.AddRange(new object[] {
            "aktivny",
            "pn",
            "dovolenka"});
            this.comboBox2.Location = new System.Drawing.Point(149, 198);
            this.comboBox2.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(369, 24);
            this.comboBox2.TabIndex = 37;
            this.comboBox2.SelectedIndexChanged += new System.EventHandler(this.comboBox2_SelectedIndexChanged);
            // 
            // generL
            // 
            this.generL.AutoSize = true;
            this.generL.Location = new System.Drawing.Point(172, 62);
            this.generL.Name = "generL";
            this.generL.Size = new System.Drawing.Size(13, 17);
            this.generL.TabIndex = 38;
            this.generL.Text = "-";
            this.generL.Click += new System.EventHandler(this.generL_Click);
            // 
            // generB
            // 
            this.generB.Location = new System.Drawing.Point(255, 62);
            this.generB.Name = "generB";
            this.generB.Size = new System.Drawing.Size(263, 23);
            this.generB.TabIndex = 39;
            this.generB.Text = "generovať";
            this.generB.UseVisualStyleBackColor = true;
            this.generB.Click += new System.EventHandler(this.generB_Click);
            // 
            // addUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(579, 388);
            this.Controls.Add(this.generB);
            this.Controls.Add(this.generL);
            this.Controls.Add(this.comboBox2);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.priezviskotextBox);
            this.Controls.Add(this.menotextBox);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.okB);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "addUser";
            this.Text = "addUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox priezviskotextBox;
        private System.Windows.Forms.TextBox menotextBox;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button okB;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Label generL;
        private System.Windows.Forms.Button generB;
    }
}