package testForStudent1;

import java.util.Scanner;

public class Main {
    public final static int max = 50;
    public static int[] que = new int[max];
    public static int front = -1, rear = -1;

    public static void enqueue(int data) {
        if (rear == max - 1) {
            System.out.println("Que Is Full!");
        } else {
            rear = rear + 1;
            que[rear] = data;
            if (front == -1) {
                front = 0;
            }
        }
    }

    public static void disp() {
        System.out.println("The Elements in the Queue");
        if (front == -1) {
            System.out.println("Que is empty");
        } else {
            for (int i = front; i <= rear; i++) {
                System.out.println(que[i] + " ");
            }
        }
        System.out.println();
    }

    public static void main(String[] args) {
        int data, size;
        System.out.println("Enter the Size of the Queue");
        size = STDIN_SCANNER.nextInt();
        {
            for (int i = 0; i < size; i++) {
                System.out.println("Enter Data to Queue");
                data = STDIN_SCANNER.nextInt();
                System.out.println("Enqueuing" + data);
                enqueue(data);
                disp();
            }
        }
    }

    public final static Scanner STDIN_SCANNER = new Scanner(System.in);

}
