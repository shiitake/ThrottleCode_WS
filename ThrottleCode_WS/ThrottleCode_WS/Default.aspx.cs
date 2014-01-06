using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

namespace ThrottleCode_WS
{
    public partial class Default : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            try
            {
                clearFields();
                throttleMode.Text = calcMode(Convert.ToInt32(reason.Text));
                int myLoops;
                string resType;
                string throtType;
                calcResource(Convert.ToInt32(reason.Text), out myLoops, out resType);
                typeFunction(myLoops, Convert.ToInt32(reason.Text), out throtType);                
                //resourceType.Text = typeFunction(Convert.ToInt32(reason.Text));
                throttleType.Text = throtType;
                resourceType.Text = resType;
            }
            catch (ArithmeticException z)
            {
                throttleMode.Text = "see below";
                throttleType.Text = "see below";
                resourceType.Text = "see below";
                errorBox.Text = "Error: " + z.Message + "\r\nPlease verify that you are using a valid reason code and try your request again.";
            }      
                
        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            clearFields();
            reason.Text = "";
        }

        static public string calcMode(int mode)
        {
            switch (mode % 4)
            {
                case 0: return "No throttling";
                case 1: return "Reject Updates and Inserts";
                case 2: return "Reject All Writes";
                case 3: return "Reject All Reads and Writes";
                default: return "Unknown.";
            }
        }
        
        static public void calcResource(int reasonCode, out int myLoops, out string resType)
        {
        myLoops = 0;
        int holderCode = (reasonCode / 256);
            //determine loops value            
                do{
                    if(holderCode == 0)
                    {
                        myLoops = -1;
                        resType = "(see below)";
                        throw new ArithmeticException();                        
                    }
                    else if (holderCode % 2 > 0)
                    {
                        holderCode = -1;
                    }
                    else{
                        myLoops++;
                        holderCode /= 2;
                    }
                }
                while (holderCode > -1);
            
           //resource type calculation
            switch(Convert.ToInt32(myLoops/2))
            {
                case 0: resType = "Physical Database Space"; break;
                case 1: resType = "Physical Log Space"; break;
                case 2: resType = "LogWriteIODelay"; break;
                case 3: resType = "DataReadIODelay"; break;
                case 4: resType = "CPU"; break;
                case 5: resType = "Database Size"; break;
                case 6: resType = "Internal"; break;
                case 7: resType = "SQL Worker Threads"; break;
                case 8: resType = "Internal"; break;
                default: resType = "Resource Type is unknown."; break;
            }
            myLoops++;
            return;
            }
           
        static public void typeFunction(int myLoops, int mode, out string throtType)
        {
            if (myLoops == -1)
            {
                throtType = "(see below)";
            }
            else if (myLoops % 2 == 0 && mode > 0)
            {
                throtType = "Hard Throttle";
            }
            else if (mode > 0)
            {
                throtType = "Soft Throttle";
            }
            else
            {
                throtType = "No Throttling";
            }
            return;
            }

        public void clearFields()
        {
            throttleMode.Text = "";
            throttleType.Text = "";
            resourceType.Text = "";
            errorBox.Text = "";
            return;
        }

    }
}