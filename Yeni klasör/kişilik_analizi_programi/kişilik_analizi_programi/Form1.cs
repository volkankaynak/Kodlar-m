namespace kişilik_analizi_programi
{
    public partial class Form1 : Form
    {
        Form2 form2 = new Form2();
        
        public static string giriş;
        public Form1()
        {
            InitializeComponent();
        }
        int soruno = 0;
        int cevap = 0;
        public int toplam = 0;

        private void button1_Click(object sender, EventArgs e)
        {
            if (soruno == 0 && button1.Text == label3.Text)
            {
                toplam += 2;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
                
                
                
                
            }
            if(soruno == 1 && button1.Text == label3.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if(soruno == 2 && button1.Text == label3.Text )
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 3 && button1.Text == label3.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 4 && button1.Text == label3.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 5 && button1.Text == label3.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 6 && button1.Text == label3.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 7 && button1.Text == label3.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 8 && button1.Text == label3.Text)
            {
                toplam = toplam + 7;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 7;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 10 && button1.Text == label3.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }

            button1.BackColor = Color.Green;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            soruno++;
            button1.Enabled = false;



        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (soruno == 0 && button2.Text == label4.Text)
            {
                toplam += 4;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 1 && button2.Text == label4.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 2 && button2.Text == label4.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 3 && button2.Text == label4.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 4 && button2.Text == label4.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
               
               
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 5 && button2.Text == label4.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 6 && button2.Text == label4.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 7 && button2.Text == label4.Text)
            {
                toplam = toplam + 7;
                label9.Text = toplam.ToString(); 
                
                form2.progressBar1.Value += 7;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 8 && button2.Text == label4.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 10 && button2.Text == label4.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }

            button2.BackColor = Color.Green;
            
            button1.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            soruno++;
            button2.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (soruno == 0 && button3.Text == label5.Text)
            {
                toplam += 6;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();

            }
            if (soruno == 1 && button3.Text == label5.Text)
            {
                toplam = toplam + 7;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 7;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 2 && button3.Text == label5.Text)
            {
                toplam = toplam + 5;
                label9.Text = toplam.ToString();
                
              
                form2.progressBar1.Value += 5;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 3 && button3.Text == label5.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 4 && button3.Text == label5.Text)
            {
                toplam = toplam + 3;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 3;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 5 && button3.Text == label5.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 6 && button3.Text == label5.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 7 && button3.Text == label5.Text)
            {
                toplam = toplam + 5;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 5;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 8 && button3.Text == label5.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString(); Form2 form2 = new Form2();
                
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 10 && button3.Text == label5.Text)
            {
                toplam = toplam + 3;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 3;
                form2.label1.Text = toplam.ToString();
            }
            button3.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            soruno++;
            button3.Enabled = false;

        }

        private void button4_Click(object sender, EventArgs e)
        {
            if (soruno == 1 && button4.Text == label6.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 2 && button4.Text == label6.Text)
            {
                toplam = toplam + 7;
                label9.Text = toplam.ToString();
                
                
                form2.progressBar1.Value += 7;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 3 && button4.Text == label6.Text)
            {
                toplam = toplam + 1;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 1;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 4 && button4.Text == label6.Text)
            {
                toplam = toplam + 5;
                label9.Text = toplam.ToString();
                
              
                form2.progressBar1.Value += 5;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 7 && button4.Text == label6.Text)
            {
                toplam = toplam + 4;
                label9.Text = toplam.ToString();
               
              
                form2.progressBar1.Value += 4;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 8 && button4.Text == label6.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();

            }
            if (soruno == 10 && button4.Text == label6.Text)
            {
                toplam = toplam + 5;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 5;
                form2.label1.Text = toplam.ToString();

            }


            button4.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button5.Enabled = false;
            button6.Enabled = false;
            soruno++;
            button4.Enabled = false;

        }

        private void btne_Click(object sender, EventArgs e)
        {
            if (soruno == 1 && button5.Text == label7.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 2 && button5.Text == label7.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 4 && button5.Text == label7.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
                
               
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 7 && button5.Text == label7.Text)
            {
                toplam = toplam + 3;
                label9.Text = toplam.ToString();
                
              
                form2.progressBar1.Value += 3;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 8 && button5.Text == label7.Text)
            {
                toplam = toplam + 1;
                label9.Text = toplam.ToString();
               
               
                form2.progressBar1.Value += 1;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 10 && button5.Text == label7.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
              
             
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();
            }
            button5.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button6.Enabled = false;
            soruno++;
            button5.Enabled = false;


        }

        private void button6_Click(object sender, EventArgs e)
        {
            if(soruno == 7 && button6.Text == label8.Text)
            {
                toplam = toplam + 2;
                label9.Text = toplam.ToString();
               
                
                form2.progressBar1.Value += 2;
                form2.label1.Text = toplam.ToString();
            }
            if (soruno == 10 && button6.Text == label8.Text)
            {
                toplam = toplam + 6;
                label9.Text = toplam.ToString();
               
               
                form2.progressBar1.Value += 6;
                form2.label1.Text = toplam.ToString();

            }


            button6.BackColor = Color.Green;
            button1.Enabled = false;
            button2.Enabled = false;
            button3.Enabled = false;
            button4.Enabled = false;
            button5.Enabled = false;
            soruno++;
            button6.Enabled = false;

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            Form2 f2 = (Form2)Application.OpenForms["Form2"];
            MessageBox.Show("Karakterini bulmak ister misin ? ");
            pictureBox11.Visible = true;
            label10.Visible = true;
            label10.Text = "Öncelikli olarak merhaba güzel insan. Eğer sen de nasıl bir psikoljiye sahip olduğunu merak ediyor ve"+ Environment.NewLine + "bunu öğrenmek istiyorsan doğru yerdesin. Programımız veriğin cevaplara göre puanlama yaparak" + Environment.NewLine + "senin nasıl bir karaktere sahip olduğunu ortaya çıkarıyor." + Environment.NewLine + "Hadi hemen BAŞLA butonuna tıkla ve nasıl bir karaktere sahipsin öğren. ";
        }

        private void button7_Click(object sender, EventArgs e)
         
        {
            if( soruno == 0)
            {
              






                pictureBox11.Visible = false;   
                pictureBox1.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                label1.Visible = true;
                label10.Visible = false;
                label1.Text = "1) Kendinizi ne zaman en iyi hissedersiniz ?";
                button1.Text = " Sabahları";
                button2.Text = " Öğlenden sonra ve akşama doğru";
                button3.Text = " Gecenin ilerleyen saatlerinde";
                button7.Text = "GEÇ";
                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
               





            }
            if (soruno == 1)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = true;
                button5.Visible = true;




                label1.Text = "2) Nasıl yürürsünüz ?";
                button1.Text = "Hızlı ve uzun adımlarla";
                button2.Text = "Hızlı ve kısa adımlarla";
                button3.Text = "Normalden yavaş ve etrafa bakınarak";
                button4.Text = "Yavaş ve başı eğik";
                button5.Text = "Çok yavaş";


                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;
                label7.Text = button5.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
            }
            if(soruno == 2)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = true;
                button5.Visible = true;

                label1.Text = "3) İnsanlarla konuşurken...";
                button1.Text = "Kollarımı göğsümde katlamış olarak dururum";
                button2.Text = "Ellerimi sıkarım";
                button3.Text = "Bir veya iki elimi belime koyarım";
                button4.Text = "Konuştuğum insanlara dokunur veya ittiririm";
                button5.Text = "Kulağımla oynar, çeneme dokunur veya saçımla oynarım";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;
                label7.Text = button5.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;


            }
            if (soruno == 3)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = true;
                button5.Visible = false;


                label1.Text = "4) Dinlenirken nasıl oturursunuz ?";
                button1.Text = "Dizler katlanmış ve bacaklar birbirine bitişik olarak";
                button2.Text = "Bacaklar çaprazlanmış olarak";
                button3.Text = "Bacaklarımı uzatarak";
                button4.Text = "Bir bacağımı altıma katlayarak";


                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
            }
            if(soruno == 4)
            {
                pictureBox4.Visible = false;
                pictureBox5.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = true;
                button5.Visible = false;


                label1.Text = "5) Çok hoşunuza giden bir şey olduğunda ne yaparsınız ?";
                button1.Text = "Büyük bir kahkaha atarım";
                button2.Text = "Gülerim ama fazla sesli değil";
                button3.Text = "Bir kerelik gülerim";
                button4.Text = "Sessizce gülümserim";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;

            }
            if(soruno == 5)
            {
                pictureBox5.Visible = false;
                pictureBox6.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = false;
                button5.Visible = false;


                label1.Text = "6) Bir partiye veya sosyal etkinliğe katıldığınızda...";
                button1.Text = "Herkes sizi fark edecek şekilde gürültülü bir giriş mi yaparsınız?";
                button2.Text = "Sessiz bir giriş yapıp etrafınızda tanıdık birilerine mi bakarsınız?";
                button3.Text = "Çok sessizce girip kimsenin sizi farketmemesine mi gayret edrsiniz?";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;


                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if(soruno == 6)
            {
                pictureBox6.Visible = false;
                pictureBox7.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button4.Visible = false;
                button5.Visible = false;

                label1.Text = "7) Çok zor bir işe dikkatinizi vermişken rahatsız ediliyorsunuz. Ne yaparsınız?";
                button1.Text = "Bölünmeyi memnuniyetle karşılarım";
                button2.Text = "Aşırı derecede rahatsız olurum";
                button3.Text = "Belli olmaz. Bu iki uç arasında değişken tavırlar gösteririm";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;


                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
            }
            if(soruno == 7)
            {
                pictureBox7.Visible = false;
                pictureBox8.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;

                label1.Text = "8) En çok hangi rengi seversiniz ?";
                button1.Text = "Kırmızı veya portakal rengi";
                button2.Text = "Siyah";
                button3.Text = "Sarı veya mavi";
                button4.Text = "Yeşil";
                button5.Text = "Koyu mavi veya mor";
                button6.Text = "beyaz";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;
                label7.Text = button5.Text;
                label8.Text = button6.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
                button6.BackColor = Color.Transparent;
            }
            if(soruno == 8)
            {
                pictureBox8.Visible = false;
                pictureBox9.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = false;

                label1.Text = "9) Yatakta uyumadan önceki birkaç dakikada...";
                button1.Text = "Sırt üstü yatıp uzanırsınız";
                button2.Text = "Karnınızın üstüne yatıp uzanırsınız";
                button3.Text = "Hafif kıvrılmış olarak yan tarafınıza yatarsınız";
                button4.Text = "Başınızı bir kolunuzun üzerine koyarsınız";
                button5.Text = "Başınızı yorganın altına kapatırsınız";

                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;
                label7.Text = button5.Text;
                label8.Text = button6.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
                button6.BackColor = Color.Transparent;


            }
            if( soruno == 9)
            {
                pictureBox9.Visible = false;
                pictureBox10.Visible = true;
                button1.Enabled = true;
                button2.Enabled = true;
                button3.Enabled = true;
                button4.Enabled = true;
                button5.Enabled = true;
                button6.Enabled = true;
                button1.Visible = true;
                button2.Visible = true;
                button3.Visible = true;
                button4.Visible = true;
                button5.Visible = true;
                button6.Visible = true;


                label1.Text = "10) Rüyanızda genellikle...";
                button1.Text = "Düşersiniz";
                button2.Text = "Kavga eder veya tartışırsınız";
                button3.Text = "Birilerini veya bir şeyler ararsınız";
                button4.Text = "Uçar veya yüzersiniz";
                button5.Text = "Genelde rüya görmezsiniz";
                button6.Text = "Rüyalarınız daima hoştur";
                button7.Text = "BİTİR";
                label3.Text = button1.Text;
                label4.Text = button2.Text;
                label5.Text = button3.Text;
                label6.Text = button4.Text;
                label7.Text = button5.Text;
                label8.Text = button6.Text;

                button1.BackColor = Color.Transparent;
                button2.BackColor = Color.Transparent;
                button3.BackColor = Color.Transparent;
                button4.BackColor = Color.Transparent;
                button5.BackColor = Color.Transparent;
                button6.BackColor = Color.Transparent;

                soruno++;
              
            }
            if(soruno == 11)
            {
                form2.Show();
            }
















        }
    }
}