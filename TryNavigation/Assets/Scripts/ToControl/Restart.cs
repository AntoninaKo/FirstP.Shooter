using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;

public class Restart : MonoBehaviour {

    public void RestartThis()
    {
        SceneManager.LoadScene(0);
    }
}
