package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class EqualSums {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arr = Arrays.stream(scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        for (int i = 0; i < arr.length; i++) {
            long leftSum = calcLeftSum(arr, i - 1);
            long rightSum = calcRightSum(arr, i + 1);
            if (leftSum == rightSum) {
                System.out.println(i);
                return;
            }
        }
        System.out.println("no");
    }

    private static long calcRightSum(int[] arr, int fromIndex)
    {
        long sum = 0;
        for (int i = fromIndex; i < arr.length; i++) {
            sum += arr[i];
        }
        return sum;
    }

    private static long calcLeftSum(int[] arr, int toIndex)
    {
        long sum = 0;
        for (int i = 0; i <= toIndex; i++) {
            sum += arr[i];
        }
        return sum;
    }
}
