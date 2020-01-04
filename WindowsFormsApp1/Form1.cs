using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
            button10.Visible = false;
            textBox2_set_time_one.Text = "0";
            textBox1.MaxLength = 150;
            
        }

        Form_monitor form = new Form_monitor();

        // Buttonn to open first ER
        private void Button2_Click(object sender, EventArgs e)
        {
            form.Show();
        }

        // Button to close the first ER
        private void Button3_close_er_Click(object sender, EventArgs e)
        {
            form.Hide();
        }

        //Button to give the tip
        private void Button1_Click(object sender, EventArgs e)
        {
            form.setLabelText(textBox1.Text);
            label12_actual_tip.Text = textBox1.Text;
            textBox1.Clear();
        }

        private void Load_tips()
        {
            try
            {   // Open the text file using a stream reader.
                using (StreamReader file = new StreamReader("podpowiedzi.txt"))
                {
                    //set list view in details mode
                    listView1.View = View.Details;
                    // Read the stream to a string, and write the string to the console.
                    String line = file.ReadToEnd();
                    //first value in txt - lines     
                        int temp = int.Parse(line.Split(';')[0].ToString());          
                    //dodawanie wierszy do listview
                    for (int k = 1; k <= temp+1; k++)
                    {
                        listView1.Items.Add(line.Split(';')[k].ToString());
                    }
                    file.Close();

                    
                }
            }
            catch (IOException k)
            {
                MessageBox.Show("The file could not be read:");
                MessageBox.Show(k.Message + "BŁĘDYYYYY");
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Load_tips();
        }

        int timeLeft = 0;
        int secounds = 0;
        private void Timer1_Tick(object sender, EventArgs e)
        {
            if (timeLeft > 0)
            {
                //timeleft w sekundach
                timeLeft = timeLeft - 1;

                //timeleft w minutach
                int minutes = timeLeft / 60;
                label_minites.Text = minutes.ToString();

                //Odejmowanie sekund od minut żeby sekundy liczyły się "co minutę";
                secounds = timeLeft - (minutes * 60);
                label7_time_info_one.Text = secounds.ToString();

                //timeleft w godzinach
                int hours = int.Parse(label_minites.Text) / 60;
                label9_hours.Text = hours.ToString();

                form.setLabelTimeText(minutes.ToString(), secounds.ToString());
                //Przesyłać do form_monitor
                // 1. label_minutes
                // 2. label7_time_info_one
                // 3. label9_hours
                if (secounds == 0 && minutes == 0)
                {
                    form.setLabelText("KONIEC CZASU");
                    label12_actual_tip.Text = "KONIEC CZASU";
                }
            }
            else
            {
                timer1.Stop();
                button5_set_time_one.Enabled = true;
            }
        }



        private void Button5_set_time_one_Click(object sender, EventArgs e)
        {
            if (int.Parse(textBox2_set_time_one.Text) == 0 || int.Parse(textBox2_set_time_one.Text) < 0)
            {
                MessageBox.Show("Czas nie może być mniejszy lub równy 0.");
            }
            else
            {
                timeLeft = int.Parse(textBox2_set_time_one.Text);
                timer1.Start();
                textBox2_set_time_one.Clear();
                form.setLabelText(string.Empty);
            }
        }



        private void Button3_Click(object sender, EventArgs e)
        {
            form.setLabelText(string.Empty);
            label12_actual_tip.Text = string.Empty;
            textBox1.Text = string.Empty;
        }

        //BUTTON 10 minut
        private void Button4_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 600.ToString();
        }

        //BUTTON 20 minut
        private void Button5_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 1200.ToString();
        }

        //BUTTON 30 minut
        private void Button6_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 1800.ToString();
        }

        //BUTTON 40 minut
        private void Button7_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 2400.ToString();
        }

        //BUTTON 50 minut
        private void Button8_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 3000.ToString();
        }

        //BUTTON 50 minut
        private void Button9_Click(object sender, EventArgs e)
        {
            textBox2_set_time_one.Text = 3600.ToString();
        }

        private void Button10_stop_timer_Click(object sender, EventArgs e)
        {
            timer1.Stop();
            button10.Visible = true;
        }

        private void Button10_Click(object sender, EventArgs e)
        {
            timer1.Start();
            button10.Visible = false;
        }

        private void Button11_Click(object sender, EventArgs e)
        {
            Form1 formone = new Form1();
            formone.BackColor = Color.Black;
            int temp = int.Parse(label5_nr_room.Text) + 1;
            formone.label5_nr_room.Text = temp.ToString();
            formone.Show();
        }

        
        private void ListView1_SelectedIndexChanged(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                textBox1.Text = listView1.SelectedItems[0].Text;
            }
        }

        private void Button12_del_tip_Click(object sender, EventArgs e)
        {
            foreach (ListViewItem item in listView1.SelectedItems)
            {
                listView1.SelectedItems[0].Remove();
            }
            textBox1.Text = string.Empty;
        }

        private void Button12_refresh_Click(object sender, EventArgs e)
        {
            listView1.Items.Clear();
            Load_tips();
        }

        private void Button_add_tip_Click(object sender, EventArgs e)
        {
            listView1.Items.Add(textBox1.Text);
        }

        private void Button12_Click(object sender, EventArgs e)
        {
           // try
          //  {
                var counter = 0;
                int temp = 1;
 
            using (var tw = new StreamWriter("podpowiedzi.txt"))
                {
                
                foreach (ListViewItem item in listView1.Items)
                {
                    temp = counter++;
                }

                tw.WriteLine(temp + ";");

                foreach (ListViewItem item in listView1.Items)
                    {
                        tw.WriteLine(item.Text + ";");
                    }
                    tw.Close();
                }
                var lines = File.ReadAllLines("podpowiedzi.txt").Where(arg => !string.IsNullOrWhiteSpace(arg));
                File.WriteAllLines("podpowiedzi.txt", lines);
                
         ///   }
          //  catch (Exception o)
         //   {
            //    MessageBox.Show("Problem z zapisem danych.");
          //  }
        }
    }
}
