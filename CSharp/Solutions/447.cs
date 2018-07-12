using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {
    public int NumberOfBoomerangs(int[,] points) {
        int n = points.GetLength(0);
        int[,] matrix = new int[n,n];
        for(int i = 0; i < n; i++){
            for(int j = i+1; j< n; j++){
                int distance = (points[i,0]-points[j,0])*(points[i,0]-points[j,0])+(points[i,1]-points[j,1])*(points[i,1]-points[j,1]);
                matrix[i,j]=distance;
                matrix[j,i]=distance;
                
            }
        }
        int sum = 0;
        for(int i = 0; i < n; i++){
            Dictionary<int, int> dict = new Dictionary<int, int>();
            for(int j = 0; j< n; j++){
                if(dict.ContainsKey(matrix[i,j])) dict[matrix[i,j]]++;
                else dict.Add(matrix[i,j],1);
            }
            foreach(var pair in dict){
                if(pair.Value>=2) sum+=pair.Value*(pair.Value-1);
            }
        }
        
        return sum;
        
    }
}
}