public class FizzBuzz{
    public static void Main(){
        for (int i = 1; i <= 100; i++) {

            var str = "";

            // ここから記述

            // 15の倍数のときは、"FizzBuzz"を代入。
            if (i % 15 == 0)
            { 
                str = "FizzBuzz";
            }
            // 3の倍数のときは、"Fizz"を代入。
            else if (i % 3 == 0)
            {
                str = "Fizz";
            }
            // 5の倍数のときは、"Buzz"を代入。
            else if (i % 5 == 0)
            {
                str = "Buzz";
            }
            // いずれかにも当てはまらない場合、数字を代入。
            else
            {
                str = i.ToString();
            }

            // ここまで記述

            System.Console.WriteLine(str);
        }
    }
}
