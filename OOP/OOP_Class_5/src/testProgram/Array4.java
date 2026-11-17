package testProgram;

import java.util.Scanner;

public class Array4 {
    public static void main(String[] args) {
        Scanner sc = new Scanner(System.in);

        int[] marks;
        marks = new int[4];

        for (int i = 0; i < marks.length; i++) {
            System.out.println("Enter Marks : ");
            marks[i] = sc.nextInt();
        }

        for (int j : marks) {
            System.out.println(j);
        }
    }
}
