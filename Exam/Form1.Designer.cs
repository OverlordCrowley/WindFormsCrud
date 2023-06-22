namespace Exam
{
    partial class Form1
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
            this.button_Create = new System.Windows.Forms.Button();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.button_Detele = new System.Windows.Forms.Button();
            this.button_Edit = new System.Windows.Forms.Button();
            this.textBox_EditCountry = new System.Windows.Forms.TextBox();
            this.textBox_EditSecondName = new System.Windows.Forms.TextBox();
            this.textBox_EditRank = new System.Windows.Forms.TextBox();
            this.textBox_EditRating = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.button_EditClear = new System.Windows.Forms.Button();
            this.button_EditSave = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.label9 = new System.Windows.Forms.Label();
            this.panel2 = new System.Windows.Forms.Panel();
            this.label10 = new System.Windows.Forms.Label();
            this.textBox_AddRating = new System.Windows.Forms.TextBox();
            this.button_AddSave = new System.Windows.Forms.Button();
            this.textBox_AddCountry = new System.Windows.Forms.TextBox();
            this.button_AddClear = new System.Windows.Forms.Button();
            this.textBox_AddSecondName = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.textBox_AddRank = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // button_Create
            // 
            this.button_Create.Location = new System.Drawing.Point(629, 12);
            this.button_Create.Name = "button_Create";
            this.button_Create.Size = new System.Drawing.Size(232, 42);
            this.button_Create.TabIndex = 0;
            this.button_Create.Text = "Создать";
            this.button_Create.UseVisualStyleBackColor = true;
            this.button_Create.Click += new System.EventHandler(this.button_Create_Click);
            // 
            // dataGridView1
            // 
            this.dataGridView1.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(12, 12);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.RowTemplate.Height = 25;
            this.dataGridView1.Size = new System.Drawing.Size(611, 264);
            this.dataGridView1.TabIndex = 1;
            this.dataGridView1.CellDoubleClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView1_CellDoubleClick);
            // 
            // button_Detele
            // 
            this.button_Detele.Enabled = false;
            this.button_Detele.Location = new System.Drawing.Point(629, 60);
            this.button_Detele.Name = "button_Detele";
            this.button_Detele.Size = new System.Drawing.Size(232, 42);
            this.button_Detele.TabIndex = 2;
            this.button_Detele.Text = "Удалить";
            this.button_Detele.UseVisualStyleBackColor = true;
            this.button_Detele.Click += new System.EventHandler(this.button_Detele_Click);
            // 
            // button_Edit
            // 
            this.button_Edit.Enabled = false;
            this.button_Edit.Location = new System.Drawing.Point(629, 108);
            this.button_Edit.Name = "button_Edit";
            this.button_Edit.Size = new System.Drawing.Size(232, 42);
            this.button_Edit.TabIndex = 3;
            this.button_Edit.Text = "Редактировать";
            this.button_Edit.UseVisualStyleBackColor = true;
            this.button_Edit.Click += new System.EventHandler(this.button_Edit_Click);
            // 
            // textBox_EditCountry
            // 
            this.textBox_EditCountry.Location = new System.Drawing.Point(77, 35);
            this.textBox_EditCountry.Name = "textBox_EditCountry";
            this.textBox_EditCountry.Size = new System.Drawing.Size(183, 23);
            this.textBox_EditCountry.TabIndex = 5;
            // 
            // textBox_EditSecondName
            // 
            this.textBox_EditSecondName.Location = new System.Drawing.Point(77, 73);
            this.textBox_EditSecondName.Name = "textBox_EditSecondName";
            this.textBox_EditSecondName.Size = new System.Drawing.Size(183, 23);
            this.textBox_EditSecondName.TabIndex = 6;
            // 
            // textBox_EditRank
            // 
            this.textBox_EditRank.Location = new System.Drawing.Point(77, 111);
            this.textBox_EditRank.Name = "textBox_EditRank";
            this.textBox_EditRank.Size = new System.Drawing.Size(183, 23);
            this.textBox_EditRank.TabIndex = 7;
            // 
            // textBox_EditRating
            // 
            this.textBox_EditRating.Location = new System.Drawing.Point(77, 149);
            this.textBox_EditRating.Name = "textBox_EditRating";
            this.textBox_EditRating.Size = new System.Drawing.Size(183, 23);
            this.textBox_EditRating.TabIndex = 8;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(14, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(46, 15);
            this.label1.TabIndex = 9;
            this.label1.Text = "Страна";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(14, 81);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(58, 15);
            this.label2.TabIndex = 10;
            this.label2.Text = "Фамилия";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(14, 119);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(46, 15);
            this.label3.TabIndex = 11;
            this.label3.Text = "Звание";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(14, 157);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(51, 15);
            this.label4.TabIndex = 12;
            this.label4.Text = "Рейтинг";
            // 
            // button_EditClear
            // 
            this.button_EditClear.Location = new System.Drawing.Point(14, 204);
            this.button_EditClear.Name = "button_EditClear";
            this.button_EditClear.Size = new System.Drawing.Size(121, 42);
            this.button_EditClear.TabIndex = 13;
            this.button_EditClear.Text = "Очистить";
            this.button_EditClear.UseVisualStyleBackColor = true;
            this.button_EditClear.Click += new System.EventHandler(this.button_EditClear_Click);
            // 
            // button_EditSave
            // 
            this.button_EditSave.Location = new System.Drawing.Point(141, 204);
            this.button_EditSave.Name = "button_EditSave";
            this.button_EditSave.Size = new System.Drawing.Size(119, 42);
            this.button_EditSave.TabIndex = 14;
            this.button_EditSave.Text = "Записать";
            this.button_EditSave.UseVisualStyleBackColor = true;
            this.button_EditSave.Click += new System.EventHandler(this.button_EditSave_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.textBox_EditRating);
            this.panel1.Controls.Add(this.button_EditSave);
            this.panel1.Controls.Add(this.textBox_EditCountry);
            this.panel1.Controls.Add(this.button_EditClear);
            this.panel1.Controls.Add(this.textBox_EditSecondName);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.textBox_EditRank);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Enabled = false;
            this.panel1.Location = new System.Drawing.Point(12, 282);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(285, 258);
            this.panel1.TabIndex = 15;
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(104, 11);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(87, 15);
            this.label9.TabIndex = 15;
            this.label9.Text = "Редактировать";
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.label10);
            this.panel2.Controls.Add(this.textBox_AddRating);
            this.panel2.Controls.Add(this.button_AddSave);
            this.panel2.Controls.Add(this.textBox_AddCountry);
            this.panel2.Controls.Add(this.button_AddClear);
            this.panel2.Controls.Add(this.textBox_AddSecondName);
            this.panel2.Controls.Add(this.label5);
            this.panel2.Controls.Add(this.textBox_AddRank);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.label8);
            this.panel2.Enabled = false;
            this.panel2.Location = new System.Drawing.Point(338, 282);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(285, 258);
            this.panel2.TabIndex = 16;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Location = new System.Drawing.Point(121, 11);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(59, 15);
            this.label10.TabIndex = 16;
            this.label10.Text = "Добавить";
            // 
            // textBox_AddRating
            // 
            this.textBox_AddRating.Location = new System.Drawing.Point(77, 149);
            this.textBox_AddRating.Name = "textBox_AddRating";
            this.textBox_AddRating.Size = new System.Drawing.Size(183, 23);
            this.textBox_AddRating.TabIndex = 8;
            // 
            // button_AddSave
            // 
            this.button_AddSave.Location = new System.Drawing.Point(141, 204);
            this.button_AddSave.Name = "button_AddSave";
            this.button_AddSave.Size = new System.Drawing.Size(119, 42);
            this.button_AddSave.TabIndex = 14;
            this.button_AddSave.Text = "Сохранить";
            this.button_AddSave.UseVisualStyleBackColor = true;
            this.button_AddSave.Click += new System.EventHandler(this.button_AddSave_Click);
            // 
            // textBox_AddCountry
            // 
            this.textBox_AddCountry.Location = new System.Drawing.Point(77, 35);
            this.textBox_AddCountry.Name = "textBox_AddCountry";
            this.textBox_AddCountry.Size = new System.Drawing.Size(183, 23);
            this.textBox_AddCountry.TabIndex = 5;
            // 
            // button_AddClear
            // 
            this.button_AddClear.Location = new System.Drawing.Point(14, 204);
            this.button_AddClear.Name = "button_AddClear";
            this.button_AddClear.Size = new System.Drawing.Size(121, 42);
            this.button_AddClear.TabIndex = 13;
            this.button_AddClear.Text = "Очистить";
            this.button_AddClear.UseVisualStyleBackColor = true;
            this.button_AddClear.Click += new System.EventHandler(this.button_AddClear_Click);
            // 
            // textBox_AddSecondName
            // 
            this.textBox_AddSecondName.Location = new System.Drawing.Point(77, 73);
            this.textBox_AddSecondName.Name = "textBox_AddSecondName";
            this.textBox_AddSecondName.Size = new System.Drawing.Size(183, 23);
            this.textBox_AddSecondName.TabIndex = 6;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(14, 157);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(51, 15);
            this.label5.TabIndex = 12;
            this.label5.Text = "Рейтинг";
            // 
            // textBox_AddRank
            // 
            this.textBox_AddRank.Location = new System.Drawing.Point(77, 111);
            this.textBox_AddRank.Name = "textBox_AddRank";
            this.textBox_AddRank.Size = new System.Drawing.Size(183, 23);
            this.textBox_AddRank.TabIndex = 7;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(14, 119);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(46, 15);
            this.label6.TabIndex = 11;
            this.label6.Text = "Звание";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(14, 43);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(46, 15);
            this.label7.TabIndex = 9;
            this.label7.Text = "Страна";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(14, 81);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(58, 15);
            this.label8.TabIndex = 10;
            this.label8.Text = "Фамилия";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(7F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(870, 552);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.button_Edit);
            this.Controls.Add(this.button_Detele);
            this.Controls.Add(this.dataGridView1);
            this.Controls.Add(this.button_Create);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private Button button_Create;
        private DataGridView dataGridView1;
        private Button button_Detele;
        private Button button_Edit;
        private TextBox textBox_EditCountry;
        private TextBox textBox_EditSecondName;
        private TextBox textBox_EditRank;
        private TextBox textBox_EditRating;
        private Label label1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Button button_EditClear;
        private Button button_EditSave;
        private Panel panel1;
        private Label label9;
        private Panel panel2;
        private Label label10;
        private TextBox textBox_AddRating;
        private Button button_AddSave;
        private TextBox textBox_AddCountry;
        private Button button_AddClear;
        private TextBox textBox_AddSecondName;
        private Label label5;
        private TextBox textBox_AddRank;
        private Label label6;
        private Label label7;
        private Label label8;
    }
}