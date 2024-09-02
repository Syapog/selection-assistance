using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Luk : MonoBehaviour
{


    [SerializeField] private GameObject luk;
    [SerializeField] private GameObject fla;
    [SerializeField] private GameObject flb;
    [SerializeField] private GameObject flc;

    public GameObject box;

    private void Update()
    {
        Shoot();
        NoShoot();
    }

    void Shoot()
    {
        if (Vector3.Distance(box.transform.position, transform.position) > 10f) 
        {
            luk.SetActive(true);
            fla.SetActive(false);
            flb.SetActive(false);
            flc.SetActive(false);
            Debug.Log("AAAAAAA"); 
        }
        
    }

    void NoShoot()
    {
        if (Vector3.Distance(box.transform.position, transform.position) < 10f)
        {
            luk.SetActive(false);
            Debug.Log("входитAAAAAA");
        }
    }
}
