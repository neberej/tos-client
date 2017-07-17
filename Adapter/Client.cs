using Microsoft.Win32;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Diagnostics;

namespace Adapter
{

    public class Client
    {

        public static Double getQuotes(RtdClient client, string topic, string symbol)
        {
            object value;
            if (client.GetValue(TimeSpan.FromSeconds(3), out value, topic, symbol))
            {
                try
                {
                    return double.Parse(value.ToString());
                }
                catch
                {
                    return 0;
                }
            }
            return 0;
        }
    }
}
