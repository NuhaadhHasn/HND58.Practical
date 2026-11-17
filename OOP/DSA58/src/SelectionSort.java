public class SelectionSort {
    public static void main(String args[]) {
        int[] arr = {56, 34, 23, 45, 67, 89, 12};
        selectionSort(arr);
    }

    private static void selectionSort(int arr[]) {
        int out, in, min;

        for (out = 0; out < arr.length - 1; out++) {
            min = out;
            for (in = out + 1; in < arr.length; in++) {
                if (arr[in] < arr[min])
                    min = in;
            }
            int temp = arr[out];
            arr[out] = arr[min];
            arr[min] = temp;
        }
        for (int i : arr) {
            System.out.print(i + " ");
        }
    }
}


