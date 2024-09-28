using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class PlayerHealthGit : MonoBehaviour
{
    public float fullHealth = 10.0f;
    public float health = 3.0f;
    public int respawn;


    // Start is called before the first frame update
    void Start()
    {
        HealthBar.healthBar.maxium = fullHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if (health <= 0)
        {
            SceneManager.LoadScene(respawn);
        }

        HealthBar.healthBar.getHP(health);
    }



}
