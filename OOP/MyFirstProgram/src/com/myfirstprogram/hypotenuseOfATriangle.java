package com.myfirstprogram;

import java.util.Scanner;

public class hypotenuseOfATriangle {
    public static void main(String[] args) {
        double x;
        double y;
        double z;

        Scanner scanner = new Scanner(System.in);

        System.out.println("Enter Side X: ");
        x = scanner.nextDouble();
        System.out.println("Enter Side Y: ");
        y = scanner.nextDouble();

        z = Math.sqrt((x * x) + (y * y)); // formula for hypotenuse
        System.out.println("hypotenuse is : " + z);

        scanner.close();
    }
}
