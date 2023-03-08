using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeMovementScript : MonoBehaviour
{
    public float _speed = 5.0f;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("Cube");
        float moveRight = Input.GetAxis("Horizontal") * _speed;        
        float moveLeft = Input.GetAxis("Horizontal") * -_speed;
        
        if (Input.GetKeyDown(KeyCode.RightArrow))
        {
            cube.transform.Translate(moveRight,0,0);
        }
        if(Input.GetKeyDown(KeyCode.LeftArrow))
        {
            cube.transform.Translate(-moveLeft,0,0);
        }
        moveRight = Time.deltaTime;
        moveLeft = Time.deltaTime;
    }
}
