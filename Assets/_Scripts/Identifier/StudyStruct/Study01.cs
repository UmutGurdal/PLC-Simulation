using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study01 : MonoBehaviour
{
    [SerializeField] private Material
        LedOpenMat,
        LedClosedMat;
    [SerializeField] private MeshRenderer LEDrenderer;

    private void Update()
    {
        if (!GameManager.ins.comManager.isConnected) return;

        bool isPressed = GameManager.ins.comManager.ReadBool(GameManager.ins.gameData.BoolBlockToRead);

        if (isPressed) LEDrenderer.material = LedOpenMat;
        else LEDrenderer.material = LedClosedMat;
    }
}
