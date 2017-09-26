using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

using log4net;
using log4net.Config;

namespace TemperatureMonitor
{
    public class FileDataReader
    {
        private static readonly ILog logger = LogManager.GetLogger(typeof(FileDataReader));

        private DateTime date;
        private double tw = 0, mc = 0, t1 = 0, t2 = 0, tn = 0, en = 0, e1 = 0, e2 = 0;
        private int phase;

        public double TemperatureWood { get { return tw; } set { tw = value; } }
        //public double TemperatureAir { get { return ta; } set { ta = value; } }
        public double T1 { get { return t1; } set { t1 = value; } }
        public double T2 { get { return t2; } set { t2 = value; } }
        public double TN { get { return tn; } set { tn = value; } }
        public double MC { get { return mc; } set { mc = value; } }
        public double EN { get { return en; } set { en = value; } }
        public double E1 { get { return e1; } set { e1 = value; } }
        public double E2 { get { return e2; } set { e2 = value; } }
        public int PHASE { get { return phase; } 
        set
        {             
            phase = value; 
        } 
        }
        public DateTime DateTime { get { return date; } set { date = value; } }

        // writes the data to a file
        public void writeDataToFile(String fileName)
        {
            logger.Debug("Entering writeDataToFile, fileName: " + fileName );
            try
            {               
                StreamWriter writer = new StreamWriter(fileName, true);
                writer.WriteLine(this.ToString());
                writer.Close();
            }
            catch( Exception ex )
            {
                logger.Error("Exception writing to file: " + ex.Message );
            }

            logger.Debug("Exiting writeDataToFile, fileName: " + fileName );
        }

        public override String ToString()
        {
            return date + "," + date.Ticks + "," + tw + "," + t1 + "," + t2 + "," + tn + "," + e1 + "," + e2 + "," + en + "," + mc + "," + phase;
        }

        // reads data from the input string
        public void readDataFromFile(String data)
        {
            try
            {
                string[] items = data.Trim().Split(',');

                if (items.Length > 1)
                {
                    long dateTicks = Convert.ToInt64(items[0]);
                    date = new DateTime(dateTicks);
                    tw = Convert.ToDouble(items[2]);
                    t1 = Convert.ToDouble(items[3]);
                    t2 = Convert.ToDouble(items[4]);
                    tn = Convert.ToDouble(items[5]);
                    e1 = Convert.ToDouble(items[6]);
                    e2 = Convert.ToDouble(items[7]);
                    en = Convert.ToDouble(items[8]);
                    mc = Convert.ToDouble(items[9]);
                    phase = Convert.ToInt16(items[10].Substring(0, 1));
                }
            }
            catch( Exception ex )
            {
                logger.Error("Exception reading data: " + ex.Message);
            }
        }
    }
}
