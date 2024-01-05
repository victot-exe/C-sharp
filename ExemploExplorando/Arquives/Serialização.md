# Serialização
Consiste em transformar obejtos em um fluxo de bytes para seu armazenamento ou transmissão.
## Deserialização
Processo inverso a serialização.
### Atributos
* Quando o nome no arquivo for de uma convenção de nomenclatura diferente fazemos assim->
~~~
[JsonProperty("Nome_no_arquivo)]//atributo no arquivov .json
public string Produto{get; set;}//propriedade no código
~~~

## JSON
* **JavaScript Notation Object** -> é um formato de texto que segue a sintaxe **JS**, usado para transmitir dados entre apps.
* Possibilita a troca de informações entre diferentes linguagens.  
[JSON Viewer](https://www.codebeautift.org)
* Para ele transferir as datas ele usa o *ISO 8601* que é o formato oficial para a representação de datas.