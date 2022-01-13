using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using S7.Net;

public class InputFieldHandler : MonoBehaviour
{
    [Header("General PLC")]
    [SerializeField] private TMP_InputField ipAddress;
    [SerializeField] private TMP_InputField rack;
    [SerializeField] private TMP_InputField slot;
    [SerializeField] private TMP_Dropdown dropdown;

    [Header("PLC Datablock")]
    [SerializeField] private TMP_InputField readBool;
    [SerializeField] private TMP_InputField writeBool;
    [SerializeField] private TMP_InputField readInt;
    [SerializeField] private TMP_InputField writeInt;



    private GameData data;

    private void Awake()
    {
        data = GameManager.ins.gameData;    
    }


    private void OnEnable()
    {
        dropdown.value = (int)data.cpuType;
        ipAddress.text = data.ip;
        rack.text = data.rack.ToString();
        slot.text = data.slot.ToString();

        readBool.text = data.BoolBlockToRead;
        writeBool.text = data.BoolBlockToWrite;
        readInt.text = data.IntBlockToRead;
        writeInt.text = data.IntBlockToWrite;
    }

    public void ChangeCpuType(int i) 
    {
        data.cpuType = (CpuType)i;
    }
    public void ChangeIpAddress(string str) 
    {
        data.ip = str;    
    }

    public void ChangeRack(string str) 
    {
        data.rack = int.Parse(str);
    }

    public void ChangeSlot(string str) 
    {
        data.slot = int.Parse(str);
    }

    public void BoolReadBlock(string str) 
    {
        data.BoolBlockToRead = str;
    }

    public void BoolWriteBlock(string str) 
    {
        data.BoolBlockToWrite = str;
    }

    public void IntReadBlock(string str) 
    {
        data.IntBlockToRead = str;
    }

    public void IntWriteBlock(string str)
    {
        data.IntBlockToWrite = str;
    }
}
