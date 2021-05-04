using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.UI;
    public class MessageBox : MonoBehaviour
    {
        [SerializeField] GameObject canvas;
        [SerializeField] Text Message;
        public static MessageBox Instance; 

        public string m_messageText;

        void Awake() {
            Instance = this;
            //button.onClick.RemoveAlListeners();
            //button.onClick.AddListener(Hide);
        }

        public MessageBox setMessage(string message){
            m_messageText = message;
            return Instance;
        }

        public MessageBox Show() {
            Message.text = m_messageText;
            canvas.SetActive(true);
            return Instance;
        }

        public MessageBox Hide() {
            canvas.SetActive(false);
            return Instance;
        }
         
    }