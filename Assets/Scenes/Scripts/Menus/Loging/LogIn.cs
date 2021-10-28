using UnityEngine;
using UnityEngine.UI;

public class LogIn : MonoBehaviour
{
    public InputField login;
    public InputField password;
    public GameObject show;
    public GameObject hide;
    //public GameObject bind;

    private const string _login = "CAHEK";
    private const string _pass = "2203";

    public void LogOnClick()
    {
        if (login.text == _login && password.text == _pass)
        {
            show.SetActive(true);
            hide.SetActive(false);
            //bind.SetActive(true);
        }
    }
}
