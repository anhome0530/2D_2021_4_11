
using UnityEngine;

public class Enemy : MonoBehaviour
{
    #region 欄位
    [Header("移動速度"), Range(0, 100)]
    public float speed = 1f;
    [Header("攻擊力"), Range(0, 100)]
    public float attack = 10f;
    [Header("血量"), Range(0, 1000)]
    public float hp = 100f;

    private Transform player;
    private Rigidbody2D rig;
    private Animator ani;
    #endregion

    #region
    private void Start()
    {
        ani = GetComponent<Animator>();
        rig = GetComponent<Rigidbody2D>();

        player = GameObject.Find("玩家").transform;

    }
    #endregion
}
