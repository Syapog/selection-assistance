using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;


public class Mous : MonoBehaviour, IPointerEnterHandler, IPointerExitHandler
{
  

    [SerializeField] private GameObject fla;
 
   

    void IPointerEnterHandler.OnPointerEnter(PointerEventData eventData)
    {
        fla.SetActive(true);
        Debug.Log("входит");
    }

    void IPointerExitHandler.OnPointerExit(PointerEventData eventData)
    {
        fla.SetActive(false);
        Debug.Log("И выходит");
    }
}
