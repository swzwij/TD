using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UImanaager : MonoBehaviour
{
    public Text kills;
    public Text Mana;
    public int CurrentMana = 1000;
    public int currentkills = 0;

    public GameObject LossScreen;

    void Start()
    {
        Mana.text = "Mana : " + CurrentMana;
        kills.text = "Kills : " + currentkills;
    }

    void Update()
    {
        Mana.text = "Mana : " + CurrentMana;
        kills.text = "Kills : " + currentkills;

        if(CurrentMana <= 0)
        {
            Death();
        }
    }

    void Death()
    {
        Time.timeScale = 0;
        LossScreen.SetActive(true);
    }
}
