﻿using McuTools.Interfaces;
using MTools.ToolOther;
using System;
using System.Diagnostics;
using System.Windows.Media.Imaging;

namespace MTools
{
    public class StW : Tool
    {
        public override System.Windows.Controls.UserControl GetControl()
        {
            return new StopWatch();
        }

        public override ToolCategory Category
        {
            get { return ToolCategory.Other; }
        }

        public override string Description
        {
            get { return "Stopwatch"; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/timer-128.png", UriKind.Relative)); }
        }

    }

    public class Webbrowser : ExternalTool
    {
        public override void RunTool()
        {
            Process p = new Process();
            p.StartInfo.FileName = "MCUBrowser.exe";
            p.Start();
        }

        public override string Description
        {
            get { return "Launch MCU Tools Browser"; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/web.png", UriKind.Relative)); }
        }

        public override bool IsVisible
        {
            get { return true; }
        }
    }

    public class CryptoTools : Tool
    {

        public override System.Windows.Controls.UserControl GetControl()
        {
            return new Crypto();
        }

        public override string Description
        {
            get { return "Crypto tools"; }
        }

        public override ToolCategory Category
        {
            get { return ToolCategory.Other; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/encrypt.png", UriKind.Relative)); }
        }
    }

    public class EagleBack : Tool
    {

        public override System.Windows.Controls.UserControl GetControl()
        {
            return new EagleBackupRem();
        }

        public override string Description
        {
            get { return "Eagle Backup cleaner"; }
        }

        public override ToolCategory Category
        {
            get { return ToolCategory.Other; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/eagle.png", UriKind.Relative)); }
        }
    }

    public class ArduinoInst : Tool
    {

        public override System.Windows.Controls.UserControl GetControl()
        {
            return new ArduinoInstaller();
        }

        public override string Description
        {
            get { return "Arduino Installer"; }
        }

        public override ToolCategory Category
        {
            get { return ToolCategory.Other; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/arduino.png", UriKind.Relative)); }
        }
    }

    public class NetScan : Tool
    {
        public override System.Windows.Controls.UserControl GetControl()
        {
            return new PortScanner();
        }

        public override string Description
        {
            get { return "Network & Port Scannner"; }
        }

        public override ToolCategory Category
        {
            get { return ToolCategory.Other; }
        }

        public override System.Windows.Media.ImageSource Icon
        {
            get { return new BitmapImage(new Uri("/MTools.Tool;component/icons/portscann.png", UriKind.Relative)); }
        }
    }
}
