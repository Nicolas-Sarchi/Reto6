static int findLongestSubsequence (int[] array){
    for (int i = 0;i < array.Length;i++){
        if (array[i] <0 || array[i] > Math.Pow(10,9)){
            return -1;
        }
    }
    if(array.Length < 3 || array.Length > Math.Pow(10, 5)){
        return -1;
    }

    else{
        int sum = 0;
        Array.Sort(array);
        for (int i = 1;i  < array.Length;i++){
            sum += array[i] - array[i-1];
        }
        
        if (sum %2 == 0){
            return sum;
        }
        else {
            
        }
    }
   
}


 // 3C2 = 4! / 3! (4-3)!

int [] array = {2,4,1,7};
Console.WriteLine(findLongestSubsequence(array));