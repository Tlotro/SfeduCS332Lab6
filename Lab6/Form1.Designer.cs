namespace Lab6
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
            this.Selector = new System.Windows.Forms.ComboBox();
            this.SpawnPanel = new System.Windows.Forms.Panel();
            this.SpawnZLabel = new System.Windows.Forms.Label();
            this.SpawnYLabel = new System.Windows.Forms.Label();
            this.SpawnXLabel = new System.Windows.Forms.Label();
            this.SpawnSelector = new System.Windows.Forms.ComboBox();
            this.SpawnZBox = new System.Windows.Forms.TextBox();
            this.SpawnYBox = new System.Windows.Forms.TextBox();
            this.SpawnXBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotatePanel = new System.Windows.Forms.Panel();
            this.RotateButton = new System.Windows.Forms.Button();
            this.RotateSelectDropdown = new System.Windows.Forms.ComboBox();
            this.RotatePoint1Label = new System.Windows.Forms.Label();
            this.RotatePoint1XLabel = new System.Windows.Forms.Label();
            this.RotatePoint1XBox = new System.Windows.Forms.TextBox();
            this.RotatePoint1YLabel = new System.Windows.Forms.Label();
            this.RotatePoint1YBox = new System.Windows.Forms.TextBox();
            this.RotatePoint1ZLabel = new System.Windows.Forms.Label();
            this.RotatePoint1ZBox = new System.Windows.Forms.TextBox();
            this.RotatePoint2Label = new System.Windows.Forms.Label();
            this.RotatePoint2XLabel = new System.Windows.Forms.Label();
            this.RotatePoint2XBox = new System.Windows.Forms.TextBox();
            this.RotatePoint2YLabel = new System.Windows.Forms.Label();
            this.RotatePoint2YBox = new System.Windows.Forms.TextBox();
            this.RotatePoint2ZLabel = new System.Windows.Forms.Label();
            this.RotatePoint2ZBox = new System.Windows.Forms.TextBox();
            this.PerspectivePanel = new System.Windows.Forms.Panel();
            this.PerspectiveBox = new System.Windows.Forms.ComboBox();
            this.SpawnPanel.SuspendLayout();
            this.RotatePanel.SuspendLayout();
            this.PerspectivePanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // Selector
            // 
            this.Selector.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.Selector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.Selector.FormattingEnabled = true;
            this.Selector.Items.AddRange(new object[] {
            "Создать",
            "Преобразовать",
            "Изменить",
            "Отразить",
            "Поворот вокруг прямой",
            "Изменить проекцию"});
            this.Selector.Location = new System.Drawing.Point(667, 12);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(121, 21);
            this.Selector.TabIndex = 0;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // SpawnPanel
            // 
            this.SpawnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpawnPanel.Controls.Add(this.SpawnZLabel);
            this.SpawnPanel.Controls.Add(this.SpawnYLabel);
            this.SpawnPanel.Controls.Add(this.SpawnXLabel);
            this.SpawnPanel.Controls.Add(this.SpawnSelector);
            this.SpawnPanel.Controls.Add(this.SpawnZBox);
            this.SpawnPanel.Controls.Add(this.SpawnYBox);
            this.SpawnPanel.Controls.Add(this.SpawnXBox);
            this.SpawnPanel.Location = new System.Drawing.Point(667, 39);
            this.SpawnPanel.Name = "SpawnPanel";
            this.SpawnPanel.Size = new System.Drawing.Size(121, 399);
            this.SpawnPanel.TabIndex = 1;
            this.SpawnPanel.Visible = false;
            // 
            // SpawnZLabel
            // 
            this.SpawnZLabel.AutoSize = true;
            this.SpawnZLabel.Location = new System.Drawing.Point(3, 81);
            this.SpawnZLabel.Name = "SpawnZLabel";
            this.SpawnZLabel.Size = new System.Drawing.Size(14, 13);
            this.SpawnZLabel.TabIndex = 6;
            this.SpawnZLabel.Text = "Z";
            // 
            // SpawnYLabel
            // 
            this.SpawnYLabel.AutoSize = true;
            this.SpawnYLabel.Location = new System.Drawing.Point(3, 55);
            this.SpawnYLabel.Name = "SpawnYLabel";
            this.SpawnYLabel.Size = new System.Drawing.Size(14, 13);
            this.SpawnYLabel.TabIndex = 5;
            this.SpawnYLabel.Text = "Y";
            // 
            // SpawnXLabel
            // 
            this.SpawnXLabel.AutoSize = true;
            this.SpawnXLabel.Location = new System.Drawing.Point(3, 29);
            this.SpawnXLabel.Name = "SpawnXLabel";
            this.SpawnXLabel.Size = new System.Drawing.Size(14, 13);
            this.SpawnXLabel.TabIndex = 4;
            this.SpawnXLabel.Text = "X";
            // 
            // SpawnSelector
            // 
            this.SpawnSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SpawnSelector.FormattingEnabled = true;
            this.SpawnSelector.Items.AddRange(new object[] {
            "Тетраэдр",
            "Гексаэдр",
            "Октаэдр",
            "Икосаэдр",
            "Додекаэдр"});
            this.SpawnSelector.Location = new System.Drawing.Point(0, 0);
            this.SpawnSelector.Name = "SpawnSelector";
            this.SpawnSelector.Size = new System.Drawing.Size(121, 21);
            this.SpawnSelector.TabIndex = 0;
            // 
            // SpawnZBox
            // 
            this.SpawnZBox.Location = new System.Drawing.Point(20, 78);
            this.SpawnZBox.Name = "SpawnZBox";
            this.SpawnZBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnZBox.TabIndex = 3;
            // 
            // SpawnYBox
            // 
            this.SpawnYBox.Location = new System.Drawing.Point(20, 52);
            this.SpawnYBox.Name = "SpawnYBox";
            this.SpawnYBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnYBox.TabIndex = 2;
            // 
            // SpawnXBox
            // 
            this.SpawnXBox.Location = new System.Drawing.Point(20, 26);
            this.SpawnXBox.Name = "SpawnXBox";
            this.SpawnXBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnXBox.TabIndex = 1;
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackColor = System.Drawing.Color.Transparent;
            this.panel1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.panel1.Location = new System.Drawing.Point(12, 12);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(649, 426);
            this.panel1.TabIndex = 2;
            // 
            // RotatePanel
            // 
            this.RotatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotatePanel.Controls.Add(this.RotateButton);
            this.RotatePanel.Controls.Add(this.RotateSelectDropdown);
            this.RotatePanel.Controls.Add(this.RotatePoint1Label);
            this.RotatePanel.Controls.Add(this.RotatePoint1XLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint1XBox);
            this.RotatePanel.Controls.Add(this.RotatePoint1YLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint1YBox);
            this.RotatePanel.Controls.Add(this.RotatePoint1ZLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint1ZBox);
            this.RotatePanel.Controls.Add(this.RotatePoint2Label);
            this.RotatePanel.Controls.Add(this.RotatePoint2XLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint2XBox);
            this.RotatePanel.Controls.Add(this.RotatePoint2YLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint2YBox);
            this.RotatePanel.Controls.Add(this.RotatePoint2ZLabel);
            this.RotatePanel.Controls.Add(this.RotatePoint2ZBox);
            this.RotatePanel.Location = new System.Drawing.Point(667, 39);
            this.RotatePanel.Name = "RotatePanel";
            this.RotatePanel.Size = new System.Drawing.Size(121, 399);
            this.RotatePanel.TabIndex = 7;
            this.RotatePanel.Visible = false;
            // 
            // RotateButton
            // 
            this.RotateButton.Location = new System.Drawing.Point(40, 218);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 23);
            this.RotateButton.TabIndex = 15;
            this.RotateButton.Text = "Повернуть";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // RotateSelectDropdown
            // 
            this.RotateSelectDropdown.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.RotateSelectDropdown.FormattingEnabled = true;
            this.RotateSelectDropdown.Location = new System.Drawing.Point(0, 0);
            this.RotateSelectDropdown.Name = "RotateSelectDropdown";
            this.RotateSelectDropdown.Size = new System.Drawing.Size(121, 21);
            this.RotateSelectDropdown.TabIndex = 0;
            this.RotateSelectDropdown.SelectedIndexChanged += new System.EventHandler(this.RotateSelectDropdown_SelectedIndexChanged);
            // 
            // RotatePoint1Label
            // 
            this.RotatePoint1Label.AutoSize = true;
            this.RotatePoint1Label.Location = new System.Drawing.Point(70, 29);
            this.RotatePoint1Label.Name = "RotatePoint1Label";
            this.RotatePoint1Label.Size = new System.Drawing.Size(46, 13);
            this.RotatePoint1Label.TabIndex = 7;
            this.RotatePoint1Label.Text = "Точка 1";
            // 
            // RotatePoint1XLabel
            // 
            this.RotatePoint1XLabel.AutoSize = true;
            this.RotatePoint1XLabel.Location = new System.Drawing.Point(3, 103);
            this.RotatePoint1XLabel.Name = "RotatePoint1XLabel";
            this.RotatePoint1XLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint1XLabel.TabIndex = 6;
            this.RotatePoint1XLabel.Text = "Z";
            // 
            // RotatePoint1XBox
            // 
            this.RotatePoint1XBox.Location = new System.Drawing.Point(20, 48);
            this.RotatePoint1XBox.Name = "RotatePoint1XBox";
            this.RotatePoint1XBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint1XBox.TabIndex = 3;
            // 
            // RotatePoint1YLabel
            // 
            this.RotatePoint1YLabel.AutoSize = true;
            this.RotatePoint1YLabel.Location = new System.Drawing.Point(3, 77);
            this.RotatePoint1YLabel.Name = "RotatePoint1YLabel";
            this.RotatePoint1YLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint1YLabel.TabIndex = 5;
            this.RotatePoint1YLabel.Text = "Y";
            // 
            // RotatePoint1YBox
            // 
            this.RotatePoint1YBox.Location = new System.Drawing.Point(20, 74);
            this.RotatePoint1YBox.Name = "RotatePoint1YBox";
            this.RotatePoint1YBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint1YBox.TabIndex = 2;
            // 
            // RotatePoint1ZLabel
            // 
            this.RotatePoint1ZLabel.AutoSize = true;
            this.RotatePoint1ZLabel.Location = new System.Drawing.Point(3, 51);
            this.RotatePoint1ZLabel.Name = "RotatePoint1ZLabel";
            this.RotatePoint1ZLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint1ZLabel.TabIndex = 4;
            this.RotatePoint1ZLabel.Text = "X";
            // 
            // RotatePoint1ZBox
            // 
            this.RotatePoint1ZBox.Location = new System.Drawing.Point(20, 100);
            this.RotatePoint1ZBox.Name = "RotatePoint1ZBox";
            this.RotatePoint1ZBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint1ZBox.TabIndex = 1;
            // 
            // RotatePoint2Label
            // 
            this.RotatePoint2Label.AutoSize = true;
            this.RotatePoint2Label.Location = new System.Drawing.Point(70, 123);
            this.RotatePoint2Label.Name = "RotatePoint2Label";
            this.RotatePoint2Label.Size = new System.Drawing.Size(46, 13);
            this.RotatePoint2Label.TabIndex = 8;
            this.RotatePoint2Label.Text = "Точка 2";
            // 
            // RotatePoint2XLabel
            // 
            this.RotatePoint2XLabel.AutoSize = true;
            this.RotatePoint2XLabel.Location = new System.Drawing.Point(3, 142);
            this.RotatePoint2XLabel.Name = "RotatePoint2XLabel";
            this.RotatePoint2XLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint2XLabel.TabIndex = 12;
            this.RotatePoint2XLabel.Text = "X";
            // 
            // RotatePoint2XBox
            // 
            this.RotatePoint2XBox.Location = new System.Drawing.Point(20, 139);
            this.RotatePoint2XBox.Name = "RotatePoint2XBox";
            this.RotatePoint2XBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint2XBox.TabIndex = 9;
            // 
            // RotatePoint2YLabel
            // 
            this.RotatePoint2YLabel.AutoSize = true;
            this.RotatePoint2YLabel.Location = new System.Drawing.Point(3, 168);
            this.RotatePoint2YLabel.Name = "RotatePoint2YLabel";
            this.RotatePoint2YLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint2YLabel.TabIndex = 13;
            this.RotatePoint2YLabel.Text = "Y";
            // 
            // RotatePoint2YBox
            // 
            this.RotatePoint2YBox.Location = new System.Drawing.Point(20, 165);
            this.RotatePoint2YBox.Name = "RotatePoint2YBox";
            this.RotatePoint2YBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint2YBox.TabIndex = 10;
            // 
            // RotatePoint2ZLabel
            // 
            this.RotatePoint2ZLabel.AutoSize = true;
            this.RotatePoint2ZLabel.Location = new System.Drawing.Point(3, 194);
            this.RotatePoint2ZLabel.Name = "RotatePoint2ZLabel";
            this.RotatePoint2ZLabel.Size = new System.Drawing.Size(14, 13);
            this.RotatePoint2ZLabel.TabIndex = 14;
            this.RotatePoint2ZLabel.Text = "Z";
            // 
            // RotatePoint2ZBox
            // 
            this.RotatePoint2ZBox.Location = new System.Drawing.Point(20, 191);
            this.RotatePoint2ZBox.Name = "RotatePoint2ZBox";
            this.RotatePoint2ZBox.Size = new System.Drawing.Size(96, 20);
            this.RotatePoint2ZBox.TabIndex = 11;
            // 
            // PerspectivePanel
            // 
            this.PerspectivePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.PerspectivePanel.Controls.Add(this.PerspectiveBox);
            this.PerspectivePanel.Location = new System.Drawing.Point(667, 39);
            this.PerspectivePanel.Name = "PerspectivePanel";
            this.PerspectivePanel.Size = new System.Drawing.Size(121, 399);
            this.PerspectivePanel.TabIndex = 16;
            this.PerspectivePanel.Visible = false;
            // 
            // PerspectiveBox
            // 
            this.PerspectiveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.PerspectiveBox.FormattingEnabled = true;
            this.PerspectiveBox.Location = new System.Drawing.Point(0, 0);
            this.PerspectiveBox.Name = "PerspectiveBox";
            this.PerspectiveBox.Size = new System.Drawing.Size(121, 21);
            this.PerspectiveBox.TabIndex = 0;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.PerspectivePanel);
            this.Controls.Add(this.RotatePanel);
            this.Controls.Add(this.SpawnPanel);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Selector);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Shown += new System.EventHandler(this.Form1_Shown);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyDown);
            this.KeyUp += new System.Windows.Forms.KeyEventHandler(this.Form1_KeyUp);
            this.SpawnPanel.ResumeLayout(false);
            this.SpawnPanel.PerformLayout();
            this.RotatePanel.ResumeLayout(false);
            this.RotatePanel.PerformLayout();
            this.PerspectivePanel.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.ComboBox Selector;
        private System.Windows.Forms.Panel SpawnPanel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ComboBox SpawnSelector;
        private System.Windows.Forms.Label SpawnYLabel;
        private System.Windows.Forms.Label SpawnXLabel;
        private System.Windows.Forms.TextBox SpawnZBox;
        private System.Windows.Forms.TextBox SpawnYBox;
        private System.Windows.Forms.TextBox SpawnXBox;
        private System.Windows.Forms.Label SpawnZLabel;
        private System.Windows.Forms.Panel RotatePanel;
        private System.Windows.Forms.Label RotatePoint1Label;
        private System.Windows.Forms.Label RotatePoint1XLabel;
        private System.Windows.Forms.Label RotatePoint1YLabel;
        private System.Windows.Forms.Label RotatePoint1ZLabel;
        private System.Windows.Forms.ComboBox RotateSelectDropdown;
        private System.Windows.Forms.TextBox RotatePoint1XBox;
        private System.Windows.Forms.TextBox RotatePoint1YBox;
        private System.Windows.Forms.TextBox RotatePoint1ZBox;
        private System.Windows.Forms.Label RotatePoint2ZLabel;
        private System.Windows.Forms.Label RotatePoint2YLabel;
        private System.Windows.Forms.Label RotatePoint2XLabel;
        private System.Windows.Forms.TextBox RotatePoint2ZBox;
        private System.Windows.Forms.TextBox RotatePoint2YBox;
        private System.Windows.Forms.TextBox RotatePoint2XBox;
        private System.Windows.Forms.Label RotatePoint2Label;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Panel PerspectivePanel;
        private System.Windows.Forms.ComboBox PerspectiveBox;
    }
}

