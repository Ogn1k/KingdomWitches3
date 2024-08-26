using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Dark;
    public GameObject Light;
    private bool True = true;
    private void OnTriggerEnter2D(Collider2D collision)
    {
        Dark.SetActive(false);
        Light.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        Dark.SetActive(true);
        Light.SetActive(false);
    }
}
