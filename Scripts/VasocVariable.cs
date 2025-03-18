using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class VasocVariable : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string PlayerName = "홍길동";
    public bool isAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        // == 두 값이 같을 때 true
        // != 두 값이 다르면 true
        if (gold > 50)
        {
            Debug.Log("아이템을 구매할 수 있습니다.");
        }
        else if (gold == 40)
        {
            Debug.Log("골드를 40원 보유 중입니다. 10 골드만 더 모으면 살 수 있습니다.");
        }
        // else //if 안의 조건이 참이 아닐 때
        //{
           //Debug.Log("골드가 부족합니다.")
       //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("현재 골드 : " + gold);
        }

        
    }
}
