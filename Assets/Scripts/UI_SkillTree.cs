using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SkillTree : MonoBehaviour
{
    //[SerializeField] private Button powerUpButton;
    [SerializeField] private GameObject skillPanel;

    private bool skillPanelIsActivated = true;

    
    // Start is called before the first frame update
    void Start()
    {
        //powerUpButton = transform.Find("BtnPowerUp").GetComponent<Button>();
        skillPanel.SetActive(skillPanelIsActivated);
    }

    private void Awake()
    {
        //powerUpButton.onClick.AddListener(() => ButtonClicked(0));
    }

    private void Update()
    {
        if (Input.GetKeyDown(KeyCode.K))
        {
            skillPanel.SetActive(!skillPanel.activeSelf);
        }
    }
    /*void ButtonClicked(int clickedNumber)
    {
        if (Input.GetMouseButtonDown(0))
        {
            clickedNumber++;
        }
        Debug.Log("Button clicked =" + clickedNumber);
    }*/
}
