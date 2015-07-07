using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Text;
using System.Windows.Forms;
using System.Runtime.InteropServices;

// http://www.codeproject.com/Articles/6810/Dynamic-Screen-Resolution
[StructLayout(LayoutKind.Sequential)]
public struct DEVMODE1
{
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string dmDeviceName;
    public short dmSpecVersion;
    public short dmDriverVersion;
    public short dmSize;
    public short dmDriverExtra;
    public int dmFields;

    public short dmOrientation;
    public short dmPaperSize;
    public short dmPaperLength;
    public short dmPaperWidth;

    public short dmScale;
    public short dmCopies;
    public short dmDefaultSource;
    public short dmPrintQuality;
    public short dmColor;
    public short dmDuplex;
    public short dmYResolution;
    public short dmTTOption;
    public short dmCollate;
    [MarshalAs(UnmanagedType.ByValTStr, SizeConst = 32)]
    public string dmFormName;
    public short dmLogPixels;
    public short dmBitsPerPel;
    public int dmPelsWidth;
    public int dmPelsHeight;

    public int dmDisplayFlags;
    public int dmDisplayFrequency;

    public int dmICMMethod;
    public int dmICMIntent;
    public int dmMediaType;
    public int dmDitherType;
    public int dmReserved1;
    public int dmReserved2;

    public int dmPanningWidth;
    public int dmPanningHeight;
};




namespace VmSelNet
{
    public partial class Form1 : Form
    {
        DEVMODE1 dm;

        public Form1()
        {
            InitializeComponent();
        }


        protected override void OnLoad(System.EventArgs e)
        {
            dm = new DEVMODE1();
            dm.dmDeviceName = new String(new char[32]);
            dm.dmFormName = new String(new char[32]);
            dm.dmSize = (short)Marshal.SizeOf(dm);

            int i = 0;
            int err = 0;

            string selectedStr = null;
            int selectedIndex=-1;

            err = User_32.EnumDisplaySettings(null, User_32.ENUM_CURRENT_SETTINGS, ref dm);
            if (err != 0)
            {
                selectedStr = "" + dm.dmPelsWidth + "x" + dm.dmPelsHeight
                              + "x" + dm.dmBitsPerPel + "@" + dm.dmDisplayFrequency;

            }
            else
            {
                MessageBox.Show("Unable to query current video mode");
            }


            while ((err = User_32.EnumDisplaySettings(null, i, ref dm)) > 0)
            {
                string mode = ""+dm.dmPelsWidth+"x"+dm.dmPelsHeight
                              +"x"+dm.dmBitsPerPel+"@"+dm.dmDisplayFrequency;
                videoModeCombo.Items.Add(mode);
                if (selectedStr != null && mode.Equals(selectedStr))
                {
                    selectedIndex = i;
                }
                i++;
            }

            if (selectedIndex >= 0)
            {
                videoModeCombo.SelectedIndex = selectedIndex;
            }

            base.OnLoad(e);
        }

        private void videoModeCombo_SelectedIndexChanged(object sender, EventArgs e)
        {
            int index = videoModeCombo.SelectedIndex;
            if (index >= 0)
            {
                // query our video mode
                if (User_32.EnumDisplaySettings(null, index, ref dm) != 0)
                {
                    int flags = 0;
                    if (writeToRegistrycb.Checked)
                    {
                        flags = User_32.CDS_UPDATEREGISTRY;
                    }
                    int err = User_32.ChangeDisplaySettings(ref dm, flags);
                    if (err != User_32.DISP_CHANGE_SUCCESSFUL)
                    {
                        MessageBox.Show("Error on ChangeDisplaySettings " + err);
                    }
                }
                else
                {
                    MessageBox.Show("Error on EnumDisplaySettings, index= " + index);
                }
            }

        }

    }
}

class User_32
{
    [DllImport("user32.dll")]
    public static extern int EnumDisplaySettings(string deviceName, int modeNum, ref DEVMODE1 devMode);
    [DllImport("user32.dll")]
    public static extern int ChangeDisplaySettings(ref DEVMODE1 devMode, int flags);

    public const int ENUM_CURRENT_SETTINGS = -1;
    public const int CDS_UPDATEREGISTRY = 0x01;
    public const int CDS_TEST = 0x02;
    public const int DISP_CHANGE_SUCCESSFUL = 0;
    public const int DISP_CHANGE_RESTART = 1;
    public const int DISP_CHANGE_FAILED = -1;
}
