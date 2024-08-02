using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class DoorManager : ObsBase
{
    public bool isOpen;
    public GameObject doorObject; 
    public List<GameObject> doorsList;
    void Start()
    {
        // isOpen = doorsList[0].GetComponent<ButtonBase2>().isButtonOn;
        // isOn = doorsList[0].GetComponent<ObsBase>().isObs;
        UpdateDoorAppearance();
    }

    // Update is called once per frame
    void Update()
    {
        if (Input.GetKeyDown(KeyCode.E))
        {
            SwitchDoor();
        }
        
    }

    public override bool CanPassThrough()
    {
        return isOpen;
    }

    public void SwitchDoor()
    {
        isOpen = !isOpen;
        // 更新门的外观或状态
        UpdateDoorAppearance();
    }

    private void UpdateDoorAppearance()
    {
        if (doorObject != null)
        {
            /* 在这里处理门的外观，例如显示/隐藏门或播放动画 */

            doorObject.SetActive(!isOpen);
            
            Debug.Log(isOpen ? "Door is now open." : "Door is now closed.");
        }
    }
}
