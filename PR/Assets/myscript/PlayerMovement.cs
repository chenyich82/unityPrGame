using UnityEngine;

public class PlayerMovement : MonoBehaviour
{
    //設定角色屬性
    public float moveSpeed = 5f;// 移動速度
    public float runSpeed = 10f;//跑步速度（按 Shift 時）
    public float jumpForce = 7f;//跳要力度（AddForce 的大小）

    //    void Start()

    //     {
    //         //找到名稱為 "Ground" 的物件<用 GameObject.Find() 找物件再改變 Scale>
    //         GameObject ground = GameObject.Find("Ground");
    //         if (ground != null)
    //         {
    //             // 改變地板的縮放
    //             ground.transform.localScale = new Vector3(5f, 1f, 5f);
    //         }
    //         else
    //         {
    //              Debug.LogWarning("找不到名為 'Ground' 的物件！");
    //         }

    //     }
    void Start()
    {
        transform.localScale = new Vector3(5f, 1f, 5f);
    }


}
