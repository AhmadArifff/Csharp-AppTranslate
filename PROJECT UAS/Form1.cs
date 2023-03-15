using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Web;
using System.Net;
using System.Collections;

namespace PROJECT_UAS
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            //inputkata.Add("Saya");
            //inputkata.Add("Siapa");
            //inputkata.Add("Kapan?");
            //"Nama  : AHMAD ARIF";
            //"NPM   : 40621190002";
        }

        //fungsi translate ngambil LINK google translate
        public String translate(String input, string indonesia, string english)
        {
            var indonesiaLanguage = indonesia;
            var englishLanguage = english;
            var url = $"https://translate.googleapis.com/translate_a/single?client=gtx&sl={indonesiaLanguage}&tl={englishLanguage}&dt=t&q={WebUtility.UrlEncode(input)}";
            var webclient = new WebClient
            {
                Encoding = System.Text.Encoding.UTF8
            };
            var result = webclient.DownloadString(url);
            try
            {
                result = result.Substring(4, result.IndexOf("\"", 4, StringComparison.Ordinal) - 4);
                return result;
            }
            catch (Exception e1)
            {
                return "error";
            }
        }
        // fungsi simpan data untuk tampilkan di listbox
        private void Btn_Simpan_Click(object sender, EventArgs e)
        {
            if (Kata.Text == "" | Arti.Text == "")
            {
                MessageBox.Show("Harap Isi Data Dengan Lengkap!");
            }
            else
            {
                List_Kata.Items.Add(Kata.Text);
                List_Arti.Items.Add(Arti.Text);
                MessageBox.Show("Data Berhasil Disimpan!");
                //MessageBox.Show("Data kata Item ke = " + inputkata.Count + "\nData Arti Item ke = " + inputarti.Count + "\ndapat disimpan!");
                Kata.Clear();
                Arti.Clear();
                Cari.Clear();
                Cari.Enabled = true;
                List_Kata.SelectedItems.Clear();
            }
            Kata.Focus();
        }
        
        // fungsi page form action active real time
        private void Form1_Activated(object sender, EventArgs e)
        {
            // set reset data list box
            Kata.Focus();
            Cari.Enabled = false;
            // set inisialisasi action translate
            string artikata = translate(Kata.Text, "id", "en");
            Arti.Enabled = false;
        }
        // fungsi action clik listbox
        private void List_Kata_Click(object sender, EventArgs e)
        {
            // show message data index di dalam listbox
            //MessageBox.Show("Index Kata Ke = " + List_Kata.SelectedIndex);
            Cari.Enabled = true;
        }
        // fungsi action clik listbox
        private void List_Arti_Click(object sender, EventArgs e)
        {
            // show message data index di dalam listbox
            //MessageBox.Show("Index Arti Ke = " + List_Arti.SelectedIndex);
            Cari.Enabled = true;
        }
        // fungsi set translate menggunakan event "keyup" untuk menambahkan data dalam textbox tanpa action button
        private void Kata_KeyUp(object sender, KeyEventArgs e)
        {
            string artikata = translate(Kata.Text, "id", "en");
            if (e.KeyCode == Keys.Space)
            {
                Arti.ResetText();
                Arti.AppendText(artikata);
            }
        }
        // fungsi set data listbox untuk ditampilkan dalam textbox
        private void List_Kata_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (object ob in List_Kata.SelectedItems)
                {
                    Kata.AppendText(ob.ToString());
                }
            }
            catch
            {
            }
        }
        // fungsi set data listbox untuk ditampilkan dalam textbox
        private void List_Arti_SelectedIndexChanged(object sender, EventArgs e)
        {
            try
            {
                foreach (object ob in List_Arti.SelectedItems)
                {
                    Arti.AppendText(ob.ToString());
                }
            }
            catch
            {
            }
        }
        // fungsi edit
        private void Btn_Edit_Click(object sender, EventArgs e)
        {
            // Update set listbox Kata
            DialogResult dialogResult = MessageBox.Show("Yakin Anda mau ", "mengubahnya?", MessageBoxButtons.YesNo);
            // condisi Yes
            if (dialogResult == DialogResult.Yes)
            {
                // Update set listbox Kata
                int indexKata = List_Kata.SelectedIndex;
                List_Kata.Items.RemoveAt(indexKata);
                List_Kata.Items.Insert(indexKata, Kata.Text);
                // Update set listbox Arti
                int indexArti = List_Arti.SelectedIndex;
                List_Arti.Items.RemoveAt(indexArti);
                List_Arti.Items.Insert(indexArti, Arti.Text);
                Kata.Clear();
                Arti.Clear();
                List_Kata.SelectedItems.Clear();
                Cari.Enabled = true;
            }
            // condisi NO
            else if (dialogResult == DialogResult.No)
            {
                // set clear box
                Kata.Clear();
                Arti.Clear();
                List_Kata.SelectedItems.Clear();
                Cari.Enabled = true;
            }
            Kata.Focus();
        }
        // fungsi cari
        private void Btn_Cari_Click(object sender, EventArgs e)
        {
            Kata.Clear();
            Arti.Clear();
            List_Kata.ClearSelected();
            // fungsi cari listbox kata
            List_Kata.SelectedItems.Clear();
            for(int i = List_Kata.Items.Count - 1; i >= 0; i--)
            {
                if (List_Kata.Items[i].ToString().ToLower().Contains(Cari.Text.ToLower()))
                {
                    List_Kata.SetSelected(i, true);
                }
            }

            string artikata = translate(Cari.Text, "id", "en");
            // fungsi cari listbox arti
            List_Arti.SelectedItems.Clear();
            for (int i = List_Arti.Items.Count - 1; i >= 0; i--)
            {
                if (List_Arti.Items[i].ToString().ToLower().Contains(artikata.ToLower()))
                {
                    List_Arti.SetSelected(i, true);
                }
            }
            Cari.Clear();
            Cari.Focus();
        }
        // fungsi Sorting Ascending dan Descending
        private void filters_SelectedIndexChanged(object sender, EventArgs e)
        {
            // inisialisasi array data item listbox
            ArrayList listkata = new ArrayList();
            ArrayList listarti = new ArrayList();
            if (filters.SelectedItem == "a->z")
            {
                // fungsi sort listbox kata Ascending adalah pengurutan dari yang terkecil ke yang terbesar
                foreach (var item in List_Kata.Items)
                {
                    listkata.Add(item);
                }
                List_Kata.Items.Clear();
                listkata.Sort();
                foreach(var item in listkata)
                {
                    List_Kata.Items.Add(item);
                }
                // fungsi sort listbox arti Ascending adalah pengurutan dari yang terkecil ke yang terbesar
                foreach (var item in List_Arti.Items)
                {
                    listarti.Add(item);
                }
                List_Arti.Items.Clear();
                listarti.Sort();
                foreach (var item in listarti)
                {
                    List_Arti.Items.Add(item);
                }
            }
            else
            {
                // fungsi sort listbox kata Descending adalah pengurutan yang terbesar ke yang terkecil
                foreach (var item in List_Kata.Items)
                {
                    listkata.Add(item);
                }
                List_Kata.Items.Clear();
                listkata.Reverse();
                foreach (var item in listkata)
                {
                    List_Kata.Items.Add(item);
                }
                // fungsi sort listbox arti Descending adalah pengurutan yang terbesar ke yang terkecil
                foreach (var item in List_Arti.Items)
                {
                    listarti.Add(item);
                }
                List_Arti.Items.Clear();
                listarti.Reverse();
                foreach (var item in listarti)
                {
                    List_Arti.Items.Add(item);
                }
            }
            
        }

        
    }
}
