using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class InterfaceManager : MonoBehaviour
{
    [SerializeField]
    private InterfaceElement
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
        ChangeUI(MenuType.MainMenu);
    }

    public void ChangeUI(MenuType menuType)
    {
        activeInterface?.gameObject.SetActive(false);

        switch (menuType)
        {
            case MenuType.MainMenu:
                MainMenu.gameObject.SetActive(true);
                activeInterface = MainMenu;
                break;

            case MenuType.StudyMenu:
                StudyMenu.gameObject.SetActive(true);
                activeInterface = StudyMenu;
                break;

            case MenuType.Table:
                TableMenu.gameObject.SetActive(true);
                activeInterface = TableMenu;
                break;
        }

    }
}
