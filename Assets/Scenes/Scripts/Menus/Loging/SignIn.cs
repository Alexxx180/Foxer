using UnityEngine;
using UnityEngine.UI;

public class SignIn : MonoBehaviour
{
    public InputField snm;
    public InputField login;
    public InputField password;
    public InputField repeat;
    public Toggle agreement;
    public GameObject show;
    public GameObject hide;
    //public GameObject bind;

    bool NA(InputField field)
    {
        return field.text == "";
    }

    public void SignOnClick()
    {
        if (NA(snm) || NA(login) || NA(password) || NA(repeat))
            return;
        if (password.text == repeat.text && agreement.isOn)
        {
            show.SetActive(true);
            hide.SetActive(false);
            //bind.SetActive(true);
        }
    }
}
