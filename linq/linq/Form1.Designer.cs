
namespace linq
{
    partial class Form1
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.listBox1 = new System.Windows.Forms.ListBox();
            this.SortByAge = new System.Windows.Forms.Button();
            this.GroupPeople = new System.Windows.Forms.Button();
            this.ShowCountryOnI = new System.Windows.Forms.Button();
            this.listBox2 = new System.Windows.Forms.ListBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.listBox1);
            this.groupBox1.Location = new System.Drawing.Point(27, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(359, 221);
            this.groupBox1.TabIndex = 0;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "groupBox1";
            this.groupBox1.Visible = false;
            this.groupBox1.Enter += new System.EventHandler(this.groupBox1_Enter);
            // 
            // listBox1
            // 
            this.listBox1.FormattingEnabled = true;
            this.listBox1.Location = new System.Drawing.Point(6, 19);
            this.listBox1.Name = "listBox1";
            this.listBox1.Size = new System.Drawing.Size(343, 134);
            this.listBox1.TabIndex = 0;
            // 
            // SortByAge
            // 
            this.SortByAge.Location = new System.Drawing.Point(99, 252);
            this.SortByAge.Name = "SortByAge";
            this.SortByAge.Size = new System.Drawing.Size(95, 38);
            this.SortByAge.TabIndex = 1;
            this.SortByAge.Text = "Вывод людей за сорок";
            this.SortByAge.UseVisualStyleBackColor = true;
            this.SortByAge.Click += new System.EventHandler(this.SortByAge_Click);
            // 
            // GroupPeople
            // 
            this.GroupPeople.Location = new System.Drawing.Point(434, 260);
            this.GroupPeople.Name = "GroupPeople";
            this.GroupPeople.Size = new System.Drawing.Size(89, 46);
            this.GroupPeople.TabIndex = 2;
            this.GroupPeople.Text = "Группировка людей";
            this.GroupPeople.UseVisualStyleBackColor = true;
            this.GroupPeople.Click += new System.EventHandler(this.GroupPeople_Click);
            // 
            // ShowCountryOnI
            // 
            this.ShowCountryOnI.Location = new System.Drawing.Point(653, 260);
            this.ShowCountryOnI.Name = "ShowCountryOnI";
            this.ShowCountryOnI.Size = new System.Drawing.Size(89, 46);
            this.ShowCountryOnI.TabIndex = 3;
            this.ShowCountryOnI.Text = "Вывод людей на и";
            this.ShowCountryOnI.UseVisualStyleBackColor = true;
            this.ShowCountryOnI.Click += new System.EventHandler(this.ShowCountryOnI_Click);
            // 
            // listBox2
            // 
            this.listBox2.FormattingEnabled = true;
            this.listBox2.Location = new System.Drawing.Point(407, 31);
            this.listBox2.Name = "listBox2";
            this.listBox2.Size = new System.Drawing.Size(353, 147);
            this.listBox2.TabIndex = 4;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.listBox2);
            this.Controls.Add(this.ShowCountryOnI);
            this.Controls.Add(this.GroupPeople);
            this.Controls.Add(this.SortByAge);
            this.Controls.Add(this.groupBox1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.groupBox1.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.ListBox listBox1;
        private System.Windows.Forms.Button SortByAge;
        private System.Windows.Forms.Button GroupPeople;
        private System.Windows.Forms.Button ShowCountryOnI;
        private System.Windows.Forms.ListBox listBox2;
    }
}

