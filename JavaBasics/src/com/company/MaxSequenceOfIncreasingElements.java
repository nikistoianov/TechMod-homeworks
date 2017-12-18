package com.company;

import java.util.Arrays;
import java.util.Scanner;

public class MaxSequenceOfIncreasingElements {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arr = Arrays.stream(scan.nextLine().split(" "))
                .map(Integer::parseInt)
                .mapToInt(i -> i)
                .toArray();

        int bestStart = 0, bestLen = 1, start = 0, len = 1;

        for (int i = 1; i < arr.length; i++)
        {
            if (arr[i] > arr[i - 1])
            {
                len++;
            }
            else
            {
                if (len > bestLen)
                {
                    bestLen = len;
                    bestStart = start;
                }
                start = i;
                len = 1;
            }
        }

        if (len > bestLen)
        {
            bestLen = len;
            bestStart = start;
        }

        for (int i = bestStart; i < bestStart + bestLen; i++)
        {
            System.out.print(arr[i] + " ");
        }
    }
}
