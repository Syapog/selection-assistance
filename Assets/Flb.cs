using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Flb : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{


    [SerializeField] private GameObject flb;
    

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        flb.SetActive(true);
        Debug.Log("входит");
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        flb.SetActive(false);
        Debug.Log("И выходит");
    }
}