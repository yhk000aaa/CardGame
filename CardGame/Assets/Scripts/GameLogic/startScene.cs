using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class startScene : MonoBehaviour//开始场景
{
    // 引用预制件。在 Inspector 中，将预制件拖动到该字段中。
    public GameObject myPrefab;
    public GameObject meNode;

    void Start()
    {
        // 实例化为位置 (0, 0, 0) 和零旋转。
        var gameLtle = Instantiate(myPrefab, new Vector3(0, 0, 0), Quaternion.identity);
        gameLtle.transform.SetParent(meNode.transform);
    }

    void Update()
    {
        
    }
}
