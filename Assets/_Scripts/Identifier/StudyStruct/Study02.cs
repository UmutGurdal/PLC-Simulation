using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study02 : MonoBehaviour
{
    [SerializeField] private float rotSpeed = 10;
    [SerializeField] private Transform motorMil;

    private void Update()
    {
        if (!GameManager.ins.comManager.isConnected) return;

        bool isPressed = GameManager.ins.comManager.ReadBool(GameManager.ins.gameData.BoolBlockToRead);
        float speed = GameManager.ins.comManager.ReadInt(GameManager.ins.gameData.IntBlockToRead);
        
        if (isPressed) rotSpeed = speed * 100;
        else rotSpeed = 0;

        motorMil.Rotate(0, motorMil.rotation.y + rotSpeed * Time.deltaTime, 0);
    }
}