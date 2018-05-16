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
    public partial class Form2 : Form
    {



        

        Character data = new Character();

        //private EventHandler populate;

        public string TextDisplay
        {
            set
            {
                textBox1.Text = value;              
            }
        }
        public string listDisplay
        {
            set
            {
                listBox1.Text = value;
            }
        }
        //public  string Clear

        //{
            
        //    set
        //    {
        //        listBox1.Items.Clear();
        //    }
        //}


        public  Form2(string data)
        {
            // string beach = data;
            InitializeComponent();
            this.listBox1.Items.Add(data);

 
                listBox1.Items.Clear();
           

        }



        //the count for evenhandler
        public void HandleCountChanged(object sender, EventArgs e)

        {
            Form1 mainForm = sender as Form1;
            textBox1.Text = mainForm.ItemCount.ToString();
        }

        public void StoredChanged(object sender, EventArgs e)

        {
            Form1 mainForm = sender as Form1;
            listBox1.Items.Add (mainForm.CharData.ToString());   
        }

       

        //listbox configuation
        public void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Form1 mainForm = sender as Form1;
           // mainForm.CharacterListBox_SelectedIndexChanged(sender, e);

            if (listBox1.SelectedIndex >= 0 && listBox1.SelectedIndex < listBox1.Items.Count)
            {
                Character c = listBox1.Items[listBox1.SelectedIndex] as Character;
                data = c;

                //populate += mainForm.CharacterListBox_SelectedIndexChanged;

                //mainForm.Populate(data);
            }


            //if (populate!= null)
            //{
            //    populate(this, new EventArgs());
            //}
        }

        public void Cleared()

        {
            listBox1.Items.Clear();
        }
         
    }
 }
 