using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ShotEn : MonoBehaviour {

    int CheckHealth;

    public void ReactToHit()
    {
        StartCoroutine(React());
    }

    private IEnumerator React()
    {
        if (this.gameObject.GetComponent<Move2>() != null)
        {
            CheckHealth = this.gameObject.GetComponent<Move2>().Health;
            if (CheckHealth > 1)
            {
                this.gameObject.GetComponent<Move2>().Health--;
            }
            else
            {
                Destroy(this.gameObject);
                GameObject.FindGameObjectWithTag("Manager").GetComponent<SpawnEn>().MinusQuantity();
                Manager.Score += 10;
            }
        }
        yield return new WaitForSeconds(1.0f);
    }
}
