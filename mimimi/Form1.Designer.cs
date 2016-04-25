namespace mimimi
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
            this.КнопкаНачатьТестирование = new System.Windows.Forms.Button();
            this.ТекстВыбораРежимаТестирования = new System.Windows.Forms.Label();
            this.КнопкаВыхода = new System.Windows.Forms.Button();
            this.ТекстВыбораКатегорииБилетов = new System.Windows.Forms.Label();
            this.ВыборКатегорий = new System.Windows.Forms.ComboBox();
            this.РежимТестирования = new System.Windows.Forms.ComboBox();
            this.SuspendLayout();
            // 
            // КнопкаНачатьТестирование
            // 
            this.КнопкаНачатьТестирование.BackColor = System.Drawing.Color.RoyalBlue;
            this.КнопкаНачатьТестирование.Cursor = System.Windows.Forms.Cursors.Hand;
            this.КнопкаНачатьТестирование.Font = new System.Drawing.Font("Consolas", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.КнопкаНачатьТестирование.Location = new System.Drawing.Point(249, 305);
            this.КнопкаНачатьТестирование.Name = "КнопкаНачатьТестирование";
            this.КнопкаНачатьТестирование.Size = new System.Drawing.Size(172, 53);
            this.КнопкаНачатьТестирование.TabIndex = 0;
            this.КнопкаНачатьТестирование.Text = "Начать тестирование";
            this.КнопкаНачатьТестирование.UseVisualStyleBackColor = false;
            this.КнопкаНачатьТестирование.Click += new System.EventHandler(this.НачатьТестирование_Click);
            // 
            // ТекстВыбораРежимаТестирования
            // 
            this.ТекстВыбораРежимаТестирования.AutoSize = true;
            this.ТекстВыбораРежимаТестирования.BackColor = System.Drawing.Color.Transparent;
            this.ТекстВыбораРежимаТестирования.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТекстВыбораРежимаТестирования.ForeColor = System.Drawing.Color.Black;
            this.ТекстВыбораРежимаТестирования.Location = new System.Drawing.Point(234, 133);
            this.ТекстВыбораРежимаТестирования.Name = "ТекстВыбораРежимаТестирования";
            this.ТекстВыбораРежимаТестирования.Size = new System.Drawing.Size(208, 22);
            this.ТекстВыбораРежимаТестирования.TabIndex = 3;
            this.ТекстВыбораРежимаТестирования.Text = "Режим тестирования";
            this.ТекстВыбораРежимаТестирования.Click += new System.EventHandler(this.label1_Click);
            // 
            // КнопкаВыхода
            // 
            this.КнопкаВыхода.BackgroundImage = global::mimimi.Properties.Resources.gtk_close;
            this.КнопкаВыхода.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.КнопкаВыхода.Location = new System.Drawing.Point(617, 25);
            this.КнопкаВыхода.Name = "КнопкаВыхода";
            this.КнопкаВыхода.Size = new System.Drawing.Size(32, 29);
            this.КнопкаВыхода.TabIndex = 4;
            this.КнопкаВыхода.UseVisualStyleBackColor = true;
            this.КнопкаВыхода.Click += new System.EventHandler(this.Выход_Click);
            // 
            // ТекстВыбораКатегорииБилетов
            // 
            this.ТекстВыбораКатегорииБилетов.AutoSize = true;
            this.ТекстВыбораКатегорииБилетов.BackColor = System.Drawing.Color.Transparent;
            this.ТекстВыбораКатегорииБилетов.Font = new System.Drawing.Font("Courier New", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ТекстВыбораКатегорииБилетов.Location = new System.Drawing.Point(234, 220);
            this.ТекстВыбораКатегорииБилетов.Name = "ТекстВыбораКатегорииБилетов";
            this.ТекстВыбораКатегорииБилетов.Size = new System.Drawing.Size(208, 22);
            this.ТекстВыбораКатегорииБилетов.TabIndex = 5;
            this.ТекстВыбораКатегорииБилетов.Text = "Выберите категорию";
            this.ТекстВыбораКатегорииБилетов.Click += new System.EventHandler(this.label2_Click);
            // 
            // ВыборКатегорий
            // 
            this.ВыборКатегорий.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ВыборКатегорий.FormattingEnabled = true;
            this.ВыборКатегорий.Items.AddRange(new object[] {
            "B",
            "C",
            "D",
            "E"});
            this.ВыборКатегорий.Location = new System.Drawing.Point(249, 266);
            this.ВыборКатегорий.Name = "ВыборКатегорий";
            this.ВыборКатегорий.Size = new System.Drawing.Size(172, 26);
            this.ВыборКатегорий.TabIndex = 6;
            // 
            // РежимТестирования
            // 
            this.РежимТестирования.Font = new System.Drawing.Font("Courier New", 12F, System.Drawing.FontStyle.Bold);
            this.РежимТестирования.FormattingEnabled = true;
            this.РежимТестирования.Items.AddRange(new object[] {
            "Режим обучения",
            "Режим экзамена"});
            this.РежимТестирования.Location = new System.Drawing.Point(249, 174);
            this.РежимТестирования.Name = "РежимТестирования";
            this.РежимТестирования.Size = new System.Drawing.Size(172, 26);
            this.РежимТестирования.TabIndex = 7;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoScroll = true;
            this.BackColor = System.Drawing.Color.White;
            this.BackgroundImage = global::mimimi.Properties.Resources.tekstura_uzory_siniy_fon_oboi;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(683, 536);
            this.Controls.Add(this.РежимТестирования);
            this.Controls.Add(this.ВыборКатегорий);
            this.Controls.Add(this.ТекстВыбораКатегорииБилетов);
            this.Controls.Add(this.КнопкаВыхода);
            this.Controls.Add(this.ТекстВыбораРежимаТестирования);
            this.Controls.Add(this.КнопкаНачатьТестирование);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button КнопкаНачатьТестирование;
        private System.Windows.Forms.Label ТекстВыбораРежимаТестирования;
        private System.Windows.Forms.Button КнопкаВыхода;
        private System.Windows.Forms.Label ТекстВыбораКатегорииБилетов;
        private System.Windows.Forms.ComboBox ВыборКатегорий;
        private System.Windows.Forms.ComboBox РежимТестирования;
    }
}

