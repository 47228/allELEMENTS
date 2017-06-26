using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace AllElements
{
    public partial class Form1 : Form
    {
        Button newButton = new Button();
        public Form1()
        {
            InitializeComponent();
        }

        private void treeView1_AfterSelect(object sender, TreeViewEventArgs e)
        {
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            switch (treeView1.SelectedNode.Text)
            {
                case "Button (Кнопка)":
                    
                    newButton.Size = new Size(100, 70);
                    newButton.Location = new Point(500, 100);
                    newButton.Text = "Новая кнопка";
                    this.Controls.Add(newButton);
                    newButton.Click += new EventHandler(butclick);
                    break;
                case "CheckBox (Галочка)":
                    checkboxform nwform = new checkboxform();
                    nwform.ShowDialog();
                    break;
                case "ComboBox":
                    comboboxform nwcbform = new comboboxform();
                    nwcbform.ShowDialog();
                    break;
                case "ListBox":
                    listboxform newForm = new listboxform();
                    newForm.Show();
                    break;
                case "Radiobutton":
                    RAdiobutForm newFOrm = new RAdiobutForm();
                    newFOrm.ShowDialog();
                    break;
                case "TextBox":
                    TExtboxForm newFormtxt = new TExtboxForm();
                    newFormtxt.ShowDialog();
                    break;
                case "RichBox":
                    richtextboxform newFormRich = new richtextboxform();
                    newFormRich.ShowDialog();
                    break;
                case "TabControl":
                    tabcontrolForm newFormTAb = new tabcontrolForm();
                    newFormTAb.ShowDialog();
                    break;

            }
        }
            private void butclick (object sender, EventArgs e)
        {
            newButton.Dispose();
        }
        
    }
}
