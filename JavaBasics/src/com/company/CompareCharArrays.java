package com.company;

import java.util.Scanner;

public class CompareCharArrays {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        String arr1[] = scan.nextLine().split(" ");
        String arr2[] = scan.nextLine().split(" ");

        int min = Math.min(arr1.length, arr2.length);
        for (int i = 0; i < min; i++) {
            int compare = arr1[i].compareTo(arr2[i]);
            if (compare < 0) {
                printArrays(arr1, arr2);
                return;
            } else if (compare > 0) {
                printArrays(arr2, arr1);
                return;
            }
        }

        if (arr1.length > arr2.length) {
            printArrays(arr2, arr1);
        } else {
            printArrays(arr1, arr2);
        }
    }

    public static void printArrays(String firstArr[], String secondArr[]) {
        System.out.println(String.join("", firstArr));
        System.out.println(String.join("", secondArr));
    }
}
