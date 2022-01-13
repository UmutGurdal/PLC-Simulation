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
        float speed;
        
        if (isPressed) speed = rotSpeed;
        else speed = 0;

        motorMil.Rotate(0, motorMil.rotation.y + speed * Time.deltaTime, 0);
    }
}