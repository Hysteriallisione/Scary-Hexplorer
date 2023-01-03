using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class LoadCharacter : MonoBehaviour
{
    public GameObject[] character;
    public Transform spawnChar;
   

    // Start is called before the first frame update
    void Start()
    {
        int selectedChar = PlayerPrefs.GetInt("Player");
        GameObject prefab = character[selectedChar];
        GameObject clone = Instantiate(prefab, spawnChar.position, Quaternion.identity);
        
    }

   
}
