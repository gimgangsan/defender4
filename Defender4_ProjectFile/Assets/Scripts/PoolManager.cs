using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PoolManager : ObjectPool
{
    private void Awake()
    {
        Pools = new List<GameObject>[Prefebs.Length];
        for(int i = 0; i < Prefebs.Length; i++)
        {
            Pools[i] = new List<GameObject>();
        }
    }

    public override GameObject Get(int type)
    {
        GameObject result = null;
        
        // ���� �����Ǿ����� ��� �ִ� ������Ʈ�� �ִٸ� ��ȯ
        foreach(GameObject item in Pools[type])
        {
            if(item.activeSelf == false)
            {
                result = item;
                item.SetActive(true);
                return result;
            }
        }

        // ��� �ִ� ������Ʈ�� ���ٸ� ���� ������ ��ȯ
        result = Instantiate(Prefebs[type]);
        result.transform.parent = gameObject.transform;
        Pools[type].Add(result);
        return result;
    }
}
