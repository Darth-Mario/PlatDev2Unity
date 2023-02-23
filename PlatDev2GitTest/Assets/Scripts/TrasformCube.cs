using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class TrasformCube : MonoBehaviour
{
    private Transform _cube;
    public float _speed = 69f;

    // Start is called before the first frame update
    void Start()
    {
        GameObject cube = GameObject.Find("Cube");
        if (cube != null)
        {
            _cube = cube.transform;
            _cube.position = new Vector3(0.5f, 0.5f, 4.0f);

            MeshRenderer r = cube.GetComponent<MeshRenderer>();
            if (r != null)
                r.material.color = new Color(Random.Range(0,1.0f), Random.Range(0, 1.0f), Random.Range(0, 1.0f));
        }
        else
        {
            this.enabled = false;
        }
        
    }

    // Update is called once per frame
    void Update()
    {
        _cube.RotateAround(Vector3.zero, Vector3.up, _speed * Time.deltaTime);
    }
}
