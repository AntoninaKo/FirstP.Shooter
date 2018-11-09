using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Alive : MonoBehaviour {

    int HealthPlayer = 120;
    bool PlayerAlive;

    public Slider HealthSlider;
    public Image Damage;

    bool CheckDamage;
    Color flashColour = new Color(1f, 0f, 0f, 0.1f);

    void Start () {
        PlayerAlive = true;
	}
	
	void Update () {
        if (!PlayerAlive)
        {
            GameObject.FindGameObjectWithTag("MainCamera").GetComponent<DeactivateCam>().DeactiveCam();
            DestroyPlayer();
            return;
        }
        SetImage(CheckDamage);
    }

    public void ReductionHealth()
    {
        HealthPlayer--;
        Slider(HealthPlayer);
        if(HealthPlayer == 0)
        {
            PlayerAlive = false;
            return;
        }
        CheckDamage = true;
 
    } 

    void DestroyPlayer()
    {
        Destroy(this.gameObject);
        GameObject.FindGameObjectWithTag("Canvas").GetComponent<StartClip>().ClipGameOver();
    }

    void Slider(int h)
    {
        HealthSlider.value = h;
    }

    void SetImage(bool C)
    {
        if (C)
        {
            Damage.color = flashColour;
            CheckDamage = false;
        }
        else
        {
            Damage.color = Color.Lerp(Damage.color, Color.clear, 5f * Time.deltaTime);      
        }
    }

}
