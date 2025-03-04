﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[System.Serializable]
public class BuildingData
{

    //{"buildingName":"satelite2","type":0,"incomeTime":10800,"incomeCoin":100,"buildTime":5,"cost":1000,"width":5,"height":5},

    public string buildingName;     //빌딩의 이름
    public int type;                //랜드마크인지 아닌지,landmark = 0, normal = 1
    public int incomeCoin;          //incomeCoin
    public int buildTime;           //건설에 걸리는 시간(초)
    public int cost;                //드는 비용
    public int width;               //garo             
    public int height;              //sero
    public int mileage;         //mileage
    public int sellCost;        //dd
    public GameObject prefab;       //prefab object
    public GameObject incompletedPrefab;    //건설중일때의 오브젝트
}
