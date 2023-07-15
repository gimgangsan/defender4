using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public abstract class Monster : HealthObject
{
    RaycastHit2D ScanObject;
    Rigidbody2D rigid;
    public float AttackRange, WalkSpeed;
    public int HP, Atk;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    // Update is called once per frame
    void Update()
    {
        ScanObject = Physics2D.Raycast(rigid.position, Vector2.left, AttackRange);
        if(ScanObject.transform.CompareTag("Barrier"))
        {
            Attack();
        }
        else
        {
            rigid.velocity = Vector2.left * WalkSpeed;
        }
    }

    public abstract void Attack();
}
