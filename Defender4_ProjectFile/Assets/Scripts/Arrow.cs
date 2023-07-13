using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    Rigidbody2D rigid;
    public float speed;
    public int damage;

    void Start()
    {
        rigid = GetComponent<Rigidbody2D>();
    }

    void Update()
    {
        transform.Translate(transform.right * speed * Time.deltaTime);
        if(transform.position.x > 8)
        {
            gameObject.SetActive(false);
        }
    }
    
    void OnCollisionEnter2D(Collider2D collider)
    {

    }
}
