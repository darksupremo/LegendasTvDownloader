[![GitHub issues](https://img.shields.io/github/issues/DarkSupremo/LegendasTvDownloader.svg?maxAge=60&style=flat-square)](https://github.com/DarkSupremo/LegendasTvDownloader/issues)
[![GitHub pull requests](https://img.shields.io/github/issues-pr/DarkSupremo/LegendasTvDownloader.svg?maxAge=60&style=flat-square)](https://github.com/DarkSupremo/LegendasTvDownloader/pulls)
[![Github Releases](https://img.shields.io/github/downloads/DarkSupremo/LegendasTvDownloader/total.svg?maxAge=60&style=flat-square)](https://github.com/DarkSupremo/LegendasTvDownloader/releases/latest)

Legendas.Tv Downloader
====================

Descrição
-----------
Com este programa, através de um simples click com botão direito no arquivo de filme ou seriado, você encontra e baixa a legenda sem precisar entrar em nenhum site!

Se o arquivo que você mandou baixar conter uma legenda com nome igual ao do filme/serie, ele irá automaticamente extrair apenas aquela legenda e apagar o .rar, caso contrário irá manter o .rar pra você escolher!

A legenda / rar será baixada pra pasta atual do filme/série.

Este programa contém algorítimos pra identificar o nome original do filme ou série mesmo que o arquivo tenha sido renomeado!

Fiz este programa em apenas 2 dias, se gostarem ou encontraram problemas, comentem!


3.2
-----------
- Adicionado sistema de login para o Legendas.tv

3.0 / 3.1
-----------
- Adicionado monitoramento de legendas ainda não lançada, aviso será entregue por email e não precisa deixar o software rodando, veja: http://i.imgur.com/VD9AUL4.png
- Software modificado pra utilizar um web service remoto também desenvolvido por mim pra realizar as buscas ao invés de fazer localmente através de http requests.
= Vantagens:
+ Em caso de modificações no legendas.tv ou legendasbrasil não precisará de um novo update pra fazer voltar a funcionar.
+ Adicionado um cache de 5 minutos no servidor pra buscas iguais, evitando sobrecarga no meu servidor (gratuito/openshift) e também no do legendas.tv/legendasbrasil
+ Buscas mais rápidas, pois utiliza o servidor que tem uma internet bem melhor que a brasileira pra fazer as requisições http.
+ O cliente agora faz apenas uma requisição no formato JSON ao invés de 4-5 requisições no formato HTTP em sites diferentes (Legendas.tv / Legendasbrasil / IMDB)

2.4
-----------
- Desativado mensagem de debug que esqueci de desativar na 2.3

2.3
-----------
- Corrigido problemas devido a mudanças no site do Legendas.tv

2.2
-----------
- Corrigido problemas devido a mudanças no site do Legendas.tv (eles não se decidem? dessa vez mudaram a url da busca.. deve ter quebrado compatibilidade com vários programas externo..)

2.1
-----------
- Melhorado ação do botão "enter", agora se pressionado enquanto estiver com algo da lista selecionado, irá baixar automaticamente, e se tiver com foco no campo de busca, irá buscar manualmente...
- Corrigido bug que não exibia mensagem informando que tinha sido baixado com sucesso em caso de buscar apenas 1 arquivo.
- Corrigido problemas devido a mudanças no site do Legendas.tv (novamente)

2.0
-----------
- Corrigido problemas devido a mudanças no site do Legendas.tv

1.9
-----------
- Adicionado nova entrada no botão direito: "Baixar melhor legenda (suporta multiplos)" que irá baixar a melhor legenda automaticamente, suporta busca selecionando vários arquivos também!!
- Renomeado entrada de "Buscar via Legendas.tv" para "Buscar legenda"

1.8
-----------
- Ao pressionar o botão 'Enter' irá automaticamente baixar as legendas selecionadas.

1.7
-----------
- Corrigido crash causado ao baixar legenda via LegendasBrasil.

1.6
-----------
- Corrigido alguns bugs.
- Adicionado suporte para mais um mecanismo de busca: LegendasBrasil.com.br 
OBS 1: LegendasBrasil apenas para busca automática pelo menu de contexto, manual continua apenas o legendas.tv, usado o mesmo método que usam no software deles
OBS 2: Legendas.tv tem prioridade no método de detecção da seleção automática de melhor legenda.

1.5
-----------
- Corrigido travamento ao baixar legendas simultaneamentes.
- Adicionado suporte pra baixar multiplas legendas ao mesmo tempo.
- Adicionado algoritimo pra detectar se o arquivo com mesmo nome já existe e adicionar (1), (2)...etc.
- Programa não irá mais finalizar sozinho após baixar a legenda (caso tenha aberto pelo menu de contexto), pra caso queira tentar baixar outros...

1.4
-----------
- Adicionado opção para baixar Poster.
- Corrigido bug gerado na versão 1.3 com extração da legenda.

1.3
-----------
- Corrigido vários bugs
- Adicionado algorítimo para tentar detectar a legenda correta que deve ser baixado e seleciona-la por padrão (caso buscado pelo menu de contexto)
- Adicionado alerta de novas versões disponíveis e link para baixa-la
- Corrigido bug em caso de conter acentos dentro do rar, como a biblioteca que uso pra extrair não suporta acentos, nesses casos o rar será mantido para extração manual.
- Caso tenha sido feito busca através do menu de contexto e não tenha encontrado a legenda correspondente após o download, o rar agora terá o mesmo nome do arquivo ao invés do nome original (para facilitar localização)


1.2
-----------
- Corrigido vários bugs
- Adicionado opção de carregar mais legendas (ao invés de apenas a primeira página como era)
- Melhorado algorítimo, está mais rápido e preciso agora.


1.1
-----------
- Adicionado suporte para busca manual executando direto pelo LegendasTv.exe


1.0
-----------
- versão inicial


Fotos
-----------

![qjlxmi9](http://i.imgur.com/nMXrIBN.png)
![mfiktup](https://f.cloud.github.com/assets/7059651/2514293/bd52fbd2-b437-11e3-9ed6-478533167105.png)


Baixar: https://github.com/DarkSupremo/LegendasTvDownloader/releases
