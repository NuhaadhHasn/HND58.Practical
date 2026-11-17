import java.util.Stack; // Method 2

public class StackX {
    private int maxSize;
    private long[] stackArray;
    private int top;

    public StackX(int s) {
        maxSize = s;
        stackArray = new long[maxSize];
        top = -1;
    }

    public void push(long j) {
        stackArray[++top] = j;
    }

    public long pop() {
        return stackArray[top--];
    }

    public long peek() {
        return stackArray[top];
    }

    public boolean isEmpty() {
        return (top == -1);
    }

    public boolean isFull() {
        return (top == maxSize - 1);
    }

    public static void main(String[] args) {
        StackX theStack = new StackX(10); // Method 1
        theStack.push(20); // Method 1
        theStack.push(40); // Method 1
        theStack.push(60); // Method 1
        theStack.push(80); // Method 1

        while (!theStack.isEmpty()) {
            long value = theStack.pop();
            System.out.println(value);
        }// Method 1

//        Stack<Integer> st = new Stack<Integer>(); // Method 2
//        st.push(20); // Method 2
//        st.push(40); // Method 2
//        st.push(60); // Method 2
//        st.push(80); // Method 2
//
//        while (!st.isEmpty()) {
//            System.out.println(st.pop());
//        } // Method 2
    }
}
