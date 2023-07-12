using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class ObjectPool : MonoBehaviour
{
    public GameObject[] Prefebs;

    public enum ObjectType {Arrow = 0, Enemy = 1}
    protected List<GameObject>[] Pools;

    public abstract GameObject Get(int type);
}
