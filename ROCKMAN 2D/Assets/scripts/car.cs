using UnityEngine;

public class car : MonoBehaviour
{
    // 單行註解
    /*
     * 第一行
     * 第二行
     * 
     */

    // 物件資料 - 欄位 Field:
    // 欄位的語法
    // 類型 名稱 結尾
    // 整  數 int : 正負整數
    // 浮點數 float : 有小數點的正負數值，結尾要加 f (大小寫皆可)
    // 字  串 string : 任何文字，必須使用雙引號
    // 布林值 bool : 正反 true false

    // 關鍵字 藍色 自訂名稱 白色

    // 修飾詞
    // 私人 : 不顯示 private (預設值)
    // 公開 : 顯  示 public

    // 欄位屬性語法
    // [屬性名稱(屬性內容)]
    // 標題 Header(字串)
    // 提示 Tooltip(字串)
    // 範圍 Range(最小值，最大值) - 限定數值類型
    
    [Header("汽車的 CC 數")]
    [Tooltip("這是汽車的cc數。")]
    [Range(1000, 5000)]
    //逗號後面空格可有可無

    public int cc = 2000;
    [Header("汽車重量")]
    public float weight = 1.5f;
    [Header("汽車品牌")]
    public string brand = "BNW";
    [Header("有沒有天窗")]
    public bool hasWindow = true;

    // unity 常見類型
    // 顏色 Color
    public Color Color;
    public Color red = Color.red;
    public Color Y = Color.yellow;
    // 指定顏色的 (R, G, B, A) 值為0到1

    

}
