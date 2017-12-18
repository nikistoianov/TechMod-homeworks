package com.company;

import java.util.Scanner;

public class VowelOrDigit {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String s = scan.nextLine();
        if (s.equals("a") || s.equals("o") || s.equals("e") || s.equals("i") || s.equals("u")) {
            System.out.println("vowel");
        } else if (s.equals("1") || s.equals("2") || s.equals("3") || s.equals("4") || s.equals("5") || s.equals("6") || s.equals("7") || s.equals("8") || s.equals("9") || s.equals("0")) {
            System.out.println("digit");
        } else {
            System.out.println("other");
        }

    }
}
