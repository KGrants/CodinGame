import java.util.*;
import java.io.*;
import java.math.*;


class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int height = in.nextInt();
        int width = in.nextInt();
        String material = in.next();

        System.err.println(height);
        System.err.println(width);
        System.err.println(material);

        for(int i = 0; i < height; i++) {
            for(int j = 0; j < width; j++) 
                System.out.print(material);
            System.out.println("");
        }
    }
}