using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject[] loots;
    private int number;
    private int randNum;
    public bool spawnLoot = false;

    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void Loots()
    {

        if (!spawnLoot)
        {
            
            randNum = Random.Range(0, 101);


            if (randNum >= 51)
            {

                Instantiate(loots[0], transform.position, Quaternion.identity);
            }
            if (randNum > 30 && randNum <= 50)
            {

                Instantiate(loots[1], transform.position, Quaternion.identity);

            }
            if (randNum < 29)
            {

                return;
            }


            spawnLoot = true;
        }
    }
}
