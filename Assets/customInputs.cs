using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class customInputs : MonoBehaviour
{
    [SerializeField] GameObject MenuCanvas;
    public void OnMenu() => MenuCanvas.SetActive(!MenuCanvas.activeInHierarchy);
    
}
