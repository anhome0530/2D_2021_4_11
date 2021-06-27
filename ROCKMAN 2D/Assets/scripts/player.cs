using UnityEngine;

public class player : MonoBehaviour
{
    [Header("移動速度"), Range(0, 1000)]
    public float speed = 10.5f;
    [Header("跳越高度"), Range(0, 3000)]
    public int height = 100;
    [Header("血量"), Range(0, 200)]
    public float blood = 100;
    [Header("是否在地板上"), Tooltip ("儲存角色是否在地板上")]
    public bool onLand;
    [Header("子彈"), Tooltip("角色要發射的子彈物件")]
    public GameObject bullet;
    [Header("子彈生成點"), Tooltip("生成子彈的位子")]
    public Transform bulletPoint;
    [Range(0, 5000)]
    public int bulletSpeed = 800;
    [Header("開槍音效"), Tooltip("開槍的聲音")]
    public AudioClip bulletSound;

    private AudioSource aud;
    private Rigidbody2D rig;
    private Animator ani;











}

public class LearnLerp : MonoBehaviour 
{
    public float a = 0;
    public float b = 10;
    public float posCam = 0;
    public float posPla = 100;
    public Vector3 vCam = new Vector3(0, 0, 0);
    public Vector3 vPla = new Vector3(100, 100, 100);

    private void Start()
    {
        // 認識插值  Lerp
        float r = Mathf.Lerp(a, b, 0.5f);
        print("a 與 b 中間值 :" + r);
    }

    private void Update()
    {
        posCam = Mathf.Lerp(posCam, posPla, 0.5f);

        vCam = Vector3.Lerp(vCam, vPla, 0.5f);

    }
}
 