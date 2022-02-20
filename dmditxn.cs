using System;
using System.Data;
using System.Collections.Generic;
using System.Collections;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Linq;
using System.IO;
using RestSharp;



namespace dmdiApp
{
    public class dmditxn
    {

        public List<string> productIds = new List<string>(){"CONSULNEQR", "PRODLNUSDEQR", "PRODNL-W", "SERVLNEQR",
                                        "SERVLNEQR","SERVLN-W", "TRACLNEQR", "TRACLN-W"};
            public string getTxns(){
            var client = new RestClient("https://dmdiusdtraining.instafin.info/submit/instafin.SearchAllTransactions");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic MDU5ZDcyZWIyMmE3NDdjOGIwNmNhOWRkODI3MjVjMmM6ZGI0YTc5OTEwYTllNDNjMzk5NmYzYWFhZGU0ZGM1OTA=");
            request.AddHeader("Content-Type", "text/plain");
            var body = @"{
            " + "\n" +
            @" ""filter"": {
            " + "\n" +
            @" ""startDate"": ""2021-08-20"",
            " + "\n" +
            @" ""endDate"": ""2021-09-06"",
            " + "\n" +
            @" ""branchId"": null,
            " + "\n" +
            @" ""creditOfficerId"": null,
            " + "\n" +
            @" ""centreId"" : null,
            " + "\n" +
            @" ""organisation"":
            " + "\n" +
            @"{
            " + "\n" +
            @" ""organisationId"": null,
            " + "\n" +
            @" ""withoutCreditOfficer"": false,
            " + "\n" +
            @" ""withoutCentre"": false
            " + "\n" +
            @" },
            " + "\n" +
            @" ""transactionTypes"": [],
            " + "\n" +
            @" ""transactionStatuses"": [],
            " + "\n" +
            @" ""paymentMethods"": [],
            " + "\n" +
            @" ""revertedTransactions"": true,
            " + "\n" +
            @" ""successfulTransactions"": true,
            " + "\n" +
            @" ""revertTransactions"": true,
            " + "\n" +
            @" ""fromAmount"": null,
            " + "\n" +
            @" ""toAmount"": null,
            " + "\n" +
            @" ""inAbsoluteAmounts"": false,
            " + "\n" +
            @" ""username"": null,
            " + "\n" +
            @" ""users"": null,
            " + "\n" +
            @" ""forOtherBranchTransactions"": true,
            " + "\n" +
            @" ""fromOtherBranchTransactions"": true,
            " + "\n" +
            @" ""withinOwnBranchTransactions"": true,
            " + "\n" +
            @" ""transactionIDs"": [],
            " + "\n" +
            @" ""clients"": [],
            " + "\n" +
            @" ""accountIDs"": [],
            " + "\n" +
            @" ""products"": [],
            " + "\n" +
            @" ""isCashRelevant"": false
            " + "\n" +
            @" },
            " + "\n" +
            @" ""pagination"":{
            " + "\n" +
            @" ""beforeID"": null,
            " + "\n" +
            @" ""limit"": 1000
            " + "\n" +
            @"}
            " + "\n" +
            @"}";
            request.AddParameter("text/plain", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
            
           // Console.WriteLine(response.Content);
            return response.Content;
                               

            } 
           
           public string getTxnLDLive()
           {
               var client = new RestClient("https://dmdild.instafin.com/submit/instafin.SearchAllTransactions");
            client.Timeout = -1;
            var request = new RestRequest(Method.POST);
            request.AddHeader("Authorization", "Basic NjyyyyYThkY2FlMmE0NGU4NWE1NTE0ZGYxY2FiNzY2YzY6M2QyN2Q3NzI1ODRlNDRjZjgzZjJhZTViNDJkZDNhZjM=");
            request.AddHeader("Content-Type", "application/json");
            var body = @"{
            " + "\n" +
            @" ""filter"": {
            " + "\n" +
            @" ""startDate"": ""2021-10-01"",
            " + "\n" +
            @" ""endDate"": ""2021-12-18"",
            " + "\n" +
            @" ""branchId"": null,
            " + "\n" +
            @" ""creditOfficerId"": null,
            " + "\n" +
            @" ""centreId"": null,
            " + "\n" +
            @" ""organisation"":
            " + "\n" +
            @"{
            " + "\n" +
            @" ""organisationId"": null,
            " + "\n" +
            @" ""withoutCreditOfficer"": false,
            " + "\n" +
            @" ""withoutCentre"": false },
            " + "\n" +
            @" ""transactionTypes"": [],
            " + "\n" +
            @" ""transactionStatuses"": [],
            " + "\n" +
            @" ""paymentMethods"": [],
            " + "\n" +
            @" ""revertedTransactions"": true,
            " + "\n" +
            @" ""successfulTransactions"": true,
            " + "\n" +
            @" ""revertTransactions"": true,
            " + "\n" +
            @" ""fromAmount"": null,
            " + "\n" +
            @" ""toAmount"": null,
            " + "\n" +
            @" ""inAbsoluteAmounts"": false,
            " + "\n" +
            @" ""username"": null,
            " + "\n" +
            @" ""users"": null,
            " + "\n" +
            @" ""forOtherBranchTransactions"": true,
            " + "\n" +
            @" ""fromOtherBranchTransactions"": true,
            " + "\n" +
            @" ""withinOwnBranchTransactions"": true,
            " + "\n" +
            @" ""transactionIDs"": [],
            " + "\n" +
            @" ""clients"": [],
            " + "\n" +
            @" ""accountIDs"": [],
            " + "\n" +
            @" ""products"": [],
            " + "\n" +
            @" ""isCashRelevant"": false
            " + "\n" +
            @" },
            " + "\n" +
            @" ""pagination"":{
            " + "\n" +
            @" ""beforeID"": null,
            " + "\n" +
            @" ""limit"": 1000}
            " + "\n" +
            @"}";
            request.AddParameter("application/json", body,  ParameterType.RequestBody);
            IRestResponse response = client.Execute(request);
           // Console.WriteLine(response.Content);
            return response.Content;
                               
        }

        public string getPaymentMethod(string str)
        {
           return str.Substring(str.IndexOf("_") +1);
        }

        public ArrayList calcLoanProds(AllTransactions txns)
        {
            ArrayList  loansums = new ArrayList();
            decimal amount; 
            //int i = 0;
            var linqQery = from txn in txns.transactions
                           // where  txn.paymentMethod.Contains("Cash")
                            select txn.amount;

            decimal total = 0.0M;
            foreach (var amnt in linqQery)
            {
                amount = decimal.Parse(amnt);
                loansums.Add(amount);
                Console.WriteLine("Txn Amount " + amnt);

                total += amount;
            }


            foreach (var txn in txns.transactions)
            {
                 // Determine the payment method (Cash, Cheque, Mobile-Money)

                // take care of special payment type

                    //Revert_Payment - Make TxnAmount Negative 
                    //Revert_Deposit - Make TxnAmount Negative 
                    //Revert_Withdrawal - Make TxnAmount Negative
                    //Revert_Disbursement - Make TxnAmount Positive 
                    //Disbursement - Make TxnAmount negative for all products

                // Sum up Interest for each Product
                //Sum up Principal for each Product

                // Sum the interest for products whose that have a -W extentension and a product with the same name but no extension,
                // Sum the principal for products whose that have a -W extentension and a product with the same name but no extension,
                
                //Sum up TxnAmount for Txntype Disbursement for each product

            }
            
               
                //store each of these values in a associative array,indexed by the name of
                // the product account in Quickbooks Chart of Accounts

           
            Console.WriteLine("Total : {0}", total);
            return loansums;
        }

        public void loanInterest(List<Transaction> txns)
        {
            //int i = 0;
            var loanprods = from txn in txns
                        where txn.productID != null && txn.productType.Equals("Loan")
                        group txn by new{txn.productID, txn.paymentMethod, txn.transactionBranch} ;
                        // into g  select g.ToList();
            var depositprods = from txn in txns
                        where txn.productID != null && txn.productType.Equals("Deposit")
                        group txn by new{txn.productID, txn.paymentMethod, txn.transactionBranch} ;
                        // into g  select g.ToList();
                        


            var interests = from txn in txns
                          //  where txn.productType.Contains("Loan") && txn.transactionType.Contains("Repayment")
                            select txn.transactionType;/////////////////interest

            

             //prods = prods.Distinct();
            /*
            foreach (var prod in prods)
            {
                Console.WriteLine("ProdID : " + prod);
            } */
            Console.WriteLine("Loan Products \n");
            foreach (var itm in loanprods)  
            {
                Console.WriteLine("ProductId : {0}  TotalInterest : {1}  TotalPrincipal  {2} ", itm.Key, itm.Sum(x=> decimal.Parse(x.interest ?? "0.00")), itm.Sum(x=>decimal.Parse(x.principal ?? "0.0")));
            }
            Console.WriteLine("\nDeposits Products\n");
            foreach (var itm in depositprods)  
            {
                Console.WriteLine("ProductId : {0}  TotalAmount : {1}  ", itm.Key, itm.Sum(x=> decimal.Parse(x.amount ?? "0.00")));
            }
        }

        public List<Transaction> adjustTxn(List<Transaction> txns)
        {
            //create a new collection to reference the modified txns collection

            List<Transaction> txnsModified = null;

            string txnType = "";
        foreach (var txn in txns)
                {
                    
                    txnType = txn.transactionType;
                    
                    
                    switch (txnType)
                    {
                        case "Revert_Repayment": break; //it is positive so make amount negative

                        case "Revert_Deposit": break; // amount is always negative

                        case "Revert_Withdrawal": break; // amount is always negative

                        case "Revert_Disbursement": 
                                decimal amnt = -1 * decimal.Parse(txn.amount); 
                                txn.amount = amnt.ToString();
                                break; //amount is negative,make it positive
                        
                        
                        default:
                        break;
                    }
                    
                }
           

            return txnsModified;
        }

        public void createIIFFile()
        {
           
           /*
            string accntName;
            string txnType = "TRNSTYPE";
            string date = DateTime.Now.ToShortDateString();
            string amnt= "0.0";
            */

            string fileName = @"C:\IIF_Files\je.iif";
            if (!File.Exists(fileName)) 
            {
                // Create the journal entry file headers.
                using (StreamWriter writer = File.CreateText(fileName)) 
                {
                    writer.WriteLine("!TRNS\tTRNSTYPE\tDATE\tACCNT\tAMOUNT");
                    writer.WriteLine("!SPL\tTRNSTYPE\tDATE\tACCNT\tAMOUNT");
                    writer.WriteLine("!ENDTRNS	");
                }	

                //create the journal entry transactions
              //  foreach (var item in collection)
                {
                    
                }
            }
        }

         public void createJsonFFile(string json)
        {
           
           /* string accntName;
            string txnType = "TRNSTYPE";
            string date = DateTime.Now.ToShortDateString();
            string amnt= "0.0";
            */

            string fileName = @"C:\IIF_Files\jsonData.txt";
           // if (!File.Exists(fileName)) 
           // {
                // Create the journal entry file headers.
                using (StreamWriter writer = File.CreateText(fileName)) 
                {
                    writer.WriteLine(json);
                   // writer.WriteLine("!SPL\tTRNSTYPE\tDATE\tACCNT\tAMOUNT");
                  //  writer.WriteLine("!ENDTRNS	");
                }	

                //create the journal entry transactions
              //  foreach (var item in collection)
                {
                    
                }
           // }
        }

        public string getJsonData()
        {
             // Create the journal entry file headers.
             string fileName = @"C:\IIF_Files\jsonData.txt";
                using(StreamReader reader = File.OpenText(fileName))
                {
                    return reader.ReadLine();
                }
        }

        public void calcLoanProducts_Principle(AllTransactions txns)
        {
            var lnrepaymentGp =  from s in txns.transactions
                    where s.productType == "Loan" && s.transactionType == "LOAN_REPAYMENT"
                    group s by new {
                        s.productName, s.transactionType, s.productID,s.paymentMethod, s.transactionBranch
                    };
                    string fileName = @"C:\IIF_Files\loanProdsJE_Principle.iif";
            using(StreamWriter writer = File.CreateText(fileName))
            {

                   Hashtable qbaccntMap = new Hashtable(){
                      {"TRACLNEQR","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"TRACLN-W","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"SERVLNEQR", "Service Loan - LRD, Service Loans - LRD"},
                      {"SERVLN-W", "Service Loan - LRD, Service Loans - LRD"},
                      {"PRODLNUSDEQR","Production Loan - LRD, Production Loans - LRD"},
                      {"CONSULNEQR","Consumer Loan - LRD, Consumer Loans - LRD"},
                      {"AGRICLSWA","Agric Loan"}                       
                   };

                    foreach (DictionaryEntry prodId in qbaccntMap)
                    {
                        Console.WriteLine("Loan Name {0}", prodId.Key); //.Split(",",2,StringSplitOptions.None)[1]);    
                    }

                    
                    //create the journal entry file header row
                  //  writer.WriteLine("!CUST\tNAME\tBADDR1\tBADDR2\tBADDR3\tBADDR4\tBADDR5\tSADDR1\tSADDR2\tSADDR3\tSADDR4\tSADDR5\tPHONE1\tPHONE2\tFAXNUM\tEMAIL\tNOTE\tCONT1\tCONT2\tCTYPE\tTERMS\tTAXABLE\tLIMIT\tRESALENUM\tREP\tTAXITEM\tNOTEPAD\tSALUTATION\tCOMPANYNAME\tFIRSTNAME\tMIDINIT\tLASTNAME");
                 //   writer.WriteLine("CUST	Customer	Joe Customer	444 Road Rd	\"Anywhere, AZ 85740\"	USA");
                    writer.WriteLine("!TRNS\tDATE\tTRNSTYPEE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                    writer.WriteLine("!SPL\tDATE\tTRNSTYPEE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                    writer.WriteLine("!ENDTRNS	");
                foreach (var t in lnrepaymentGp)
                    {
                     //   Console.WriteLine(t.Key);

                        //check the product to determine which quick books receivable accnts the product maps to
                      //  if(t.Key.productID.Equals("TRACLNEQR"))
                        {
                            string principalAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[1];
                           // string interestAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[0];

                            Console.WriteLine("PrincipalAcnt : {0} ", principalAccnt);//,interestAccnt);
                                                      
                            //Cr product account in QBdate- 12/28/2021
                            writer.WriteLine("TRNS\t"+ DateTime.Now.ToString("MM/dd/yyyy")+ "\tGENERAL JOURNAL\t"+ principalAccnt.TrimStart() +"\t12345678\tJoe Customer\tClass3\t" + (0M -t.Sum(x=>decimal.Parse(x.principal ?? "0.0")))+"\t");
                            //writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\t"+ interestAccnt.TrimStart() +"\tJoe Customer\t" + (0M -t.Sum(x=>decimal.Parse(x.interest ?? "0.0")))+"\t\t");
                            //check the transaction branch
                            if(t.Key.transactionBranch.Equals("Monrovia"))
                            {
                                    //check the payment method
                                    //to determine the right income account to debit
                                    //note that debit (Dr) amounts are always positive
                                    // and credit(Cr) amounts are always negative
                                   // for the Disbursement transaction type the product accunt is debited
                                   //and the payment method account Cas, Cheque, Mobile Money is credited
                                    
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tGENERAL JOURNAL\tCash-In-Vault - Head Off (LRD)\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                  // writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tCash-In-Vault - Head Off (LRD)\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t"); 
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") + "GENERAL JOURNAL\tTeller 2 - Head Office (LRD)\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                  // writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tTeller 2 - Head Office (LRD)\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t" + DateTime.Now.ToString("MM/dd/yyyy")+ "\tGENERAL JOURNAL\tMobile Money - LRD\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                       //  writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tMobile Money - LRD\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t");
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }


                            }
                            if(t.Key.transactionBranch.Equals("Redlight"))
                            {
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tGENERAL JOURNAL\tCash in Vault - Redlight\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                  // writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tCash in Vault - Redlight\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t"); 
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") + "\tGENERAL JOURNAL\tTeller 2 - Redlight (LRD)\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                 //  writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tTeller 2 - Redlight (LRD)\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") + "\tGENERAL JOURNAL\tMobile Money USD\t12345678\tJoe Customer\tClass3\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t");
                                                     //   writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tMobile Money USD\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t\t");
                                                        writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }
                            }
                        }
                      } //end of using statement
              // foreach (var _t in t)
                {
                // if(txn.getPaymentMethod(_t.transactionType) == "REPAYMENT")
                    //Console.WriteLine("Interest : " + _t.interest + "\t"+ "Principal : "+ _t.principal +"\t"+ "Amount : "+_t.amount);
                 //   Console.WriteLine("\nInterest : " + t.Sum( n=>decimal.Parse(n.interest ?? "0.0"))  + "\t"+ "Principal : "+ t.Sum(n=>decimal.Parse(n.principal ?? "0.0")) +"\t"+ "Amount : "+t.Sum(f=>decimal.Parse(f.amount ?? "0.0")));

                }
            }
        }

