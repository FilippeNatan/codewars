using System;

WeightSort.orderWeight("56 65 74 100 99 68 86 180 90");

public class WeightSort {
	
	public static string orderWeight(string strng) {
		//Dictionary<int, string> oWDicionary = new Directory<int, string>();

        strng = strng.Replace(" ",";");
        int[] arrayInt = strng.Split(';').Select(n => Convert.ToInt32(n)).ToArray();
        int sum = 0;
        int[] listSum = {};
        int count = 0;

        foreach(int numNow in arrayInt)
        {
            int n = numNow;
            while(n != 0)
            {
                sum += n % 10;
                n /= 10;
            }
            listSum[count] = sum;
            count++;
        }
        Console.WriteLine(listSum[2]);

        return strng;
	}
}