using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Arrow : MonoBehaviour
{
    public float speed;
    Rigidbody2D rigid;

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
    
    public void Position(Vector2 position)
    {
        transform.position = position;
    }
    public void Rotation(Quaternion rotation)
    {
        transform.rotation = rotation;
    }
    void OnCollisionEnter2D(Collision2D collision)
    {
        gameObject.SetActive(false);
    }
}
