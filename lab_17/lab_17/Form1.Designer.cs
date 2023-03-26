namespace lab_17
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
            this.rezult_Year = new System.Windows.Forms.Label();
            this.btn_Year = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.Year_txt = new System.Windows.Forms.TextBox();
            this.Month_txt = new System.Windows.Forms.TextBox();
            this.Day_txt = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.Hour_txt = new System.Windows.Forms.TextBox();
            this.Minute_txt = new System.Windows.Forms.TextBox();
            this.Second_txt = new System.Windows.Forms.TextBox();
            this.btn_Month = new System.Windows.Forms.Button();
            this.btn_Day = new System.Windows.Forms.Button();
            this.btn_Hour = new System.Windows.Forms.Button();
            this.btn_Minute = new System.Windows.Forms.Button();
            this.btn_Second = new System.Windows.Forms.Button();
            this.rezult_Month = new System.Windows.Forms.Label();
            this.rezult_Day = new System.Windows.Forms.Label();
            this.rezult_Hour = new System.Windows.Forms.Label();
            this.rezult_Minute = new System.Windows.Forms.Label();
            this.rezult_Second = new System.Windows.Forms.Label();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // rezult_Year
            // 
            this.rezult_Year.AutoSize = true;
            this.rezult_Year.Location = new System.Drawing.Point(141, 41);
            this.rezult_Year.Name = "rezult_Year";
            this.rezult_Year.Size = new System.Drawing.Size(0, 16);
            this.rezult_Year.TabIndex = 0;
            // 
            // btn_Year
            // 
            this.btn_Year.Location = new System.Drawing.Point(275, 37);
            this.btn_Year.Name = "btn_Year";
            this.btn_Year.Size = new System.Drawing.Size(110, 23);
            this.btn_Year.TabIndex = 1;
            this.btn_Year.Text = "+ 1 Рік";
            this.btn_Year.UseVisualStyleBackColor = true;
            this.btn_Year.Click += new System.EventHandler(this.btn_Year_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(12, 19);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(39, 16);
            this.label1.TabIndex = 2;
            this.label1.Text = "Роки";
            // 
            // Year_txt
            // 
            this.Year_txt.Location = new System.Drawing.Point(15, 38);
            this.Year_txt.Name = "Year_txt";
            this.Year_txt.Size = new System.Drawing.Size(100, 22);
            this.Year_txt.TabIndex = 3;
            this.Year_txt.Tag = "";
            this.Year_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Year_txt_KeyPress);
            // 
            // Month_txt
            // 
            this.Month_txt.Location = new System.Drawing.Point(15, 82);
            this.Month_txt.Name = "Month_txt";
            this.Month_txt.Size = new System.Drawing.Size(100, 22);
            this.Month_txt.TabIndex = 4;
            this.Month_txt.Tag = "";
            this.Month_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Month_txt_KeyPress);
            // 
            // Day_txt
            // 
            this.Day_txt.Location = new System.Drawing.Point(15, 126);
            this.Day_txt.Name = "Day_txt";
            this.Day_txt.Size = new System.Drawing.Size(100, 22);
            this.Day_txt.TabIndex = 5;
            this.Day_txt.Tag = "";
            this.Day_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Day_txt_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(12, 63);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(46, 16);
            this.label2.TabIndex = 6;
            this.label2.Text = "Місяці";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(12, 107);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(27, 16);
            this.label3.TabIndex = 7;
            this.label3.Text = "Дні";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(12, 151);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(54, 16);
            this.label4.TabIndex = 8;
            this.label4.Text = "Години";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(12, 195);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 16);
            this.label5.TabIndex = 9;
            this.label5.Text = "Хвилини";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(12, 239);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 16);
            this.label6.TabIndex = 10;
            this.label6.Text = "Секунди";
            // 
            // Hour_txt
            // 
            this.Hour_txt.Location = new System.Drawing.Point(15, 170);
            this.Hour_txt.Name = "Hour_txt";
            this.Hour_txt.Size = new System.Drawing.Size(100, 22);
            this.Hour_txt.TabIndex = 11;
            this.Hour_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Hour_txt_KeyPress);
            // 
            // Minute_txt
            // 
            this.Minute_txt.Location = new System.Drawing.Point(15, 214);
            this.Minute_txt.Name = "Minute_txt";
            this.Minute_txt.Size = new System.Drawing.Size(100, 22);
            this.Minute_txt.TabIndex = 12;
            this.Minute_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Minute_txt_KeyPress);
            // 
            // Second_txt
            // 
            this.Second_txt.Location = new System.Drawing.Point(15, 258);
            this.Second_txt.Name = "Second_txt";
            this.Second_txt.Size = new System.Drawing.Size(100, 22);
            this.Second_txt.TabIndex = 13;
            this.Second_txt.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Second_txt_KeyPress);
            // 
            // btn_Month
            // 
            this.btn_Month.Location = new System.Drawing.Point(275, 81);
            this.btn_Month.Name = "btn_Month";
            this.btn_Month.Size = new System.Drawing.Size(110, 23);
            this.btn_Month.TabIndex = 14;
            this.btn_Month.Text = "+ 1 Місяць";
            this.btn_Month.UseVisualStyleBackColor = true;
            this.btn_Month.Click += new System.EventHandler(this.btn_Month_Click);
            // 
            // btn_Day
            // 
            this.btn_Day.Location = new System.Drawing.Point(275, 125);
            this.btn_Day.Name = "btn_Day";
            this.btn_Day.Size = new System.Drawing.Size(110, 23);
            this.btn_Day.TabIndex = 15;
            this.btn_Day.Text = "+ 1 День";
            this.btn_Day.UseVisualStyleBackColor = true;
            this.btn_Day.Click += new System.EventHandler(this.btn_Day_Click);
            // 
            // btn_Hour
            // 
            this.btn_Hour.Location = new System.Drawing.Point(275, 169);
            this.btn_Hour.Name = "btn_Hour";
            this.btn_Hour.Size = new System.Drawing.Size(110, 23);
            this.btn_Hour.TabIndex = 16;
            this.btn_Hour.Text = "+ 1 Година";
            this.btn_Hour.UseVisualStyleBackColor = true;
            this.btn_Hour.Click += new System.EventHandler(this.btn_Hour_Click);
            // 
            // btn_Minute
            // 
            this.btn_Minute.Location = new System.Drawing.Point(275, 213);
            this.btn_Minute.Name = "btn_Minute";
            this.btn_Minute.Size = new System.Drawing.Size(110, 23);
            this.btn_Minute.TabIndex = 17;
            this.btn_Minute.Text = "+ 1 Хвилина";
            this.btn_Minute.UseVisualStyleBackColor = true;
            this.btn_Minute.Click += new System.EventHandler(this.btn_Minute_Click);
            // 
            // btn_Second
            // 
            this.btn_Second.Location = new System.Drawing.Point(275, 257);
            this.btn_Second.Name = "btn_Second";
            this.btn_Second.Size = new System.Drawing.Size(110, 23);
            this.btn_Second.TabIndex = 18;
            this.btn_Second.Text = "+ 1 Секунда";
            this.btn_Second.UseVisualStyleBackColor = true;
            this.btn_Second.Click += new System.EventHandler(this.btn_Second_Click);
            // 
            // rezult_Month
            // 
            this.rezult_Month.AutoSize = true;
            this.rezult_Month.Location = new System.Drawing.Point(141, 85);
            this.rezult_Month.Name = "rezult_Month";
            this.rezult_Month.Size = new System.Drawing.Size(0, 16);
            this.rezult_Month.TabIndex = 19;
            // 
            // rezult_Day
            // 
            this.rezult_Day.AutoSize = true;
            this.rezult_Day.Location = new System.Drawing.Point(141, 129);
            this.rezult_Day.Name = "rezult_Day";
            this.rezult_Day.Size = new System.Drawing.Size(0, 16);
            this.rezult_Day.TabIndex = 20;
            // 
            // rezult_Hour
            // 
            this.rezult_Hour.AutoSize = true;
            this.rezult_Hour.Location = new System.Drawing.Point(141, 173);
            this.rezult_Hour.Name = "rezult_Hour";
            this.rezult_Hour.Size = new System.Drawing.Size(0, 16);
            this.rezult_Hour.TabIndex = 21;
            // 
            // rezult_Minute
            // 
            this.rezult_Minute.AutoSize = true;
            this.rezult_Minute.Location = new System.Drawing.Point(141, 217);
            this.rezult_Minute.Name = "rezult_Minute";
            this.rezult_Minute.Size = new System.Drawing.Size(0, 16);
            this.rezult_Minute.TabIndex = 22;
            // 
            // rezult_Second
            // 
            this.rezult_Second.AutoSize = true;
            this.rezult_Second.Location = new System.Drawing.Point(141, 261);
            this.rezult_Second.Name = "rezult_Second";
            this.rezult_Second.Size = new System.Drawing.Size(0, 16);
            this.rezult_Second.TabIndex = 23;
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(15, 303);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(100, 25);
            this.button1.TabIndex = 30;
            this.button1.Text = "Обробити*";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.rezult_Second);
            this.Controls.Add(this.rezult_Minute);
            this.Controls.Add(this.rezult_Hour);
            this.Controls.Add(this.rezult_Day);
            this.Controls.Add(this.rezult_Month);
            this.Controls.Add(this.btn_Second);
            this.Controls.Add(this.btn_Minute);
            this.Controls.Add(this.btn_Hour);
            this.Controls.Add(this.btn_Day);
            this.Controls.Add(this.btn_Month);
            this.Controls.Add(this.Second_txt);
            this.Controls.Add(this.Minute_txt);
            this.Controls.Add(this.Hour_txt);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.Day_txt);
            this.Controls.Add(this.Month_txt);
            this.Controls.Add(this.Year_txt);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.btn_Year);
            this.Controls.Add(this.rezult_Year);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label rezult_Year;
        private System.Windows.Forms.Button btn_Year;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox Year_txt;
        private System.Windows.Forms.TextBox Month_txt;
        private System.Windows.Forms.TextBox Day_txt;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox Hour_txt;
        private System.Windows.Forms.TextBox Minute_txt;
        private System.Windows.Forms.TextBox Second_txt;
        private System.Windows.Forms.Button btn_Month;
        private System.Windows.Forms.Button btn_Day;
        private System.Windows.Forms.Button btn_Hour;
        private System.Windows.Forms.Button btn_Minute;
        private System.Windows.Forms.Button btn_Second;
        private System.Windows.Forms.Label rezult_Month;
        private System.Windows.Forms.Label rezult_Day;
        private System.Windows.Forms.Label rezult_Hour;
        private System.Windows.Forms.Label rezult_Minute;
        private System.Windows.Forms.Label rezult_Second;
        private System.Windows.Forms.Button button1;
    }
}

