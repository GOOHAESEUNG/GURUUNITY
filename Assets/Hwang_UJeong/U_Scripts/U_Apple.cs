/*using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class U_Apple : MonoBehaviour
{
    private void OnTriggerEnter(Collider collision)
    {
        if (collision.tag == "Player")
        {
            GameObject smObject = GameObject.Find("ScoreManager");
            ScoreManager sm = smObject.GetComponent<ScoreManager>();
            sm.appleAmount += 1; //��� ȹ�� �� ȹ� 1 ����
            sm.appleAmountUI.text = "ȹ�� ���: " + sm.appleAmount;

            Destroy(gameObject);//����� ������ ��� ����

            Sfx.SoundPlay();//��� ȹ�� �� ȿ���� �߻�
        }
    }

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {

    }
}*/