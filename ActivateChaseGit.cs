using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ActivateChaseGit : MonoBehaviour
{
    private Animator enemy;

    // Start is called before the first frame update
    void Start()
    {
        enemy = gameObject.GetComponentInParent<Animator>();
    }
    private void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("PlayerVis"))
        {
            IdolBehaviour idol = enemy.GetBehaviour<IdolBehaviour>();
            idol.activated = true;
        }

    }

    private void OnTriggerExit2D(Collider2D other)
    {
        if (other.CompareTag("PlayerVis"))
        {
            IdolBehaviour idol = enemy.GetBehaviour<IdolBehaviour>();
            idol.activated = false;
        }
    }
}
