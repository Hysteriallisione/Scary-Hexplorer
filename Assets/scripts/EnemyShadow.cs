using System.Collections;
using System.Collections.Generic;
using TMPro;
using UnityEngine;

public class EnemyShadow : MonoBehaviour
{
    public float damage;
    public float health;
    public Collider2D shadCo;
    public bool deleteE = false;

    // Attack Player
    public float timeBetweenAtt = .2f;
    public bool canAtt;
    private float time;


    public GameObject aie;

    // Start is called before the first frame update
    void Start()
    {
        GameObject player = GameObject.FindWithTag("Player");
    }

    // Update is called once per frame
    void Update()
    {
        
    }
    public void TakeDamage(float damage)
    {
        health -= damage;

        if (health <= 0)
        {
            deleteE= true;
            // Loots();
            Death();
            
        }

        Vector3 showDamage = new Vector3(transform.position.x, 1f, transform.position.z);
        var go = Instantiate(aie, showDamage, Quaternion.identity);
        TMP_Text damageText = go.GetComponent<TMP_Text>();
        damageText.text = damage.ToString();


    }
    public void Death()
    {


        if ( deleteE && health == 0)
        {
            deleteE = true;
            //Debug.Log("Dead Enemy");

            Destroy(this.gameObject, .1f);
        }
    }
}
