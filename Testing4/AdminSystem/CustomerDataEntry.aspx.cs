using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_DataEntry : System.Web.UI.Page
{

    Int32 CustomerNo;

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnOk_Click(object sender, EventArgs e)
    {
        //create new instance of customer class
        clsCustomer AnCustomer = new clsCustomer();
        //capture the name 
        string Name = txtCName.Text;
        int CustomerNo = int.Parse(txtCustomerNo.Text);
        string Surname = txtCSurname.Text;
        string Mail = txtCMail.Text;
        string Address = txtCAddress.Text;
        string Error = "";
        Boolean Active = true;
        Error = AnCustomer.Valid(CustomerNo, Name, Surname, Mail, Address, Active);
        
        if (Error == "")
        {
            AnCustomer.CustomerNo = CustomerNo;
            AnCustomer.Name = Name;
            AnCustomer.Surname = Surname;
            AnCustomer.Mail = Mail;
            AnCustomer.Address = Address;
            AnCustomer.Active = chkActive.Checked;

            clsCustomerCollection CustomerList = new clsCustomerCollection();

            if (CustomerNo == -1)
            {

                CustomerList.ThisCustomer = AnCustomer;

                CustomerList.Add();

            }
            else
            {
                CustomerList.ThisCustomer.Find(CustomerNo);

                CustomerList.ThisCustomer = AnCustomer;


                CustomerList.Update();
            }

           
            Response.Redirect("CustomerList.aspx");


        }
        else
        {
            lblError.Text = Error;
        }
        
    }

    protected void btnFind_Click(object sender, EventArgs e)
    {
        //create an instance of the address class
        clsCustomer AnCustomer = new clsCustomer();
        //variable to store the primary key
        Int32 CustomerNo;
          // variable to store the result of the find operation
          Boolean Found = false;
            //get the primary key entered by the user
            CustomerNo = Convert.ToInt32(txtCustomerNo.Text);
            //ind the record
            Found = AnCustomer.Find(CustomerNo);
            //if found
            if (Found == true)
            {
            //display the values of the properties in the form
            txtCustomerNo.Text = AnCustomer.CustomerNo.ToString();
            txtCName.Text = AnCustomer.Name;
                txtCSurname.Text = AnCustomer.Surname;
                txtCMail.Text = AnCustomer.Mail;
                txtCAddress.Text = AnCustomer.Address;
            
                
            }
    }

    private void DisplayCustomer()
    {
        clsCustomerCollection CustomerBook = new clsCustomerCollection();

        CustomerBook.ThisCustomer.Find(CustomerNo);

        txtCustomerNo.Text = CustomerBook.ThisCustomer.CustomerNo.ToString();
        txtCName.Text = CustomerBook.ThisCustomer.Name;
        txtCSurname.Text = CustomerBook.ThisCustomer.Surname;
        txtCMail.Text = CustomerBook.ThisCustomer.Mail;
        txtCAddress.Text = CustomerBook.ThisCustomer.Address;
        chkActive.Checked = CustomerBook.ThisCustomer.Active;



    }


}
