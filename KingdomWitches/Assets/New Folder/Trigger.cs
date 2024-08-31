using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Trigger : MonoBehaviour
{
    public GameObject Dark;
    public GameObject Light;
    private bool True = true;

    bool _entered = false;
    public float _fadeIn = 1;
    public float _fadeOut = 1;
    float _fade = 1;
    private void Update()
    {
        if(_entered)
        {
            if(_fade > 0)
            {
                float _colorDark = Mathf.Lerp(255, 0, 1/Time.deltaTime);
                Dark.GetComponent<Light>().intensity = _fade;
                _fade -= Time.deltaTime;
            }
        }
        else
        {
            if (_fade < _fadeOut)
            {
                float _colorLight = Mathf.Lerp(0, 255, 1/Time.deltaTime);
                Dark.GetComponent<Light>().intensity = _fade;
                _fade += Time.deltaTime;
            }
        }
    }

    private void OnTriggerEnter2D(Collider2D collision)
    {
        //_fade = _fadeIn;
        _entered = true;
        //Dark.SetActive(false);
        Light.SetActive(true);
    }
    private void OnTriggerExit2D(Collider2D collision)
    {
        //_fade = 0;
        _entered = false;
        //Dark.SetActive(true);
        Light.SetActive(false);
    }
}
