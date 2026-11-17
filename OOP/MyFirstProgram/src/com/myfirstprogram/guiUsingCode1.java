package com.myfirstprogram;

import javax.swing.JOptionPane;

public class guiUsingCode1 {
    public static void main(String[] args) {
        String name = JOptionPane.showInputDialog("Enter Your Name");
        JOptionPane.showMessageDialog(null, "Hello " + name);
        System.out.println(name);

        int age = Integer.parseInt(JOptionPane.showInputDialog("Enter Your Age"));
        JOptionPane.showMessageDialog(null, name + ", You are " + age + " years old");

        double height = Double.parseDouble(JOptionPane.showInputDialog("Enter Your Height(cm)"));
        JOptionPane.showMessageDialog(null, name + ", You are " + height + "cm tall");

    }
}
