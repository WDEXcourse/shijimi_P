using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject tama;
    public GameObject t;
    tamaka script;
    // Start is called before the first frame update
    void Start()
    {
        tama = gameObject;
        t = GameObject.Find ("GameObject");
        script = t.GetComponent<tamaka>(); 
    }

    // Update is called once per frame
    void Update()
    {
      
    }
    private void OnTriggerEnter2D(Collider2D collider)
    {
        if (collider.gameObject.tag == "atarikabe")
        {
            script.tamakazu += 5;
            Debug.Log("a");
            Destroy(gameObject);
        }
        if (collider.gameObject.tag == "kabe")
        {
            Destroy(gameObject);
            
        }
    }
}
