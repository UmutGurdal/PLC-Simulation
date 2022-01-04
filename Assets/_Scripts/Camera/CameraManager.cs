using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    [SerializeField]
    private CinemachineVirtualCamera
        MainMenuCam,
        StudyMenuCam,
        TableCam;

    private CinemachineVirtualCamera activeCam;

    private void Awake()
    {
        CinemachineVirtualCamera[] cams = GetComponentsInChildren<CinemachineVirtualCamera>();
        foreach(CinemachineVirtualCamera element in cams) 
        {
            element.gameObject.SetActive(false);
        }
    }

    private void Start()
    {
        ChangeCamera(MenuType.MainMenu);
    }

    public void ChangeCamera(MenuType menuType) 
    {
        activeCam?.gameObject.SetActive(false);

        switch (menuType) 
        {
            case MenuType.MainMenu:
                MainMenuCam.gameObject.SetActive(true);
                activeCam = MainMenuCam;
                break;

            case MenuType.StudyMenu:
                StudyMenuCam.gameObject.SetActive(true);
                activeCam = StudyMenuCam;
                break;

            case MenuType.Table:
                TableCam.gameObject.SetActive(true);
                activeCam = TableCam;
                break;
        }
    }
}
