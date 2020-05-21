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
using System.IO;
using OfficeOpenXml;
using System.Collections.ObjectModel;
using BingLibrary.hjb;
using BingLibrary.hjb.Metro;

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
        private string lineID1;

        public string LineID1
        {
            get { return lineID1; }
            set
            {
                lineID1 = value;
                this.RaisePropertyChanged("LineID1");
            }
        }
        private string lineID2;

        public string LineID2
        {
            get { return lineID2; }
            set
            {
                lineID2 = value;
                this.RaisePropertyChanged("LineID2");
            }
        }
        private string homePageVisibility;

        public string HomePageVisibility
        {
            get { return homePageVisibility; }
            set
            {
                homePageVisibility = value;
                this.RaisePropertyChanged("HomePageVisibility");
            }
        }
        private string parameterPageVisibility;

        public string ParameterPageVisibility
        {
            get { return parameterPageVisibility; }
            set
            {
                parameterPageVisibility = value;
                this.RaisePropertyChanged("ParameterPageVisibility");
            }
        }
        private string samplePageVisibility;

        public string SamplePageVisibility
        {
            get { return samplePageVisibility; }
            set
            {
                samplePageVisibility = value;
                this.RaisePropertyChanged("SamplePageVisibility");
            }
        }
        private string materialPageVisibility;

        public string MaterialPageVisibility
        {
            get { return materialPageVisibility; }
            set
            {
                materialPageVisibility = value;
                this.RaisePropertyChanged("MaterialPageVisibility");
            }
        }

        private string testerResult0;

        public string TesterResult0
        {
            get { return testerResult0; }
            set
            {
                testerResult0 = value;
                this.RaisePropertyChanged("TesterResult0");
            }
        }
        private string testerResult1;

        public string TesterResult1
        {
            get { return testerResult1; }
            set
            {
                testerResult1 = value;
                this.RaisePropertyChanged("TesterResult1");
            }
        }
        private string testerResult2;

        public string TesterResult2
        {
            get { return testerResult2; }
            set
            {
                testerResult2 = value;
                this.RaisePropertyChanged("TesterResult2");
            }
        }
        private string testerResult3;

        public string TesterResult3
        {
            get { return testerResult3; }
            set
            {
                testerResult3 = value;
                this.RaisePropertyChanged("TesterResult3");
            }
        }
        private string passStatusDisplayText0;

        public string PassStatusDisplayText0
        {
            get { return passStatusDisplayText0; }
            set
            {
                passStatusDisplayText0 = value;
                this.RaisePropertyChanged("PassStatusDisplayText0");
            }
        }
        private string passStatusDisplayText1;

        public string PassStatusDisplayText1
        {
            get { return passStatusDisplayText1; }
            set
            {
                passStatusDisplayText1 = value;
                this.RaisePropertyChanged("PassStatusDisplayText1");
            }
        }
        private string passStatusDisplayText2;

        public string PassStatusDisplayText2
        {
            get { return passStatusDisplayText2; }
            set
            {
                passStatusDisplayText2 = value;
                this.RaisePropertyChanged("PassStatusDisplayText2");
            }
        }
        private string passStatusDisplayText3;

        public string PassStatusDisplayText3
        {
            get { return passStatusDisplayText3; }
            set
            {
                passStatusDisplayText3 = value;
                this.RaisePropertyChanged("PassStatusDisplayText3");
            }
        }
        private string passStatusDisplayForeground0;

        public string PassStatusDisplayForeground0
        {
            get { return passStatusDisplayForeground0; }
            set
            {
                passStatusDisplayForeground0 = value;
                this.RaisePropertyChanged("PassStatusDisplayForeground0");
            }
        }
        private string passStatusDisplayForeground1;

        public string PassStatusDisplayForeground1
        {
            get { return passStatusDisplayForeground1; }
            set
            {
                passStatusDisplayForeground1 = value;
                this.RaisePropertyChanged("PassStatusDisplayForeground1");
            }
        }
        private string passStatusDisplayForeground2;

        public string PassStatusDisplayForeground2
        {
            get { return passStatusDisplayForeground2; }
            set
            {
                passStatusDisplayForeground2 = value;
                this.RaisePropertyChanged("PassStatusDisplayForeground2");
            }
        }
        private string passStatusDisplayForeground3;

        public string PassStatusDisplayForeground3
        {
            get { return passStatusDisplayForeground3; }
            set
            {
                passStatusDisplayForeground3 = value;
                this.RaisePropertyChanged("PassStatusDisplayForeground3");
            }
        }
        private double testTime0;

        public double TestTime0
        {
            get { return testTime0; }
            set
            {
                testTime0 = value;
                this.RaisePropertyChanged("TestTime0");
            }
        }
        private double testTime1;

        public double TestTime1
        {
            get { return testTime1; }
            set
            {
                testTime1 = value;
                this.RaisePropertyChanged("TestTime1");
            }
        }
        private double testTime2;

        public double TestTime2
        {
            get { return testTime2; }
            set
            {
                testTime2 = value;
                this.RaisePropertyChanged("TestTime2");
            }
        }
        private double testTime3;

        public double TestTime3
        {
            get { return testTime3; }
            set
            {
                testTime3 = value;
                this.RaisePropertyChanged("TestTime3");
            }
        }
        private double testIdle0;

        public double TestIdle0
        {
            get { return testIdle0; }
            set
            {
                testIdle0 = value;
                this.RaisePropertyChanged("TestIdle0");
            }
        }
        private double testIdle1;

        public double TestIdle1
        {
            get { return testIdle1; }
            set
            {
                testIdle1 = value;
                this.RaisePropertyChanged("TestIdle1");
            }
        }
        private double testIdle2;

        public double TestIdle2
        {
            get { return testIdle2; }
            set
            {
                testIdle2 = value;
                this.RaisePropertyChanged("TestIdle2");
            }
        }
        private double testIdle3;

        public double TestIdle3
        {
            get { return testIdle3; }
            set
            {
                testIdle3 = value;
                this.RaisePropertyChanged("TestIdle3");
            }
        }
        private double testCycle0;

        public double TestCycle0
        {
            get { return testCycle0; }
            set
            {
                testCycle0 = value;
                this.RaisePropertyChanged("TestCycle0");
            }
        }
        private double testCycle1;

        public double TestCycle1
        {
            get { return testCycle1; }
            set
            {
                testCycle1 = value;
                this.RaisePropertyChanged("TestCycle1");
            }
        }
        private double testCycle2;

        public double TestCycle2
        {
            get { return testCycle2; }
            set
            {
                testCycle2 = value;
                this.RaisePropertyChanged("TestCycle2");
            }
        }
        private double testCycle3;

        public double TestCycle3
        {
            get { return testCycle3; }
            set
            {
                testCycle3 = value;
                this.RaisePropertyChanged("TestCycle3");
            }
        }
        private double testCycleAve;

        public double TestCycleAve
        {
            get { return testCycleAve; }
            set
            {
                testCycleAve = value;
                this.RaisePropertyChanged("TestCycleAve");
            }
        }
        private int testCount0;

        public int TestCount0
        {
            get { return testCount0; }
            set
            {
                testCount0 = value;
                this.RaisePropertyChanged("TestCount0");
            }
        }
        private int testCount1;

        public int TestCount1
        {
            get { return testCount1; }
            set
            {
                testCount1 = value;
                this.RaisePropertyChanged("TestCount1");
            }
        }
        private int testCount2;

        public int TestCount2
        {
            get { return testCount2; }
            set
            {
                testCount2 = value;
                this.RaisePropertyChanged("TestCount2");
            }
        }
        private int testCount3;

        public int TestCount3
        {
            get { return testCount3; }
            set
            {
                testCount3 = value;
                this.RaisePropertyChanged("TestCount3");
            }
        }
        private int passCount0;

        public int PassCount0
        {
            get { return passCount0; }
            set
            {
                passCount0 = value;
                this.RaisePropertyChanged("PassCount0");
            }
        }
        private int passCount1;

        public int PassCount1
        {
            get { return passCount1; }
            set
            {
                passCount1 = value;
                this.RaisePropertyChanged("PassCount1");
            }
        }
        private int passCount2;

        public int PassCount2
        {
            get { return passCount2; }
            set
            {
                passCount2 = value;
                this.RaisePropertyChanged("PassCount2");
            }
        }
        private int passCount3;

        public int PassCount3
        {
            get { return passCount3; }
            set
            {
                passCount3 = value;
                this.RaisePropertyChanged("PassCount3");
            }
        }
        private int testCountOutput;

        public int TestCountOutput
        {
            get { return testCountOutput; }
            set
            {
                testCountOutput = value;
                this.RaisePropertyChanged("TestCountOutput");
            }
        }
        private int testCountInput;

        public int TestCountInput
        {
            get { return testCountInput; }
            set
            {
                testCountInput = value;
                this.RaisePropertyChanged("TestCountInput");
            }
        }
        private double yieldTotal;

        public double YieldTotal
        {
            get { return yieldTotal; }
            set
            {
                yieldTotal = value;
                this.RaisePropertyChanged("YieldTotal");
            }
        }
        private ObservableCollection<string> sampleNgitem;

        public ObservableCollection<string> SampleNgitem
        {
            get { return sampleNgitem; }
            set
            {
                sampleNgitem = value;
                this.RaisePropertyChanged("SampleNgitem");
            }
        }
        private ObservableCollection<string> sampleItemsStatus;

        public ObservableCollection<string> SampleItemsStatus
        {
            get { return sampleItemsStatus; }
            set
            {
                sampleItemsStatus = value;
                this.RaisePropertyChanged("SampleItemsStatus");
            }
        }
        private DateTime lastSam1;

        public DateTime LastSam1
        {
            get { return lastSam1; }
            set
            {
                lastSam1 = value;
                this.RaisePropertyChanged("LastSam1");
            }
        }
        private string spanSam1;

        public string SpanSam1
        {
            get { return spanSam1; }
            set
            {
                spanSam1 = value;
                this.RaisePropertyChanged("SpanSam1");
            }
        }
        private DateTime lastClean1;

        public DateTime LastClean1
        {
            get { return lastClean1; }
            set
            {
                lastClean1 = value;
                this.RaisePropertyChanged("LastClean1");
            }
        }
        private DateTime nextClean1;

        public DateTime NextClean1
        {
            get { return nextClean1; }
            set
            {
                nextClean1 = value;
                this.RaisePropertyChanged("NextClean1");
            }
        }
        private string spanClean1;

        public string SpanClean1
        {
            get { return spanClean1; }
            set
            {
                spanClean1 = value;
                this.RaisePropertyChanged("SpanClean1");
            }
        }
        private bool iSam;

        public bool IsSam
        {
            get { return iSam; }
            set
            {
                iSam = value;
                this.RaisePropertyChanged("IsSam");
            }
        }
        private bool isClean;

        public bool IsClean
        {
            get { return isClean; }
            set
            {
                isClean = value;
                this.RaisePropertyChanged("IsClean");
            }
        }
        private ObservableCollection<string> flexID;

        public ObservableCollection<string> FlexID
        {
            get { return flexID; }
            set
            {
                flexID = value;
                this.RaisePropertyChanged("FlexID");
            }
        }
        private int nGItemCount;

        public int NGItemCount
        {
            get { return nGItemCount; }
            set
            {
                nGItemCount = value;
                this.RaisePropertyChanged("NGItemCount");
            }
        }
        private int nGItemLimit;

        public int NGItemLimit
        {
            get { return nGItemLimit; }
            set
            {
                nGItemLimit = value;
                this.RaisePropertyChanged("NGItemLimit");
            }
        }
        private string sampleGridVisibility;

        public string SampleGridVisibility
        {
            get { return sampleGridVisibility; }
            set
            {
                sampleGridVisibility = value;
                this.RaisePropertyChanged("SampleGridVisibility");
            }
        }
        private string sampleText;

        public string SampleText
        {
            get { return sampleText; }
            set
            {
                sampleText = value;
                this.RaisePropertyChanged("SampleText");
            }
        }
        private string pM;

        public string PM
        {
            get { return pM; }
            set
            {
                pM = value;
                this.RaisePropertyChanged("PM");
            }
        }
        private string gROUP1;

        public string GROUP1
        {
            get { return gROUP1; }
            set
            {
                gROUP1 = value;
                this.RaisePropertyChanged("GROUP1");
            }
        }
        private string tRACK;

        public string TRACK
        {
            get { return tRACK; }
            set
            {
                tRACK = value;
                this.RaisePropertyChanged("TRACK");
            }
        }
        private string mACID;

        public string MACID
        {
            get { return mACID; }
            set
            {
                mACID = value;
                this.RaisePropertyChanged("MACID");
            }
        }
        private string lIGHT_ID;

        public string LIGHT_ID
        {
            get { return lIGHT_ID; }
            set
            {
                lIGHT_ID = value;
                this.RaisePropertyChanged("LIGHT_ID");
            }
        }
        //private string lIGHT_ID2;

        //public string LIGHT_ID2
        //{
        //    get { return lIGHT_ID2; }
        //    set
        //    {
        //        lIGHT_ID2 = value;
        //        this.RaisePropertyChanged("LIGHT_ID2");
        //    }
        //}

        private string siteID;

        public string SiteID
        {
            get { return siteID; }
            set
            {
                siteID = value;
                this.RaisePropertyChanged("SiteID");
            }
        }
        private string projectCode;

        public string ProjectCode
        {
            get { return projectCode; }
            set
            {
                projectCode = value;
                this.RaisePropertyChanged("ProjectCode");
            }
        }
        private string testerID;

        public string TesterID
        {
            get { return testerID; }
            set
            {
                testerID = value;
                this.RaisePropertyChanged("TesterID");
            }
        }
        private string lotName;

        public string LotName
        {
            get { return lotName; }
            set
            {
                lotName = value;
                this.RaisePropertyChanged("LotName");
            }
        }
        private string mACID_M;

        public string MACID_M
        {
            get { return mACID_M; }
            set
            {
                mACID_M = value;
                this.RaisePropertyChanged("MACID_M");
            }
        }
        private string alarmGridVisibility;

        public string AlarmGridVisibility
        {
            get { return alarmGridVisibility; }
            set
            {
                alarmGridVisibility = value;
                this.RaisePropertyChanged("AlarmGridVisibility");
            }
        }
        private string alarmText;

        public string AlarmText
        {
            get { return alarmText; }
            set
            {
                alarmText = value;
                this.RaisePropertyChanged("AlarmText");
            }
        }
        private string testerID1;

        public string TesterID1
        {
            get { return testerID1; }
            set
            {
                testerID1 = value;
                this.RaisePropertyChanged("TesterID1");
            }
        }
        private string testerID2;

        public string TesterID2
        {
            get { return testerID2; }
            set
            {
                testerID2 = value;
                this.RaisePropertyChanged("TesterID2");
            }
        }
        private string testerID3;

        public string TesterID3
        {
            get { return testerID3; }
            set
            {
                testerID3 = value;
                this.RaisePropertyChanged("TesterID3");
            }
        }
        private string testerID4;

        public string TesterID4
        {
            get { return testerID4; }
            set
            {
                testerID4 = value;
                this.RaisePropertyChanged("TesterID4");
            }
        }
        private string operaterID;

        public string OperaterID
        {
            get { return operaterID; }
            set
            {
                operaterID = value;
                this.RaisePropertyChanged("OperaterID");
            }
        }
        private double greenElapse;

        public double GreenElapse
        {
            get { return greenElapse; }
            set
            {
                greenElapse = value;
                this.RaisePropertyChanged("GreenElapse");
            }
        }
        private DataTable materialItemsSource;

        public DataTable MaterialItemsSource
        {
            get { return materialItemsSource; }
            set
            {
                materialItemsSource = value;
                this.RaisePropertyChanged("MaterialItemsSource");
            }
        }
        private ObservableCollection<string> materialChangeItemsSource;

        public ObservableCollection<string> MaterialChangeItemsSource
        {
            get { return materialChangeItemsSource; }
            set
            {
                materialChangeItemsSource = value;
                this.RaisePropertyChanged("MaterialChangeItemsSource");
            }
        }
        private bool alarmButtonIsEnabled;

        public bool AlarmButtonIsEnabled
        {
            get { return alarmButtonIsEnabled; }
            set
            {
                alarmButtonIsEnabled = value;
                this.RaisePropertyChanged("AlarmButtonIsEnabled");
            }
        }
        private string sampleDStartTimeAM;

        public string SampleDStartTimeAM
        {
            get { return sampleDStartTimeAM; }
            set
            {
                sampleDStartTimeAM = value;
                this.RaisePropertyChanged("SampleDStartTimeAM");
            }
        }
        private string sampleDStartTimePM;

        public string SampleDStartTimePM
        {
            get { return sampleDStartTimePM; }
            set
            {
                sampleDStartTimePM = value;
                this.RaisePropertyChanged("SampleDStartTimePM");
            }
        }
        private string sampleNStartTimeAM;

        public string SampleNStartTimeAM
        {
            get { return sampleNStartTimeAM; }
            set
            {
                sampleNStartTimeAM = value;
                this.RaisePropertyChanged("SampleNStartTimeAM");
            }
        }
        private string sampleNStartTimePM;

        public string SampleNStartTimePM
        {
            get { return sampleNStartTimePM; }
            set
            {
                sampleNStartTimePM = value;
                this.RaisePropertyChanged("SampleNStartTimePM");
            }
        }
        private string wORKSTATION;

        public string WORKSTATION
        {
            get { return wORKSTATION; }
            set
            {
                wORKSTATION = value;
                this.RaisePropertyChanged("WORKSTATION");
            }
        }
        private ObservableCollection<int> adminAddNum;

        public ObservableCollection<int> AdminAddNum
        {
            get { return adminAddNum; }
            set
            {
                adminAddNum = value;
                this.RaisePropertyChanged("AdminAddNum");
            }
        }
        private bool showYieldAdminControlWindow;

        public bool ShowYieldAdminControlWindow
        {
            get { return showYieldAdminControlWindow; }
            set
            {
                showYieldAdminControlWindow = value;
                this.RaisePropertyChanged("ShowYieldAdminControlWindow");
            }
        }
        private bool quitYieldAdminControl;

        public bool QuitYieldAdminControl
        {
            get { return quitYieldAdminControl; }
            set
            {
                quitYieldAdminControl = value;
                this.RaisePropertyChanged("QuitYieldAdminControl");
            }
        }

        #endregion
        #region 方法绑定
        public DelegateCommand AppLoadedEventCommand { get; set; }
        public DelegateCommand<object> MenuActionCommand { get; set; }
        public DelegateCommand<object> LanguageChangeCommand { get; set; }
        public DelegateCommand<object> ChangeMaterialOperateCommand { get; set; }
        public DelegateCommand FuncTestCommand { get; set; }
        public DelegateCommand StartSampleCommand { get; set; }
        public DelegateCommand SaveSamParamCommand { get; set; }
        public DelegateCommand SaveParameterCommand { get; set; }
        public DelegateCommand BigDataAlarmGetCommand { get; set; }
        public DelegateCommand<object> TrackInitCommand { get; set; }
        public DelegateCommand YieldConfirmButtonCommand { get; set; }
        #endregion
        #region 变量
        private string iniParameterPath = System.Environment.CurrentDirectory + "\\Parameter.ini";
        private string iniFilepath = @"d:\test.ini";
        private 读写器530SDK.CReader reader = new 读写器530SDK.CReader();
        Fx5u Fx5u_left1, Fx5u_left2, Fx5u_mid, Fx5u_right1, Fx5u_right2;
        Scan scan1, scan2;
        //int CardStatus = 1;
        private EpsonRC90 epsonRC90; string LastBanci;
        DateTime SamStartDatetime1, SamNextDatetime1, SamDateBigin1;
        int LampColor = 1; Stopwatch LampGreenSw = new Stopwatch(); bool[] M300; bool[] M2000; bool[] X40;
        List<AlarmData> AlarmList = new List<AlarmData>(); string CurrentAlarm = "";
        string alarmExcelPath = System.Environment.CurrentDirectory + "\\X1621串线上料机报警.xlsx";
        int LampGreenElapse, LampGreenFlickerElapse, LampYellowElapse, LampYellowFlickerElapse, LampRedElapse;
        int ErrorCount = 0; bool CardLockFlag; DateTime CardLockTime;
        bool isSendSamCMD = false, isSendCleanCMD = false;
        Metro metro = new Metro();
        #endregion
        #region 构造函数
        public MainWindowViewModel()
        {
            this.AppLoadedEventCommand = new DelegateCommand(new Action(this.AppLoadedEventCommandExecute));
            this.MenuActionCommand = new DelegateCommand<object>(new Action<object>(this.MenuActionCommandExecute));
            this.LanguageChangeCommand = new DelegateCommand<object>(new Action<object>(this.LanguageChangeCommandExecute));
            this.FuncTestCommand = new DelegateCommand(new Action(this.FuncTestCommandExecute));
            this.StartSampleCommand = new DelegateCommand(new Action(this.StartSampleCommandExecute));
            this.SaveSamParamCommand = new DelegateCommand(new Action(this.SaveSamParamCommandExecute));
            this.SaveParameterCommand = new DelegateCommand(new Action(this.SaveParameterCommandExecute));
            this.BigDataAlarmGetCommand = new DelegateCommand(new Action(this.BigDataAlarmGetCommandExecute));
            this.ChangeMaterialOperateCommand = new DelegateCommand<object>(new Action<object>(this.ChangeMaterialOperateCommandExecute));
            this.TrackInitCommand = new DelegateCommand<object>(new Action<object>(this.TrackInitCommandExecute));
            this.YieldConfirmButtonCommand = new DelegateCommand(new Action(this.YieldConfirmButtonCommandExecute));
            ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
            if (System.Environment.CurrentDirectory != @"C:\Debug")
            //if (false)
            {
                System.Windows.MessageBox.Show("软件安装目录必须为C:\\Debug");
                System.Windows.Application.Current.Shutdown();
            }
            else
            {

                System.Diagnostics.Process[] myProcesses = System.Diagnostics.Process.GetProcessesByName("X1621LineUI");//获取指定的进程名   
                if (myProcesses.Length > 1) //如果可以获取到知道的进程名则说明已经启动
                {
                    System.Windows.MessageBox.Show("不允许重复打开软件");
                    System.Windows.Application.Current.Shutdown();
                }
            }
        }
        #endregion
        #region 方法绑定执行函数
        private void AppLoadedEventCommandExecute()
        {
            Init();
            UIRun();
            BigDataRun();
            MachineLogRun();
            Task.Run(() => { IORun(); });
            Task.Run(() => { SystemRun(); });
            AddMessage("软件加载完成");
        }
        private async void MenuActionCommandExecute(object p)
        {
            switch (p.ToString())
            {
                case "0":
                    HomePageVisibility = "Visible";
                    ParameterPageVisibility = "Collapsed";
                    SamplePageVisibility = "Collapsed";
                    MaterialPageVisibility = "Collapsed";
                    break;
                case "1":
                    metro.ChangeAccent("Orange");
                    var password = await metro.ShowLoginOnlyPassword("密码");
                    if (password == GetPassWord())
                    {
                        HomePageVisibility = "Collapsed";
                        ParameterPageVisibility = "Visible";
                        SamplePageVisibility = "Collapsed";
                        MaterialPageVisibility = "Collapsed";
                    }
                    else
                    {
                        AddMessage("密码输入错误");
                    }
                    metro.ChangeAccent("Blue");
                    break;
                case "2":
                    HomePageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    SamplePageVisibility = "Visible";
                    MaterialPageVisibility = "Collapsed";
                    break;
                case "3":
                    HomePageVisibility = "Collapsed";
                    ParameterPageVisibility = "Collapsed";
                    SamplePageVisibility = "Collapsed";
                    MaterialPageVisibility = "Visible";
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
            //StatusL1 = !StatusL1;
            //int _time = 3599;
            //string downtime = string.Format("{0}:{1}:{2}", (_time / 3600).ToString(), (_time / 60).ToString(), (_time % 60).ToString());
            //AddMessage(downtime);
            //epsonRC90.TestSentNet.SendAsync("sgrfgsaerfawef");
            //string machineLogpath = @"D:\MachineLog" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            //int i = 0;
            //TimeSpan time = AlarmList[i].End - AlarmList[i].Start;
            //string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", AlarmList[i].Start.ToString("HH:mm:ss"), AlarmList[i].End.ToString("HH:mm:ss"), time.ToString(), "WARNING", "", AlarmList[i].Code, "", AlarmList[i].Type, AlarmList[i].Content };
            //Csvfile.savetocsv(machineLogpath, contents);
            AddMessage("功能执行完成");
        }
        private async void StartSampleCommandExecute()
        {
            metro.ChangeAccent("Orange");
            var r = await metro.ShowConfirm("确认","请确认手动测样本吗?");
            if (r)
            {
                if (epsonRC90.TestSendStatus && !Tester.IsInSampleMode && IsSam)
                {
                    await epsonRC90.TestSentNet.SendAsync("StartSample");
                    AddMessage("StartSample");
                }
            }
            metro.ChangeAccent("Blue");
        }
        private void SaveSamParamCommandExecute()
        {
            for (int i = 0; i < 8; i++)
            {
                Inifile.INIWriteValue(iniParameterPath, "Sample", "NGItem" + i.ToString(), SampleNgitem[i]);
            }
            for (int i = 0; i < 4; i++)
            {
                FlexID[i] = Inifile.INIGetStringValue(iniFilepath, "A", "id" + (i + 1).ToString(), "99999");
            }
            TesterID1 = Inifile.INIGetStringValue(iniFilepath, "A", "id1", "99999");
            TesterID2 = Inifile.INIGetStringValue(iniFilepath, "A", "id2", "99999");
            TesterID3 = Inifile.INIGetStringValue(iniFilepath, "A", "id3", "99999");
            TesterID4 = Inifile.INIGetStringValue(iniFilepath, "A", "id4", "99999");
            Inifile.INIWriteValue(iniParameterPath, "Sample", "NGItemCount", NGItemCount.ToString());
            Inifile.INIWriteValue(iniParameterPath, "Sample", "NGItemLimit", NGItemLimit.ToString());
            Inifile.INIWriteValue(iniParameterPath, "Sample", "IsSam", IsSam.ToString());
            Inifile.INIWriteValue(iniParameterPath, "Clean", "IsClean", IsClean.ToString());
            Inifile.INIWriteValue(iniParameterPath, "Sample", "SampleDStartTimeAM", GetSampleTimeString(SampleDStartTimeAM, "06:00:00"));
            Inifile.INIWriteValue(iniParameterPath, "Sample", "SampleDStartTimePM", GetSampleTimeString(SampleDStartTimePM, "12:00:00"));
            Inifile.INIWriteValue(iniParameterPath, "Sample", "SampleNStartTimeAM", GetSampleTimeString(SampleNStartTimeAM, "18:00:00"));
            Inifile.INIWriteValue(iniParameterPath, "Sample", "SampleNStartTimePM", GetSampleTimeString(SampleNStartTimePM, "00:00:00"));
        }
        private void SaveParameterCommandExecute()
        {
            Inifile.INIWriteValue(iniParameterPath, "BigData", "PM", PM);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "GROUP1", GROUP1);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "TRACK", TRACK);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "MACID", MACID);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "MACID_M", MACID_M);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "LIGHT_ID", LIGHT_ID);
            //Inifile.INIWriteValue(iniParameterPath, "BigData", "LIGHT_ID2", LIGHT_ID2);
            Inifile.INIWriteValue(iniParameterPath, "BigData", "WORKSTATION", WORKSTATION);

            Inifile.INIWriteValue(iniParameterPath, "System", "LineID1", LineID1);
            Inifile.INIWriteValue(iniParameterPath, "System", "LineID2", LineID2);

            Inifile.INIWriteValue(iniParameterPath, "MachineLog", "SiteID", SiteID);
            Inifile.INIWriteValue(iniParameterPath, "MachineLog", "ProjectCode", ProjectCode);
            Inifile.INIWriteValue(iniParameterPath, "MachineLog", "TesterID", TesterID);
            Inifile.INIWriteValue(iniParameterPath, "MachineLog", "LotName", LotName);
            AddMessage("参数保存完成");
        }
        private async void ChangeMaterialOperateCommandExecute(object p)
        {
            if ((int)p >= 0)
            {
                metro.ChangeAccent("Orange");
                string rr = await metro.ShowLoginOnlyPassword("确认将 " + MaterialChangeItemsSource[(int)p] + " 更换？");
                if (rr == GetPassWord())
                {
                    try
                    {
                        epsonRC90.Worksheet.Cells[(int)p + 3, 9].Value = Convert.ToInt32(epsonRC90.Worksheet.Cells[(int)p + 3, 9].Value) + 1;
                        epsonRC90.Worksheet.Cells[(int)p + 3, 7].Value = epsonRC90.Worksheet.Cells[(int)p + 3, 8].Value;
                        epsonRC90.Worksheet.Cells[(int)p + 3, 8].Value = System.DateTime.Now.ToString();
                        epsonRC90.Worksheet.Cells[(int)p + 3, 6].Value = 0;
                        epsonRC90.Package.Save();
                    }
                    catch (Exception ex)
                    {
                        AddMessage(ex.Message);
                    }
                }
                metro.ChangeAccent("Blue");
            }
            
        }
        private async void BigDataAlarmGetCommandExecute()
        {
            AlarmButtonIsEnabled = false;

            var rst = await Task<string>.Run(() =>
            {
                try
                {
                    if (!Directory.Exists(Path.Combine(System.Environment.CurrentDirectory, DateTime.Now.ToString("yyyyMMdd"))))
                    {
                        Directory.CreateDirectory(Path.Combine(System.Environment.CurrentDirectory, DateTime.Now.ToString("yyyyMMdd")));
                    }
                    string path = Path.Combine(System.Environment.CurrentDirectory, DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("yyyyMMddHHmmss") + "AlarmTotal.csv");

                    Mysql mysql = new Mysql();
                    if (mysql.Connect())
                    {
                        string stm = string.Format("SELECT * FROM HA_F4_DATA_ALARM WHERE PM = '{0}' AND MACID = '{1}' AND CLASS = '{2}' AND GROUP1 = '{3}' AND TRACK = '{4}' AND WORKSTATION = '{5}'", PM, MACID, epsonRC90.GetBanci(), GROUP1, TRACK, WORKSTATION);
                        DataSet ds = mysql.Select(stm);

                        DataTable dt = ds.Tables["table0"];
                        if (dt.Rows.Count > 0)
                        {

                            string strHead = DateTime.Now.ToString("yyyyMMddHHmmss") + "AlarmTotal";
                            string strColumns = "";
                            for (int i = 0; i < dt.Columns.Count; i++)
                            {
                                strColumns += dt.Columns[i].ColumnName + ",";
                            }
                            strColumns = strColumns.Substring(0, strColumns.Length - 1);
                            Csvfile.dt2csv(dt, path, strHead, strColumns);

                            Process process1 = new Process();
                            process1.StartInfo.FileName = path;
                            process1.StartInfo.Arguments = "";
                            process1.StartInfo.WindowStyle = ProcessWindowStyle.Maximized;
                            process1.Start();
                        }

                    }
                    mysql.DisConnect();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
                return "查询报警结束";
            });

            AddMessage(rst);
            AlarmButtonIsEnabled = true;
        }
        private async void TrackInitCommandExecute(object p)
        {
            metro.ChangeAccent("Red");
            var password = await metro.ShowLoginOnlyPassword("专业人员密码");
            if (password == "543337")
            {
                await Task.Run(()=> {
                    try
                    {

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string lineid = "";
                            switch (p.ToString())
                            {
                                case "0":
                                    lineid = LineID1;
                                    break;
                                case "1":
                                    lineid = LineID2;
                                    break;
                                default:
                                    break;
                            }
                            string cleanstation = "";
                            switch (Station)
                            {
                                case 1:
                                    cleanstation = "Station9 = 0";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    cleanstation = "Station10 = 0";
                                    break;
                                case 6:
                                    cleanstation = "Station11 = 0";
                                    break;
                                default:
                                    break;
                            }
                            string stm = "UPDATE BODLINE SET " + cleanstation + " WHERE LineID = '" + lineid + "'";
                            mysql.executeQuery(stm);
                            AddMessage("清空轨道" + lineid);
                        }
                        mysql.DisConnect();
                    }
                    catch (Exception ex)
                    {
                        AddMessage(ex.Message);
                    }
                });
            }
            metro.ChangeAccent("Blue");
        }
        private void YieldConfirmButtonCommandExecute()
        {
            for (int i = 0; i < 4; i++)
            {
                if (epsonRC90.YanmadeTester[i].Yield_Nomal >= 95 || epsonRC90.YanmadeTester[i].TestCount_Nomal < 100 + AdminAddNum[i])
                {
                    ;
                }
                else
                {
                    AdminAddNum[i] = epsonRC90.YanmadeTester[i].TestCount_Nomal - 100 + (int)(epsonRC90.YanmadeTester[i].TestCount_Nomal * 0.1);
                }
            }
            QuitYieldAdminControl = !QuitYieldAdminControl;
        }
        #endregion
        #region 自定义函数
        private void Init()
        {
            #region 初始化
            AdminAddNum = new ObservableCollection<int>();
            for (int i = 0; i < 4; i++)
            {
                AdminAddNum.Add(0);
            }
            MessageStr = "";
            AlarmGridVisibility = "Collapsed";
            HomePageVisibility = "Visible";
            ParameterPageVisibility = "Collapsed";
            SamplePageVisibility = "Collapsed";
            AlarmButtonIsEnabled = true;
            MaterialItemsSource = new DataTable();
            MaterialChangeItemsSource = new ObservableCollection<string>();
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
                    //Task.Run(() => { StationEnterRun(); });
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
            TestCountInput = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Summary", "TestCountInput", "0"));
            LastBanci = Inifile.INIGetStringValue(iniParameterPath, "Summary", "LastBanci", "null");
            SampleNgitem = new ObservableCollection<string>();
            for (int i = 0; i < 8; i++)
            {
                SampleNgitem.Add(Inifile.INIGetStringValue(iniParameterPath, "Sample", "NGItem" + i.ToString(), "NA"));
            }
            SampleItemsStatus = new ObservableCollection<string>();
            for (int i = 0; i < 32; i++)
            {
                SampleItemsStatus.Add("NA");
            }
            FlexID = new ObservableCollection<string>();
            for (int i = 0; i < 4; i++)
            {
                FlexID.Add(Inifile.INIGetStringValue(iniFilepath, "A", "id" + (i + 1).ToString(), "99999"));
            }
            //IsSam = bool.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sample", "IsSam", "True"));
            IsSam = true;
            //IsClean = bool.Parse(Inifile.INIGetStringValue(iniParameterPath, "Clean", "IsClean", "True"));
            IsClean = true;

            LastSam1 = Convert.ToDateTime(Inifile.INIGetStringValue(iniParameterPath, "Sample", "LastSam1", "2019/1/1 00:00:00"));
            LastClean1 = Convert.ToDateTime(Inifile.INIGetStringValue(iniParameterPath, "Clean", "LastClean1", "2019/1/1 00:00:00"));
            NGItemCount = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sample", "NGItemCount", "3"));
            NGItemLimit = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "Sample", "NGItemLimit", "99"));

            SampleDStartTimeAM = Inifile.INIGetStringValue(iniParameterPath, "Sample", "SampleDStartTimeAM", "06:00:00");
            SampleDStartTimePM = Inifile.INIGetStringValue(iniParameterPath, "Sample", "SampleDStartTimePM", "12:00:00");
            SampleNStartTimeAM = Inifile.INIGetStringValue(iniParameterPath, "Sample", "SampleNStartTimeAM", "18:00:00");
            SampleNStartTimePM = Inifile.INIGetStringValue(iniParameterPath, "Sample", "SampleNStartTimePM", "00:00:00");

            PM = Inifile.INIGetStringValue(iniParameterPath, "BigData", "PM", "X1621");
            GROUP1 = Inifile.INIGetStringValue(iniParameterPath, "BigData", "GROUP1", "NA");
            TRACK = Inifile.INIGetStringValue(iniParameterPath, "BigData", "TRACK", "NA");
            MACID = Inifile.INIGetStringValue(iniParameterPath, "BigData", "MACID", "NA");
            MACID_M = Inifile.INIGetStringValue(iniParameterPath, "BigData", "MACID_M", "NA");
            WORKSTATION = Inifile.INIGetStringValue(iniParameterPath, "BigData", "WORKSTATION", "X1621");
            LIGHT_ID = Inifile.INIGetStringValue(iniParameterPath, "BigData", "LIGHT_ID", "NA");
            //LIGHT_ID2 = Inifile.INIGetStringValue(iniParameterPath, "BigData", "LIGHT_ID2", "NA");

            LineID1 = Inifile.INIGetStringValue(iniParameterPath, "System", "LineID1", "Line1");
            LineID2 = Inifile.INIGetStringValue(iniParameterPath, "System", "LineID2", "Line2");

            SiteID = Inifile.INIGetStringValue(iniParameterPath, "MachineLog", "SiteID", "HA4F");
            ProjectCode = Inifile.INIGetStringValue(iniParameterPath, "MachineLog", "ProjectCode", "X1621");
            TesterID = Inifile.INIGetStringValue(iniParameterPath, "MachineLog", "TesterID", "NO1");
            LotName = Inifile.INIGetStringValue(iniParameterPath, "MachineLog", "LotName", "MTAXMC18500513");
            ErrorCount = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "MachineLog", "ErrorCount", "0"));

            LampGreenElapse = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "BigData", "LampGreenElapse", "0"));
            LampGreenFlickerElapse = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "BigData", "LampGreenFlickerElapse", "0"));
            LampYellowElapse = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "BigData", "LampYellowElapse", "0"));
            LampYellowFlickerElapse = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "BigData", "LampYellowFlickerElapse", "0"));
            LampRedElapse = int.Parse(Inifile.INIGetStringValue(iniParameterPath, "BigData", "LampRedElapse", "0"));

            TesterID1 = Inifile.INIGetStringValue(iniFilepath, "A", "id1", "99999");
            TesterID2 = Inifile.INIGetStringValue(iniFilepath, "A", "id2", "99999");
            TesterID3 = Inifile.INIGetStringValue(iniFilepath, "A", "id3", "99999");
            TesterID4 = Inifile.INIGetStringValue(iniFilepath, "A", "id4", "99999");

            OperaterID = Inifile.INIGetStringValue(iniFilepath, "Other", "op", "99999");

            epsonRC90 = new EpsonRC90();
            epsonRC90.ModelPrint += ModelPrintEventProcess;
            #endregion
            #region 报警文档
            try
            {
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                if (File.Exists(alarmExcelPath))
                {

                    FileInfo existingFile = new FileInfo(alarmExcelPath);
                    using (ExcelPackage package = new ExcelPackage(existingFile))
                    {
                        // get the first worksheet in the workbook
                        ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                        for (int i = 1; i <= worksheet.Dimension.End.Row; i++)
                        {
                            AlarmData ad = new AlarmData();
                            ad.Code = worksheet.Cells["A" + i.ToString()].Value == null ? "Null" : worksheet.Cells["A" + i.ToString()].Value.ToString();
                            ad.Content = worksheet.Cells["B" + i.ToString()].Value == null ? "Null" : worksheet.Cells["B" + i.ToString()].Value.ToString();
                            ad.Type = worksheet.Cells["C" + i.ToString()].Value == null ? "Null" : worksheet.Cells["C" + i.ToString()].Value.ToString();
                            ad.Start = DateTime.Now;
                            ad.End = DateTime.Now;
                            ad.State = false;
                            AlarmList.Add(ad);
                        }
                        AddMessage("读取到" + worksheet.Dimension.End.Row.ToString() + "条报警");
                    }
                }
                else
                {
                    AddMessage("X1621串线上料机报警.xlsx 文件不存在");
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
            #endregion
            #region 更新本地时间
            try
            {
                SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                if (oraDB.isConnect())
                {
                    string oracleTime = oraDB.OraclDateTime();
                    AddMessage("更新数据库时间到本地" + oracleTime);
                }
                oraDB.disconnect();
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
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
            RunLog(str);
        }
        private async void UIRun()
        {

            int cardcount = 0, timetick = 0, timetick1 = 0;
            bool first = true;
            Fx5u_mid.SetM("M2606", true);
            CardLockFlag = true;
            CardLockTime = DateTime.Now;
            AddMessage("机台锁定!");
            while (true)
            {

                await Task.Delay(100);
                #region 界面刷新
                StatusMid = Fx5u_mid.Connect;
                StatusR1 = Fx5u_right1.Connect;
                switch (Station)
                {
                    case 1:
                        StatusR2 = Fx5u_right2.Connect;
                        break;
                    case 3:
                    case 5:
                        StatusL2 = Fx5u_left2.Connect;
                        StatusR2 = Fx5u_right2.Connect;
                        break;
                    case 2:
                    case 4:
                    case 6:
                        StatusL1 = Fx5u_left1.Connect;
                        StatusL2 = Fx5u_left2.Connect;
                        break;
                    default:
                        break;
                }
                StatusRobot = epsonRC90.IOReceiveStatus && epsonRC90.TestSendStatus && epsonRC90.TestReceiveStatus && epsonRC90.TestReceive1Status;

                if (first)
                {
                    FileInfo existingFile = new FileInfo("C:\\耗材.xlsx");
                    try
                    {
                        epsonRC90.Package = new ExcelPackage(existingFile);
                        epsonRC90.Worksheet = epsonRC90.Package.Workbook.Worksheets[0];

                        for (int i = 0; i < 4; i++)
                        {
                            epsonRC90.Worksheet.Cells[i * 2 + 3, 3].Value = FlexID[i];
                            epsonRC90.Worksheet.Cells[i * 2 + 1 + 3, 3].Value = FlexID[i];
                            epsonRC90.Worksheet.Cells[i * 2 + 3, 2].Value = MACID;
                            epsonRC90.Worksheet.Cells[i * 2 + 1 + 3, 2].Value = MACID;
                            MaterialChangeItemsSource.Add((string)epsonRC90.Worksheet.Cells[i * 2 + 3, 1].Value + "," + FlexID[i]);
                            MaterialChangeItemsSource.Add((string)epsonRC90.Worksheet.Cells[i * 2 + 3 + 1, 1].Value + "," + FlexID[i]);
                        }
                        for (int i = 0; i < 2; i++)
                        {
                            epsonRC90.Worksheet.Cells[i + 11, 3].Value = "NA";
                            epsonRC90.Worksheet.Cells[i + 11, 2].Value = MACID;
                            MaterialChangeItemsSource.Add((string)epsonRC90.Worksheet.Cells[i + 11, 1].Value + "," + "NA");
                        }

                        for (int i = 1; i <= epsonRC90.Worksheet.Dimension.End.Column; i++)
                        {
                            MaterialItemsSource.Columns.Add((string)epsonRC90.Worksheet.Cells[2, i].Value);
                        }
                        try
                        {
                            epsonRC90.Package.Save();
                        }
                        catch (Exception ex)
                        {
                            AddMessage(ex.Message);
                        }
                        first = false;
                        epsonRC90.MaterialFileStatus = true;
                    }
                    catch (Exception ex)
                    {
                        AddMessage(ex.Message);
                    }
                }

                if (!first && timetick1++ > 10)
                {
                    timetick1 = 0;
                    MaterialItemsSource.Clear();
                    for (int i = 3; i <= epsonRC90.Worksheet.Dimension.End.Row; i++)
                    {
                        DataRow dr = MaterialItemsSource.NewRow();
                        for (int j = 1; j <= epsonRC90.Worksheet.Dimension.End.Column; j++)
                        {
                            dr[j - 1] = epsonRC90.Worksheet.Cells[i, j].Value;
                        }
                        MaterialItemsSource.Rows.Add(dr);
                    }

                }
                #endregion
                #region 良率面板显示
                //良率界面显示
                string[] Yieldstrs0 = PassStatusProcess(epsonRC90.YanmadeTester[0].Yield_Nomal);
                PassStatusDisplayText0 = "测试机1" + Yieldstrs0[0];
                PassStatusDisplayForeground0 = Yieldstrs0[1];
                string[] Yieldstrs1 = PassStatusProcess(epsonRC90.YanmadeTester[1].Yield_Nomal);
                PassStatusDisplayText1 = "测试机2" + Yieldstrs1[0];
                PassStatusDisplayForeground1 = Yieldstrs1[1];
                string[] Yieldstrs2 = PassStatusProcess(epsonRC90.YanmadeTester[2].Yield_Nomal);
                PassStatusDisplayText2 = "测试机3" + Yieldstrs2[0];
                PassStatusDisplayForeground2 = Yieldstrs2[1];
                string[] Yieldstrs3 = PassStatusProcess(epsonRC90.YanmadeTester[3].Yield_Nomal);
                PassStatusDisplayText3 = "测试机4" + Yieldstrs3[0];
                PassStatusDisplayForeground3 = Yieldstrs3[1];

                switch (epsonRC90.YanmadeTester[0].TestResult)
                {
                    case TestResult.Ng:
                        TesterResult0 = "F";
                        break;
                    case TestResult.Pass:
                        TesterResult0 = "P";
                        break;
                    default:
                        TesterResult0 = "N";
                        break;
                }
                switch (epsonRC90.YanmadeTester[1].TestResult)
                {
                    case TestResult.Ng:
                        TesterResult1 = "F";
                        break;
                    case TestResult.Pass:
                        TesterResult1 = "P";
                        break;
                    default:
                        TesterResult1 = "N";
                        break;
                }
                switch (epsonRC90.YanmadeTester[2].TestResult)
                {
                    case TestResult.Ng:
                        TesterResult2 = "F";
                        break;
                    case TestResult.Pass:
                        TesterResult2 = "P";
                        break;
                    default:
                        TesterResult2 = "N";
                        break;
                }
                switch (epsonRC90.YanmadeTester[3].TestResult)
                {
                    case TestResult.Ng:
                        TesterResult3 = "F";
                        break;
                    case TestResult.Pass:
                        TesterResult3 = "P";
                        break;
                    default:
                        TesterResult3 = "N";
                        break;
                }
                TestCount0 = epsonRC90.YanmadeTester[0].TestCount_Nomal;
                PassCount0 = epsonRC90.YanmadeTester[0].PassCount_Nomal;
                TestCount1 = epsonRC90.YanmadeTester[1].TestCount_Nomal;
                PassCount1 = epsonRC90.YanmadeTester[1].PassCount_Nomal;
                TestCount2 = epsonRC90.YanmadeTester[2].TestCount_Nomal;
                PassCount2 = epsonRC90.YanmadeTester[2].PassCount_Nomal;
                TestCount3 = epsonRC90.YanmadeTester[3].TestCount_Nomal;
                PassCount3 = epsonRC90.YanmadeTester[3].PassCount_Nomal;

                TestCountOutput = epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount;
                if (TestCountInput > 0)
                {
                    if ((double)(epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount) < TestCountInput)
                    {
                        YieldTotal = Math.Round((double)(epsonRC90.YanmadeTester[0].PassCount + epsonRC90.YanmadeTester[1].PassCount + epsonRC90.YanmadeTester[2].PassCount + epsonRC90.YanmadeTester[3].PassCount) / TestCountInput * 100, 2);
                    }
                    else
                    {
                        YieldTotal = 100;
                    }
                }
                else
                {
                    YieldTotal = 100;
                }
                #endregion
                #region 时间统计
                TestTime0 = epsonRC90.YanmadeTester[0].TestSpan;
                TestTime1 = epsonRC90.YanmadeTester[1].TestSpan;
                TestTime2 = epsonRC90.YanmadeTester[2].TestSpan;
                TestTime3 = epsonRC90.YanmadeTester[3].TestSpan;
                TestIdle0 = epsonRC90.YanmadeTester[0].TestIdle;
                TestIdle1 = epsonRC90.YanmadeTester[1].TestIdle;
                TestIdle2 = epsonRC90.YanmadeTester[2].TestIdle;
                TestIdle3 = epsonRC90.YanmadeTester[3].TestIdle;
                TestCycle0 = epsonRC90.YanmadeTester[0].TestCycle;
                TestCycle1 = epsonRC90.YanmadeTester[1].TestCycle;
                TestCycle2 = epsonRC90.YanmadeTester[2].TestCycle;
                TestCycle3 = epsonRC90.YanmadeTester[3].TestCycle;

                TestCycleAve = Math.Round((epsonRC90.YanmadeTester[0].TestCycle + epsonRC90.YanmadeTester[1].TestCycle + epsonRC90.YanmadeTester[2].TestCycle + epsonRC90.YanmadeTester[3].TestCycle) / 4, 1);
                #endregion
                #region 样本

                if (DateTime.Now.Hour >= 6 && DateTime.Now.Hour < 12)
                {
                    try
                    {
                        SamStartDatetime1 = Convert.ToDateTime(SampleDStartTimeAM);
                        SamNextDatetime1 = Convert.ToDateTime(SampleDStartTimePM);
                    }
                    catch
                    {
                        SamStartDatetime1 = Convert.ToDateTime("06:00:00");
                        SamNextDatetime1 = Convert.ToDateTime("12:00:00");
                    }
                }
                else
                {
                    if (DateTime.Now.Hour >= 12 && DateTime.Now.Hour < 18)
                    {
                        try
                        {
                            SamStartDatetime1 = Convert.ToDateTime(SampleDStartTimePM);
                            SamNextDatetime1 = Convert.ToDateTime(SampleNStartTimeAM);
                        }
                        catch
                        {
                            SamStartDatetime1 = Convert.ToDateTime("12:00:00");
                            SamNextDatetime1 = Convert.ToDateTime("18:00:00");
                        }
                    }
                    else
                    {
                        if (DateTime.Now.Hour >= 18)
                        {
                            try
                            {
                                SamStartDatetime1 = Convert.ToDateTime(SampleNStartTimeAM);
                                SamNextDatetime1 = Convert.ToDateTime(SampleNStartTimePM).AddDays(1);
                            }
                            catch
                            {
                                SamStartDatetime1 = Convert.ToDateTime("18:00:00");
                                SamNextDatetime1 = Convert.ToDateTime("00:00:00").AddDays(1);
                            }
                        }
                        else
                        {
                            try
                            {
                                SamStartDatetime1 = Convert.ToDateTime(SampleNStartTimePM);
                                SamNextDatetime1 = Convert.ToDateTime(SampleDStartTimeAM);
                            }
                            catch
                            {
                                SamStartDatetime1 = Convert.ToDateTime("00:00:00");
                                SamNextDatetime1 = Convert.ToDateTime("06:00:00");
                            }
                        }
                    }

                }


                SamDateBigin1 = SamStartDatetime1.AddHours(-2);

                var timeSpan = LastSam1 > SamStartDatetime1 ? SamNextDatetime1 - DateTime.Now : SamStartDatetime1 - DateTime.Now;
                String fmt = (timeSpan < TimeSpan.Zero ? "\\-dd\\.hh\\:mm\\:ss" : "hh\\:mm\\:ss");
                SpanSam1 = timeSpan.ToString(fmt);

                SampleGridVisibility = (DateTime.Now - SamDateBigin1).TotalSeconds > 0 && (LastSam1 - SamDateBigin1).TotalSeconds < 0 && IsSam ? "Visible" : "Collapsed";
                if ((DateTime.Now - SamDateBigin1).TotalSeconds > 0 && (LastSam1 - SamDateBigin1).TotalSeconds < 0 && IsSam)
                {
                    if (Tester.IsInSampleMode)
                    {
                        SampleText = "样本测试中";
                    }
                    else
                    {
                        if ((DateTime.Now - SamStartDatetime1).TotalSeconds < 0)
                        {
                            SampleText = "请测样本";
                        }
                        else
                        {
                            if (epsonRC90.TestSendStatus && !isSendSamCMD && IsSam)
                            {
                                isSendSamCMD = true;
                                await epsonRC90.TestSentNet.SendAsync("StartSample");
                                AddMessage("StartSample");
                            }                            
                            SampleText = "强制样本";
                        }
                    }
                }
                for (int i = 0; i < 32; i++)
                {
                    SampleItemsStatus[i] = epsonRC90.sampleContent[i % 8][i / 8];
                }

                #endregion
                #region 清洁
                NextClean1 = lastClean1.AddHours(2);
                timeSpan = NextClean1 - DateTime.Now;
                fmt = (timeSpan < TimeSpan.Zero ? "\\-dd\\.hh\\:mm\\:ss" : "hh\\:mm\\:ss");
                SpanClean1 = timeSpan.ToString(fmt);
                if (timeSpan < TimeSpan.Zero)
                {
                    if (IsClean && !isSendCleanCMD && epsonRC90.TestSendStatus)
                    {
                        isSendCleanCMD = true;
                        await epsonRC90.TestSentNet.SendAsync("StartClean");
                        AddMessage("StartClean");
                    }
                }
                #endregion
                #region 刷卡恢复
                if (cardcount++ > 10)
                {
                    cardcount = 0;
                    if (CardLockFlag)
                    {
                        await Task.Run(() =>
                        {
                            try
                            {
                                SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                                if (oraDB.isConnect())
                                {
                                    string stm = string.Format("SELECT * FROM CFT_DATA WHERE TRESULT = 'PASS' AND CFT01 LIKE '%{0}%' AND MNO = '{1}' ORDER BY TESTDATE DESC,TESTTIME DESC",
                                        PM, PM + GROUP1 + TRACK + MACID_M);
                                    DataSet ds = oraDB.executeQuery(stm);
                                    DataTable dt = ds.Tables[0];
                                    if (dt.Rows.Count > 0)
                                    {
                                        DataRow dr = dt.Rows[0];
                                        string datestr = (string)dr["TESTDATE"];
                                        string timestr = (string)dr["TESTTIME"];
                                        if (datestr.Length == 8 && (timestr.Length == 5 || timestr.Length == 6))
                                        {
                                            if (timestr.Length == 5)
                                            {
                                                timestr = "0" + timestr;
                                            }
                                            string datetimestr = string.Empty;
                                            datetimestr = string.Format("{0}/{1}/{2} {3}:{4}:{5}", datestr.Substring(0, 4), datestr.Substring(4, 2), datestr.Substring(6, 2), timestr.Substring(0, 2), timestr.Substring(2, 2), timestr.Substring(4, 2));
                                            DateTime updatetime = Convert.ToDateTime(datetimestr);
                                            if ((updatetime - CardLockTime).TotalMilliseconds > 0)
                                            {
                                                Fx5u_mid.SetM("M2606", false);
                                                CardLockFlag = false;
                                                OperaterID = (string)dr["OPERTOR"];
                                                Inifile.INIWriteValue(iniFilepath, "Other", "op", OperaterID);
                                                AddMessage("刷卡成功，解锁");
                                            }
                                        }
                                    }
                                }
                                oraDB.disconnect();
                            }
                            catch (Exception ex)
                            {
                                AddMessage(ex.Message);
                            }
                        });

                    }
                }
                #region 锁机
                if (!CardLockFlag)
                {
                    if (LampColor != 1)
                    {
                        if (timetick++ > 15 * 600)
                        {
                            Fx5u_mid.SetM("M2606", true);
                            CardLockFlag = true;
                            CardLockTime = DateTime.Now;
                            AddMessage("机台锁定!");
                            timetick = 0;
                        }
                    }
                    else
                    {
                        timetick = 0;
                    }
                }
                else
                {
                    timetick = 0;
                }
                #endregion
                #endregion
                #region 界面后台操作
                if (X40 != null)
                {
                    if (X40[2])
                    {
                        AlarmText = "";
                        AlarmGridVisibility = "Collapsed";
                    }
                }
                #endregion
                #region 换班
                if (LastBanci != epsonRC90.GetBanci())
                {
                    LastBanci = epsonRC90.GetBanci();
                    Inifile.INIWriteValue(iniParameterPath, "Summary", "LastBanci", LastBanci);
                    TestCountInput = 0;
                    Inifile.INIWriteValue(iniParameterPath, "Summary", "TestCountInput", TestCountInput.ToString());
                    WriteMachineData();
                    for (int i = 0; i < 4; i++)
                    {
                        epsonRC90.YanmadeTester[i].Clean();
                    }

                    LampGreenElapse = 0;
                    Inifile.INIWriteValue(iniParameterPath, "BigData", "LampGreenElapse", LampGreenElapse.ToString());
                    LampGreenFlickerElapse = 0;
                    Inifile.INIWriteValue(iniParameterPath, "BigData", "LampGreenFlickerElapse", LampGreenFlickerElapse.ToString());
                    LampYellowElapse = 0;
                    Inifile.INIWriteValue(iniParameterPath, "BigData", "LampYellowElapse", LampYellowElapse.ToString());
                    LampYellowFlickerElapse = 0;
                    Inifile.INIWriteValue(iniParameterPath, "BigData", "LampYellowFlickerElapse", LampYellowFlickerElapse.ToString());
                    LampRedElapse = 0;
                    Inifile.INIWriteValue(iniParameterPath, "BigData", "LampRedElapse", LampRedElapse.ToString());
                    await Task.Run(() =>
                    {
                        Mysql mysql = new Mysql();
                        try
                        {
                            int _result = -999;
                            if (mysql.Connect())
                            {
                                string stm = string.Format("INSERT INTO HA_F4_LIGHT (PM,LIGHT_ID,MACID,CLASS,LIGHT,SDATE,STIME,ALARM,TIME_1,TIME_2,TIME_3,TIME_4,TIME_5,GROUP1,TRACK,WORKSTATION) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','0','0','0','0','0','{8}','{9}','{10}')"
                                    , PM, LIGHT_ID, MACID, epsonRC90.GetBanci(), LampColor.ToString(), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), "NA", GROUP1, TRACK, WORKSTATION);
                                _result = mysql.executeQuery(stm);
    //                            stm = string.Format("INSERT INTO HA_F4_LIGHT (PM,LIGHT_ID,MACID,CLASS,LIGHT,SDATE,STIME,ALARM,TIME_1,TIME_2,TIME_3,TIME_4,TIME_5,GROUP1,TRACK,WORKSTATION) VALUES ('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','0','0','0','0','0','{8}','{9}','{10}')"
    //, PM, LIGHT_ID2, MACID, epsonRC90.GetBanci(), LampColor.ToString(), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), "NA", GROUP1, TRACK, WORKSTATION);
    //                            _result = mysql.executeQuery(stm);
                                AddMessage("插入数据库灯信号" + _result.ToString());
                                stm = string.Format("INSERT INTO HA_F4_DATA_FPY (PM,MACID,CLASS,INPUT,OUTPUT,FAIL,FPY,WORKSTATION,GROUP1,TRACK) VALUES ('{0}','{1}','{2}','0','0','0','0','{3}','{4}','{5}')"
                                    , PM, MACID, epsonRC90.GetBanci(), WORKSTATION, GROUP1, TRACK);
                                _result = mysql.executeQuery(stm);
                                AddMessage("插入数据库良率" + _result.ToString());
                            }
                            
                        }
                        catch (Exception ex)
                        {
                            AddMessage(ex.Message);
                        }
                        finally
                        {
                            mysql.DisConnect();
                        }
                    });
                    Fx5u_mid.SetM("M2606", true);
                    CardLockFlag = true;
                    CardLockTime = DateTime.Now;
                    AddMessage("机台锁定!");
                    AddMessage(LastBanci + " 换班数据清零");

                }
                #endregion
            }
        }
        async void BigDataRun()
        {
            int _LampColor = LampColor;
            int count1 = 0,count2 = 0;
            bool first = true;
            LampGreenSw.Start();
            while (true)
            {
                await Task.Delay(1000);//每秒刷新               
                #region 报警
                if (M300 != null && StatusMid)
                {
                    for (int i = 0; i < AlarmList.Count; i++)
                    {
                        if (M300[i] != AlarmList[i].State && AlarmList[i].Content != "Null" && (LampGreenSw.Elapsed.TotalMinutes > 3 || first))
                        {
                            first = false;
                            LampGreenSw.Reset();
                            AlarmList[i].State = M300[i];
                            if (AlarmList[i].State)
                            {
                                CurrentAlarm = AlarmList[i].Content;

                                AlarmList[i].Start = DateTime.Now;
                                AlarmList[i].End = DateTime.Now;
                                AddMessage(AlarmList[i].Code + AlarmList[i].Content + "发生");

                                AlarmAction(i);//等待报警结束
                            }

                        }
                    }

                }
                #endregion
                #region 灯号更新
                switch (LampColor)
                {
                    case 1:
                        LampGreenElapse += 1;
                        Inifile.INIWriteValue(iniParameterPath, "BigData", "LampGreenElapse", LampGreenElapse.ToString());
                        break;
                    case 2:
                        LampGreenFlickerElapse += 1;
                        Inifile.INIWriteValue(iniParameterPath, "BigData", "LampGreenFlickerElapse", LampGreenFlickerElapse.ToString());
                        break;
                    case 3:
                        LampYellowElapse += 1;
                        Inifile.INIWriteValue(iniParameterPath, "BigData", "LampYellowElapse", LampYellowElapse.ToString());
                        break;
                    case 4:
                        LampYellowFlickerElapse += 1;
                        Inifile.INIWriteValue(iniParameterPath, "BigData", "LampYellowFlickerElapse", LampYellowFlickerElapse.ToString());
                        break;
                    case 5:
                        LampRedElapse += 1;
                        Inifile.INIWriteValue(iniParameterPath, "BigData", "LampRedElapse", LampRedElapse.ToString());
                        break;
                    default:
                        break;
                }
                count1++;
                if (_LampColor != LampColor || count1 > 60)
                {

                    if (LampColor == 1 && _LampColor != LampColor)
                    {
                        LampGreenSw.Restart();
                    }
                    _LampColor = LampColor;
                    count1 = 0;

                    string result = await Task<string>.Run(() =>
                    {
                        try
                        {
                            int _result = -999;
                            Mysql mysql = new Mysql();
                            if (mysql.Connect())
                            {
                                string currentAlarm = LampColor == 4 ? CurrentAlarm : "NA";
                                string stm = string.Format("UPDATE HA_F4_LIGHT SET LIGHT = '{3}',SDATE = '{4}',STIME = '{5}',ALARM = '{6}',TIME_1 = '{8}',TIME_2 = '{9}',TIME_3 = '{10}',TIME_4 = '{11}',TIME_5 = '{12}' WHERE PM = '{0}' AND LIGHT_ID = '{1}' AND MACID = '{2}' AND CLASS = '{7}' AND GROUP1 = '{13}' AND TRACK = '{14}' AND WORKSTATION = '{15}'"
                                    , PM, LIGHT_ID, MACID, LampColor.ToString(), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), currentAlarm, epsonRC90.GetBanci(), ((double)LampGreenElapse / 60).ToString("F2"), ((double)LampGreenFlickerElapse / 60).ToString("F2"), ((double)LampYellowElapse / 60).ToString("F2")
                                    , ((double)LampYellowFlickerElapse / 60).ToString("F2"), ((double)LampRedElapse / 60).ToString("F2"), GROUP1, TRACK, WORKSTATION);
                                _result = mysql.executeQuery(stm);
    //                            stm = string.Format("UPDATE HA_F4_LIGHT SET LIGHT = '{3}',SDATE = '{4}',STIME = '{5}',ALARM = '{6}',TIME_1 = '{8}',TIME_2 = '{9}',TIME_3 = '{10}',TIME_4 = '{11}',TIME_5 = '{12}' WHERE PM = '{0}' AND LIGHT_ID = '{1}' AND MACID = '{2}' AND CLASS = '{7}' AND GROUP1 = '{13}' AND TRACK = '{14}' AND WORKSTATION = '{15}'"
    //, PM, LIGHT_ID2, MACID, LampColor.ToString(), DateTime.Now.ToString("yyyyMMdd"), DateTime.Now.ToString("HHmmss"), currentAlarm, epsonRC90.GetBanci(), ((double)LampGreenElapse / 60).ToString("F2"), ((double)LampGreenFlickerElapse / 60).ToString("F2"), ((double)LampYellowElapse / 60).ToString("F2")
    //, ((double)LampYellowFlickerElapse / 60).ToString("F2"), ((double)LampRedElapse / 60).ToString("F2"), GROUP1, TRACK, WORKSTATION);
    //                            _result = mysql.executeQuery(stm);
                            }
                            mysql.DisConnect();
                            return _result.ToString();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                    });
                    //AddMessage("更新灯信号" + result);

                }
                if (LampColor != 1)
                {
                    LampGreenSw.Reset();
                }
                if (LampColor == 1 && LampGreenSw.Elapsed == TimeSpan.Zero)
                {
                    LampGreenSw.Restart();
                }
                #endregion
                #region 插入良率
                count2++;
                if (count2 > 60)
                {
                    count2 = 0;
                    string result = await Task<string>.Run(() =>
                    {
                        try
                        {
                            int _result = -999;
                            Mysql mysql = new Mysql();
                            if (mysql.Connect())
                            {
                                double fpy = TestCountInput > 0 ? (double)TestCountOutput / TestCountInput * 100 : 0;
                                string stm = string.Format("UPDATE HA_F4_DATA_FPY SET INPUT = '{3}',OUTPUT = '{4}',FAIL = '{5}',FPY = '{6}' WHERE PM = '{0}' AND MACID = '{1}' AND CLASS = '{2}' AND GROUP1 = '{7}' AND TRACK = '{8}' AND WORKSTATION = '{9}'"
                                    , PM, MACID, epsonRC90.GetBanci(), TestCountInput.ToString(), TestCountOutput.ToString(), (TestCountInput - TestCountOutput).ToString(), fpy.ToString("F1"), GROUP1, TRACK, WORKSTATION);
                                _result = mysql.executeQuery(stm);
                            }
                            mysql.DisConnect();
                            return _result.ToString();
                        }
                        catch (Exception ex)
                        {
                            return ex.Message;
                        }
                    });
                    //AddMessage("上传良率" + result);
                }

                #endregion
                GreenElapse = Math.Round(LampGreenSw.Elapsed.TotalMinutes,1);
            }

        }
        async void MachineLogRun()
        {
            var mInput = TestCountInput;
            var mPass = TestCountOutput;
            var FailCount = epsonRC90.YanmadeTester[0].FailCount + epsonRC90.YanmadeTester[1].FailCount + epsonRC90.YanmadeTester[2].FailCount + epsonRC90.YanmadeTester[3].FailCount;
            var mFail = FailCount;
            var mError = ErrorCount;
            int tickcount1 = 0;
            bool MInit = false, MStart = false, MEnd = false;
            bool first = true;
            while (true)
            {
                await Task.Delay(1000);
                try
                {
                    string machineLogpath = @"D:\MachineLog" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                    string machineSummarypath = @"D:\MachineSummary" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
                    if (!File.Exists(machineLogpath))
                    {
                        ErrorCount = 0;
                        Inifile.INIWriteValue(iniParameterPath, "MachineLog", "ErrorCount", ErrorCount.ToString());
                        string[] heads = new string[] { "SiteID", "ProjectCode", "TesterID", "DATE", "TIME", "LOT NAME", "LOGIN MODE", "STOP TIME", "RESTART TIME", "DOWN TIME", "KEYWORD", "STATUS", "ERROR CODE", "ERROR TYPE", "ERROR MESSAGE", "MESSAGE" };
                        Csvfile.savetocsv(machineLogpath, heads);
                    }
                    if (!File.Exists(machineSummarypath))
                    {
                        string[] heads = new string[] { "SiteID", "ProjectCode", "TesterID", "DATE", "TIME", "LOT NAME", "LOGIN MODE", "INPUT", "PASS", "FAIL", "Error#", "Socket Usage" };
                        Csvfile.savetocsv(machineSummarypath, heads);
                    }
                    //MachineLog
                    if (tickcount1++ > 60)
                    {
                        tickcount1 = 0;
                        FailCount = epsonRC90.YanmadeTester[0].FailCount + epsonRC90.YanmadeTester[1].FailCount + epsonRC90.YanmadeTester[2].FailCount + epsonRC90.YanmadeTester[3].FailCount;
                        string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", (TestCountInput - mInput).ToString(), (TestCountOutput - mPass).ToString(), (FailCount - mFail).ToString(), (ErrorCount - mError).ToString(), "1111" };
                        mInput = TestCountInput;
                        mFail = FailCount;
                        mError = ErrorCount;
                        Csvfile.savetocsv(machineSummarypath, contents);
                    }

                    if (M2000 != null && StatusMid)
                    {
                        if (first)
                        {
                            MInit = M2000[0];
                            MStart = M2000[1];
                            MEnd = M2000[2];
                        }
                        if (MInit != M2000[0])
                        {
                            MInit = M2000[0];
                            if (M2000[0])
                            {
                                string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "INITIALIZE END", "", "", "", "", "" };
                                Csvfile.savetocsv(machineLogpath, contents);
                            }
                            else
                            {
                                string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "INITIALIZE START", "", "", "", "", "" };
                                Csvfile.savetocsv(machineLogpath, contents);
                            }
                        }
                        if (MStart != M2000[1])
                        {
                            MStart = M2000[1];
                            if (M2000[1])
                            {
                                string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "START", "", "", "", "", "" };
                                Csvfile.savetocsv(machineLogpath, contents);
                            }
                        }
                        if (MEnd != M2000[2])
                        {
                            MEnd = M2000[2];
                            if (M2000[2])
                            {
                                string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "END", "", "", "", "", "" };
                                Csvfile.savetocsv(machineLogpath, contents);
                                MachineLogAction();
                            }
                        }
                    }
                    if (DateTime.Now.Minute == 59 && DateTime.Now.Second == 59)
                    {
                        MachineLogAction();
                    }

                }
                catch { }
            }
        }
        private void MachineLogAction()
        {
            string machineLogpath = @"D:\MachineLog" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "PASS", TestCountOutput.ToString(), "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
            var FailCount = epsonRC90.YanmadeTester[0].FailCount + epsonRC90.YanmadeTester[1].FailCount + epsonRC90.YanmadeTester[2].FailCount + epsonRC90.YanmadeTester[3].FailCount;
            contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "FAIL", FailCount.ToString(), "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
            contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "RATE", ((double)TestCountOutput/(TestCountOutput + FailCount) * 100).ToString("F1"), "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
            int _time = LampYellowFlickerElapse + LampRedElapse;
            string downtime = string.Format("{0}:{1}:{2}",(_time / 3600).ToString(), (_time / 60).ToString(), (_time % 60).ToString());
            contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "DOWN TIME", downtime, "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
            _time = LampGreenElapse;
            downtime = string.Format("{0}:{1}:{2}", (_time / 3600).ToString(), (_time / 60).ToString(), (_time % 60).ToString());
            contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "PRODUCTION TIME", downtime, "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
            _time = LampGreenFlickerElapse + LampYellowElapse;
            downtime = string.Format("{0}:{1}:{2}", (_time / 3600).ToString(), (_time / 60).ToString(), (_time % 60).ToString());
            contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", "", "", "", "IDLE TIME", downtime, "", "", "", "" };
            Csvfile.savetocsv(machineLogpath, contents);
        }
        async void AlarmAction(int i)
        {
            while (true)
            {
                await Task.Delay(100);
                try
                {
                    if (LampGreenSw.Elapsed.TotalMinutes > 3)
                    {
                        break;
                    }
                }
                catch (Exception ex)
                {
                    AddMessage("AlarmAction " + ex.Message);
                }
            }
            AlarmList[i].End = DateTime.Now - LampGreenSw.Elapsed;
            AddMessage(AlarmList[i].Code + AlarmList[i].Content + "解除");
            TimeSpan time = AlarmList[i].End - AlarmList[i].Start;

            string result = await Task<string>.Run(() =>
            {
                try
                {
                    int _result = -999;
                    Mysql mysql = new Mysql();
                    if (mysql.Connect())
                    {
                        string stm = string.Format("INSERT INTO HA_F4_DATA_ALARM (PM, GROUP1,TRACK,MACID,NAME,SSTARTDATE,SSTARTTIME,SSTOPDATE,SSTOPTIME,TIME,CLASS,WORKSTATION) VALUES('{0}','{1}','{2}','{3}','{4}','{5}','{6}','{7}','{8}','{9}','{10}','{11}')"
                            , PM, GROUP1, TRACK, MACID, AlarmList[i].Content, AlarmList[i].Start.ToString("yyyyMMdd"), AlarmList[i].Start.ToString("HHmmss"), AlarmList[i].End.ToString("yyyyMMdd"), AlarmList[i].End.ToString("HHmmss"), time.TotalMinutes.ToString("F1"), epsonRC90.GetBanci(), WORKSTATION);
                        _result = mysql.executeQuery(stm);
                    }
                    mysql.DisConnect();
                    return _result.ToString();
                }
                catch (Exception ex)
                {
                    return ex.Message;
                }
            });
            AddMessage("插入报警" + result);


            ErrorCount++;
            Inifile.INIWriteValue(iniParameterPath, "MachineLog", "ErrorCount", ErrorCount.ToString());

            string machineLogpath = @"D:\MachineLog" + DateTime.Now.ToString("yyyyMMdd") + ".csv";
            if (!File.Exists(machineLogpath))
            {
                string[] heads = new string[] { "SiteID", "ProjectCode", "TesterID", "DATE", "TIME", "LOT NAME", "LOGIN MODE", "STOP TIME", "RESTART TIME", "DOWN TIME", "KEYWORD", "STATUS", "ERROR CODE", "ERROR TYPE", "ERROR MESSAGE", "MESSAGE" };
                Csvfile.savetocsv(machineLogpath, heads);
            }
            string[] contents = new string[] { SiteID, ProjectCode, TesterID, DateTime.Now.ToString("dd/MM/yyyy"), DateTime.Now.ToString("HH:mm:ss"), LotName, "OPERATOR", AlarmList[i].Start.ToString("HH:mm:ss"), AlarmList[i].End.ToString("HH:mm:ss"), time.ToString(), "WARNING" ,"", AlarmList[i].Code,"", AlarmList[i].Type, AlarmList[i].Content };
            Csvfile.savetocsv(machineLogpath, contents);
        }
        private string[] PassStatusProcess(double f)
        {
            string[] strs = new string[2];
            if (f > 98)
            {
                strs[0] = "良率" + f.ToString() + "% 优秀";
                strs[1] = "Blue";
            }
            else
            {
                if (f > 95)
                {
                    strs[0] = "良率" + f.ToString() + "% 正常";
                    strs[1] = "Green";
                }
                else
                {
                    if (f == 0)
                    {
                        strs[0] = "良率" + f.ToString() + "% 未知";
                        strs[1] = "Black";
                    }
                    else
                    {
                        strs[0] = "良率" + f.ToString() + "% 异常";
                        strs[1] = "Red";
                    }
                }
            }
            return strs;
        }
        private void WriteMachineData()
        {
            string excelpath = @"D:\X1621MachineData.xlsx";

            try
            {
                FileInfo fileInfo = new FileInfo(excelpath);
                ExcelPackage.LicenseContext = LicenseContext.NonCommercial;
                if (!File.Exists(excelpath))
                {                    
                    using (ExcelPackage package = new ExcelPackage(fileInfo))
                    {
                        ExcelWorksheet worksheet = package.Workbook.Worksheets.Add("MachineData");
                        worksheet.Cells[1, 1].Value = "日期时间";
                        for (int i = 0; i < 4; i++)
                        {
                            worksheet.Cells[1, 2 + i * 4].Value = "穴" + (i + 1).ToString() + "测试数";
                            worksheet.Cells[1, 3 + i * 4].Value = "穴" + (i + 1).ToString() + "良品数";
                            worksheet.Cells[1, 4 + i * 4].Value = "穴" + (i + 1).ToString() + "不良品数";
                            worksheet.Cells[1, 5 + i * 4].Value = "穴" + (i + 1).ToString() + "良率";
                        }
                        for (int i = 0; i < 4; i++)
                        {
                            worksheet.Cells[1, 18 + i * 4].Value = "穴" + (i + 1).ToString() + "测试数AAB";
                            worksheet.Cells[1, 19 + i * 4].Value = "穴" + (i + 1).ToString() + "良品数AAB";
                            worksheet.Cells[1, 20 + i * 4].Value = "穴" + (i + 1).ToString() + "不良品数AAB";
                            worksheet.Cells[1, 21 + i * 4].Value = "穴" + (i + 1).ToString() + "良率AAB";
                        }
                        package.Save();
                    }
                }
                using (ExcelPackage package = new ExcelPackage(fileInfo))
                {
                    ExcelWorksheet worksheet = package.Workbook.Worksheets[0];
                    int newrow = worksheet.Dimension.End.Row + 1;
                    worksheet.Cells[newrow, 1].Value = System.DateTime.Now.ToString();
                    for (int i = 0; i < 4; i++)
                    {
                        worksheet.Cells[newrow, 2 + i * 4].Value = epsonRC90.YanmadeTester[i].TestCount_Nomal;
                        worksheet.Cells[newrow, 3 + i * 4].Value = epsonRC90.YanmadeTester[i].PassCount_Nomal;
                        worksheet.Cells[newrow, 4 + i * 4].Value = epsonRC90.YanmadeTester[i].FailCount_Nomal;
                        worksheet.Cells[newrow, 5 + i * 4].Value = epsonRC90.YanmadeTester[i].Yield_Nomal;

                        worksheet.Cells[newrow, 18 + i * 4].Value = epsonRC90.YanmadeTester[i].TestCount;
                        worksheet.Cells[newrow, 19 + i * 4].Value = epsonRC90.YanmadeTester[i].PassCount;
                        worksheet.Cells[newrow, 20 + i * 4].Value = epsonRC90.YanmadeTester[i].FailCount;
                        worksheet.Cells[newrow, 21 + i * 4].Value = epsonRC90.YanmadeTester[i].Yield;
                    }
                    package.Save();
                }
                //AddMessage("保存机台生产数据完成");
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }
        private void SystemRun()
        {
            Stopwatch sw = new Stopwatch();
            string stm = "";
            while (true)
            {
                System.Threading.Thread.Sleep(10);
                sw.Restart();
                #region 扫码
                try
                {
                    //扫码（载具）【A轨道】
                    if (Fx5u_mid.ReadM("M2797"))
                    {
                        AddMessage("轨道A扫码");

                        Fx5u_mid.SetM("M2797", false);
                        Fx5u_mid.SetMultiM("M2597", new bool[4] { false, false, false, false });
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2596", false);
                                Fx5u_right1.SetM("M2597", false);
                                Fx5u_right1.SetM("M2600", false);
                                break;
                            default:
                                break;
                        }
                        scan1.GetBarCode(Scan1GetBarcodeCallback);
                    }
                    //扫码（载具）【B轨道】
                    if (Fx5u_mid.ReadM("M2802"))
                    {
                        AddMessage("轨道B扫码");
                        Fx5u_mid.SetM("M2802", false);
                        Fx5u_mid.SetMultiM("M2602", new bool[4] { false, false, false, false });
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2602", false);
                                Fx5u_right1.SetM("M2603", false);
                                Fx5u_right1.SetM("M2606", false);
                                break;
                            default:
                                break;
                        }
                        scan2.GetBarCode(Scan2GetBarcodeCallback);
                    }
                }
                catch 
                { }
                #endregion
                #region 上顶
                try
                {
                    //A轨道
                    if (Fx5u_mid.ReadM("M2798"))
                    {
                        AddMessage("轨道A上顶");
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2596", false);
                                Fx5u_right1.SetM("M2597", false);
                                Fx5u_right1.SetM("M2600", false);
                                break;
                            default:
                                break;
                        }
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                    stm = "UPDATE BODLINE SET Station1 = 1, Station9 = 0 WHERE LineID = '" + LineID1 + "'";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 1, Station10 = Station10 - 1 WHERE LineID = '" + LineID1 + "'";
                                    break;
                                case 6:
                                    stm = "UPDATE BODLINE SET Station6 = 1, Station11 = 0 WHERE LineID = '" + LineID1 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);
                        }
                        mysql.DisConnect();
                        epsonRC90.BordBarcode[0] = epsonRC90.TemporaryBordBarcode[0];
                        epsonRC90.ResetBord(0);
                        //stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + epsonRC90.BordBarcode[0] + "','ON')";
                        //mysql.executeQuery(stm);
                        Fx5u_mid.SetM("M2798", false);

                    }
                    //B轨道
                    if (Fx5u_mid.ReadM("M2803"))
                    {
                        AddMessage("轨道B上顶");
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2602", false);
                                Fx5u_right1.SetM("M2603", false);
                                Fx5u_right1.SetM("M2606", false);
                                break;
                            default:
                                break;
                        }

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                    stm = "UPDATE BODLINE SET Station1 = 1, Station9 = 0 WHERE LineID = '" + LineID2 + "'";
                                    break;
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 1, Station10 = Station10 - 1 WHERE LineID = '" + LineID2 + "'";
                                    break;
                                case 6:
                                    stm = "UPDATE BODLINE SET Station6 = 1, Station11 = 0 WHERE LineID = '" + LineID2 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);
                        }
                        mysql.DisConnect();
                        epsonRC90.BordBarcode[1] = epsonRC90.TemporaryBordBarcode[1];
                        epsonRC90.ResetBord(1);
                        //stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + epsonRC90.BordBarcode[1] + "','ON')";
                        //mysql.executeQuery(stm);

                        Fx5u_mid.SetM("M2803", false);
                    }
                }
                catch
                { }

                #endregion
                #region 测完下放
                try
                {
                    if (Fx5u_mid.ReadM("M2799"))
                    {
                        AddMessage("轨道A测完下放");
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2596", false);
                                Fx5u_right1.SetM("M2597", false);
                                Fx5u_right1.SetM("M2600", true);
                                break;
                            default:
                                break;
                        }
                        
                        SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                        Mysql mysql = new Mysql();
                        if (oraDB.isConnect() && mysql.Connect())
                        {
                            stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 0 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + epsonRC90.BordBarcode[0] + "','ON')";

                            int rst = oraDB.executeNonQuery(stm);
                            AddMessage("板" + epsonRC90.BordBarcode[0] + "绑定结果 " + rst.ToString());
                            oraDB.executeNonQuery("COMMIT");
                            epsonRC90.BordBarcode[0] = "Empty";
                            
                        }
                        mysql.DisConnect();
                        oraDB.disconnect();
                        Fx5u_mid.SetM("M2799", false);

                    }
                    if (Fx5u_mid.ReadM("M2804"))
                    {
                        AddMessage("轨道B测完下放");
                        switch (Station)
                        {
                            case 5:
                            case 1:
                                Fx5u_right1.SetM("M2602", false);
                                Fx5u_right1.SetM("M2603", false);
                                Fx5u_right1.SetM("M2606", true);
                                break;
                            default:
                                break;
                        }
                        
                        SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                        Mysql mysql = new Mysql();
                        if (oraDB.isConnect() && mysql.Connect())
                        {
                            stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 0 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + epsonRC90.BordBarcode[1] + "','ON')";

                            int rst = oraDB.executeNonQuery(stm);
                            AddMessage("板" + epsonRC90.BordBarcode[1] + "绑定结果 " + rst.ToString());
                            oraDB.executeNonQuery("COMMIT");
                            epsonRC90.BordBarcode[1] = "Empty";
                            
                        }
                        oraDB.disconnect();
                        Fx5u_mid.SetM("M2804", false);

                    }
                }
                catch
                { }

                #endregion
                #region 测试机屏蔽
                try
                {
                    //A轨道
                    if (Fx5u_mid.ReadM("M2810"))
                    {
                        AddMessage("测试机A屏蔽");

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 1 WHERE LineID = '" + LineID1 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);

                        }
                        mysql.DisConnect();
                        Fx5u_mid.SetM("M2810", false);
                    }
                    if (Fx5u_mid.ReadM("M2812"))
                    {
                        AddMessage("测试机A取消屏蔽");

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 0 WHERE LineID = '" + LineID1 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);

                        }
                        mysql.DisConnect();
                        Fx5u_mid.SetM("M2812", false);
                    }
                    //B轨道
                    if (Fx5u_mid.ReadM("M2811"))
                    {
                        AddMessage("测试机B屏蔽");

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 1 WHERE LineID = '" + LineID2 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);

                        }
                        mysql.DisConnect();
                        Fx5u_mid.SetM("M2811", false);
                    }
                    if (Fx5u_mid.ReadM("M2813"))
                    {
                        AddMessage("测试机B取消屏蔽");

                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            switch (Station)
                            {
                                case 1:
                                case 2:
                                case 3:
                                case 4:
                                case 5:
                                case 6:
                                    stm = "UPDATE BODLINE SET Station" + Station.ToString() + " = 0 WHERE LineID = '" + LineID2 + "'";
                                    break;
                                default:
                                    break;
                            }
                            mysql.executeQuery(stm);

                        }
                        mysql.DisConnect();
                        Fx5u_mid.SetM("M2813", false);
                    }
                }
                catch { }                

                #endregion
                #region 读写PLC信号
                try
                {
                    //读报警
                    M300 = Fx5u_mid.ReadMultiM("M300", 64);
                    //读三色灯状态
                    LampColor = Fx5u_mid.ReadW("D200");
                    //读机台状态
                    M2000 = Fx5u_mid.ReadMultiM("M2000", 16);
                    X40 = Fx5u_mid.ReadMultiM("X20", 16);
                }
                catch { }
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
        void Scan1GetBarcodeCallback(string barcode)
        {
            try
            {
                epsonRC90.TemporaryBordBarcode[0] = barcode;
                if (barcode != "Error")
                {
                    SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                    if (oraDB.isConnect())
                    {
                        string stm;
                        if (Station == 1)
                        {
                            stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + barcode + "','OFF')";

                            int rst = oraDB.executeNonQuery(stm);
                            oraDB.executeNonQuery("COMMIT");
                            AddMessage("1号机板" + barcode + "清空结果 " + rst.ToString());
                        }


                        stm = "SELECT * FROM (SELECT * FROM BODMSG WHERE SCBODBAR = '" + barcode + "' ORDER BY SIDATE DESC) WHERE ROWNUM <= 5 ";
                        DataSet ds = oraDB.executeQuery(stm);
                        DataTable dt = ds.Tables["table0"];
                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["STATUS"] == DBNull.Value)
                            {
                                Fx5u_mid.SetM("M2600", true);
                                switch (Station)
                                {
                                    case 1:
                                        DockStation1Check(0);
                                        break;
                                    case 5:
                                        DockStation2Check(0);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                if ((string)dt.Rows[0]["STATUS"] == "OFF")
                                {
                                    Fx5u_mid.SetM("M2600", true);
                                    switch (Station)
                                    {
                                        case 1:
                                            DockStation1Check(0);
                                            break;
                                        case 5:
                                            DockStation2Check(0);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else
                                {
                                    AddMessage("板 " + barcode + " 已测过");
                                    Fx5u_mid.SetM("M2599", true);
                                    switch (Station)
                                    {
                                        case 1:
                                        case 5:
                                            Fx5u_right1.SetM("M2600", true);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Fx5u_mid.SetM("M2600", true);
                            switch (Station)
                            {
                                case 1:
                                    DockStation1Check(0);
                                    break;
                                case 5:
                                    DockStation2Check(0);
                                    break;
                                default:
                                    break;
                            }
                        }
                        Fx5u_mid.SetM("M2597", true);
                    }
                    else
                    {
                        AddMessage("Mysql数据库查询失败");
                        Fx5u_mid.SetM("M2598", true);
                    }
                    oraDB.disconnect();
                }
                else
                {
                    Fx5u_mid.SetM("M2598", true);
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
            
        }
        void DockStation1Check(int lineIndex)
        {
            string lineid = lineIndex == 0 ? LineID1 : LineID2;
            try
            {
                Mysql mysql = new Mysql();
                if (mysql.Connect())
                {
                    string stm = "SELECT * FROM BODLINE WHERE LineID = '" + lineid + "' ORDER BY SIDATE DESC";
                    DataSet ds = mysql.Select(stm);
                    DataTable dt = ds.Tables["table0"];
                    if (dt.Rows.Count > 0)
                    {
                        int bordcount = (int)dt.Rows[0]["Station2"] + (int)dt.Rows[0]["Station3"] + (int)dt.Rows[0]["Station4"] + (int)dt.Rows[0]["Station5"] + (int)dt.Rows[0]["Station6"];
                        if (bordcount < 5)//轨道+测试机板数量 < 5 不存储，放板
                        {
                            if (lineIndex == 0)
                            {
                                Fx5u_right1.SetM("M2596", true);
                                AddMessage("线A内接驳台1后板数:" + bordcount.ToString() + " < 5,直接放板");
                            }
                            else
                            {
                                //B轨道
                                Fx5u_right1.SetM("M2602", true);
                                AddMessage("线B内接驳台1后板数:" + bordcount.ToString() + " < 5,直接放板");
                            }
                        }
                        else
                        {
                            if (lineIndex == 0)
                            {
                                Fx5u_right1.SetM("M2597", true);
                                AddMessage("线A内接驳台1,存储板");
                            }
                            else
                            {
                                //B轨道
                                Fx5u_right1.SetM("M2603", true);
                                AddMessage("线B内接驳台1,存储板");
                            }
                        }
                    }
                }
                mysql.DisConnect();
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }
        void DockStation2Check(int lineIndex)
        {
            string lineid = lineIndex == 0 ? LineID1 : LineID2;
            try
            {
                Mysql mysql = new Mysql();
                if (mysql.Connect())
                {
                    string stm = "SELECT * FROM BODLINE WHERE LineID = '" + lineid + "' ORDER BY SIDATE DESC";
                    DataSet ds = mysql.Select(stm);
                    DataTable dt = ds.Tables["table0"];
                    if (dt.Rows.Count > 0)
                    {
                        int bordcount = (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station11"];
                        if (bordcount < 1)//轨道+测试机板数量 < 1 不存储，放板
                        {
                            if (lineIndex == 0)
                            {
                                Fx5u_right1.SetM("M2596", true);
                                AddMessage("线A内接驳台2后板数:" + bordcount.ToString() + " < 1,直接放板");
                            }
                            else
                            {
                                //B轨道
                                Fx5u_right1.SetM("M2602", true);
                                AddMessage("线B内接驳台2后板数:" + bordcount.ToString() + " < 1,直接放板");
                            }
                        }
                        else
                        {
                            if (lineIndex == 0)
                            {
                                Fx5u_right1.SetM("M2597", true);
                                AddMessage("线A内接驳台2,存储板");
                            }
                            else
                            {
                                //B轨道
                                Fx5u_right1.SetM("M2603", true);
                                AddMessage("线B内接驳台2,存储板");
                            }
                        }
                    }
                }
                mysql.DisConnect();
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
        }
        void Scan2GetBarcodeCallback(string barcode)
        {
            try
            {
                epsonRC90.TemporaryBordBarcode[1] = barcode;
                if (barcode != "Error")
                {
                    SXJLibrary.Oracle oraDB = new SXJLibrary.Oracle("qddb04.eavarytech.com", "mesdb04", "ictdata", "ictdata*168");
                    if (oraDB.isConnect())
                    {
                        string stm;
                        if (Station == 1)
                        {
                            stm = "INSERT INTO BODMSG (SCBODBAR, STATUS) VALUES('" + barcode + "','OFF')";

                            int rst = oraDB.executeNonQuery(stm);
                            oraDB.executeNonQuery("COMMIT");
                            AddMessage("1号机板" + barcode + "清空结果 " + rst.ToString());
                        }

                        stm = "SELECT * FROM (SELECT * FROM BODMSG WHERE SCBODBAR = '" + barcode + "' ORDER BY SIDATE DESC) WHERE ROWNUM <= 5";
                        DataSet ds = oraDB.executeQuery(stm);
                        DataTable dt = ds.Tables["table0"];
                        if (dt.Rows.Count > 0)
                        {
                            if (dt.Rows[0]["STATUS"] == DBNull.Value)
                            {

                                Fx5u_mid.SetM("M2605", true);
                                switch (Station)
                                {
                                    case 1:
                                        DockStation1Check(1);
                                        break;
                                    case 5:
                                        DockStation2Check(1);
                                        break;
                                    default:
                                        break;
                                }
                            }
                            else
                            {
                                if ((string)dt.Rows[0]["STATUS"] == "OFF")
                                {
                                    Fx5u_mid.SetM("M2605", true);
                                    switch (Station)
                                    {
                                        case 1:
                                            DockStation1Check(1);
                                            break;
                                        case 5:
                                            DockStation2Check(1);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                                else
                                {
                                    AddMessage("板 " + barcode + " 已测过");
                                    Fx5u_mid.SetM("M2604", true);
                                    switch (Station)
                                    {
                                        case 1:
                                        case 5:
                                            Fx5u_right1.SetM("M2606", true);
                                            break;
                                        default:
                                            break;
                                    }
                                }
                            }
                        }
                        else
                        {
                            Fx5u_mid.SetM("M2605", true);
                            switch (Station)
                            {
                                case 1:
                                    DockStation1Check(1);
                                    break;
                                case 5:
                                    DockStation2Check(1);
                                    break;
                                default:
                                    break;
                            }
                        }
                        Fx5u_mid.SetM("M2602", true);
                    }
                    else
                    {
                        AddMessage("Mysql数据库查询失败");
                        Fx5u_mid.SetM("M2603", true);
                    }
                    oraDB.disconnect();
                }
                else
                {
                    Fx5u_mid.SetM("M2603", true);
                }
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
            }
            
        }
        void StationEnterRun()
        {
            while (true)
            {
                System.Threading.Thread.Sleep(10000);
                try
                {
                    Mysql mysql = new Mysql();
                    if (mysql.Connect())
                    {
                        //【轨道A】
                        string stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID1 + "' ORDER BY SIDATE DESC";
                        DataSet ds = mysql.Select(stm);
                        DataTable dt = ds.Tables["table0"];
                        if (dt.Rows.Count > 0)
                        {
                            int bordcount = (int)dt.Rows[0]["Station1"] + (int)dt.Rows[0]["Station2"] + (int)dt.Rows[0]["Station3"] + (int)dt.Rows[0]["Station4"] + (int)dt.Rows[0]["Station5"] + (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station7"] + (int)dt.Rows[0]["Station8"] + (int)dt.Rows[0]["Station9"] + (int)dt.Rows[0]["Station10"] + (int)dt.Rows[0]["Station11"];
                            if (!Fx5u_mid.ReadM("M2596") && bordcount < 21 && (int)dt.Rows[0]["Station7"] < 1)//不在进板；有进板需求；轨道1空
                            {
                                Fx5u_mid.SetM("M2796", false);
                                Fx5u_mid.SetM("M2596", true);
                                AddMessage("线A内板数:" + bordcount.ToString() + " < 21,申请进板");
                            }
                            if (Fx5u_mid.ReadM("M2796"))
                            {
                                Fx5u_mid.SetM("M2796", false);
                                Fx5u_mid.SetM("M2596", false);
                                stm = "UPDATE BODLINE SET Station9 = 1 WHERE LineID = '" + LineID1 + "'";
                                mysql.executeQuery(stm);
                                AddMessage("线A进入1块板");
                            }
                        }

                        //【轨道B】
                        stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID2 + "' ORDER BY SIDATE DESC";
                        ds = mysql.Select(stm);
                        dt = ds.Tables["table0"];
                        if (dt.Rows.Count > 0)
                        {
                            int bordcount = (int)dt.Rows[0]["Station1"] + (int)dt.Rows[0]["Station2"] + (int)dt.Rows[0]["Station3"] + (int)dt.Rows[0]["Station4"] + (int)dt.Rows[0]["Station5"] + (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station7"] + (int)dt.Rows[0]["Station8"] + (int)dt.Rows[0]["Station9"] + (int)dt.Rows[0]["Station10"] + (int)dt.Rows[0]["Station11"];
                            if (!Fx5u_mid.ReadM("M2601") && bordcount < 21 && (int)dt.Rows[0]["Station7"] < 1)//不在进板；有进板需求；轨道1空
                            {
                                Fx5u_mid.SetM("M2801", false);
                                Fx5u_mid.SetM("M2601", true);
                                AddMessage("线B内板数:" + bordcount.ToString() + " < 21,申请进板");
                            }
                            if (Fx5u_mid.ReadM("M2801"))
                            {
                                Fx5u_mid.SetM("M2801", false);
                                Fx5u_mid.SetM("M2601", false);
                                stm = "UPDATE BODLINE SET Station9 = Station9 + 1 WHERE LineID = '" + LineID2 + "'";
                                mysql.executeQuery(stm);
                                AddMessage("线B进入1块板");
                            }
                        }
                    }
                    mysql.DisConnect();
                }
                catch (Exception ex)
                {
                    AddMessage(ex.Message);
                }

            }
        }
        private void DockStation1Run()
        {
            int cycle1 = 0, cycle2 = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(500);

                try
                {
                    //A轨道
                    cycle1++;
                    if (cycle1 > 20)
                    {
                        cycle1 = 0;
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID1 + "' ORDER BY SIDATE DESC";
                            DataSet ds = mysql.Select(stm);
                            DataTable dt = ds.Tables["table0"];
                            if (dt.Rows.Count > 0)
                            {
                                //int station7count = (int)dt.Rows[0]["Station7"];
                                if (Fx5u_left2.ReadM("M2810"))//A轨道有料
                                {
                                    int bordcount = (int)dt.Rows[0]["Station2"] + (int)dt.Rows[0]["Station3"] + (int)dt.Rows[0]["Station4"] + (int)dt.Rows[0]["Station5"] + (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station11"];
                                    if (bordcount < 5)//轨道+测试机板数量 < 5 ，下1块板
                                    {
                                        Fx5u_left2.SetM("M2610", true);
                                        AddMessage("线A内接驳台1后板数:" + bordcount.ToString() + " < 5,下1块板");
                                    }
                                }
                                else
                                {
                                    ;//没有存储板，无动作
                                }

                            }
                        }
                        mysql.DisConnect();
                    }
                   
                    if (Fx5u_left2.ReadM("M2798"))//存储响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2798", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station9 = 0 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1存储1块板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2799"))//放新板响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2799", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station9 = 0, Station10 = Station10 + 1 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1放1块新板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2800"))//放存储板响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2800", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 + 1 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1放1块存储板");
                        }
                        mysql.DisConnect();
                    }
                    //B轨道
                    cycle2++;
                    if (cycle2 > 20)
                    {
                        cycle2 = 0;
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID2 + "' ORDER BY SIDATE DESC";
                            DataSet ds = mysql.Select(stm);
                            DataTable dt = ds.Tables["table0"];
                            if (dt.Rows.Count > 0)
                            {
                                //int station7count = (int)dt.Rows[0]["Station7"];
                                if (Fx5u_left2.ReadM("M2811"))//B轨道有料
                                {
                                    int bordcount = (int)dt.Rows[0]["Station2"] + (int)dt.Rows[0]["Station3"] + (int)dt.Rows[0]["Station4"] + (int)dt.Rows[0]["Station5"] + (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station11"];
                                    if (bordcount < 5)//轨道+测试机板数量 < 5 ，下1块板
                                    {
                                        Fx5u_left2.SetM("M2611", true);
                                        AddMessage("线B内接驳台1后板数:" + bordcount.ToString() + " < 5,下1块板");
                                    }
                                }
                                else
                                {
                                    ;//没有存储板，无动作
                                }

                            }
                        }
                        mysql.DisConnect();
                    }
                    
                    if (Fx5u_left2.ReadM("M2804"))//存储响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2804", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station9 = 0 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1存储1块板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2805"))//放新板响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2805", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station9 = 0, Station10 = Station10 + 1 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1放1块新板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2806"))//放存储板响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2806", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 + 1 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台1放1块存储板");
                        }
                        mysql.DisConnect();
                    }
                }
                catch (Exception ex)
                {
                    AddMessage(ex.Message);
                }
            }
        }
        private void DockStation2Run()
        {
            int cycle1 = 0, cycle2 = 0;
            while (true)
            {
                System.Threading.Thread.Sleep(500);
                try
                {
                    //A轨道
                    cycle1++;

                    if (cycle1 > 20)
                    {
                        cycle1 = 0;
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID1 + "' ORDER BY SIDATE DESC";
                            DataSet ds = mysql.Select(stm);
                            DataTable dt = ds.Tables["table0"];
                            if (dt.Rows.Count > 0)
                            {
                                //int station8count = (int)dt.Rows[0]["Station8"];
                                if (Fx5u_left2.ReadM("M2810"))//A轨道有料
                                {
                                    int bordcount = (int)dt.Rows[0]["Station11"] + (int)dt.Rows[0]["Station6"];
                                    if (bordcount < 1)//轨道+测试机板数量 < 1 不存储，放板
                                    {
                                        Fx5u_left2.SetM("M2610", true);
                                        AddMessage("线A内接驳台2后板数:" + bordcount.ToString() + " < 1,下1块板");
                                    }
                                }
                                else
                                {
                                    ;//没有存储板，无动作
                                }

                            }
                        }
                        mysql.DisConnect();
                    }
                    
                    if (Fx5u_left2.ReadM("M2798"))//存储响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2798", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 - 1 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2存储1块板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2799"))//放新板响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2799", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 - 1, Station11 = 1 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2放1块新板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2800"))//放存储板响应【A轨道】
                    {
                        Fx5u_left2.SetM("M2800", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station11 = 1 WHERE LineID = '" + LineID1 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2放1块存储板");
                        }
                        mysql.DisConnect();
                    }
                    //B轨道
                    cycle2++;

                    if (cycle2 > 20)
                    {
                        cycle2 = 0;
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "SELECT * FROM BODLINE WHERE LineID = '" + LineID2 + "' ORDER BY SIDATE DESC";
                            DataSet ds = mysql.Select(stm);
                            DataTable dt = ds.Tables["table0"];
                            if (dt.Rows.Count > 0)
                            {
                                //int station8count = (int)dt.Rows[0]["Station7"];
                                if (Fx5u_left2.ReadM("M2811"))//B轨道有料
                                {
                                    int bordcount = (int)dt.Rows[0]["Station6"] + (int)dt.Rows[0]["Station11"];
                                    if (bordcount < 1)//轨道+测试机板数量 < 1 不存储，放板
                                    {
                                        Fx5u_left2.SetM("M2611", true);
                                        AddMessage("线B内接驳台2后板数:" + bordcount.ToString() + " < 1,下1块板");
                                    }
                                }
                                else
                                {
                                    ;//没有存储板，无动作
                                }

                            }
                        }
                        mysql.DisConnect();
                    }
                    
                    if (Fx5u_left2.ReadM("M2804"))//存储响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2804", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 - 1 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2存储1块板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2805"))//放新板响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2805", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station10 = Station10 - 1, Station11 = 1 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2放1块新板");
                        }
                        mysql.DisConnect();
                    }
                    if (Fx5u_left2.ReadM("M2806"))//放存储板响应【B轨道】
                    {
                        Fx5u_left2.SetM("M2806", false);
                        Mysql mysql = new Mysql();
                        if (mysql.Connect())
                        {
                            string stm = "UPDATE BODLINE SET Station11 = 1 WHERE LineID = '" + LineID2 + "'";
                            mysql.executeQuery(stm);
                            AddMessage("线A接驳台2放1块存储板");
                        }
                        mysql.DisConnect();
                    }
                }
                catch (Exception ex)
                {
                    AddMessage(ex.Message);
                }
            }
        }
        private async void ModelPrintEventProcess(string str)
        {
           
            AddMessage(str);

            #region 样本
            if (str.Contains("StartSample"))
            {
                epsonRC90.SamStart = DateTime.Now;
                Tester.IsInSampleMode = true;
                for (int i = 0; i < 8; i++)
                {
                    for (int j = 0; j < 4; j++)
                    {
                        epsonRC90.sampleContent[i][j] = "Null";
                    }
                }
            }
            if (str.Contains("EndSample"))
            {
                LastSam1 = DateTime.Now;
                Tester.IsInSampleMode = false;
                isSendSamCMD = false;
                Inifile.INIWriteValue(iniParameterPath, "Sample", "LastSam1", LastSam1.ToString());
            }
            if (str.Contains("EndClean"))
            {
                LastClean1 = DateTime.Now;
                isSendCleanCMD = false;
                Inifile.INIWriteValue(iniParameterPath, "Clean", "LastClean1", LastClean1.ToString());
            }
            if (str.Contains("PickNew"))
            {
                TestCountInput += 1;
                Inifile.INIWriteValue(iniParameterPath, "Summary", "TestCountInput", TestCountInput.ToString());
            }
            #endregion
            #region 信息显示
            if (str.Contains("LinkNG"))
            {
                AlarmText = "上传软体异常";
                AlarmGridVisibility = "Visible";
                AddMessage("上传软体异常");
            }
            if (str.Contains("寿命"))
            {
                AlarmText = str;
                AlarmGridVisibility = "Visible";
            }
            #endregion
            #region 良率报警
            if (str.Contains("StatusOfYield"))
            {
                string str1 = "StatusOfYield";
                for (int i = 0; i < 4; i++)
                {
                    if (epsonRC90.YanmadeTester[i].Yield_Nomal >= 95 || epsonRC90.YanmadeTester[i].TestCount_Nomal < 100 + AdminAddNum[i])
                    {
                        str1 += ";1";
                    }
                    else
                    {
                        str1 += ";0";
                        //AdminAddNum[i] = epsonRC90.YanmadeTester[i].TestCount_Nomal - 100 + (int)(epsonRC90.YanmadeTester[i].TestCount_Nomal * 0.1);
                    }
                }
                if (str1.Contains("0"))
                {
                    ShowYieldAdminControlWindow = !ShowYieldAdminControlWindow;
                }
                if (epsonRC90.TestSendStatus)
                {
                    await epsonRC90.TestSentNet.SendAsync(str);
                }
            }
            #endregion
        }
        private string GetPassWord()
        {
            int day = System.DateTime.Now.Day;
            int month = System.DateTime.Now.Month;
            string ss = (day + month).ToString();
            string passwordstr = "";
            for (int i = 0; i < 4 - ss.Length; i++)
            {
                passwordstr += "0";
            }
            passwordstr += ss;
            return passwordstr;
        }
        private string GetSampleTimeString(string string1,string defaultstring)
        {
            try
            {
                Convert.ToDateTime(string1);
                return string1;
            }
            catch (Exception ex)
            {
                AddMessage(ex.Message);
                return defaultstring;
            }
        }
        void RunLog(string str)
        {
            try
            {
                string tempSaveFilee5 = System.AppDomain.CurrentDomain.BaseDirectory + @"RunLog";
                DateTime dtim = DateTime.Now;
                string DateNow = dtim.ToString("yyyy/MM/dd");
                string TimeNow = dtim.ToString("HH:mm:ss");

                if (!Directory.Exists(tempSaveFilee5))
                {
                    Directory.CreateDirectory(tempSaveFilee5);  //创建目录 
                }

                if (File.Exists(tempSaveFilee5 + "\\" + DateNow.Replace("/", "") + ".txt"))
                {
                    //第一种方法：
                    FileStream fs = new FileStream(tempSaveFilee5 + "\\" + DateNow.Replace("/", "") + ".txt", FileMode.Append);
                    StreamWriter sw = new StreamWriter(fs);
                    sw.WriteLine("TTIME：" + TimeNow + " 执行事件：" + str);
                    sw.Dispose();
                    fs.Dispose();
                    sw.Close();
                    fs.Close();
                }
                else
                {
                    //不存在就新建一个文本文件,并写入一些内容 
                    StreamWriter sw;
                    sw = File.CreateText(tempSaveFilee5 + "\\" + DateNow.Replace("/", "") + ".txt");
                    sw.WriteLine("TTIME：" + TimeNow + " 执行事件：" + str);
                    sw.Dispose();
                    sw.Close();
                }
            }
            catch { }
        }
        #endregion

    }
}