        public void calcDisbursementProducts(AllTransactions txns)
        {
                    var lndisbursementGp =  from s in txns.transactions
                    where  s.productType == "Loan" && s.transactionType == "LOAN_DISBURSEMENT"
                    group s by new {
                        s.productName, s.transactionType, s.productID,s.paymentMethod, s.transactionBranch
                    };
        
            string fileName = @"C:\IIF_Files\loanDisbursementProdsJE.iif";
            using(StreamWriter writer = File.CreateText(fileName))
            {

                   Hashtable qbaccntMap = new Hashtable(){
                      {"TRACLNEQR","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"TRACLN-W","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"SERVLNEQR", "Service Loan - LRD, Service Loans - LRD"},
                      {"SERVLN-W", "Service Loan - LRD, Service Loans - LRD"},
                      {"PRODLNUSDEQR","Production Loan - LRD, Production Loans - LRD"},
                      {"CONSULNEQR","Consumer Loan - LRD, Consumer Loans - LRD"},
                      {"AGRICLSWA","'', Agric Loan"}                       
                   };

                   foreach (DictionaryEntry prodId in qbaccntMap)
                    {
                        Console.WriteLine("Loan Name {0}", prodId.Key); //.Split(",",2,StringSplitOptions.None)[1]);    
                    }

                    
                    //create the journal entry file header row
                   // writer.WriteLine("!TRNS\tTRNSID\tTRNSTYPE\tDATE\tACCNT\tNAME\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                   // writer.WriteLine("!SPL\tSPLID\tTRNSTYPE\tDATE\tACCNT\tNAME\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                    writer.WriteLine("!TRNS\tTRNSID\tTRNSTYPE\tDATE\tACCNT\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                    writer.WriteLine("!SPL\tSPLID\tTRNSTYPE\tDATE\tACCNT\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                    writer.WriteLine("!ENDTRNS");
                foreach (var t in lndisbursementGp)
                {
                            string principalAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[1];
                            string interestAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[0];

                            Console.WriteLine("PrincipalAcnt : {0} InterestAcnt : {1}", principalAccnt,interestAccnt);
                             //Dr product account in QBdate- 12/28/2021
                             //principalAccnt

                             string accnt = principalAccnt.TrimStart();
                            Console.WriteLine("Principal Account "+accnt);
                            Console.WriteLine("\nString Lengths \n");
                            Console.WriteLine("Agric Loan : {0}  principalAcnt variable {1}", "Agric Loan".Length, accnt.Length);

                            writer.WriteLine("TRNS\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\t"+accnt+ "\t\t" + (0M + t.Sum(x=>decimal.Parse(x.amount ?? "0.0"))));//+"\t\t"
                           
                           if(t.Key.transactionBranch.Equals("Monrovia"))
                            {
                                    //check the payment method
                                    //to determine the right income account to debit
                                    //note that debit (Dr) amounts are always positive
                                    // and credit(Cr) amounts are always negative
                                    // for the Disbursement transaction type the product accunt is debited
                                    //and the payment method account Cas, Cheque, Mobile Money is credited
                                    
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tCash-In-Vault - Head Off (LRD)\t\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t\t");
                                                    writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToShortDateString()+"\tTeller 2 - Head Office (LRD)\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0")));
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToShortDateString()+"\tMobile Money - LRD\t\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0")));
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }


                            }
                            if(t.Key.transactionBranch.Equals("Redlight"))
                            {
                                //these are credit tranctions thus the amount must be negative
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tCash in Vault - Redlight\t\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tTeller 2 - Redlight (LRD)\t\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tMobile Money - LRD\t\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t\t");
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }
                            }
                    Console.WriteLine(t.Key);
                    // if(t.Key..Contains()
                    // foreach (var _t in t)
                    {
                    // if(txn.getPaymentMethod(_t.transactionType) == "REPAYMENT")
                        //Console.WriteLine("Interest : " + _t.interest + "\t"+ "Principal : "+ _t.principal +"\t"+ "Amount : "+_t.amount);
                        Console.WriteLine("\nAmount : " + t.Sum( n=>decimal.Parse(n.amount ?? "0.0"))  + "\t"+ "Principal : "+ t.Sum(n=>decimal.Parse(n.principal ?? "0.0")) +"\t"+ "Interest : "+t.Sum(f=>decimal.Parse(f.interest ?? "0.0")));

                    }
                    
                }
            }

        }



         public void calcDisbursementProducts_AR(AllTransactions txns)
        {
                    var lndisbursementGp =  from s in txns.transactions
                    where  s.productType == "Loan" && s.transactionType == "LOAN_DISBURSEMENT"
                    group s by new {
                        s.productName, s.transactionType, s.productID,s.paymentMethod, s.transactionBranch
                    };
        
            string fileName = @"C:\IIF_Files\GJE_AR.iif";
            using(StreamWriter writer = File.CreateText(fileName))
            {

                   Hashtable qbaccntMap = new Hashtable(){
                      {"TRACLNEQR","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"TRACLN-W","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"SERVLNEQR", "Service Loan - LRD, Service Loans - LRD"},
                      {"SERVLN-W", "Service Loan - LRD, Service Loans - LRD"},
                      {"PRODLNUSDEQR","Production Loan - LRD, Production Loans - LRD"},
                      {"CONSULNEQR","Consumer Loan - LRD, Consumer Loans - LRD"},
                      {"AGRICLSWA","'', Agric Loan"}                       
                   };

                   foreach (DictionaryEntry prodId in qbaccntMap)
                    {
                        Console.WriteLine("Loan Name {0}", prodId.Key); //.Split(",",2,StringSplitOptions.None)[1]);    
                    }

                    
                    //create the journal entry file header row
                    //!TRNS	DATE	TRNSTYPE	ACCNT	DOCNUM	NAME	CLASS	AMOUNT	MEMO
                    writer.WriteLine("!TRNS\tDATE\tTRNSTYPE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                    writer.WriteLine("!SPL\tDATE\tTRNSTYPE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                  //  writer.WriteLine("!TRNS\tTRNSID\tTRNSTYPE\tDATE\tACCNT\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                  //  writer.WriteLine("!SPL\tSPLID\tTRNSTYPE\tDATE\tACCNT\tCLASS\tAMOUNT\tDOCNUN\tMEMO");
                    writer.WriteLine("!ENDTRNS");
                foreach (var t in lndisbursementGp)
                {
                            string principalAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[1];
                            string interestAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[0];

                            Console.WriteLine("PrincipalAcnt : {0} InterestAcnt : {1}", principalAccnt,interestAccnt);
                             //Dr product account in QBdate- 12/28/2021
                             //principalAccnt

                             string accnt = principalAccnt.TrimStart();
                            Console.WriteLine("Principal Account "+accnt);
                            Console.WriteLine("\nString Lengths \n");
                            Console.WriteLine("Agric Loan : {0}  principalAcnt variable {1}", "Agric Loan".Length, accnt.Length);

                            writer.WriteLine("TRNS\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t"+accnt+ "\t12345678\tJoe Customer\tClass1\t" + (0M + t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t");//
                           
                           if(t.Key.transactionBranch.Equals("Monrovia"))
                            {
                                    //check the payment method
                                    //to determine the right income account to debit
                                    //note that debit (Dr) amounts are always positive
                                    // and credit(Cr) amounts are always negative
                                    // for the Disbursement transaction type the product accunt is debited
                                    //and the payment method account Cas, Cheque, Mobile Money is credited
                                    
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Cash-In-Vault - Head Off (LRD)\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t");
                                                    writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Teller 2 - Head Office (LRD)\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.interest ?? "0.0")))+"\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Mobile Money - LRD\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.interest ?? "0.0")))+"\t");
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }


                            }
                            if(t.Key.transactionBranch.Equals("Redlight"))
                            {
                                //these are credit tranctions thus the amount must be negative
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Cash in Vault - Redlight\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Teller 2 - Redlight (LRD)\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\t" + "Mobile Money - LRD\t12345678\tJoe Customer\tClass1\t" + (0M - t.Sum(x=>decimal.Parse(x.amount ?? "0.0")))+"\t");
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }
                            }
                    Console.WriteLine(t.Key);
                    // if(t.Key..Contains()
                    // foreach (var _t in t)
                    {
                    // if(txn.getPaymentMethod(_t.transactionType) == "REPAYMENT")
                        //Console.WriteLine("Interest : " + _t.interest + "\t"+ "Principal : "+ _t.principal +"\t"+ "Amount : "+_t.amount);
                        Console.WriteLine("\nAmount : " + t.Sum( n=>decimal.Parse(n.amount ?? "0.0"))  + "\t"+ "Principal : "+ t.Sum(n=>decimal.Parse(n.principal ?? "0.0")) +"\t"+ "Interest : "+t.Sum(f=>decimal.Parse(f.interest ?? "0.0")));

                    }
                    
                }
            }

        }
        
            public void calcLoanProducts_Interests(AllTransactions txns)
        {
            var lnrepaymentGp =  from s in txns.transactions
                    where s.productType == "Loan" && s.transactionType == "LOAN_REPAYMENT"
                    group s by new {
                        s.productName, s.transactionType, s.productID,s.paymentMethod, s.transactionBranch
                    };
                    string fileName = @"C:\IIF_Files\loanProdsJE_Interests.iif";
            using(StreamWriter writer = File.CreateText(fileName))
            {

                   Hashtable qbaccntMap = new Hashtable(){
                      {"TRACLNEQR","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"TRACLN-W","Trade & Comm Loans - LRD, Trade & Comm Loan - LRD"},
                      {"SERVLNEQR", "Service Loan - LRD, Service Loans - LRD"},
                      {"SERVLN-W", "Service Loan - LRD, Service Loans - LRD"},
                      {"PRODLNUSDEQR","Production Loan - LRD, Production Loans - LRD"},
                      {"CONSULNEQR","Consumer Loan - LRD, Consumer Loans - LRD"},
                      {"AGRICLSWA","Agric Loan"}                       
                   };

                    foreach (DictionaryEntry prodId in qbaccntMap)
                    {
                        Console.WriteLine("Loan Name {0}", prodId.Key); //.Split(",",2,StringSplitOptions.None)[1]);    
                    }

                    
                    //create the journal entry file header row
                  //  writer.WriteLine("!CUST\tNAME\tBADDR1\tBADDR2\tBADDR3\tBADDR4\tBADDR5\tSADDR1\tSADDR2\tSADDR3\tSADDR4\tSADDR5\tPHONE1\tPHONE2\tFAXNUM\tEMAIL\tNOTE\tCONT1\tCONT2\tCTYPE\tTERMS\tTAXABLE\tLIMIT\tRESALENUM\tREP\tTAXITEM\tNOTEPAD\tSALUTATION\tCOMPANYNAME\tFIRSTNAME\tMIDINIT\tLASTNAME");
                 //   writer.WriteLine("CUST	Customer	Joe Customer	444 Road Rd	\"Anywhere, AZ 85740\"	USA");
                    writer.WriteLine("!TRNS\tDATE\tTRNSTYPE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                    writer.WriteLine("!SPL\tDATE\tTRNSTYPE\tACCNT\tDOCNUN\tNAME\tCLASS\tAMOUNT\tMEMO");
                    writer.WriteLine("!ENDTRNS	");
                foreach (var t in lnrepaymentGp)
                    {
                     //   Console.WriteLine(t.Key);

                        //check the product to determine which quick books receivable accnts the product maps to
                      //  if(t.Key.productID.Equals("TRACLNEQR"))
                        {
                            string principalAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[1];
                            string interestAccnt = qbaccntMap[t.Key.productID].ToString().Split(",",2,StringSplitOptions.None)[0];

                            Console.WriteLine("PrincipalAcnt : {0} InterestAcnt : {1}", principalAccnt,interestAccnt);
                                                      
                            //Cr product Interest account in QBdate- 12/28/2021
                            writer.WriteLine("TRNS\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tGENERAL JOURNAL" +"\t"+ interestAccnt.TrimStart() +"\t12345678\tJoe Customer\tClass2\t" + (0M -t.Sum(x=>decimal.Parse(x.interest ?? "0.0")))+"\t");
                           // writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\t"+ principalAccnt.TrimStart() +"\tJoe Customer\t" + (0M -t.Sum(x=>decimal.Parse(x.principal ?? "0.0")))+"\t\t");
                            //check the transaction branch
                            if(t.Key.transactionBranch.Equals("Monrovia"))
                            {
                                    //check the payment method
                                    //to determine the right income account to debit
                                    //note that debit (Dr) amounts are always positive
                                    // and credit(Cr) amounts are always negative
                                   // for the Disbursement transaction type the product accunt is debited
                                   //and the payment method account Cas, Cheque, Mobile Money is credited
                                    
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" :  //writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tCash-In-Vault - Head Off (LRD)\t\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tGENERAL JOURNAL\tCash-In-Vault - Head Off (LRD)\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t"); 
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": //writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tTeller 2 - Head Office (LRD)\t\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tGENERAL JOURNAL\tTeller 2 - Head Office (LRD)\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money": //writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tMobile Money - LRD\t\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                         writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tGENERAL JOURNAL\tMobile Money - LRD\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t");
                                                         writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }


                            }
                            if(t.Key.transactionBranch.Equals("Redlight"))
                            {
                                switch (t.Key.paymentMethod)
                                {
                                    case "Cash" : // writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy")+"\tCash in Vault - Redlight\t\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("SPL\t"+ DateTime.Now.ToString("MM/dd/yyyy") + "\tGENERAL JOURNAL\tCash in Vault - Redlight\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t"); 
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Cheque": //writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tTeller 2 - Redlight (LRD)\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                   writer.WriteLine("SPL\t" +DateTime.Now.ToString("MM/dd/yyyy") + "\tGENERAL JOURNAL\tTeller 2 - Redlight (LRD)\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t");
                                                   writer.WriteLine("ENDTRNS");
                                                   break;
                                    
                                    case "Mobile Money":// writer.WriteLine("SPL\t\tGENERAL JOURNAL\t"+ DateTime.Now.ToString("MM/dd/yyyy") +"\tMobile Money USD\t\t" + t.Sum(x=>decimal.Parse(x.principal ?? "0.0"))+"\t\t");
                                                        writer.WriteLine("SPL\t" + DateTime.Now.ToString("MM/dd/yyyy") + "\tGENERAL JOURNAL\tMobile Money USD\t12345678\tJoe Customer\tClass2\t" + t.Sum(x=>decimal.Parse(x.interest ?? "0.0"))+"\t");
                                                        writer.WriteLine("ENDTRNS");
                                                        break;
                                    
                                    default: break;
                                }
                            }
                        }
                      } //end of using statement
              // foreach (var _t in t)
                {
                // if(txn.getPaymentMethod(_t.transactionType) == "REPAYMENT")
                    //Console.WriteLine("Interest : " + _t.interest + "\t"+ "Principal : "+ _t.principal +"\t"+ "Amount : "+_t.amount);
                 //   Console.WriteLine("\nInterest : " + t.Sum( n=>decimal.Parse(n.interest ?? "0.0"))  + "\t"+ "Principal : "+ t.Sum(n=>decimal.Parse(n.principal ?? "0.0")) +"\t"+ "Amount : "+t.Sum(f=>decimal.Parse(f.amount ?? "0.0")));

                }
            }
        }
              
       }
        
    }
