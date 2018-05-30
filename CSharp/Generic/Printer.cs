using System;
using System.Collections;
using System.Collections.Generic;

namespace CSharp{
    public static class Printer{

        public static void PrintList<T>(List<T> list){
            if(list == null){
                Console.WriteLine("Empty List.");
            }
            else{
                foreach(T item in list){
                    Console.WriteLine(item);
                }
            }
            
        }

        public static void PrintDictionary<TKey,TValue>(Dictionary<TKey,TValue> dictionary){
            if(dictionary == null){
                Console.WriteLine("Empty Dictionary.");
            }
            else{
                foreach(var pair in dictionary){
                    Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
                }
                
            }
        }
        
        public static void PrintArray<T>(T[] array){
            if(array == null){
                Console.WriteLine("Empty Array.");
            }
            else{
                foreach(T item in array){
                    Console.WriteLine(item);
                }
            }
            
        }

    }
}