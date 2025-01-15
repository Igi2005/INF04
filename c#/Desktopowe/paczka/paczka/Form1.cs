namespace paczka
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            radioButton1.Checked = true;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (radioButton1.Checked)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Properties.Resources.pocztowka;
                cena.Text = "Cena 1z³";
            }
            else if (radioButton2.Checked)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Properties.Resources.list;
                cena.Text = "Cena 1,5z³";
            }
            else if (radioButton3.Checked)
            {
                pictureBox1.Image = null;
                pictureBox1.Image = Properties.Resources.paczka;
                cena.Text = "Cena 10z³";
            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            string komunikat = "";
            bool validate = true;
            int min_range = '0';
            int max_range = '9';
            int x = 100;
            char test = (char)x;

            if(kod.Text.Length == 5)
            {
                for(int i = 0; i < kod.Text.Length; i++)
                {
                    int asci = kod.Text[i];
                    if(asci >= min_range && max_range >= asci)
                    {
                        continue;
                    }
                    else
                    {
                        validate = false;
                        break;
                    }
                }
                if(!validate)
                {
                    komunikat = "Kod pocztowy powinien siê sk³adaæ z samych cyfr";
                    
                }
                else if(validate)
                {
                    komunikat = "Dane przesy³ki zosta³y wprowadzone";
                }
                
            }
            if(kod.Text.Length != 5)
            {
                komunikat = "Nieprawid³owa liczba cyfr w kodzie pocztowym";
            }
            komunikat+= "\n x -> 100 test to " + test;
            MessageBox.Show(komunikat);
        }
    }
}
