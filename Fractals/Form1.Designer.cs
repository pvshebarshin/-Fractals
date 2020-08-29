namespace Fractals
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.MainButton = new System.Windows.Forms.Button();
            this.trackBar = new System.Windows.Forms.TrackBar();
            this.labelDegree = new System.Windows.Forms.Label();
            this.pictureBox = new System.Windows.Forms.PictureBox();
            this.comboBox = new System.Windows.Forms.ComboBox();
            this.colorDialogBegin = new System.Windows.Forms.ColorDialog();
            this.colorButtonBegin = new System.Windows.Forms.Button();
            this.colorDialogEnd = new System.Windows.Forms.ColorDialog();
            this.colorButtonEnd = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(778, 541);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(75, 30);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Draw";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(681, 466);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Size = new System.Drawing.Size(315, 69);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.None;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(774, 443);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(79, 20);
            this.labelDegree.TabIndex = 2;
            this.labelDegree.Text = "Degree: 1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 12);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(600, 600);
            this.pictureBox.TabIndex = 3;
            this.pictureBox.TabStop = false;
            // 
            // comboBox
            // 
            this.comboBox.FormattingEnabled = true;
            this.comboBox.Items.AddRange(new object[] {
            "Фрактал \"Центр масс треугольника\"",
            "Снежинка Коха",
            "Кривая Гильберта",
            "Кривая Госпера",
            "Треугольник Серпинского",
            "Ковер Серпинского",
            "Фрактал \"Квазиклевер\"",
            "Множество Кантора",
            "Т-Фрактал",
            "Н-фрактал",
            "Вложенные спиральные квадраты"});
            this.comboBox.Location = new System.Drawing.Point(681, 236);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(212, 28);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            // 
            // colorButtonBegin
            // 
            this.colorButtonBegin.Location = new System.Drawing.Point(691, 121);
            this.colorButtonBegin.Name = "colorButtonBegin";
            this.colorButtonBegin.Size = new System.Drawing.Size(162, 44);
            this.colorButtonBegin.TabIndex = 5;
            this.colorButtonBegin.Text = "Initial iteration color";
            this.colorButtonBegin.UseVisualStyleBackColor = true;
            this.colorButtonBegin.Click += new System.EventHandler(this.colorButtonBegin_Click);
            // 
            // colorButtonEnd
            // 
            this.colorButtonEnd.Location = new System.Drawing.Point(691, 171);
            this.colorButtonEnd.Name = "colorButtonEnd";
            this.colorButtonEnd.Size = new System.Drawing.Size(162, 42);
            this.colorButtonEnd.TabIndex = 6;
            this.colorButtonEnd.Text = "Last iteration color";
            this.colorButtonEnd.UseVisualStyleBackColor = true;
            this.colorButtonEnd.Click += new System.EventHandler(this.colorButtonEnd_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1102, 685);
            this.Controls.Add(this.colorButtonEnd);
            this.Controls.Add(this.colorButtonBegin);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.MainButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button MainButton;
        private System.Windows.Forms.TrackBar trackBar;
        private System.Windows.Forms.Label labelDegree;
        private System.Windows.Forms.PictureBox pictureBox;
        private System.Windows.Forms.ComboBox comboBox;
        private System.Windows.Forms.ColorDialog colorDialogBegin;
        private System.Windows.Forms.Button colorButtonBegin;
        private System.Windows.Forms.ColorDialog colorDialogEnd;
        private System.Windows.Forms.Button colorButtonEnd;
    }
}

