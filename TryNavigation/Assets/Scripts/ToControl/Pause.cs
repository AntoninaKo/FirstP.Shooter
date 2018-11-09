using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Pause : MonoBehaviour {
    bool pause = false;
	
	void Update () {
        
        if (Input.GetKey("space"))
        {
            ClickPause();
        }
	}

    void ClickPause() {
        pause = !pause;
        if (pause)
        {
            Time.timeScale = 0;
        }
        else
        {
            Time.timeScale = 1;
        }
    }
}
