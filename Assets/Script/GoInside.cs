using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.Assertions;
using UnityEngine.UI;

public class GoInside : MonoBehaviour
{
    bool correct = false;

    void Start()
    {
        DebugUIBuilder.instance.AddLabel("You can choose");
        DebugUIBuilder.instance.AddButton("Go Inside", () => LoadScene(0));
        
        DebugUIBuilder.instance.AddLabel("Make a choice", 3);
		DebugUIBuilder.instance.AddDivider(3);
        DebugUIBuilder.instance.AddRadio("Choice A", "group2", delegate(Toggle t) { RadioPressed("Choice A", "group2", t); }, 3);
        DebugUIBuilder.instance.AddRadio("Choice B", "group2", delegate(Toggle t) { RadioPressed("Choice B", "group2", t); }, 3);
        DebugUIBuilder.instance.AddRadio("Choice C", "group2", delegate(Toggle t) { RadioPressed("Choice C", "group2", t); }, 3);
        DebugUIBuilder.instance.AddRadio("Choice D", "group2", delegate(Toggle t) { RadioPressed("Choice D", "group2", t); }, 3);
        DebugUIBuilder.instance.AddButton("Submit", CheckAnswer, 3);
        DebugUIBuilder.instance.Show();
        // DebugUIBuilder.instance.Hide();
    }

    void LoadScene(int idx)
    {
        // DebugUIBuilder.instance.Hide();
        Debug.Log("Load scene: " + idx);
        UnityEngine.SceneManagement.SceneManager.LoadScene(idx);
    }

    public void RadioPressed(string radioLabel, string group, Toggle t)
    {
        Debug.Log("Radio value changed: "+radioLabel+", from group "+group+". New value: "+t.isOn);
        if(radioLabel.Equals("Choice C"))
        {
            correct = true;
        }
        else
        {
            correct = false;
        }
    }

    void CheckAnswer()
    {
        if(correct)
        {
            
            DebugUIBuilder.instance.AddLabel("Your answer is correct!", 3);
        }
        else
        {
            DebugUIBuilder.instance.AddLabel("Your answer is not correct!", 3);
            DebugUIBuilder.instance.AddLabel("Please try again", 3);
        }
    }

    public void ShowPuzzle()
    {
        DebugUIBuilder.instance.Show();
    }
}
