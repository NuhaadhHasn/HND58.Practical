package com.myfirstprogram;

import java.util.Scanner;

public class scanner {
    public static void main(String[] args) {
        Scanner scanner = new Scanner(System.in);

        System.out.println("What Is Your Name : ");
        String name = scanner.nextLine();
        System.out.println("What Age : ");
        int age = scanner.nextInt();
        scanner.nextLine();
        System.out.println("What Is Your favorite food : ");
        String food = scanner.nextLine();
        
        System.out.println("Hello " + name);
        System.out.println("You are " + age + " years old");
        System.out.println("You like " + food);
    }
}
