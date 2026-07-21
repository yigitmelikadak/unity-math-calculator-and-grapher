using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using OpenAI;

public class chatgptManager : MonoBehaviour
{
    private OpenAIApi api = new OpenAIApi();
    private List<ChatMessage> mesajlar = new List<ChatMessage>();
    public async void SoruChatGpt(string soruSor)
    {
        ChatMessage yeniMesaj = new ChatMessage();
        yeniMesaj.Content = soruSor;
        yeniMesaj.Role = "user";
        mesajlar.Add(yeniMesaj);
        CreateChatCompletionRequest istek = new CreateChatCompletionRequest();
        istek.Messages = mesajlar;
        istek.Model = "gpt-3.5-turbo";

        var cevap = await api.CreateChatCompletion(istek);
        if (cevap.Choices != null && cevap.Choices.Count > 0)
        {
            var mesaj2 = cevap.Choices[0].Message;
            mesajlar.Add(mesaj2);
            Debug.Log(mesaj2.Content);
        }
    }
}
