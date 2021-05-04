using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    public class MessageBox : MonoBehaviour
    {
        [SerializeField] GameObject canvas;
        [SerializeField] Text Message;
        [SerializeField] Text Title;
        public static MessageBox Instance; 

        public string m_messageText;
        public string m_titleText;

        void Awake() {
            Instance = this;
            //button.onClick.RemoveAlListeners();
            //button.onClick.AddListener(Hide);
        }

        public MessageBox setMessage(string message){
            m_titleText = "Información"; 
            m_messageText = message;
            return Instance;
        }

        public MessageBox Show() {
            Message.text = m_messageText;
            Title.text = m_titleText;
            //Title.color = m_color;
            canvas.SetActive(true);
            return Instance;
        }

        public MessageBox setError(string message){
            m_titleText = "Error"; 
            m_messageText = message;
            return Instance;
        }

        public MessageBox Hide() {
            canvas.SetActive(false);
            return Instance;
        }
         
    }