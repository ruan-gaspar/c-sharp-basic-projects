Ruan Nunes Gaspar RM 559567 2TDSPA 
Rodrigo Paes Morales RM 560209 2TDSPA
``
dotnet publish -c Release -r win-x64 --self-contained true /p:PublishSingleFile=true /p:PublishTrimmed=false
``

# Calculadora Windows Forms

## Descrição
Este projeto é uma calculadora simples criada com C# usando Windows Forms.  
Ela suporta as operações básicas: adição, subtração, multiplicação, divisão, exponenciação 
e radiciação.

## Funcionalidades
- Adição, subtração, multiplicação e divisão
- Potência (x²)
- Raiz quadrada (√)
- Suporte a números decimais
- Interface gráfica com botões e display de resultados

## Tecnologias
- C# (.NET 9)
- Windows Forms

## Como usar
1. Clone ou baixe o projeto.
2. Abra a solução (`.sln`) no Visual Studio.
3. Compile e execute (`F5` ou botão de **Start**).
4. Use os botões da interface para realizar operações.

## Estrutura do projeto
- `Form1.cs` → Contém a lógica da calculadora.
- `Form1.Designer.cs` → Define a interface gráfica.
- `Program.cs` → Ponto de entrada da aplicação.

Aprendizado Pessoal: nesse projeto pude compreender o básico da programação em CSharp, 
implementando não apenas a lógica dos cálculos mas usando estruturas básicas de controle 
de fluxo, manipulação de eventos, tratamento de erros simples que poderiam quebrar a 
aplicação e interação com a interface gráfica do Windows Forms.  