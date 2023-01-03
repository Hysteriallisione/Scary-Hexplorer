using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Loot : MonoBehaviour
{
    public GameObject loots;
    public Collider2D coffreTriggered;
    public bool spawnLoot = false;
    public bool touched = false;
    public bool open = false;

    public playerControls playerScr;
    public SpriteRenderer swapSprite;
    public Sprite[] spriteOnC;
    public int spriteVersion;
    

    // Start is called before the first frame update
    void Start()
    {
       spriteVersion = 0;
       swapSprite.sprite = spriteOnC[0];
    }

    // Update is called once per frame
    void Update()
    { 
      
        if(touched && playerScr.opening)
        {
            Loots();
        }
    }
    private void OnTriggerEnter2D(Collider2D collision)
    {
        if (collision.gameObject.CompareTag("Player"))
        {
            touched = true;
            coffreTriggered = collision;
            Debug.Log("trigger has been approached and touched!!");
        }
    }
    public void Loots()
    {
        spriteVersion = 1;
        swapSprite.sprite = spriteOnC[1];
        var extraPos = new Vector2(transform.position.y, 5);

        if (open && touched)
        {
                Instantiate(loots, extraPos, Quaternion.identity);
           
            spawnLoot = true;

        } 
    touched = true;
    playerScr.opening = true;
    spawnLoot= false;
    }
}
