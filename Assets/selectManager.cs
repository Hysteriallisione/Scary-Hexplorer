using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;


public class selectManager : MonoBehaviour
{
    
    public GameObject[] character;
    public int selectedChar = 0;
    public GameManager gameM;

    public void NextCharacter()
    {
        character[selectedChar].SetActive(false);
        selectedChar = (selectedChar + 1) % character.Length;
        character[selectedChar].SetActive(true);
    }
    public void PreviousCharacter()
    {
        character[selectedChar].SetActive(false);
        selectedChar--;
        if(selectedChar < 0)
        {
            selectedChar += character.Length;
        }
        character[selectedChar].SetActive(true);
    }

    public void StartButton()
    {
        PlayerPrefs.SetInt("Player", selectedChar);
        SceneManager.LoadScene(1, LoadSceneMode.Single);
        
        //gameM.BeginGame();
    }
}
