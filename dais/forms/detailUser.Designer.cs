namespace forms
{
    partial class detailUser
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
            this.pidL = new System.Windows.Forms.Label();
            this.menoL = new System.Windows.Forms.Label();
            this.priezviskoL = new System.Windows.Forms.Label();
            this.id_oddieluL = new System.Windows.Forms.Label();
            this.praceschopnostL = new System.Windows.Forms.Label();
            this.pidData = new System.Windows.Forms.Label();
            this.menoData = new System.Windows.Forms.Label();
            this.priezviskoData = new System.Windows.Forms.Label();
            this.id_oddieluData = new System.Windows.Forms.Label();
            this.praceschopnostData = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.label2 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // comboBox1
            // 
            this.comboBox1.Location = new System.Drawing.Point(145, 28);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(315, 21);
            this.comboBox1.TabIndex = 24;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(54, 28);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(64, 13);
            this.label1.TabIndex = 9;
            this.label1.Text = "zamestanec";
            // 
            // pidL
            // 
            this.pidL.AutoSize = true;
            this.pidL.Location = new System.Drawing.Point(54, 95);
            this.pidL.Name = "pidL";
            this.pidL.Size = new System.Drawing.Size(21, 13);
            this.pidL.TabIndex = 13;
            this.pidL.Text = "pid";
            this.pidL.Click += new System.EventHandler(this.label2_Click);
            // 
            // menoL
            // 
            this.menoL.AutoSize = true;
            this.menoL.Location = new System.Drawing.Point(54, 131);
            this.menoL.Name = "menoL";
            this.menoL.Size = new System.Drawing.Size(33, 13);
            this.menoL.TabIndex = 14;
            this.menoL.Text = "meno";
            // 
            // priezviskoL
            // 
            this.priezviskoL.AutoSize = true;
            this.priezviskoL.Location = new System.Drawing.Point(54, 167);
            this.priezviskoL.Name = "priezviskoL";
            this.priezviskoL.Size = new System.Drawing.Size(54, 13);
            this.priezviskoL.TabIndex = 15;
            this.priezviskoL.Text = "priezvisko";
            // 
            // id_oddieluL
            // 
            this.id_oddieluL.AutoSize = true;
            this.id_oddieluL.Location = new System.Drawing.Point(313, 95);
            this.id_oddieluL.Name = "id_oddieluL";
            this.id_oddieluL.Size = new System.Drawing.Size(52, 13);
            this.id_oddieluL.TabIndex = 16;
            this.id_oddieluL.Text = "id oddielu";
            // 
            // praceschopnostL
            // 
            this.praceschopnostL.AutoSize = true;
            this.praceschopnostL.Location = new System.Drawing.Point(313, 131);
            this.praceschopnostL.Name = "praceschopnostL";
            this.praceschopnostL.Size = new System.Drawing.Size(83, 13);
            this.praceschopnostL.TabIndex = 17;
            this.praceschopnostL.Text = "praceschopnost";
            // 
            // pidData
            // 
            this.pidData.AutoSize = true;
            this.pidData.Location = new System.Drawing.Point(131, 95);
            this.pidData.Name = "pidData";
            this.pidData.Size = new System.Drawing.Size(10, 13);
            this.pidData.TabIndex = 18;
            this.pidData.Text = "-";
            // 
            // menoData
            // 
            this.menoData.AutoSize = true;
            this.menoData.Location = new System.Drawing.Point(131, 131);
            this.menoData.Name = "menoData";
            this.menoData.Size = new System.Drawing.Size(10, 13);
            this.menoData.TabIndex = 19;
            this.menoData.Text = "-";
            // 
            // priezviskoData
            // 
            this.priezviskoData.AutoSize = true;
            this.priezviskoData.Location = new System.Drawing.Point(131, 167);
            this.priezviskoData.Name = "priezviskoData";
            this.priezviskoData.Size = new System.Drawing.Size(10, 13);
            this.priezviskoData.TabIndex = 20;
            this.priezviskoData.Text = "-";
            // 
            // id_oddieluData
            // 
            this.id_oddieluData.AutoSize = true;
            this.id_oddieluData.Location = new System.Drawing.Point(450, 95);
            this.id_oddieluData.Name = "id_oddieluData";
            this.id_oddieluData.Size = new System.Drawing.Size(10, 13);
            this.id_oddieluData.TabIndex = 21;
            this.id_oddieluData.Text = "-";
            // 
            // praceschopnostData
            // 
            this.praceschopnostData.AutoSize = true;
            this.praceschopnostData.Location = new System.Drawing.Point(450, 131);
            this.praceschopnostData.Name = "praceschopnostData";
            this.praceschopnostData.Size = new System.Drawing.Size(10, 13);
            this.praceschopnostData.TabIndex = 22;
            this.praceschopnostData.Text = "-";
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(34, 228);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(998, 192);
            this.listView1.TabIndex = 23;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.Location = new System.Drawing.Point(31, 202);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(157, 13);
            this.label2.TabIndex = 25;
            this.label2.Text = "Zoznam pracovných smien";
            // 
            // detailUser
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1044, 450);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.praceschopnostData);
            this.Controls.Add(this.id_oddieluData);
            this.Controls.Add(this.priezviskoData);
            this.Controls.Add(this.menoData);
            this.Controls.Add(this.pidData);
            this.Controls.Add(this.praceschopnostL);
            this.Controls.Add(this.id_oddieluL);
            this.Controls.Add(this.priezviskoL);
            this.Controls.Add(this.menoL);
            this.Controls.Add(this.pidL);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label1);
            this.Name = "detailUser";
            this.Text = "detailUser";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label pidL;
        private System.Windows.Forms.Label menoL;
        private System.Windows.Forms.Label priezviskoL;
        private System.Windows.Forms.Label id_oddieluL;
        private System.Windows.Forms.Label praceschopnostL;
        private System.Windows.Forms.Label pidData;
        private System.Windows.Forms.Label menoData;
        private System.Windows.Forms.Label priezviskoData;
        private System.Windows.Forms.Label id_oddieluData;
        private System.Windows.Forms.Label praceschopnostData;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Label label2;
    }
}