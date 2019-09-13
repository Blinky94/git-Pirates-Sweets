using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class SaveIhmControler : MonoBehaviour
{
    public Text score;
    public Text pseudo;
    private int scoreValue;
    private string myPseudo = "Pseudo : Alto";
    private string saveFile;
    // Start is called before the first frame update
    void Start()
    {
        pseudo.text = myPseudo;
        saveFile = "Save.txt";
        scoreValue = 0;
    }

    private string concatScoreText(int value)
    {
        return string.Format("Score : {0} pts", value);
    }

    // Update is called once per frame
    public void addScoreValue(int value)
    {
        scoreValue += value;
        Debug.Log(scoreValue);
        score.text = concatScoreText(scoreValue);

    }

    public void saveData()
    {
       Datas datas = new Datas();
       datas.name = myPseudo;
       datas.score = scoreValue;
       DataManager.Save(datas, saveFile);
    }

    public void loadData()
    {
       Datas datas = (Datas)DataManager.Load(saveFile);
       score.text = concatScoreText(datas.score);

    }

}
