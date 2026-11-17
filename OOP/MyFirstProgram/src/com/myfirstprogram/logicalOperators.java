package com.myfirstprogram;

import java.util.Scanner;

public class logicalOperators {
    public static void main(String[] args) {

        // Logical Operators = used to connect two or more expressions
        //
        //      && = (AND) Both conditions must be true
        //      || = (OR) ANy of the conditions should be true
        //       ! = (NOT) reverses boolean value of a condition

        int temperature = 25;

        if (temperature > 30) {
            System.out.println("It is hot outside");
        } else if (temperature >= 20 && temperature <= 30) {
            System.out.println("It is warm outside");
        } else {
            System.out.println("It is cold outside");
        }

        Scanner scanner = new Scanner(System.in);

        System.out.println("You are playing a game ! Press q or Q to quit!");
        String response = scanner.next();

        if (response.equals("q") || response.equals("Q")) {
            System.out.println("You quit the game!");
        } else {
            System.out.println("Your are still playing the game \"*pew pew*\"");
        }

        Scanner scn = new Scanner(System.in);

        System.out.println("You are playing a game ! Press q or Q to quit!");
        String resp = scn.next();

        if (!resp.equals("q") && !resp.equals("Q")) {
            System.out.println("Your are still playing the game \"*pew pew*\"");
        } else {
            System.out.println("You quit the game!");
        }
    }
}
