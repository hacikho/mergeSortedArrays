using System;
using System.Collections.Generic;

class MainClass {
  public static void Main (string[] args) {
    //Console.WriteLine ("Hello World");
    int[] x = new int[4]{0,3,4,31};
    int[] y = new int[3]{4,6,30};
    mergerSortedArrays(x,y);
  }

  public static void mergerSortedArrays(int[] arr1, int[] arr2){
    List<int> result = new List<int>(); 

    for(int i = 0; i < arr1.Length; i++){
      result.Add(arr1[i]);
    }

     for(int j = 0; j < arr2.Length; j++){
      result.Add(arr2[j]);
    }

    result.Sort();

    int[] array = result.ToArray();

    for(int a = 0; a< array.Length; a++){
      Console.WriteLine(array[a]);
    }
  }
}