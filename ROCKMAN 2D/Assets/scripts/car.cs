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
    public Color mycolor = new Color(0.3f, 0, 0.6f);
    public Color mycolor2 = new Color(0, 0.5f, 0.5f, 0.5f);

    // 座標二維-四維 Vector2 3 4
    public Vector2 v2;
    public Vector2 v2zero = Vector2.zero;
    public Vector2 v2one = Vector2.one;
    public Vector2 v2my = new Vector2(7, 9);

    public Vector3 v3 = new Vector3(1, 2, 3);
    public Vector4 v4 = new Vector4(1, 2, 3, 4);

    // 按鍵 KeyCode 
    public KeyCode key1;
    public KeyCode key2 = KeyCode.A;
    public KeyCode key3 = KeyCode.Mouse1;
    public KeyCode key4 = KeyCode.Joystick1Button0;


    // 遊戲物件 與 元件
    // 遊戲物件 GameObject
    public GameObject obj1;
    public GameObject obj2;
    // 元件 Component - 屬性面板可摺疊的
    // 名稱去掉空格
    public Transform tra;                        // 儲存包含 Transform 元件的物件
    public SpriteRenderer spr;                   // 儲存包含 SpriteRenderer 元件的物件



}
