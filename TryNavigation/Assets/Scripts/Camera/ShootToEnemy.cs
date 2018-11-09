using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShootToEnemy : MonoBehaviour {

    private Camera cam;

    void Start()
    {
        cam = GetComponent<Camera>();
    }

    void Update()
    {
        if (Input.GetMouseButtonDown(0))
        {
            Vector3 point = new Vector3(cam.pixelWidth / 2, cam.pixelHeight / 2, 0);
            Ray ray = cam.ScreenPointToRay(point);
            RaycastHit hit;
            if (Physics.Raycast(ray, out hit))
            {
                GameObject hitO = hit.transform.gameObject;
                if (hitO.gameObject.CompareTag("Enemy"))
                {
                    ShotEn se = hitO.GetComponent<ShotEn>();
                    se.ReactToHit();
                }
            }
        }
    }
}
