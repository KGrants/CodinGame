import java.util.*;

class Solution {

    public static void main(String args[]) {
        Scanner in = new Scanner(System.in);
        int N = in.nextInt();
        if (in.hasNextLine()) {
            in.nextLine();
        }
        for (int i = 0; i < N; i++) {
            String line = in.nextLine();
            int a = 0;
            for (int j = 0; j < line.length(); j++) 
            {
                if (line.charAt(j)=='f')
                {
                    j = j + 2;
                    a = a + 1;
                }
            }
        System.out.println(a);
        }
    }
}