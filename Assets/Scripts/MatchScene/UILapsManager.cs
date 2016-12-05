﻿using UnityEngine;
using UnityEngine.UI;
using System.Collections;

public class UILapsManager : MonoBehaviour
{
    public Text timerLabel;
    public int lap = -10;

	
	void Update ()
    {
        int __lap = GameSceneManager.instance.player.laps;
        if (__lap == lap)
            return;

        if (__lap == -1)
            timerLabel.text = "LAP 1/3";
        else if (__lap == 3)
            timerLabel.text = GetPositionText (GameSceneManager.instance.player.currentPlace)+ " Place";
        else
            timerLabel.text = "LAP " + (__lap + 1).ToString() + "/3";
	}

    private string GetPositionText(int p_position)
    {
        if (p_position == 0)
            return "1st";
        else if (p_position == 1)
            return "2nd";
        else if (p_position == 2)
            return "3rd";
        else
            return "4th";
    }
}
