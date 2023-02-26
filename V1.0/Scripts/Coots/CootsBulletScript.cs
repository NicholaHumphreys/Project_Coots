using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CootsBulletScript : MonoBehaviour
{

    float TimeToLive = 4000f;

    private Vector3 mousePos;
    private Camera mainCam;
    private Rigidbody2D rb;
    public float force;


    void Start() {

        mainCam = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();

        rb = GetComponent<Rigidbody2D>();

        mousePos = mainCam.ScreenToWorldPoint(Input.mousePosition);

        Vector3 direction = mousePos - transform.position;

        Vector3 rotation = transform.position - mousePos;

        rb.velocity = new Vector2(direction.x,direction.y).normalized *force;

        float rot = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0, rot+90);
    }


    void Update()
    {
        DieOnWait();
    }

    void DieOnWait() {

        Destroy(gameObject, TimeToLive * Time.deltaTime);

    }

    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("Enemy"))
        {

            Destroy(gameObject);


        }

    }
}
