using System.Collections;
using System.Collections.Generic;
using Unity.VisualScripting;
using UnityEngine;

public class FollowMouseScript : MonoBehaviour
{
    public float _speed = 5.0f;
    public Vector3 _mouseFollow;
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        /*Vector3 mouseFollow = Camera.main.ScreenToWorldPoint(Input.mousePosition) ;
        this.transform.position = Vector3.MoveTowards(new Vector3(0,0.5f,0),new Vector3(mouseFollow.x,0.5f,mouseFollow.y),_speed * Time.deltaTime);*/
        _mouseFollow = Camera.main.ScreenToWorldPoint(new Vector3(Input.mousePosition.x, Input.mousePosition.y, Camera.main.transform.position.y));
        this.transform.position = Vector3.MoveTowards(this.transform.position, new Vector3(_mouseFollow.x, 0.5f, _mouseFollow.z), _speed * Time.deltaTime);
    }
}
/*Create a new scene “FollowMouse” 
• Create a plane on position (0,0,0) with a scale of (3,1,2) 
• Place the camera downwards and on a position (0,10,0) 
• Create a cube and attach a new script “FollowMouse” 
• Make a public float Speed variable = 5
• In the update function you make the cube follow the mouse position */

/*4.2.Split Screen(Ref: SplitScreen.rar)
Make a dynamic split screen scene 
• Create a new scene “SplitScreen” 
• Create a “beautiful” scene with primitives 
• Create 3 extra cameras with all a different angle of the scene 
• Make a new GameObject “SplitScreen” and attach a new script
“SplitScreen” 
• Make a public Camera array “Cameras” 
Platform Development 2  Lab 03 
- 2 / 3 -   
• Assign the cameras 
• In the start function you disable all the camera component except the first 
one 
• In the update function you check for key input 
(Keypad1/Keypad2/Keypad3/Keypad4). In case of Keypad1 you enable only 
• the first camera with the correct view. In case of Keypad2 you enable only 
the first two cameras with the correct view. etc.*/