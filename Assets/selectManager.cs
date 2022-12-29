using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.SceneManagement;
using UnityEditor;

public class selectManager : MonoBehaviour
{
    public GameObject[] character;
    public int selectedChar = 0;
    public GameObject emptyChar;
    public int maxCount = 4;
    public int minCount = 0;
    public bool continueCount = false;
    


    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
       
      
      
    }
    public void NextCharacter()
    {
        selectedChar++;
        if(selectedChar == -1)
        {
            selectedChar ++;
         if (selectedChar == 4)
        {
            selectedChar = minCount;
            continueCount = true;
        }} 
        emptyChar = character[selectedChar];
    }
    public void PreviousCharacter()
    {
        selectedChar--;
        if(selectedChar < 0)
        { 
            selectedChar --;
        
        if(selectedChar == 0)
        {
            selectedChar = maxCount;
            continueCount= true;
        }}
        emptyChar = character[selectedChar];
    }
}
