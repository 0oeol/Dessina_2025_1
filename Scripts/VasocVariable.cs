using System.Collections;
using System.Collections.Generic;
using Unity.Collections;
using UnityEngine;

public class VasocVariable : MonoBehaviour
{
    public int gold = 0;
    public float Hp = 100.0f;
    public string PlayerName = "ȫ�浿";
    public bool isAlive = true;


    // Start is called before the first frame update
    void Start()
    {
        // == �� ���� ���� �� true
        // != �� ���� �ٸ��� true
        if (gold > 50)
        {
            Debug.Log("�������� ������ �� �ֽ��ϴ�.");
        }
        else if (gold == 40)
        {
            Debug.Log("��带 40�� ���� ���Դϴ�. 10 ��常 �� ������ �� �� �ֽ��ϴ�.");
        }
        // else //if ���� ������ ���� �ƴ� ��
        //{
           //Debug.Log("��尡 �����մϴ�.")
       //
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyUp(KeyCode.Space))
        {
            gold = gold + 10;
            Debug.Log("���� ��� : " + gold);
        }

        
    }
}
