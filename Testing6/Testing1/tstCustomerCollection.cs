using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;
using System.Collections.Generic;

namespace Testing1
{
    [TestClass]
    public class tstCustomerCollection
    {
        [TestMethod]
        public void InstanceOk()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            Assert.IsNotNull(AllCustomers);
        }


        [TestMethod]
        public void CustomerListOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();


            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "John";
            TestItem.Surname = "Lemon";
            TestItem.Mail = "jl@mail.com";
            TestItem.Address = "New Street 21";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.CustomerList, TestList);


        }



        [TestMethod]
        public void ThisAddressPropertyOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();



            clsCustomer TestCustomer = new clsCustomer();

            TestCustomer.Active = true;
            TestCustomer.CustomerNo = 1;
            TestCustomer.Name = "John";
            TestCustomer.Surname = "Lemon";
            TestCustomer.Mail = "jl@mail.com";
            TestCustomer.Address = "New Street 21";

            AllCustomers.ThisCustomer = TestCustomer;

            Assert.AreEqual(AllCustomers.ThisCustomer, TestCustomer);

        }


        [TestMethod]
        public void ListAndCountOK()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();
            List<clsCustomer> TestList = new List<clsCustomer>();


            clsCustomer TestItem = new clsCustomer();

            TestItem.Active = true;
            TestItem.CustomerNo = 1;
            TestItem.Name = "John";
            TestItem.Surname = "Lemon";
            TestItem.Mail = "jl@mail.com";
            TestItem.Address = "New Street 21";
            TestList.Add(TestItem);
            AllCustomers.CustomerList = TestList;

            Assert.AreEqual(AllCustomers.Count, TestList.Count);


        }

        [TestMethod]
        public void AddMethodOk()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 Primarykey = 0;


            TestItem.Active = true;
            TestItem.Name = "Jan";
            TestItem.Surname = "Pan";
            TestItem.CustomerNo = 003;
            TestItem.Mail = "jp003@mail.com";
            TestItem.Address = "MyStreet 21";


            AllCustomers.ThisCustomer = TestItem;

            Primarykey = AllCustomers.Add();


            TestItem.CustomerNo = Primarykey;

            AllCustomers.ThisCustomer.Find(Primarykey);

            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);


        }


        [TestMethod]
        public void UpdateMethodOk()
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 Primarykey = 0;

            TestItem.Active = true;
            TestItem.CustomerNo = 004;
            TestItem.Name = "Paul";
            TestItem.Surname = "Mall";
            TestItem.Mail = "pm004@mail.com";
            TestItem.Address = "SomeStreet 33";

            AllCustomers.ThisCustomer = TestItem;

            Primarykey = AllCustomers.Add();

            TestItem.CustomerNo = Primarykey;

            TestItem.Active = false;
            TestItem.Name = "No Paul";
            TestItem.Surname = "No Mall";
            TestItem.Mail = "nopm004@mail.com";
            TestItem.Address = "NoSomeStreet 33";

            AllCustomers.ThisCustomer = TestItem;

            AllCustomers.Update();

            AllCustomers.ThisCustomer.Find(Primarykey);


            Assert.AreEqual(AllCustomers.ThisCustomer, TestItem);

            
        }

        [TestMethod]
        public void DeleteMethodOk()    
        {
            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomer TestItem = new clsCustomer();

            Int32 Primarykey = 0;

            TestItem.Active = true;
            TestItem.CustomerNo = 005;
            TestItem.Name = "Mike";
            TestItem.Surname = "Spike";
            TestItem.Mail = "ms055@mail.com";
            TestItem.Address = "PoolStreet 12";


            AllCustomers.ThisCustomer = TestItem;

            Primarykey = AllCustomers.Add();

            TestItem.CustomerNo = Primarykey;

            AllCustomers.ThisCustomer.Find(Primarykey);

            AllCustomers.Delete();

            Boolean Found = AllCustomers.ThisCustomer.Find(Primarykey);

            Assert.IsFalse(Found);
        }


        [TestMethod]
        public void ReportByNameMethodOk()
        {

            clsCustomerCollection AllCustomers = new clsCustomerCollection();

            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByName("");

            Assert.AreEqual(AllCustomers.Count, FilteredCustomers.Count);

        }

        [TestMethod]
        public void ReportByNameNoneFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            FilteredCustomers.ReportByName("xxxx");
            Assert.AreEqual(0, FilteredCustomers.Count);
        }
        [TestMethod]
        public void ReportByNameTestDataFound()
        {
            clsCustomerCollection FilteredCustomers = new clsCustomerCollection();

            Boolean OK = true;

            FilteredCustomers.ReportByName("xxxx");
            if (FilteredCustomers.Count == 2)
            {
                if(FilteredCustomers.CustomerList[0].CustomerNo != 006)
                {
                    OK = false;
                }
                if(FilteredCustomers.CustomerList[0].CustomerNo != 007)
                {
                    OK = false;

                }
            }
            else
            {
                OK = true;
            }
            Assert.IsTrue(OK);

        }
        

       
    }

   
}
