using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MvcApp_SignalR.Hubs
{
    public class Notification
    {
        //---le typed e notification
        public NotificationType Type { get; set; }

        //---en millesecond , duree pendant laquelle la notification est affichée
        public int Duration { get; set; }

        //le texte de la notification
        public string Text { get; set; }
    }

    public enum NotificationType
    {
        Alert=0,
        Notice=1,
        Greeting=2,
        HotNews=3
    }
}
