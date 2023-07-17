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
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.Space))
        {
            GameObject a = ManagerScript.Get(0);
            a.transform.position = new Vector2(Spawn_x, Spawn_y[Random.Range(0, Spawn_y.Length)]);
        }
    }
}
