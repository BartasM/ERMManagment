namespace WindowsFormsApp1
{
    partial class Form1
    {
        /// <summary>
        /// Wymagana zmienna projektanta.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Wyczyść wszystkie używane zasoby.
        /// </summary>
        /// <param name="disposing">prawda, jeżeli zarządzane zasoby powinny zostać zlikwidowane; Fałsz w przeciwnym wypadku.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Kod generowany przez Projektanta formularzy systemu Windows

        /// <summary>
        /// Metoda wymagana do obsługi projektanta — nie należy modyfikować
        /// jej zawartości w edytorze kodu.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.button2 = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.button3_close_er = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label7_time_info_one = new System.Windows.Forms.Label();
            this.button5_set_time_one = new System.Windows.Forms.Button();
            this.textBox2_set_time_one = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label_minites = new System.Windows.Forms.Label();
            this.label9_hours = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.label11 = new System.Windows.Forms.Label();
            this.label12_actual_tip = new System.Windows.Forms.Label();
            this.button3 = new System.Windows.Forms.Button();
            this.label12 = new System.Windows.Forms.Label();
            this.button4 = new System.Windows.Forms.Button();
            this.button5 = new System.Windows.Forms.Button();
            this.button6 = new System.Windows.Forms.Button();
            this.button7 = new System.Windows.Forms.Button();
            this.button8 = new System.Windows.Forms.Button();
            this.button9 = new System.Windows.Forms.Button();
            this.button10_stop_timer = new System.Windows.Forms.Button();
            this.button10 = new System.Windows.Forms.Button();
            this.button11 = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.label5_nr_room = new System.Windows.Forms.Label();
            this.listView1 = new System.Windows.Forms.ListView();
            this.columnHeader2 = ((System.Windows.Forms.ColumnHeader)(new System.Windows.Forms.ColumnHeader()));
            this.button12_del_tip = new System.Windows.Forms.Button();
            this.button_add_tip = new System.Windows.Forms.Button();
            this.button12_refresh = new System.Windows.Forms.Button();
            this.button12 = new System.Windows.Forms.Button();
            this.label5 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // textBox1
            // 
            this.textBox1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.textBox1.Location = new System.Drawing.Point(12, 89);
            this.textBox1.Multiline = true;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(413, 55);
            this.textBox1.TabIndex = 0;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button1.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button1.Location = new System.Drawing.Point(12, 152);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(158, 35);
            this.button1.TabIndex = 1;
            this.button1.Text = "Prześlij podpowiedź";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.Button1_Click);
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button2.Location = new System.Drawing.Point(12, 30);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(245, 34);
            this.button2.TabIndex = 2;
            this.button2.Text = "Otwórz okno monitora w E.R";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.Button2_Click);
            // 
            // label2
            // 
            this.label2.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label2.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label2.Location = new System.Drawing.Point(488, 592);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(186, 16);
            this.label2.TabIndex = 4;
            this.label2.Text = "Wszystkie prawa zastrzeżone.";
            // 
            // label3
            // 
            this.label3.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label3.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label3.Location = new System.Drawing.Point(485, 572);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(187, 16);
            this.label3.TabIndex = 5;
            this.label3.Text = "Marczewski.b@gmail.com";
            // 
            // button3_close_er
            // 
            this.button3_close_er.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3_close_er.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3_close_er.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.button3_close_er.Location = new System.Drawing.Point(263, 30);
            this.button3_close_er.Name = "button3_close_er";
            this.button3_close_er.Size = new System.Drawing.Size(162, 34);
            this.button3_close_er.TabIndex = 6;
            this.button3_close_er.Text = "Zamknij okno";
            this.button3_close_er.UseVisualStyleBackColor = false;
            this.button3_close_er.Click += new System.EventHandler(this.Button3_close_er_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label4.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label4.Location = new System.Drawing.Point(8, 7);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(106, 20);
            this.label4.TabIndex = 7;
            this.label4.Text = "Opcje dla E.R";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label6.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label6.Location = new System.Drawing.Point(12, 68);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(145, 20);
            this.label6.TabIndex = 10;
            this.label6.Text = "Wpisz podpowiedź:";
            // 
            // timer1
            // 
            this.timer1.Interval = 1000;
            this.timer1.Tick += new System.EventHandler(this.Timer1_Tick);
            // 
            // label7_time_info_one
            // 
            this.label7_time_info_one.AutoSize = true;
            this.label7_time_info_one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7_time_info_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7_time_info_one.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7_time_info_one.Location = new System.Drawing.Point(588, 256);
            this.label7_time_info_one.Name = "label7_time_info_one";
            this.label7_time_info_one.Size = new System.Drawing.Size(71, 20);
            this.label7_time_info_one.TabIndex = 11;
            this.label7_time_info_one.Text = "Sekundy";
            // 
            // button5_set_time_one
            // 
            this.button5_set_time_one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5_set_time_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5_set_time_one.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button5_set_time_one.Location = new System.Drawing.Point(568, 113);
            this.button5_set_time_one.Name = "button5_set_time_one";
            this.button5_set_time_one.Size = new System.Drawing.Size(102, 34);
            this.button5_set_time_one.TabIndex = 14;
            this.button5_set_time_one.Text = "Ustaw czas";
            this.button5_set_time_one.UseVisualStyleBackColor = false;
            this.button5_set_time_one.Click += new System.EventHandler(this.Button5_set_time_one_Click);
            // 
            // textBox2_set_time_one
            // 
            this.textBox2_set_time_one.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.textBox2_set_time_one.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.textBox2_set_time_one.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.textBox2_set_time_one.Location = new System.Drawing.Point(449, 116);
            this.textBox2_set_time_one.Name = "textBox2_set_time_one";
            this.textBox2_set_time_one.Size = new System.Drawing.Size(113, 31);
            this.textBox2_set_time_one.TabIndex = 15;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label7.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label7.Location = new System.Drawing.Point(502, 200);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(105, 20);
            this.label7.TabIndex = 17;
            this.label7.Text = "Czas nadany:";
            // 
            // label_minites
            // 
            this.label_minites.AutoSize = true;
            this.label_minites.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label_minites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label_minites.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label_minites.Location = new System.Drawing.Point(527, 256);
            this.label_minites.Name = "label_minites";
            this.label_minites.Size = new System.Drawing.Size(55, 20);
            this.label_minites.TabIndex = 19;
            this.label_minites.Text = "Minuty";
            // 
            // label9_hours
            // 
            this.label9_hours.AutoSize = true;
            this.label9_hours.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9_hours.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9_hours.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9_hours.Location = new System.Drawing.Point(454, 256);
            this.label9_hours.Name = "label9_hours";
            this.label9_hours.Size = new System.Drawing.Size(67, 20);
            this.label9_hours.TabIndex = 20;
            this.label9_hours.Text = "Godziny";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label8.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label8.Location = new System.Drawing.Point(454, 228);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(67, 20);
            this.label8.TabIndex = 23;
            this.label8.Text = "Godziny";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label9.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label9.Location = new System.Drawing.Point(527, 228);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(55, 20);
            this.label9.TabIndex = 22;
            this.label9.Text = "Minuty";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label10.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.label10.Location = new System.Drawing.Point(588, 228);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(71, 20);
            this.label10.TabIndex = 21;
            this.label10.Text = "Sekundy";
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label11.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.label11.Location = new System.Drawing.Point(10, 191);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(303, 20);
            this.label11.TabIndex = 24;
            this.label11.Text = "Aktualny wyświetlany komunikat w pokoju:";
            // 
            // label12_actual_tip
            // 
            this.label12_actual_tip.AutoSize = true;
            this.label12_actual_tip.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12_actual_tip.ForeColor = System.Drawing.SystemColors.MenuHighlight;
            this.label12_actual_tip.Location = new System.Drawing.Point(19, 211);
            this.label12_actual_tip.MaximumSize = new System.Drawing.Size(400, 0);
            this.label12_actual_tip.Name = "label12_actual_tip";
            this.label12_actual_tip.Size = new System.Drawing.Size(138, 20);
            this.label12_actual_tip.TabIndex = 25;
            this.label12_actual_tip.Text = "Brak podpowiedzi.";
            // 
            // button3
            // 
            this.button3.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button3.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.button3.Location = new System.Drawing.Point(181, 153);
            this.button3.Name = "button3";
            this.button3.Size = new System.Drawing.Size(244, 35);
            this.button3.TabIndex = 26;
            this.button3.Text = "Wyczyść komunikat";
            this.button3.UseVisualStyleBackColor = false;
            this.button3.Click += new System.EventHandler(this.Button3_Click);
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Italic, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label12.ForeColor = System.Drawing.SystemColors.ButtonShadow;
            this.label12.Location = new System.Drawing.Point(444, 4);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(96, 20);
            this.label12.TabIndex = 27;
            this.label12.Text = "Opcje czasu";
            // 
            // button4
            // 
            this.button4.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button4.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button4.Location = new System.Drawing.Point(494, 30);
            this.button4.Name = "button4";
            this.button4.Size = new System.Drawing.Size(42, 31);
            this.button4.TabIndex = 28;
            this.button4.Text = "10";
            this.button4.UseVisualStyleBackColor = false;
            this.button4.Click += new System.EventHandler(this.Button4_Click);
            // 
            // button5
            // 
            this.button5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button5.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button5.Location = new System.Drawing.Point(542, 30);
            this.button5.Name = "button5";
            this.button5.Size = new System.Drawing.Size(44, 31);
            this.button5.TabIndex = 29;
            this.button5.Text = "20";
            this.button5.UseVisualStyleBackColor = false;
            this.button5.Click += new System.EventHandler(this.Button5_Click);
            // 
            // button6
            // 
            this.button6.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button6.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button6.Location = new System.Drawing.Point(592, 30);
            this.button6.Name = "button6";
            this.button6.Size = new System.Drawing.Size(44, 31);
            this.button6.TabIndex = 30;
            this.button6.Text = "30";
            this.button6.UseVisualStyleBackColor = false;
            this.button6.Click += new System.EventHandler(this.Button6_Click);
            // 
            // button7
            // 
            this.button7.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button7.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button7.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button7.Location = new System.Drawing.Point(492, 68);
            this.button7.Name = "button7";
            this.button7.Size = new System.Drawing.Size(44, 31);
            this.button7.TabIndex = 31;
            this.button7.Text = "40";
            this.button7.UseVisualStyleBackColor = false;
            this.button7.Click += new System.EventHandler(this.Button7_Click);
            // 
            // button8
            // 
            this.button8.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button8.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button8.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button8.Location = new System.Drawing.Point(542, 68);
            this.button8.Name = "button8";
            this.button8.Size = new System.Drawing.Size(44, 31);
            this.button8.TabIndex = 32;
            this.button8.Text = "50";
            this.button8.UseVisualStyleBackColor = false;
            this.button8.Click += new System.EventHandler(this.Button8_Click);
            // 
            // button9
            // 
            this.button9.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button9.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button9.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button9.Location = new System.Drawing.Point(592, 68);
            this.button9.Name = "button9";
            this.button9.Size = new System.Drawing.Size(44, 31);
            this.button9.TabIndex = 33;
            this.button9.Text = "1H";
            this.button9.UseVisualStyleBackColor = false;
            this.button9.Click += new System.EventHandler(this.Button9_Click);
            // 
            // button10_stop_timer
            // 
            this.button10_stop_timer.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10_stop_timer.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10_stop_timer.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button10_stop_timer.Location = new System.Drawing.Point(568, 152);
            this.button10_stop_timer.Name = "button10_stop_timer";
            this.button10_stop_timer.Size = new System.Drawing.Size(102, 36);
            this.button10_stop_timer.TabIndex = 34;
            this.button10_stop_timer.Text = "Czas stop!";
            this.button10_stop_timer.UseVisualStyleBackColor = false;
            this.button10_stop_timer.Click += new System.EventHandler(this.Button10_stop_timer_Click);
            // 
            // button10
            // 
            this.button10.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button10.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.button10.ForeColor = System.Drawing.SystemColors.MenuBar;
            this.button10.Location = new System.Drawing.Point(449, 152);
            this.button10.Name = "button10";
            this.button10.Size = new System.Drawing.Size(113, 36);
            this.button10.TabIndex = 35;
            this.button10.Text = "Czas start!";
            this.button10.UseVisualStyleBackColor = false;
            this.button10.Click += new System.EventHandler(this.Button10_Click);
            // 
            // button11
            // 
            this.button11.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button11.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.button11.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button11.Location = new System.Drawing.Point(16, 562);
            this.button11.Name = "button11";
            this.button11.Size = new System.Drawing.Size(180, 42);
            this.button11.TabIndex = 36;
            this.button11.Text = "Obsługuj kolejny pokój";
            this.button11.UseVisualStyleBackColor = false;
            this.button11.Click += new System.EventHandler(this.Button11_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label1.ForeColor = System.Drawing.Color.OrangeRed;
            this.label1.Location = new System.Drawing.Point(13, 539);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(157, 20);
            this.label1.TabIndex = 37;
            this.label1.Text = "Okno obsługi pokoju:";
            // 
            // label5_nr_room
            // 
            this.label5_nr_room.AutoSize = true;
            this.label5_nr_room.Font = new System.Drawing.Font("Modern No. 20", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5_nr_room.ForeColor = System.Drawing.Color.OrangeRed;
            this.label5_nr_room.Location = new System.Drawing.Point(176, 533);
            this.label5_nr_room.Name = "label5_nr_room";
            this.label5_nr_room.Size = new System.Drawing.Size(25, 29);
            this.label5_nr_room.TabIndex = 38;
            this.label5_nr_room.Text = "1";
            // 
            // listView1
            // 
            this.listView1.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.listView1.BackColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.listView1.Columns.AddRange(new System.Windows.Forms.ColumnHeader[] {
            this.columnHeader2});
            this.listView1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.listView1.ForeColor = System.Drawing.SystemColors.HighlightText;
            this.listView1.HideSelection = false;
            this.listView1.Location = new System.Drawing.Point(12, 296);
            this.listView1.Name = "listView1";
            this.listView1.Size = new System.Drawing.Size(509, 229);
            this.listView1.TabIndex = 39;
            this.listView1.UseCompatibleStateImageBehavior = false;
            this.listView1.View = System.Windows.Forms.View.Details;
            this.listView1.SelectedIndexChanged += new System.EventHandler(this.ListView1_SelectedIndexChanged);
            // 
            // columnHeader2
            // 
            this.columnHeader2.Text = "Treść podpowiedzi";
            this.columnHeader2.Width = 500;
            // 
            // button12_del_tip
            // 
            this.button12_del_tip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12_del_tip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12_del_tip.Location = new System.Drawing.Point(542, 342);
            this.button12_del_tip.Name = "button12_del_tip";
            this.button12_del_tip.Size = new System.Drawing.Size(128, 41);
            this.button12_del_tip.TabIndex = 40;
            this.button12_del_tip.Text = "Usuń podpowiedź";
            this.button12_del_tip.UseVisualStyleBackColor = false;
            this.button12_del_tip.Click += new System.EventHandler(this.Button12_del_tip_Click);
            // 
            // button_add_tip
            // 
            this.button_add_tip.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button_add_tip.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button_add_tip.Location = new System.Drawing.Point(542, 296);
            this.button_add_tip.Name = "button_add_tip";
            this.button_add_tip.Size = new System.Drawing.Size(128, 40);
            this.button_add_tip.TabIndex = 41;
            this.button_add_tip.Text = "Dodaj podpowiedź";
            this.button_add_tip.UseVisualStyleBackColor = false;
            this.button_add_tip.Click += new System.EventHandler(this.Button_add_tip_Click);
            // 
            // button12_refresh
            // 
            this.button12_refresh.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12_refresh.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12_refresh.Location = new System.Drawing.Point(542, 434);
            this.button12_refresh.Name = "button12_refresh";
            this.button12_refresh.Size = new System.Drawing.Size(128, 38);
            this.button12_refresh.TabIndex = 42;
            this.button12_refresh.Text = "Odśwież listę";
            this.button12_refresh.UseVisualStyleBackColor = false;
            this.button12_refresh.Click += new System.EventHandler(this.Button12_refresh_Click);
            // 
            // button12
            // 
            this.button12.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.button12.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.button12.Location = new System.Drawing.Point(542, 389);
            this.button12.Name = "button12";
            this.button12.Size = new System.Drawing.Size(128, 39);
            this.button12.TabIndex = 43;
            this.button12.Text = "Zapisz Listę";
            this.button12.UseVisualStyleBackColor = false;
            this.button12.Click += new System.EventHandler(this.Button12_Click);
            // 
            // label5
            // 
            this.label5.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(238)));
            this.label5.ForeColor = System.Drawing.SystemColors.ButtonFace;
            this.label5.Location = new System.Drawing.Point(485, 556);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 16);
            this.label5.TabIndex = 44;
            this.label5.Text = "Bartosz Marczewski";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.ClientSize = new System.Drawing.Size(686, 617);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.button12);
            this.Controls.Add(this.button12_refresh);
            this.Controls.Add(this.button_add_tip);
            this.Controls.Add(this.button12_del_tip);
            this.Controls.Add(this.listView1);
            this.Controls.Add(this.label5_nr_room);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.button11);
            this.Controls.Add(this.button10);
            this.Controls.Add(this.button10_stop_timer);
            this.Controls.Add(this.button9);
            this.Controls.Add(this.button8);
            this.Controls.Add(this.button7);
            this.Controls.Add(this.button6);
            this.Controls.Add(this.button5);
            this.Controls.Add(this.button4);
            this.Controls.Add(this.label12);
            this.Controls.Add(this.button3);
            this.Controls.Add(this.label12_actual_tip);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.label9_hours);
            this.Controls.Add(this.label_minites);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.textBox2_set_time_one);
            this.Controls.Add(this.button5_set_time_one);
            this.Controls.Add(this.label7_time_info_one);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.button3_close_er);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.textBox1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.Name = "Form1";
            this.Opacity = 0.9D;
            this.ShowIcon = false;
            this.Text = "ESCAPE ROOM MANAGMENT";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button button2;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button button3_close_er;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label7_time_info_one;
        private System.Windows.Forms.Button button5_set_time_one;
        private System.Windows.Forms.TextBox textBox2_set_time_one;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label_minites;
        private System.Windows.Forms.Label label9_hours;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.Label label12_actual_tip;
        private System.Windows.Forms.Button button3;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Button button4;
        private System.Windows.Forms.Button button5;
        private System.Windows.Forms.Button button6;
        private System.Windows.Forms.Button button7;
        private System.Windows.Forms.Button button8;
        private System.Windows.Forms.Button button9;
        private System.Windows.Forms.Button button10_stop_timer;
        private System.Windows.Forms.Button button10;
        private System.Windows.Forms.Button button11;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label5_nr_room;
        private System.Windows.Forms.ListView listView1;
        private System.Windows.Forms.ColumnHeader columnHeader2;
        private System.Windows.Forms.Button button12_del_tip;
        private System.Windows.Forms.Button button_add_tip;
        private System.Windows.Forms.Button button12_refresh;
        private System.Windows.Forms.Button button12;
        private System.Windows.Forms.Label label5;
    }
}

