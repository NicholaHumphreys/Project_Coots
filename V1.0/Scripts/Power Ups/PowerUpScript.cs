using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PowerUpScript : MonoBehaviour
{
    public Transform target;
    public float speed;
    private Vector3 zAxis = new Vector3(0, 0, 1);

    public GameObject Health;

    public float Health_Interval;

    // Start is called before the first frame update
    void Start()
    {
        StartCoroutine(spawnPowerUp(Health_Interval, Health));
    }

    void FixedUpdate()
    {

        transform.RotateAround(target.transform.localPosition, transform.forward * -1, speed * Time.deltaTime);


    }

    private IEnumerator spawnPowerUp(float interval, GameObject PowerUp)
    {

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(PowerUp, this.transform.position, Quaternion.identity);
        StartCoroutine(spawnPowerUp(interval, PowerUp));

    }
}
