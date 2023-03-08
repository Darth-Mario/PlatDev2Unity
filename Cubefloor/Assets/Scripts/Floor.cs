using System.Collections;
using System.Collections.Generic;
using System.IO;
using UnityEngine;

public class Floor : MonoBehaviour
{
    public int _height;
    public int _width;
    public GameObject _prefab;
    
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i < _width; i++)
        {
            for (int j = 0; j < _height; j++)
            {
                {
                    if ((i + j) % 2 == 0)
                    {
                        Instantiate(_prefab, new Vector3(i, 0, j), _prefab.transform.rotation); 
                    }
                    else if ((i + j) % 2 == 1)
                    {
                        Instantiate(_prefab, new Vector3(i, 0, j), _prefab.transform.rotation); 
                    }
                    float randomY = Random.Range(0.1f, 1.5f);

                    _prefab.transform.localScale = new Vector3(1, randomY, 1);    
                }
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
