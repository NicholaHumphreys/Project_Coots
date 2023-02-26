using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class EnemyHealth : MonoBehaviour
{
    [SerializeField]
    private int health;

    [SerializeField]
    private int MaxHealth;

    
    public void SetHealth(int maxHealth, int health){
    
        this.MaxHealth = maxHealth;
        this.health= health;   
    
    }

    private IEnumerator VisualIndicator(Color color) {

        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;

    }

    public void Damage(int amount)
    {

        this.health -= amount;
        StartCoroutine(VisualIndicator(Color.red));
        

        if (health <= 0)
        {
            
            Die();
        }

    }

    

    private void Die()
    {

        Destroy(gameObject);

    }
}
