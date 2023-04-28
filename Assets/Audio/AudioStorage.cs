using System.Collections;
using System.Collections.Generic;
using UnityEngine;


[CreateAssetMenu (fileName ="AudioStorage", menuName = "cards/AudioStorage", order =0)]
public class AudioStorage : ScriptableObject
{
    // 1 - Crear AudioClips publicos individuales o un array publico, no importa.
    // 2 - En la carpeta Audio/AudioStorage, click al objeto AudioStorage y para ir asignando en el inspector los clips de audio.
    // 3 - para usar en el script, se crea una variable publica o [SerializedField] de tipo AudioStorage, y se arrasta el objeto donde esta los clips para empezar a llamar.
}
