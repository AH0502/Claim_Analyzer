﻿using System;
using System.Collections.Generic;
using System.IO;

namespace ClaimAnalyzerApp
{

    public class ClaimAnalyzer
    {   
        private List<Dictionary<string, string>> claims = new List<Dictionary<string, string>>();

        public void LoadClaimsFromFile(string filePath)
        {
            

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while ((line = sr.ReadLine()) != null)
                {
                    string[] parts = line.Split(',');
                    Dictionary<string, string> claimsData = new Dictionary<string, string>
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
                Console.WriteLine($"Policy Holder:{claim["Policy Holder Name"]}, "+
                                  $"ClaimID:{claim["ClaimID"]}, " + 
                                  $"Date:{claim["Claim Date"]}, " +
                                  $"Amount:{claim["Claim Amount"]}, " + 
                                  $"Type:{claim["Claim Type"]}, " + 
                                  $"Location:{claim["Claim Location"]}"); 
            }
        }
        public void CalculateAvg()
        {
            decimal sum = 0;
            int count = 0;

            foreach (var claim in claims)
            {
                decimal.TryParse(claim["Claim Amount"], out decimal claimAmount);
                sum += claimAmount;
                count++;
            }
            sum = sum / count;
            Console.WriteLine($"Average: ${sum}");
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
    