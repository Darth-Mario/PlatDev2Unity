using System;
using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{


    public GameObject _cube;
    public GameObject _cubeDestroy;
    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("Cube");
        if (cube != null && Input.anyKeyDown)
        {
            for (int i = 0; i == 50; i++)
            {
                Vector3 postion = UnityEngine.Random.insideUnitSphere * 5.0f;
                GameObject cubeObj = Instantiate(_cube, postion, _cube.transform.rotation);
                cubeObj.transform.SetParent(this.transform);

                cubeObj.transform.localScale = new Vector3(1, 0.5f, 1);
            }
        }
        
        

    }

    // Update is called once per frame
    void Update()
    {
        GameObject cube = GameObject.Find("Cube");

    }
}
