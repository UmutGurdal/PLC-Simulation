using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;

public class GameManager : MonoBehaviour
{
    public static GameManager ins;

    [Space][Header("Managers")]
    public CameraManager cameraManager;
    public InterfaceManager interfaceManager;
    

    private void Awake()
    {
        ins = this;
    }

    public void ChangeToMainMenu() 
    {
    
    }

    public void ChangeToStudyMenu() 
    {
        MenuType menuType = MenuType.StudyMenu;
        cameraManager.ChangeCamera(menuType);
        interfaceManager.ChangeUI(menuType);
    }

    public void ChangeToTableMenu() 
    {
    
    }

    
}
