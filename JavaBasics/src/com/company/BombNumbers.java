package com.company;

import java.util.ArrayList;
import java.util.Arrays;
import java.util.Scanner;
import java.util.stream.Collectors;
import java.util.stream.DoubleStream;
import java.util.stream.IntStream;

public class BombNumbers {

    public static void main(String[] args) {

        Scanner scan = new Scanner(System.in);
        int[] arri = Arrays.stream(scan.nextLine().split(" "))
                .mapToInt(Integer::parseInt)
                .toArray();

        ArrayList<Integer> nums = IntStream.of(arri).boxed().collect(Collectors.toCollection(ArrayList::new));

        String[] arr = scan.nextLine().split(" ");
        int bombNumber = Integer.parseInt(arr[0]);
        int power = Integer.parseInt(arr[1]);

        boolean listDetonated = true;

        while (listDetonated)
        {
            listDetonated = detonateList(nums, bombNumber, power);
        }

        int sum = sumListElements(nums);
        System.out.println(sum);
    }

    static int sumListElements(ArrayList<Integer> nums) {
        int sum = 0;
        for (double num : nums) {
            sum += num;
        }
        return sum;
    }

    static boolean detonateList(ArrayList<Integer> nums, int bombNumber, int power) {
        int foundID = nums.indexOf(bombNumber);
        if (foundID == -1) {
            return false;
        } else {
            int removeFrom = Math.max(0, foundID - power);
            int removeTo = Math.min(nums.size() - 1, foundID + power);
            nums.subList(removeFrom, removeTo + 1).clear();
            return true;
        }

    }
}
