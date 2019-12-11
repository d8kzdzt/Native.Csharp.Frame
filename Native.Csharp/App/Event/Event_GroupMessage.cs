using System;
using System.Collections.Generic;
using System.Text;
using Native.Csharp.Sdk.Cqp.EventArgs;
using Native.Csharp.Sdk.Cqp.Interface;

namespace Native.Csharp.App.Event
{
    public class Event_GroupMessage : IReceiveGroupMessage
    {
        public void ReceiveGroupMessage(object sender, CqGroupMessageEventArgs e)
        {
            if (e.Message.StartsWith("!SDK测试"))
            {
                Common.CqApi.SendGroupMessage(e.FromGroup, "测试回文");
            }
        }
    }
}
