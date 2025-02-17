﻿using Microsoft.Toolkit.Uwp.Notifications;

namespace EnvyUpdate
{
    internal class Notify
    {
        public static void ShowDrivUpdatePopup()
        {
            var toast = new ToastContentBuilder();
            toast.AddText(Properties.Resources.update_popup_message);
            toast.AddButton(new ToastButton()
                .SetContent("Download")
                .AddArgument("action", "download"));
            toast.Show();
        }
    }
}