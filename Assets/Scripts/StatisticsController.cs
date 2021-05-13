using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;

public class StatisticsController : Singleton<StatisticsController>
{
    int people = 500;


    [SerializeField]
    private TextMeshProUGUI PeopleValue;

    private void UpdatePeopleValue()
    {
        PeopleValue.text = people.ToString();
    }

    public void AddPeople(int i) 
    {
        people += i;
        UpdatePeopleValue();
    }

    public void RemovePeople(int i)
    {
        people -= i;
        Mathf.Clamp(people, 0, 100000);
        UpdatePeopleValue();

        // TODO: End game if the amount of people goes to 0
    }

    // Start is called before the first frame update
    void Start()
    {
    }

    // Update is called once per frame
    void Update()
    {
        
    }


}
