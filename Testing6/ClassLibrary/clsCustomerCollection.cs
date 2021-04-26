using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ClassLibrary
{
    public class clsCustomerCollection
    {


        List<clsCustomer> mCustomerList = new List<clsCustomer>();

        clsCustomer mThisCustomer = new clsCustomer();

        public List<clsCustomer> CustomerList
        {
            get
            {
                return mCustomerList;


            }

            set
            {
                mCustomerList = value;
            }

        }
        public int Count
        {
            get
            {
                return mCustomerList.Count;
            }
            set
            {

            }
        }
        public clsCustomer ThisCustomer {
            get
            {
                return mThisCustomer;
            }



            set
            {
                mThisCustomer = value;

            }

        }

        public clsCustomerCollection()
        {
           

            clsDataConnection DB = new clsDataConnection();

            DB.Execute("sproc_tblCustomer_SelectAll");

            PopulateArray(DB);

            


        }
        public int Add()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Mail", mThisCustomer.Mail);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Active", mThisCustomer.Active);

            return DB.Execute("sproc_tblCustomer_Insert");
        }

        public void Update()
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.AddParameter("@Name", mThisCustomer.Name);
            DB.AddParameter("@Surname", mThisCustomer.Surname);
            DB.AddParameter("@Mail", mThisCustomer.Mail);
            DB.AddParameter("@Address", mThisCustomer.Address);
            DB.AddParameter("@Active", mThisCustomer.Active);

            DB.Execute("sproc_tblCustomer_Update");

        }

        public void Delete()
        {
            clsDataConnection DB = new clsDataConnection();

            DB.AddParameter("@CustomerNo", mThisCustomer.CustomerNo);
            DB.Execute("sproc_tblCusotmer_Delete");

        }

        public void ReportByName(string Name)
        {
            clsDataConnection DB = new clsDataConnection();
            DB.AddParameter("@Name", Name);
            DB.Execute("sproc_tblCustomer_FilterByName");
            PopulateArray(DB;)

        }
        void PopulateArray(clsDataConnection DB)
        {
            Int32 Index = 0;

            int RecordCount = 0;

            

            DB.Execute("sproc_tblCustomer_SelectAll");

            RecordCount = DB.Count;

            while (Index < RecordCount)
            {

                clsCustomer AnCustomer = new clsCustomer();
                //copy the data from the database to the private data members


                AnCustomer.CustomerNo = Convert.ToInt32(DB.DataTable.Rows[Index]["CustomerNo"]);
                AnCustomer.Name = Convert.ToString(DB.DataTable.Rows[Index]["Name"]);
                AnCustomer.Surname = Convert.ToString(DB.DataTable.Rows[Index]["Surname"]);
                AnCustomer.Mail = Convert.ToString(DB.DataTable.Rows[Index]["Mail"]);
                AnCustomer.Active = Convert.ToBoolean(DB.DataTable.Rows[Index]["Active"]);

                mCustomerList.Add(AnCustomer);

                Index++;
            }
        }
    }
}
