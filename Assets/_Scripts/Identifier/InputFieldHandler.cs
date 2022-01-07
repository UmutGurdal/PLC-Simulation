using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
using UnityEngine.UI;
using S7.Net;

public class InputFieldHandler : MonoBehaviour
{
    [SerializeField] private TMP_InputField
        ipAddress,
        rack,
        slot,
        dataBlock;

    [SerializeField] private TMP_Dropdown dropdown;

    private void OnEnable()
    {
        dropdown.value = (int)GameManager.ins.gameData.cpuType;
        ipAddress.text = GameManager.ins.gameData.ip;
        rack.text = GameManager.ins.gameData.rack.ToString();
        slot.text = GameManager.ins.gameData.slot.ToString();
        dataBlock.text = GameManager.ins.gameData.dataBlock;
    }

    public void ChangeCpuType(int i) 
    {
        GameManager.ins.gameData.cpuType = (CpuType)i;
    }
    public void ChangeIpAddress(string str) 
    {
        GameManager.ins.gameData.ip = str;    
    }

    public void ChangeRack(string str) 
    {
        GameManager.ins.gameData.rack = int.Parse(str);
    }

    public void ChangeSlot(string str) 
    {
        GameManager.ins.gameData.slot = int.Parse(str);
    }

    public void ChangeDataBlock(string str) 
    {
        GameManager.ins.gameData.dataBlock = str;
    }
}
