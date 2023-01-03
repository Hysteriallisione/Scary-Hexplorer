using System.Collections;
using System.Collections.Generic;
using UnityEngine;



public class GameManager : MonoBehaviour
{
    public GameObject animatedShad;
    public GameObject shadowE;
    public GameObject menuForPause;
    public GameObject returnButton;

    public bool canPause;

    public EnemyZombie zombScript;
    public playerControls playerScript;
    public Loot lootScript;
    public selectManager selectM;

    public bool isPaused;



    // Start is called before the first frame update
    void Start()
    {
       playerControls playerScript= GetComponent<playerControls>();

    }

    // Update is called once per frame
    public void Update()
    {
       /*   if (canPause)
        {

          if (playerScript._input.pause)
            {
                Pause();
            }
            else
            {
                UnPause();
            }
        }*/
    }

    public void BeginGame()
    {
        canPause= true;
        menuForPause.SetActive(false);
        animatedShad.SetActive(true);
    }

    public void Pause()
    {
        menuForPause.SetActive(true);
        Time.timeScale = 0f;


    }

    public void UnPause()
    {

        menuForPause.SetActive(false);
        Time.timeScale = 1f;

    }

   
}
