using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;



namespace Mccormick_Rob_CE03
{



    public partial class Form1 : Form
    {


        // 
        private EventHandler ItemCountChanged;
        private EventHandler _StoredChanged;
        private EventHandler clear;



        Character _Data = new Character();


        public Form1()
        {
            InitializeComponent();
        }

        //getters

        public int ItemCount
        {
            get
            {
                return CharacterListBox.Items.Count;
            }
        }


        //getter
        public string CharData
        {
            get
            {
                string d = Convert.ToString(Data);
                return d;
            }
        }


        //this data passes to the character class
        public Character Data
        {
            get
            {
                Character c = new Character();
                c.Name = NameBox.Text;
                c.Gender = GenderList.Text;
                c.Age = NumericAge.Value;
                return c;
            }
            set
            {                
                NameBox.Text = value.Name;
                GenderList.Text = value.Gender;
                NumericAge.Value = value.Age;
            }
        }



        // the add button, quality the EventHandler 
        private void addButton_Click(object sender, EventArgs e)
        {
            CharacterListBox.Items.Add(Data);
            string _Data = Convert.ToString(Data);
            Form2 frm2 = new Form2(_Data);

            if (ItemCountChanged != null)
            {
                ItemCountChanged(this, new EventArgs());
            }
            if (_StoredChanged != null)
            {  
                _StoredChanged(this, new EventArgs());
            }
        }




        //configuration for listbox
        public void CharacterListBox_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (CharacterListBox.SelectedIndex >= 0 && CharacterListBox.SelectedIndex < CharacterListBox.Items.Count)
            {
                Character c = CharacterListBox.Items[CharacterListBox.SelectedIndex] as Character;

                Data = c;
                string _c = Convert.ToString(Data);        
            }            
        }


       // ToolStrip
        private void displayToolStripMenuItem_Click(object sender, EventArgs e)
        {

            string _c = Convert.ToString(Data);
            string _d = Convert.ToString(_Data);

            // Character c = new Character(); // woops
            Form2 form = new Form2(_c); //   woops

            ItemCountChanged += form.HandleCountChanged;
            _StoredChanged += form.StoredChanged;
             

            form.TextDisplay = CharacterListBox.Items.Count.ToString();
            form.listDisplay = CharacterListBox.Items.ToString();  


            form.Show();

        }




        //populated
        public void Populate(object sender)

        {
                   sender = Data;
                                 }

    

        private void NameBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void clearToolStripMenuItem_Click(object sender, EventArgs e)
        {
             CharacterListBox.Items.Clear();
            string o = "clear" ; 

            Form2 f = new Form2(o);

        
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
