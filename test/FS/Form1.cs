using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq; 
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FS
{

    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnSubmit_Click(object sender, EventArgs e)
        {
            string notes = txtNotes.Text;
            NotesStorage storage = new NotesStorage();
            storage.SaveNote(notes, @"C:\Users\WindowsPC\Documents\notes.txt");
            lstAllNotes.Items.Add(notes);
            txtNotes.Text = "";
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            NotesStorage notesStorage = new NotesStorage();
            List<string> allLines = notesStorage.GetNote(@"C:\Users\WindowsPC\Documents\notes.txt");

            foreach (string singleLine in allLines)
            {
                lstAllNotes.Items.Add(singleLine);
            }
        }
    }
}
