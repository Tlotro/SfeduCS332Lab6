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
            this.SpawnButton = new System.Windows.Forms.Button();
            this.SpawnZLabel = new System.Windows.Forms.Label();
            this.SpawnYLabel = new System.Windows.Forms.Label();
            this.SpawnXLabel = new System.Windows.Forms.Label();
            this.SpawnSizeLabel = new System.Windows.Forms.Label();
            this.SpawnSelector = new System.Windows.Forms.ComboBox();
            this.SpawnZBox = new System.Windows.Forms.TextBox();
            this.SpawnYBox = new System.Windows.Forms.TextBox();
            this.SpawnXBox = new System.Windows.Forms.TextBox();
            this.SpawnSizeBox = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.RotatePanel = new System.Windows.Forms.Panel();
            this.RotateButton = new System.Windows.Forms.Button();
            this.RotateDeg = new System.Windows.Forms.Label();
            this.RotateDegBox = new System.Windows.Forms.TextBox();
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
            this.DespawnPanel = new System.Windows.Forms.Panel();
            this.DespawnButton = new System.Windows.Forms.Button();
            this.DespawnSelector = new System.Windows.Forms.ComboBox();
            this.TransformPanel = new System.Windows.Forms.Panel();
            this.ScaleLabel = new System.Windows.Forms.Label();
            this.ScaleZLabel = new System.Windows.Forms.Label();
            this.ScaleYLabel = new System.Windows.Forms.Label();
            this.ScaleXLabel = new System.Windows.Forms.Label();
            this.ScaleZ = new System.Windows.Forms.TextBox();
            this.ScaleY = new System.Windows.Forms.TextBox();
            this.ScaleX = new System.Windows.Forms.TextBox();
            this.RotationLabel = new System.Windows.Forms.Label();
            this.RotationZLabel = new System.Windows.Forms.Label();
            this.RotationYLabel = new System.Windows.Forms.Label();
            this.RotationXLabel = new System.Windows.Forms.Label();
            this.RotationZ = new System.Windows.Forms.TextBox();
            this.RotationY = new System.Windows.Forms.TextBox();
            this.RotationX = new System.Windows.Forms.TextBox();
            this.PositionLabel = new System.Windows.Forms.Label();
            this.PositionZLabel = new System.Windows.Forms.Label();
            this.PositionYLabel = new System.Windows.Forms.Label();
            this.PositionXLabel = new System.Windows.Forms.Label();
            this.PositionZ = new System.Windows.Forms.TextBox();
            this.PositionY = new System.Windows.Forms.TextBox();
            this.PositionX = new System.Windows.Forms.TextBox();
            this.TransformSelector = new System.Windows.Forms.ComboBox();
            this.EditPanel = new System.Windows.Forms.Panel();
            this.EditButton = new System.Windows.Forms.Button();
            this.EditPolySelector = new System.Windows.Forms.ComboBox();
            this.EditOpSelector = new System.Windows.Forms.ComboBox();
            this.EditZLabel = new System.Windows.Forms.Label();
            this.EditX = new System.Windows.Forms.TextBox();
            this.EditYLabel = new System.Windows.Forms.Label();
            this.EditY = new System.Windows.Forms.TextBox();
            this.EditXLabel = new System.Windows.Forms.Label();
            this.EditZ = new System.Windows.Forms.TextBox();
            this.MirrorPanel = new System.Windows.Forms.Panel();
            this.MirrorButton = new System.Windows.Forms.Button();
            this.MirrorPolySelector = new System.Windows.Forms.ComboBox();
            this.MirrorAxisSelector = new System.Windows.Forms.ComboBox();
            this.MirrorPlaneBox = new System.Windows.Forms.TextBox();
            this.openModel = new System.Windows.Forms.OpenFileDialog();
            this.saveModel = new System.Windows.Forms.SaveFileDialog();
            this.SavePanel = new System.Windows.Forms.Panel();
            this.SaveButton = new System.Windows.Forms.Button();
            this.SaveBox = new System.Windows.Forms.ComboBox();
            this.LatheSelectorBox = new System.Windows.Forms.ComboBox();
            this.LatheDivisionsBox = new System.Windows.Forms.TextBox();
            this.LatheDivisionsLabel = new System.Windows.Forms.Label();
            this.LatheButton = new System.Windows.Forms.Button();
            this.LatheAxisBox = new System.Windows.Forms.ComboBox();
            this.LathePanel = new System.Windows.Forms.Panel();
            this.SpawnPanel.SuspendLayout();
            this.RotatePanel.SuspendLayout();
            this.PerspectivePanel.SuspendLayout();
            this.DespawnPanel.SuspendLayout();
            this.TransformPanel.SuspendLayout();
            this.EditPanel.SuspendLayout();
            this.MirrorPanel.SuspendLayout();
            this.SavePanel.SuspendLayout();
            this.LathePanel.SuspendLayout();
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
            "Изменить проекцию",
            "Сохранить",
            "Выточить",
            "Удалить"});
            this.Selector.Location = new System.Drawing.Point(667, 12);
            this.Selector.Name = "Selector";
            this.Selector.Size = new System.Drawing.Size(121, 21);
            this.Selector.TabIndex = 0;
            this.Selector.SelectedIndexChanged += new System.EventHandler(this.Selector_SelectedIndexChanged);
            // 
            // SpawnPanel
            // 
            this.SpawnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SpawnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SpawnPanel.Controls.Add(this.SpawnButton);
            this.SpawnPanel.Controls.Add(this.SpawnZLabel);
            this.SpawnPanel.Controls.Add(this.SpawnYLabel);
            this.SpawnPanel.Controls.Add(this.SpawnXLabel);
            this.SpawnPanel.Controls.Add(this.SpawnSizeLabel);
            this.SpawnPanel.Controls.Add(this.SpawnSelector);
            this.SpawnPanel.Controls.Add(this.SpawnZBox);
            this.SpawnPanel.Controls.Add(this.SpawnYBox);
            this.SpawnPanel.Controls.Add(this.SpawnXBox);
            this.SpawnPanel.Controls.Add(this.SpawnSizeBox);
            this.SpawnPanel.Location = new System.Drawing.Point(667, 39);
            this.SpawnPanel.Name = "SpawnPanel";
            this.SpawnPanel.Size = new System.Drawing.Size(121, 399);
            this.SpawnPanel.TabIndex = 1;
            this.SpawnPanel.Visible = false;
            // 
            // SpawnButton
            // 
            this.SpawnButton.Location = new System.Drawing.Point(40, 130);
            this.SpawnButton.Name = "SpawnButton";
            this.SpawnButton.Size = new System.Drawing.Size(75, 23);
            this.SpawnButton.TabIndex = 7;
            this.SpawnButton.Text = "Создать";
            this.SpawnButton.UseVisualStyleBackColor = true;
            this.SpawnButton.Click += new System.EventHandler(this.SpawnButton_Click);
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
            // SpawnSizeLabel
            // 
            this.SpawnSizeLabel.AutoSize = true;
            this.SpawnSizeLabel.Location = new System.Drawing.Point(3, 107);
            this.SpawnSizeLabel.Name = "SpawnSizeLabel";
            this.SpawnSizeLabel.Size = new System.Drawing.Size(15, 13);
            this.SpawnSizeLabel.TabIndex = 9;
            this.SpawnSizeLabel.Text = "R";
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
            "Додекаэдр",
            "Загрузить"});
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
            this.SpawnZBox.TextChanged += new System.EventHandler(this.Spawn_TextChanged);
            // 
            // SpawnYBox
            // 
            this.SpawnYBox.Location = new System.Drawing.Point(20, 52);
            this.SpawnYBox.Name = "SpawnYBox";
            this.SpawnYBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnYBox.TabIndex = 2;
            this.SpawnYBox.TextChanged += new System.EventHandler(this.Spawn_TextChanged);
            // 
            // SpawnXBox
            // 
            this.SpawnXBox.Location = new System.Drawing.Point(20, 26);
            this.SpawnXBox.Name = "SpawnXBox";
            this.SpawnXBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnXBox.TabIndex = 1;
            this.SpawnXBox.TextChanged += new System.EventHandler(this.Spawn_TextChanged);
            // 
            // SpawnSizeBox
            // 
            this.SpawnSizeBox.Location = new System.Drawing.Point(20, 104);
            this.SpawnSizeBox.Name = "SpawnSizeBox";
            this.SpawnSizeBox.Size = new System.Drawing.Size(96, 20);
            this.SpawnSizeBox.TabIndex = 8;
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
            this.RotatePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.RotatePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.RotatePanel.Controls.Add(this.RotateButton);
            this.RotatePanel.Controls.Add(this.RotateDeg);
            this.RotatePanel.Controls.Add(this.RotateDegBox);
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
            this.RotateButton.Location = new System.Drawing.Point(40, 243);
            this.RotateButton.Name = "RotateButton";
            this.RotateButton.Size = new System.Drawing.Size(75, 23);
            this.RotateButton.TabIndex = 15;
            this.RotateButton.Text = "Повернуть";
            this.RotateButton.UseVisualStyleBackColor = true;
            this.RotateButton.Click += new System.EventHandler(this.RotateButton_Click);
            // 
            // RotateDeg
            // 
            this.RotateDeg.AutoSize = true;
            this.RotateDeg.Location = new System.Drawing.Point(4, 220);
            this.RotateDeg.Name = "RotateDeg";
            this.RotateDeg.Size = new System.Drawing.Size(15, 13);
            this.RotateDeg.TabIndex = 17;
            this.RotateDeg.Text = "D";
            // 
            // RotateDegBox
            // 
            this.RotateDegBox.Location = new System.Drawing.Point(20, 217);
            this.RotateDegBox.Name = "RotateDegBox";
            this.RotateDegBox.Size = new System.Drawing.Size(96, 20);
            this.RotateDegBox.TabIndex = 16;
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
            this.RotatePoint1XBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
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
            this.RotatePoint1YBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
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
            this.RotatePoint1ZBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
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
            this.RotatePoint2XBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
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
            this.RotatePoint2YBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
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
            this.RotatePoint2ZBox.TextChanged += new System.EventHandler(this.RotatePoint_TextChanged);
            // 
            // PerspectivePanel
            // 
            this.PerspectivePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
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
            this.PerspectiveBox.Items.AddRange(new object[] {
            "Аксонометрическая",
            "Перспективная"});
            this.PerspectiveBox.Location = new System.Drawing.Point(0, 0);
            this.PerspectiveBox.Name = "PerspectiveBox";
            this.PerspectiveBox.Size = new System.Drawing.Size(121, 21);
            this.PerspectiveBox.TabIndex = 0;
            this.PerspectiveBox.SelectedIndexChanged += new System.EventHandler(this.PerspectiveBox_SelectedIndexChanged);
            // 
            // DespawnPanel
            // 
            this.DespawnPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.DespawnPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.DespawnPanel.Controls.Add(this.DespawnButton);
            this.DespawnPanel.Controls.Add(this.DespawnSelector);
            this.DespawnPanel.Location = new System.Drawing.Point(667, 39);
            this.DespawnPanel.Name = "DespawnPanel";
            this.DespawnPanel.Size = new System.Drawing.Size(121, 399);
            this.DespawnPanel.TabIndex = 10;
            this.DespawnPanel.Visible = false;
            // 
            // DespawnButton
            // 
            this.DespawnButton.Location = new System.Drawing.Point(40, 26);
            this.DespawnButton.Name = "DespawnButton";
            this.DespawnButton.Size = new System.Drawing.Size(75, 23);
            this.DespawnButton.TabIndex = 7;
            this.DespawnButton.Text = "Удалить";
            this.DespawnButton.UseVisualStyleBackColor = true;
            this.DespawnButton.Click += new System.EventHandler(this.DespawnButton_Click);
            // 
            // DespawnSelector
            // 
            this.DespawnSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.DespawnSelector.FormattingEnabled = true;
            this.DespawnSelector.Items.AddRange(new object[] {
            "Тетраэдр",
            "Гексаэдр",
            "Октаэдр",
            "Икосаэдр",
            "Додекаэдр"});
            this.DespawnSelector.Location = new System.Drawing.Point(0, 0);
            this.DespawnSelector.Name = "DespawnSelector";
            this.DespawnSelector.Size = new System.Drawing.Size(121, 21);
            this.DespawnSelector.TabIndex = 0;
            this.DespawnSelector.SelectedIndexChanged += new System.EventHandler(this.DespawnSelector_SelectedIndexChanged);
            // 
            // TransformPanel
            // 
            this.TransformPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.TransformPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.TransformPanel.Controls.Add(this.ScaleLabel);
            this.TransformPanel.Controls.Add(this.ScaleZLabel);
            this.TransformPanel.Controls.Add(this.ScaleYLabel);
            this.TransformPanel.Controls.Add(this.ScaleXLabel);
            this.TransformPanel.Controls.Add(this.ScaleZ);
            this.TransformPanel.Controls.Add(this.ScaleY);
            this.TransformPanel.Controls.Add(this.ScaleX);
            this.TransformPanel.Controls.Add(this.RotationLabel);
            this.TransformPanel.Controls.Add(this.RotationZLabel);
            this.TransformPanel.Controls.Add(this.RotationYLabel);
            this.TransformPanel.Controls.Add(this.RotationXLabel);
            this.TransformPanel.Controls.Add(this.RotationZ);
            this.TransformPanel.Controls.Add(this.RotationY);
            this.TransformPanel.Controls.Add(this.RotationX);
            this.TransformPanel.Controls.Add(this.PositionLabel);
            this.TransformPanel.Controls.Add(this.PositionZLabel);
            this.TransformPanel.Controls.Add(this.PositionYLabel);
            this.TransformPanel.Controls.Add(this.PositionXLabel);
            this.TransformPanel.Controls.Add(this.PositionZ);
            this.TransformPanel.Controls.Add(this.PositionY);
            this.TransformPanel.Controls.Add(this.PositionX);
            this.TransformPanel.Controls.Add(this.TransformSelector);
            this.TransformPanel.Location = new System.Drawing.Point(667, 39);
            this.TransformPanel.Name = "TransformPanel";
            this.TransformPanel.Size = new System.Drawing.Size(121, 399);
            this.TransformPanel.TabIndex = 17;
            this.TransformPanel.Visible = false;
            // 
            // ScaleLabel
            // 
            this.ScaleLabel.AutoSize = true;
            this.ScaleLabel.Location = new System.Drawing.Point(80, 214);
            this.ScaleLabel.Name = "ScaleLabel";
            this.ScaleLabel.Size = new System.Drawing.Size(34, 13);
            this.ScaleLabel.TabIndex = 16;
            this.ScaleLabel.Text = "Scale";
            // 
            // ScaleZLabel
            // 
            this.ScaleZLabel.AutoSize = true;
            this.ScaleZLabel.Location = new System.Drawing.Point(3, 285);
            this.ScaleZLabel.Name = "ScaleZLabel";
            this.ScaleZLabel.Size = new System.Drawing.Size(14, 13);
            this.ScaleZLabel.TabIndex = 22;
            this.ScaleZLabel.Text = "Z";
            // 
            // ScaleYLabel
            // 
            this.ScaleYLabel.AutoSize = true;
            this.ScaleYLabel.Location = new System.Drawing.Point(3, 259);
            this.ScaleYLabel.Name = "ScaleYLabel";
            this.ScaleYLabel.Size = new System.Drawing.Size(14, 13);
            this.ScaleYLabel.TabIndex = 21;
            this.ScaleYLabel.Text = "Y";
            // 
            // ScaleXLabel
            // 
            this.ScaleXLabel.AutoSize = true;
            this.ScaleXLabel.Location = new System.Drawing.Point(3, 233);
            this.ScaleXLabel.Name = "ScaleXLabel";
            this.ScaleXLabel.Size = new System.Drawing.Size(14, 13);
            this.ScaleXLabel.TabIndex = 20;
            this.ScaleXLabel.Text = "X";
            // 
            // ScaleZ
            // 
            this.ScaleZ.Location = new System.Drawing.Point(20, 282);
            this.ScaleZ.Name = "ScaleZ";
            this.ScaleZ.Size = new System.Drawing.Size(96, 20);
            this.ScaleZ.TabIndex = 19;
            this.ScaleZ.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // ScaleY
            // 
            this.ScaleY.Location = new System.Drawing.Point(20, 256);
            this.ScaleY.Name = "ScaleY";
            this.ScaleY.Size = new System.Drawing.Size(96, 20);
            this.ScaleY.TabIndex = 18;
            this.ScaleY.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // ScaleX
            // 
            this.ScaleX.Location = new System.Drawing.Point(20, 230);
            this.ScaleX.Name = "ScaleX";
            this.ScaleX.Size = new System.Drawing.Size(96, 20);
            this.ScaleX.TabIndex = 17;
            this.ScaleX.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // RotationLabel
            // 
            this.RotationLabel.AutoSize = true;
            this.RotationLabel.Location = new System.Drawing.Point(67, 123);
            this.RotationLabel.Name = "RotationLabel";
            this.RotationLabel.Size = new System.Drawing.Size(47, 13);
            this.RotationLabel.TabIndex = 15;
            this.RotationLabel.Text = "Rotation";
            // 
            // RotationZLabel
            // 
            this.RotationZLabel.AutoSize = true;
            this.RotationZLabel.Location = new System.Drawing.Point(3, 194);
            this.RotationZLabel.Name = "RotationZLabel";
            this.RotationZLabel.Size = new System.Drawing.Size(14, 13);
            this.RotationZLabel.TabIndex = 14;
            this.RotationZLabel.Text = "Z";
            // 
            // RotationYLabel
            // 
            this.RotationYLabel.AutoSize = true;
            this.RotationYLabel.Location = new System.Drawing.Point(3, 168);
            this.RotationYLabel.Name = "RotationYLabel";
            this.RotationYLabel.Size = new System.Drawing.Size(14, 13);
            this.RotationYLabel.TabIndex = 13;
            this.RotationYLabel.Text = "Y";
            // 
            // RotationXLabel
            // 
            this.RotationXLabel.AutoSize = true;
            this.RotationXLabel.Location = new System.Drawing.Point(3, 142);
            this.RotationXLabel.Name = "RotationXLabel";
            this.RotationXLabel.Size = new System.Drawing.Size(14, 13);
            this.RotationXLabel.TabIndex = 12;
            this.RotationXLabel.Text = "X";
            // 
            // RotationZ
            // 
            this.RotationZ.Location = new System.Drawing.Point(20, 191);
            this.RotationZ.Name = "RotationZ";
            this.RotationZ.Size = new System.Drawing.Size(96, 20);
            this.RotationZ.TabIndex = 11;
            this.RotationZ.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // RotationY
            // 
            this.RotationY.Location = new System.Drawing.Point(20, 165);
            this.RotationY.Name = "RotationY";
            this.RotationY.Size = new System.Drawing.Size(96, 20);
            this.RotationY.TabIndex = 10;
            this.RotationY.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // RotationX
            // 
            this.RotationX.Location = new System.Drawing.Point(20, 139);
            this.RotationX.Name = "RotationX";
            this.RotationX.Size = new System.Drawing.Size(96, 20);
            this.RotationX.TabIndex = 9;
            this.RotationX.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // PositionLabel
            // 
            this.PositionLabel.AutoSize = true;
            this.PositionLabel.Location = new System.Drawing.Point(70, 29);
            this.PositionLabel.Name = "PositionLabel";
            this.PositionLabel.Size = new System.Drawing.Size(44, 13);
            this.PositionLabel.TabIndex = 8;
            this.PositionLabel.Text = "Position";
            // 
            // PositionZLabel
            // 
            this.PositionZLabel.AutoSize = true;
            this.PositionZLabel.Location = new System.Drawing.Point(3, 103);
            this.PositionZLabel.Name = "PositionZLabel";
            this.PositionZLabel.Size = new System.Drawing.Size(14, 13);
            this.PositionZLabel.TabIndex = 6;
            this.PositionZLabel.Text = "Z";
            // 
            // PositionYLabel
            // 
            this.PositionYLabel.AutoSize = true;
            this.PositionYLabel.Location = new System.Drawing.Point(3, 77);
            this.PositionYLabel.Name = "PositionYLabel";
            this.PositionYLabel.Size = new System.Drawing.Size(14, 13);
            this.PositionYLabel.TabIndex = 5;
            this.PositionYLabel.Text = "Y";
            // 
            // PositionXLabel
            // 
            this.PositionXLabel.AutoSize = true;
            this.PositionXLabel.Location = new System.Drawing.Point(3, 51);
            this.PositionXLabel.Name = "PositionXLabel";
            this.PositionXLabel.Size = new System.Drawing.Size(14, 13);
            this.PositionXLabel.TabIndex = 4;
            this.PositionXLabel.Text = "X";
            // 
            // PositionZ
            // 
            this.PositionZ.Location = new System.Drawing.Point(20, 100);
            this.PositionZ.Name = "PositionZ";
            this.PositionZ.Size = new System.Drawing.Size(96, 20);
            this.PositionZ.TabIndex = 3;
            this.PositionZ.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // PositionY
            // 
            this.PositionY.Location = new System.Drawing.Point(20, 74);
            this.PositionY.Name = "PositionY";
            this.PositionY.Size = new System.Drawing.Size(96, 20);
            this.PositionY.TabIndex = 2;
            this.PositionY.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // PositionX
            // 
            this.PositionX.Location = new System.Drawing.Point(20, 48);
            this.PositionX.Name = "PositionX";
            this.PositionX.Size = new System.Drawing.Size(96, 20);
            this.PositionX.TabIndex = 1;
            this.PositionX.TextChanged += new System.EventHandler(this.Transform_TextChanged);
            // 
            // TransformSelector
            // 
            this.TransformSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.TransformSelector.FormattingEnabled = true;
            this.TransformSelector.Items.AddRange(new object[] {
            "Тетраэдр",
            "Гексаэдр",
            "Октаэдр",
            "Икосаэдр",
            "Додекаэдр"});
            this.TransformSelector.Location = new System.Drawing.Point(0, 0);
            this.TransformSelector.Name = "TransformSelector";
            this.TransformSelector.Size = new System.Drawing.Size(121, 21);
            this.TransformSelector.TabIndex = 0;
            this.TransformSelector.SelectedIndexChanged += new System.EventHandler(this.TransformSelector_SelectedIndexChanged);
            // 
            // EditPanel
            // 
            this.EditPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.EditPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.EditPanel.Controls.Add(this.EditButton);
            this.EditPanel.Controls.Add(this.EditPolySelector);
            this.EditPanel.Controls.Add(this.EditOpSelector);
            this.EditPanel.Controls.Add(this.EditZLabel);
            this.EditPanel.Controls.Add(this.EditX);
            this.EditPanel.Controls.Add(this.EditYLabel);
            this.EditPanel.Controls.Add(this.EditY);
            this.EditPanel.Controls.Add(this.EditXLabel);
            this.EditPanel.Controls.Add(this.EditZ);
            this.EditPanel.Location = new System.Drawing.Point(667, 39);
            this.EditPanel.Name = "EditPanel";
            this.EditPanel.Size = new System.Drawing.Size(121, 399);
            this.EditPanel.TabIndex = 18;
            this.EditPanel.Visible = false;
            // 
            // EditButton
            // 
            this.EditButton.Location = new System.Drawing.Point(41, 126);
            this.EditButton.Name = "EditButton";
            this.EditButton.Size = new System.Drawing.Size(75, 23);
            this.EditButton.TabIndex = 15;
            this.EditButton.Text = "Применить";
            this.EditButton.UseVisualStyleBackColor = true;
            this.EditButton.Click += new System.EventHandler(this.EditButton_Click);
            // 
            // EditPolySelector
            // 
            this.EditPolySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditPolySelector.FormattingEnabled = true;
            this.EditPolySelector.Location = new System.Drawing.Point(-1, -1);
            this.EditPolySelector.Name = "EditPolySelector";
            this.EditPolySelector.Size = new System.Drawing.Size(121, 21);
            this.EditPolySelector.TabIndex = 0;
            this.EditPolySelector.SelectedIndexChanged += new System.EventHandler(this.EditPolySelector_SelectedIndexChanged);
            // 
            // EditOpSelector
            // 
            this.EditOpSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.EditOpSelector.FormattingEnabled = true;
            this.EditOpSelector.Items.AddRange(new object[] {
            "Сдвинуть",
            "Повернуть",
            "Масштабировать"});
            this.EditOpSelector.Location = new System.Drawing.Point(-1, 21);
            this.EditOpSelector.Name = "EditOpSelector";
            this.EditOpSelector.Size = new System.Drawing.Size(121, 21);
            this.EditOpSelector.TabIndex = 16;
            // 
            // EditZLabel
            // 
            this.EditZLabel.AutoSize = true;
            this.EditZLabel.Location = new System.Drawing.Point(3, 103);
            this.EditZLabel.Name = "EditZLabel";
            this.EditZLabel.Size = new System.Drawing.Size(14, 13);
            this.EditZLabel.TabIndex = 6;
            this.EditZLabel.Text = "Z";
            // 
            // EditX
            // 
            this.EditX.Location = new System.Drawing.Point(20, 48);
            this.EditX.Name = "EditX";
            this.EditX.Size = new System.Drawing.Size(96, 20);
            this.EditX.TabIndex = 3;
            // 
            // EditYLabel
            // 
            this.EditYLabel.AutoSize = true;
            this.EditYLabel.Location = new System.Drawing.Point(3, 77);
            this.EditYLabel.Name = "EditYLabel";
            this.EditYLabel.Size = new System.Drawing.Size(14, 13);
            this.EditYLabel.TabIndex = 5;
            this.EditYLabel.Text = "Y";
            // 
            // EditY
            // 
            this.EditY.Location = new System.Drawing.Point(20, 74);
            this.EditY.Name = "EditY";
            this.EditY.Size = new System.Drawing.Size(96, 20);
            this.EditY.TabIndex = 2;
            // 
            // EditXLabel
            // 
            this.EditXLabel.AutoSize = true;
            this.EditXLabel.Location = new System.Drawing.Point(3, 51);
            this.EditXLabel.Name = "EditXLabel";
            this.EditXLabel.Size = new System.Drawing.Size(14, 13);
            this.EditXLabel.TabIndex = 4;
            this.EditXLabel.Text = "X";
            // 
            // EditZ
            // 
            this.EditZ.Location = new System.Drawing.Point(20, 100);
            this.EditZ.Name = "EditZ";
            this.EditZ.Size = new System.Drawing.Size(96, 20);
            this.EditZ.TabIndex = 1;
            // 
            // MirrorPanel
            // 
            this.MirrorPanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.MirrorPanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.MirrorPanel.Controls.Add(this.MirrorButton);
            this.MirrorPanel.Controls.Add(this.MirrorPolySelector);
            this.MirrorPanel.Controls.Add(this.MirrorAxisSelector);
            this.MirrorPanel.Controls.Add(this.MirrorPlaneBox);
            this.MirrorPanel.Location = new System.Drawing.Point(667, 39);
            this.MirrorPanel.Name = "MirrorPanel";
            this.MirrorPanel.Size = new System.Drawing.Size(121, 399);
            this.MirrorPanel.TabIndex = 19;
            this.MirrorPanel.Visible = false;
            // 
            // MirrorButton
            // 
            this.MirrorButton.Location = new System.Drawing.Point(41, 74);
            this.MirrorButton.Name = "MirrorButton";
            this.MirrorButton.Size = new System.Drawing.Size(75, 23);
            this.MirrorButton.TabIndex = 15;
            this.MirrorButton.Text = "Применить";
            this.MirrorButton.UseVisualStyleBackColor = true;
            this.MirrorButton.Click += new System.EventHandler(this.MirrorButton_Click);
            // 
            // MirrorPolySelector
            // 
            this.MirrorPolySelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MirrorPolySelector.FormattingEnabled = true;
            this.MirrorPolySelector.Location = new System.Drawing.Point(-1, -1);
            this.MirrorPolySelector.Name = "MirrorPolySelector";
            this.MirrorPolySelector.Size = new System.Drawing.Size(121, 21);
            this.MirrorPolySelector.TabIndex = 0;
            this.MirrorPolySelector.SelectedIndexChanged += new System.EventHandler(this.MirrorPolySelector_SelectedIndexChanged);
            // 
            // MirrorAxisSelector
            // 
            this.MirrorAxisSelector.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.MirrorAxisSelector.FormattingEnabled = true;
            this.MirrorAxisSelector.Items.AddRange(new object[] {
            "YZ",
            "XZ",
            "XY"});
            this.MirrorAxisSelector.Location = new System.Drawing.Point(-1, 21);
            this.MirrorAxisSelector.Name = "MirrorAxisSelector";
            this.MirrorAxisSelector.Size = new System.Drawing.Size(121, 21);
            this.MirrorAxisSelector.TabIndex = 16;
            // 
            // MirrorPlaneBox
            // 
            this.MirrorPlaneBox.Location = new System.Drawing.Point(3, 48);
            this.MirrorPlaneBox.Name = "MirrorPlaneBox";
            this.MirrorPlaneBox.Size = new System.Drawing.Size(113, 20);
            this.MirrorPlaneBox.TabIndex = 17;
            // 
            // openModel
            // 
            this.openModel.FileName = "openFileDialog1";
            // 
            // SavePanel
            // 
            this.SavePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.SavePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.SavePanel.Controls.Add(this.SaveButton);
            this.SavePanel.Controls.Add(this.SaveBox);
            this.SavePanel.Location = new System.Drawing.Point(667, 39);
            this.SavePanel.Name = "SavePanel";
            this.SavePanel.Size = new System.Drawing.Size(121, 399);
            this.SavePanel.TabIndex = 20;
            this.SavePanel.Visible = false;
            // 
            // SaveButton
            // 
            this.SaveButton.Location = new System.Drawing.Point(41, 24);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(75, 23);
            this.SaveButton.TabIndex = 15;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.UseVisualStyleBackColor = true;
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // SaveBox
            // 
            this.SaveBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.SaveBox.FormattingEnabled = true;
            this.SaveBox.Location = new System.Drawing.Point(-1, -1);
            this.SaveBox.Name = "SaveBox";
            this.SaveBox.Size = new System.Drawing.Size(121, 21);
            this.SaveBox.TabIndex = 0;
            this.SaveBox.SelectedIndexChanged += new System.EventHandler(this.SaveBox_SelectedIndexChanged);
            // 
            // LatheSelectorBox
            // 
            this.LatheSelectorBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LatheSelectorBox.FormattingEnabled = true;
            this.LatheSelectorBox.Location = new System.Drawing.Point(-1, 0);
            this.LatheSelectorBox.Name = "LatheSelectorBox";
            this.LatheSelectorBox.Size = new System.Drawing.Size(121, 21);
            this.LatheSelectorBox.TabIndex = 0;
            this.LatheSelectorBox.SelectedIndexChanged += new System.EventHandler(this.BevelSelectorBox_SelectedIndexChanged);
            // 
            // LatheDivisionsBox
            // 
            this.LatheDivisionsBox.Location = new System.Drawing.Point(19, 54);
            this.LatheDivisionsBox.Name = "LatheDivisionsBox";
            this.LatheDivisionsBox.Size = new System.Drawing.Size(96, 20);
            this.LatheDivisionsBox.TabIndex = 16;
            // 
            // LatheDivisionsLabel
            // 
            this.LatheDivisionsLabel.AutoSize = true;
            this.LatheDivisionsLabel.Location = new System.Drawing.Point(3, 57);
            this.LatheDivisionsLabel.Name = "LatheDivisionsLabel";
            this.LatheDivisionsLabel.Size = new System.Drawing.Size(15, 13);
            this.LatheDivisionsLabel.TabIndex = 17;
            this.LatheDivisionsLabel.Text = "D";
            // 
            // LatheButton
            // 
            this.LatheButton.Location = new System.Drawing.Point(40, 80);
            this.LatheButton.Name = "LatheButton";
            this.LatheButton.Size = new System.Drawing.Size(75, 23);
            this.LatheButton.TabIndex = 15;
            this.LatheButton.Text = "Повернуть";
            this.LatheButton.UseVisualStyleBackColor = true;
            this.LatheButton.Click += new System.EventHandler(this.LatheButton_Click);
            // 
            // LatheAxisBox
            // 
            this.LatheAxisBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.LatheAxisBox.FormattingEnabled = true;
            this.LatheAxisBox.Items.AddRange(new object[] {
            "X",
            "Y",
            "Z"});
            this.LatheAxisBox.Location = new System.Drawing.Point(-1, 27);
            this.LatheAxisBox.Name = "LatheAxisBox";
            this.LatheAxisBox.Size = new System.Drawing.Size(121, 21);
            this.LatheAxisBox.TabIndex = 18;
            // 
            // LathePanel
            // 
            this.LathePanel.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.LathePanel.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.LathePanel.Controls.Add(this.LatheAxisBox);
            this.LathePanel.Controls.Add(this.LatheButton);
            this.LathePanel.Controls.Add(this.LatheDivisionsLabel);
            this.LathePanel.Controls.Add(this.LatheDivisionsBox);
            this.LathePanel.Controls.Add(this.LatheSelectorBox);
            this.LathePanel.Location = new System.Drawing.Point(667, 39);
            this.LathePanel.Name = "LathePanel";
            this.LathePanel.Size = new System.Drawing.Size(121, 399);
            this.LathePanel.TabIndex = 21;
            this.LathePanel.Visible = false;
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.LathePanel);
            this.Controls.Add(this.SpawnPanel);
            this.Controls.Add(this.SavePanel);
            this.Controls.Add(this.MirrorPanel);
            this.Controls.Add(this.RotatePanel);
            this.Controls.Add(this.PerspectivePanel);
            this.Controls.Add(this.EditPanel);
            this.Controls.Add(this.TransformPanel);
            this.Controls.Add(this.DespawnPanel);
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
            this.DespawnPanel.ResumeLayout(false);
            this.TransformPanel.ResumeLayout(false);
            this.TransformPanel.PerformLayout();
            this.EditPanel.ResumeLayout(false);
            this.EditPanel.PerformLayout();
            this.MirrorPanel.ResumeLayout(false);
            this.MirrorPanel.PerformLayout();
            this.SavePanel.ResumeLayout(false);
            this.LathePanel.ResumeLayout(false);
            this.LathePanel.PerformLayout();
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
        private System.Windows.Forms.Label RotatePoint1XLabel;
        private System.Windows.Forms.Label RotatePoint1YLabel;
        private System.Windows.Forms.Label RotatePoint1ZLabel;
        private System.Windows.Forms.ComboBox RotateSelectDropdown;
        private System.Windows.Forms.TextBox RotatePoint1XBox;
        private System.Windows.Forms.TextBox RotatePoint1YBox;
        private System.Windows.Forms.TextBox RotatePoint1ZBox;
        private System.Windows.Forms.Button RotateButton;
        private System.Windows.Forms.Panel PerspectivePanel;
        private System.Windows.Forms.ComboBox PerspectiveBox;
        private System.Windows.Forms.Button SpawnButton;
        private System.Windows.Forms.Label SpawnSizeLabel;
        private System.Windows.Forms.TextBox SpawnSizeBox;
        private System.Windows.Forms.Panel DespawnPanel;
        private System.Windows.Forms.Button DespawnButton;
        private System.Windows.Forms.ComboBox DespawnSelector;
        private System.Windows.Forms.Panel TransformPanel;
        private System.Windows.Forms.Label PositionLabel;
        private System.Windows.Forms.Label PositionZLabel;
        private System.Windows.Forms.Label PositionYLabel;
        private System.Windows.Forms.Label PositionXLabel;
        private System.Windows.Forms.ComboBox TransformSelector;
        private System.Windows.Forms.TextBox PositionZ;
        private System.Windows.Forms.TextBox PositionY;
        private System.Windows.Forms.TextBox PositionX;
        private System.Windows.Forms.Label ScaleLabel;
        private System.Windows.Forms.Label ScaleZLabel;
        private System.Windows.Forms.Label ScaleYLabel;
        private System.Windows.Forms.Label ScaleXLabel;
        private System.Windows.Forms.TextBox ScaleZ;
        private System.Windows.Forms.TextBox ScaleY;
        private System.Windows.Forms.TextBox ScaleX;
        private System.Windows.Forms.Label RotationLabel;
        private System.Windows.Forms.Label RotationZLabel;
        private System.Windows.Forms.Label RotationYLabel;
        private System.Windows.Forms.Label RotationXLabel;
        private System.Windows.Forms.TextBox RotationZ;
        private System.Windows.Forms.TextBox RotationY;
        private System.Windows.Forms.TextBox RotationX;
        private System.Windows.Forms.Label RotatePoint1Label;
        private System.Windows.Forms.Label RotatePoint2Label;
        private System.Windows.Forms.Label RotatePoint2XLabel;
        private System.Windows.Forms.TextBox RotatePoint2XBox;
        private System.Windows.Forms.Label RotatePoint2YLabel;
        private System.Windows.Forms.TextBox RotatePoint2YBox;
        private System.Windows.Forms.Label RotatePoint2ZLabel;
        private System.Windows.Forms.TextBox RotatePoint2ZBox;
        private System.Windows.Forms.Panel EditPanel;
        private System.Windows.Forms.Button EditButton;
        private System.Windows.Forms.ComboBox EditPolySelector;
        private System.Windows.Forms.Label EditZLabel;
        private System.Windows.Forms.TextBox EditX;
        private System.Windows.Forms.Label EditYLabel;
        private System.Windows.Forms.TextBox EditY;
        private System.Windows.Forms.Label EditXLabel;
        private System.Windows.Forms.TextBox EditZ;
        private System.Windows.Forms.ComboBox EditOpSelector;
        private System.Windows.Forms.Panel MirrorPanel;
        private System.Windows.Forms.Button MirrorButton;
        private System.Windows.Forms.ComboBox MirrorPolySelector;
        private System.Windows.Forms.ComboBox MirrorAxisSelector;
        private System.Windows.Forms.Label RotateDeg;
        private System.Windows.Forms.TextBox RotateDegBox;
        private System.Windows.Forms.TextBox MirrorPlaneBox;
        private System.Windows.Forms.OpenFileDialog openModel;
        private System.Windows.Forms.SaveFileDialog saveModel;
        private System.Windows.Forms.Panel SavePanel;
        private System.Windows.Forms.Button SaveButton;
        private System.Windows.Forms.ComboBox SaveBox;
        private System.Windows.Forms.ComboBox LatheSelectorBox;
        private System.Windows.Forms.TextBox LatheDivisionsBox;
        private System.Windows.Forms.Label LatheDivisionsLabel;
        private System.Windows.Forms.Button LatheButton;
        private System.Windows.Forms.ComboBox LatheAxisBox;
        private System.Windows.Forms.Panel LathePanel;
    }
}

