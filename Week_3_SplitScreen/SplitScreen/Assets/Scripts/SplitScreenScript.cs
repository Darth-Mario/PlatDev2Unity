using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class SplitScreenScript : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}

/*4.2.Split Screen(Ref: SplitScreen.rar)
Make a dynamic split screen scene 
• Create a new scene “SplitScreen” 
• Create a “beautiful” scene with primitives 
• Create 3 extra cameras with all a different angle of the scene 
• Make a new GameObject “SplitScreen” and attach a new script
“SplitScreen” 
• Make a public Camera array “Cameras”  
• Assign the cameras 
• In the start function you disable all the camera component except the first 
one 
• In the update function you check for key input 
(Keypad1/Keypad2/Keypad3/Keypad4). In case of Keypad1 you enable only 
• the first camera with the correct view. In case of Keypad2 you enable only 
the first two cameras with the correct view. etc. */