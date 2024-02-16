using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class StartGame : MonoBehaviour
{
    private void Start()
    {
        GameObject.Find("Spiel Starten").transform.GetComponent<Button>().interactable = false;
    }

    public void PlayGame()
    {
        SceneManager.LoadScene("PlayGame");
        Debug.Log("starteeeeen!");
    }

    public void ButtonCharacter(int characterIndex)
    {
        PlayerPrefs.SetInt("characterIndex", characterIndex);
        Debug.Log("Character: " + characterIndex);
        for (int i = 0; i < GameObject.Find("Buttons").transform.childCount; i++)
        {
            if (i == characterIndex) 
                GameObject.Find("Buttons").transform.GetChild(i).GetComponent<Image>().color = new Color(1f, 1f, 1f, 1f);
            else
                GameObject.Find("Buttons").transform.GetChild(i).GetComponent<Image>().color = new Color(0.8f, 0.8f, 0.8f, 0.5f);
        }
        GameObject.Find("Spiel Starten").transform.GetComponent<Button>().interactable = true;
    }

}
