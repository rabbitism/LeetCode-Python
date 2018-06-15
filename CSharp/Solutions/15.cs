using System;
using System.Linq;
using System.Collections.Generic;

namespace CSharp{
    public partial class Solution{
        //Solution 1: Brutal Force
        //This solution is basically wrong, because it exceeds time complexity, and included duplicates.
        public IList<IList<int>> ThreeSum_1(int[] nums) {
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            if(length<3) return null;
            for(int i = 0; i< length; i++){
                for(int j=i+1; j< length; j++){
                    for(int k=j+1; k< length; k++){
                        if(nums[i]+nums[j]+nums[k]==0){
                            result.Add(new List<int>(){nums[i],nums[j],nums[k]});
                        }
                    }
                }
            }
            result.Distinct();

            return result;
        
        }

        //Solution 2: Brutal Force, Add result after sorted
        //This solution is wrong, because when distincting result, the result of comparing list is not working as expected. 
        public IList<IList<int>> ThreeSum_2(int[] nums){
            int length = nums.Length;
            IList<IList<int>> result = new List<IList<int>>();
            if(length<3) return null;
            for(int i = 0; i< length; i++){
                for(int j=i+1; j< length; j++){
                    for(int k=j+1; k< length; k++){
                        if(nums[i]+nums[j]+nums[k]==0){
                            List<int> temp = new List<int>(){nums[i], nums[j], nums[k]};
                            temp.Sort();
                            result.Add(temp);
                        }
                    }
                }
            }
            result = result.Distinct().ToList();
            return result;
        }

        //Solution 3: Brutal Force, reduce maximum appearance of numbers to 2.
        public IList<IList<int>> ThreeSum(int[] nums){
            IList<IList<int>> result = new List<IList<int>>();
            if(nums.Length<3) return result;

            Dictionary<int, int> dictionary = new Dictionary<int, int>();
            
            foreach(var num in nums){
                if(!dictionary.ContainsKey(num)) dictionary.Add(num,1);
                else dictionary[num]+=1;
            }
            foreach(KeyValuePair<int,int> pair in dictionary){
                if(pair.Key==0 && pair.Value>=3) result.Add(new List<int>(){0,0,0});
                else{
                    if(pair.Key!=0 && pair.Value>=2 && dictionary.ContainsKey(-2*pair.Key)){
                        result.Add(new List<int>{pair.Key,pair.Key,-2*pair.Key});
                    }
                }
                
            }
            List<int> reducedList = nums.ToList();
            reducedList = reducedList.Distinct().ToList();
            reducedList.Sort();
            int length = reducedList.Count;
            if(length>=3){
                for(int i = 0; i< length; i++){
                    int startIndex = i+1;
                    int endIndex = length-1;
                    while(startIndex<=endIndex){
                        if(startIndex==endIndex) break;
                        if(reducedList[startIndex]+reducedList[endIndex]>-reducedList[i]){
                            endIndex--;
                        }
                        else if(reducedList[startIndex]+reducedList[endIndex]<-reducedList[i]){
                            startIndex++;
                        }
                        else if(reducedList[startIndex]+reducedList[endIndex]==-reducedList[i]){
                            result.Add(new List<int>(){reducedList[i], reducedList[startIndex], reducedList[endIndex]});
                            startIndex++;
                        }
                        
                    }
                }
            }
            return result;
        }



    }

}