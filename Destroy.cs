using UnityEngine;

public class Destroy : MonoBehaviour
{
    // Уничтожаем игровой объект при запуске игры
    void Start()
    {
        Destroy(gameObject);  // Уничтожаем объект, к которому прикреплен этот скрипт
    }
}
