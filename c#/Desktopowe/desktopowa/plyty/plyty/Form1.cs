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

namespace plyty
{
    public partial class Form1 : Form
    {
        int currentIndex = 0;
        int len = 0;
        public Form1()
        {
            InitializeComponent();

            Pliki.getData();
            Pliki.setData();
            len = Pliki.setLenOfProperties();
            setContainersOnStart();
        }

        public void setContainersOnStart()
        {
            label1.Text = Pliki.listOfObj[0].artist;
            label2.Text = Pliki.listOfObj[0].album;
            label3.Text = (Pliki.listOfObj[0].songsNumber).ToString();
            label4.Text = Pliki.listOfObj[0].yearOfEdition;
            label5.Text = (Pliki.listOfObj[0].downloadNumber).ToString();
        }

        public void setContainers(int value)
        {
            label1.Text = Pliki.listOfObj[value].artist;
            label2.Text = Pliki.listOfObj[value].album;
            label3.Text = (Pliki.listOfObj[value].songsNumber).ToString();
            label4.Text = Pliki.listOfObj[value].yearOfEdition;
            label5.Text = (Pliki.listOfObj[value].downloadNumber).ToString();
        }

        //dodawanie 
        private void button1_Click(object sender, EventArgs e)
        {
            string downloadNumber = label5.Text;
            int int_downloadNumber = int.Parse(downloadNumber);
            int_downloadNumber += 1;
            Pliki.listOfObj[currentIndex].downloadNumber = int_downloadNumber;
            label5.Text = (Pliki.listOfObj[currentIndex].downloadNumber).ToString();
        }
        //prawo
        private void button2_Click(object sender, EventArgs e)
        {
            currentIndex += 1;
            if (currentIndex > len - 1)
            {
                currentIndex = 0;
            }
            setContainers(currentIndex);
        }
        //lewo
        private void button3_Click(object sender, EventArgs e)
        {
            currentIndex -= 1;
            if (currentIndex < 0)
            {
                currentIndex = len - 1;
            }
            setContainers(currentIndex);
        }
    }
    public partial class Pliki
    {
        public string artist;
        public string album;
        public int songsNumber;
        public string yearOfEdition;
        public int downloadNumber;

        public static List<Pliki> listOfObj = new List<Pliki>();
        public static List<string> properties = new List<string>();

        public static int lenOfProperties = 0;

        public static void getData()
        {
            StreamReader file = new StreamReader("Data.txt");
            string line = file.ReadLine();

            while (line != null)
            {
                if (line != "")
                {
                    properties.Add(line);
                }
                line = file.ReadLine();
            }
        }
        public static void setData()
        {
            for (int i = 0; i < properties.Count; i += 5)
            {
                Pliki obj = new Pliki();
                obj.artist = properties[i];
                obj.album = properties[i + 1];
                obj.songsNumber = int.Parse(properties[i + 2]);
                obj.yearOfEdition = properties[i + 3];
                obj.downloadNumber = int.Parse(properties[i + 4]);
                listOfObj.Add(obj);
            }
        }

        public static int setLenOfProperties()
        {
            lenOfProperties = listOfObj.Count;
            return lenOfProperties;
        }
    }
}
