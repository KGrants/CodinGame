import 'dart:io';
import 'dart:math';

String readLineSync() {
  String? s = stdin.readLineSync();
  return s == null ? '' : s;
}

void main() {
    int N = int.parse(readLineSync());
    for (int i = 0; i < N; i++) 
    {
        int a = 0;
        String line = readLineSync();
        for (int j = 0; j < line.length; j++) 
        {
            if (line[j]=='f')
            {
                a = a + 1;
                j = j + 2;
            }
        }
        print(a);
    }
}