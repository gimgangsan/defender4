using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    float angle;
    public float cooltime = 0;
    Vector2 target, mouse;
    PoolManager pool;

    void Start()
    {
        target = transform.position;
        pool = GameObject.Find("PoolManager").GetComponent<PoolManager>();

    }

    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle, Vector3.forward);
        if (Input.GetMouseButton(0))
        {
            if (cooltime <= 0)
            {
                SpawnArrow();
                cooltime = 0.25f;
            }
            
        }
        cooltime -= Time.deltaTime;
    }

    void SpawnArrow()
    {
        Arrow script = pool.Get(1).GetComponent<Arrow>();
        script.Position(this.transform.position);
        script.Rotation(Quaternion.AngleAxis(angle, Vector3.forward));
    }
}
