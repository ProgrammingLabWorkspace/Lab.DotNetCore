# Introdução ao git

## Sistema de controle de versão (VCS - Version Control System)

Monitora uma coleção de arquivos e, para cada modificação, permite descrever o que foi modificado. Além disso, cada modificação fica vinculada a uma pessoa, sendo possível saber quem foi e o porquê ela fez aquela modificação. 

- Também é conhecido como `Software Configuration Management (SCM)`;
- Pode ser usado não somente para desenvolvimento de software, mas também para a escrita de documentação;
- Com um controle de versão é possível todas as mudanças do projeto e pontos importantes, como publicações (releases);
- **Git é um exemplo de VCS**;

## Controle de versão distribuído

Inicialmente, instâncias de sistemas de controle de versão, como: CVS, Subversion (SVN) e perforce, centralizavam o histórico de um projeto em um único servidor.

### Git é distribuído

Git armazena o projeto no cliente e no servidor. Se o servidor cair, o projeto e o seu histórico de modificações ainda estariam disponíveis localmente. Além disso, mesmo que o servidor esteja fora, ainda é possível seguir trabalhando no projeto e fazendo `commits` localmente.

## Terminologia do Git

- **Working tree**: conjunto de diretórios e arquivos do projeto;
- **Repository (Repo)**: diretório, localizado na raiz do projeto (working tree), local onde o git mantém o histórico e os metadados do projeto;
    - **Bare Repository**: Usado para compartilhamento e backup;
- **Hash**: Número gerado por função hash e que representa o conteúdo de um arquivo ou outro objeto. Git utiliza hashes de 160 bits. O Git sabe se houve modificações em um arquivo com base no hash. Toda vez que o conteúdo do arquivo é modificado, o hash do conteúdo é diferente, logo, usando essa estratégia, o git consegue identificar modificações;
- **Object**: Um repositório git possui quatro tipo de objetos, sendo cada um identificado por um nome único (SHA-1).
    - **blob**: Contém um arquivo comum;
    - **tree**: Representa um diretório; contém nomes, hashes e permissões;
    - **commit**: Representa uma versão especifica do **working tree**;
    - **tag**: Nome vinculado a um commit.
- **Commit**: Representa a ação de descrever e enviar as modificações;
- **Branch**: Uma branch é uma série nomeada de commits vinculados. **O commit mais recente em uma branch é chamado de head**. Quando um repositório é criado, por padrão, a branch criada é chamada `main` (anteriormente usava-se o termo `master`). As branches permitem que vários desenvolvedores trabalhem juntos ou independentes e depois façam um `merge` de suas modificações na branch principal.
- **Comandos, subcomandos e opções**: Git é operado com comandos, como `git push` e `git pull`. `git` é o comando e `push` ou `pull` são os subcomandos. **Os subcomandos definem o que o git deve realizar**. Comandos são acompanhados por opções, como: `git reset --hard`. `--hard` é uma opção para o comando. Opções utilizam um único hífen ou duplo hífen;


# Observações

- O git não monitora e não deixa commitar diretórios vazios. Caso queira commitar um diretório, 
crie dentro dele um arquivo chamado `.git-keep`;
- Usar o `git rm` fará com que o git remova o arquivo não permita restaura-lo via `checkout`. Caso precisa reverter, use o comando
`git reset HEAD nome_arquivo`;


# Referências

https://www.youtube.com/watch?v=9uGS1ak_FGg
https://learn.microsoft.com/en-us/credentials/certifications/github-foundations/?practice-assessment-type=certification