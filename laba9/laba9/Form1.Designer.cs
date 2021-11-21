
namespace laba9
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
            this.tabControl1 = new System.Windows.Forms.TabControl();
            this.tabPage1 = new System.Windows.Forms.TabPage();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.button1 = new System.Windows.Forms.Button();
            this.btn1_1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.btn1_2 = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.tB1_1 = new System.Windows.Forms.TextBox();
            this.tB1_2 = new System.Windows.Forms.TextBox();
            this.tB1_3 = new System.Windows.Forms.TextBox();
            this.richTextBox1 = new System.Windows.Forms.RichTextBox();
            this.tabPage2 = new System.Windows.Forms.TabPage();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.tB2_1 = new System.Windows.Forms.TextBox();
            this.tB2_2 = new System.Windows.Forms.TextBox();
            this.tB2_3 = new System.Windows.Forms.TextBox();
            this.tB2_4 = new System.Windows.Forms.TextBox();
            this.tB2_5 = new System.Windows.Forms.TextBox();
            this.richTextBox2 = new System.Windows.Forms.RichTextBox();
            this.btnBuild = new System.Windows.Forms.Button();
            this.tabControl1.SuspendLayout();
            this.tabPage1.SuspendLayout();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.tabPage2.SuspendLayout();
            this.SuspendLayout();
            // 
            // tabControl1
            // 
            this.tabControl1.Controls.Add(this.tabPage1);
            this.tabControl1.Controls.Add(this.tabPage2);
            this.tabControl1.Location = new System.Drawing.Point(2, 1);
            this.tabControl1.Name = "tabControl1";
            this.tabControl1.SelectedIndex = 0;
            this.tabControl1.Size = new System.Drawing.Size(786, 404);
            this.tabControl1.TabIndex = 0;
            // 
            // tabPage1
            // 
            this.tabPage1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.tabPage1.Controls.Add(this.groupBox2);
            this.tabPage1.Controls.Add(this.label3);
            this.tabPage1.Controls.Add(this.groupBox1);
            this.tabPage1.Controls.Add(this.tB1_3);
            this.tabPage1.Controls.Add(this.richTextBox1);
            this.tabPage1.Location = new System.Drawing.Point(4, 25);
            this.tabPage1.Name = "tabPage1";
            this.tabPage1.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage1.Size = new System.Drawing.Size(778, 375);
            this.tabPage1.TabIndex = 0;
            this.tabPage1.Text = "Банк";
            this.tabPage1.UseVisualStyleBackColor = true;
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.button1);
            this.groupBox2.Controls.Add(this.btn1_1);
            this.groupBox2.Controls.Add(this.button2);
            this.groupBox2.Controls.Add(this.btn1_2);
            this.groupBox2.Location = new System.Drawing.Point(24, 239);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(710, 111);
            this.groupBox2.TabIndex = 3;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Операции со счетами";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(375, 36);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(154, 47);
            this.button1.TabIndex = 7;
            this.button1.Text = "Снять со счета";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // btn1_1
            // 
            this.btn1_1.Location = new System.Drawing.Point(20, 36);
            this.btn1_1.Name = "btn1_1";
            this.btn1_1.Size = new System.Drawing.Size(154, 47);
            this.btn1_1.TabIndex = 0;
            this.btn1_1.Text = "Вывести информацию";
            this.btn1_1.UseVisualStyleBackColor = true;
            this.btn1_1.Click += new System.EventHandler(this.btn1_1_Click);
            // 
            // button2
            // 
            this.button2.Location = new System.Drawing.Point(535, 36);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(154, 47);
            this.button2.TabIndex = 8;
            this.button2.Text = "Положить на счет";
            this.button2.UseVisualStyleBackColor = true;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // btn1_2
            // 
            this.btn1_2.Location = new System.Drawing.Point(180, 36);
            this.btn1_2.Name = "btn1_2";
            this.btn1_2.Size = new System.Drawing.Size(154, 47);
            this.btn1_2.TabIndex = 5;
            this.btn1_2.Text = "Ввести информацию";
            this.btn1_2.UseVisualStyleBackColor = true;
            this.btn1_2.Click += new System.EventHandler(this.btn1_2_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 177);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(149, 34);
            this.label3.TabIndex = 9;
            this.label3.Text = "Сумма, к/т вы хотите \r\nввести/вывести:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.tB1_1);
            this.groupBox1.Controls.Add(this.tB1_2);
            this.groupBox1.Location = new System.Drawing.Point(24, 33);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(334, 131);
            this.groupBox1.TabIndex = 6;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Банк";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 78);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(60, 17);
            this.label2.TabIndex = 2;
            this.label2.Text = "Баланс:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(17, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(97, 17);
            this.label1.TabIndex = 0;
            this.label1.Text = "Номер счета:";
            // 
            // tB1_1
            // 
            this.tB1_1.Location = new System.Drawing.Point(185, 35);
            this.tB1_1.Name = "tB1_1";
            this.tB1_1.Size = new System.Drawing.Size(100, 22);
            this.tB1_1.TabIndex = 1;
            // 
            // tB1_2
            // 
            this.tB1_2.Location = new System.Drawing.Point(185, 76);
            this.tB1_2.Name = "tB1_2";
            this.tB1_2.Size = new System.Drawing.Size(100, 22);
            this.tB1_2.TabIndex = 2;
            // 
            // tB1_3
            // 
            this.tB1_3.Location = new System.Drawing.Point(209, 189);
            this.tB1_3.Name = "tB1_3";
            this.tB1_3.Size = new System.Drawing.Size(100, 22);
            this.tB1_3.TabIndex = 4;
            // 
            // richTextBox1
            // 
            this.richTextBox1.Location = new System.Drawing.Point(399, 33);
            this.richTextBox1.Name = "richTextBox1";
            this.richTextBox1.Size = new System.Drawing.Size(314, 139);
            this.richTextBox1.TabIndex = 3;
            this.richTextBox1.Text = "";
            // 
            // tabPage2
            // 
            this.tabPage2.Controls.Add(this.btnBuild);
            this.tabPage2.Controls.Add(this.richTextBox2);
            this.tabPage2.Controls.Add(this.tB2_5);
            this.tabPage2.Controls.Add(this.tB2_4);
            this.tabPage2.Controls.Add(this.tB2_3);
            this.tabPage2.Controls.Add(this.tB2_2);
            this.tabPage2.Controls.Add(this.tB2_1);
            this.tabPage2.Controls.Add(this.label8);
            this.tabPage2.Controls.Add(this.label7);
            this.tabPage2.Controls.Add(this.label6);
            this.tabPage2.Controls.Add(this.label5);
            this.tabPage2.Controls.Add(this.label4);
            this.tabPage2.Location = new System.Drawing.Point(4, 25);
            this.tabPage2.Name = "tabPage2";
            this.tabPage2.Padding = new System.Windows.Forms.Padding(3);
            this.tabPage2.Size = new System.Drawing.Size(778, 375);
            this.tabPage2.TabIndex = 1;
            this.tabPage2.Text = "Здание";
            this.tabPage2.UseVisualStyleBackColor = true;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(59, 57);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 17);
            this.label4.TabIndex = 0;
            this.label4.Text = "Номер сдания:";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(59, 99);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(112, 17);
            this.label5.TabIndex = 1;
            this.label5.Text = "Высота здания:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(59, 141);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(108, 17);
            this.label6.TabIndex = 2;
            this.label6.Text = "Кол-во этажей:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(59, 182);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(114, 17);
            this.label7.TabIndex = 3;
            this.label7.Text = "Кол-во квартир:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(59, 223);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(132, 17);
            this.label8.TabIndex = 4;
            this.label8.Text = "Кол-во подъездов:";
            // 
            // tB2_1
            // 
            this.tB2_1.Location = new System.Drawing.Point(210, 54);
            this.tB2_1.Name = "tB2_1";
            this.tB2_1.Size = new System.Drawing.Size(100, 22);
            this.tB2_1.TabIndex = 5;
            // 
            // tB2_2
            // 
            this.tB2_2.Location = new System.Drawing.Point(210, 96);
            this.tB2_2.Name = "tB2_2";
            this.tB2_2.Size = new System.Drawing.Size(100, 22);
            this.tB2_2.TabIndex = 6;
            // 
            // tB2_3
            // 
            this.tB2_3.Location = new System.Drawing.Point(210, 138);
            this.tB2_3.Name = "tB2_3";
            this.tB2_3.Size = new System.Drawing.Size(100, 22);
            this.tB2_3.TabIndex = 7;
            // 
            // tB2_4
            // 
            this.tB2_4.Location = new System.Drawing.Point(210, 179);
            this.tB2_4.Name = "tB2_4";
            this.tB2_4.Size = new System.Drawing.Size(100, 22);
            this.tB2_4.TabIndex = 8;
            // 
            // tB2_5
            // 
            this.tB2_5.Location = new System.Drawing.Point(210, 220);
            this.tB2_5.Name = "tB2_5";
            this.tB2_5.Size = new System.Drawing.Size(100, 22);
            this.tB2_5.TabIndex = 9;
            // 
            // richTextBox2
            // 
            this.richTextBox2.Location = new System.Drawing.Point(379, 54);
            this.richTextBox2.Name = "richTextBox2";
            this.richTextBox2.Size = new System.Drawing.Size(289, 188);
            this.richTextBox2.TabIndex = 10;
            this.richTextBox2.Text = "";
            // 
            // btnBuild
            // 
            this.btnBuild.Location = new System.Drawing.Point(62, 285);
            this.btnBuild.Name = "btnBuild";
            this.btnBuild.Size = new System.Drawing.Size(149, 42);
            this.btnBuild.TabIndex = 11;
            this.btnBuild.Text = "button3";
            this.btnBuild.UseVisualStyleBackColor = true;
            this.btnBuild.Click += new System.EventHandler(this.btnBuild_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.tabControl1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.tabControl1.ResumeLayout(false);
            this.tabPage1.ResumeLayout(false);
            this.tabPage1.PerformLayout();
            this.groupBox2.ResumeLayout(false);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.tabPage2.ResumeLayout(false);
            this.tabPage2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TabControl tabControl1;
        private System.Windows.Forms.TabPage tabPage1;
        private System.Windows.Forms.Button btn1_1;
        private System.Windows.Forms.TabPage tabPage2;
        private System.Windows.Forms.TextBox tB1_2;
        private System.Windows.Forms.TextBox tB1_1;
        private System.Windows.Forms.RichTextBox richTextBox1;
        private System.Windows.Forms.TextBox tB1_3;
        private System.Windows.Forms.Button btn1_2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btnBuild;
        private System.Windows.Forms.RichTextBox richTextBox2;
        private System.Windows.Forms.TextBox tB2_5;
        private System.Windows.Forms.TextBox tB2_4;
        private System.Windows.Forms.TextBox tB2_3;
        private System.Windows.Forms.TextBox tB2_2;
        private System.Windows.Forms.TextBox tB2_1;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
    }
}

