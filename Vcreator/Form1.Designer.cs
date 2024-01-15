namespace Vcreator
{
    partial class BlockEditor
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
            Save = new Button();
            hiddenBox = new CheckBox();
            saveFileDialog = new SaveFileDialog();
            checkBox2 = new CheckBox();
            replacibleBox = new CheckBox();
            breakableBox = new CheckBox();
            selectableBox = new CheckBox();
            obstacleBox = new CheckBox();
            skyLightPassingBox = new CheckBox();
            pickingBox = new TextBox();
            label1 = new Label();
            textureBox = new TextBox();
            TextureCheckBox = new CheckBox();
            comboBox1 = new ComboBox();
            label2 = new Label();
            textureXm = new TextBox();
            label3 = new Label();
            label4 = new Label();
            textureXp = new TextBox();
            textureYm = new TextBox();
            label5 = new Label();
            textureYp = new TextBox();
            label6 = new Label();
            textureZm = new TextBox();
            textureZp = new TextBox();
            label7 = new Label();
            label8 = new Label();
            comboBox2 = new ComboBox();
            label9 = new Label();
            hitboxCheck = new CheckBox();
            offsetLabel = new Label();
            offsetX = new NumericUpDown();
            label10 = new Label();
            offsetY = new NumericUpDown();
            label11 = new Label();
            label12 = new Label();
            offsetZ = new NumericUpDown();
            label13 = new Label();
            sizeX = new NumericUpDown();
            sizeY = new NumericUpDown();
            sizeZ = new NumericUpDown();
            label14 = new Label();
            numericUpDown1 = new NumericUpDown();
            ((System.ComponentModel.ISupportInitialize)offsetX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)offsetZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeX).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeY).BeginInit();
            ((System.ComponentModel.ISupportInitialize)sizeZ).BeginInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).BeginInit();
            SuspendLayout();
            // 
            // Save
            // 
            Save.Location = new Point(690, 415);
            Save.Name = "Save";
            Save.Size = new Size(98, 23);
            Save.TabIndex = 0;
            Save.Text = "Сохранить";
            Save.UseVisualStyleBackColor = true;
            Save.Click += Save_Click;
            // 
            // hiddenBox
            // 
            hiddenBox.AutoSize = true;
            hiddenBox.Location = new Point(12, 46);
            hiddenBox.Name = "hiddenBox";
            hiddenBox.Size = new Size(77, 19);
            hiddenBox.TabIndex = 3;
            hiddenBox.Text = "Скрытый";
            hiddenBox.UseVisualStyleBackColor = true;
            hiddenBox.CheckedChanged += checkBox1_CheckedChanged;
            // 
            // saveFileDialog
            // 
            saveFileDialog.Filter = "Json|*.json";
            saveFileDialog.FileOk += saveFileDialog_FileOk;
            // 
            // checkBox2
            // 
            checkBox2.AutoSize = true;
            checkBox2.Location = new Point(12, 71);
            checkBox2.Name = "checkBox2";
            checkBox2.Size = new Size(130, 19);
            checkBox2.TabIndex = 8;
            checkBox2.Text = "Светопроводимый";
            checkBox2.UseVisualStyleBackColor = true;
            checkBox2.CheckedChanged += checkBox2_CheckedChanged;
            // 
            // replacibleBox
            // 
            replacibleBox.AutoSize = true;
            replacibleBox.Location = new Point(12, 96);
            replacibleBox.Name = "replacibleBox";
            replacibleBox.Size = new Size(98, 19);
            replacibleBox.TabIndex = 9;
            replacibleBox.Text = "Заменяемый";
            replacibleBox.UseVisualStyleBackColor = true;
            replacibleBox.CheckedChanged += replacibleBox_CheckedChanged;
            // 
            // breakableBox
            // 
            breakableBox.AutoSize = true;
            breakableBox.Checked = true;
            breakableBox.CheckState = CheckState.Checked;
            breakableBox.Location = new Point(12, 121);
            breakableBox.Name = "breakableBox";
            breakableBox.Size = new Size(105, 19);
            breakableBox.TabIndex = 10;
            breakableBox.Text = "Разрушаемый";
            breakableBox.UseVisualStyleBackColor = true;
            breakableBox.CheckedChanged += breakableBox_CheckedChanged;
            // 
            // selectableBox
            // 
            selectableBox.AutoSize = true;
            selectableBox.Checked = true;
            selectableBox.CheckState = CheckState.Checked;
            selectableBox.Location = new Point(12, 146);
            selectableBox.Name = "selectableBox";
            selectableBox.Size = new Size(98, 19);
            selectableBox.TabIndex = 11;
            selectableBox.Text = "Выделяемый";
            selectableBox.UseVisualStyleBackColor = true;
            selectableBox.CheckedChanged += selectableBox_CheckedChanged;
            // 
            // obstacleBox
            // 
            obstacleBox.AutoSize = true;
            obstacleBox.Checked = true;
            obstacleBox.CheckState = CheckState.Checked;
            obstacleBox.Location = new Point(12, 171);
            obstacleBox.Name = "obstacleBox";
            obstacleBox.Size = new Size(219, 19);
            obstacleBox.TabIndex = 12;
            obstacleBox.Text = "Блокирует движение(Препятствие)";
            obstacleBox.UseVisualStyleBackColor = true;
            obstacleBox.CheckedChanged += obstacleBox_CheckedChanged;
            // 
            // skyLightPassingBox
            // 
            skyLightPassingBox.AutoSize = true;
            skyLightPassingBox.Location = new Point(12, 196);
            skyLightPassingBox.Name = "skyLightPassingBox";
            skyLightPassingBox.Size = new Size(203, 19);
            skyLightPassingBox.TabIndex = 13;
            skyLightPassingBox.Text = "Солнечная светопроводимость ";
            skyLightPassingBox.UseVisualStyleBackColor = true;
            // 
            // pickingBox
            // 
            pickingBox.Enabled = false;
            pickingBox.Location = new Point(268, 44);
            pickingBox.Name = "pickingBox";
            pickingBox.PlaceholderText = "picking-item";
            pickingBox.Size = new Size(133, 23);
            pickingBox.TabIndex = 15;
            pickingBox.TextChanged += pickingBox_TextChanged;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 15F);
            label1.Location = new Point(305, 9);
            label1.Name = "label1";
            label1.Size = new Size(171, 28);
            label1.TabIndex = 16;
            label1.Text = "Настройки блока";
            // 
            // textureBox
            // 
            textureBox.Location = new Point(12, 250);
            textureBox.Name = "textureBox";
            textureBox.PlaceholderText = "dirt";
            textureBox.Size = new Size(100, 23);
            textureBox.TabIndex = 17;
            textureBox.TextChanged += textureBox_TextChanged;
            // 
            // TextureCheckBox
            // 
            TextureCheckBox.AutoSize = true;
            TextureCheckBox.Checked = true;
            TextureCheckBox.CheckState = CheckState.Checked;
            TextureCheckBox.Location = new Point(12, 221);
            TextureCheckBox.Name = "TextureCheckBox";
            TextureCheckBox.Size = new Size(104, 19);
            TextureCheckBox.TabIndex = 18;
            TextureCheckBox.Text = "Одна текстура";
            TextureCheckBox.UseVisualStyleBackColor = true;
            TextureCheckBox.CheckedChanged += TextureCheckBox_CheckedChanged;
            // 
            // comboBox1
            // 
            comboBox1.FormattingEnabled = true;
            comboBox1.Items.AddRange(new object[] { "block", "none", "X", "aabb" });
            comboBox1.Location = new Point(529, 44);
            comboBox1.Name = "comboBox1";
            comboBox1.Size = new Size(121, 23);
            comboBox1.TabIndex = 19;
            comboBox1.Text = "block";
            comboBox1.SelectedIndexChanged += comboBox1_SelectedIndexChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(465, 47);
            label2.Name = "label2";
            label2.Size = new Size(53, 15);
            label2.TabIndex = 20;
            label2.Text = "Модель:";
            // 
            // textureXm
            // 
            textureXm.Enabled = false;
            textureXm.Location = new Point(145, 250);
            textureXm.Name = "textureXm";
            textureXm.PlaceholderText = "grass_side";
            textureXm.Size = new Size(100, 23);
            textureXm.TabIndex = 21;
            textureXm.TextChanged += textureXm_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(121, 253);
            label3.Name = "label3";
            label3.Size = new Size(18, 15);
            label3.TabIndex = 22;
            label3.Text = "-x";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(121, 282);
            label4.Name = "label4";
            label4.Size = new Size(21, 15);
            label4.TabIndex = 23;
            label4.Text = "+x";
            // 
            // textureXp
            // 
            textureXp.Enabled = false;
            textureXp.Location = new Point(145, 279);
            textureXp.Name = "textureXp";
            textureXp.PlaceholderText = "grass_side";
            textureXp.Size = new Size(100, 23);
            textureXp.TabIndex = 24;
            textureXp.TextChanged += textureXp_TextChanged;
            // 
            // textureYm
            // 
            textureYm.Enabled = false;
            textureYm.Location = new Point(145, 308);
            textureYm.Name = "textureYm";
            textureYm.PlaceholderText = "dirt";
            textureYm.Size = new Size(100, 23);
            textureYm.TabIndex = 25;
            textureYm.TextChanged += textureYm_TextChanged;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(121, 311);
            label5.Name = "label5";
            label5.Size = new Size(18, 15);
            label5.TabIndex = 26;
            label5.Text = "-y";
            // 
            // textureYp
            // 
            textureYp.Enabled = false;
            textureYp.Location = new Point(145, 337);
            textureYp.Name = "textureYp";
            textureYp.PlaceholderText = "grass_top";
            textureYp.Size = new Size(100, 23);
            textureYp.TabIndex = 27;
            textureYp.TextChanged += textureYp_TextChanged;
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(121, 340);
            label6.Name = "label6";
            label6.Size = new Size(21, 15);
            label6.TabIndex = 28;
            label6.Text = "+y";
            // 
            // textureZm
            // 
            textureZm.Enabled = false;
            textureZm.ForeColor = SystemColors.WindowText;
            textureZm.Location = new Point(145, 366);
            textureZm.Name = "textureZm";
            textureZm.PlaceholderText = "grass_side";
            textureZm.Size = new Size(100, 23);
            textureZm.TabIndex = 29;
            textureZm.TextChanged += textureZm_TextChanged;
            // 
            // textureZp
            // 
            textureZp.Enabled = false;
            textureZp.ForeColor = SystemColors.WindowText;
            textureZp.Location = new Point(145, 395);
            textureZp.Name = "textureZp";
            textureZp.PlaceholderText = "grass_side";
            textureZp.Size = new Size(100, 23);
            textureZp.TabIndex = 30;
            textureZp.TextChanged += textureZp_TextChanged;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(121, 369);
            label7.Name = "label7";
            label7.Size = new Size(17, 15);
            label7.TabIndex = 31;
            label7.Text = "-z";
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Location = new Point(121, 398);
            label8.Name = "label8";
            label8.Size = new Size(20, 15);
            label8.TabIndex = 32;
            label8.Text = "+z";
            // 
            // comboBox2
            // 
            comboBox2.FormattingEnabled = true;
            comboBox2.Items.AddRange(new object[] { "none", "pipe", "pane" });
            comboBox2.Location = new Point(529, 72);
            comboBox2.Name = "comboBox2";
            comboBox2.Size = new Size(121, 23);
            comboBox2.TabIndex = 33;
            comboBox2.Text = "none";
            comboBox2.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(465, 75);
            label9.Name = "label9";
            label9.Size = new Size(58, 15);
            label9.TabIndex = 34;
            label9.Text = "Поворот:";
            // 
            // hitboxCheck
            // 
            hitboxCheck.AutoSize = true;
            hitboxCheck.Location = new Point(465, 101);
            hitboxCheck.Name = "hitboxCheck";
            hitboxCheck.Size = new Size(141, 19);
            hitboxCheck.TabIndex = 35;
            hitboxCheck.Text = "Собственый хитбокс";
            hitboxCheck.UseVisualStyleBackColor = true;
            hitboxCheck.CheckedChanged += hitboxCheck_CheckedChanged;
            // 
            // offsetLabel
            // 
            offsetLabel.AutoSize = true;
            offsetLabel.Location = new Point(465, 125);
            offsetLabel.Name = "offsetLabel";
            offsetLabel.Size = new Size(108, 15);
            offsetLabel.TabIndex = 36;
            offsetLabel.Text = "Смещение(offset):";
            // 
            // offsetX
            // 
            offsetX.DecimalPlaces = 2;
            offsetX.Enabled = false;
            offsetX.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            offsetX.Location = new Point(538, 146);
            offsetX.Name = "offsetX";
            offsetX.Size = new Size(68, 23);
            offsetX.TabIndex = 37;
            offsetX.ValueChanged += offsetX_ValueChanged;
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(465, 148);
            label10.Name = "label10";
            label10.Size = new Size(71, 15);
            label10.TabIndex = 38;
            label10.Text = "X (на запад)";
            // 
            // offsetY
            // 
            offsetY.DecimalPlaces = 2;
            offsetY.Enabled = false;
            offsetY.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            offsetY.Location = new Point(538, 175);
            offsetY.Name = "offsetY";
            offsetY.Size = new Size(68, 23);
            offsetY.TabIndex = 39;
            offsetY.ValueChanged += offsetY_ValueChanged;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Location = new Point(465, 177);
            label11.Name = "label11";
            label11.Size = new Size(66, 15);
            label11.TabIndex = 40;
            label11.Text = "Y (на верх)";
            // 
            // label12
            // 
            label12.AutoSize = true;
            label12.Location = new Point(465, 206);
            label12.Name = "label12";
            label12.Size = new Size(72, 15);
            label12.TabIndex = 41;
            label12.Text = "Z (на север)";
            // 
            // offsetZ
            // 
            offsetZ.DecimalPlaces = 2;
            offsetZ.Enabled = false;
            offsetZ.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            offsetZ.Location = new Point(538, 204);
            offsetZ.Name = "offsetZ";
            offsetZ.Size = new Size(68, 23);
            offsetZ.TabIndex = 42;
            offsetZ.ValueChanged += offsetZ_ValueChanged;
            // 
            // label13
            // 
            label13.AutoSize = true;
            label13.Location = new Point(618, 125);
            label13.Name = "label13";
            label13.Size = new Size(50, 15);
            label13.TabIndex = 43;
            label13.Text = "Размер:";
            // 
            // sizeX
            // 
            sizeX.DecimalPlaces = 2;
            sizeX.Enabled = false;
            sizeX.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            sizeX.Location = new Point(618, 146);
            sizeX.Name = "sizeX";
            sizeX.Size = new Size(68, 23);
            sizeX.TabIndex = 44;
            sizeX.ValueChanged += sizeX_ValueChanged;
            // 
            // sizeY
            // 
            sizeY.DecimalPlaces = 2;
            sizeY.Enabled = false;
            sizeY.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            sizeY.Location = new Point(618, 175);
            sizeY.Name = "sizeY";
            sizeY.Size = new Size(68, 23);
            sizeY.TabIndex = 45;
            sizeY.ValueChanged += sizeY_ValueChanged;
            // 
            // sizeZ
            // 
            sizeZ.DecimalPlaces = 2;
            sizeZ.Enabled = false;
            sizeZ.Increment = new decimal(new int[] { 5, 0, 0, 131072 });
            sizeZ.Location = new Point(618, 204);
            sizeZ.Name = "sizeZ";
            sizeZ.Size = new Size(68, 23);
            sizeZ.TabIndex = 46;
            sizeZ.ValueChanged += sizeZ_ValueChanged;
            // 
            // label14
            // 
            label14.AutoSize = true;
            label14.Location = new Point(465, 250);
            label14.Name = "label14";
            label14.Size = new Size(74, 15);
            label14.TabIndex = 47;
            label14.Text = "Draw-group:";
            // 
            // numericUpDown1
            // 
            numericUpDown1.Location = new Point(545, 248);
            numericUpDown1.Name = "numericUpDown1";
            numericUpDown1.Size = new Size(120, 23);
            numericUpDown1.TabIndex = 48;
            numericUpDown1.ValueChanged += numericUpDown1_ValueChanged;
            // 
            // BlockEditor
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(numericUpDown1);
            Controls.Add(label14);
            Controls.Add(sizeZ);
            Controls.Add(sizeY);
            Controls.Add(sizeX);
            Controls.Add(label13);
            Controls.Add(offsetZ);
            Controls.Add(label12);
            Controls.Add(label11);
            Controls.Add(offsetY);
            Controls.Add(label10);
            Controls.Add(offsetX);
            Controls.Add(offsetLabel);
            Controls.Add(hitboxCheck);
            Controls.Add(label9);
            Controls.Add(comboBox2);
            Controls.Add(label8);
            Controls.Add(label7);
            Controls.Add(textureZp);
            Controls.Add(textureZm);
            Controls.Add(label6);
            Controls.Add(textureYp);
            Controls.Add(label5);
            Controls.Add(textureYm);
            Controls.Add(textureXp);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(textureXm);
            Controls.Add(label2);
            Controls.Add(comboBox1);
            Controls.Add(TextureCheckBox);
            Controls.Add(textureBox);
            Controls.Add(label1);
            Controls.Add(pickingBox);
            Controls.Add(skyLightPassingBox);
            Controls.Add(obstacleBox);
            Controls.Add(selectableBox);
            Controls.Add(breakableBox);
            Controls.Add(replacibleBox);
            Controls.Add(checkBox2);
            Controls.Add(hiddenBox);
            Controls.Add(Save);
            Name = "BlockEditor";
            Text = "Vcreator-0.1-block";
            ((System.ComponentModel.ISupportInitialize)offsetX).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetY).EndInit();
            ((System.ComponentModel.ISupportInitialize)offsetZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeX).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeY).EndInit();
            ((System.ComponentModel.ISupportInitialize)sizeZ).EndInit();
            ((System.ComponentModel.ISupportInitialize)numericUpDown1).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Button Save;
        private CheckBox hiddenBox;
        private SaveFileDialog saveFileDialog;
        private CheckBox checkBox2;
        private CheckBox replacibleBox;
        private CheckBox breakableBox;
        private CheckBox selectableBox;
        private CheckBox obstacleBox;
        private CheckBox skyLightPassingBox;
        private TextBox pickingBox;
        private Label label1;
        private TextBox textureBox;
        private CheckBox TextureCheckBox;
        private ComboBox comboBox1;
        private Label label2;
        private TextBox textureXm;
        private Label label3;
        private Label label4;
        private TextBox textureXp;
        private TextBox textureYm;
        private Label label5;
        private TextBox textureYp;
        private Label label6;
        private TextBox textureZm;
        private TextBox textureZp;
        private Label label7;
        private Label label8;
        private ComboBox comboBox2;
        private Label label9;
        private CheckBox hitboxCheck;
        private Label offsetLabel;
        private NumericUpDown offsetX;
        private Label label10;
        private NumericUpDown offsetY;
        private Label label11;
        private Label label12;
        private NumericUpDown offsetZ;
        private Label label13;
        private NumericUpDown sizeX;
        private NumericUpDown sizeY;
        private NumericUpDown sizeZ;
        private Label label14;
        private NumericUpDown numericUpDown1;
    }
}
