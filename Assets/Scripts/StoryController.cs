using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;

using TMPro;


public class StoryController : Singleton<StoryController>
{
    [SerializeField]
    private TextMeshProUGUI EncounterText;

    private string encounter;
    // Start is called before the first frame update
    void Start()
    {
        encounter = firstPart[Random.Range(0,firstPart.Length)] + " " + secondPart[Random.Range(0,secondPart.Length)];
        UpdateEncounterText(encounter);
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public void UpdateEncounterText(string s)
    {
        // Maximum length?
        EncounterText.text = s;
    }

    string[] firstPart = {
        "Example text 1 <color=blue><link id=1>my link</color></link>",
        "Example text 2 <color='blue'>my link</color>", 
        "Example text 3 <color='blue'>my link</color>"
    };   
    string[] secondPart = {
        "Example text 4",
        "Example text 5", 
        "Example text 6"
    };

}
