package com.myfirstprogram;

import java.util.Random;

public class generateRandomValue {
    public static void main(String[] args) {
        Random random = new Random();

        int w = random.nextInt(10); // generate numbers between 0 to the value
        System.out.println(w);
        int x = random.nextInt(-600, 600); // generate numbers between values
        System.out.println(x);
        double z = random.nextDouble(); // generate numbers between 0 and 1 if no bound and origin value are defined
        System.out.println(z);
        boolean y = random.nextBoolean(); // generate true or false
        System.out.println(y);

    }
}
