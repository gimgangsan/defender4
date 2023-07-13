using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    float angle;
    Vector2 target, mouse;
    void Start()
    {
        target = transform.position;

    }

    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        if (Input.GetMouseButtonDown(0))
        {
            SpawnArrow();
        }
    }
    void SpawnArrow()
    {

    }
}
