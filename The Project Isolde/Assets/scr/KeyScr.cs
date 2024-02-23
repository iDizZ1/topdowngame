using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
using TMPro;
using System;
using UnityEngine.SceneManagement;

public class KeyScr : MonoBehaviour
{
    public TMP_Text Textfield;
    public TMP_Text TextAnswer;
    public GameObject Conti;
    public int a = 0;
    int le = 9;

    public void Contin(){
        if (Textfield.text != "" && Textfield.text != "Гастер" && TextAnswer.text != ""){
            SceneManager.LoadScene("Loc1");
        }
    }
    public void Reset(){
        Textfield.text = "";
        a = 0;
        TextAnswer.text = "";
        Conti.SetActive(false);
    }
    public void BackSpace(){
        if (a == 99){
            Textfield.text = "";
            a = 0;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
        else if (a > 0){
            Textfield.text = Textfield.text.Remove(a - 1);
            a = a - 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
    }
    public void Enter(){
        if (Textfield.text != ""){
            Conti.SetActive(true);
            switch (Textfield.text)
            {
                //отслыки на лор мира
                case "Ольга":
                    TextAnswer.text = "Верное имя.";
                    break;
                case "Оля":
                    TextAnswer.text = "Верное имя.";
                    break;
                case "Андрей":
                    TextAnswer.text = "Не все в этом мире обречены на счастье";
                    break;
                case "Наталья":
                    TextAnswer.text = "Ваша жизнь превратится в ад"; //когда-то это имя будет активировать хард-мод
                    break;
                case "Наташв":
                    TextAnswer.text = "Ваша жизнь превратится в ад"; //когда-то это имя будет активировать хард-мод
                    break;
                //отсылки на другие игры
                case "Чара":
                    TextAnswer.text = "Где ножи? = )";
                    break;
                case "Андертейл":
                    TextAnswer.text = "В ЭТОМ МИРЕ УБИВАЙ ИЛИ БУДЕШЬ УБИТ";
                    break;
                case "Тобифокс":
                    TextAnswer.text = "Гав.";
                    Textfield.text = "Тоби Фокс";
                    a = 99;
                    break;
                break;
                case "Тоби Фокс":
                    TextAnswer.text = "Гав.";
                    Textfield.text = "Тоби Фокс";
                    a = 99;
                    break;
                break;
                case "Бёрдли":
                    TextAnswer.text = "ГЕЙМЕРЫ НЕ УМИРАЮТ!";
                    break;
                case "Цесаревич":
                    TextAnswer.text = "Fiat iustitia, et pereat mundus";
                    break;
                case "Алексей":
                    TextAnswer.text = "Fiat iustitia, et pereat mundus";
                    break;
                //отсылки на реальных личностей, но имя можно ввести
                case "Сахаров":
                    TextAnswer.text = "Я считаю, что какой-то высший смысл существует и во вселенной, и в человеческой жизни тоже";
                    break;
                case "Декарт":
                    TextAnswer.text = "я мыслю следовательно я существую";
                    break;
                //отсылки на реальных личностей, имя нельзя ввести
                case "Ленин":
                    TextAnswer.text = "...";
                    Textfield.text = "";
                    a = 0;
                    Conti.SetActive(false);
                    break;
                case "Сталин":
                    TextAnswer.text = "Неверный таймлайн";
                    Textfield.text = "";
                    Conti.SetActive(false);
                    a = 0;
                    break;
                case "Гитлер":
                    TextAnswer.text = "Запрещаю.";
                    Textfield.text = "";
                    Conti.SetActive(false);
                    a = 0;
                    break;
                //отсылка на Гастера, вылет игры
                case "Гастер":
                    TextAnswer.text = "ERROR№17";
                    a = 99;
                    Conti.SetActive(false);
                    Application.Quit();
                    break;
                //иные отсылки
                case "Вейнмайер":
                    TextAnswer.text = "Не знаю, кто это, но звучит круто";
                    break;
                break;
                //дефолт
                default:
                    TextAnswer.text = "Выбрать это имя?";
                    break;
            }
        }
    }
    public void SetTextFF(){
        if (a == 0){
                Textfield.text += 'Ё';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ё';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextQ(){
        if (a == 0){
                Textfield.text += 'Й';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'й';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextW(){
        if (a == 0){
                Textfield.text += 'Ц';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ц';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextE(){
        if (a == 0){
                Textfield.text += 'У';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'у';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
        public void SetTextR(){
        if (a == 0){
                Textfield.text += 'К';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'к';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextT(){
        if (a == 0){
                Textfield.text += 'Е';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'е';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextY(){
        if (a == 0){
                Textfield.text += 'Н';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'н';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
        public void SetTextU(){
        if (a == 0){
                Textfield.text += 'Г';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'г';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
        public void SetTextI(){
        if (a == 0){
                Textfield.text += 'Ш';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ш';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextO(){
        if (a == 0){
                Textfield.text += 'Щ';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'щ';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextP(){
        if (a == 0){
                Textfield.text += 'З';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'з';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextPP(){
        if (a == 0){
                Textfield.text += 'Х';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'х';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextPPP(){
        if (a == 0){
                Textfield.text += 'Ъ';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ъ';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
     public void SetTextA(){
        if (a == 0){
            Textfield.text += 'Ф';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
        else if (a < le){
            Textfield.text += 'ф';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
    }
     public void SetTextS(){
        if (a == 0){
            Textfield.text += 'Ы';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
        else if (a < le){
            Textfield.text += 'ы';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
    }
     public void SetTextD(){
            if (a == 0){
                Textfield.text += 'В';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'в';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextF(){
        if (a == 0){
            Textfield.text += 'А';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
        else if (a < le){
            Textfield.text += 'а';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
    }
    public void SetTextG(){
        if (a == 0){
            Textfield.text += 'П';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
        else if (a < le){
            Textfield.text += 'п';
            a = a + 1;
            TextAnswer.text = "";
            Conti.SetActive(false);
        }
    }
    public void SetTextH(){
        if (a == 0){
                Textfield.text += 'Р';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'р';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextJ(){
        if (a == 0){
                Textfield.text += 'О';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'о';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextK(){
        if (a == 0){
                Textfield.text += 'Л';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'л';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextL(){
        if (a == 0){
                Textfield.text += 'Д';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'д';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextLL(){
        if (a == 0){
                Textfield.text += 'Ж';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ж';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextLLL(){
        if (a == 0){
                Textfield.text += 'Э';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'э';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextZ(){
        if (a == 0){
                Textfield.text += 'Я';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'я';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextX(){
        if (a == 0){
                Textfield.text += 'Ч';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ч';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextC(){
        if (a == 0){
                Textfield.text += 'С';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'с';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextV(){
        if (a == 0){
                Textfield.text += 'М';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'м';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextB(){
        if (a == 0){
                Textfield.text += 'И';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'и';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextN(){
        if (a == 0){
                Textfield.text += 'Т';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'т';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextM(){
        if (a == 0){
                Textfield.text += 'Ь';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ь';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextMM(){
        if (a == 0){
                Textfield.text += 'Б';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'б';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
    public void SetTextMMM(){
        if (a == 0){
                Textfield.text += 'Ю';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
            else if (a < le){
                Textfield.text += 'ю';
                a = a + 1;
                TextAnswer.text = "";
                Conti.SetActive(false);
            }
    }
}
