using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using DG.Tweening;

public class Study03 : MonoBehaviour
{
    [SerializeField] private Transform switchObj;

    private bool isSwitchOn;
    private void OnMouseDown()
    {
        var com = GameManager.ins.comManager;

        if (isSwitchOn)
        {
            switchObj.DOLocalMoveX(0.00381f, 0.3f);
            isSwitchOn = false;
            if(com.isConnected) com.WriteBool(GameManager.ins.gameData.BoolBlockToWrite, false);
        }
        else
        {
            switchObj.DOLocalMoveX(-0.00033f, 0.3f);
            isSwitchOn = true;
            if(com.isConnected) com.WriteBool(GameManager.ins.gameData.BoolBlockToWrite, true);
        }
    }
}
