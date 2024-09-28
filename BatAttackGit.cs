using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class BatAttackGit : MonoBehaviour
{
    public bool alreadyHit;
    private bool inRange;

    // Start is called before the first frame update
    void Start()
    {

    }

    // Update is called once per frame
    void Update()
    {
        if (inRange == true)
        {
            if (alreadyHit == false)
            {
                Attack(GameObject.FindGameObjectWithTag("PlayerBox").GetComponentInParent<PlayerHealth>());
            }
            Invoke("Wait", 5.0f);
        }
    }



    public void Attack(PlayerHealth player)
    {
        player.health -= 1;
        alreadyHit = true;
    }

    public void Wait()
    {
        alreadyHit = false;
    }


    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            inRange = true;

        }
    }
    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("PlayerBox"))
        {
            inRange = false;

        }
    }

}
