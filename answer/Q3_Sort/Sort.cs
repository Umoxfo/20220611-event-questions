using System.Linq;

public class Sort{
    public static void Main(){
        // ランダムに並べられた重複のない整数の配列
        var array = new int[] { 5, 4, 6, 2, 1, 9, 8, 3, 7, 10 };
        // ソート実行
        var sortedArray = new Sort().SortArray(array);
        // 結果出力
        foreach (int i in sortedArray)
        {
            System.Console.WriteLine(i);
        }
    }

    public int[] SortArray(int[] array){
        // 要素が一つの場合はソートの必要がないので、そのまま返却
        if(array.Length == 1) {
            return array;
        }

        // 配列の先頭を基準値とする
        var pivot = array[0];

        // ここから記述
        // 基準値以上の値のインデックス
        int firstIndex = 0;
        // 基準値未満の値のインデックス
        int lastIndex = array.Length - 1;

        // 先頭から末端に向かって基準値以上の値、逆方向から基準値の値未満を探索し、
        // 見つかったらそれらの値を交換
        do
        {
            // 先頭から探索し、基準値以上の値の探索
            for (int i = firstIndex; i < lastIndex; i++)
            {
                // 基準値以上の値のインデックスを代入
                if (array[i] >= pivot)
                {
                    firstIndex = i;
                    break;
                }
            }

            // 逆方向から基準値の値未満の探索
            bool found = false;
            for (int i = lastIndex; i > firstIndex; i--)
            {
                // 基準値未満の値のインデックスを代入
                if (array[i] < pivot) 
                {
                    lastIndex = i;
                    found = true;
                    break;
                }
            }

            // 基準値以上の値と基準値未満の値を入替
            if (found)
            {
                (array[firstIndex], array[lastIndex]) = (array[lastIndex], array[firstIndex]);
            }

            // 次回の先頭からの探索開始インデックスを設定
            firstIndex++;
            // 次回の末端からの探索開始インデックスを設定
            lastIndex--;
        // 次回の「先頭からの探索」と「末端からの探索」がぶつかる場合、探索を終了
        } while (firstIndex < lastIndex);

        //　基準値未満と基準値以上の境界インデックスを特定
        firstIndex = 1;
        while (array[firstIndex] < pivot)
        {
            firstIndex++;
        }

        //　基準値未満と基準値以上のグループに分け、再帰処理を行う
        int[] smallArr = SortArray(array[..firstIndex]);
        int[] largeArr = SortArray(array[firstIndex..]);

        // ２つのグループ（配列）を結合
        int[] resultArr = new int[array.Length];
        System.Array.Copy(smallArr, resultArr, smallArr.Length);
        System.Array.Copy(largeArr, 0, resultArr, smallArr.Length, largeArr.Length);

        return resultArr;
        // ここまで記述

    }
}
