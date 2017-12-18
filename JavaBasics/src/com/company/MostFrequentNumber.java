package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;

public class MostFrequentNumber {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        int[] arr = Arrays.stream(scan.nextLine().split(" "))
                .map(Integer::parseInt)
                .mapToInt(i -> i)
                .toArray();

        ArrayList<Integer> numbers = new ArrayList<Integer>();
        ArrayList<Integer> counts = new ArrayList<Integer>();
        int maxCount = 1;

        for (int item : arr) {
            int id = numbers.indexOf(item);
            if (id > -1) {
                counts.set(id, counts.get(id) + 1);
                maxCount = Math.max(maxCount, counts.get(id));
            } else {
                numbers.add(item);
                counts.add(1);
            }
        }

        int closerLeft = counts.indexOf(maxCount);
        System.out.println(numbers.get(closerLeft));
    }
}
