using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CootsShoot : MonoBehaviour
{

    private Camera mainCamera;

    private Vector3 mousePos;

    public GameObject bulletPrefab;

    public Transform bulletTransform;

    public CameraShake cameraShake;


    void Start() {

        mainCamera = GameObject.FindGameObjectWithTag("MainCamera").GetComponent<Camera>();
    }

    // Update is called once per frame
    void Update()
    {
        shoot();
    }

    void shoot() {

        mousePos = mainCamera.ScreenToWorldPoint(Input.mousePosition);

        Vector3 rotation = mousePos - transform.position;

        float rotZ = Mathf.Atan2(rotation.y, rotation.x) * Mathf.Rad2Deg;

        transform.rotation = Quaternion.Euler(0,0,rotZ);

        if (Input.GetMouseButtonDown(0))
        {
            Instantiate(bulletPrefab, bulletTransform.position, Quaternion.identity);
            StartCoroutine(cameraShake.Shake(0.15f, 0.05f));

        }

    }
}
