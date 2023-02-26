using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class EnemySpawner : MonoBehaviour
{

    public Transform target;
    public float speed = 20;
    private Vector3 zAxis = new Vector3(0, 0, 1);

    [SerializeField]
    private GameObject Oriental;

    [SerializeField]
    private GameObject Scottish;

    [SerializeField]
    private GameObject Hairless;

    
    private float O_Interval = 5f;    
    private float S_Interval = 10f;    
    private float H_Interval = 2f;


    void Start() {

        StartCoroutine(spawnEnemy(O_Interval, Oriental));
        StartCoroutine(spawnEnemy(S_Interval, Scottish));
        StartCoroutine(spawnEnemy(H_Interval, Hairless));


    }

    void FixedUpdate() {

        transform.RotateAround(target.transform.localPosition, transform.forward * -1, speed * Time.deltaTime);
        IncreaseSpawnOverTime();

    }

    private IEnumerator spawnEnemy(float interval, GameObject enemy) {

        yield return new WaitForSeconds(interval);
        GameObject newEnemy = Instantiate(enemy, this.transform.position, Quaternion.identity);
        StartCoroutine(spawnEnemy(interval, enemy));
    
    }

    void IncreaseSpawnOverTime() {

        O_Interval += 0.05f * Time.deltaTime;
        S_Interval += 0.05f * Time.deltaTime;
        S_Interval += 0.05f * Time.deltaTime;

    }


}
