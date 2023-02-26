using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CootsMovement : MonoBehaviour
{
    [SerializeField]
    private float speed = 3f;

    private Rigidbody2D body;
    private Vector2 axisMovement;

    private SpriteRenderer _renderer;


    void Start() {

        body = GetComponent<Rigidbody2D>();

        _renderer = GetComponent<SpriteRenderer>();
    }

    void Update()
    {
        DirectionalMovement();


    }

    private void FixedUpdate() {

        Move();

    }

    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////

    private void Move() {

        body.velocity = axisMovement.normalized * speed;
        CheckForFlipping();


    }

    private void CheckForFlipping()
    {
        bool movingLeft = axisMovement.x < 0;
        bool movingRight = axisMovement.x > 0;

        if (movingLeft) {
            _renderer.flipX = true;

        }

        if (movingRight)
        {
            _renderer.flipX = false;

        }

    }


    ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
    void DirectionalMovement() {

        axisMovement.x = Input.GetAxisRaw("Horizontal");
        axisMovement.y = Input.GetAxisRaw("Vertical");


    }

    

    
}
