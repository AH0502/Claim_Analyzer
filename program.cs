using System;
using System.Generic;
using System.IO;

namespace claimAnalyzer
{

    public class claimAnalyzer
    {   
        private List<Dictionary<string, object>> claims = new List<Dictionary<string, object>>();

        public void LoadClaimsFromFile(string filePath)
        {
            Dictionary<string, object> claimsData = new Dictionary<string, object>();

            using (StreamReader sr = new StreamReader(filePath))
            {
                string line;
                while (line = sr.ReadLine() != null)
                {
                    string[] parts = line.split(',');
                    claims.Add('ClaimID', parts[0]);
                    claims.Add('Policy Holder Name', parts[1]);
                    claims.Add('Claim Date', parts[2]);
                    claims.Add('Claim Amount', parts[3]);
                    claims.Add('Claim Type', parts[4]);
                    claims.Add('Claim Location', parts[5]);
                }
            }

        }
    }

    static void Mainin(string[] args)
    {

    }
}