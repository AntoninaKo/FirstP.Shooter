using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class OnCollision : MonoBehaviour {

    void OnCollisionEnter(Collision collision)
    {

        if (collision.gameObject.name == "Player")
        {
            if (collision.gameObject.GetComponent<Alive>())
            { collision.gameObject.GetComponent<Alive>().ReductionHealth();
                Destroy(this.gameObject);
            }
        }
    }
}
