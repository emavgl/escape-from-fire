using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Android;

public class GravityController : MonoBehaviour
{
    // Start is called before the first frame update
    private bool normalGravity;
    void Start()
    {
        normalGravity = true;
    }

    void ChangeGravity(){
        //ChangeGravityWithKeyboard(); // DEBUG!
        ChangeGravityWithTouchScreen();
    }

    void ChangeGravityWithKeyboard(){
        if (Input.GetKeyDown("space"))
        {
            Debug.Log("Key space pressed");
            if (normalGravity)
            {
                Physics2D.gravity = new Vector3(0f,10f,0f);
                normalGravity = false;
            }
            else
            {
                Physics2D.gravity = new Vector3(0f,-10f,0f);
                normalGravity = true;
            }
        }
    }

    void ChangeGravityWithTouchScreen(){
        if (Input.touchCount > 0)
        {
            if (normalGravity)
            {
                Physics2D.gravity = new Vector3(0f,10f,0f);
                normalGravity = false;
            }
            else
            {
                Physics2D.gravity = new Vector3(0f,-10f,0f);
                normalGravity = true;
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // DEBUG: Change Gravity.
        ChangeGravity();
    }
}
