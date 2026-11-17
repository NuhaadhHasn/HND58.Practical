public class bubbleSortEx {
    public static void main(String[] args) {
        int[] arr = {12, 5, 4, 56, 78, 22};
        bubbleSort(arr);
    }

    private static void bubbleSort(int[] arr) {
        int out, in;
        for (out = arr.length - 1; out > 1; out--) {
            for (in = 0; in < out; in++) {
                if (arr[in] > arr[in + 1]) {
                    int temp = arr[in];
                    arr[in] = arr[in + 1];
                    arr[in + 1] = temp;
                }
            }
        }

        for (int i : arr) {
            System.out.println(i + " ");
        }
    }
}
