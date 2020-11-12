using System;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Windows.Forms;

namespace MonkeyPiracy
{
    public partial class Form : System.Windows.Forms.Form
    {
        Image[] listUpDial = {  Properties.Resources.face_b0,
                            Properties.Resources.face_b7,
                            Properties.Resources.face_b2,
                            Properties.Resources.face_b6,
                            Properties.Resources.face_b1,
                            Properties.Resources.face_b3,
                            Properties.Resources.face_b5,
                            Properties.Resources.face_b8,
                            Properties.Resources.face_b4
                        };

        Image[] listBottomDial = {  Properties.Resources.face_a0,
                                Properties.Resources.face_a7,
                                Properties.Resources.face_a2,
                                Properties.Resources.face_a6,
                                Properties.Resources.face_a1,
                                Properties.Resources.face_a3,
                                Properties.Resources.face_a5,
                                Properties.Resources.face_a8,
                                Properties.Resources.face_a4
                            };

        int[,] dataDial = { { 1,2,4,5,9,10,13,14,15 },
                        { 15,1,3,4,8,9,12,13,14 },
                        { 13,14,1,2,6,7,10,11,12 },
                        { 12,13,15,1,5,6,9,10,11 },
                        { 8,9,11,12,1,2,5,6,7 },
                        { 7,8,10,11,15,1,4,5,6 },
                        { 4,5,7,8,12,13,1,2,3 },
                        { 3,4,6,7,11,12,15,1,2 },
                        { 2,3,5,6,10,11,14,15,1 }
                      };

        String[][] valuesDial = { new String [] { "St. Kitts", "1712", "1542", "1565", "1720", "1664", "1566", "1592", "1654", "1635", "1639", "1695", "1704", "1711", "1609", "1681" } ,
                            new String [] { "Tortuga", "1604", "1653", "1641", "1690", "1682", "1601", "1619", "1680", "1621", "1652", "1689", "1713", "1697", "1696", "1624" },
                            new String [] { "Antigua", "1710", "1651", "1679", "1719", "1694", "1632", "1668", "1703", "1726", "1564", "1615", "1599", "1669", "1660", "1687" },
                            new String [] { "Barbados", "1725", "1630", "1709", "1594", "1614", "1563", "1649", "1693", "1577", "1678", "1686", "1597", "1718", "1658", "1702" },
                            new String [] { "Jamaica", "1613", "1580", "1723", "1717", "1684", "1698", "1643", "1559", "1573", "1708", "1701", "1724", "1667", "1691", "1685" },
                            new String [] { "Montserrat", "1692", "1656", "1567", "1674", "1662", "1655", "1646", "1671", "1611", "1672", "1562", "1721", "1666", "1673", "1670" },
                            new String [] { "Nebraska","1665", "1706", "1506", "1722", "1716", "1584", "1551", "1627", "1707", "1688", "1699", "1568", "1705", "1579", "1585" }
                            };

        Image[] listUpMix = {  Properties.Resources.mix_a0,
                               Properties.Resources.mix_a1,
                               Properties.Resources.mix_a2,
                               Properties.Resources.mix_a3,
                               Properties.Resources.mix_a4,
                               Properties.Resources.mix_a6,
                               Properties.Resources.mix_a7,
                               Properties.Resources.mix_a8,
                               Properties.Resources.mix_a9,
                               Properties.Resources.mix_aA,
                               Properties.Resources.mix_aB,
                               Properties.Resources.mix_aC,
                               Properties.Resources.mix_aD,
                               Properties.Resources.mix_aE

                        };

        Image[] listDownMix = {  Properties.Resources.mix_b0,
                               Properties.Resources.mix_b1,
                               Properties.Resources.mix_b2,
                               Properties.Resources.mix_b3,
                               Properties.Resources.mix_b4,
                               Properties.Resources.mix_b5,
                               Properties.Resources.mix_b6,
                               Properties.Resources.mix_b7,
                               Properties.Resources.mix_b8,
                               Properties.Resources.mix_b9,
                               Properties.Resources.mix_bA,
                               Properties.Resources.mix_bB,
                               Properties.Resources.mix_bC,
                               Properties.Resources.mix_bD,
                               Properties.Resources.mix_bE

                        };

