using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GlobalsPPController : MonoBehaviour
{
    // Start is called before the first frame update
    [SerializeField] private GameObject globalPP1;
    [SerializeField] private GameObject globalPP2;
    [SerializeField] private GameObject globalPP3;

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        SwitchPostProsessings();
    }

    private void SwitchPostProsessings()
    {
        if (Input.GetKeyDown(KeyCode.Alpha1))
        {
            globalPP1.SetActive(true);
            globalPP2.SetActive(false);
            globalPP3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha2))
        {
            globalPP1.SetActive(true);
            globalPP2.SetActive(true);
            globalPP3.SetActive(false);
        }
        if (Input.GetKeyDown(KeyCode.Alpha3))
        {
            globalPP1.SetActive(true);
            globalPP2.SetActive(false);
            globalPP3.SetActive(true);
        }
    }
}
