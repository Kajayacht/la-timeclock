using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.IO;

namespace Los_Alamos_Timeclock
{

        /*
    This program is free software: you can redistribute it and/or modify
    it under the terms of the GNU General Public License as published by
    the Free Software Foundation, either version 3 of the License, or
    (at your option) any later version.

    This program is distributed in the hope that it will be useful,
    but WITHOUT ANY WARRANTY; without even the implied warranty of
    MERCHANTABILITY or FITNESS FOR A PARTICULAR PURPOSE.  See the
    GNU General Public License for more details.

    You should have received a copy of the GNU General Public License
    along with this program.  If not, see <http://www.gnu.org/licenses/>.
     */



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

        /* Write a message to the logfile
         * 
         * @author Andrew DePersio
         * @param logMessage        The message to be written
         */
        public static void writeLog(String logMessage)
        {
            //Get the previous log so we can prepend to it
            String previousLog = viewLog();
            //Prepare the message to be written
            String entry = "\r\nLog Entry : " + DateTime.Now.ToLongTimeString() + " " + DateTime.Now.ToLongDateString() + "\r\n:\r\n: " + logMessage + "\r\n -------------------------------";
            String log = entry + previousLog;
            //delete the old log file
            File.Delete(Directory.GetCurrentDirectory() + "/log.txt");

            try
            {
                //open the file
                
                StreamWriter w = File.AppendText(Directory.GetCurrentDirectory()+ "/log.txt");
                
                /*write the header, date/time, and the logmessage
                w.Write("\r\nLog Entry : ");
                w.WriteLine("{0} {1}", DateTime.Now.ToLongTimeString(),
                    DateTime.Now.ToLongDateString());
                w.WriteLine("  :");
                w.WriteLine("  :{0}", logMessage);
                w.WriteLine("-------------------------------");
                 */
                w.Write(log);
                // Update the underlying file.
                w.Flush();
                // Close the writer and underlying file.
                w.Close();
            }
            //Catch error if the log is inaccesible 
            catch (System.UnauthorizedAccessException)
            {
                Main.maininstance.error("Log access denied: Run as Administrator");
            }
        }

        /* Method to return a string of the log
         * 
         * @author Andrew DePersio
         * @return string line      The contents of the logfile
         */
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

        //Delete the log file
        public static void clearLog()
        {
            File.Delete(Directory.GetCurrentDirectory() + "/log.txt");
        }

    }
}
