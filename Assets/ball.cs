using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject tama;
    public tamaka t;
    // Start is called before the first frame update
    void Start()
    {
        tama = gameObject;
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "atarikabe")
        {
            t.tamakazu += 5;
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "kabe")
        {
            Destroy(gameObject);
            
        }
    }
}
