using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Hit : MonoBehaviour
{
    int counter = 0;
    public GameObject Duck;

    public Text text;
    void Start()
    {
        text.text = "Score: " + counter;
    }

    void OnMouseDown()
    {
        counter += 500;
        text.text = "Score: " + counter;
        Destroy(this.gameObject);
        // Instantiate(Duck);
    }
}