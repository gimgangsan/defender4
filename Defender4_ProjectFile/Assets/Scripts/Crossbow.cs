using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Crossbow : MonoBehaviour
{
    float angle;
    Vector2 target, mouse;
    Arrow arrow;

    void Start()
    {
        target = transform.position;
        arrow = GameObject.Find("Arrow").GetComponent<Arrow>();
    }

    void Update()
    {
        mouse = Camera.main.ScreenToWorldPoint(Input.mousePosition);
        angle = Mathf.Atan2(mouse.y - target.y, mouse.x - target.x) * Mathf.Rad2Deg;
        this.transform.rotation = Quaternion.AngleAxis(angle - 90, Vector3.forward);
        if (Input.GetMouseButton(0))
        {
            if (arrow.speed < 10)
            {
                arrow.speed += Time.deltaTime;
            }
            else
            {
                arrow.speed = 10;
            }
        }
        else if (Input.GetMouseButtonUp(0))
        {
            SpawnArrow();
        }
            
    }
    void SpawnArrow()
    {

    }
}
