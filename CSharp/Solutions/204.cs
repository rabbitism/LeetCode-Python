using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    //Solution 1: TLE. 
    public int CountPrimes_2(int n) {
        if(n<=2) return 0;
        List<int> list = new List<int>();
        list.Add(2);
        for(int i = 2; i< n; i++){
            bool prime = true;
            foreach(var number in list){
                if(i%number==0){
                    prime = false;
                    break;
                }
            }
            if(prime){
                list.Add(i);
            }
            
        }
        return list.Count;
        
    }

    //Solution 2: Accepted. 
    public int CountPrimes(int n) {
        if(n<=2) return 0;
        bool[] notPrime = new bool[n];
        int result = 0;
        for(int i = 2; i<n; i++){
            if(notPrime[i]==false){
                result++;
                for(int j = 1; i*j<n; j++){
                    notPrime[i*j] = true; 
                }
            }
        }
        return result;
    }
}
}
