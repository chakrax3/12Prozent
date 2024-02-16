using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class Buttons : MonoBehaviour
{
    public TextMeshProUGUI text;
    int score;
    public void Start()
    {
        score = 12; 
        for (int i = 0; i < GameObject.Find("Button Character").transform.childCount; i++)
        {
            if (i == PlayerPrefs.GetInt("characterIndex"))
                GameObject.Find("Button Character").transform.GetChild(i).gameObject.SetActive(true);
            else
                GameObject.Find("Button Character").transform.GetChild(i).gameObject.SetActive(false);
        }
    }
    public void Update()
    {
        if (score > 100)
        {
            score = 100;
        }

        if (score < 0)
        {
            score = 0;
        }
        text.text = score.ToString();
    }
    public void OnClickPlus()
    {
        score += Random.Range(1, 6);
        
    }
    public void OnClickMinus()
    {
        score += Random.Range(-1, -6);
        
    }

    public void OnClickReset()
    {
        score = 12;

    }
}