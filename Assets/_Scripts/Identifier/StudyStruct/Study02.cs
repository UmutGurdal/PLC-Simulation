using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Study02 : MonoBehaviour
{
    [SerializeField] private float rotSpeed;
    [SerializeField] private Transform motorMil;
    private void Update()
    {
        if (!GameManager.ins.comManager.isConnected) return;

        bool isPressed = GameManager.ins.comManager.ReadPlcData("DB1.DBX0.0");

        if (isPressed) transform.rotation = Quaternion.Euler(0,transform.rotation.y + rotSpeed,0);
        else transform.rotation = Quaternion.Euler(0, transform.rotation.y, 0);
    }
}