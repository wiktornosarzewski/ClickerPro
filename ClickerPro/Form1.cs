using System.Media;

namespace ClickerPro
{
    
    public partial class Form1 : Form
    {
        public int score; // = 0;
        public int level = 1; //poziom gracza
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            //kiedy gracz klika przycisk:
            score = score + 1;
            //SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\chimes.wav");
            SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Windows Notify System Generic.wav");
            simpleSound.Play();
        }

        private void wynikVal_Click(object sender, EventArgs e)
        {

        }

        private void timer1_Tick(object sender, EventArgs e)
        { //glowna petla programu
            wynikVal.Text = score.ToString(); //konwersja typu int -> str, czyli liczbowy na ci¹g tekstowy
            label2.Text = level.ToString();
            if (score == 100) 
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring01.wav");
                simpleSound.PlaySync();
                level++; // poziom 2
            }
            if (score == 120)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring02.wav");
                simpleSound.PlaySync();
                level++; //3
            }
            if (score == 160)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring03.wav");
                simpleSound.PlaySync();
                level++; //4
            }
            if (score == 180)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring04.wav");
                simpleSound.PlaySync();
                level++; //5
            }
            if (score == 220)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring05.wav");
                //simpleSound.Play();
                simpleSound.PlaySync();
                level++; //6
            }
            if (score == 260)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring06.wav");
                simpleSound.PlaySync();
                level++; //7
            }
            if (score == 300)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring07.wav");
                simpleSound.PlaySync();
                level++; //8
            }
            if (score == 340)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring08.wav");
                simpleSound.PlaySync();
                level++; //9
            }
            if (score == 380)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring09.wav");
                simpleSound.PlaySync();
                level++; //10
            }
            if (score == 420)
            {
                SoundPlayer simpleSound = new SoundPlayer(@"c:\Windows\Media\Ring10.wav");
                simpleSound.PlaySync();
                level++; //11
            }
            if (score == level * 50) //40
            {
                level++; //kolejne PRO poziomy!
            }

        }

        private void pictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e) //tekst poziomu
        {

        }
    }
}