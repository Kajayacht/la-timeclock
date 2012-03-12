using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Los_Alamos_Timeclock
{
    /** The class to handle all logfile writing, viewing, reading, ect
     * @author  Andrew DePersio
     *
     */

    class Log
    {
        //create file (if not exist)
        public static void createLog()
        {
            string filepath = Directory.GetCurrentDirectory() + "/log.txt";
            if (File.Exists(filepath) == false)
            {
                StreamWriter w = new StreamWriter(Directory.GetCurrentDirectory() + "/log.txt");
                // Update the underlying file.
                w.Flush();
                // Close the writer and underlying file.
                w.Close();
            }
        }

        //write to file        
        public static void writeLog(String logMessage)
        {
            try
            {
                //open the file
                
                StreamWriter w = File.AppendText(Directory.GetCurrentDirectory()+ "/log.txt");
                
                //write the header, date/time, and the logmessage
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", logMessage);
                w.WriteLine("-------------------------------");
                // Update the underlying file.
                w.Flush();
                // Close the writer and underlying file.
                w.Close();
            }
            catch (System.UnauthorizedAccessException)
            {
                Main.maininstance.error("Log access denied: Run as Administrator");
            }
        }

        //read file, work in progress
        public static string viewLog()
        {
            try
            {
                // Create an instance of StreamReader to read from a file.
                // The using statement also closes the StreamReader.
                using (StreamReader r = new StreamReader(Directory.GetCurrentDirectory() + "/log.txt"))
                {
                    
                    //Create a string from the text file and return it
                    String line = r.ReadToEnd();
                    r.Close();
                    return line;
                }
            }

            catch
            {
                // Let the user know what went wrong.

                return "The file could not be read:";
            }
            
        }

        //clear log file? work in progress, although not much work has been done
        public static void clearLog()
        {

        }

    }
}
