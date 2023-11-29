using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Sword : MonoBehaviour
{
    public Transform pivot;
    private float cooldown = 0;
    public float cooldownTime;


    void Update()
    {
        Vector2 direction = Camera.main.ScreenToWorldPoint(Input.mousePosition) - pivot.position;
        float angle = Mathf.Atan2(direction.y, direction.x)* Mathf.Rad2Deg;
        pivot.rotation = Quaternion.Euler(0, 0, angle-90);
        if(cooldown>0) cooldown -= Time.deltaTime;
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        if(collision.gameObject.tag.Equals("Enemy") && cooldown <= 0)
        {
            if(collision.gameObject.GetComponent<SlimeHealth>() != null)
            {
                collision.gameObject.GetComponent<SlimeHealth>().Die();
            }
            else if(collision.gameObject.GetComponent<SmallSlimeHealth>() != null)
            {
                collision.gameObject.GetComponent<SmallSlimeHealth>().Die();
            }
            cooldown = cooldownTime;
        }
    }
}
