using System;
using System.Collections.Generic;
using System.IO;

namespace ClaimAnalyzerApp
{

    public class ClaimAnalyzer
    {   
        private List<Dictionary<string, object>> claims = new List<Dictionary<string, object>>();

        public void LoadClaimsFromFile(string filePath)
        {
            

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Dictionary<string, object> claimsData = new Dictionary<string, object>
                    {
                        {"ClaimID", parts[0]},
                        {"Policy Holder Name", parts[1]},
                        {"Claim Date", parts[2]},
                        {"Claim Amount", parts[3]},
                        {"Claim Type", parts[4]},
                        {"Claim Location", parts[5]}
                    };

                    claims.Add(claimsData);
                }
            }
               

        }
        public void DisplayInfo()
        {
            foreach (var claim in claims)
            {
                Console.WriteLine($"Policy Holder: {claim["Policy Holder Name"]}, "+
                                  $"ClaimID: {claim["ClaimID"]}, " + 
                                  $"Date: {claim["Claim Date"]}, " +
                                  $"Amount: {claim["Claim Amount"]}, " + 
                                  $"Type: {claim["Claim Type"]}, " + 
                                  $"Location: {claim["Claim Location"]}"); 
            }
        }
    
    }
    public class Program
    {
         static void Main(string[] args)
         {
            ClaimAnalyzer analyzer = new ClaimAnalyzer();

            string filePath = "/Users/alexanderhagopian/Documents/repos/Claim_Analyzer/ClaimAnalyzerApp/claims.txt";

            analyzer.LoadClaimsFromFile(filePath);
            analyzer.DisplayInfo();
         }
    }

}
    