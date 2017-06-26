namespace AllElements
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
            System.Windows.Forms.TreeNode treeNode37 = new System.Windows.Forms.TreeNode("Button (Кнопка)");
            System.Windows.Forms.TreeNode treeNode38 = new System.Windows.Forms.TreeNode("CheckBox (Галочка)");
            System.Windows.Forms.TreeNode treeNode39 = new System.Windows.Forms.TreeNode("ComboBox");
            System.Windows.Forms.TreeNode treeNode40 = new System.Windows.Forms.TreeNode("ListBox");
            System.Windows.Forms.TreeNode treeNode41 = new System.Windows.Forms.TreeNode("Radiobutton");
            System.Windows.Forms.TreeNode treeNode42 = new System.Windows.Forms.TreeNode("TextBox");
            System.Windows.Forms.TreeNode treeNode43 = new System.Windows.Forms.TreeNode("RichBox");
            System.Windows.Forms.TreeNode treeNode44 = new System.Windows.Forms.TreeNode("TabControl");
            System.Windows.Forms.TreeNode treeNode45 = new System.Windows.Forms.TreeNode("Элементы управления", new System.Windows.Forms.TreeNode[] {
            treeNode37,
            treeNode38,
            treeNode39,
            treeNode40,
            treeNode41,
            treeNode42,
            treeNode43,
            treeNode44});
            this.treeView1 = new System.Windows.Forms.TreeView();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeView1
            // 
            this.treeView1.Location = new System.Drawing.Point(13, 13);
            this.treeView1.Name = "treeView1";
            treeNode37.Name = "button";
            treeNode37.Text = "Button (Кнопка)";
            treeNode38.Name = "checkbox";
            treeNode38.Text = "CheckBox (Галочка)";
            treeNode39.Name = "combobox";
            treeNode39.Text = "ComboBox";
            treeNode40.Name = "listbox";
            treeNode40.Text = "ListBox";
            treeNode41.Name = "radiobutton";
            treeNode41.Text = "Radiobutton";
            treeNode42.Name = "textBox";
            treeNode42.Text = "TextBox";
            treeNode43.Name = "richBox";
            treeNode43.Text = "RichBox";
            treeNode44.Name = "tabControl";
            treeNode44.Text = "TabControl";
            treeNode45.BackColor = System.Drawing.Color.White;
            treeNode45.Name = "ElemControl";
            treeNode45.Text = "Элементы управления";
            this.treeView1.Nodes.AddRange(new System.Windows.Forms.TreeNode[] {
            treeNode45});
            this.treeView1.Size = new System.Drawing.Size(253, 218);
            this.treeView1.TabIndex = 0;
            this.treeView1.AfterSelect += new System.Windows.Forms.TreeViewEventHandler(this.treeView1_AfterSelect);
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(13, 238);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(75, 23);
            this.button1.TabIndex = 1;
            this.button1.Text = "Добавить";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1014, 332);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeView1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.TreeView treeView1;
        private System.Windows.Forms.Button button1;
    }
}

