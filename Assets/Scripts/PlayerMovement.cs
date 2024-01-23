using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem;

// Take this code from InputMover script that eral gave us in lecture 2
[RequireComponent(typeof(Rigidbody2D))]
public class PlayerMovement : MonoBehaviour {

    private float stepSize = 6f;

    [SerializeField]
    InputAction moveLeft = new InputAction(type: InputActionType.Button);

    [SerializeField]
    InputAction moveRight = new InputAction(type: InputActionType.Button);


    void OnEnable()
    {
        moveLeft.Enable();
        moveRight.Enable();
    }

    void OnDisable()
    {
        moveLeft.Disable();
        moveRight.Disable();
    }

    void Start () {
		
	}
	
	// Update is called once per frame
	void Update () {

        if (moveLeft.IsPressed())
        {
            transform.position += new Vector3(-stepSize * Time.deltaTime, 0, 0);
            FlipPlayer(true);
        }
        else if (moveRight.IsPressed())
        {
            transform.position += new Vector3(stepSize * Time.deltaTime, 0, 0);
            FlipPlayer(false);
        }
    }

    // Flip the player's sprite left/right
    void FlipPlayer(bool isLeft)
    {
        Vector3 scale = transform.localScale;
        scale.x = isLeft ? -1f : 1f;
        transform.localScale = scale;
    }
}
