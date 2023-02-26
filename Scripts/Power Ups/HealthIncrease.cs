using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class HealthIncrease : MonoBehaviour
{
    private GameObject player;

    private float rotationsPerMinute;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Coots");

        rotationsPerMinute = Random.Range(1.5f, 5f);
    }

    // Update is called once per frame
    void Update()
    {
        transform.Rotate(0, 0, 6.0f * rotationsPerMinute * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Coots"))
        {

            Destroy(gameObject);


        }

    }
}
