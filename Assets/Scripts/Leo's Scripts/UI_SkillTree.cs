using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class UI_SkillTree : MonoBehaviour
{
    //skill buttons
    [SerializeField] private Button powerStrikeButton;

    [SerializeField] private GameObject skillPanel;
    [SerializeField] private GameObject meleeSkillPanel;
    [SerializeField] private GameObject magicSkillPanel;

    

    private bool skillPanelIsActivated = true;
    public static bool meleeSkillPanelOn = true;
    public static bool magicSkillPanelOn = false;


    // Start is called before the first frame update
    void Start()
    {
        skillPanel.SetActive(skillPanelIsActivated);
        skillPanel.SetActive(meleeSkillPanelOn);
        skillPanel.SetActive(magicSkillPanelOn);

        
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
    public void SetMeleePanelOn()
    {
        meleeSkillPanel.SetActive(true);
        meleeSkillPanelOn = true;
        magicSkillPanel.SetActive(false);
        magicSkillPanelOn = false;
    }
    public void SetMagicPanelOn()
    {
        magicSkillPanel.SetActive(true);
        magicSkillPanelOn = true;
        meleeSkillPanel.SetActive(false);
        meleeSkillPanelOn = false;
    }

    public void SetPowerStrike()
    {
        
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
