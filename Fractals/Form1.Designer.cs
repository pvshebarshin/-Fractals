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
            this.components = new System.ComponentModel.Container();
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
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.menuStrip2 = new System.Windows.Forms.MenuStrip();
            this.fileToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.saveToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.vScrollBar = new System.Windows.Forms.VScrollBar();
            this.hScrollBar = new System.Windows.Forms.HScrollBar();
            this.buttonx0y0 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).BeginInit();
            this.menuStrip2.SuspendLayout();
            this.SuspendLayout();
            // 
            // MainButton
            // 
            this.MainButton.Location = new System.Drawing.Point(990, 839);
            this.MainButton.Name = "MainButton";
            this.MainButton.Size = new System.Drawing.Size(112, 39);
            this.MainButton.TabIndex = 0;
            this.MainButton.Text = "Draw";
            this.MainButton.UseVisualStyleBackColor = true;
            this.MainButton.Click += new System.EventHandler(this.MainButton_Click);
            // 
            // trackBar
            // 
            this.trackBar.Location = new System.Drawing.Point(990, 518);
            this.trackBar.Minimum = 1;
            this.trackBar.Name = "trackBar";
            this.trackBar.Orientation = System.Windows.Forms.Orientation.Vertical;
            this.trackBar.Size = new System.Drawing.Size(69, 315);
            this.trackBar.TabIndex = 1;
            this.trackBar.TickStyle = System.Windows.Forms.TickStyle.Both;
            this.trackBar.Value = 1;
            this.trackBar.Scroll += new System.EventHandler(this.trackBar_Scroll);
            // 
            // labelDegree
            // 
            this.labelDegree.AutoSize = true;
            this.labelDegree.Location = new System.Drawing.Point(990, 500);
            this.labelDegree.Name = "labelDegree";
            this.labelDegree.Size = new System.Drawing.Size(79, 20);
            this.labelDegree.TabIndex = 2;
            this.labelDegree.Text = "Degree: 1";
            // 
            // pictureBox
            // 
            this.pictureBox.Location = new System.Drawing.Point(12, 46);
            this.pictureBox.Name = "pictureBox";
            this.pictureBox.Size = new System.Drawing.Size(852, 839);
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
            this.comboBox.Location = new System.Drawing.Point(991, 368);
            this.comboBox.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.comboBox.Name = "comboBox";
            this.comboBox.Size = new System.Drawing.Size(212, 28);
            this.comboBox.TabIndex = 4;
            this.comboBox.SelectedIndexChanged += new System.EventHandler(this.comboBox_SelectedIndexChanged);
            this.comboBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.comboBox_KeyPress);
            // 
            // colorButtonBegin
            // 
            this.colorButtonBegin.Location = new System.Drawing.Point(990, 404);
            this.colorButtonBegin.Name = "colorButtonBegin";
            this.colorButtonBegin.Size = new System.Drawing.Size(162, 45);
            this.colorButtonBegin.TabIndex = 5;
            this.colorButtonBegin.Text = "Initial iteration color";
            this.colorButtonBegin.UseVisualStyleBackColor = true;
            this.colorButtonBegin.Click += new System.EventHandler(this.colorButtonBegin_Click);
            // 
            // colorButtonEnd
            // 
            this.colorButtonEnd.Location = new System.Drawing.Point(990, 455);
            this.colorButtonEnd.Name = "colorButtonEnd";
            this.colorButtonEnd.Size = new System.Drawing.Size(162, 42);
            this.colorButtonEnd.TabIndex = 6;
            this.colorButtonEnd.Text = "Last iteration color";
            this.colorButtonEnd.UseVisualStyleBackColor = true;
            this.colorButtonEnd.Click += new System.EventHandler(this.colorButtonEnd_Click);
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(61, 4);
            // 
            // menuStrip2
            // 
            this.menuStrip2.GripMargin = new System.Windows.Forms.Padding(2, 2, 0, 2);
            this.menuStrip2.ImageScalingSize = new System.Drawing.Size(24, 24);
            this.menuStrip2.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.fileToolStripMenuItem});
            this.menuStrip2.Location = new System.Drawing.Point(0, 0);
            this.menuStrip2.Name = "menuStrip2";
            this.menuStrip2.Size = new System.Drawing.Size(1293, 33);
            this.menuStrip2.TabIndex = 9;
            this.menuStrip2.Text = "menuStrip2";
            // 
            // fileToolStripMenuItem
            // 
            this.fileToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.saveToolStripMenuItem});
            this.fileToolStripMenuItem.Name = "fileToolStripMenuItem";
            this.fileToolStripMenuItem.Size = new System.Drawing.Size(54, 29);
            this.fileToolStripMenuItem.Text = "File";
            // 
            // saveToolStripMenuItem
            // 
            this.saveToolStripMenuItem.Name = "saveToolStripMenuItem";
            this.saveToolStripMenuItem.Size = new System.Drawing.Size(151, 34);
            this.saveToolStripMenuItem.Text = "Save";
            this.saveToolStripMenuItem.Click += new System.EventHandler(this.saveToolStripMenuItem_Click);
            // 
            // vScrollBar
            // 
            this.vScrollBar.Location = new System.Drawing.Point(867, 43);
            this.vScrollBar.Name = "vScrollBar";
            this.vScrollBar.Size = new System.Drawing.Size(20, 842);
            this.vScrollBar.TabIndex = 10;
            this.vScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.vScrollBar_Scroll);
            // 
            // hScrollBar
            // 
            this.hScrollBar.Location = new System.Drawing.Point(12, 888);
            this.hScrollBar.Name = "hScrollBar";
            this.hScrollBar.Size = new System.Drawing.Size(855, 20);
            this.hScrollBar.TabIndex = 11;
            this.hScrollBar.Scroll += new System.Windows.Forms.ScrollEventHandler(this.hScrollBar_Scroll);
            // 
            // buttonx0y0
            // 
            this.buttonx0y0.Location = new System.Drawing.Point(1005, 303);
            this.buttonx0y0.Name = "buttonx0y0";
            this.buttonx0y0.Size = new System.Drawing.Size(97, 34);
            this.buttonx0y0.TabIndex = 12;
            this.buttonx0y0.Text = "Default XY";
            this.buttonx0y0.UseVisualStyleBackColor = true;
            this.buttonx0y0.Click += new System.EventHandler(this.buttonx0y0_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(1293, 919);
            this.Controls.Add(this.buttonx0y0);
            this.Controls.Add(this.hScrollBar);
            this.Controls.Add(this.vScrollBar);
            this.Controls.Add(this.colorButtonEnd);
            this.Controls.Add(this.colorButtonBegin);
            this.Controls.Add(this.comboBox);
            this.Controls.Add(this.pictureBox);
            this.Controls.Add(this.labelDegree);
            this.Controls.Add(this.trackBar);
            this.Controls.Add(this.MainButton);
            this.Controls.Add(this.menuStrip2);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "Form1";
            this.Text = "Fractals";
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.trackBar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox)).EndInit();
            this.menuStrip2.ResumeLayout(false);
            this.menuStrip2.PerformLayout();
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
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.MenuStrip menuStrip2;
        private System.Windows.Forms.ToolStripMenuItem fileToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem saveToolStripMenuItem;
        private System.Windows.Forms.VScrollBar vScrollBar;
        private System.Windows.Forms.HScrollBar hScrollBar;
        private System.Windows.Forms.Button buttonx0y0;
    }
}

