using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class BasicButton : MonoBehaviour
{
    Button button;
    public GameObject TabToOpen;
    public float ScaleWhenMouseOver;
    public GameObject[] TabList=new GameObject[3];
    public int tabCodeToOpen;
    Vector3 initialScale;
    bool CluesComplete = false;
    private void Start()
    {
        initialScale = GetComponent<RectTransform>().localScale;
    }
    public void MouseOver()
    {
        gameObject.GetComponent<RectTransform>().localScale = initialScale* ScaleWhenMouseOver;
    }
    public void MouseExit()
    {
        gameObject.GetComponent<RectTransform>().localScale = initialScale;
    }
    public void ClickToOpenTab()
    {
        TabToOpen.SetActive(true);
    }
    public void OpenTabInTabList()
    {
        for(int i = 0; i < 4; i++)
        {
            TabList[i].SetActive(false);
        }
        TabList[tabCodeToOpen].SetActive(true);
    }
    public void ClickToCloseTab()
    {
        TabToOpen.SetActive(false);
    }
    public void SubmitClues()
    {
        ClueCheck();
        if (CluesComplete)
        {
            TabToOpen.SetActive(true);
        }
    }
    void ClueCheck()
    {
        CluesComplete = true;
    }
    public void ExitAfterWin()
    {
        Debug.Log("Exit");
    }
}
