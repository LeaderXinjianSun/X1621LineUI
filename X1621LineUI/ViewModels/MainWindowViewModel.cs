using Microsoft.Practices.Prism.Commands;
using Microsoft.Practices.Prism.ViewModel;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using BingLibrary.hjb.file;
using System.Data;
using System.Diagnostics;
using SXJLibrary;

namespace X1621LineUI.ViewModels
{
    class MainWindowViewModel : NotificationObject
    {
        #region 绑定属性
        private int station;

        public int Station
        {
            get { return station; }
            set
            {
                station = value;
                this.RaisePropertyChanged("Station");
            }
        }
        private string messageStr;

        public string MessageStr
        {
            get { return messageStr; }
            set
            {
                messageStr = value;
                this.RaisePropertyChanged("MessageStr");
            }
        }
        private long uICycle;

        public long UICycle
        {
            get { return uICycle; }
            set
            {
                uICycle = value;
                this.RaisePropertyChanged("UICycle");
            }
        }
        private long conCycle;

        public long ConCycle
        {
            get { return conCycle; }
            set
            {
                conCycle = value;
                this.RaisePropertyChanged("ConCycle");
            }
        }
        private bool statusL1;

        public bool StatusL1
        {
            get { return statusL1; }
            set
            {
                statusL1 = value;
                this.RaisePropertyChanged("StatusL1");
            }
        }
        private bool satusL2;

        public bool StatusL2
        {
            get { return satusL2; }
            set
            {
                satusL2 = value;
                this.RaisePropertyChanged("StatusL2");
            }
        }
        private bool statusMid;

        public bool StatusMid
        {
            get { return statusMid; }
            set
            {
                statusMid = value;
                this.RaisePropertyChanged("StatusMid");
            }
        }
        private bool statusRobot;

        public bool StatusRobot
        {
            get { return statusRobot; }
            set
            {
                statusRobot = value;
                this.RaisePropertyChanged("StatusRobot");
            }
        }
        private bool statusR1;

        public bool StatusR1
        {
            get { return statusR1; }
            set
            {
                statusR1 = value;
                this.RaisePropertyChanged("StatusR1");
            }
        }
        private bool statusR2;

        public bool StatusR2
        {
            get { return statusR2; }
            set
            {
                statusR2 = value;
                this.RaisePropertyChanged("StatusR2");
            }
        }
        private string itemVisibility0;

        public string ItemVisibility0
        {
            get { return itemVisibility0; }
            set
            {
                itemVisibility0 = value;
                this.RaisePropertyChanged("ItemVisibility0");
            }
        }
        private string itemVisibility1;

        public string ItemVisibility1
        {
            get { return itemVisibility1; }
            set
            {
                itemVisibility1 = value;
                this.RaisePropertyChanged("ItemVisibility1");
            }
        }

        private string itemVisibility5;

        public string ItemVisibility5
        {
            get { return itemVisibility5; }
            set
            {
                itemVisibility5 = value;
                this.RaisePropertyChanged("ItemVisibility5");
            }
        }

        #endregion
        #region 方法绑定
        public DelegateCommand AppLoadedEventCommand { get; set; }
        public DelegateCommand<object> MenuActionCommand { get; set; }
        public DelegateCommand<object> LanguageChangeCommand { get; set; }
        public DelegateCommand FuncTestCommand { get; set; }

