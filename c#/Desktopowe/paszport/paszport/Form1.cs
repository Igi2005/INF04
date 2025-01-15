namespace paszport
{
    public partial class Form1 : Form
    {

        public List<string> Data = new List<string>();

        public void setData()
        {
            Data.Add("111");
            Data.Add("333");
        }

        public Form1()
        {
            InitializeComponent();

            radioButton1.Checked = true;
            setData();
        }

        private void textBox1_Leave(object sender, EventArgs e)
        {
            //XIEGA TU CZYTAJ 
            //Pobranie wszystkich zdjec z Properties.Resources czyli zdjecia ktore dodajesz
            var resources = Properties.Resources.ResourceManager;

            // pobranie numeru zdjecia
            string numer = textBox1.Text;

            //tworzenie szablonu nazwy zdjecia
            string photo1 = numer + "-zdjecie";
            string photo2 = numer + "-odcisk";

            //tworzenie sciezki do zdjecia (chyba)
            var setPhoto1 = (Bitmap)resources.GetObject(photo1);
            var setPhoto2 = (Bitmap)resources.GetObject(photo2);

            //na to nie patrz
            if (Data.Contains(numer))
            {
                /*if (numer == "111")
                {
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;

                    pictureBox2.Image = Properties.Resources._111_zdjecie;
                    pictureBox1.Image = Properties.Resources._111_odcisk;
                }
                if (numer == "333")
                {
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;

                    pictureBox2.Image = Properties.Resources._333_zdjecie;
                    pictureBox1.Image = Properties.Resources._333_odcisk;
                }*/
                //jesli znalaz³o zdjecie
                if (setPhoto1 != null)
                {
                    //czyszczenie poprzednich
                    pictureBox1.Image = null;
                    pictureBox2.Image = null;

                    //ustawianie nowych
                    pictureBox1.Image = setPhoto2;
                    pictureBox2.Image = setPhoto1;
                }
            }
            else
            {
                MessageBox.Show("ni ma takiego ");
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string res = "";
            string name = textBox2.Text;
            string surname = textBox3.Text;

            if(name == null || name == "" || surname == null || surname == "")
            {
                res = "WprowadŸ dane!";
            }
            else
            {
                res = "Imiê " + name + " Nazwisko " + surname;
                if (radioButton1.Checked)
                {
                    res += " Kolor oczu niebieskie.";
                }
                if (radioButton2.Checked)
                {
                    res += "Kolor oczu to zielone";
                }
                if (radioButton3.Checked)
                {
                    res += "Kolor oczu to per³owe.";
                }
            }



            MessageBox.Show(res);
        }
    }
}
