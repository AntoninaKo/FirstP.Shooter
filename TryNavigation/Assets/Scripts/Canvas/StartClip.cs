using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartClip : MonoBehaviour {

    Animator anim;
  
    void Start() {
        anim = GetComponent<Animator>();
    }


    public void ClipGameOver()
    {
        anim.SetTrigger("Dead");
    }
}