        int[,] dataMix = { { 1,15,14,13,12,11,10,9,8,7,6,5,4,3,2 },
                           { 2,1,15,14,13,12,11,10,9,8,7,6,5,4,3 },
                           { 3,2,1,15,14,13,12,11,10,9,8,7,6,5,4 },
                           { 4,3,2,1,15,14,13,12,11,10,9,8,7,6,5 },
                           { 5,4,3,2,1,15,14,13,12,11,10,9,8,7,6 },
                           { 7,6,5,4,3,2,1,15,14,13,12,11,10,9,8 },
                           { 8,7,6,5,4,3,2,1,15,14,13,12,11,10,9 },
                           { 9,8,7,6,5,4,3,2,1,15,14,13,12,11,10 },
                           { 10,9,8,7,6,5,4,3,2,1,15,14,13,12,11 },
                           { 11,10,9,8,7,6,5,4,3,2,1,15,14,13,12 },
                           { 12,11,10,9,8,7,6,5,4,3,2,1,15,14,13 },
                           { 13,12,11,10,9,8,7,6,5,4,3,2,1,15,14 },
                           { 14,13,12,11,10,9,8,7,6,5,4,3,2,1,15 },
                           { 15,14,13,12,11,10,9,8,7,6,5,4,3,2,1 }
                        };

        String[][][] valuesMix = { new string[][] { new string[] { "Worms","","" },
                                                    new string[] { "11", "52" },
                                                    new string[] { "11", "41" },
                                                    new string[] { "16", "22" },
                                                    new string[] { "39", "58" },
                                                    new string[] { "56", "16" },
                                                    new string[] { "30", "47" },
                                                    new string[] { "33", "54" },
                                                    new string[] { "13", "36" },
                                                    new string[] { "27", "12" },
                                                    new string[] { "28", "43" },
                                                    new string[] { "16", "16" },
                                                    new string[] { "24", "29" },
                                                    new string[] { "27", "48" },
                                                    new string[] { "34", "25" },
                                                    new string[] { "37", "22" } },
                                    new string[][] { new string[] { "Gout","","" },
                                                    new string[] { "45", "51" },
                                                    new string[] { "24", "38" },
                                                    new string[] { "47", "34" },
                                                    new string[] { "32", "48" },
                                                    new string[] { "38", "44" },
                                                    new string[] { "25", "46" },
                                                    new string[] { "14", "12" },
                                                    new string[] { "34", "39" },
                                                    new string[] { "56", "47" },
                                                    new string[] { "56", "16" },
                                                    new string[] { "51", "15" },
                                                    new string[] { "46", "22" },
                                                    new string[] { "15", "40" },
                                                    new string[] { "26", "18" },
                                                    new string[] { "15", "60" } },
                                    new string[][] { new string[] { "Scurvy", "","" },
                                                    new string[] { "38", "17" },
                                                    new string[] { "60", "24" },
                                                    new string[] { "26", "17" },
                                                    new string[] { "30", "46" },
                                                    new string[] { "23", "48" },
                                                    new string[] { "17", "23" },
                                                    new string[] { "24", "37" },
                                                    new string[] { "28", "31" },
                                                    new string[] { "12", "45" },
                                                    new string[] { "32", "44" },
                                                    new string[] { "58", "35" },
                                                    new string[] { "57", "12" },
                                                    new string[] { "12", "13" },
                                                    new string[] { "32", "54" },
                                                    new string[] { "53", "50" } },
                                    new string[][] { new string[] { "Warts", "","" },
                                                    new string[] { "44", "30" },
                                                    new string[] { "34", "45" },
                                                    new string[] { "48", "23" },
                                                    new string[] { "15", "52" },
                                                    new string[] { "50", "39" },
                                                    new string[] { "39", "20" },
                                                    new string[] { "25", "31" },
                                                    new string[] { "31", "48" },
                                                    new string[] { "50", "38" },
                                                    new string[] { "19", "12" },
                                                    new string[] { "44", "34" },
                                                    new string[] { "16", "19" },
                                                    new string[] { "11", "56" },
                                                    new string[] { "26", "20" },
                                                    new string[] { "36", "19" } },
                                    new string[][] { new string[] { "Trench Mouth", "","" },
                                                    new string[] { "27", "11" },
                                                    new string[] { "28", "22" },
                                                    new string[] { "30", "16" },
                                                    new string[] { "26", "57" },
                                                    new string[] { "48", "11" },
                                                    new string[] { "42", "50" },
                                                    new string[] { "15", "54" },
                                                    new string[] { "26", "12" },
                                                    new string[] { "32", "29" },
                                                    new string[] { "60", "16" },
                                                    new string[] { "22", "38" },
                                                    new string[] { "54", "54" },
                                                    new string[] { "30", "50" },
                                                    new string[] { "48", "22" },
                                                    new string[] { "60", "36" } },
                                    new string[][] { new string[] { "Tattoo Rash", "","" },
                                                    new string[] { "60", "41" },
                                                    new string[] { "27", "21" },
                                                    new string[] { "55", "23" },
                                                    new string[] { "47", "34" },
                                                    new string[] { "57", "13" },
                                                    new string[] { "21", "13" },
                                                    new string[] { "30", "49" },
                                                    new string[] { "50", "57" },
                                                    new string[] { "52", "20" },
                                                    new string[] { "29", "51" },
                                                    new string[] { "24", "47" },
                                                    new string[] { "37", "47" },
                                                    new string[] { "34", "51" },
                                                    new string[] { "21", "44" },
                                                    new string[] { "17", "36" } },
                                    new string[][] { new string[] { "Peg Leg Rot", "","" },
                                                    new string[] { "48", "20" },
                                                    new string[] { "34", "22" },
                                                    new string[] { "19", "21" },
                                                    new string[] { "15", "15" },
                                                    new string[] { "32", "27" },
                                                    new string[] { "42", "21" },
                                                    new string[] { "31", "17" },
                                                    new string[] { "11", "48" },
                                                    new string[] { "58", "55" },
                                                    new string[] { "23", "25" },
                                                    new string[] { "22", "17" },
                                                    new string[] { "42", "26" },
                                                    new string[] { "49", "34" },
                                                    new string[] { "20", "59" },
                                                    new string[] { "42", "57" } }
                            };

