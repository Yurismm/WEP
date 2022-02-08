using UnityEngine;

public class Target : MonoBehaviour
{
    // Start is called before the first frame update

    public float health = 50f;

    public ParticleSystem hiteffect;
    // this will be the effect that plays when the enemy is hit



    public void TakeDamage(float amount)
    {
        hiteffect.Play();

        health -= amount;
        if (health <= 0f)
        {
            Die();
        }
    }


    void Die()
    {
        Destroy(gameObject);
    }

}