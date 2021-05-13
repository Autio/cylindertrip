using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class GameController : Singleton<GameController>
{
    // Start is called before the first frame update
    void Start()
    {
        StatisticsController.Instance.AddPeople(200);
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
