using UnityEngine;
using TMPro;
using UnityEngine.SceneManagement;

public class PlayerHealth : MonoBehaviour
{
    public float MaxHealth;
    public float Health;
    public TextMeshProUGUI text;
    public float SlimeDamage;
    public float InvulnurabilityTime;
    private float invulnurabilityTimer;

    void Start()
    {
        Health = MaxHealth;
    }

    // Update is called once per frame
    void Update()
    {
        if(invulnurabilityTimer > 0) invulnurabilityTimer -= Time.deltaTime;

        showHealth();
    }

    private void showHealth()
    {
        text.text = $"{Health}/{MaxHealth}";
    }

    private void OnCollisionEnter2D(Collision2D collision)
    {
        if (collision.gameObject.tag.Equals("Enemy") && invulnurabilityTimer <= 0)
        {
            Health -= SlimeDamage;
            invulnurabilityTimer = InvulnurabilityTime;
        }
        if(Health <= 0)
        {
            Die();
        }
    }

    private void Die()
    {
        SceneManager.LoadScene("Game");
    }
}
