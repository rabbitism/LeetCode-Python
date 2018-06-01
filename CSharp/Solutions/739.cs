using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{

        //Brutal force, TLE.
        public int[] DailyTemperatures(int[] temperatures) {
            int days = temperatures.Length;
            if(days==1) return new int[]{0}; 
            int[] result = new int[days];
            for(int i=0; i<days; i++){
                for(int j = i+1; j<days;j++){
                    if(j==days-1&&temperatures[i]>temperatures[j])
                    {
                        result[i]=0;
                    }
                    else if(temperatures[i]<temperatures[j]){
                        result[i]=j-i;
                        break;
                    }
                }
            }

            return result;
        
        }

        public int[] DailyTemperatures_2(int[] temperatures) {

            return null;

        }
    }
}