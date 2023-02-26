using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using UnityEngine.SceneManagement;

public class CootsHealth : MonoBehaviour
{
    public TMP_Text healthdisplay;

    public CameraShake cameraShake;
    public MenuSwap menuSwap;

    public bool isDead = false;

    [SerializeField] private int health = 100;

    private int MaxHealth = 100;


    // Update is called once per frame
    void Update()
    {
       
        healthdisplay.text =  health.ToString();
    }

    private IEnumerator VisualIndicator(Color color)
    {

        GetComponent<SpriteRenderer>().color = color;
        yield return new WaitForSeconds(0.15f);
        GetComponent<SpriteRenderer>().color = Color.white;

    }

    public void Damage(int amount)
    {

        if (amount < 0)
        {

        }

        this.health -= amount;

        if (health <= 0)
        {

            Die();
        }

    }

    public void Heal(int amount)
    {
        if (amount < 0)
        {

            //throw new System.ArguementOutOfRangeException("Cannot have negative health");
        }

        bool wouldBeOverMaxHealth = health + amount > MaxHealth;

        if (health + amount > MaxHealth)
        {

            this.health = MaxHealth;

        }
        else
        {

            this.health += amount;

        }


    }

    void Awake()
    {
        DontDestroyOnLoad(transform.gameObject);
    }

    private void Die()
    {


        //SceneManager.LoadScene("DeathScreen");

        Time.timeScale =0;
        StartCoroutine(cameraShake.Shake(0f, 0f));
        isDead = true;
        Destroy(gameObject);

        healthdisplay.text = "DEAD";

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {
        //ENEMY COLLIDES//
        if (collider.CompareTag("H_Enemy"))
        {

            Damage(5);
            StartCoroutine(cameraShake.Shake(0.15f, 0.05f));
            StartCoroutine(VisualIndicator(Color.red));


        }

        if (collider.CompareTag("S_Enemy"))
        {

            Damage(20);
            StartCoroutine(cameraShake.Shake(0.15f, 0.15f));
            StartCoroutine(VisualIndicator(Color.red));


        }

        if (collider.CompareTag("O_Enemy"))
        {

            Damage(10);
            StartCoroutine(cameraShake.Shake(0.15f, 0.1f));
            StartCoroutine(VisualIndicator(Color.red));

        }

        //POWER UPS//
        if (collider.CompareTag("Health"))
        {
            Heal(10);
            StartCoroutine(VisualIndicator(Color.green));

        }

    }
}
