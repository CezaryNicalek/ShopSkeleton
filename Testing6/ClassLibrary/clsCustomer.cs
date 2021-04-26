using System;

namespace ClassLibrary
{
    public class clsCustomer
    {
        
        public int CustomerNo {
            get
            {
                return mCustomerNo;
            }
            set
            {
                mCustomerNo = value;
            }

        }
        public string Name {
            get
            {
                return mName;
            }

            set
            {
                mName = value;
            }

        }
        public string Surname {
            get
            {
                return mSurname;
            }

            set
            {
                mSurname = value;
            }

        }
        public string Address { get
            {
                return mAddress;
            }

            set
            {
                mAddress = value;
            }
        }
        public string Mail {
            get
            {
                return mMail;
            }

            set
            {
                mMail = value;
            }

        }
        //public property for active
        public bool Active
        {
            get
            {
                //return the private data
                return mActive;
            }
            set
            {
                //set the private data
                mActive = value;
            }
        }


       

        private int mCustomerNo;
        //private data member for active
        private Boolean mActive;
        private string mSurname;
        private string mName;
        private string mMail;
        private string mAddress; 



        public bool Find(int CustomerNo)
        {//ereate an instance of the data connection
            clsDataConnection DB = new clsDataConnection();
            //add the parameter for the address no to search for
            DB.AddParameter("@CustomerNo", CustomerNo);
            //execute the stored procedure
            DB.Execute("sproc_tblCustomer_FilterByCustomerNo");
            // if one record is found (there should be either one or zero!)
            if (DB.Count == 1)
            {
                //copy the data from the database to the private data members
                mCustomerNo = Convert.ToInt32(DB.DataTable.Rows[0]["CustomerNo"]);
                mName = Convert.ToString(DB.DataTable.Rows[0]["Name"]);
                mSurname = Convert.ToString(DB.DataTable.Rows[0]["Surname"]);
                mMail = Convert.ToString(DB.DataTable.Rows[0]["Mail"]);
                mActive = Convert.ToBoolean(DB.DataTable.Rows[0]["Active"]);
                //return that everything worked OK
                return true;
            }
            //if no record was found
            else
            {
            // return false indicating a problem
            return false;
            }
        }

        public string Valid(int CustomerNo, string Name, string Surname, string Mail, string Address, Boolean Active)
        {
            //create a string variable to store the error
            String Error = "";
            // if customer number is equal to 0   
            if (CustomerNo == 0 )
            {
                Error = Error + "Customer number cannot equal 0 ";
            }

            
            //if customer number is bigger than max value 
            if(CustomerNo > 2147483647)

            {
                Error = Error + "Customer number cannot be bigger than 2147483647";
            }
            //if name is blank 
            if (Name == "")
            {
                Error = Error + "Name cannot be empty"; 
            }
            //if name is too long
            if (Name.Length > 50)
            {
                Error = Error + "Name cannot be longer than 50 characters";
            }
            
            //if surname is blank
            if(Surname.Length == 0)
            {
                Error = Error + "Surname cannot be empty";
            }
            //if surname is too long
            if (Surname.Length > 50)
            {
                Error = Error + "Surname cannot be longer than 50 characters";
            }
            //if mail is blank 
            if(Mail.Length==0 )
            {
                Error = Error + "Mail cannot be empty";
            }

            //if mail is too long
            if(Mail.Length >50)
            {
                Error = Error + "Mail cannot be longer than 50 characters";
            }
            //if address is blank
            if(Address.Length == 0)
            {
                Error = Error + "Address cannot be empty";
            }
            //if address is too long
            if(Address.Length>50 )
            {
                Error = Error + "Address cannot be longer than 50 characters";
            
            }

            return Error;
        }


    }
}