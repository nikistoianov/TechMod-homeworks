package com.company;

import java.util.Scanner;

public class BooleanVariable {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String input = scan.nextLine();
        boolean result = Boolean.valueOf(input);
        if (result) {
            System.out.println("Yes");
        } else {
            System.out.println("No");
        }
    }

}
