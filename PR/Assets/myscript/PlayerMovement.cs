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
        float moveX = Input.GetAxis("Horizontal");//水平移動ＡＤ
        float moveZ = Input.GetAxis("Vertical");//垂直移動ＷＳ

        Vector3 move = new Vector3(moveX, 0, moveZ).normalized;
        //計算移動方向與標準化：建立一個移動方向向量。.normalized 讓方向的長度永遠是 1，避免斜著走比直走快。

        float currentSpeed = Input.GetKey(KeyCode.LeftShift) ? runSpeed : moveSpeed;
        //檢查是否按下Shift鍵來決定移動速度如果按下 左 Shift，就用跑步速度，否則用走路速度。

        Vector3 moveVelocity = transform.TransformDirection(move) * currentSpeed;
        //將本地方向轉換爲世界方向，並乘以速度。

        Vector3 newPosition = rb.position + moveVelocity * Time.deltaTime;
        //計算新的位置：用剛體的當前位置加上移動速度乘以時間增量（Time.deltaTime確保移動是平滑的）
        rb.MovePosition(newPosition);
        //移動剛體到新位置


    }
    void jump()
    {
        
    }




}