        #endregion
        #region 变量
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        private 读写器530SDK.CReader reader = new 读写器530SDK.CReader();
        Fx5u Fx5u_left1, Fx5u_left2, Fx5u_mid, Fx5u_right1, Fx5u_right2;
        Scan scan1, scan2;
        int CardStatus = 1;
        private EpsonRC90 epsonRC90;
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {
            this.AppLoadedEventCommand = new DelegateCommand(new Action(this.AppLoadedEventCommandExecute));
            this.MenuActionCommand = new DelegateCommand<object>(new Action<object>(this.MenuActionCommandExecute));
            this.LanguageChangeCommand = new DelegateCommand<object>(new Action<object>(this.LanguageChangeCommandExecute));
            this.FuncTestCommand = new DelegateCommand(new Action(this.FuncTestCommandExecute));
        }
        #endregion
        #region 方法绑定执行函数
        private void AppLoadedEventCommandExecute()
        {
            Init();
            UIRun();
            Task.Run(()=> { IORun(); }); 
            AddMessage("软件加载完成");
        }
        private void MenuActionCommandExecute(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    break;
                default:
                    break;
            }
        }
        private void LanguageChangeCommandExecute(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    {
                        List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
                        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
                        {
                            dictionaryList.Add(dictionary);
                        }
                        string requestedCulture = @"Views\Resources\zh-cn.xaml";
                        ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
                        Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                        Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
                    }

                    break;
                case "1":
                    {
                        List<ResourceDictionary> dictionaryList = new List<ResourceDictionary>();
                        foreach (ResourceDictionary dictionary in Application.Current.Resources.MergedDictionaries)
                        {
                            dictionaryList.Add(dictionary);
                        }
                        string requestedCulture = @"Views\Resources\en-us.xaml";
                        ResourceDictionary resourceDictionary = dictionaryList.FirstOrDefault(d => d.Source.OriginalString.Equals(requestedCulture));
                        Application.Current.Resources.MergedDictionaries.Remove(resourceDictionary);
                        Application.Current.Resources.MergedDictionaries.Add(resourceDictionary);
                    }

                    break;
                default:
                    break;
            }
        }
        private void FuncTestCommandExecute()
        {
            //Inifile.INIWriteValue(iniParameterPath, "System", "Station", "1");
            //Inifile.INIWriteValue(iniParameterPath, "读卡器", "COM", "COM21");
            //Inifile.INIWriteValue(iniParameterPath, "读卡器", "MODE", "3");
            StatusL1 = !StatusL1;
            AddMessage("功能执行完成");
        }
        #endregion
        #region 自定义函数
        private void Init()
        {
            #region 初始化
            MessageStr = "";
            Station = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "Station", "1"));
            string plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC2IP", "192.168.10.2");
            int plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC2PORT", "8000"));
            Fx5u_mid = new Fx5u(plc_ip, plc_port);
            plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC4IP", "192.168.10.2");
            plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC4PORT", "8000"));
            Fx5u_right1 = new Fx5u(plc_ip, plc_port);
            scan1 = new Scan();
            string COM = Inifile.INIGetStringValue(iniParameterPath, "System", "ScanCOM1", "COM0");
            scan1.ini(COM);
            scan2 = new Scan();
            COM = Inifile.INIGetStringValue(iniParameterPath, "System", "ScanCOM2", "COM1");
            scan2.ini(COM);
            ItemVisibility0 = "Visible";
            ItemVisibility1 = "Visible";
            ItemVisibility5 = "Visible";
            switch (Station)
            {
                case 1:
                    ItemVisibility0 = "Collapsed";
                    ItemVisibility1 = "Collapsed";
                    plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC5IP", "192.168.10.2");
                    plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC5PORT", "8000"));
                    Fx5u_right2 = new Fx5u(plc_ip, plc_port);
                    Task.Run(() => { StationEnterRun(); });
                    AddMessage("机台站:" + Station.ToString() + ";轨道入口功能开启");
                    break;
                case 2:
                case 4:
                case 6:
                    ItemVisibility5 = "Collapsed";
                    plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC0IP", "192.168.10.2");
                    plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC0PORT", "8000"));
                    Fx5u_left1 = new Fx5u(plc_ip, plc_port);
                    plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC1IP", "192.168.10.2");
                    plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC1PORT", "8000"));
                    Fx5u_left2 = new Fx5u(plc_ip, plc_port);
                    switch (Station)
                    {
                        case 2:
                            Task.Run(() => { DockStation1Run(); });
                            AddMessage("机台站:" + Station.ToString() + ";接驳台1功能开启");
                            break;
                        case 4:
                            AddMessage("机台站:" + Station.ToString() + ";翻转接驳台开启");
                            break;
                        case 6:
                            Task.Run(() => { DockStation2Run(); });
                            AddMessage("机台站:" + Station.ToString() + ";接驳台2功能开启");
                            break;
                        default:
                            break;
                    }
                    break;
                case 3:
                case 5:
                    plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC1IP", "192.168.10.2");
                    plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC1PORT", "8000"));
                    Fx5u_left2 = new Fx5u(plc_ip, plc_port);

                    ItemVisibility0 = "Collapsed";

                    plc_ip = Inifile.INIGetStringValue(iniParameterPath, "System", "PLC5IP", "192.168.10.2");
                    plc_port = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "System", "PLC5PORT", "8000"));
                    Fx5u_right2 = new Fx5u(plc_ip, plc_port);

                    break;
                default:
                    break;
            }
            epsonRC90 = new EpsonRC90();
            epsonRC90.ModelPrint += ModelPrintEventProcess;
            #endregion
        }
        private void AddMessage(string str)
        {
            string[] s = MessageStr.Split('\n');
            if (s.Length > 1000)
            {
                MessageStr = "";
            }
            if (MessageStr != "")
            {
                MessageStr += "\n";
            }
            MessageStr += System.DateTime.Now.ToString("yyyy/MM/dd HH:mm:ss") + " " + str;
        }
        private async void UIRun()
        {
            Stopwatch sw = new Stopwatch();
            int cardret = 1;
            int cardcount = 0;
            string MODE = "0";
            while (true)
            {
                sw.Restart();
                await Task.Delay(100);
                #region 刷卡
                if (cardcount++ > 9)
                {
                    cardcount = 0;
                    if (true)
                    {
                        try
                        {
                            byte[] buf = new byte[256];//用来存储卡信息的buff
                            byte[] snr = 读写器530SDK.CPublic.CharToByte("FF FF FF FF FF FF");//应该是一种读码格式，照抄即可。
                            if (true)
                            {
                                if (IntPtr.Zero == reader.GetHComm())
                                {
                                    string COM = Inifile.INIGetStringValue(iniParameterPath, "读卡器", "COM", "COM19").Replace("COM", "");
                                    reader.OpenComm(int.Parse(COM), 9600);
                                    MODE = Inifile.INIGetStringValue(iniParameterPath, "读卡器", "MODE", "3");
                                }
                                
                                //刷卡；若刷到卡返回0，没刷到回1。
                                CardStatus = reader.MF_Read(0, byte.Parse(MODE), 0, 1, ref snr[0], ref buf[0]);
                                //采用上升沿信号，防止卡放在读卡机上，重复执行查询动作。寄卡放一次，才查询一次，要再查询，需要重新刷卡。
                                if (cardret != CardStatus)
                                {
                                    cardret = CardStatus;
                                    if (CardStatus == 0)//刷到卡了
                                    {
                                        string strTmp = "";
                                        //测试发现，卡返回的是16个HEX（十六进制）数，放在byte[]数组内，需要用一下方法转成字符串格式。
                                        for (int i = 0; i < 16; i++)
                                        {
                                            strTmp += string.Format("{0:X2} ", buf[i]);
                                        }
                                        //删除转换后，字符串内的空格。这些HEX字符并不是员工编号字符的编码，需要用读到的字符串在数据库里查找，
                                        //在记录里再匹配员工信息和权限
                                        string barcode = strTmp.Replace(" ", "");
                                        AddMessage("刷卡 " + barcode);
                                        SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                                        if (oraDB.isConnect())
                                        {
                                            string stm = string.Format("SELECT * FROM CAP_TABLE WHERE BARCODE = '{0}'", barcode);
                                            DataSet s = oraDB.executeQuery(stm);
                                            DataTable dt = s.Tables[0];
                                            if (dt.Rows.Count > 0)//查询到数据条目大于0，即查到了
                                            {
                                                //取查到的第一行记录，一般只有1行。如果有多行，也只取第一行。
                                                DataRow dr = dt.Rows[0];
                                                //筛选一下数据，如果我们需要的“工号”、“姓名”和“权限”对应的栏位为空，则数据不合格。
                                                if (dr["OPERATORID"] != DBNull.Value && dr["DATA0"] != DBNull.Value && dr["RESULT"] != DBNull.Value)
                                                {
                                                    //打印出匹配到的结果，并返回给下位机。
                                                    AddMessage("工号 " + (string)dr["OPERATORID"] + " 姓名 " + (string)dr["DATA0"] + " 权限 " + (string)dr["RESULT"]);
                                                    if ((string)dr["RESULT"] == "PASS")
                                                    {
                                                        //Xinjie.SetM(11155, false);
                                                    }
                                                }
                                                else
                                                {
                                                    AddMessage("数据库记录信息不完整");
                                                }
                                            }
                                            else
                                            {
                                                AddMessage("未查询到卡信息");
                                            }
                                        }
                                        oraDB.disconnect();
                                    }
                                }
                            }

                        }
                        catch (Exception ex)
                        {
                            reader.CloseComm();
                            AddMessage(ex.Message);
                        }
                    }

                }
                #endregion
                UICycle = sw.ElapsedMilliseconds;
            }
        }
        void IORun()
        {
            Stopwatch sw = new Stopwatch();
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                sw.Restart();
                try
                {
                    bool[] X50 = Fx5u_mid.ReadMultiM("M3000", 16);
                    bool[] Y50 = new bool[16];
                    for (int i = 0; i < 16; i++)
                    {
                        epsonRC90.Rc90In[i] = X50[i];
                        Y50[i] = epsonRC90.Rc90Out[i];
                    }
                    Fx5u_mid.SetMultiM("M3016", Y50);
                    bool[] M2700 = Fx5u_mid.ReadMultiM("M2700", 64);
                    bool[] M2500 = new bool[64];
                    for (int i = 0; i < 64; i++)
                    {
                        epsonRC90.Rc90In[i + 16] = M2700[i];
                        M2500[i] = epsonRC90.Rc90Out[i + 16];
                    }
                    Fx5u_mid.SetMultiM("M2500", M2500);
                }
                catch
                { }
                try
                {
                    //To Right
                    bool[] M2860 = Fx5u_mid.ReadMultiM("M2860", 32);
                    Fx5u_right1.SetMultiM("M2660", M2860);
                    switch (Station)
                    {
                        case 1:
                        case 3:
                        case 5:
                            {
                                bool[] M2860_2 = Fx5u_right1.ReadMultiM("M2860", 32);
                                Fx5u_right2.SetMultiM("M2660", M2860_2);
                            }
                            break;
                        default:
                            break;
                    }

                    //To Left
                    if (Station != 1)
                    {
                        bool[] M2764 = Fx5u_mid.ReadMultiM("M2764", 32);
                        Fx5u_left2.SetMultiM("M2564", M2764);
                    }
                    switch (Station)
                    {
                        case 2:
                        case 4:
                        case 6:
                            {
                                bool[] M2764_2 = Fx5u_left2.ReadMultiM("M2764", 32);
                                Fx5u_left1.SetMultiM("M2564", M2764_2);
                            }
                            break;
                        default:
                            break;
                    }
                }
                catch
                { }

                ConCycle = sw.ElapsedMilliseconds;
            }
        }
        private void StationEnterRun()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
        private void DockStation1Run()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
        private void DockStation2Run()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(100);
            }
        }
        private void ModelPrintEventProcess(string str)
        {
           
            AddMessage(str);
            
            //#region 清洁
            //if (str.Contains("CheckClean"))
            //{
            //    this.Dispatcher.Invoke(new Action(async () => {
            //        if ((DateTime.Now - lastClean1.AddHours(2)).TotalSeconds > 0 && IsClean.IsChecked.Value)
            //        {
            //            await epsonRC90.TestSentNet.SendAsync("StartClean");
            //            lastClean1 = DateTime.Now;
            //            LastClean1.Text = lastClean1.ToString();
            //            Inifile.INIWriteValue(iniParameterPath, "Clean", "LastClean1", lastClean1.ToString());
            //        }
            //        else
            //        {
            //            await epsonRC90.TestSentNet.SendAsync("EndClean");
            //        }
            //    }));
            //}
            //#endregion
            //#region 样本
            //if (str.Contains("AskSample"))
            //{
            //    this.Dispatcher.Invoke(new Action(async () => {
            //        if ((DateTime.Now - SamStartDatetime1).TotalSeconds > 0 && IsSam.IsChecked.Value)
            //        {
            //            await epsonRC90.TestSentNet.SendAsync("SampleTest;OK");
            //            if (epsonRC90.TestSendStatus && IsSam.IsChecked.Value)
            //            {
            //                await epsonRC90.TestSentNet.SendAsync("StartSample");
            //            }
            //        }
            //        else
            //        {
            //            await epsonRC90.TestSentNet.SendAsync("SampleTest;NG");
            //        }
            //    }));
            //}
            //if (str.Contains("StartSample"))
            //{
            //    epsonRC90.SamStart = DateTime.Now;
            //    Tester.IsInSampleMode = true;
            //    for (int i = 0; i < 8; i++)
            //    {
            //        for (int j = 0; j < 4; j++)
            //        {
            //            epsonRC90.sampleContent[i][j] = "Null";
            //        }
            //    }
            //}
            //if (str.Contains("EndSample"))
            //{
            //    lastSam1 = DateTime.Now;
            //    Tester.IsInSampleMode = false;
            //    Inifile.INIWriteValue(iniParameterPath, "Sample", "LastSam1", lastSam1.ToString());
            //    this.Dispatcher.Invoke(new Action(() => {
            //        LastSam1.Text = lastSam1.ToString();
            //    }));
            //}
            //#endregion
        }
        #endregion
    }
}
