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
                    Print(item);
                }
            }
        }

        public static void Print<T>(IList<T> list){
            if(list == null){
                Console.WriteLine("Empty List.");
            }
            else{
                foreach(T item in list){
                   Console.Write(item);
                   Console.Write("\t");
                }
            }
            Console.WriteLine();
        }

        public static void Print<T>(IList<IList<T>> list){
            if(list == null){
                Console.WriteLine("Empty List.");
            }
            else{
                foreach(var item in list){
                    if(item==null) Console.Write("Empty List");
                    else{
                        foreach(var subitem in item){
                            Console.Write(subitem+"\t");
                        }
                    }
                    Console.WriteLine();
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
                    Console.Write(item+"\t");
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

        public static void Print<T>(T[][] matrix){
            for(int i = 0; i< matrix.Length; i++){
                for(int j = 0; j<matrix[0].Length; j++){
                    Console.Write(matrix[i][j]+"\t");
                }
                Console.Write("\n");
            }
        }

        public static void Print<T>(T num){
            Console.WriteLine(num);
        }

        public static void Print(ListNode node){
            if(node==null){
                Console.WriteLine("Null head");
            }
            else{
                Console.Write("Start->");
                var probe = node;
                while(probe!=null){
                    Console.Write(probe.val+"->");
                    probe = probe.next;
                }
                Console.Write("End"+"\n");
            }
        }

    }
}