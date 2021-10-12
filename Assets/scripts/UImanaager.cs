using System.Collections;
using System.Collections.Generic;
using UnityEngine.UI;
using UnityEngine;

public class UImanaager : MonoBehaviour
{
    public Text kills;
    public Text Mana;
    public int CurrentMana = 300;
    public int currentkills = 0;

    public GameObject LossScreen;

    void Start()
    {
        StartCoroutine(addHealth());

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

    IEnumerator addHealth()
    {
        while (true)
        {
            if (CurrentMana < 1000)
            {
                CurrentMana += 1;
                yield return new WaitForSeconds(1);
            }
            else
            { 
                yield return null;
            }
        }
    }
}
