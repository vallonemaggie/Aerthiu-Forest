using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;


public class TextSpawn : MonoBehaviour
{
    //[SerializeField]
    public GameObject text;

    void Start()
    {
        text.SetActive(false);
    }
     void OnTriggerEnter2D(Collider2D other)
    {
        if (other.CompareTag("Player"))
        {
            text.SetActive(true);
            Destroy(text, 3.0f);
            Destroy(this.gameObject, 3.0f);
            Debug.Log("Text Spawned.");
        }
    }

}