using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Socket_XML_Send_Receive
{
    public class RequestReceiver
    {
        public string ConvertBytesToString(byte[] stringbytes, Encoding encoding, bool shouldAddMessageLength)
        {
           
                if (shouldAddMessageLength)
                {
                    string text = encoding.GetString(stringbytes, 0, (stringbytes.Length - 4));
                    return text;
                }
                else
                {
                    string text = encoding.GetString(stringbytes, 0, stringbytes.Length);
                    return text;
                }
            

        }

       
        
    }
}
