using Unity.VisualScripting;
using UnityEngine;

public class CubeDestroy : MonoBehaviour
{


    public GameObject _cube;
    float period = 0.0f;
    // Start is called before the first frame update
    void Start()
    {

        for (int i = 0; i <= 50; i++)
        {

            float randomX = Random.Range(0.9f, 4.0f);
            float randomY = Random.Range(0.4f, 4.0f);
            float randomZ = Random.Range(0.2f, 4.0f);

            Vector3 postion = Random.insideUnitSphere * 5.0f;
            GameObject cubeObj = Instantiate(_cube, postion, _cube.transform.rotation);
            cubeObj.transform.SetParent(this.transform);
            cubeObj.transform.localScale = new Vector3(randomX, randomY, randomZ);
        }


    }

    // Update is called once per frame
    void Update()
    {
        
        if (period > 1.0f)
        {
            GameObject[] cube = GameObject.FindGameObjectsWithTag("Cube");
            GameObject.Destroy(cube[0]);
            period = 0;            
        }
        period += Time.deltaTime;


       
            
        
            
        
        
    }
}
