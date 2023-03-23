using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class FlashLight : MonoBehaviour
{
    [SerializeField] GameObject FlashlightLight;
    private bool FlashlightAcrive = false;
    // Start is called before the first frame update
    void Start()
    {
        FlashlightLight.gameObject.SetActive(false);
    }

    // Update is called once per frame
    void Update()
    {
        if(Input.GetKeyDown(KeyCode.F))
        {
            if (FlashlightAcrive == false)
            {
                FlashlightLight.gameObject.SetActive(true);
                FlashlightAcrive = true;
            }
            else
            {
                FlashlightLight.gameObject.SetActive(false);
                FlashlightAcrive = false;
            }
        }
    }
}
