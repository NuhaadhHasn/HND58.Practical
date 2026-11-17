public class InsertionSort {
    public static void main(String args[]) {
        int[] arr = {56, 34, 23, 45, 67, 89, 12};
        insertionSortEx(arr);
    }

    public static void insertionSortEx(int arr[]) {
        int in, out;
        for (out = 1; out < arr.length; out++) {
            int temp = arr[out];
            in = out;
            while (in > 0 && arr[in - 1] >= temp) {
                arr[in] = arr[in - 1];
                --in;
            }
            arr[in] = temp;

            for (int i : arr) {
                System.out.print(i + " ");
            }
        }
    }
}
