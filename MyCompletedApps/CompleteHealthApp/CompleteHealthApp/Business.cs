using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CompleteHealthApp
{
    public class Business
    {
        public string businessName { get; set; }
        public string industry { get; set; }
        public DateTime hoursOfOperation { get; set; }
        public string address { get; set; }
        public string businessPhoneNumber { get; set; }
        public string logo { get; set; } //use the path to the image file
        public int taxIdNumber { get; set; }

        public Business(string businessName, string industry, DateTime hoursOfOperation, 
            string address, string businessPhoneNumber, string logo, int taxIdNumber)
        {
            this.businessName = businessName;
            this.industry = industry;
            this.hoursOfOperation = hoursOfOperation;
            this.address = address;
            this.businessPhoneNumber = businessPhoneNumber;
            this.logo = logo;
            this.taxIdNumber = taxIdNumber;
        }

        public void DisplayBusinessInformation()
        {

        }

        public void EditBusinessInformation()
        {

        }

        public void SendVirtualBusinessCard()
        {

        }
    }

    public class Customers
    {
        public string customerName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }

        public Customers(string customerName, string address, string phoneNumber, string emailAddress)
        {
            this.customerName = customerName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
        }

        public void DisplayCustomerInformation()
        {

        }

        public void EditCustomerInformation()
        {

        }
    }

    public class Employees
    {
        public string employeeName { get; set; }
        public string address { get; set; }
        public string phoneNumber { get; set; }
        public string emailAddress { get; set; }
        public int salary { get; set; }
        public int timeWithCompany { get; set; }

        public Employees(string employeeName, string address, string phoneNumber, string emailAddress, int salary, int timeWithCompany)
        {
            this.employeeName = employeeName;
            this.address = address;
            this.phoneNumber = phoneNumber;
            this.emailAddress = emailAddress;
            this.salary = salary;
            this.timeWithCompany = timeWithCompany;
        }

        public void DisplayEmployeeInformation()
        {

        }

        public void EditEmployeeInformation()
        {

        }
    }

    public class Invoices
    {
        public int invoiceID { get; set; }
        public string customerName { get; set; }
        public string customerPhoneNumber { get; set; }
        public string customerAddress { get; set; }
        public string customerEmail { get; set; }
        public string companyName { get; set; }
        public string companyPhoneNumber { get; set; }
        public string companyAddress { get; set; }
        public string companyEmail { get; set; }
        public int invoiceSubtotal { get; set; }
        public int invoiceTotal { get; set; }
        public int amountPaid { get; set; }

        List<string> invoiceItems = new List<string>();
        List<int> invoiceItemCosts = new List<int>();

        public Invoices(int invoiceID, string customerName, string customerPhoneNumber, string customerAddress, string customerEmail, string companyName, string companyPhoneNumber, string companyAddress, string companyEmail, int invoiceSubtotal, int invoiceTotal, int amountPaid, List<string> invoiceItems, List<int> invoiceItemCosts)
        {
            this.invoiceID = invoiceID;
            this.customerName = customerName;
            this.customerPhoneNumber = customerPhoneNumber;
            this.customerAddress = customerAddress;
            this.customerEmail = customerEmail;
            this.companyName = companyName;
            this.companyPhoneNumber = companyPhoneNumber;
            this.companyAddress = companyAddress;
            this.companyEmail = companyEmail;
            this.invoiceSubtotal = invoiceSubtotal;
            this.invoiceTotal = invoiceTotal;
            this.amountPaid = amountPaid;
            this.invoiceItems = invoiceItems;
            this.invoiceItemCosts = invoiceItemCosts;
        }

        public void DisplayInvoiceInformation()
        {

        }

        public void EditInvoiceInformation()
        {

        }

        public void SendInvoice()
        {

        }

        public void RetrievePaidInvoice()
        {

        }

        public void ViewPastInvoices()
        {

        }

        public void ViewSummaryOfInvoices()
        {

        }

        public void PrintInvoice()
        {

        }
    }
}
