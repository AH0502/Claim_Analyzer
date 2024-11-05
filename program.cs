using System;
using System.Collections.Generic;
using System.IO;

namespace claimAnalyzer
{

    public class claimAnalyzer
    {   
        private List<Dictionary<string, object>> claims = new List<Dictionary<string, object>>();

        public void LoadClaimsFromFile(string filePath)
        {
            

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.split(',');
                    Dictionary<string, object> claimsData = new Dictionary<string, object>
                    {
                        {'ClaimID', parts[0]},
                        {'Policy Holder Name', parts[1]},
                        {'Claim Date', parts[2]},
                        {'Claim Amount', parts[3]},
                        {'Claim Type', parts[4]},
                        {'Claim Location', parts[5]}
                    }
                }
                claims.Add(claimsData);

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
                                  $"Location: {Claim["Claim Location"]}"); 
            }
        }
    }

    static void Main(string[] args)
    {

    }
}