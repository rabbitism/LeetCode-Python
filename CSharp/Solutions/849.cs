using System;
using System.Collections.Generic;

namespace CSharp{
public partial class Solution {

    //Accepted
    public int MaxDistToClosest(int[] seats) {
        List<int> seated = new List<int>();
        for(int i = 0; i< seats.Length; i++){
            if(seats[i]==1) seated.Add(i);
        }
        List<int> distances = new List<int>();
        distances.Add(seated[0]);
        distances.Add(seats.Length-1-seated[seated.Count-1]);
        for(int i = 0; i< seated.Count-1; i++){
            distances.Add((seated[i+1]-seated[i])/2);
        }
        int max = 0;
        for(int i = 0; i< distances.Count; i++){
            max = Math.Max(max, distances[i]);
        }
        return max;
    }
}   
}