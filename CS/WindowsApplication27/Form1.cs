using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraSpellChecker;
using System.IO;
using System.Reflection;

namespace WindowsApplication27 {
    public partial class Form1 : Form {
        public Form1() {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e) {
            SpellCheckerISpellDictionary dictionary = new SpellCheckerISpellDictionary();
            Stream affStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsApplication27.Dictionaries.english.aff");
            Stream dicStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsApplication27.Dictionaries.american.xlg");
            Stream alphStream = Assembly.GetExecutingAssembly().GetManifestResourceStream("WindowsApplication27.Dictionaries.EnglishAlphabet.txt");
            dictionary.LoadFromStream(dicStream, affStream, alphStream);
            spellChecker1.Dictionaries.Add(dictionary);
        }
    }
}