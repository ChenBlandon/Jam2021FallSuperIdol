using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class Clue : MonoBehaviour
{
    public enum Owner { A,B,C,D};
    public Owner CurrentOwner;
    public int ClueCode;
    public GameObject InfoPage;
    public void ClickToOpenInfoPage()
    {
        InfoPage.SetActive(true);
    }
}
