using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ball : MonoBehaviour
{
    public GameObject tama;
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
        if (collider.gameObject.tag == "kabe")
        {
            float x = Random.Range(-2, 2);
            Instantiate(tama,new Vector3(x,3,0),Quaternion.identity);
            Destroy(gameObject);
        }
    }
}
