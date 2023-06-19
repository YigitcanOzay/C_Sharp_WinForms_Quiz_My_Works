namespace Quiz_My_Works
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        int SoruNo = 0, dogru = 0, yanlis = 0;

        private void buttonNEXT_Click(object sender, EventArgs e)
        {

            buttonA.Enabled = true;
            buttonB.Enabled = true;
            buttonC.Enabled = true;
            buttonD.Enabled = true;
            buttonNEXT.Enabled = true;
            pictureBox1.Visible = false;
            pictureBox2.Visible = false;

            SoruNo++;
            label4SN.Text = SoruNo.ToString();

            if (SoruNo == 1)
            {
                RichTextBoxSoru.Text = "1023 MB kaç GB'týr?";
                buttonA.Text = "1 GB";
                buttonB.Text = "2 GB";
                buttonC.Text = "3 GB";
                buttonD.Text = "4 GB";
                label4.Text = "1 GB";

            }
            if (SoruNo == 2)
            {
                RichTextBoxSoru.Text = "Hangisi Þehir Ege bölgemizde bulunmaz?";
                buttonA.Text = "Muðla";
                buttonB.Text = "Aydýn";
                buttonC.Text = "Ýzmir";
                buttonD.Text = "Diyarbakýr";
                label4.Text = "Diyarbakýr";
            }
            if (SoruNo == 3)
            {
                RichTextBoxSoru.Text = "DHCP nin Açýlýmý nedir ?";
                buttonA.Text = "Dynamic Host Configuration Protocol";
                buttonB.Text = "Devrimci Halk Kurtuluþ Partisi-Cephesi";
                buttonC.Text = "Direct healthcare professional communications";
                buttonD.Text = "Defence Medical Services";
                label4.Text = "Dynamic Host Configuration Protocol";
                buttonNEXT.Text = "Sonuçlar:";
            }
            if (SoruNo == 4)
            {
                buttonA.Enabled = false;
                buttonB.Enabled = false;
                buttonC.Enabled = false;
                buttonD.Enabled = false;
                buttonNEXT.Enabled = false;
                MessageBox.Show("Doðru" + dogru + "\n" + "Yanlýþ: " + yanlis);
            }
        }

        private void buttonA_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNEXT.Enabled = true;

            label5.Text = buttonA.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label5DD.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6YY.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonB_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNEXT.Enabled = true;

            label5.Text = buttonB.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label5DD.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6YY.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonC_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNEXT.Enabled = true;

            label5.Text = buttonC.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label5DD.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6YY.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }

        private void buttonD_Click(object sender, EventArgs e)
        {
            buttonA.Enabled = false;
            buttonB.Enabled = false;
            buttonC.Enabled = false;
            buttonD.Enabled = false;
            buttonNEXT.Enabled = true;

            label5.Text = buttonD.Text;
            if (label4.Text == label5.Text)
            {
                dogru++;
                label5DD.Text = dogru.ToString();
                pictureBox2.Visible = true;
            }
            else
            {
                yanlis++;
                label6YY.Text = yanlis.ToString();
                pictureBox1.Visible = true;
            }
        }
    }
}