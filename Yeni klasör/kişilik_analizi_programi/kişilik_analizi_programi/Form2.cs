using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace kişilik_analizi_programi
{
    public partial class Form2 : Form
    {
       
        public Form2()
        {
            InitializeComponent();
        }
        int toplam = 0;
        private void Form2_Load(object sender, EventArgs e)
        {
            Form1 f1 = (Form1)Application.OpenForms["Form1"];
            label1.BackColor = Color.Green;
            label2.BackColor = Color.Red;
            
            if (f1.toplam <= 40 && f1.toplam >= 9)
            {
                pictureBox1.Visible = true;
                label3.Text = "İnsanlar sizi mantıklı, ihtiyatlı, dikkatli ve pratik birisi olarak görürler. Sizi zeki, yetenekli ve hünerli ama alçak" + Environment.NewLine + "gönüllü olarak tanırlar. Çok hızlı arkadaşlık kurmayan, ama arkadaşlarına karşı çok sadık olan ve" + Environment.NewLine + "onlardan da aynı şeyi bekleyen birisiniz.";
            }
            if(f1.toplam <= 50 && f1.toplam >= 41)
            {
                pictureBox1.Visible = false;
                pictureBox2.Visible = true;
                label3.Text = "İnsanlar sizi taze, canlı, çekici, eğlendirici, pratik ve daima ilginç birisi olarak görürler; her zaman ilgi odağı olan"+ Environment.NewLine + "ama çok aşırıya kaçmayacak kadar da dengeli birisi.. İnsanlar sizi ayrıca iyiliksever, düşünceli, anlayışlı"+ Environment.NewLine + "ve kendilerini neşelendiren ve rahatlatan birisi olarak tanırlar.";
            }
            if(f1.toplam <= 60 && f1.toplam >= 51)
            {
                pictureBox2.Visible = false;
                pictureBox3.Visible = true;
                label3.Text = "insanlar sizi heyecan verici, havai, düşüncesiz yapıda, doğal liderlik özellikleri olan, her zaman doğru olmasa da hızlı"+ Environment.NewLine + "karar veren birisi olarak tanırlar. Seni cesur, maceraperest birisi olarak tanırlar; her şeyi bir kez denemek isteyen,"+ Environment.NewLine + "macera yaşamak için fırsatları kaçırmayan birisi.. Yaydığınız heyecandan dolayı insanlar sizinle aynı iş yerinde yaşamaktan zevk alırlar.";
            }
            if(f1.toplam >= 60)
            {
                pictureBox3.Visible = false;
                pictureBox4.Visible = true;
                label3.Text = "İnsanlar sana kırılgan bir eşya muamelesi yapıyorlar. Kibirli, bencil ve aşırı baskın birisi olarak görülüyorsun. İnsanlar"+ Environment.NewLine + "size hayranlık duyup sizin gibi olmak isteyebilirler ama size her zaman güvenmezler ve sizinle çok yakın ilişkide olmaktan kaçınırlar.";
            }
           
        }
    }
}
