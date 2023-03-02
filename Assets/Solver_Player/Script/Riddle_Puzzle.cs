using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Net.Mime;
using UnityEngine;
using UnityEngine.SocialPlatforms.Impl;
using UnityEngine.UI;

public class Riddle_Puzzle : MonoBehaviour
{
    public Button correct;
    public Button wrong2;
    public Button wrong1;
    public GameObject dance;


    public Text passwordValue;
    public Text tryAgain;

    // Start is called before the first frame update
    void Start()
    {
        dance.gameObject.SetActive(false);
        passwordValue.gameObject.SetActive(false);
        tryAgain.gameObject.SetActive(false);

        correct.onClick.AddListener(correctChosen);
        wrong2.onClick.AddListener(wrongChosen);
        wrong1.onClick.AddListener(wrongChosen);
    }

    // Update is called once per frame
    void Update()
    {
    }

    public void wrongChosen()
    {
        tryAgain.gameObject.SetActive(true);
    }

    public void correctChosen()
    {
        dance.gameObject.SetActive(true);
        tryAgain.gameObject.SetActive(false);
        passwordValue.gameObject.SetActive(true);
    }
}