
namespace LR22_Sydorenco_202TN
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
            this.components = new System.ComponentModel.Container();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.справкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.відкритиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиЯкToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.зберегтиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.правкаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.скопіюватиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.шрифтToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметриШрифтаToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.фонToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.параметриФонуToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveFileDialog1 = new System.Windows.Forms.SaveFileDialog();
            this.openFileDialog1 = new System.Windows.Forms.OpenFileDialog();
            this.fontDialog1 = new System.Windows.Forms.FontDialog();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.виділитиВсеToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.скопіюватиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вставитиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.вирізатиToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.виділитиВсеToolStripMenuItem1 = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // richTextBox1
            // 
            this.richTextBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.richTextBox1.Location = new System.Drawing.Point(0, 28);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(873, 451);
            this.richTextBox1.TabIndex = 0;
            this.richTextBox1.Text = "";
            this.richTextBox1.MouseUp += new System.Windows.Forms.MouseEventHandler(this.richTextBox1_MouseUp);
            // 
            // menuStrip1
            // 
            this.menuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.справкаToolStripMenuItem,
            this.правкаToolStripMenuItem,
            this.шрифтToolStripMenuItem,
            this.фонToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(873, 28);
            this.menuStrip1.TabIndex = 1;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // справкаToolStripMenuItem
            // 
            this.справкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.відкритиToolStripMenuItem,
            this.зберегтиЯкToolStripMenuItem,
            this.зберегтиToolStripMenuItem});
            this.справкаToolStripMenuItem.Name = "справкаToolStripMenuItem";
            this.справкаToolStripMenuItem.Size = new System.Drawing.Size(59, 24);
            this.справкаToolStripMenuItem.Text = "Файл";
            // 
            // відкритиToolStripMenuItem
            // 
            this.відкритиToolStripMenuItem.Name = "відкритиToolStripMenuItem";
            this.відкритиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.відкритиToolStripMenuItem.Text = "Відкрити";
            this.відкритиToolStripMenuItem.Click += new System.EventHandler(this.відкритиToolStripMenuItem_Click);
            // 
            // зберегтиЯкToolStripMenuItem
            // 
            this.зберегтиЯкToolStripMenuItem.Name = "зберегтиЯкToolStripMenuItem";
            this.зберегтиЯкToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зберегтиЯкToolStripMenuItem.Text = "Зберегти як";
            this.зберегтиЯкToolStripMenuItem.Click += new System.EventHandler(this.зберегтиЯкToolStripMenuItem_Click);
            // 
            // зберегтиToolStripMenuItem
            // 
            this.зберегтиToolStripMenuItem.Name = "зберегтиToolStripMenuItem";
            this.зберегтиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.зберегтиToolStripMenuItem.Text = "Зберегти";
            this.зберегтиToolStripMenuItem.Click += new System.EventHandler(this.зберегтиToolStripMenuItem_Click);
            // 
            // правкаToolStripMenuItem
            // 
            this.правкаToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скопіюватиToolStripMenuItem,
            this.вставитиToolStripMenuItem,
            this.вирізатиToolStripMenuItem,
            this.виділитиВсеToolStripMenuItem});
            this.правкаToolStripMenuItem.Name = "правкаToolStripMenuItem";
            this.правкаToolStripMenuItem.Size = new System.Drawing.Size(74, 24);
            this.правкаToolStripMenuItem.Text = "Правка";
            // 
            // скопіюватиToolStripMenuItem
            // 
            this.скопіюватиToolStripMenuItem.Name = "скопіюватиToolStripMenuItem";
            this.скопіюватиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.скопіюватиToolStripMenuItem.Text = "Скопіювати";
            this.скопіюватиToolStripMenuItem.Click += new System.EventHandler(this.скопіюватиToolStripMenuItem_Click);
            // 
            // вставитиToolStripMenuItem
            // 
            this.вставитиToolStripMenuItem.Name = "вставитиToolStripMenuItem";
            this.вставитиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вставитиToolStripMenuItem.Text = "Вставити";
            this.вставитиToolStripMenuItem.Click += new System.EventHandler(this.вставитиToolStripMenuItem_Click);
            // 
            // вирізатиToolStripMenuItem
            // 
            this.вирізатиToolStripMenuItem.Name = "вирізатиToolStripMenuItem";
            this.вирізатиToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.вирізатиToolStripMenuItem.Text = "Вирізати";
            this.вирізатиToolStripMenuItem.Click += new System.EventHandler(this.вирізатиToolStripMenuItem_Click);
            // 
            // шрифтToolStripMenuItem
            // 
            this.шрифтToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметриШрифтаToolStripMenuItem});
            this.шрифтToolStripMenuItem.Name = "шрифтToolStripMenuItem";
            this.шрифтToolStripMenuItem.Size = new System.Drawing.Size(129, 24);
            this.шрифтToolStripMenuItem.Text = "Змінити шрифт";
            // 
            // параметриШрифтаToolStripMenuItem
            // 
            this.параметриШрифтаToolStripMenuItem.Name = "параметриШрифтаToolStripMenuItem";
            this.параметриШрифтаToolStripMenuItem.Size = new System.Drawing.Size(229, 26);
            this.параметриШрифтаToolStripMenuItem.Text = "Параметри шрифта";
            this.параметриШрифтаToolStripMenuItem.Click += new System.EventHandler(this.параметриШрифтаToolStripMenuItem_Click);
            // 
            // фонToolStripMenuItem
            // 
            this.фонToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.параметриФонуToolStripMenuItem});
            this.фонToolStripMenuItem.Name = "фонToolStripMenuItem";
            this.фонToolStripMenuItem.Size = new System.Drawing.Size(174, 24);
            this.фонToolStripMenuItem.Text = "Характеристики фона";
            // 
            // параметриФонуToolStripMenuItem
            // 
            this.параметриФонуToolStripMenuItem.Name = "параметриФонуToolStripMenuItem";
            this.параметриФонуToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.параметриФонуToolStripMenuItem.Text = "Параметри фону";
            this.параметриФонуToolStripMenuItem.Click += new System.EventHandler(this.параметриФонуToolStripMenuItem_Click);
            // 
            // openFileDialog1
            // 
            this.openFileDialog1.FileName = "openFileDialog1";
            // 
            // виділитиВсеToolStripMenuItem
            // 
            this.виділитиВсеToolStripMenuItem.Name = "виділитиВсеToolStripMenuItem";
            this.виділитиВсеToolStripMenuItem.Size = new System.Drawing.Size(224, 26);
            this.виділитиВсеToolStripMenuItem.Text = "Виділити все";
            this.виділитиВсеToolStripMenuItem.Click += new System.EventHandler(this.виділитиВсеToolStripMenuItem_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(20, 20);
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.скопіюватиToolStripMenuItem1,
            this.вставитиToolStripMenuItem1,
            this.вирізатиToolStripMenuItem1,
            this.виділитиВсеToolStripMenuItem1});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(168, 100);
            // 
            // скопіюватиToolStripMenuItem1
            // 
            this.скопіюватиToolStripMenuItem1.Name = "скопіюватиToolStripMenuItem1";
            this.скопіюватиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.скопіюватиToolStripMenuItem1.Text = "Скопіювати";
            this.скопіюватиToolStripMenuItem1.Click += new System.EventHandler(this.скопіюватиToolStripMenuItem1_Click);
            // 
            // вставитиToolStripMenuItem1
            // 
            this.вставитиToolStripMenuItem1.Name = "вставитиToolStripMenuItem1";
            this.вставитиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.вставитиToolStripMenuItem1.Text = "Вставити";
            this.вставитиToolStripMenuItem1.Click += new System.EventHandler(this.вставитиToolStripMenuItem1_Click);
            // 
            // вирізатиToolStripMenuItem1
            // 
            this.вирізатиToolStripMenuItem1.Name = "вирізатиToolStripMenuItem1";
            this.вирізатиToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.вирізатиToolStripMenuItem1.Text = "Вирізати";
            this.вирізатиToolStripMenuItem1.Click += new System.EventHandler(this.вирізатиToolStripMenuItem1_Click);
            // 
            // виділитиВсеToolStripMenuItem1
            // 
            this.виділитиВсеToolStripMenuItem1.Name = "виділитиВсеToolStripMenuItem1";
            this.виділитиВсеToolStripMenuItem1.Size = new System.Drawing.Size(210, 24);
            this.виділитиВсеToolStripMenuItem1.Text = "Виділити все";
            this.виділитиВсеToolStripMenuItem1.Click += new System.EventHandler(this.виділитиВсеToolStripMenuItem1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(873, 479);
            this.Controls.Add(this.richTextBox1);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.Name = "Form1";
            this.Text = "Form1";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem справкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem відкритиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиЯкToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem зберегтиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem правкаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem скопіюватиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem шрифтToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметриШрифтаToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem фонToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem параметриФонуToolStripMenuItem;
        private System.Windows.Forms.SaveFileDialog saveFileDialog1;
        private System.Windows.Forms.OpenFileDialog openFileDialog1;
        private System.Windows.Forms.FontDialog fontDialog1;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.ToolStripMenuItem виділитиВсеToolStripMenuItem;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem скопіюватиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вставитиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem вирізатиToolStripMenuItem1;
        private System.Windows.Forms.ToolStripMenuItem виділитиВсеToolStripMenuItem1;
    }
}

