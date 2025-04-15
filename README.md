# Gerenciador de Compromissos

Este é um projeto simples de **Gerenciador de Compromissos** desenvolvido em C# utilizando conceitos de **Programação Orientada a Objetos (POO)**.

## Funcionalidades

- Permite registrar compromissos com data e hora.
- Valida a data e hora informadas:
  - A data deve estar no formato `dd/MM/yyyy` e não pode ser anterior à data atual.
  - A hora deve estar no formato válido e, se o compromisso for para o dia atual, não pode ser anterior à hora atual.
- Exibe mensagens de erro amigáveis para entradas inválidas.

## Estrutura do Projeto

- **`Program.cs`**: Contém o ponto de entrada do programa e a lógica de interação com o usuário.
- **`Modelos/Compromisso.cs`**: Define a classe `Compromisso`, responsável por armazenar e validar os dados do compromisso.

## Como Usar

1. Clone este repositório:
   ```bash
     git clone https://github.com/seu-usuario/poo.git
   ```
2. Navegue até a pasta do projeto:

   ```bash
   cd poo/GerenciadorDeCompromissos
   ```

3. Compile e execute o programa:
   ```bash
   dotnet run
   ```
