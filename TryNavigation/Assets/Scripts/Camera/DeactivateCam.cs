using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DeactivateCam : MonoBehaviour {


    public void DeactiveCam()
    {
        this.gameObject.transform.SetParent(null);
        this.gameObject.GetComponent<ShootToEnemy>().enabled = false;
        this.gameObject.GetComponent<RotationOfCamera>().enabled = false;
    }
}
