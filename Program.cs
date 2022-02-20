using System;
using System.Threading.Tasks;
using System.Net.Http;
using System.Net.Http.Headers;
using dmdiApp;
using System.Collections.Generic;
using System.Text.Json;
using System.Diagnostics;
using System.Linq;
using System.Text;
using Newtonsoft.Json;



namespace dmdiApp
{
    
    class Program
    {
        private static readonly HttpClient client = new HttpClient();
        static void Main(string[] args)
        {
          //  await ProcessRepositories();
          dmditxn txn = new dmditxn();
         // var jsonData = txn.getTxns();
         // var jsonData = txn.getTxnLDLive();
         var jsonData = txn.getJsonData();
          //AllTransactions alltxn = new AllTransactions();

          var txns = JsonConvert.DeserializeObject<AllTransactions>(jsonData);
          
          //  txn.calcLoanProds(txns.transactions);
        
        //txn.adjustTxn(txns.transactions);
         //  txn.loanInterest(txns.transactions);
           // txn.createJsonFFile(jsonData);
           txn.createIIFFile();

        var transactn = from t in txns.transactions
                        where t.productType == "Loan"
                        select t;        

       /*  Console.WriteLine("\nLoan_Disbursement"); 
        txn.calcDisbursementProducts(txns);*/
        Console.WriteLine();Console.WriteLine();
        Console.WriteLine("Loan Repayment");
        txn.calcLoanProducts_Principle(txns); 
        txn.calcLoanProducts_Interests(txns);
        Console.WriteLine("Loan Disbursement Accounts Receivable");
        txn.calcDisbursementProducts_AR(txns);

   //     
    /*     foreach (var tx in transactn) //txns.transactions
        {
             //check for the product type
            string[] prodtype = {"Deposit", "Loan"};

            ///paymentMethod
            var txnType = txn.getPaymentMethod(tx.transactionType);
            
             
         //   Console.WriteLine("ProductName : " + tx.productName + "\t" + "ProductID : " + tx.productID + "\t" + "TxnType - "+  txnType + "\t Interest : " + tx.interest  + "\t Principal : " + tx.principal + "\tAmount  : " + tx.amount + "\t Branch: " +tx.clientBranch);


         }        
            */
          //Console.WriteLine(DateTime.Now.ToShortDateString());//.AddDays(13)
           Console.ReadLine();

        }

        private static async Task ProcessRepositories()
        {
            //set up the Http headers
             //clear any previous headers
            client.DefaultRequestHeaders.Accept.Clear();
            client.DefaultRequestHeaders.Accept.Add(new MediaTypeWithQualityHeaderValue("application/vnd.github.v3+json"));
            client.DefaultRequestHeaders.Add("User-Agent", ".NET Foundation Repository Reporter");

            var stringTask = client.GetStringAsync("https://api.github.com/orgs/dotnet/repos");
            var msg = await stringTask;
            Console.Write(msg);

        }
    }

}