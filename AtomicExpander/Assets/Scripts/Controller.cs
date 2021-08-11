using UnityEngine;
using TMPro;
using BreakInfinity;

public class Controller : MonoBehaviour
{
    public Data data;

    public TMP_Text matterText;

    public void Start()
    {
        data = new Data();
    }
    public void Update()
    {
        matterText.text = data.matter + " Matter";
        data.matter++;
    }

    public void matterClick()
    {
        data.matter += 1;
    }
}
