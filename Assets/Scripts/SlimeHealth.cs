using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeHealth : MonoBehaviour
{
    public SlimeController sc;

    public void Die()
    {
        sc.SpawnSmallSlime();
    }

    
}
