using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class ButtonHandler : MonoBehaviour
{
    // Start is called before the first frame update
    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void ChangeToMainMenu()
    {
        GameManager.ins.cameraManager.ChangeCamera(GameManager.ins.cameraManager.MainMenuCam);
        StartCoroutine(GameManager.ins.interfaceManager.ChangeUI(GameManager.ins.interfaceManager.MainMenu, 2));
    }

    public void ChangeToStudyMenu()
    {
        GameManager.ins.cameraManager.ChangeCamera(GameManager.ins.cameraManager.StudyMenuCam);
        StartCoroutine(GameManager.ins.interfaceManager.ChangeUI(GameManager.ins.interfaceManager.StudyMenu, 2));
    }

    public void ChangeToStudyOne() 
    {
        GameManager.ins.cameraManager.ChangeCamera(GameManager.ins.cameraManager.TableCam);
        StartCoroutine(GameManager.ins.interfaceManager.ChangeUI(GameManager.ins.interfaceManager.TableMenu, 2));
        GameManager.ins.studyManager.ChangeStudy(GameManager.ins.studyManager.StudyOne);
    }

    public void ChangeToStudyTwo()
    {
        GameManager.ins.cameraManager.ChangeCamera(GameManager.ins.cameraManager.TableCam);
        StartCoroutine(GameManager.ins.interfaceManager.ChangeUI(GameManager.ins.interfaceManager.TableMenu, 2));
        GameManager.ins.studyManager.ChangeStudy(GameManager.ins.studyManager.StudyTwo);
    }

    public void ChangeToStudyThree()
    {
        GameManager.ins.cameraManager.ChangeCamera(GameManager.ins.cameraManager.TableCam);
        StartCoroutine(GameManager.ins.interfaceManager.ChangeUI(GameManager.ins.interfaceManager.TableMenu, 2));
        GameManager.ins.studyManager.ChangeStudy(GameManager.ins.studyManager.StudyThree);
    }

    public void ApplyButton() 
    {
        GameManager.ins.comManager.ConnectPlc();
    }

    public void ExitGame() 
    {
        Application.Quit();
    }
}
