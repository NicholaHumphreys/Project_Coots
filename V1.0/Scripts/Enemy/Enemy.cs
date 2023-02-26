using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Enemy : MonoBehaviour
{
    [SerializeField]
    private int damage;

    [SerializeField]
    private float speed;

    

    [SerializeField]
    private int points;

    

    [SerializeField]
    private EnemyData data;

    private GameObject player;

    private CootsPoints PlayerScore;

    // Start is called before the first frame update
    void Start()
    {
        player = GameObject.FindGameObjectWithTag("Coots");
        PlayerScore = player.GetComponent<CootsPoints>();

        SetEnemyValues();
    }

    // Update is called once per frame
    void Update()
    {
        Swawm();
    }

    private void SetEnemyValues()
    {

        GetComponent<EnemyHealth>().SetHealth(data.HP, data.HP);

        

        speed = data.speed;
        damage = data.damage;
        points = data.points;



    }

    private void Swawm()
    {

        transform.position = Vector2.MoveTowards(transform.position, player.transform.position, speed * Time.deltaTime);
    }



    private void OnTriggerEnter2D(Collider2D collider)
    {

        if (collider.CompareTag("BulletCoots"))
        {

            this.GetComponent<EnemyHealth>().Damage(1);
            PlayerScore.AddPoints(points);


        }

        if (collider.CompareTag("Coots"))
        {

            Destroy(gameObject);


        }

    }
}
