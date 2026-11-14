# BLITZ — Diretrizes de Preservação

## Contexto do projeto
- **Projeto:** BLITZ  
- **Caminho:** `C:\Users\Adm\Desktop\EQuittoGD2\eduardoquittogd2\EQuittoGD2`  
- **Unity Editor:** 6000.3.7f1  
- **Unity CLI:** 1.0.0  

## Princípio fundamental
O projeto BLITZ deve manter sua arquitetura, identidade visual, mecânicas, hierarquia de objetos e direção de desenvolvimento originais.

## Regras obrigatórias para qualquer alteração
1. Não fazer refatorações gerais, reestruturações, substituições de sistemas ou melhorias não solicitadas.
2. O objetivo é corrigir bugs específicos com alterações mínimas e localizadas.
3. Não alterar outros sistemas para facilitar a implementação.
4. Não considerar uma solução válida se ela corrigir um problema criando outro.
5. Em caso de dúvida, preservar o comportamento original e apresentar o diagnóstico sem realizar alterações especulativas.

## Fluxo obrigatório para cada bug
1. Identificar a causa raiz.
2. Localizar o menor trecho de código ou configuração responsável.
3. Explicar a alteração proposta.
4. Modificar somente o necessário.
5. Comparar o resultado com o comportamento original.
6. Testar e documentar o resultado.

## Estado conhecido da última sessão
- Branch: `fix/estabilizacao-visual` (base: `ab9a982ce55211b6822bac88eeb4fb27ba4b3a61`)
- Nenhum commit realizado após as correções
- Arquivos modificados na sessão anterior:
  - `Assets/Scripts/FaceCamera.cs` (correção escala zero)
  - `Assets/Scripts/EnemyController.cs` (correção escala hpBar)
  - `Assets/Scripts/PlayerController.cs` (correção canhão + null check playerInput)
  - `Assets/Scenes/Game.unity` (maxRotationX serializado)
- Alterações pré-existentes preservadas (áudio, rotação player, Victory.unity)
