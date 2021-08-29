using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class PrintAndHide : MonoBehaviour
{
    private int i = 3;
    public Renderer rend;
    private int random;
    // Start is called before the first frame update
    void Start()
    {
        random = Random.Range(200, 251); 
    }

    // Update is called once per frame
    void Update()
    {
        i++;
        Debug.Log(gameObject.name + ":" + i);

//        GameObject.FindWithTag();

//        Debug.Log(GameObject.FindGameObjectsWithTag("Red"));
        if (i == 100 && gameObject.CompareTag("Red"))
        {
            gameObject.SetActive(false);
        }

        if (i == random && gameObject.CompareTag("Blue"))
        {
            rend.enabled = false;
        }
    }
}
