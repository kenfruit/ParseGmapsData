using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ParseGmapsData
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void ProcessButton_Click(object sender, EventArgs e)
        {
            string inputText = InputText.Text;



            List<float> listLat = new List<float>();
            List<float> listLong = new List<float>();
            List<float[]> listLonLat = new List<float[]>();



            string[] pp;
            string temp1;
            string temp2;
            string temp3;


            // Split data string into individual lines
            string[] piecesParts = inputText.Split('\n');




            // Get rid of everything but the Long/Lat
            // Convert to float and add to the lists
            foreach (var piecesPart in piecesParts)
            {
                if (!piecesPart.Contains("lon=") && !piecesPart.Contains("lat="))
                {
                    continue;
                }

                temp1 = piecesPart.Replace("<rtept lat=\"", "");
                temp2 = temp1.Replace("\" lon=\"", ",");
                temp3 = temp2.Replace("\">\r","");



                pp = temp3.Split(',');
            
                if(pp.Length == 2)
                {
                    float lat = float.Parse(pp[0]);
                    float lon = float.Parse(pp[1]);
                    listLat.Add(lat);
                    listLong.Add(lon);
                    float[] ff = { lat, lon };
                    listLonLat.Add(ff);
                }

            }

            // Get the Max, Min and Averages to find the center of the map

            float latMax = listLat.Max();
            float lonMax = listLong.Max();

            float latMin = listLat.Min();
            float lonMin = listLong.Min();

            float width = latMax - latMin;
            float height = lonMax - lonMin;

            float latCenter = (latMax + latMin) / 2;
            float lonCenter = (lonMax + lonMin) / 2;

            int zoom = 14;
            if (.016 < width || .024 < height)
                zoom = 13;
            
            string outputText = "|| {{#display_map: ";

 

            if (0 < inputMile1.Text.Length)
            {
                inputMile1.Text.Replace(" ", "");
                string[] LonLat1 = inputMile1.Text.Split(',');

                outputText += LonLat1[0].Substring(0, LonLat1[0].IndexOf('.') + 6);
                outputText += ",";
                outputText += LonLat1[1].Substring(0, LonLat1[1].IndexOf('.') + 6);
                outputText += "~ ~ ~ ~ ~1;";
            }

            if (0 < inputMile2.Text.Length)
            {
                inputMile2.Text.Replace(" ", "");
                string[] LonLat2 = inputMile2.Text.Split(',');

                outputText += LonLat2[0].Substring(0, LonLat2[0].IndexOf('.') + 6);
                outputText += ",";
                outputText += LonLat2[1].Substring(0, LonLat2[1].IndexOf('.') + 6);
                outputText += "~ ~ ~ ~ ~2;";
            }

            if (0 < inputMile3.Text.Length)
            {
                inputMile3.Text.Replace(" ", "");
                string[] LonLat3 = inputMile3.Text.Split(',');

                outputText += LonLat3[0].Substring(0, LonLat3[0].IndexOf('.') + 6);
                outputText += ",";
                outputText += LonLat3[1].Substring(0, LonLat3[1].IndexOf('.') + 6);
                outputText += "~ ~ ~ ~ ~3;";
            }

            if (0 < inputMile4.Text.Length)
            {
                inputMile4.Text.Replace(" ", "");
                string[] LonLat4 = inputMile4.Text.Split(',');

                outputText += LonLat4[0].Substring(0, LonLat4[0].IndexOf('.') + 6);
                outputText += ",";
                outputText += LonLat4[1].Substring(0, LonLat4[1].IndexOf('.') + 6);
                outputText += "~ ~ ~ ~ ~4;";
            }


            outputText += "| lines = \n";
            foreach (var lonlat in listLonLat)
            {
                outputText += lonlat[0];
                outputText += ",";
                outputText += lonlat[1];
                outputText += ": ";


            }



            outputText += "|center= ";
            outputText += latCenter;
            outputText += ",";
            outputText += lonCenter;



            outputText += "|zoom=" + zoom;
            outputText += "|width=285 |height=285|controls = \"\"}} ";
            outputText += inputDate.Text;

            if (0 < inputDistance.Text.Length)
                outputText += " "+ inputDistance.Text + " miles";

            OutputText.Text = outputText;



        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }
    }
}
