using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class HealthObject : MonoBehaviour
{
    [SerializeField]
    private Slider HealthBar;

    public float MaxHP;
    protected float CurrentHP;
    // Start is called before the first frame update
    void OnEnable()
    {
        CurrentHP = MaxHP;
        HealthBar.maxValue = MaxHP;
        HealthBar.value = CurrentHP;
    }

    public void TakeDamage(float damage)
    {
        CurrentHP -= damage;
        HandleHpBar();

        if(CurrentHP <= 0)
        {
            Die();
        }
    }

    private void HandleHpBar()
    {
        HealthBar.value = CurrentHP;
    }

    public virtual void Die()
    {
        gameObject.SetActive(false);
    }
}
