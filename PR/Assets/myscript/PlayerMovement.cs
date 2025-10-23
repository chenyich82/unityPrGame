using UnityEditor.Callbacks;
using UnityEngine;
using UnityEngine.Scripting.APIUpdating;

public class PlayerMovement : MonoBehaviour
{
    //設定角色屬性
    public float moveSpeed = 5f;// 移動速度
    public float runSpeed = 10f;//跑步速度（按 Shift 時）
    public float jumpForce = 7f;//跳要力度（AddForce 的大小）

    private Rigidbody rb;    // 角色的剛體，控制物理移動
    private bool isGrounded = true;// 是否在地面上（用來判斷能否跳）<isGrounded 
    // 用來防止「在空中無限跳」。>
    void Start()
    {
        rb = GetComponent<Rigidbody>();
        //在遊戲開始時，從角色身上抓取 Rigidbody 元件（確保角色能用物理運動）。

    }
    void Update()//每一幀都檢查玩家是否在按方向鍵或空白鍵。
    {
        Move();
        jump();

    }
    void Move()
    {

    }
    void jump()
    {
        
    }




}
