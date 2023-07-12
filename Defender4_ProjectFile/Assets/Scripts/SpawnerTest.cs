using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SpawnerTest : MonoBehaviour
{
    public GameObject PoolManager;
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
            a.transform.position = new Vector2(Random.Range(-5.0f, 5.0f), Random.Range(-5.0f, 5.0f));
        }
    }
}
