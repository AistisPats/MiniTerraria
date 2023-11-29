using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    public GameObject Spawner;

    public void Die()
    {
        Spawner.GetComponent<spawner>().CreateSmallSlime(transform);
        Spawner.GetComponent<spawner>().CreateSmallSlime(transform);
        Destroy(gameObject);
    }

    
}
