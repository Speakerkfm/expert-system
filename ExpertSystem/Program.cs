using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using ExpertSystem.store;
using ExpertSystem.model;
using ExpertSystem.service;

namespace ExpertSystem
{
    class DataContainer
    {
        private Store st;
        private model.CurrentExpertSystem expertSystem;

        public Store Store => st;
        public model.CurrentExpertSystem ExpertSystem
        {
            get { return expertSystem; }
            set { expertSystem = value; }
        }

        public DataContainer(Store st, model.CurrentExpertSystem expertSystem)
        {
            this.st = st;
            this.expertSystem = expertSystem;
        }
    }

    static class Program
    {
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);

            //mysql
            string host = "127.0.0.1";
            int port = 3306;
            string database = "expert-system";
            string username = "root";
            string password = "root";
            Store st = new Store(host, port, database, username, password);

            DataContainer dataContainer = new DataContainer(st, null);

            //services
            ExpertSystemService expertSystemService = new ExpertSystemService(dataContainer);

            //forms
            ExpertSystemCreator expertSystemCreator = new ExpertSystemCreator(expertSystemService);
            MainForm mainForm = new MainForm(dataContainer, expertSystemCreator);

            Application.Run(mainForm);

            st.CloseConnection();
        }
    }
}
