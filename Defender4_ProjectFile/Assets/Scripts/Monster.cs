using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;

public class Monster : HealthObject
{
    RaycastHit2D ScanObject;
    Rigidbody2D rigid;
    Animator animator;
    float Timer = 0;

    public float AttackRange, WalkSpeed, AttackTerm;
    public int Atk;

    // Start is called before the first frame update
    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
        animator = GetComponent<Animator>();
    }

    // Update is called once per frame
    void Update()
    {
        Debug.DrawRay(rigid.position, Vector2.left);
        ScanObject = Physics2D.Raycast(rigid.position, Vector2.left, AttackRange, LayerMask.GetMask("Barrier"));

        if(ScanObject.collider == null)
        {
            animator.SetBool("Walk", true);
            rigid.velocity = Vector2.left * WalkSpeed;
        }
        else if(Timer <= 0)
        {
            Attack();
        }
        else
        {
            Timer -= Time.deltaTime;
        }
    }

    public void Attack()
    {
        rigid.velocity = Vector2.zero;
        animator.SetBool("Walk", false);
        animator.SetTrigger("Attack");
        Timer = AttackTerm;
    }
}
