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
        if (isSwitchOn)
        {
            switchObj.DOLocalMoveX(0.00381f, 0.3f);
            isSwitchOn = false;
            //GameManager.ins.comManager.WriteBool();
        }
        else
        {
            switchObj.DOLocalMoveX(-0.00033f, 0.3f);
            isSwitchOn = true;
            //GameManager.ins.comManager.WriteBool();
        }
    }
}
