using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.IO;


namespace GeneratorDocs
{
    public partial class MainWin : Form
    {
        public MainWin()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            saver.Filter = "Word files(*.doc)|*.doc";
            if (saver.ShowDialog() == DialogResult.Cancel)
                return;
            string filename = saver.FileName;
            
            string pathParent = "Parent.doc";
            try
            {
                File.Copy(pathParent, filename);
                Editting g = new Editting(filename, UFamily.Text, UNameOtc.Text, UCollege.Text, USpecialnost.Text, USpezializaz.Text, ULearnPrg.Text, UProfQual.Text, Family.Text, NameOtc.Text, College.Text, Specialnost.Text, Spezializaz.Text, LearnPrg.Text, ProfQual.Text);
                g.mau();
            }
            catch (Exception г)
            {
                MessageBox.Show("Вы неосторожны", "Внимательнее");
            }
            
        }
    }
}
