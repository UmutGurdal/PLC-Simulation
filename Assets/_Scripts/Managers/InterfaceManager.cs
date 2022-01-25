using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    public InterfaceElement
        MainMenu,
        StudyMenu,
        TableMenu;

    private InterfaceElement activeInterface;

    private void Awake()
    {
        InterfaceElement[] interfaces = GetComponentsInChildren<InterfaceElement>();
        foreach(InterfaceElement element in interfaces) 
        {
            element.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        StartCoroutine(ChangeUI(GameManager.ins.interfaceManager.MainMenu, 0));
    }

    public IEnumerator ChangeUI(InterfaceElement iElement, float delay) 
    {
        activeInterface?.gameObject.SetActive(false);
        yield return new WaitForSeconds(delay);
        iElement.gameObject.SetActive(true);
        activeInterface = iElement;
    }


}
