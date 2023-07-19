using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Castle : HealthObject
{
    public GameObject GameOverMenu;
    public override void Die()
    {
        GameOverMenu.SetActive(true);
        base.Die();
    }

    public void Restart()
    {
        SceneManager.LoadScene(SceneManager.GetActiveScene().buildIndex);
    }
}
