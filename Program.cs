using System;
using System.Collections.Generic;

namespace OopTest
{
    class Program
    {
        static void Main(string[] args)
        {
            Buffet buffet = new Buffet();
            Ninja ninja = new Ninja();

            while(!ninja.IsFull){
                ninja.Eat(buffet.Serve());
            }   
            
            ninja.Eat(buffet.Serve());
        }



        static List<int> RemoveDuplicate(List<int> numList, int index=0){       
            if(index==numList.Count)
                return numList;
            
            for(int i=0; i<numList.Count;i++) {
                if( numList[index]==numList[i] && index!=i) {
                    numList.RemoveAt(i);
                }
            }

            return RemoveDuplicate(numList,index+1);

            // List<int> alist = new List<int>(){5,6,1,2,3,1,5,4,4,2,6};
            // alist=RemoveDuplicate(alist);
            // Console.WriteLine(string.Join(Environment.NewLine, alist));
        }

    }
}
