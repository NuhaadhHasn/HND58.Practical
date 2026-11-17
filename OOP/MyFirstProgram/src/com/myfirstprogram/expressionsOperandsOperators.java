package com.myfirstprogram;

public class expressionsOperandsOperators {

    public static void main(String[] args) {
        //    expression = operands & operators
        //    operands = values, variables, numbers, quantity
        //    operators = + _ * / %
        int friends = 10;
        friends = friends + 1;
        System.out.println("friends = friends + 1; " + friends);

        friends = 10;
        friends = friends - 1;
        System.out.println("friends = friends - 1; " + friends);

        friends = 10;
        friends = friends * 2;
        System.out.println("friends = friends * 2; " + friends);

        friends = 10;
        friends = friends / 2;
        System.out.println("friends = friends / 2; " + friends);

        friends = 10;
        friends = friends % 3;
        System.out.println("friends = friends % 3; " + friends);

        friends = 10;
        friends++;
        System.out.println("friends++; " + friends);

        friends = 10;
        friends--;
        System.out.println("friends--; " + friends);

        double friend = 10;
        friend = (double) friend / 3;
        System.out.println("(Double) friend = friend / 3; " + friend);
    }
}
