using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEditor.Experimental.GraphView;
using UnityEngine;

public class EnemyZombie : MonoBehaviour
{
    // Ze base
    public Collider2D triggerAtt;
    private bool move;
    public float speed;
    public float health;
    public int damage;
    public bool deleteE = false;

    //Attacking Player
    public float timeBetweenAttacks = .5f;
    private float time;
    private bool canAttack = false;
    public playerControls playerScr;


    //Damage Popup
    public GameObject aie;

    //extra
    public Animator zombie;

    // Start is called before the first frame update
    void Start()
    {
       
    }

    // Update is called once per frame
    void Update()
    {


    }
    public void WalkToward()

    {
      GameObject player = GameObject.FindWithTag("Player");
      float horizontal = player.transform.localScale.x - this.transform.localScale.x;
      float vertical = player.transform.localScale.y - this.transform.localScale.y;
      Vector2 playerPosition = new Vector2(player.transform.position.x, transform.position.y);
      transform.LookAt(playerPosition);
        Vector2 zombiePos = new Vector2(horizontal, vertical);

        if (zombiePos.magnitude > 0)
        {
            move = true;
            zombie.SetFloat("horizontal", horizontal);
            zombie.SetFloat("vertical", vertical);
            zombie.SetBool("goingTo", true);
           
        }
        else
        {
            move = false;
            zombie.SetBool("Move", false);
        }

    }

    public void TakeDamage(float damage)
    {
       health -= damage;

       if (health <= 0)
       {
            deleteE = true;
             // Loots();
              Death();
              zombie.SetBool("dead", true);
       }

       Vector3 showDamage = new Vector3(transform.position.x, 1f, transform.position.z);
       var go = Instantiate(aie, showDamage, Quaternion.identity);
       TMP_Text damageText = go.GetComponent<TMP_Text>();
       damageText.text = damage.ToString();


    }
    public void Death()
    {


        if (deleteE && health == 0)
        {
            deleteE = true;
          //Debug.Log("Dead Enemy");

         Destroy(this.gameObject, .1f);
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        GameObject player = GameObject.FindWithTag("Player");
        triggerAtt = player.GetComponent<Collider2D>();

        if (collision.gameObject.CompareTag("Player"))
        {
            canAttack = true;
            triggerAtt = collision;
            if(canAttack)
            {
                playerScr.PlayerAction();
            }
        }
        playerScr.PlayerAction();
    }
    /* public void Loots()
     {

          if (!spawnLoot)
          {
               spawner.enemyM.enemiesDefeated++; //Putting this here because this is for defeated enemies.
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
       }*/


}
