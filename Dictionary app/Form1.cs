using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Dictionary_app
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void inputButton_Click(object sender, EventArgs e)
        {
            var my_Dictionary = new Dictionary<string, string>()
            {
                {"king" , "Boqor" },
                {"queen" ,"boqorad" },
                {"word" ,  "erayga" },
                {"hot","kulul" },
                 {"but","lakiin" },
                  {"can","awood" },
                   {"Tell","sheeg" },
                    {"play","Ciyaar" },
                     {"read","akhrin" },
                      {"write","qorid" },
                       {"cook","karin" },
                        {"large","wayn" },
                         {"small","yar" },
                          {"thin","dhuupan" },
                           {"port","dakad" },
                            {"act","fall" },
                             {"change","isbadalka" },
                              {"house","guri" },
                               {"picture","sawir" },
                                {"animal","xayawaan" },
                                 {"mother","hooyo" },
                                  {"father","aabo" },
                                   {"earth","dhul" },
                                    {"try","izkuday" },
                                     {"new","cusub" },
                                      {"work","shaqo" },
                                       {"self","naf" },
                                        {"part","qayp" },
                                         {"one","midh" },
                                          {"live","nolol" },

            };
            string word;
            word = inputBox.Text;

            try
            {
                resultBox.Text = my_Dictionary[word];
            }
            catch
            {
                resultBox.Text = "sorry word not found";
            }
        }

        private void inputBox_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
