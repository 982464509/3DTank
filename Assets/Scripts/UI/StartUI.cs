using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class StartUI : MonoBehaviour
{

    public GameObject rookiePanel;
    public GameObject oldPanel;
    public GameObject storyPanel;
    public GameObject installPanel;

    void Start () {
		
	}
	
	void Update () {
		
	}


    public void Quit()
    {
        Application.Quit();
    }

    public void RookieButton()  //召唤出提示信息面板
    {
        rookiePanel.SetActive(true);
    }
    public void RookieButtonDown()  //关闭提示信息面板
    {
        rookiePanel.SetActive(false);
    }

    public void oldPanelButton()  //召唤出老手选择存档信息面板
    {
        oldPanel.SetActive(true);
    }
    public void oldPanelButtonDown()  //关闭老手选择存档信息面板
    {
        oldPanel.SetActive(false);
    }

    public void storyPanelButton()  //召唤出故事面板
    {
        storyPanel.SetActive(true);
    }
    public void storyPanelButtonDown()  //关闭故事面板
    {
        storyPanel.SetActive(false);
    }

    public void installPanelButton()  //召唤出设置面板
    {
        installPanel.SetActive(true);
    }
    public void installPanelButtonDown()  //关闭设置面板
    {
        installPanel.SetActive(false);
    }
}
