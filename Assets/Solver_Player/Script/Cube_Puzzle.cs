using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.InputSystem.HID;
using UnityEngine.UI;
using Vuforia;

public class Cube_Puzzle : MonoBehaviour
{
    private string solution = "";
    public Button red_cube;
    public Button yellow_cube;
    public Button green_cube;
    public Button blue_cube;
    public GameObject dance;

    public Text password;
    public Text res;
    public string TargetString = "rgby";
    private int Counter = 0;


    // Start is called before the first frame update
    void Start()
    {
        dance.gameObject.SetActive(false);
        password.gameObject.SetActive(false);
        res.gameObject.SetActive(false);
        red_cube.onClick.AddListener(red_button_click);
        yellow_cube.onClick.AddListener(yellow_button_click);
        green_cube.onClick.AddListener(green_button_click);
        blue_cube.onClick.AddListener(blue_button_click);
    }

    //rbgy
    void red_button_click()
    {
        solution += "r";
        Counter++;
        Debug.Log("red Clicked");
        if (Counter % 4 == 0)
        {
            res.gameObject.SetActive(true);
            if (solution.Equals(TargetString))
            {
                //print the pass for next puzzle 
                solution = "";

                password.gameObject.SetActive(true);
                res.text = "Winner!";
                dance.gameObject.SetActive(true);
                // Debug.Log("Winner!");
            }

            else
            {
                solution = "";
                res.text = "Try Again!";
                // Debug.Log("Try Again!");
                //print try again  (wrong pattern ) 
            }
        }
    }

    void blue_button_click()
    {
        solution += "b";
        Counter++;
        Debug.Log("blue Clicked");
        if (Counter % 4 == 0)
        {
            res.gameObject.SetActive(true);
            if (solution.Equals(TargetString))
            {
                //print the pass for next puzzle 
                solution = "";
                password.gameObject.SetActive(true);

                res.text = "Winner!";
                dance.gameObject.SetActive(true);

                // Debug.Log("Winner!");
            }

            else
            {
                solution = "";

                res.text = "Try Again!";
                // Debug.Log("Try Again!");
                //print try again  (wrong pattern ) 
            }
        }
    }

    void green_button_click()
    {
        solution += "g";
        Counter++;
        if (Counter % 4 == 0)
        {
            res.gameObject.SetActive(true);
            if (solution.Equals(TargetString))
            {
                solution = "";
                password.gameObject.SetActive(true);

                //print the pass for next puzzle 
                res.text = "Winner!";
                dance.gameObject.SetActive(true);

                // Debug.Log("Winner!");
            }

            else
            {
                solution = "";

                res.text = "Try Again!";
                // Debug.Log("Try Again!");
                //print try again  (wrong pattern ) 
            }
        }
    }

    void yellow_button_click()
    {
        solution += "y";
        Counter++;
        if (Counter % 4 == 0)
        {
            res.gameObject.SetActive(true);
            if (solution.Equals(TargetString))
            {
                solution = "";
                password.gameObject.SetActive(true);

                res.text = "Winner!";
                dance.gameObject.SetActive(true);

                //print the pass for next puzzle 
                // Debug.Log("Winner!");
            }

            else
            {
                solution = "";

                res.text = "Try Again!";
                // Debug.Log("Try Again!");
                //print try again  (wrong pattern ) 
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        // red_cube.onClick.AddListener(red_button_click);
        // blue_cube.onClick.AddListener(blue_button_click);
        // green_cube.onClick.AddListener(green_button_click);
        // yellow_cube.onClick.AddListener(yellow_button_click);
    }
}