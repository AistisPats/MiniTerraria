using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SlimeController : MonoBehaviour
{
    public GameObject Slime;
    public GameObject SmallSlime;
    public Transform PlayerPosition;
    private GameObject slime, smallSlime1, smallSlime2;

    void Start()
    {
        slime = Instantiate(Slime, transform); 
        slime.GetComponent<SlimeMovement>().PlayerPos = PlayerPosition;
        slime.GetComponent<SlimeHealth>().sc = this;
    }

    public void SpawnSmallSlime()
    {
        transform.position = slime.transform.position;
        Destroy(slime);
        
        smallSlime1 = Instantiate(SmallSlime, transform);
        smallSlime1.GetComponent<SlimeMovement>().PlayerPos = PlayerPosition;
        smallSlime2 = Instantiate(SmallSlime, transform);
        smallSlime2.GetComponent<SlimeMovement>().PlayerPos = PlayerPosition;
        
    }    
}
