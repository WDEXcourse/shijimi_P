using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class tamaka : MonoBehaviour
{
    public GameObject tama;
    public int tamakazu;
    public GameObject tamakazu_Object = null;
    // Start is called before the first frame update
    void Start()
    {
        tamakazu = 10;
    }

    // Update is called once per frame
    void Update()
    {
        Text tamakazu_text = tamakazu_Object.GetComponent<Text> ();
        if (Input.GetKeyDown(KeyCode.Space))
        {
            if (tamakazu >= 1)
            {
                float x = Random.Range(-2, 2);
                Instantiate(tama, new Vector3(x, 3, 0), Quaternion.identity);
                tamakazu -= 1;
            }
        }
        tamakazu_text.text = "x" + tamakazu.ToString();
    }
}
