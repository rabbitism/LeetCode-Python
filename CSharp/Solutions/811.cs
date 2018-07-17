using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public IList<string> SubdomainVisits(string[] cpdomains) {
        if(cpdomains.Length==0) return new List<string>();
        List<string> result = new List<string>();
        Dictionary<string,int> dict = new Dictionary<string, int>();
        foreach(string s in cpdomains){
            string[] sArray = s.Split(' ');
            int count = System.Convert.ToInt32(sArray[0]); //Since there is another function named Convert, so I add domain name. 
            string[] domainSplit = sArray[1].Split('.');
            if(domainSplit.Length == 2){
                string domain1 = domainSplit[1];
                string domain2 = domainSplit[0]+"."+domainSplit[1];
                if(dict.ContainsKey(domain1)) dict[domain1]+=count;
                if(!dict.ContainsKey(domain1)) dict.Add(domain1,count);
                if(dict.ContainsKey(domain2)) dict[domain2]+=count;
                if(!dict.ContainsKey(domain2)) dict.Add(domain2,count);
            }
            if(domainSplit.Length == 3){
                string domain1 = domainSplit[2];
                string domain2 = domainSplit[1]+"."+domainSplit[2];
                string domain3 = sArray[1];
                if(dict.ContainsKey(domain1)) dict[domain1]+=count;
                if(!dict.ContainsKey(domain1)) dict.Add(domain1,count);
                if(dict.ContainsKey(domain2)) dict[domain2]+=count;
                if(!dict.ContainsKey(domain2)) dict.Add(domain2,count);
                if(dict.ContainsKey(domain3)) dict[domain3]+=count;
                if(!dict.ContainsKey(domain3)) dict.Add(domain3,count);
            }
        }
        
        foreach(var pair in dict){
            result.Add(pair.Value+" "+pair.Key);
        }
        return result;
        
    }
}
}