using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Flc : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    [SerializeField] private GameObject flc;
 


    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        flc.SetActive(true);
        Debug.Log("входит");
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        flc.SetActive(false);
        Debug.Log("И выходит");
    }
}