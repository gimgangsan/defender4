using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Castle : HealthObject
{
    private void Update()
    {
        /*
        if (Input.GetKeyDown(KeyCode.Space))
        {
            TakeDamage(100);
        }
        */
    }

    public override void Die()
    {
        Debug.Log("¼º »Ñ¼ÅÁü. °ÔÀÓ¿À¹ö Ã¢ ¶ç¿ì±â°¡ ÇÊ¿äÇÔ");
        base.Die();
    }
}
