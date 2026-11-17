public class LinearSearchEx {
    public static void main(String[] args) {
        int[] arr = {12, 34, 56, 11, 8, 55, 89};
        int searchItem = 55;
        if (linearSearch(arr, searchItem)) {
            System.out.println("Found");
        } else {
            System.out.println("Not Found");
        }
    }

    private static boolean linearSearch(int[] arr, int searchItem) {
        for (int i : arr) {
            if (i == searchItem) {
                return true;
            }
        }
        return false;
    }
}
