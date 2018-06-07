using System;
using System.Collections.Generic;

namespace CSharp
{
    public static class Printer{

        public static void Print<T>(List<T> list){
            if(list == null){
                Console.WriteLine("Empty List.");
            }
            else{
                foreach(T item in list){
                    Console.WriteLine(item);
                }
            }
            
        }

        public static void Print<TKey,TValue>(Dictionary<TKey,TValue> dictionary){
            if(dictionary == null){
                Console.WriteLine("Empty Dictionary.");
            }
            else{
                foreach(var pair in dictionary){
                    Console.WriteLine("{0}\t{1}", pair.Key, pair.Value);
                }
                
            }
        }
        
        public static void Print<T>(T[] array){
            if(array == null){
                Console.WriteLine("Empty Array.");
            }
            else{
                foreach(T item in array){
                    Console.WriteLine(item);
                }
            }
            
        }

        public static void Print<T>(T[,] array){
            if(array==null){
                Console.WriteLine("Empty Array.");
            }
            else{
                for(int i = 0; i < array.GetLength(0); i++){
                    for(int j = 0; j < array.GetLength(1); j++){
                        Console.Write(array[i,j]+"\t");
                    }
                    Console.Write("\n");
                }
            }
        }

        public static void Print<T>(T num){
            Console.WriteLine(num);
        }

    }
}