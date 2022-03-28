using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Diagnostics;
using System.ServiceProcess;
using System.Text;

namespace SampleWinService
{
    public partial class Service1 : ServiceBase
    {
        public Service1()
        {
            InitializeComponent();
        }

        protected override void OnStart(string[] args)
        {
            base.OnStart(args);
            /* ここにサービス開始時の処理を記述する */
        }

        protected override void OnStop()
        {
            base.OnStop();
            /* ここにサービス停止時の処理を記述する */
        }
    }
}
