using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject slime;
    public Transform PlayerPos;
    public GameObject smallSlime;
    public float delay;
    private float timer = 0;

    void Update()
    {
        timer += Time.deltaTime;
        if (timer > delay)
        {
            GameObject s = Instantiate(slime, transform);
            s.GetComponent<SlimeMovement>().PlayerPos = PlayerPos;
            s.GetComponent<SlimeHealth>().Spawner = gameObject;
            timer -= delay;
        }
    }
    public void CreateSmallSlime(Transform pos)
    {
        GameObject s = Instantiate(smallSlime, pos);
        s.GetComponent<SlimeMovement>().PlayerPos = PlayerPos;
    }
}
