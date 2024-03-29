# API de Lista de Tarefas

## Descrição
Esta API fornece um conjunto de recursos para gerenciar uma lista de tarefas. Você pode criar, ler, atualizar e excluir tarefas, além de marcá-las como concluídas.

## Funcionalidades
- Criar tarefas
- Ler tarefas
- Atualizar tarefas
- Excluir tarefas
- Marcar tarefas como concluídas


## Instalação
- Certifique-se de ter o .NET SDK instalado em sua máquina. Você pode baixar o SDK em https://dotnet.microsoft.com/download.

- A versão do .NET que esta nesse Projeto é o .NET 6.0

- O comando específico para instalar o .NET 6.0 pelo terminal depende do sistema operacional que você está usando.

### No Windows:
- Com PowerShell:
```bash
  Set-ExecutionPolicy RemoteSigned -Scope CurrentUser
  Install-Module dotnet
  Import-Module dotnet
  Install-Package dotnet-sdk-6.0
  ```
  - Com Prompt de Comando:

```bash  
dotnet-install.ps1 -InstallSDK 6.0
```
### No macOS:
```bash  
brew install dotnet/core/dotnet-sdk6
```
### No Linux:

- Com Ubuntu:
```bash  
wget https://packages.microsoft.com/config/ubuntu/20.04/packages-microsoft-prod.deb -O packages-microsoft-prod.deb
sudo dpkg -i packages-microsoft-prod.deb
rm packages-microsoft-prod.deb
sudo apt-get update
sudo apt-get install dotnet-sdk-6.0
```
- Com outras distros:
- Consulte a documentação do .NET para obter instruções específicas para sua distro: https://docs.microsoft.com/pt-br/dotnet/core/install/linux.

### Observações:

- Certifique-se de ter um gerenciador de pacotes instalado em sua máquina.
- O comando dotnet-install.ps1 só está disponível no Windows.
- O comando brew só está disponível no macOS.
- Os comandos para Linux podem variar dependendo da sua distro.


### Clonar o repositorio
```bash
git clone https://github.com/Mizaeldouglas/todoApi-AspNet.git
```
### Iniciar o projeto na sua maquina

```bash
  dotnet restore
  dotnet build
  dotnet run
```
