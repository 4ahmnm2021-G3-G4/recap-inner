﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using UnityEngine.SceneManagement;

public class ChangeScene : MonoBehaviour{
 
public void changeToCalculator(string scene_name){

     SceneManager.LoadScene(scene_name);

    }


    
}

