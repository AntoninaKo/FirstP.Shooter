using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Manager : MonoBehaviour {

    Text text;
    public static int Score;

    void Start () {
        text = GetComponent<Text>();
	}
	
	void Update () {
        text.text = "Score: " + Score;
	}
}
