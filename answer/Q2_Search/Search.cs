public class Search{
    public static void Main(){
        // 昇順にソートされた配列
        var sortedArray = new int[] {1, 2, 3, 5, 12, 7890, 12345};
        // 探索対象の番号
        var targetNumber = 7890;
        // 探索実行
        var targetIndex = new Search().SearchIndex(sortedArray, targetNumber);
        // 結果出力
        System.Console.WriteLine(targetIndex);
    }

    private int SearchIndex(int[] sortedArray, int targetNumber){

        // ここから記述
        // 探索対象配列の中間インデックス
        int midIndex = sortedArray.Length / 2;
        do
        {
            // 探索対象配列の中間値
            int midValue = sortedArray[midIndex];

            // 探索対象と中間値が一致した場合、インデックスを返す。
            if (midValue == targetNumber) return midIndex;

            // 新しい探索範囲の中間インデックスのオフセット値を算出
            int offset = (sortedArray.Length - midIndex) / 2;

            // 中間値より探索対象が小さい場合
            if (midValue > targetNumber)
            {
                // 中間値より小さい範囲の中間インデックスを算出。
                midIndex -= offset;
            }
            // 中間値より探索対象が大きい場合
            else
            {
                // 中間値より大きい範囲の中間インデックスを算出。
                midIndex += offset;
            }
        // 中間インデックスが配列の範囲を超える場合、探索を中断
        } while (0 < midIndex && midIndex < sortedArray.Length);
        // ここまで記述

        // 探索対象がない場合、-1を返す
        return -1;
    }
}
