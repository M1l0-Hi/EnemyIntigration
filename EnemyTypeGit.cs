using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemyTypeGit : MonoBehaviour
{
    public string type;

    public void hit(float takePoints)
    {
        if (type == "Bat")
        {
            gameObject.GetComponent<Bat>().health -= takePoints;
        }
    }
}
