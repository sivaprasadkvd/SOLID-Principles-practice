using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

// dependecy inversion principle states that high level class must not depend on low level class.

namespace solid_principles_practice
{

    /*
    public class DataAccessLayer   // high-level-class
    {
        public void addCustomer(string name)
        {
            //add customer to the database
            Filelogger logger = new Filelogger();   // low - level - class
            logger.Log("customer added: " + name)
        }

    }

    */

    public interface Ilogger
    {
        void log(string message);
    }

    public class FileLogger : Ilogger
    {
        public void log(string message) 
        {
            // write message to log file
            Console.WriteLine("siva prasad");
        }
    }


    public class DataAccessLayer()             
    {
        private Ilogger logger;

        public DataAccessLayer(Ilogger loger)        // here , low level class is injected to highlevel class in constructor.
        {
            this.logger = loger;
        }

        public void AddCustomer(String name)
        {
            //add customer to the database
            logger.Log("customer added: " + name)
        }
    }

}
