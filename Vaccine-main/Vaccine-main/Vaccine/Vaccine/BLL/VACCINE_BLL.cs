using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;

namespace Vaccine.BLL
{
    class VACCINE_BLL
    {
        private XmlDocument doc = new XmlDocument();
        private XmlElement root;
        private string fileName = @"../../Vaccine.xml";

        public VACCINE_BLL()
        {
            doc.Load(fileName);
            root = doc.DocumentElement;
        }

        public void HienThi(DataGridView dgv)
        {
            dgv.Rows.Clear();
            dgv.ColumnCount = 4;

            XmlNodeList ds = root.SelectNodes("Vaccine");
            int sd = 0;//lưu chỉ số dòng
            foreach (XmlNode item in ds)
            {
                dgv.Rows.Add();
                dgv.Rows[sd].Cells[0].Value = item.SelectSingleNode("MaDanhMuc").InnerText;
                dgv.Rows[sd].Cells[1].Value = item.SelectSingleNode("MaVaccine").InnerText;
                dgv.Rows[sd].Cells[2].Value = item.SelectSingleNode("TenVaccine").InnerText;
                dgv.Rows[sd].Cells[3].Value = item.SelectSingleNode("HSD").InnerText;
              
                sd++;
            }
        }

      
    }
}
