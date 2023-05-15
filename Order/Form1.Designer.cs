namespace Order
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
            drinkGroupBox = new GroupBox();
            drink5 = new RadioButton();
            drink4 = new RadioButton();
            drink3 = new RadioButton();
            drink2 = new RadioButton();
            drink1 = new RadioButton();
            dishGroupBox = new GroupBox();
            dish5 = new RadioButton();
            dish4 = new RadioButton();
            dish3 = new RadioButton();
            dish2 = new RadioButton();
            dish1 = new RadioButton();
            dessertGroupBox = new GroupBox();
            dessert1 = new RadioButton();
            dessert2 = new RadioButton();
            dessert3 = new RadioButton();
            dessert4 = new RadioButton();
            dessert5 = new RadioButton();
            groupBox1 = new GroupBox();
            orderText = new TextBox();
            orderButton = new Button();
            button1 = new Button();
            label1 = new Label();
            drinkGroupBox.SuspendLayout();
            dishGroupBox.SuspendLayout();
            dessertGroupBox.SuspendLayout();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // drinkGroupBox
            // 
            drinkGroupBox.Controls.Add(drink5);
            drinkGroupBox.Controls.Add(drink4);
            drinkGroupBox.Controls.Add(drink3);
            drinkGroupBox.Controls.Add(drink2);
            drinkGroupBox.Controls.Add(drink1);
            drinkGroupBox.Location = new Point(64, 116);
            drinkGroupBox.Name = "drinkGroupBox";
            drinkGroupBox.Size = new Size(270, 155);
            drinkGroupBox.TabIndex = 0;
            drinkGroupBox.TabStop = false;
            drinkGroupBox.Text = "Напої";
            // 
            // drink5
            // 
            drink5.AutoSize = true;
            drink5.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drink5.Location = new Point(11, 130);
            drink5.Name = "drink5";
            drink5.Size = new Size(94, 19);
            drink5.TabIndex = 4;
            drink5.Text = "radioButton5";
            drink5.UseVisualStyleBackColor = true;
            drink5.CheckedChanged += drinkSelect;
            // 
            // drink4
            // 
            drink4.AutoSize = true;
            drink4.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drink4.Location = new Point(11, 105);
            drink4.Name = "drink4";
            drink4.Size = new Size(94, 19);
            drink4.TabIndex = 3;
            drink4.Text = "radioButton4";
            drink4.UseVisualStyleBackColor = true;
            drink4.CheckedChanged += drinkSelect;
            // 
            // drink3
            // 
            drink3.AutoSize = true;
            drink3.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drink3.Location = new Point(11, 80);
            drink3.Name = "drink3";
            drink3.Size = new Size(94, 19);
            drink3.TabIndex = 2;
            drink3.Text = "radioButton3";
            drink3.UseVisualStyleBackColor = true;
            drink3.CheckedChanged += drinkSelect;
            // 
            // drink2
            // 
            drink2.AutoSize = true;
            drink2.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drink2.Location = new Point(11, 55);
            drink2.Name = "drink2";
            drink2.Size = new Size(94, 19);
            drink2.TabIndex = 1;
            drink2.Text = "radioButton2";
            drink2.UseVisualStyleBackColor = true;
            drink2.CheckedChanged += drinkSelect;
            // 
            // drink1
            // 
            drink1.AutoSize = true;
            drink1.Font = new Font("Segoe UI", 9F, FontStyle.Regular, GraphicsUnit.Point);
            drink1.Location = new Point(11, 30);
            drink1.Name = "drink1";
            drink1.Size = new Size(94, 19);
            drink1.TabIndex = 0;
            drink1.Text = "radioButton1";
            drink1.UseVisualStyleBackColor = true;
            drink1.CheckedChanged += drinkSelect;
            // 
            // dishGroupBox
            // 
            dishGroupBox.Controls.Add(dish5);
            dishGroupBox.Controls.Add(dish4);
            dishGroupBox.Controls.Add(dish3);
            dishGroupBox.Controls.Add(dish2);
            dishGroupBox.Controls.Add(dish1);
            dishGroupBox.Location = new Point(64, 289);
            dishGroupBox.Name = "dishGroupBox";
            dishGroupBox.Size = new Size(270, 155);
            dishGroupBox.TabIndex = 1;
            dishGroupBox.TabStop = false;
            dishGroupBox.Text = "Основна страва";
            // 
            // dish5
            // 
            dish5.AutoSize = true;
            dish5.Location = new Point(11, 130);
            dish5.Name = "dish5";
            dish5.Size = new Size(94, 19);
            dish5.TabIndex = 4;
            dish5.Text = "radioButton5";
            dish5.UseVisualStyleBackColor = true;
            dish5.CheckedChanged += dishSelect;
            // 
            // dish4
            // 
            dish4.AutoSize = true;
            dish4.Location = new Point(11, 105);
            dish4.Name = "dish4";
            dish4.Size = new Size(94, 19);
            dish4.TabIndex = 3;
            dish4.Text = "radioButton4";
            dish4.UseVisualStyleBackColor = true;
            dish4.CheckedChanged += dishSelect;
            // 
            // dish3
            // 
            dish3.AutoSize = true;
            dish3.Location = new Point(11, 80);
            dish3.Name = "dish3";
            dish3.Size = new Size(94, 19);
            dish3.TabIndex = 2;
            dish3.Text = "radioButton3";
            dish3.UseVisualStyleBackColor = true;
            dish3.CheckedChanged += dishSelect;
            // 
            // dish2
            // 
            dish2.AutoSize = true;
            dish2.Location = new Point(11, 55);
            dish2.Name = "dish2";
            dish2.Size = new Size(94, 19);
            dish2.TabIndex = 1;
            dish2.Text = "radioButton2";
            dish2.UseVisualStyleBackColor = true;
            dish2.CheckedChanged += dishSelect;
            // 
            // dish1
            // 
            dish1.AutoSize = true;
            dish1.Location = new Point(11, 30);
            dish1.Name = "dish1";
            dish1.Size = new Size(94, 19);
            dish1.TabIndex = 0;
            dish1.Text = "radioButton1";
            dish1.UseVisualStyleBackColor = true;
            dish1.CheckedChanged += dishSelect;
            // 
            // dessertGroupBox
            // 
            dessertGroupBox.Controls.Add(dessert1);
            dessertGroupBox.Controls.Add(dessert2);
            dessertGroupBox.Controls.Add(dessert3);
            dessertGroupBox.Controls.Add(dessert4);
            dessertGroupBox.Controls.Add(dessert5);
            dessertGroupBox.Location = new Point(64, 459);
            dessertGroupBox.Name = "dessertGroupBox";
            dessertGroupBox.Size = new Size(270, 155);
            dessertGroupBox.TabIndex = 2;
            dessertGroupBox.TabStop = false;
            dessertGroupBox.Text = "Десерт";
            // 
            // dessert1
            // 
            dessert1.AutoSize = true;
            dessert1.Location = new Point(11, 130);
            dessert1.Name = "dessert1";
            dessert1.Size = new Size(94, 19);
            dessert1.TabIndex = 4;
            dessert1.Text = "radioButton5";
            dessert1.UseVisualStyleBackColor = true;
            dessert1.CheckedChanged += dessertSelect;
            // 
            // dessert2
            // 
            dessert2.AutoSize = true;
            dessert2.Location = new Point(11, 105);
            dessert2.Name = "dessert2";
            dessert2.Size = new Size(94, 19);
            dessert2.TabIndex = 3;
            dessert2.Text = "radioButton4";
            dessert2.UseVisualStyleBackColor = true;
            dessert2.CheckedChanged += dessertSelect;
            // 
            // dessert3
            // 
            dessert3.AutoSize = true;
            dessert3.Location = new Point(11, 80);
            dessert3.Name = "dessert3";
            dessert3.Size = new Size(94, 19);
            dessert3.TabIndex = 2;
            dessert3.Text = "radioButton3";
            dessert3.UseVisualStyleBackColor = true;
            dessert3.CheckedChanged += dessertSelect;
            // 
            // dessert4
            // 
            dessert4.AutoSize = true;
            dessert4.Location = new Point(11, 55);
            dessert4.Name = "dessert4";
            dessert4.Size = new Size(94, 19);
            dessert4.TabIndex = 1;
            dessert4.Text = "radioButton2";
            dessert4.UseVisualStyleBackColor = true;
            dessert4.CheckedChanged += dessertSelect;
            // 
            // dessert5
            // 
            dessert5.AutoSize = true;
            dessert5.Location = new Point(11, 30);
            dessert5.Name = "dessert5";
            dessert5.Size = new Size(94, 19);
            dessert5.TabIndex = 0;
            dessert5.Text = "radioButton1";
            dessert5.UseVisualStyleBackColor = true;
            dessert5.CheckedChanged += dessertSelect;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(orderText);
            groupBox1.Location = new Point(388, 116);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(359, 492);
            groupBox1.TabIndex = 3;
            groupBox1.TabStop = false;
            groupBox1.Text = "Всі замовлення";
            // 
            // orderText
            // 
            orderText.Location = new Point(11, 22);
            orderText.Multiline = true;
            orderText.Name = "orderText";
            orderText.ReadOnly = true;
            orderText.ScrollBars = ScrollBars.Both;
            orderText.Size = new Size(339, 464);
            orderText.TabIndex = 0;
            orderText.WordWrap = false;
            // 
            // orderButton
            // 
            orderButton.Enabled = false;
            orderButton.Location = new Point(64, 641);
            orderButton.Name = "orderButton";
            orderButton.Size = new Size(150, 23);
            orderButton.TabIndex = 4;
            orderButton.Text = "Замовити";
            orderButton.UseVisualStyleBackColor = true;
            orderButton.Click += orderButton_Click;
            // 
            // button1
            // 
            button1.Location = new Point(235, 641);
            button1.Name = "button1";
            button1.Size = new Size(150, 23);
            button1.TabIndex = 5;
            button1.Text = "Вийти";
            button1.UseVisualStyleBackColor = true;
            button1.Click += Exit;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 19F, FontStyle.Regular, GraphicsUnit.Point);
            label1.Location = new Point(319, 20);
            label1.Name = "label1";
            label1.Size = new Size(167, 36);
            label1.TabIndex = 6;
            label1.Text = "Замовлення ";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(809, 706);
            Controls.Add(label1);
            Controls.Add(button1);
            Controls.Add(orderButton);
            Controls.Add(groupBox1);
            Controls.Add(dessertGroupBox);
            Controls.Add(dishGroupBox);
            Controls.Add(drinkGroupBox);
            MaximumSize = new Size(825, 745);
            MinimumSize = new Size(825, 745);
            Name = "Form1";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Замовлення";
            drinkGroupBox.ResumeLayout(false);
            drinkGroupBox.PerformLayout();
            dishGroupBox.ResumeLayout(false);
            dishGroupBox.PerformLayout();
            dessertGroupBox.ResumeLayout(false);
            dessertGroupBox.PerformLayout();
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox drinkGroupBox;
        private RadioButton drink5;
        private RadioButton drink4;
        private RadioButton drink3;
        private RadioButton drink2;
        private RadioButton drink1;
        private GroupBox dishGroupBox;
        private RadioButton dish5;
        private RadioButton dish4;
        private RadioButton dish3;
        private RadioButton dish2;
        private RadioButton dish1;
        private GroupBox dessertGroupBox;
        private RadioButton dessert1;
        private RadioButton dessert2;
        private RadioButton dessert3;
        private RadioButton dessert4;
        private RadioButton dessert5;
        private GroupBox groupBox1;
        private TextBox orderText;
        private Button orderButton;
        private Button button1;
        private Label label1;
    }
}