namespace Monday.Funcs;

public static class Class1
{
    // ! Assumptions
    // * Both arrays are sorted
    // * Both arrays are ints
    public static double GetMedian(in int[] a, in int[] b){
        int aN = a.Length;
        int bN = b.Length;
        int tempN = aN+bN;
        int[] temp = new int[tempN];

        // * Merge the arrays into temp
        // Merge iterates through both arrays, so time complexity of the merge is O(aN + bN)
        int i=0; //iterator for array a
        int j=0; //iterator for array b
        int k=0; //iterator for temp array
        while (i<aN && j<bN){
            //compare a[i] to b[j]
            //if b[j] is lesser, add b[j] and increment j
            if (a[i] < b[j]) temp[k++] = a[i++];
            else temp[k++] = b[j++];
        }

        //If both arrays are different size, add from whichever array is left
        //if a was longer, store the rest in a
        while (i<aN) {
            temp[k++] = a[i++];
        }

        //if b was longer, store the rest in b
        while (j<bN){
            temp[k++] = b[j++];
        }

        double med = 0.0;
        //Both arrays are sorted so median lookup is constant (can be calculated)

        //arrays now merged, find the median
        //if temp's length is even, median is the average of temp[n/2] and temp[(n/2)-1]
        if (tempN % 2 == 0){
            int nOverTwo = tempN/2;
            double L = (double) temp[nOverTwo];
            double R = (double) temp[nOverTwo-1];
            med = (L+R) / 2;
        }
        //if temp's length is odd, median is temp[(n-1)/2]
        else med = (double) temp[(tempN-1)/2];

        return med;
    }

    
}
