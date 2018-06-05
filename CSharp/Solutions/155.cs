using System.Collections;
using System.Collections.Generic;

namespace CSharp{
    public class MinStack{
        //Accepted. 
        List<int> list = new List<int>();
        List<int> minList = new List<int>();

        public MinStack(){

        }

        public void Push(int x){
            list.Add(x);
            if(minList.Count==0) minList.Add(x);
            else if(x>minList[minList.Count-1]) minList.Add(minList[minList.Count-1]);
            else minList.Add(x);
        }

        public void Pop(){
            list.RemoveAt(list.Count-1);
            minList.RemoveAt(minList.Count-1);
        }

        public int Top(){
            return list[list.Count-1];
        }

        public int GetMin(){
            return minList[minList.Count-1];
        }
    }
}