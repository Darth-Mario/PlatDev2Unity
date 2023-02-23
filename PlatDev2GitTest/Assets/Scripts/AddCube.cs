using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class AddCube : MonoBehaviour
{
    public GameObject _cube;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            float randomX = Random.Range(0.9f, 8.0f);
            float randomY = Random.Range(0.4f, 8.0f);
            float randomZ = Random.Range(0.2f, 8.0f);

            Vector3 postion = new Vector3(randomX, randomY, randomZ);
            GameObject cubeObj = Instantiate(_cube, postion, _cube.transform.rotation);
            cubeObj.transform.SetParent(this.transform);

            cubeObj.transform.localScale = new Vector3(1, 0.5f, 1);
        }
    }
}
