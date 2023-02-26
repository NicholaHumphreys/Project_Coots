using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SkyBoxMove : MonoBehaviour
{
    private float speed = 0.5f;

    private Vector2 axisMovement;


    // Update is called once per frame
    void Update()
    {
        
            RenderSettings.skybox.SetFloat("_Rotation", Time.time * -speed);
       


    }
}
