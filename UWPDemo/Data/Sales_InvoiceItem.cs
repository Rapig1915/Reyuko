using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace UWPDemo.Data
{
    class Sales_InvoiceItem
    {
        public int Invoice_No { get; set; }
        public string Date { get; set; }
        public string SO_No { get; set; }
        public string DO_No { get; set; }
        public string Customer_ID { get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string Status { get; set; }
        public string Outstanding { get; set; }
        public string Repeat { get; set; }
        public string AgingReceivable { get; set; }
    }
    class Sales_DeliveryOrderItem
    {
        public string Delivery_Order_No { get; set; }
        public string Date { get; set; }
        public string Sales_Order_No { get; set; }
        public string Customer_Id { get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string Annual { get; set; }
        
    }
    class Sales_DocumentItem
    {
        public string Transaction_No { get; set; }
        public string Date { get; set; }
        public string Referal_No { get; set; }
        public string Contact_Id{ get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string Annual { get; set; }
        public string Complete{ get; set; }

    }
    class Sales_ReturnItem
    {
        public string Sales_Return_No { get; set; }
        public string Date { get; set; }
        public string Invoice_No{ get; set; }
        public string Customer_Id { get; set; }
        public string Currency { get; set; }
        public string Total { get; set; }
        public string Annual { get; set; }
        public string Outstanding { get; set; }

    }
    class Ssetting_TransactionCodeItem
    {
        public string Transaction_Code { get; set; }
        public string Description { get; set; }
        
    }
}
