using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class spawner : MonoBehaviour
{
    public GameObject sc;
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
            var s = Instantiate(sc, transform);
            var scRef = s.GetComponent<SlimeController>();
            scRef.Slime = slime;
            scRef.SmallSlime = smallSlime;
            scRef.PlayerPosition = PlayerPos;
            timer -= delay;
        }
    }
}
