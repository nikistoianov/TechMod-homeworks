package com.company;

import java.util.Scanner;

public class IndexOfLetters {

    public static void main(String[] args) {
        Scanner scan = new Scanner(System.in);
        String word = scan.nextLine();

        char[] alphabet = createAlphabet();

        for (int i = 0; i < word.length(); i++) {
            int index = findIndex(word.charAt(i), alphabet);
            System.out.printf("%s -> %d%n", word.charAt(i), index);
        }

    }

    private static int findIndex(char letter, char[] alphabet) {
        for (int i = 0; i < alphabet.length; i++) {
            if (letter == alphabet[i]) {
                return i;
            }
        }
        return -1;
    }

    private static char[] createAlphabet() {
        char[] result = new char['z' - 'a' + 1];
        char firstChar = 'a';

        for (char i = 'a'; i <= 'z'; i++) {
            result[i - firstChar] = i;
        }

        return result;
    }
}
