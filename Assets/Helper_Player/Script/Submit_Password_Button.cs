using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Submit_Password_Button : MonoBehaviour
{
    public Button btnClick;

    public InputField PasswordIn;

    private int counter = 1;

    public string StoredPassword1;

    public string StoredPassword2;

    public string StoredPassword3;

    public Text TryAgain;

    public Text Score;

    private void Start()
    {
        TryAgain.gameObject.SetActive(false);
        TryAgain.text = "Try Again!";
        Score.text = "0";
        btnClick.onClick.AddListener(CheckPassword);
    }

    private void Update()
    {
        if (counter >= 4)
        {
            TryAgain.text = "You Win!";
            TryAgain.gameObject.SetActive(true);
            //7ot el ragel el byr2os
        }
    }

    //add counter for mulitple levels and validate passwords

    //get input from textbox and compare it with stored password.
    //public GameObject Helper_Password_Inputfield = GameObject.Find("Helper_Password_Inputfield");


    public void CheckPassword()
    {
        switch (this.counter)
        {
            case 1:
                if (StoredPassword1.Equals(PasswordIn.text))
                {
                    TryAgain.gameObject.SetActive(false);
                    int x = int.Parse(Score.text) + 100;
                    Score.text = x.ToString();
                    this.counter++;
                    Debug.Log(counter);
                }
                else
                    TryAgain.gameObject.SetActive(true);

                break;
            case 2:
                if (StoredPassword2.Equals(PasswordIn.text))
                {
                    TryAgain.gameObject.SetActive(false);
                    int x = int.Parse(Score.text) + 100;
                    Score.text = x.ToString();
                    this.counter++;
                    Debug.Log(counter);
                }
                else
                    TryAgain.gameObject.SetActive(true);

                break;
            case 3:
                if (StoredPassword3.Equals(PasswordIn.text))
                {
                    TryAgain.gameObject.SetActive(false);
                    int x = int.Parse(Score.text) + 100;
                    Score.text = x.ToString();
                    this.counter++;
                    Debug.Log(counter);
                }
                else
                    TryAgain.gameObject.SetActive(true);

                break;
        }
    }
}