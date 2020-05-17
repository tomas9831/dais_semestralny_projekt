namespace forms
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
            this.detailB = new System.Windows.Forms.Button();
            this.removeB = new System.Windows.Forms.Button();
            this.editB = new System.Windows.Forms.Button();
            this.pridatB = new System.Windows.Forms.Button();
            this.listView1 = new System.Windows.Forms.ListView();
            this.refreshB = new System.Windows.Forms.Button();
            this.letB = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // detailB
            // 
            this.detailB.Location = new System.Drawing.Point(21, 307);
            this.detailB.Name = "detailB";
            this.detailB.Size = new System.Drawing.Size(170, 59);
            this.detailB.TabIndex = 8;
            this.detailB.Text = "detail";
            this.detailB.UseVisualStyleBackColor = true;
            this.detailB.Click += new System.EventHandler(this.detailB_Click);
            // 
            // removeB
            // 
            this.removeB.Location = new System.Drawing.Point(21, 228);
            this.removeB.Name = "removeB";
            this.removeB.Size = new System.Drawing.Size(170, 57);
            this.removeB.TabIndex = 7;
            this.removeB.Text = "odobrať";
            this.removeB.UseVisualStyleBackColor = true;
            this.removeB.Click += new System.EventHandler(this.removeB_Click);
            // 
            // editB
            // 
            this.editB.Location = new System.Drawing.Point(21, 150);
            this.editB.Name = "editB";
            this.editB.Size = new System.Drawing.Size(170, 56);
            this.editB.TabIndex = 6;
            this.editB.Text = "upraviť";
            this.editB.UseVisualStyleBackColor = true;
            this.editB.Click += new System.EventHandler(this.editB_Click);
            // 
            // pridatB
            // 
            this.pridatB.Location = new System.Drawing.Point(21, 74);
            this.pridatB.Name = "pridatB";
            this.pridatB.Size = new System.Drawing.Size(170, 61);
            this.pridatB.TabIndex = 5;
            this.pridatB.Text = "pridať";
            this.pridatB.UseVisualStyleBackColor = true;
            this.pridatB.Click += new System.EventHandler(this.pridatB_Click);
            // 
            // listView1
            // 
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(276, 74);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(738, 292);
            this.listView1.TabIndex = 10;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.listView1_SelectedIndexChanged);
            // 
            // refreshB
            // 
            this.refreshB.Location = new System.Drawing.Point(276, 379);
            this.refreshB.Name = "refreshB";
            this.refreshB.Size = new System.Drawing.Size(738, 66);
            this.refreshB.TabIndex = 11;
            this.refreshB.Text = "znova načítaj dáta";
            this.refreshB.UseVisualStyleBackColor = true;
            this.refreshB.Click += new System.EventHandler(this.refreshB_Click);
            // 
            // letB
            // 
            this.letB.Location = new System.Drawing.Point(21, 379);
            this.letB.Name = "letB";
            this.letB.Size = new System.Drawing.Size(170, 59);
            this.letB.TabIndex = 12;
            this.letB.Text = "zoznam zamestnancov na lete";
            this.letB.UseVisualStyleBackColor = true;
            this.letB.Click += new System.EventHandler(this.letB_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1091, 486);
            this.Controls.Add(this.letB);
            this.Controls.Add(this.refreshB);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.detailB);
            this.Controls.Add(this.removeB);
            this.Controls.Add(this.editB);
            this.Controls.Add(this.pridatB);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button detailB;
        private System.Windows.Forms.Button removeB;
        private System.Windows.Forms.Button editB;
        private System.Windows.Forms.Button pridatB;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.Button refreshB;
        private System.Windows.Forms.Button letB;
    }
}

