# Desafios em C#

Este repositório contém a resolução de uma série de desafios técnicos implementados em C#. Cada desafio foi organizado em um arquivo separado para facilitar a compreensão e execução.

---

## Desafios Resolvidos

### 1. Valor da variável `SOMA`

**Descrição:**
Dado o trecho de código abaixo:
```csharp
int INDICE = 13, SOMA = 0, K = 0;
Enquanto K < INDICE faça {
    K = K + 1;
    SOMA = SOMA + K;
}
Imprimir(SOMA);
```
Implemente o código e calcule o valor final da variável `SOMA`.

**Arquivo:** [Questao1/Program.cs](./Questao1/Program.cs)

---

### 2. Sequência de Fibonacci e verificação

**Descrição:**
Implemente um programa que, dado um número informado pelo usuário, calcule a sequência de Fibonacci e retorne uma mensagem informando se o número pertence ou não à sequência.

**Arquivo:** [Questao2/Program.cs](./Questao2/Program.cs)

---

### 3. Faturamento diário de uma distribuidora

**Descrição:**
Com base em um arquivo JSON contendo o faturamento diário, implemente um programa que calcule:
- O menor valor de faturamento em um dia do mês;
- O maior valor de faturamento em um dia do mês;
- O número de dias em que o faturamento foi superior à média mensal.

**Arquivo:** [Questao3/Program.cs](./Questao3/Program.cs)

**Fonte de Dados:** [faturamento.json](./Questao3/faturamento.json)

---

### 4. Percentual de faturamento por estado

**Descrição:**
Dado o faturamento mensal de uma distribuidora detalhado por estado:
- SP – R$67.836,43
- RJ – R$36.678,66
- MG – R$29.229,88
- ES – R$27.165,48
- Outros – R$19.849,53

Implemente um programa que calcule o percentual de representação de cada estado no total mensal.

**Arquivo:** [Questao4/Program.cs](./Questao4/Program.cs)

---

### 5. Inversão de string

**Descrição:**
Implemente um programa que inverta os caracteres de uma string sem utilizar funções prontas (como `Reverse`).

**Arquivo:** [Questao5/Program.cs](./Questao5/Program.cs)

---

## Como Executar

1. Clone o repositório:
   ```bash
   git clone https://github.com/seuusuario/DesafiosEmCSharp.git
   ```

2. Navegue até a pasta do desafio que deseja executar. Por exemplo, para a questão 1:
   ```bash
   cd DesafiosEmCSharp/Questao1
   ```

3. Compile e execute o código utilizando o .NET CLI:
   ```bash
   dotnet run
   ```

---

## Tecnologias Utilizadas

- Linguagem: C#
- Framework: .NET 9 
- IDE recomendada: Visual Studio ou Visual Studio Code

---

## Contribuição

Contribuições são bem-vindas! Sinta-se à vontade para abrir issues ou enviar pull requests para melhorar o código ou adicionar novos desafios.

---

## Autor

Este projeto foi desenvolvido por [Charles Melo](https://github.com/CharlesMeloBC).
