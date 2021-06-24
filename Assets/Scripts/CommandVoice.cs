using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;

public class CommandVoice : MonoBehaviour
{
    // Start is called before the first frame update

    public GameObject lightPoint;

    public Text commandListing;

    public Transform cameraMain;

    public Transform[] point;

    public string CommandText { get; set; }

    void Start()
    {
        
    }

    // Update is called once per frame
    void Update()
    {
        
    }

    public string getCommandVoice()
    {
        return "Check";
    }

    public void startCommand()
    {
        Debug.Log("this ok");
        //lightPoint.SetActive(false);
    }

    public void stopCommand()
    {
        Debug.Log("stop ok"+ this.CommandText);
        commandListing.text = this.CommandText;


        //lightPoint.SetActive(CommandText.Contains("bật đèn"));
        if (this.CommandText.ToLower().Contains("bật đèn"))
        {
            lightPoint.SetActive(true);
        }
        if (this.CommandText.ToLower().Contains("tắt đèn"))
        {
            lightPoint.SetActive(false);
        }

        if (this.CommandText.ToLower().Contains("phòng khách"))
        {
            //lightPoint.SetActive(false);
            Debug.Log("Phong khách");
            camTransform(0);
        }

        if (this.CommandText.ToLower().Contains("phòng ngủ"))
        {
            //lightPoint.SetActive(false);
            Debug.Log("Phong khách");
            camTransform(1);
        }

    }

    private void camTransform(int index)
    {

        cameraMain.transform.position = point[index].position;
    }

}
