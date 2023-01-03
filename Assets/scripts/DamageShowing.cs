using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class animDamage : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {

    }
    public void Update()
    {
        PopUpDestroy();
    }


    public void LateUpdate()
    {
        transform.LookAt(Camera.main.transform.position, Vector2.up);

    }


    public void PopUpDestroy()
    {
        Destroy(gameObject, .5f);
    }
}