        public Form()
        {
            InitializeComponent();
        }

        private void Form_Load(object sender, EventArgs e)
        {
            pictureBoxDown.Image = FixedSize(listBottomDial[hScrollBarDown.Value], listBottomDial[hScrollBarDown.Value].Width * 2, listBottomDial[hScrollBarDown.Value].Height * 2);
            pictureBoxUp.Image = FixedSize(listUpDial[hScrollBarUp.Value], listUpDial[hScrollBarUp.Value].Width * 2, listUpDial[hScrollBarUp.Value].Height * 2);

            pictureMixDown.Image = FixedSize(listDownMix[hScrollBarMixDown.Value], listDownMix[hScrollBarMixDown.Value].Width * 2, listDownMix[hScrollBarMixDown.Value].Height * 2);
            pictureMixUp.Image = FixedSize(listUpMix[hScrollBarMixUp.Value], listUpMix[hScrollBarMixUp.Value].Width * 2, listUpMix[hScrollBarMixUp.Value].Height * 2);

            listView.Items.Add(new ListViewItem(valuesDial[0], -1));
            listView.Items.Add(new ListViewItem(valuesDial[1], -1));
            listView.Items.Add(new ListViewItem(valuesDial[2], -1));
            listView.Items.Add(new ListViewItem(valuesDial[3], -1));
            listView.Items.Add(new ListViewItem(valuesDial[4], -1));
            listView.Items.Add(new ListViewItem(valuesDial[5], -1));
            listView.Items.Add(new ListViewItem(valuesDial[6], -1));

            listViewMix.Items.Add(new ListViewItem(valuesMix[0][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[1][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[2][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[3][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[4][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[5][0], -1));
            listViewMix.Items.Add(new ListViewItem(valuesMix[6][0], -1));

            pictureBoxDown.Tag = listBottomDial;
            pictureBoxUp.Tag = listUpDial;

            pictureMixDown.Tag = listDownMix;
            pictureMixUp.Tag = listUpMix;

            hScrollBarUp.Tag = pictureBoxUp;
            hScrollBarDown.Tag = pictureBoxDown;

            hScrollBarMixUp.Tag = pictureMixUp;
            hScrollBarMixDown.Tag = pictureMixDown;

            PopulateRecettes();
        }

        private void hScrollBarMix_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar scrollbar = (HScrollBar)sender;
            PictureBox pictureBox = (PictureBox)scrollbar.Tag;
            Image[] list = (Image[])pictureBox.Tag;

            pictureBox.Image = FixedSize(list[scrollbar.Value], list[scrollbar.Value].Width * 2, list[scrollbar.Value].Height * 2);
            
            PopulateRecettes();
        }

        private void PopulateRecettes()
        {
            int x = hScrollBarMixUp.Value;
            int y = hScrollBarMixDown.Value;

            listViewMix.Items[0].SubItems[1].Text = valuesMix[0][dataMix[x, y]][0];
            listViewMix.Items[0].SubItems[2].Text = valuesMix[0][dataMix[x, y]][1];
            listViewMix.Items[1].SubItems[1].Text = valuesMix[1][dataMix[x, y]][0];
            listViewMix.Items[1].SubItems[2].Text = valuesMix[1][dataMix[x, y]][1];
            listViewMix.Items[2].SubItems[1].Text = valuesMix[2][dataMix[x, y]][0];
            listViewMix.Items[2].SubItems[2].Text = valuesMix[2][dataMix[x, y]][1];
            listViewMix.Items[3].SubItems[1].Text = valuesMix[3][dataMix[x, y]][0];
            listViewMix.Items[3].SubItems[2].Text = valuesMix[3][dataMix[x, y]][1];
            listViewMix.Items[4].SubItems[1].Text = valuesMix[4][dataMix[x, y]][0];
            listViewMix.Items[4].SubItems[2].Text = valuesMix[4][dataMix[x, y]][1];
            listViewMix.Items[5].SubItems[1].Text = valuesMix[5][dataMix[x, y]][0];
            listViewMix.Items[5].SubItems[2].Text = valuesMix[5][dataMix[x, y]][1];
            listViewMix.Items[6].SubItems[1].Text = valuesMix[6][dataMix[x, y]][0];
            listViewMix.Items[6].SubItems[2].Text = valuesMix[6][dataMix[x, y]][1];
        }

        private void hScrollBarDial_ValueChanged(object sender, EventArgs e)
        {
            HScrollBar scrollbar = (HScrollBar)sender;
            PictureBox pictureBox = (PictureBox)scrollbar.Tag;
            Image[] list = (Image[])pictureBox.Tag;

            pictureBox.Image = FixedSize(list[scrollbar.Value], list[scrollbar.Value].Width * 2, list[scrollbar.Value].Height * 2);
            PopulateDate();
        }

        private void PopulateDate()
        {
            int x = hScrollBarUp.Value;
            int y = hScrollBarDown.Value;

            listView.Items[0].SubItems[1].Text = valuesDial[0][dataDial[x, y]];
            listView.Items[1].SubItems[1].Text = valuesDial[1][dataDial[x, y]];
            listView.Items[2].SubItems[1].Text = valuesDial[2][dataDial[x, y]];
            listView.Items[3].SubItems[1].Text = valuesDial[3][dataDial[x, y]];
            listView.Items[4].SubItems[1].Text = valuesDial[4][dataDial[x, y]];
            listView.Items[5].SubItems[1].Text = valuesDial[5][dataDial[x, y]];
            listView.Items[6].SubItems[1].Text = valuesDial[6][dataDial[x, y]];
        }

        private Image FixedSize(Image imgPhoto, int Width, int Height)
        {
            int sourceWidth = imgPhoto.Width;
            int sourceHeight = imgPhoto.Height;
            float nPercentW = Width / (float)sourceWidth;
            float nPercentH = Height / (float)sourceHeight;
            float nPercent;

            if (nPercentH < nPercentW)
                nPercent = nPercentH;
            else
                nPercent = nPercentW;

            int destWidth = (int)(sourceWidth * nPercent);
            int destHeight = (int)(sourceHeight * nPercent);

            Bitmap bmPhoto = new Bitmap(destWidth, destHeight, PixelFormat.Format32bppPArgb);
            bmPhoto.SetResolution(imgPhoto.HorizontalResolution, imgPhoto.VerticalResolution);

            Graphics grPhoto = Graphics.FromImage(bmPhoto);
            grPhoto.Clear(Color.Transparent);
            grPhoto.InterpolationMode = InterpolationMode.Default;

            grPhoto.DrawImage(imgPhoto,
                new Rectangle(0, 0, destWidth, destHeight),
                new Rectangle(0, 0, sourceWidth, sourceHeight),
                GraphicsUnit.Pixel);

            grPhoto.Dispose();
            return bmPhoto;
        }

        private void listView_ItemSelectionChanged(object sender, ListViewItemSelectionChangedEventArgs e)
        {
            if (e.IsSelected)
                e.Item.Selected = false;
        }
    }
}
