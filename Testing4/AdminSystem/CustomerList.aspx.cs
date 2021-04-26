using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using ClassLibrary;

public partial class _1_List : System.Web.UI.Page
{

    Int32 CustomerNo;
    
     

    void DisplayCustomers()
    {

        clsCustomerCollection Customers = new clsCustomerCollection();

        lstCustomers.DataSource = Customers.CustomerList;

        lstCustomers.DataValueField = "CustomerNo";

        lstCustomers.DataTextField = "Surname";

        lstCustomers.DataBind();

    }
    protected void ListBox1_SelectedIndexChanged(object sender, EventArgs e)
    {

    }

    protected void btnAdd_Click(object sender, EventArgs e)
    {
        Session["CustomerNo"] = CustomerNo;
            
        Response.Redirect("AnCustomer.aspx");
    }

    protected void btnEdit_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;

        if(lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);

            Session["CustomerNo"] = CustomerNo;

            Response.Redirect("AnCustomer.aspx");


        }
        else
        {
            lblError.Text = "Please select an record to delete from the list";
        }
    }

    protected void btnDelete_Click(object sender, EventArgs e)
    {
        Int32 CustomerNo;
        if (lstCustomers.SelectedIndex != -1)
        {
            CustomerNo = Convert.ToInt32(lstCustomers.SelectedValue);

            Session["CustomerNo"] = CustomerNo;

            Response.Redirect("DeleteCustomer.aspx");


        }
        else
        {
            lblError.Text = "Please select an record to delete from the list";
        }

    }

    protected void Page_Load(object sender, EventArgs e)
    {

    }

    protected void btnApply_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName(txtFilter.Text);
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();

    }

    protected void btnClear_Click(object sender, EventArgs e)
    {
        clsCustomerCollection Customers = new clsCustomerCollection();
        Customers.ReportByName("");
        txtFilter.Text = "";
            
        lstCustomers.DataSource = Customers.CustomerList;
        lstCustomers.DataValueField = "CustomerNo";
        lstCustomers.DataTextField = "Name";
        lstCustomers.DataBind();
    }
}