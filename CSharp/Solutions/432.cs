using System.Collections.Generic;
using System.Linq;

namespace CSharp{
    public class AllOne{

        private Dictionary<string, int> dictionary;
        private SortedDictionary<int, List<string>> tracker;

        public AllOne(){
            dictionary = new Dictionary<string, int>();
            tracker = new SortedDictionary<int, List<string>>();
        }

        public void Inc(string key){
            if(dictionary.ContainsKey(key)){
                dictionary[key]+=1;
                tracker[dictionary[key]-1].Remove(key);
                if(!tracker.ContainsKey(dictionary[key])) tracker.Add(dictionary[key],new List<string>());
                tracker[dictionary[key]].Add(key);
                if(tracker[dictionary[key]-1].Count==0) tracker.Remove(dictionary[key]-1);
            } 
            else{
                dictionary.Add(key,1);
                if(!tracker.ContainsKey(1)) tracker.Add(1,new List<string>());
                tracker[1].Add(key);
            }
        }

        public void Dec(string key){
            if(dictionary.ContainsKey(key)){
                if(dictionary[key]==1){
                    dictionary.Remove(key);
                    tracker[1].Remove(key);
                    if(tracker[1].Count==0) tracker.Remove(1);
                } 
                else{
                    dictionary[key]-=1;
                    tracker[dictionary[key]+1].Remove(key);
                    tracker[dictionary[key]].Add(key);
                    if(tracker[dictionary[key]+1].Count==0) tracker.Remove(dictionary[key]+1);
                }
            }

        }

        public string GetMaxKey(){
            if(tracker.Keys.Count==0) return "";
            else{
                return tracker[tracker.Keys.Last()][0];
            }
        }

        public string GetMinKey(){
            if(tracker.Keys.Count==0) return "";
            else{
                return tracker[tracker.Keys.First()][0];
            }
        }
    }

}