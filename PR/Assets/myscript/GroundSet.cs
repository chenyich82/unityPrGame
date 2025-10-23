using UnityEngine;

public class GroundSet : MonoBehaviour
{
    void Start()
    {
        transform.localScale = new Vector3(5f, 1f, 5f);
    }
    //void Start()

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
}