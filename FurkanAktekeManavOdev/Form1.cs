using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.ExceptionServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace FurkanAktekeManavOdev
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        
        public class Node
        {
            public string name;
            public int price;
            public int code;
            public Node next;
            public Node prev;
            
           
        }
        public Node head = null;
        public Node tail = null;

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }

        

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

        }
        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
        private void button3_Click(object sender, EventArgs e)
        {
            Node temp = new Node();
            temp.code = Convert.ToInt32(textBox1.Text);
            temp.name = textBox2.Text;
            temp.price = Convert.ToInt32(textBox3.Text);
            if(head==null)
            {
                head = temp;
                tail = head;
                head.prev = null;
                head.next = tail;
                tail.prev = head;
                tail.next = null;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
            else
            {
                Node sayac = new Node();
                while (sayac != null)
                {
                    if(sayac.code == temp.code )
                    {
                        return;
                    }
                    else if (sayac.code != temp.code )
                    {
                        sayac = sayac.next;
 
                    }
                    else
                    {
                        break;
                    }
                }
                tail.next = temp;
                temp.prev = tail;
                tail = temp;
                tail.next = null;
                textBox1.Clear();
                textBox2.Clear();
                textBox3.Clear();
            }
        }

        private void button4_Click(object sender, EventArgs e)
        {
            
            Node temp = new Node();
            temp.code = Convert.ToInt32(textBox4.Text);
            if (temp.code==head.code)
            {
                head = head.next;
            }
            else if (temp.code==tail.code)
            {
                tail= tail.prev;
                tail.next = null;

                
            }
            
            else
            {
                Node oglesine = head;
                while (oglesine!=null)
                {
                    if (oglesine.code==temp.code)
                    {
                        oglesine.prev.next = oglesine.next;
                        oglesine.next.prev = oglesine.prev;
                        break;
                    }
                    oglesine = head.next;
                }
                
            }
            textBox4.Clear();
            textBox5.Clear();
            textBox6.Clear();
            
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Node temp = new Node();
            temp.code =Convert.ToInt32(textBox7.Text);
            temp.name = textBox8.Text;
            temp.price = Convert.ToInt32(textBox9.Text);
            Node oglesine = head;
            while (oglesine != null)
            {
                if(oglesine.code==temp.code)
                {
                    oglesine.code = temp.code;
                    oglesine.name= temp.name;
                    oglesine.price = temp.price;
                    break;
                }
                oglesine = head.next;
            }
            textBox7.Clear();
            textBox8.Clear();
            textBox9.Clear();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Node temp = new Node();
            temp.code =Convert.ToInt32(textBox4.Text);
            Node oglesine = head;
            while (oglesine!=null)
            {
                if(temp.code == oglesine.code)
                {
                   textBox4.Text = Convert.ToString(oglesine.code);
                   textBox5.Text = oglesine.name;
                   textBox6.Text = Convert.ToString(oglesine.price);
                    break;
                }
                oglesine= oglesine.next;
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Node temp = new Node();
            temp.code =Convert.ToInt32(textBox7.Text);
            Node oglesine = head;
            while (oglesine!=null)
            {
                if(temp.code == oglesine.code)
                {
                    textBox7.Text = Convert.ToString(oglesine.code);
                    textBox8.Text = oglesine.name;
                    textBox9.Text = Convert.ToString(oglesine.price);
                    break;
                }
                oglesine=oglesine.next;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            ListeyiGuncelle(head);
        }
        private void ListeyiGuncelle(Node head) //Yazdırma fonksiyonu
        {
            dataGridView1.Rows.Clear();
            while (head != null)
            {
                dataGridView1.Rows.Add(Convert.ToString(head.code), head.name, Convert.ToString(head.price));
                head = head.next; //ChatGPT'den alınmıştır.
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }
    }
}
