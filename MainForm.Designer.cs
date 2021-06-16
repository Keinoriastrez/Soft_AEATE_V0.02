
namespace Soft_AEATE
{
    partial class MainForm
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.main = new System.Windows.Forms.ToolStripMenuItem();
            this.purchases = new System.Windows.Forms.ToolStripMenuItem();
            this.sales = new System.Windows.Forms.ToolStripMenuItem();
            this.company = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.salaryStrip = new System.Windows.Forms.ToolStripMenuItem();
            this.employeeAdd = new System.Windows.Forms.ToolStripMenuItem();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.toolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem2 = new System.Windows.Forms.ToolStripMenuItem();
            this.toolStripMenuItem3 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.menuStrip1.BackgroundImage = global::Soft_AEATE.Properties.Resources._5259fc8c2c6f7;
            this.menuStrip1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.main,
            this.purchases,
            this.sales,
            this.company});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(625, 29);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // main
            // 
            this.main.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.main.Checked = true;
            this.main.CheckState = System.Windows.Forms.CheckState.Checked;
            this.main.Name = "main";
            this.main.Size = new System.Drawing.Size(66, 25);
            this.main.Text = "Меню";
            this.main.Click += new System.EventHandler(this.Main_Click);
            // 
            // purchases
            // 
            this.purchases.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.purchases.Name = "purchases";
            this.purchases.Size = new System.Drawing.Size(81, 25);
            this.purchases.Text = "Закупки";
            this.purchases.TextAlign = System.Drawing.ContentAlignment.MiddleRight;
            this.purchases.Click += new System.EventHandler(this.Purchases_Click);
            // 
            // sales
            // 
            this.sales.BackColor = System.Drawing.SystemColors.HighlightText;
            this.sales.Name = "sales";
            this.sales.Size = new System.Drawing.Size(84, 25);
            this.sales.Text = "Продажі";
            this.sales.Click += new System.EventHandler(this.Sales_Click);
            // 
            // company
            // 
            this.company.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.company.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.employeeStrip,
            this.salaryStrip,
            this.employeeAdd});
            this.company.Name = "company";
            this.company.Size = new System.Drawing.Size(122, 25);
            this.company.Text = "Підприємство";
            this.company.Click += new System.EventHandler(this.Company_Click);
            // 
            // employeeStrip
            // 
            this.employeeStrip.Name = "employeeStrip";
            this.employeeStrip.Size = new System.Drawing.Size(226, 26);
            this.employeeStrip.Text = "Робочі";
            this.employeeStrip.Click += new System.EventHandler(this.EmployeeStrip_Click);
            // 
            // salaryStrip
            // 
            this.salaryStrip.Name = "salaryStrip";
            this.salaryStrip.Size = new System.Drawing.Size(226, 26);
            this.salaryStrip.Text = "Виплати";
            this.salaryStrip.Click += new System.EventHandler(this.SalaryStrip_Click);
            // 
            // employeeAdd
            // 
            this.employeeAdd.Name = "employeeAdd";
            this.employeeAdd.Size = new System.Drawing.Size(226, 26);
            this.employeeAdd.Text = "Добавити робітника";
            this.employeeAdd.Click += new System.EventHandler(this.ButtonAdd_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.AllCells;
            this.dataGridView1.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dataGridView1.BackgroundColor = System.Drawing.SystemColors.InfoText;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 108);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(573, 255);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.Visible = false;
            // 
            // toolStripMenuItem1
            // 
            this.toolStripMenuItem1.Name = "toolStripMenuItem1";
            this.toolStripMenuItem1.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem1.Text = "toolStripMenuItem1";
            // 
            // toolStripMenuItem2
            // 
            this.toolStripMenuItem2.Name = "toolStripMenuItem2";
            this.toolStripMenuItem2.Size = new System.Drawing.Size(180, 22);
            this.toolStripMenuItem2.Text = "toolStripMenuItem2";
            // 
            // toolStripMenuItem3
            // 
            this.toolStripMenuItem3.Name = "toolStripMenuItem3";
            this.toolStripMenuItem3.Size = new System.Drawing.Size(32, 19);
            this.toolStripMenuItem3.Text = "toolStripMenuItem3";
            // 
            // MainForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::Soft_AEATE.Properties.Resources._5259fc8c2c6f7;
            this.ClientSize = new System.Drawing.Size(625, 454);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.menuStrip1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "MainForm";
            this.Text = "AEATE";
            this.Load += new System.EventHandler(this.MainForm_Load);
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem purchases;
        private System.Windows.Forms.ToolStripMenuItem sales;
        private System.Windows.Forms.ToolStripMenuItem company;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.ToolStripMenuItem main;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem2;
        private System.Windows.Forms.ToolStripMenuItem toolStripMenuItem3;
        private System.Windows.Forms.ToolStripMenuItem employeeStrip;
        private System.Windows.Forms.ToolStripMenuItem salaryStrip;
        private System.Windows.Forms.ToolStripMenuItem employeeAdd;
    }
}

