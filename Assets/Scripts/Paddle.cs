using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Paddle : MonoBehaviour
{
    //configuration parameters
    [SerializeField] float minX = 1f;
    [SerializeField] float maxX = 15f;
    [SerializeField] float screenWidthInUnits = 16f;

    // Start is called before the first frame update
    void Start(){}

    // Update is called once per frame
    void Update()
    {
        float mousePosInUnits = Input.mousePosition.x / Screen.width * screenWidthInUnits; //where we are in relation to overall screen size regardless of resolution
        Vector2 paddlePosition = new Vector2(transform.position.x, transform.position.y); //creating a new vector initialized to current x and y position of object
        paddlePosition.x = Mathf.Clamp(mousePosInUnits, minX, maxX); //the x position of the paddle should be within minX and maxX
        transform.position = paddlePosition; //set the transform to paddlePosition
    }
}
