# AutoBackup
[English version of the site](joeBiden.md)
## Introdução
AutoBackup é uma ferramenta criada usando [winForms](https://www.google.com/search?q=winForms), ela serve para facilitar o backup de arquivos enquanto você trabalha em um projeto, o AutoBackup é uma ferramenta gratuita e usa a licensa Creative Commons Legal Code, isso siginifica que você pode usar o codigo dela para quaisquer fins não comerciais

### Downloads
[AutoBackup 1.0](pudim.com.br) <br>
[AutoBackup PHP](pudim.com.br)

## Uma olhada no codigo
>Aconcelho saber c# primeiramente para entender melhor o codigo 👍

**Como foi feito:** <br>
- [Uso do CMD no winForms](#cmd-no-winforms)
- [Redirecionar para sites](#recirecionar-para-sites)
- [Fazer o Backup](#fazer-o-backup)
- [Entrada Rapida (AutoBackup PHP](#entrada-rapida-php)
- [Uso do CMD no winForms](pudim.com.br)

### CMD no winForms
```C#
void executeCmd(string command)
{
  Process process = new Process();
  process.StartInfo.FileName = "CMD.exe"; 
  process.StartInfo.CreateNoWindow = !mostrarCmd; 
  process.StartInfo.Arguments = "/C " + command; //Usa "/C <comando>" como parametro de inicialização
  process.StartInfo.UseShellExecute = false; //Necessario para o CreateNoWindow funcionar
  
  process.Start(); //Cria 
  process.WaitForExit(); //Espera
  process.Close(); //Fecha
}
```

Primeiramente precisamos criar um objeto com da classe `Processo`
```C#
Process process = new Process();
```

Iremos iniciar o CMD do computador, então definimos ele com o arquivo usado
```C#
process.StartInfo.FileName = "CMD.exe"; 
```

Com isso temos que definir como o CMD ira ser iniciado, então definimos que ele ira iniciar iniciar sem mostrar uma janela para ser mais limpo para o usuario 
```C#
process.StartInfo.UseShellExecute = false; //Necessario para o CreateNoWindow funcionar
process.StartInfo.CreateNoWindow = !mostrarCmd; 
```
>Estamos usando o inverso da variavel `mostrarCmd` pois se queremos mostrar ele, então falamos para o programa não esconder a janela e vice versa

Após isso, nos definimos com que parametros o CMD será iniciado, é necessario colocar `/C` antes do comando para o CMD saber que ele tem que executar o comando
```C#
process.StartInfo.Arguments = "/C " + command;
```

Com isso tudo definido nós simplesmente Iniciamos o CMD, esperamos ele executar o comando, e depois fechamos ele
```C#
process.Start(); //Cria 
process.WaitForExit(); //Espera
process.Close(); //Fecha
```
Agora para podermos usar o CMD só usamos o methodo `executeCmd(comandoMuitoLegal);` para fazermos o comando 
### Recirecionar para sites
A parte mais dificil é fazer uma maneira de usar o CMD, porem com ele podemos fazer muitas coisas, como abrir paginas da web, veja no exemplo como que usariamos o cmd para ir a uma pagina web
```Batchfile
start "https://laggh.github.io/AutoBackup/#AutoBackup"
```

Com o sistema do CMD ja funcionando, iremos apenas chamar o metodo e colocar o comando
```C#
executeCmd("start \"https://laggh.github.io/AutoBackup/#AutoBackup\"");
```
>colocamos `\` antes das aspas para o C# não achar que estamos finalizando a string, as aspas são para o CMD

### Fazer o backup
Agora que ja sabemos como umar o `executeCmd()` conseguimos fazer o metodo de backup em si, para copiar uma pasta inteira para outro lugar iremos usar o comando `XCOPY`, sua ele funciona assim:  
```Batchfile
xcopy "LocalDeOrigem" "LocalDeDestino"
```

porem nós iremos colocar alguns parametros extras, veja abaixo oque eles fazem:

| Parametro   | Descrição |
| -  | ----------- |
| /s | Copia todas as pastas e até pastas dentro de outras pastas   |
| /e | Copia até pastas vazias                                      |
| /y | Sobreescreve arquivos no destino sem confirmação do usuario  |

Então para rodar o comando nós fazemos esse codigo

```Batchfile
xcopy /s /e /y "LocalDeOrigem" "LocalDeDestino"
```

Que quando traduzido para c# ficará como
```C#
executeCmd("xcopy /s /e /y " + origin + " " + backup);
```
>`origin` e `backup` são as variaveis que estamos usando

### Entrada Rapida (PHP)
