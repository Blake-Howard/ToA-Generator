using System;
using System.Collections;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DayData;

namespace ToA_Generator
{
    public partial class MainMenuFrm : Form
    {
        private ArrayList DayList = new ArrayList();

        public MainMenuFrm()
        {
            InitializeComponent();
        }

        private void WeatherBtn_Click(object sender, EventArgs e)
        {
            DayData.DayData thing = new DayData.DayData();
            DisplayTxtBox.Text = thing.GenerateRain();

        }
    }
}
