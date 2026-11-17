public class binarySearchEx {
    public static void main(String[] args) {
        int[] arr = {12, 34, 56, 71, 89, 95, 100};
        int searchItem = 555;
        if (binarySearch(arr, searchItem)) {
            System.out.println("Found");
        } else {
            System.out.println("Not Found");
        }
    }

    private static boolean binarySearch(int[] arr, int searchItem) {
        int lower = 0;
        int upper = arr.length - 1;
        int mid;

        while (true) {
            mid = (lower + upper) / 2;
            if (arr[mid] == searchItem) {
                return true;
            } else if (lower > upper) {
                return false;
            } else {
                if (arr[mid] < searchItem) {
                    lower = mid + 1;
                } else {
                    upper = mid + 1;
                }
            }
        }
    }
}
