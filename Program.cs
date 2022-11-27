using System;

public class HeapPermutations{
    
    static void print_array(int[] array, int n){
        for (int i = 0; i < n; i++)        
            Console.WriteLine(array[i] + " ");                    
        Console.WriteLine();
    }

/*
** digits: are all symbols or characters for build the password.
**      n: is the size of password.
*/
    static void heap_permutation(int[] array, int digits, int n){
        if(digits == 1)
            print_array(array, n);
        
        for (int i = 0; i < digits; i++)
        {
            Console.Write(n + 1 + ", ");
            heap_permutation(array, digits-1, n);
            if(digits%2 == 1){
                int temp = array[0];
                array[0] = array[digits - 1];
                array[digits - 1] = temp;
            }else{
                int temp = array[i];
                array[i] = array[digits - 1];
                array[digits - 1] = temp;
            }
        }
    }

    public static void Main(){
        int [] array = {0,1,2,3,4,5,6,7,8,9};
        heap_permutation(array, 3, 2);
    }
}