using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour//��ʼ����
{
    // ����Ԥ�Ƽ����� Inspector �У���Ԥ�Ƽ��϶������ֶ��С�
    public GameObject myPrefab;
    public GameObject meNode;

    void Start()
    {
        // ʵ����Ϊλ�� (0, 0, 0) ������ת��
        var gameLtle = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        gameLtle.transform.SetParent(meNode.transform);
    }

    void Update()
    {
        
    }
}
