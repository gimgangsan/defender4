using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class 시험용_스크립트 : MonoBehaviour
{
    float TimeElapsed = 0;

    // Update is called once per frame
    void Update()
    {
        TimeElapsed += Time.deltaTime;

        if(TimeElapsed >= 1)
        {
            gameObject.SetActive(false);
        }
    }

    private void OnEnable()
    {
        TimeElapsed = 0;
    }
}
