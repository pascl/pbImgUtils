using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Drawing.Imaging;
using System.Drawing.Text;
using System.IO;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace pbImgUtils
{
    public partial class Form1 : Form
    {
        Brush[] knownBrushes = new Brush[] {
            Brushes.AliceBlue,
            Brushes.AntiqueWhite,
            Brushes.Aqua,
            Brushes.Aquamarine,
            Brushes.Azure,
            Brushes.Beige,
            Brushes.Bisque,
            Brushes.Black,
            Brushes.BlanchedAlmond,
            Brushes.Blue,
            Brushes.BlueViolet,
            Brushes.Brown,
            Brushes.BurlyWood,
            Brushes.CadetBlue,
            Brushes.Chartreuse,
            Brushes.Chocolate,
            Brushes.Coral,
            Brushes.CornflowerBlue,
            Brushes.Cornsilk,
            Brushes.Crimson,
            Brushes.Cyan,
            Brushes.DarkBlue,
            Brushes.DarkCyan,
            Brushes.DarkGoldenrod,
            Brushes.DarkGray,
            Brushes.DarkGreen,
            Brushes.DarkKhaki,
            Brushes.DarkMagenta,
            Brushes.DarkOliveGreen,
            Brushes.DarkOrange,
            Brushes.DarkOrchid,
            Brushes.DarkRed,
            Brushes.DarkSalmon,
            Brushes.DarkSeaGreen,
            Brushes.DarkSlateBlue,
            Brushes.DarkSlateGray,
            Brushes.DarkTurquoise,
            Brushes.DarkViolet,
            Brushes.DeepPink,
            Brushes.DeepSkyBlue,
            Brushes.DimGray,
            Brushes.DodgerBlue,
            Brushes.Firebrick,
            Brushes.FloralWhite,
            Brushes.ForestGreen,
            Brushes.Fuchsia,
            Brushes.Gainsboro,
            Brushes.GhostWhite,
            Brushes.Gold,
            Brushes.Goldenrod,
            Brushes.Gray,
            Brushes.Green,
            Brushes.GreenYellow,
            Brushes.Honeydew,
            Brushes.HotPink,
            Brushes.IndianRed,
            Brushes.Indigo,
            Brushes.Ivory,
            Brushes.Khaki,
            Brushes.Lavender,
            Brushes.LavenderBlush,
            Brushes.LawnGreen,
            Brushes.LemonChiffon,
            Brushes.LightBlue,
            Brushes.LightCoral,
            Brushes.LightCyan,
            Brushes.LightGoldenrodYellow,
            Brushes.LightGray,
            Brushes.LightGreen,
            Brushes.LightPink,
            Brushes.LightSalmon,
            Brushes.LightSeaGreen,
            Brushes.LightSkyBlue,
            Brushes.LightSlateGray,
            Brushes.LightSteelBlue,
            Brushes.LightYellow,
            Brushes.Lime,
            Brushes.LimeGreen,
            Brushes.Linen,
            Brushes.Magenta,
            Brushes.Maroon,
            Brushes.MediumAquamarine,
            Brushes.MediumBlue,
            Brushes.MediumOrchid,
            Brushes.MediumPurple,
            Brushes.MediumSeaGreen,
            Brushes.MediumSlateBlue,
            Brushes.MediumSpringGreen,
            Brushes.MediumTurquoise,
            Brushes.MediumVioletRed,
            Brushes.MidnightBlue,
            Brushes.MintCream,
            Brushes.MistyRose,
            Brushes.Moccasin,
            Brushes.NavajoWhite,
            Brushes.Navy,
            Brushes.OldLace,
            Brushes.Olive,
            Brushes.OliveDrab,
            Brushes.Orange,
            Brushes.OrangeRed,
            Brushes.Orchid,
            Brushes.PaleGoldenrod,
            Brushes.PaleGreen,
            Brushes.PaleTurquoise,
            Brushes.PaleVioletRed,
            Brushes.PapayaWhip,
            Brushes.PeachPuff,
            Brushes.Peru,
            Brushes.Pink,
            Brushes.Plum,
            Brushes.PowderBlue,
            Brushes.Purple,
            Brushes.Red,
            Brushes.RosyBrown,
            Brushes.RoyalBlue,
            Brushes.SaddleBrown,
            Brushes.Salmon,
            Brushes.SandyBrown,
            Brushes.SeaGreen,
            Brushes.SeaShell,
            Brushes.Sienna,
            Brushes.Silver,
            Brushes.SkyBlue,
            Brushes.SlateBlue,
            Brushes.SlateGray,
            Brushes.Snow,
            Brushes.SpringGreen,
            Brushes.SteelBlue,
            Brushes.Tan,
            Brushes.Teal,
            Brushes.Thistle,
            Brushes.Tomato,
            Brushes.Turquoise,
            Brushes.Violet,
            Brushes.Wheat,
            Brushes.White,
            Brushes.WhiteSmoke,
            Brushes.Yellow,
            Brushes.YellowGreen
            };

        int orig_width;
        int orig_height;
        float orig_ratio;

        public Form1()
        {
            InitializeComponent();

            this.Text = "pbImgUtils v" + Assembly.GetExecutingAssembly().GetName().Version;

            orig_width = 0;
            orig_height = 0;
            orig_ratio = 0;

            pbImgStart.AllowDrop = true;

            FontFamily[] fontFamilies;

            InstalledFontCollection installedFontCollection = new InstalledFontCollection();
            
            String[] sknownBrushes = new String[] {
"AliceBlue",
"AntiqueWhite",
"Aqua",
"Aquamarine",
"Azure",
"Beige",
"Bisque",
"Black",
"BlanchedAlmond",
"Blue",
"BlueViolet",
"Brown",
"BurlyWood",
"CadetBlue",
"Chartreuse",
"Chocolate",
"Coral",
"CornflowerBlue",
"Cornsilk",
"Crimson",
"Cyan",
"DarkBlue",
"DarkCyan",
"DarkGoldenrod",
"DarkGray",
"DarkGreen",
"DarkKhaki",
"DarkMagenta",
"DarkOliveGreen",
"DarkOrange",
"DarkOrchid",
"DarkRed",
"DarkSalmon",
"DarkSeaGreen",
"DarkSlateBlue",
"DarkSlateGray",
"DarkTurquoise",
"DarkViolet",
"DeepPink",
"DeepSkyBlue",
"DimGray",
"DodgerBlue",
"Firebrick",
"FloralWhite",
"ForestGreen",
"Fuchsia",
"Gainsboro",
"GhostWhite",
"Gold",
"Goldenrod",
"Gray",
"Green",
"GreenYellow",
"Honeydew",
"HotPink",
"IndianRed",
"Indigo",
"Ivory",
"Khaki",
"Lavender",
"LavenderBlush",
"LawnGreen",
"LemonChiffon",
"LightBlue",
"LightCoral",
"LightCyan",
"LightGoldenrodYellow",
"LightGray",
"LightGreen",
"LightPink",
"LightSalmon",
"LightSeaGreen",
"LightSkyBlue",
"LightSlateGray",
"LightSteelBlue",
"LightYellow",
"Lime",
"LimeGreen",
"Linen",
"Magenta",
"Maroon",
"MediumAquamarine",
"MediumBlue",
"MediumOrchid",
"MediumPurple",
"MediumSeaGreen",
"MediumSlateBlue",
"MediumSpringGreen",
"MediumTurquoise",
"MediumVioletRed",
"MidnightBlue",
"MintCream",
"MistyRose",
"Moccasin",
"NavajoWhite",
"Navy",
"OldLace",
"Olive",
"OliveDrab",
"Orange",
"OrangeRed",
"Orchid",
"PaleGoldenrod",
"PaleGreen",
"PaleTurquoise",
"PaleVioletRed",
"PapayaWhip",
"PeachPuff",
"Peru",
"Pink",
"Plum",
"PowderBlue",
"Purple",
"Red",
"RosyBrown",
"RoyalBlue",
"SaddleBrown",
"Salmon",
"SandyBrown",
"SeaGreen",
"SeaShell",
"Sienna",
"Silver",
"SkyBlue",
"SlateBlue",
"SlateGray",
"Snow",
"SpringGreen",
"SteelBlue",
"Tan",
"Teal",
"Thistle",
"Tomato",
"Turquoise",
"Violet",
"Wheat",
"White",
"WhiteSmoke",
"Yellow",
"YellowGreen"
            };

            // Get the array of FontFamily objects.
            fontFamilies = installedFontCollection.Families;

            cbFontUsed.Items.Clear();
            foreach (FontFamily ff in fontFamilies)
            {
                cbFontUsed.Items.Add(ff.Name);
            }
            cbFontUsed.SelectedIndex = Properties.Settings.Default.iFontFamily;

            cbFontColor.Items.Clear();
            foreach (String s in sknownBrushes)
            {
                cbFontColor.Items.Add(s);
            }
            cbFontColor.SelectedIndex = Properties.Settings.Default.iFontColor;

            try
            {
                nudImageWidth.Value = Properties.Settings.Default.iWidth;
            }
            catch(Exception ex)
            {
                //
            }
            try
            {
                nudImageHeight.Value = Properties.Settings.Default.iHeight;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudXText.Value = Properties.Settings.Default.iXposition;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudYText.Value = Properties.Settings.Default.iYposition;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudFontSize.Value = Properties.Settings.Default.iFontSize;
            }
            catch (Exception ex)
            {
                //
            }

            cbBold.Checked = Properties.Settings.Default.bStyleBold;
            cbItalic.Checked = Properties.Settings.Default.bStyleItalic;
            cbUnderline.Checked = Properties.Settings.Default.bStyleUnderline;
            cbStrike.Checked = Properties.Settings.Default.bStyleStrike;

            cbXCenter.Checked = Properties.Settings.Default.bXcentered;
            cbYCenter.Checked = Properties.Settings.Default.bYcentered;

            cbOneFilePerLine.Checked = Properties.Settings.Default.bOneFilePerLine;
            cbKeepOriginalRatio.Checked = Properties.Settings.Default.bKeepAspectRatio;

            try
            {
                nudLines.Value = Properties.Settings.Default.iSplitLines;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudColumns.Value = Properties.Settings.Default.iSplitColumns;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudBorderEast.Value = Properties.Settings.Default.iBorderEast;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudBorderWest.Value = Properties.Settings.Default.iBorderWest;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudBorderNorth.Value = Properties.Settings.Default.iBorderNorth;
            }
            catch (Exception ex)
            {
                //
            }
            try
            {
                nudBorderSouth.Value = Properties.Settings.Default.iBorderSouth;
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void btSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == sfdImg.ShowDialog())
            {
                String sFileName = sfdImg.FileName;
                try
                {
                    Bitmap[] bms = GenerateBitmaps();
                    for (int i = 0; i < bms.Length; i++)
                    {
                        String sFileName0 = sFileName;
                        if(i > 0)
                        {
                            int ipos = sFileName0.LastIndexOf(".");
                            if(ipos > -1)
                            {
                                String sExt = sFileName0.Substring(ipos);
                                sFileName0 = sFileName0.Substring(0, ipos) + "_" + i.ToString() + sExt;
                            }
                        }
                        bms[i].Save(sFileName0, ImageFormat.Png);

                        MyProcessHelper pPngQuant = new MyProcessHelper(Application.StartupPath + "\\pngquant\\pngquant.exe", sFileName0 + " --force --ext .png --verbose");
                        pPngQuant.DoIt();
                    }
                    SaveMySettings();
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private Bitmap[] GenerateSplittedBitmaps()
        {
            Bitmap bm = new Bitmap(pbImgStart.Image);
            int iWidth = bm.Width;
            int iHeight = bm.Height;
            int iLines = (int)(nudLines.Value);
            int iColumns = (int)(nudColumns.Value);

            int iBorderW = (int)(nudBorderWest.Value); // 24;
            int iBorderE = (int)(nudBorderEast.Value); // 14;
            int iBorderN = (int)(nudBorderNorth.Value); // 14;
            int iBorderS = (int)(nudBorderSouth.Value); // 14;

            int iWidthSplitted = (iWidth - (iBorderW + iBorderE)) / iColumns;
            int iHeightSplitted = (iHeight - (iBorderN + iBorderS)) / iLines;
            int lenResult = iLines * iColumns;
            Bitmap[] bms = new Bitmap[lenResult];
            int indexL = 0;
            int indexC = 0;

            int index = 0;

            for (indexL = 0; indexL < iLines; indexL++)
            {
                for (indexC = 0; indexC < iColumns; indexC++)
                {
                    Rectangle srcRect = new Rectangle(iBorderW + indexC * iWidthSplitted, iBorderN + indexL * iHeightSplitted, iWidthSplitted, iHeightSplitted);
                    Rectangle dstRect = new Rectangle(0, 0, iWidthSplitted, iHeightSplitted);

                    /*bms[indexL * indexC + indexC] = new Bitmap(iWidthSplitted, iHeightSplitted);
                    bms[indexL * indexC + indexC] = pbImgStart.Image.Clone(srcRect, pbImgStart.Image.PixelFormat);*/
                    bms[index] = new Bitmap(iWidthSplitted, iHeightSplitted);
                    Graphics gp;
                    gp = Graphics.FromImage(bms[index]);
                    gp.Clear(Color.Red);
                    gp.DrawImage(bm, dstRect, srcRect, GraphicsUnit.Pixel);
                    index++;
                }
            }
            return bms;
        }

        private Bitmap[] GenerateBitmaps()
        {
            int width = (int)(nudImageWidth.Value);
            int height = (int)(nudImageHeight.Value);
            int fontsize = (int)(nudFontSize.Value);
            int posx = (int)(nudXText.Value);
            int posy = (int)(nudYText.Value);
            String sFontFamily = (String)(cbFontUsed.Items[cbFontUsed.SelectedIndex]);
            String sTextAll = tbTextToAdd.Text;
            String[] sText = sTextAll.Split('\n');
            Brush brush = knownBrushes[cbFontColor.SelectedIndex];
            bool bKeepRatio = cbKeepOriginalRatio.Checked;
            
            int lenResult = 1;
            if (cbOneFilePerLine.Checked)
            {
                lenResult = sText.Length;
            }
            else
            {
                sText = new String[1] { sTextAll };
            }
            Bitmap[] bms = new Bitmap[lenResult];
            int index = 0;

            for (index = 0; index < lenResult; index++)
            {
                Bitmap bm;
                Graphics gp;
                if ((bKeepRatio) && (orig_ratio != 0) && (height != 0) && (orig_ratio != (width / height)))
                {
                    float current_ratio = (float)(width) / (float)(height);
                    int width1 = (int)(height * orig_ratio);
                    int height1 = (int)(width / orig_ratio);
                    bm = new Bitmap(width, height);
                    gp = Graphics.FromImage(bm);
                    gp.Clear(Color.Transparent);
                    Bitmap bm1;
                    int x = 0;
                    int y = 0;
                    if (width1 < width)
                    {
                        bm1 = new Bitmap(ClPbHelper.ResizeImage(pbImgStart.Image, width1, height));
                        x = ((width - width1) / 2);
                    }
                    else
                    {
                        bm1 = new Bitmap(ClPbHelper.ResizeImage(pbImgStart.Image, width, height1));
                        y = ((height - height1) / 2);
                    }
                    gp.DrawImage(bm1, x, y);
                }
                else
                {
                    bm = new Bitmap(ClPbHelper.ResizeImage(pbImgStart.Image, width, height));
                    gp = Graphics.FromImage(bm);
                }

                gp.SmoothingMode = SmoothingMode.AntiAlias;
                gp.InterpolationMode = InterpolationMode.HighQualityBicubic;
                gp.PixelOffsetMode = PixelOffsetMode.HighQuality;
                gp.TextRenderingHint = TextRenderingHint.AntiAliasGridFit;

                FontStyle fs = FontStyle.Regular;
                if (cbBold.Checked) fs |= FontStyle.Bold;
                if (cbItalic.Checked) fs |= FontStyle.Italic;
                if (cbUnderline.Checked) fs |= FontStyle.Underline;
                if (cbStrike.Checked) fs |= FontStyle.Strikeout;

                StringFormat sf = new StringFormat();
                if (cbXCenter.Checked)
                {
                    sf.Alignment = StringAlignment.Center;
                    posx = 0;
                }
                if (cbYCenter.Checked)
                {
                    sf.LineAlignment = StringAlignment.Center;
                    posy = 0;
                }

                gp.DrawString(sText[index], new Font(sFontFamily, fontsize, fs), brush, new RectangleF(posx, posy, width, height), sf);
                gp.Flush();
                bms[index] = bm;
            }
            return bms;
        }

        private void btPreview_Click(object sender, EventArgs e)
        {
            Bitmap[] bms = GenerateBitmaps();
            pbImgResult.Image = bms[0];
        }

        private void pbImgStart_DragDrop(object sender, DragEventArgs e)
        {
            try
            {
                String[] sFileList = (String[])e.Data.GetData(DataFormats.FileDrop, false);
                if (sFileList.Length == 1)
                {
                    String sExt = Path.GetExtension(sFileList[0]).ToLower();
                    List<String> lsAcceptedExt = new List<string>() { ".png", ".jpg", ".jpeg", ".bmp" };
                    if (lsAcceptedExt.IndexOf(sExt) > -1)
                    {
                        using (Bitmap bmPicture = new Bitmap(sFileList[0]))
                        {
                            orig_width = bmPicture.Width;
                            orig_height = bmPicture.Height;
                            if (orig_height != 0)
                            {
                                orig_ratio = (float)(orig_width) / (float)(orig_height);
                            }
                            else
                            {
                                orig_ratio = 0;
                            }
                            pbImgStart.Image = (Image)(new Bitmap(bmPicture));
                            btSave.Enabled = true;
                            btPreview.Enabled = true;
                            btSplitSave.Enabled = true;
                            btSplitPreview.Enabled = true;
                        }
                    }
                    else
                    {
                        MessageBox.Show("Extension " + sExt + " not accepted. Dragdrop a file with extension png, bmp, jpg or jpeg.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                    }
                }
                else
                {
                    MessageBox.Show("Only one file for drag&drop operation please.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                }
            }
            catch (Exception ex)
            {
                //
            }
        }

        private void pbImgStart_DragEnter(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(DataFormats.FileDrop))
                e.Effect = DragDropEffects.Copy;
        }

        private void btLoad_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == ofdImg.ShowDialog())
            {
                String sFileName = ofdImg.FileName;
                try
                {
                    using (Bitmap bmPicture = new Bitmap(sFileName))
                    {
                        orig_width = bmPicture.Width;
                        orig_height = bmPicture.Height;
                        if (orig_height != 0)
                        {
                            orig_ratio = (float)(orig_width) / (float)(orig_height);
                        }
                        else
                        {
                            orig_ratio = 0;
                        }
                        pbImgStart.Image = (Image)(new Bitmap(bmPicture));
                        btSave.Enabled = true;
                        btPreview.Enabled = true;
                        btSplitSave.Enabled = true;
                        btSplitPreview.Enabled = true;
                    }
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void SaveMySettings()
        {
            Properties.Settings.Default.iFontFamily = cbFontUsed.SelectedIndex;
            Properties.Settings.Default.iFontColor = cbFontColor.SelectedIndex;
            Properties.Settings.Default.iWidth = (int)(nudImageWidth.Value);
            Properties.Settings.Default.iHeight = (int)(nudImageHeight.Value);
            Properties.Settings.Default.iXposition = (int)(nudXText.Value);
            Properties.Settings.Default.iYposition = (int)(nudYText.Value);
            Properties.Settings.Default.iFontSize = (int)(nudFontSize.Value);
            Properties.Settings.Default.bStyleBold = cbBold.Checked;
            Properties.Settings.Default.bStyleItalic = cbItalic.Checked;
            Properties.Settings.Default.bStyleUnderline = cbUnderline.Checked;
            Properties.Settings.Default.bStyleStrike = cbStrike.Checked;
            Properties.Settings.Default.bXcentered = cbXCenter.Checked;
            Properties.Settings.Default.bYcentered = cbYCenter.Checked;
            Properties.Settings.Default.bOneFilePerLine = cbOneFilePerLine.Checked;
            Properties.Settings.Default.bKeepAspectRatio = cbKeepOriginalRatio.Checked;

            Properties.Settings.Default.iSplitLines = (int)(nudLines.Value);
            Properties.Settings.Default.iSplitColumns = (int)(nudColumns.Value);
            Properties.Settings.Default.iBorderEast = (int)(nudBorderEast.Value);
            Properties.Settings.Default.iBorderNorth = (int)(nudBorderNorth.Value);
            Properties.Settings.Default.iBorderWest = (int)(nudBorderWest.Value);
            Properties.Settings.Default.iBorderSouth = (int)(nudBorderSouth.Value);

            Properties.Settings.Default.Save();
        }

        private void Form1_FormClosing(object sender, FormClosingEventArgs e)
        {
            SaveMySettings();
        }

        private void btSplitSave_Click(object sender, EventArgs e)
        {
            if (DialogResult.OK == sfdImg.ShowDialog())
            {
                String sFileName = sfdImg.FileName;
                try
                {
                    List<String> lsFiles = new List<String>();
                    Bitmap[] bms = GenerateSplittedBitmaps();
                    for (int i = 0; i < bms.Length; i++)
                    {
                        String sFileName0 = sFileName;
                        if (i > 0)
                        {
                            int ipos = sFileName0.LastIndexOf(".");
                            if (ipos > -1)
                            {
                                String sExt = sFileName0.Substring(ipos);
                                sFileName0 = sFileName0.Substring(0, ipos) + "_" + i.ToString() + sExt;
                            }
                        }
                        bms[i].Save(sFileName0, ImageFormat.Png);
                        lsFiles.Add(sFileName0);
                    }
                    int imax = lsFiles.Count;
                    for (int i = 0; i < imax; i++)
                    {
                        int ibegin = i;
                        String s = String.Empty;
                        for (i = ibegin; (i < imax) && (i < ibegin + 40); i++)
                        {
                            s += " " + lsFiles[i];
                        }
                        MyProcessHelper pPngQuant = new MyProcessHelper(Application.StartupPath + "\\pngquant\\pngquant.exe", s + " --force --ext .png --verbose");
                        pPngQuant.DoIt();
                    }
                    SaveMySettings();
                }
                catch (Exception ex)
                {
                    //
                }
            }
        }

        private void btSplitPreview_Click(object sender, EventArgs e)
        {
            Bitmap[] bms = GenerateSplittedBitmaps();
            pbImgResult.Image = bms[0];
        }
    }
}
