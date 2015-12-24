using System;
using System.IO;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using System.Xml.Linq;

namespace Triax_Fejlrapportering
{
    public partial class MainForm : Form
    {
        public List<Data> FailData;
        xml xml;
        public MainForm()
        {
            InitializeComponent();
            FailData = new List<Data>();
            xml = new xml();
            xml.ReadDataXml(xml.ReadStartXml());
            foreach (string n in xml.names)
            {
                Navnbox.Items.Add(n);
            }
            foreach (string f in xml.faults)
            {
                ÅrsagBox.Items.Add(f);
            }
            foreach (Products p in xml.products)
            {
                VNummer.Items.Add(p.ProductName);
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            btnSave.Enabled = false;
            int compstock;
            Products myProduct = xml.products.Find(p => p.ProductName == VNummer.SelectedItem.ToString());
            MyExcel.DB_PATH = myProduct.RefPath;
            MyExcel.InitializeExcel();
            string[] exceldata = MyExcel.ReadFromExcel(myProduct.ComponentStockNumber, myProduct.ValueCol, myProduct.PlacementCol, myProduct.StartRow, KompBox.Text);
            MyExcel.CloseExcel();
            int.TryParse(exceldata[0], out compstock);
            Data data = new Data
            {
                Name = Navnbox.SelectedItem.ToString(),
                ComponentStockNumber = compstock,
                RepDate = DateTime.Now.Date,
                RepTime = TidSlider.Value,
                Fault = ÅrsagBox.SelectedItem.ToString(),
                Notes = Notebox.Text,
                PositionNumber = KompBox.Text,
                StockNumber = myProduct.StockNumber
            };
            MyExcel.DB_PATH = xml.endlocation;
            MyExcel.InitializeExcel();
            MyExcel.WriteToExcel(data);
            MyExcel.CloseExcel();
            btnSave.Enabled = true;
        }

        private void Notebox_Enter(object sender, EventArgs e)
        {
            if (string.Equals(Notebox.Text, "Noter"))
            {
                Notebox.Text = "";
            }

        }

        private void Notebox_Leave(object sender, EventArgs e)
        {
            if (string.Equals(Notebox.Text, ""))
            {
                Notebox.Text = "Noter";
            }
        }

        private void KompBox_Leave(object sender, EventArgs e)
        {
            
        }

        private void KompBox_Enter(object sender, EventArgs e)
        {
            
        }              

        private void KompBox_TextChanged(object sender, EventArgs e)
        {
            if (!string.Equals(KompBox.Text, null)  && !Equals(Navnbox.SelectedIndex, -1) && !Equals(VNummer.SelectedIndex, -1) && !Equals(ÅrsagBox.SelectedIndex, -1))
            {
                btnSave.Enabled = true;
            }            
        }

        private void ÅrsagBox_SelectionChanged(object sender, EventArgs e)
        {
            if (!Equals(Navnbox.SelectedIndex, -1) && !Equals(VNummer.SelectedIndex, -1) && !Equals(ÅrsagBox.SelectedIndex, -1))
            {
                btnSave.Enabled = true;
            }
        }

        

        private void Navnbox_SelectionChanged(object sender, EventArgs e)
        {
            if (!Equals(Navnbox.SelectedIndex, -1) && !Equals(VNummer.SelectedIndex, -1) && !Equals(ÅrsagBox.SelectedIndex, -1))
            {
                btnSave.Enabled = true;
            }
        }

        private void Hentbutton_Click(object sender, EventArgs e)
        {
            Products myProduct = xml.products.Find(p => p.ProductName == VNummer.SelectedItem.ToString());
            Process.Start(myProduct.ComponentTopPath);
            Process.Start(myProduct.ComponentBotPath);
            Fejlpanel.Visible = true;
        }

        private void VNummer_SelectedIndexChanged(object sender, EventArgs e)
        {
            Products myProduct = xml.products.Find(p => p.ProductName == VNummer.SelectedItem.ToString());
            MyExcel.DB_PATH = myProduct.RefPath;
            MyExcel.InitializeExcel();
            string[] exceldata = MyExcel.ReadFromExcel(KompBox.Text, myProduct.StartRow, myProduct.PlacementCol);
            MyExcel.CloseExcel();
            AutoCompleteStringCollection source = new AutoCompleteStringCollection();
            source.AddRange(exceldata);
            KompBox.AutoCompleteCustomSource = source;
            if (!Equals(VNummer.SelectedIndex, -1))
            {
                Hentbutton.Enabled = true;
                Fejlsøg.Enabled = true;
            }
            if (!Equals(Navnbox.SelectedIndex, -1) && !Equals(VNummer.SelectedIndex, -1) && !Equals(ÅrsagBox.SelectedIndex, -1))
            {
                btnSave.Enabled = true;
            }
        }

        private void KompBox_MouseClick(object sender, MouseEventArgs e)
        {

        }

        private void Findbtn_Click(object sender, EventArgs e)
        {
            Products myProduct = xml.products.Find(p => p.ProductName == VNummer.SelectedItem.ToString());
            MyExcel.DB_PATH = myProduct.RefPath;
            MyExcel.InitializeExcel();
            string[] exceldata = MyExcel.ReadFromExcel(myProduct.ComponentStockNumber, myProduct.ValueCol, myProduct.PlacementCol, myProduct.StartRow, KompBox.Text);
            MyExcel.CloseExcel();
            Valbox.Text = exceldata[0];
            Stockbox.Text = exceldata[1];
        }

        private void Fejlsøg_Click(object sender, EventArgs e)
        {
            Products myProduct = xml.products.Find(p => p.ProductName == VNummer.SelectedItem.ToString());
            Process.Start(myProduct.DiagramPath);
        }

        public bool timespent = false;
        public DateTime starttid;
        public DateTime sluttid;
        public TimeSpan tid;
        public int time = 0;

        public void Timeclick()
        {
            switch (timespent)
            {
                case false:
                    starttid = DateTime.UtcNow;
                    timespent = true;
                    Pauseimg.Visible = true;
                    break;
                case true:
                    sluttid = DateTime.UtcNow;
                    timespent = false;
                    tid = sluttid - starttid;
                    time = time + tid.Minutes;
                    TidSlider.Value = time;
                    time = 0;
                    Pauseimg.Visible = false;
                    break;
            }
        }
        private static bool gem;
            
        public void Pauseclick()
        {
            if (!pause)
            {
                Pauseimg.Image = Properties.Resources.play;
                sluttid = DateTime.UtcNow;
                tid = sluttid - starttid;
                time = tid.Minutes;
                pause = true;
                Tidbtn.Enabled = false;
                if (btnSave.Enabled)
                {
                    gem = true;
                    btnSave.Enabled = false;
                }
            }
            else
            {
                Pauseimg.Image = Properties.Resources.pause;
                starttid = DateTime.UtcNow - tid;
                pause = false;
                Tidbtn.Enabled = true;
                if (gem)
                {
                    btnSave.Enabled = true;
                }
            }
        }

        public bool pause = false;

        private void Tidbtn_Click(object sender, EventArgs e)
        {
            Timeclick();
        }

        private void Pauseimg_Click(object sender, EventArgs e)
        {
            Pauseclick();
        }
                







    }
}
