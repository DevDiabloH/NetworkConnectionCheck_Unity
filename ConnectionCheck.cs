using System.Net;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public static class ConnectionCheck
{
    public static bool IsConnected()
    {
        string somestring = string.Empty;

        try
        {
            WebClient wc = new WebClientWithTimeout();
            somestring = wc.DownloadString("http://www.msftncsi.com/ncsi.txt");

            if (somestring == "Microsoft NCSI")
            {
                return true;
            }
            else
            {
                return false;
            }

        }
        catch (WebException we)
        {
            return false;
        }
    }
}
