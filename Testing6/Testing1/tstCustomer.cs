using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ClassLibrary;

namespace TestingCustomer
{
    [TestClass]
    public class tstAddress
    {
        int CustomerNo = 001;
        string Name = "John";
        string Surname = "Cook";
        string Mail = "JC001@mail.com";
        string Address = "32 NewStreer, Leicester";

        public bool Active { get; private set; }

        [TestMethod]
        public void InstanceOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //test to see that it exists
            Assert.IsNotNull(AnCustomer);
        }

        [TestMethod]
        public void ActivePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            Boolean TestData = true;
            //assign the data to the property
            AnCustomer.Active = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Active, TestData);
        }

        [TestMethod]
        public void CustomerNoPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            int TestData = 1;
            //assign the data to the property
            AnCustomer.CustomerNo = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.CustomerNo, TestData);
        }


        [TestMethod]
        public void NamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "John";
            //assign the data to the property
            AnCustomer.Name = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Name, TestData);
        }

        [TestMethod]
        public void SurnamePropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "Cook";
            //assign the data to the property
            AnCustomer.Surname = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Surname, TestData);
        }

        [TestMethod]
        public void AddressPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "32 NewStreet, Leicester";
            //assign the data to the property
            AnCustomer.Address = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Address, TestData);
        }

        [TestMethod]
        public void MailPropertyOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //create some test data to assign to the property
            string TestData = "jc001@gmail.com";
            //assign the data to the property
            AnCustomer.Mail = TestData;
            //test to see that the two values are the same
            Assert.AreEqual(AnCustomer.Mail, TestData);
        }

        [TestMethod]
        public void FindMethodOK()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the validation
            Boolean Found = false;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //test to see that the result is correct
            Assert.IsTrue(Found);
        }




        [TestMethod]
        public void TestCustomerNoFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the address no
            if (AnCustomer.CustomerNo != 21)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }

        [TestMethod]
        public void TestSurnameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Surname != "Test Surname")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestNameFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Name != "Test Name")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestMailFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Mail != "Test Mail")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestAddressFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Address != "Test Address")
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);
        }


        [TestMethod]
        public void TestActiveFound()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //boolean variable to store the result of the search
            Boolean Found = false;
            //boolean variable to record if data is OK (assume it is)
            Boolean OK = true;
            //create some test data to use with the method
            int CustomerNo = 21;
            //invoke the method
            Found = AnCustomer.Find(CustomerNo);
            //check the property
            if (AnCustomer.Active != true)
            {
                OK = false;
            }
            //test to see that the result is correct
            Assert.IsTrue(OK);

        }


        [TestMethod]

        public void ValidMethodOK()
        {
            //create instance of method we want to create

            clsCustomer AnCustomer = new clsCustomer();
            //string to store error message
            string Error = "";
            //invoke the method
            Error = AnCustomer.Valid(CustomerNo, Name, Surname, Mail, Address, Active);
            //test method
            Assert.AreEqual(Error , "");
         
        }


        [TestMethod]

        public void HouseNoMin()
        {
            //create an instance of the class we want to create
            clsCustomer AnCustomer = new clsCustomer();
            //string variable to store any error message
            String Error = "";
            //create some test data to pass to the method
            int CustomerNo = 0; //this should be ok
            //invoke the method
            Error = AnCustomer.Valid(CustomerNo, Name, Surname, Mail, Address, Active);
            //test to see that the result is correct
            Assert.AreEqual(Error, "");
        }




    }
}

