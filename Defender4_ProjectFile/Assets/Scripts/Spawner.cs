using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Spawner : MonoBehaviour
{
    public GameObject PoolManager;
    public float Spawn_x;
    public float[] Spawn_y;
    private ObjectPool ManagerScript;
    // Start is called before the first frame update
    void Start()
    {
        ManagerScript = PoolManager.GetComponent<ObjectPool>();
        Invoke("Spawn", Random.Range(1, 3));
    }

    // Update is called once per frame
    void Spawn()
    {
        GameObject a = ManagerScript.Get(0);
        a.GetComponent<Monster>().SetPosition(new Vector2(Spawn_x, Spawn_y[Random.Range(0, Spawn_y.Length)]));
        Invoke("Spawn", Random.Range(1, 3));
    }
}
