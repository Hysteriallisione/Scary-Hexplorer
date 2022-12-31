using System.Collections;
using System.Collections.Generic;
using UnityEngine;


public class GameManager : MonoBehaviour
{
    public GameObject startMenu;
    public GameObject[] characters;
    public GameObject characContainer;

    public EnemyZombie zombScript;
    public playerControls playerScript;
    public Loot lootScript;
    public selectManager selectM;

    public bool isPaused;



    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void BeginGame()
    {

    }

    public void SelectCharacter()
    {
        isPaused = true;
        startMenu.SetActive(true);
        //selectM.Start();

    }

    public void AddCharacterPrefabToPlayer()
    {
        startMenu.SetActive(false);

       /* GameObject playerGO = Instantiate(character[], characContainer.transform.position, characContainer.transform.rotation);
        playerGO.transform.SetParent(characContainer.transform);


       
        pW.uiHolder = playerUiHolder;
       

      */  BeginGame();
    }
}
