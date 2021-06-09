using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Deleter : MonoBehaviour
{
    public int counter = 0;
    public Text text;

    public void OnTriggerEnter(Collider collision)
    {
        if (collision.gameObject.CompareTag("MoveObst"))
        {
            counter++;
            Destroy(collision.gameObject);
            text.text = counter.ToString(); 

        }
    }
}
