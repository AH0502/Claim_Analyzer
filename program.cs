using System;
using System.Generic;
using System.IO;

namespace claimAnalyzer
{

    public class Claim
    {   
        public int claimID {get; set;};
        public string policyHolderName {get; set;};
        public string claimDate {get; set;};
        public decimal amount {get; set;};
        public string claimType {get; set;};
        public string location {get; set;};
    }
    static void main(string args[])
    {
        
    }
}