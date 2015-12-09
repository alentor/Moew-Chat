﻿namespace MeowChatClientLibrary
{
    public delegate void FrmLoginCloseHandler();

    public delegate void TabPagePrivateChatSendClietHandler(string clientName, string message);

    public delegate void TabPagePrivateChatReceiveClientHandler(string tabName, string privateName, string message, int caseId);

    public delegate void FrmStatisticsUpdateHandler(StatisticsEntry staticsEntry);
}