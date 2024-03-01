namespace Restaurant_Selector__chap_4_ass_10ec_
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
            groupBox1 = new GroupBox();
            GlutenCb = new CheckBox();
            VeganCb = new CheckBox();
            VegetarianCb = new CheckBox();
            label1 = new Label();
            restaurantsLb = new ListBox();
            showBtn = new Button();
            ExitBtn = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(GlutenCb);
            groupBox1.Controls.Add(VeganCb);
            groupBox1.Controls.Add(VegetarianCb);
            groupBox1.Location = new Point(220, 39);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(250, 169);
            groupBox1.TabIndex = 0;
            groupBox1.TabStop = false;
            groupBox1.Text = "Select Dietary Restrictions";
            // 
            // GlutenCb
            // 
            GlutenCb.AutoSize = true;
            GlutenCb.Location = new Point(68, 139);
            GlutenCb.Name = "GlutenCb";
            GlutenCb.Size = new Size(108, 24);
            GlutenCb.TabIndex = 2;
            GlutenCb.Text = "Gluten-Free";
            GlutenCb.UseVisualStyleBackColor = true;
            // 
            // VeganCb
            // 
            VeganCb.AutoSize = true;
            VeganCb.Location = new Point(68, 88);
            VeganCb.Name = "VeganCb";
            VeganCb.Size = new Size(72, 24);
            VeganCb.TabIndex = 1;
            VeganCb.Text = "Vegan";
            VeganCb.UseVisualStyleBackColor = true;
            // 
            // VegetarianCb
            // 
            VegetarianCb.AutoSize = true;
            VegetarianCb.Location = new Point(68, 43);
            VegetarianCb.Name = "VegetarianCb";
            VegetarianCb.Size = new Size(102, 24);
            VegetarianCb.TabIndex = 0;
            VegetarianCb.Text = "Vegetarian";
            VegetarianCb.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(211, 277);
            label1.Name = "label1";
            label1.Size = new Size(268, 20);
            label1.TabIndex = 1;
            label1.Text = "These are your local restaurant options:";
            // 
            // restaurantsLb
            // 
            restaurantsLb.FormattingEnabled = true;
            restaurantsLb.Location = new Point(211, 311);
            restaurantsLb.Name = "restaurantsLb";
            restaurantsLb.Size = new Size(277, 104);
            restaurantsLb.TabIndex = 2;
            // 
            // showBtn
            // 
            showBtn.Location = new Point(183, 454);
            showBtn.Name = "showBtn";
            showBtn.Size = new Size(155, 58);
            showBtn.TabIndex = 3;
            showBtn.Text = "Show Restaurants";
            showBtn.UseVisualStyleBackColor = true;
            showBtn.Click += showBtn_Click;
            // 
            // ExitBtn
            // 
            ExitBtn.Location = new Point(394, 464);
            ExitBtn.Name = "ExitBtn";
            ExitBtn.Size = new Size(94, 33);
            ExitBtn.TabIndex = 4;
            ExitBtn.Text = "Exit";
            ExitBtn.UseVisualStyleBackColor = true;
            ExitBtn.Click += ExitBtn_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(658, 558);
            Controls.Add(ExitBtn);
            Controls.Add(showBtn);
            Controls.Add(restaurantsLb);
            Controls.Add(label1);
            Controls.Add(groupBox1);
            Name = "Form1";
            Text = "Restaurant Selector";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private GroupBox groupBox1;
        private CheckBox GlutenCb;
        private CheckBox VeganCb;
        private CheckBox VegetarianCb;
        private Label label1;
        private ListBox restaurantsLb;
        private Button showBtn;
        private Button ExitBtn;
    }
}
