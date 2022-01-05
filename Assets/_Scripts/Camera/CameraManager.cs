using Cinemachine;
using UnityEngine;

public class CameraManager : MonoBehaviour
{
    public CinemachineVirtualCamera
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
        ChangeCamera(MainMenuCam);
    }

    public void ChangeCamera(CinemachineVirtualCamera VirCam) 
    {
        activeCam?.gameObject.SetActive(false);
        VirCam.gameObject.SetActive(true);
        activeCam = VirCam;
    }
}
