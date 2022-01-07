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
    public StudyManager studyManager;
    public CommunicationManager comManager;

    [Space][Header("Data")]
    public GameData gameData;
    

    private void Awake()
    {
        ins = this;
    }

        
}
